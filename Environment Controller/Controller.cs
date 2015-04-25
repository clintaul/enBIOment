using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment_Controller
{
    public class Controller
    {

        private Double bodyTemperature;
        private Byte[] bodyTemperatureRawData;
        private Double[] bodyTemperatureHistory;
        private Double heartRate;
        private Double heartRateAverage;
        private Byte[] heartRateRawData;
        private Double[] heartDataHistory;
        private Double[] heartRateHistory;
        private Int32 xAxis;
        private Int32 yAxis;
        private Int32 zAxis;
        private Double[] xAxisHistory;
        private Double[] yAxisHistory;
        private Double[] zAxisHistory;
        private Byte[] accelerometerRawData;

        private Int16 hrState;
        private Int16 activityState;
        private Int16 tempState;

        private Boolean autoControl;

        private int TransmitRate = 4;                   //per second
        private int HistoryDuration = 10;             //seconds 
        private int HRHistoryDuration = 3;            //seconds
        private int HRSamplesPerTransmit = 8;
        private int ArrayLength;
        private int HRArrayLength;

        private Double lightIntensityOffset;
        private Double lightIntensityBaseline;
        private Double lightEffect;
        private Double newLightIntensity;

        private Double musicVolumeOffset;
        private Double musicVolumeBaseline;
        private Double musicVolumeEffect;
        private Double newMusicVolume;

        private Int16 roomTemperatureOffset;

        public Controller()
        {
            ArrayLength = TransmitRate * HistoryDuration;
            HRArrayLength = HRHistoryDuration * TransmitRate * HRSamplesPerTransmit;


            bodyTemperature = 0;
            bodyTemperatureRawData = new Byte[]{0x00};
            heartRate= 0;
            heartRateRawData = new Byte[] { 0x00 };
            xAxis= 0;
            yAxis= 0;
            zAxis = 0;
            accelerometerRawData = new Byte[] { 0x00 };

            heartDataHistory = new Double[(HRArrayLength)];
            heartRateHistory = new Double[ArrayLength];
            bodyTemperatureHistory = new Double[ArrayLength];
            xAxisHistory = new Double[ArrayLength];
            yAxisHistory = new Double[ArrayLength];
            zAxisHistory = new Double[ArrayLength];

            lightIntensityBaseline = 0;
            lightIntensityOffset = 0;
            lightEffect = 0;
            newLightIntensity = 0;

            musicVolumeBaseline = 0;
            musicVolumeOffset = 0;
            musicVolumeEffect = 0;
            newMusicVolume = 0;

            roomTemperatureOffset = 0;

            autoControl = true;

            tempState = 0;
            activityState = 0;
            hrState = 0;

            for (int i = 0; i < ArrayLength; i++)
            {
                bodyTemperatureHistory[i] = 70.0;
            }
            for (int j = 0; j < HRArrayLength; j++)
            {
                heartDataHistory[j] = 70;
            }
            for (int k = 0; k < ArrayLength; k++)
            {
                heartRateHistory[k] = 70;
            }
        }
        private void CalculateHeartRate()
        {

            Double average = heartDataHistory.Average();
            Double sumOfSquaresOfDifferences = heartDataHistory.Select(val => (val - average) * (val - average)).Sum();
            Double sd = Math.Sqrt(sumOfSquaresOfDifferences / heartDataHistory.Length);
            Double diff = 0.0;
            int iprevious = 0;
         
            for (int i = 2; i < HRArrayLength - 2; i++)
            {
                if (heartDataHistory[i] > (average + sd))
                {
                    if ((heartDataHistory[i] > heartDataHistory[i + 1]) && (heartDataHistory[i] > heartDataHistory[i - 1]))
                    {
                        //if ((heartDataHistory[i] > heartDataHistory[i + 2]) && (heartDataHistory[i] > heartDataHistory[i - 2]))
                        //{
                            //if ((heartDataHistory[i] > heartDataHistory[i + 3]) && (heartDataHistory[i] > heartDataHistory[i - 3]))
                            //{
                                if (iprevious == 0)
                                {
                                    iprevious = i;
                                }
                                else
                                {
                                    diff = i - iprevious;
                                    
                                    if (diff > 45)
                                    {
                                        iprevious = 0;
                                    }
                                    else if(diff > 14)
                                    {
                                        for (int j = 0; j < ArrayLength - 1; j++)
                                        {
                                            heartRateHistory[j] = heartRateHistory[j + 1];
                                        }
                                        heartRateHistory[ArrayLength - 1] = ((60.0 * 32.0) / diff); // heartRate;
                                        heartRateAverage = heartRateHistory.Average();
                                    }
                                //}
                            //}
                        }
                    }
                }
            }
            if (heartRateAverage < 75)   //<75  90>
            {
                hrState = 0;
            }
            else if ((heartRateAverage >= 75) && heartRateAverage < 90)
            {
                hrState = 1;
            }
            if (heartRateAverage >= 90)   //<75  90>
            {
                hrState = 3;
            }
        }
        private void CalculateBodyTemp()
        {
            bodyTemperature = bodyTemperatureHistory.Average();
            CalculateBodyTempState();
        }
        private void CalculateBodyTempState()
        {
           
            if (bodyTemperature > 94) 
            {
                tempState = -3;
            }
            else if ((bodyTemperature > 90) && (bodyTemperature <= 94))
            {
                tempState = -2;
            }
            else if ((bodyTemperature > 86) && (bodyTemperature <= 90))
            {
                tempState = -1;
            }
            else if ((bodyTemperature > 82) && (bodyTemperature <= 86))
            {
                tempState = 0;
            }
            else if ((bodyTemperature > 77) && (bodyTemperature <= 82))
            {
                tempState = 1;
            }
            else if ((bodyTemperature > 74) && (bodyTemperature <= 77))
            {
                tempState = 2;
            }
            else if ((bodyTemperature > 70) && (bodyTemperature <= 74))
            {
                tempState = 3;
            }
          
        }
        private void CalculateAccelerometer()
        {
            //24.6 == rest

            Double temp = 0.075 * ((xAxisHistory.Average() + yAxisHistory.Average() + zAxisHistory.Average() - 62) / 3);
            if (temp > 2.1) { activityState = 3; }
            else if (temp > 1.4) { activityState = 2; }
            else if (temp > 1.0) { activityState = 1; }
            else { activityState = 0; }
        }

        public void CalculateNewControlValues(Boolean systemModelingOn)
        {
            if(!systemModelingOn)
            {
                CalculateHeartRate();
                CalculateBodyTemp();
                CalculateAccelerometer();
                CalculateRoomTemperatureOffset();
            }
           
            CalculateLightIntensityOffset();
            CalculateMusicVolumeOffset();
           
        }

        public void UpdatePPGData(Byte[] data)
        {
            //d8 ff = ground;
            //ff 7f = 3.3v

            heartRateRawData = data;
            Int16[] temp = new Int16[HRSamplesPerTransmit];
            Array.Copy(heartDataHistory, HRSamplesPerTransmit, heartDataHistory, 0, HRArrayLength - HRSamplesPerTransmit);
            for (int i = 0; i < HRSamplesPerTransmit; i++)
            {
                temp[i] = BitConverter.ToInt16(data, (2*i));
                heartDataHistory[HRArrayLength - (HRSamplesPerTransmit - i)] = temp[i];
                Console.WriteLine(temp[i]);
            }     
        }
        public void UpdateBodyTempData(Byte[] data)
        {
            //DIVIDE BY 20.48
            //*1.8 + 32
            bodyTemperatureRawData = data;

            int temp = (data[1] << 8 | data[0])>>3;
            double bodytemp = ((((double)temp / 4096.0)*3.3) - 0.5) / 0.01 ;
            bodytemp = 2.1 * bodytemp + 30;

            Array.Copy(bodyTemperatureHistory,1, bodyTemperatureHistory,0, ArrayLength - 1);

            bodyTemperatureHistory[ArrayLength-1] = bodytemp;
        }
        public void UpdateAccelerometerData(Byte[] data)
        {
            accelerometerRawData = data;

            xAxis = Convert.ToInt32(data[0]);
            yAxis = Convert.ToInt32(data[1]);
            zAxis = Convert.ToInt32(data[2]);

            if (xAxis > 255 / 2)
            {
                xAxis = (-1*(255 + 1)) + xAxis;
            }
            if (yAxis > 255 / 2)
            {
                yAxis = (-1 * (255 + 1)) + yAxis;
            }
            if (zAxis > 255 / 2)
            {
                zAxis = (-1 * (255 + 1)) + zAxis;
            }

            Array.Copy(xAxisHistory, 1, xAxisHistory, 0, ArrayLength - 1);
            Array.Copy(yAxisHistory, 1, yAxisHistory, 0, ArrayLength - 1);
            Array.Copy(zAxisHistory, 1, zAxisHistory, 0, ArrayLength - 1);

            xAxisHistory[ArrayLength - 1] = Math.Abs(xAxis);
            yAxisHistory[ArrayLength - 1] = Math.Abs(yAxis);
            zAxisHistory[ArrayLength - 1] = Math.Abs(zAxis);
            
        }
     
        public void SetHeartRate(Double data)
        {
            heartRateAverage = data;
        }
        public void SetBodyTempData(Double data)
        {
            bodyTemperature = data;
            CalculateBodyTempState();
        }
        public void SetAccelerometerData(Int16 data)
        {
            activityState = data;
        }

        public void SetLightIntensityBaseline(Double data)
        {
            lightIntensityBaseline = data;
        }
        public void SetLightEffect(Double data)
        {
            lightEffect = data;
        }
        public void SetMusicVolumeBaseline(Double data)
        {
            musicVolumeBaseline = data;
        }
        public void SetMusicEffect(Double data)
        {
            musicVolumeEffect = data;
        }
        public void SetRoomTemperatureOffset(Int16 data)
        {
            roomTemperatureOffset = data;
            if (tempState > 3)
            {
                tempState = 3;
            }
            else if (tempState < -3)
            {
                tempState = -3;
            }
        }

        private void CalculateLightIntensityOffset()
        {
            if (autoControl)
            {
                
                lightIntensityOffset = 2*lightEffect*(activityState + hrState);
            }
            else
            {
                lightIntensityOffset = 0;
            }

            double temp = lightIntensityBaseline + lightIntensityOffset;
            if(temp > 100){newLightIntensity = 100;}
            else if (temp < 0) { newLightIntensity = 0; }
            else{newLightIntensity = temp;}
            
            
        }
        private void CalculateMusicVolumeOffset()
        {
            if(autoControl)
            {
                musicVolumeOffset = 2*musicVolumeEffect*(activityState+hrState);
            }
            else
            {
                musicVolumeOffset = 0;
            }
            double temp =  musicVolumeBaseline + musicVolumeOffset;
            if (temp > 100) { newMusicVolume = 100; }
            else if (temp < 0) { newMusicVolume = 0; }
            else { newMusicVolume = temp; }
        }
        private void CalculateRoomTemperatureOffset()
        {
            if(autoControl)
            {
                roomTemperatureOffset = (Int16)(tempState);
                if (tempState > 3)
                {
                    tempState = 3;
                }
                else if (tempState < - 3)
                {
                    tempState = -3;
                }
            }
            else
            {
                roomTemperatureOffset = 0;
            }
        }

        public Byte[] GetNewDimmerValue()
        {
            //Takes one byte from 0xF0 to 0xFF	
	        //FF --> brightest
	        //F0 --> darkest
            // 15 states
            double temp = (15 * (NewLightIntensity / 100));
            temp = 231 + (Int16)temp;

            byte result = Convert.ToByte(temp);

            return new Byte[] { result };

        }

        public Byte[] GetNewThermostatValue()
        {
           
            //Takes on byte data range from 0x00 to 0x07
	        //00 --> BLE does not affect thermostat
	        //01 --> BLE lowers the set temperature by 3 degrees F or 2 degree C
	        //02 --> BLE lowers the set temperature by 2 degrees F or 1 degree C
	        //03 --> BLE lowers the set temperature by 1 degrees F or 1 degree C
	        //04 --> BLE does not affect thermostat
	        //05 --> BLE increases the set temperature by 1 degrees F or 1 degree C
	        //06 --> BLE increases the set temperature by 2 degrees F or 1 degree C	
	        //07 --> BLE increases the set temperature by 3 degrees F or 2 degree C	

            Byte result = 0x04;
            
            switch (roomTemperatureOffset)
            {
                case -3:
                    result = 0x01;
                    break;
                case -2:
                    result = 0x02;
                    break;
                case -1:
                    result = 0x03;
                    break;
                case 0:
                    result = 0x04;
                    break;
                case 1:
                    result = 0x05;
                    break;
                case 2:
                    result = 0x06;
                    break;
                case 3:
                    result = 0x07;
                    break;
            }

            return new Byte[] {result};

        }

        public Double BodyTemperature
        {
            get { return bodyTemperature; }
        }
        public Double HeartRate
        {
            get { return heartRateAverage; }
        }
        public Double X_Axis
        {
            get { return xAxis; }
        }
        public Double Y_Axis
        {
            get { return yAxis; }
        }
        public Double Z_Axis
        {
            get { return zAxis; }
        }
        public Byte[] BodyTemperatureRawData
        {
            get { return bodyTemperatureRawData; }
        }
        public Byte[] HeartRateRawData
        {
            get { return heartRateRawData; }
        }
        public Byte[] AccelerometerRawData
        {
            get { return accelerometerRawData; }
        }
        public Double LightIntensityOffset
        {
            get { return lightIntensityOffset; }
        }
        public Double MusicVolumeOffset
        {
            get { return musicVolumeOffset; }
        }
        public Int16 RoomTemperatureOffset
        {
            get { return roomTemperatureOffset; }
        }
        public Double NewLightIntensity
        {
            get { return newLightIntensity; }
        }
        public Double NewMusicVolume
        {
            get { return newMusicVolume; }
        }
        public Boolean AutomaticControl
        {
            get { return autoControl; }
            set { autoControl = value; }
        }
        public Int16 ActivityState
        {
            get { return activityState; }
        }


        
    }
}
