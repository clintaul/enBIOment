using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace Environment_Controller
{
    public partial class MainForm : Form
    {
        public Bluegiga.BGLib bglib = new Bluegiga.BGLib();
        public Boolean isAttached = false;
        public Dictionary<string, string> portDict = new Dictionary<string, string>();

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        /* ================================================================ */
        /*                BEGIN MAIN EVENT-DRIVEN APP LOGIC                 */
        /* ================================================================ */

        public const UInt16 INPUT_STATE_STANDBY = 0;
        public const UInt16 INPUT_STATE_SCANNING = 1;
        public const UInt16 INPUT_STATE_CONNECTING = 2;
        public const UInt16 INPUT_STATE_FINDING_SERVICES = 3;
        public const UInt16 INPUT_STATE_FINDING_ATTRIBUTES = 4;
        public const UInt16 INPUT_STATE_LISTENING_MEASUREMENTS = 5;
        public const UInt16 INPUT_STATE_DISCONNECTING = 6;

        public const UInt16 OUTPUT_STATE_STANDBY = 0;
        public const UInt16 OUTPUT_STATE_SCANNING = 1;
        public const UInt16 OUTPUT_STATE_CONNECTING = 2;
        public const UInt16 OUTPUT_STATE_FINDING_SERVICES = 3;
        public const UInt16 OUTPUT_STATE_FINDING_ATTRIBUTES = 4;
        public const UInt16 OUTPUT_STATE_LISTENING_MEASUREMENTS = 5;
        public const UInt16 OUTPUT_STATE_DISCONNECTING = 6;

        public int musicPlayerID = 0;

        public Controller controller = new Controller();

        public Byte[] BLE3fAddress = { 0x3f, 0x67, 0x1b, 0x80, 0x07, 0x00 };
        public Byte[] BLE41Address = { 0x41, 0x67, 0x1b, 0x80, 0x07, 0x00 }; 
        public Byte[] SystemModelAddress = { 0xa8, 0x67, 0x1b, 0x80, 0x07, 0x00 };

        public Byte[] InputBLE113Address = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
        public Byte[] OutputBLE113Address = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public Int16 modelingActivityState;

        public UInt16 input_state = INPUT_STATE_STANDBY;        // current application state
        public UInt16 output_state = OUTPUT_STATE_STANDBY;        // current application state

        public Byte input_connection = 0xff;              // connection handle (will always be 0 if only one connection happens at a time)
        public Byte output_connection = 0xff;

        public UInt16 input_att_handlesearch_start = 65535;       // "start" handle holder during search
        public UInt16 input_att_handlesearch_end = 0;         // "end" handle holder during search

        public UInt16 output_att_handlesearch_start = 65535;       // "start" handle holder during search
        public UInt16 output_att_handlesearch_end = 0;         // "end" handle holder during search

        public UInt16 hr_handle = 0;
        public UInt16 hr_handle_ccc = 0;

        public UInt16 bodytemp_handle = 0;
        public UInt16 bodytemp_handle_ccc = 0;

        public UInt16 acc_handle = 0;
        public UInt16 acc_handle_ccc = 0;

        public UInt16 roomtemp_handle = 0;
        public UInt16 roomtemp_handle_ccc = 0;

        public UInt16 dimmer_handle = 0;
        public UInt16 dimmer_handle_ccc = 0;

        public UInt16 thermostat_handle = 0;
        public UInt16 thermostat_handle_ccc = 0;

        public Boolean input_ready = false;

        private Byte[] previousThermostatValue;
        private Byte[] previousDimmerValue;


        ////these could change
        //hr_handle = 12;
        //hr_handle_ccc = 13;
        //bodytemp_handle = 17;
        //bodytemp_handle_ccc = 18;
        //acc_handle = 21;
        //acc_handle_ccc = 22;

        public MainForm()
        {
            InitializeComponent();
            previousDimmerValue = new Byte[] { 0x00 };
            previousThermostatValue = new Byte[] { 0x00 };
        }

        public void ClearInputBoxes()
        {
            this.heartRateTextBox.Text = "";
            this.heartRateRawDataTextBox.Text = "";
            this.bodyTempTextBox.Text = "";
            this.tempRawDataTextBox.Text = "";
            this.accelXAxisTextBox.Text = "";
            this.accelXAxisRawDataTextBox.Text = "";
            this.accelYAxisTextBox.Text = "";
            this.accelYAxisRawDataTextBox.Text = "";
            this.accelZAxisTextBox.Text = "";
            this.accelZAxisRawDataTextBox.Text = "";
           
        }

        public void UpdateDataDisplay()
        {
            controller.CalculateNewControlValues(this.systemModelingRadioButtonInput.Checked);

            this.heartRateTextBox.Text = controller.HeartRate.ToString();
            this.heartRateRawDataTextBox.Text = ByteArrayToHexString(controller.HeartRateRawData);
            this.bodyTempTextBox.Text = controller.BodyTemperature.ToString();
            this.accelXAxisTextBox.Text = controller.X_Axis.ToString();
            this.accelYAxisTextBox.Text = controller.Y_Axis.ToString();
            this.accelZAxisTextBox.Text = controller.Z_Axis.ToString();
            this.lightIntensityOffsetTextBox.Text = controller.LightIntensityOffset.ToString();
            this.musicVolumeOffsetTextBox.Text = controller.MusicVolumeOffset.ToString();
            this.roomTemperatureOffsetTextBox.Text = controller.RoomTemperatureOffset.ToString();
            this.musicVolumeTextBox.Text = controller.NewMusicVolume.ToString();
            this.lightIntensityTextBox.Text = controller.NewLightIntensity.ToString();
            this.roomTempEffectFactorBar.Value = controller.RoomTemperatureOffset;
            this.roomTempEffectFactorTextBox.Text = controller.RoomTemperatureOffset.ToString();
            UpdateActivityDisplay(controller.ActivityState);

        }
        public void UpdateActivityDisplay(double activitystate)
        {
            switch (controller.ActivityState)
            {
                case 0:
                    this.activityOutputRadio1.Checked = true;
                    this.activityOutputRadio2.Checked = false;
                    this.activityOutputRadio3.Checked = false;
                    this.activityOutputRadio4.Checked = false;
                    break;
                case 1:
                    this.activityOutputRadio1.Checked = false;
                    this.activityOutputRadio2.Checked = true;
                    this.activityOutputRadio3.Checked = false;
                    this.activityOutputRadio4.Checked = false;
                    break;
                case 2:
                    this.activityOutputRadio1.Checked = false;
                    this.activityOutputRadio2.Checked = false;
                    this.activityOutputRadio3.Checked = true;
                    this.activityOutputRadio4.Checked = false;
                    break;
                case 3:
                    this.activityOutputRadio1.Checked = false;
                    this.activityOutputRadio2.Checked = false;
                    this.activityOutputRadio3.Checked = false;
                    this.activityOutputRadio4.Checked = true;
                    break;
            }
        }

#region BLE Events
        
        private void GAPScanResponseEvent(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
           //ONLY USED IF SCANNING BLUETOOTH FOR CONNECTION
            String log = String.Format("ble_evt_gap_scan_response: rssi={0}, packet_type={1}, sender=[ {2}], address_type={3}, bond={4}, data=[ {5}]" + Environment.NewLine,
              (SByte)e.rssi,
              e.packet_type,
              ByteArrayToHexString(e.sender),
              e.address_type,
              e.bond,
              ByteArrayToHexString(e.data)
              );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            // pull all advertised service info from ad packet
            List<Byte[]> ad_services = new List<Byte[]>();
            Byte[] this_field = { };
            int bytes_left = 0;
            int field_offset = 0;
            for (int i = 0; i < e.data.Length; i++)
            {
                if (bytes_left == 0)
                {
                    bytes_left = e.data[i];
                    this_field = new Byte[e.data[i]];
                    field_offset = i + 1;
                }
                else
                {
                    this_field[i - field_offset] = e.data[i];
                    bytes_left--;
                    if (bytes_left == 0)
                    {
                        if (this_field[0] == 0x02 || this_field[0] == 0x03)
                        {
                            // partial or complete list of 16-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(2).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x04 || this_field[0] == 0x05)
                        {
                            // partial or complete list of 32-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(4).Reverse().ToArray());
                        }
                        else if (this_field[0] == 0x06 || this_field[0] == 0x07)
                        {
                            // partial or complete list of 128-bit UUIDs
                            ad_services.Add(this_field.Skip(1).Take(16).Reverse().ToArray());
                        }
                    }
                }
            }

            if (e.sender[0] == InputBLE113Address[0])
            {
                // connect to this device
                Byte[] cmd = bglib.BLECommandGAPConnectDirect(e.sender, e.address_type, 0x20, 0x30, 0x100, 0); // 125ms interval, 125ms window, active scanning
                
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                bglib.SendCommand(serialPort, cmd);
                
                // update state
                input_state = INPUT_STATE_CONNECTING;
            }
            if (e.sender[0] == OutputBLE113Address[0])
            {
                // connect to this device
                Byte[] cmd = bglib.BLECommandGAPConnectDirect(e.sender, e.address_type, 0x20, 0x30, 0x100, 0); // 125ms interval, 125ms window, active scanning

                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                bglib.SendCommand(serialPort, cmd);

                // update state
                output_state = OUTPUT_STATE_CONNECTING;
            }

        }

        private void ConnectionStatusEvent(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            //Happens after we connect to BLE113

            String log = String.Format("ble_evt_connection_status: connection={0}, flags={1}, address=[ {2}], address_type={3}, conn_interval={4}, timeout={5}, latency={6}, bonding={7}" + Environment.NewLine,
               e.connection, e.flags, ByteArrayToHexString(e.address), e.address_type, e.conn_interval, e.timeout, e.latency, e.bonding);
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            if(e.address[0] == InputBLE113Address[0])
            {
                //Flag if connected
                if (e.flags == 0x05)
                {

                    // connected, now perform service discovery
                    input_connection = e.connection;

                    //Write to Log
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Connected to {0}", ByteArrayToHexString(e.address)) + Environment.NewLine); });

                    //Create Command
                    Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 }); // "service" UUID is 0x2800 (little-endian for UUID uint8array)

                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(serialPort, cmd);

                    ThreadSafeDelegate(delegate { this.connectedPanelInput.BackColor = System.Drawing.Color.PaleGreen; });
                    ThreadSafeDelegate(delegate { this.connectionStateBoxInput.Text = "Connection State: Connected"; });

                    // update state
                    input_state = INPUT_STATE_FINDING_SERVICES;

                }
            }
            if (e.address[0] == OutputBLE113Address[0])
            {
                //Flag if connected
                if (e.flags == 0x05)
                {

                    // connected, now perform service discovery
                    output_connection = e.connection;

                    //Write to Log
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Connected to {0}", ByteArrayToHexString(e.address)) + Environment.NewLine); });

                    //Create Command
                    Byte[] cmd = bglib.BLECommandATTClientReadByGroupType(e.connection, 0x0001, 0xFFFF, new Byte[] { 0x00, 0x28 }); // "service" UUID is 0x2800 (little-endian for UUID uint8array)

                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(serialPort, cmd);

                    ThreadSafeDelegate(delegate { this.connectPanelOutput.BackColor = System.Drawing.Color.PaleGreen; });
                    ThreadSafeDelegate(delegate { this.connectionStateBoxOutput.Text = "Connection State: Connected"; });

                    // update state
                    output_state = OUTPUT_STATE_FINDING_SERVICES;

                    ThreadSafeDelegate(delegate { outputTimer.Start(); });
                    

                }
            }
        
        }

        private void ConnectionDisconnected(object sender, Bluegiga.BLE.Events.Connection.DisconnectedEventArgs e)
        {
            
            String log = String.Format("ble_evt_connection_status: connection={0}, reason={1}" + Environment.NewLine, e.connection, e.reason);
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

           
            if(e.connection == input_connection)
            {
                input_connection = 0xff;
                ThreadSafeDelegate(delegate { this.connectedPanelInput.BackColor = System.Drawing.Color.OrangeRed; });
                ThreadSafeDelegate(delegate { this.connectionStateBoxInput.Text = "Connection State: Disconnected"; });
                input_state = INPUT_STATE_STANDBY;
                ThreadSafeDelegate(delegate { displayTimer.Stop(); });
                ThreadSafeDelegate(delegate { ClearInputBoxes(); });
            }
            if (e.connection == output_connection)
            {
                output_connection = 0xff;
                ThreadSafeDelegate(delegate { this.connectPanelOutput.BackColor = System.Drawing.Color.OrangeRed; });
                ThreadSafeDelegate(delegate { this.connectionStateBoxOutput.Text = "Connection State: Disconnected"; });
                output_state = OUTPUT_STATE_STANDBY;
            }            
        }

        private void ATTClientGroupFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.GroupFoundEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_group_found: connection={0}, start={1}, end={2}, uuid=[ {3}]" + Environment.NewLine,
              e.connection,
              e.start,
              e.end,
              ByteArrayToHexString(e.uuid)
              );
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            if (e.connection == input_connection)
            {

                //// our att_handle range is 9 to 22
                ////9-13 for HR, 12 is measurement, 13 is CChC
                ////14-18 for Temp, 17 is measurement, 18 is CCC
                ////19-22 for Accel, 21 is measurement, 22 is CCC

                // found "service" attribute groups (UUID=0x2800)
                //heart rate
                if (e.uuid.SequenceEqual(new Byte[] { 0x0D, 0x18 }))
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=0x180D: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                    if (e.start < input_att_handlesearch_start) { input_att_handlesearch_start = e.start; }
                    if (e.end > input_att_handlesearch_end) { input_att_handlesearch_end = e.end; }
                }
                //Temp
                if (e.uuid.SequenceEqual(new Byte[] { 0x09, 0x18 }))
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=0x1809: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                    if (e.start < input_att_handlesearch_start) { input_att_handlesearch_start = e.start; }
                    if (e.end > input_att_handlesearch_end) { input_att_handlesearch_end = e.end; }
                }
                //Accelerometer
                if (e.uuid[0] == 0x23 & e.uuid[1] == 0x9C)
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=0x9C23: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                    if (e.start < input_att_handlesearch_start) { input_att_handlesearch_start = e.start; }
                    if (e.end > input_att_handlesearch_end) { input_att_handlesearch_end = e.end; }
                }
            }

                if (e.connection == output_connection)
                {
                    //Thermostat
                    //9 = 61
                    //10 = 46
                    if( e.uuid.Length > 9)
                    {
                        if (e.uuid[9] == 0x61 & e.uuid[10] == 0x46)
                        {
                            ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=6146: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                            if (e.start < output_att_handlesearch_start) { output_att_handlesearch_start = e.start; }
                            if (e.end > output_att_handlesearch_end) { output_att_handlesearch_end = e.end; }
                        }

                        //Dimmer
                        //11 = 69
                        //12 = 4c 
                        if (e.uuid[12] == 0x4c & e.uuid[11] == 0x69)
                        {
                            ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute group for service w/UUID=694c: start={0}, end=%d", e.start, e.end) + Environment.NewLine); });
                            if (e.start < output_att_handlesearch_start) { output_att_handlesearch_start = e.start; }
                            if (e.end > output_att_handlesearch_end) { output_att_handlesearch_end = e.end; }
                        }
                    }
                }

        }

        private void ATTClientAttributeValueEvent(object sender, Bluegiga.BLE.Events.ATTClient.AttributeValueEventArgs e)
        {
            if (e.connection == input_connection && input_state == INPUT_STATE_LISTENING_MEASUREMENTS)
            {

                if (e.atthandle == hr_handle)
                {
                    ThreadSafeDelegate(delegate { controller.UpdatePPGData(e.value); });

                }

                if ( e.atthandle == bodytemp_handle)
                {
                    ThreadSafeDelegate(delegate { controller.UpdateBodyTempData(e.value); });
                }

                if (e.atthandle == acc_handle)
                {
                    ThreadSafeDelegate(delegate { controller.UpdateAccelerometerData(e.value); });
                }
                
            }
        }

        private void ATTClientProcedureCompletedEvent(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_procedure_completed: connection={0}, result={1}, chrhandle={2}" + Environment.NewLine,
                e.connection, e.result, e.chrhandle);
            Console.Write(log);
            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

            if (e.connection == input_connection)
            {
            // check if we just finished searching for services
            if (input_state == INPUT_STATE_FINDING_SERVICES)
            {
                if (input_att_handlesearch_end > 0)
                {

                    // found the Heart Rate service, so now search for the attributes inside
                    Byte[] cmd = bglib.BLECommandATTClientFindInformation(e.connection, input_att_handlesearch_start, input_att_handlesearch_end);

                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(serialPort, cmd);

                    input_state = INPUT_STATE_FINDING_ATTRIBUTES;
                }
                else
                {
                    ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'Heart Rate' service with UUID 0x180D" + Environment.NewLine); });
                }
            }

            // check if we just finished searching for attributes within the heart rate service
            else if (input_state == INPUT_STATE_FINDING_ATTRIBUTES)
            {

                // Heart Rate
                // (this is done by writing 0x0001 to the client characteristic configuration attribute)
                Byte[] cmd1 = bglib.BLECommandATTClientAttributeWrite(input_connection, hr_handle_ccc, new Byte[] { 0x01, 0x00 });
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd1.Length, ByteArrayToHexString(cmd1)) + Environment.NewLine); });
                bglib.SendCommand(serialPort, cmd1);

                System.Threading.Thread.Sleep(1500);
                               
                // Temperature
                // (this is done by writing 0x0001 to the client characteristic configuration attribute)
                Byte[] cmd2 = bglib.BLECommandATTClientAttributeWrite(input_connection, bodytemp_handle_ccc, new Byte[] { 0x01, 0x00 });
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd2.Length, ByteArrayToHexString(cmd2)) + Environment.NewLine); });
                bglib.SendCommand(serialPort, cmd2);

                System.Threading.Thread.Sleep(1500);
                
                // Accelerometer
                // (this is done by writing 0x0001 to the client characteristic configuration attribute)
                Byte[] cmd3 = bglib.BLECommandATTClientAttributeWrite(input_connection, acc_handle_ccc, new Byte[] { 0x01, 0x00 });
                // DEBUG: display bytes written
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd3.Length, ByteArrayToHexString(cmd3)) + Environment.NewLine); });
                bglib.SendCommand(serialPort, cmd3);

                // update state
                input_state = INPUT_STATE_LISTENING_MEASUREMENTS;
                }
            }

            if (e.connection == output_connection)
            {
                // check if we just finished searching for services
                if (output_state == OUTPUT_STATE_FINDING_SERVICES)
                {
                    if (output_att_handlesearch_end > 0)
                    {

                        // found the Heart Rate service, so now search for the attributes inside
                        Byte[] cmd = bglib.BLECommandATTClientFindInformation(e.connection, output_att_handlesearch_start, output_att_handlesearch_end);

                        // DEBUG: display bytes written
                        ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                        bglib.SendCommand(serialPort, cmd);

                        output_state = OUTPUT_STATE_FINDING_ATTRIBUTES;
                    }
                    else
                    {
                        ThreadSafeDelegate(delegate { txtLog.AppendText("Could not find 'LED' service" + Environment.NewLine); });
                    }
                }

                // check if we just finished searching for attributes within the heart rate service
                if (output_state == OUTPUT_STATE_FINDING_ATTRIBUTES)
                {
                    
                    // LED
                    Byte[] cmd = bglib.BLECommandATTClientReadByHandle(output_connection, dimmer_handle);
                    // DEBUG: display bytes written
                    ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });
                    bglib.SendCommand(serialPort, cmd);
                    output_state = OUTPUT_STATE_LISTENING_MEASUREMENTS;

                }
        }

        }

        private void ATTClientFindInformationFoundEvent(object sender, Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventArgs e)
        {
            String log = String.Format("ble_evt_attclient_find_information_found: connection={0}, chrhandle={1}, uuid=[ {2}]" + Environment.NewLine,
               e.connection, e.chrhandle, ByteArrayToHexString(e.uuid));
            Console.Write(log);

            ThreadSafeDelegate(delegate { txtLog.AppendText(log); });

           
            //heart rate measurement characteristic (UUID = 0x2A37)
            //Temperature Measurement (UUID = 0x2a1C)
            //Accelerometer Readings (UUID = 0x2a68)

        
            //Use for searching
            // check for heart rate measurement characteristic (UUID=0x2A37)
            if (e.uuid.SequenceEqual(new Byte[] { 0x37, 0x2A }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2A37: handle={0}", e.chrhandle) + Environment.NewLine); });
                hr_handle = e.chrhandle;
            }
            // check for subsequent client characteristic configuration (UUID=0x2902)
            else if (e.uuid.SequenceEqual(new Byte[] { 0x02, 0x29 }) && (hr_handle > 0 && hr_handle_ccc == 0))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2902: handle={0}", e.chrhandle) + Environment.NewLine); });
                hr_handle_ccc = e.chrhandle;
            }

            //Use for searching
            // check for bodytemp measurement characteristic (UUID=0x2A1C)
            if (e.uuid.SequenceEqual(new Byte[] { 0x1C, 0x2A }))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2A1C: handle={0}", e.chrhandle) + Environment.NewLine); });
                bodytemp_handle = e.chrhandle;
            }
            // check for subsequent client characteristic configuration (UUID=0x2902)
            else if (e.uuid.SequenceEqual(new Byte[] { 0x02, 0x29 }) && (bodytemp_handle > 0 && bodytemp_handle_ccc == 0))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2902: handle={0}", e.chrhandle) + Environment.NewLine); });
                bodytemp_handle_ccc = e.chrhandle;
            }
            //0xd3, 0x59
            //Use for searching
            // check for accelerometer measurement characteristic (UUID=0xd359)
            if (e.uuid[0] ==  0xd3 )
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2A68: handle={0}", e.chrhandle) + Environment.NewLine); });
                acc_handle = e.chrhandle;
            }
            // check for subsequent client characteristic configuration (UUID=0x2902)
            else if (e.uuid.SequenceEqual(new Byte[] { 0x02, 0x29 }) && (acc_handle > 0 && acc_handle_ccc == 0))
            {
                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("Found attribute w/UUID=0x2902: handle={0}", e.chrhandle) + Environment.NewLine); });
                acc_handle_ccc = e.chrhandle;
            }

            if (e.uuid.Length > 9)
            {
                //handle = 11
                if (e.uuid[7] == 0x61 & e.uuid[8] == 0x46)
                {
                    thermostat_handle = e.chrhandle;
                }

                //Dimmer handle =14
                //11 = 69
                //12 = 4c 
                if (e.uuid[10] == 0x4c & e.uuid[9] == 0x69)
                {
                    dimmer_handle = e.chrhandle;
                }
            }


        }



#endregion

#region GUI Events

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        { 
            
            // get a list of all available ports on the system
            portDict.Clear();
            
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
                //string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    portDict.Add(String.Format("{0}", queryObj["DeviceID"]), String.Format("{0} - {1}", queryObj["DeviceID"], queryObj["Caption"]));
                }
                // initialize COM port combobox with list of ports
                comboPorts.DataSource = new BindingSource(portDict, null);
                comboPorts.DisplayMember = "Value";
                comboPorts.ValueMember = "Key";
            }
            catch (ManagementException ex)
            {
                portDict.Add("0", "Error " + ex.Message);
            }
            
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (!isAttached)
            {
                txtLog.AppendText("Opening serial port '" + comboPorts.SelectedValue.ToString() + "'..." + Environment.NewLine);
                serialPort.PortName = comboPorts.SelectedValue.ToString();
                serialPort.Open();
                txtLog.AppendText("Port opened" + Environment.NewLine);
                isAttached = true;
                this.serialPortPanel.BackColor = System.Drawing.Color.PaleGreen;
                btnAttach.Text = "Detach";
            }
            else
            {
                txtLog.AppendText("Closing serial port..." + Environment.NewLine);
                serialPort.Close();
                txtLog.AppendText("Port closed" + Environment.NewLine);
                isAttached = false;
                this.serialPortPanel.BackColor = System.Drawing.Color.OrangeRed;
                btnAttach.Text = "Attach";
            }
        }

        private void connectedButtonInput_Click(object sender, EventArgs e)
        {
            ConnectBLE113(InputBLE113Address);
        }

        private void disconnectButtonInput_Click(object sender, EventArgs e)
        {
            DisconnectBLE113(input_connection);
        }

        private void connectButtonOutput_Click(object sender, EventArgs e)
        {
            ConnectBLE113(OutputBLE113Address);
        }

        private void disconnectButtonOutput_Click(object sender, EventArgs e)
        {
            DisconnectBLE113(output_connection);
        }

        private void inputTab_Click(object sender, EventArgs e)
        {

        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }

#endregion

#region Data Handlers
        // Thread-safe operations from event handlers
        // I love StackOverflow: http://stackoverflow.com/q/782274
        public void ThreadSafeDelegate(MethodInvoker method)
        {
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }

        // Convert byte array to "00 11 22 33 44 55 " string
        public string ByteArrayToHexString(Byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        // Serial port event handler for a nice event-driven architecture
        private void DataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort sp = (System.IO.Ports.SerialPort)sender;
            Byte[] inData = new Byte[sp.BytesToRead];

            try
            {
                   // read all available bytes from serial port in one chunk
                sp.Read(inData, 0, sp.BytesToRead);

                // DEBUG: display bytes read
                //ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("<= RX ({0}) [ {1}]", inData.Length, ByteArrayToHexString(inData)) + Environment.NewLine); });

                // parse all bytes read through BGLib parser
                for (int i = 0; i < inData.Length; i++)
                {
                    bglib.Parse(inData[i]);
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

#endregion

        private void ConnectBLE113(Byte[] address)
        {
            if (address == InputBLE113Address)
            {
                Byte[] cmd = bglib.BLECommandGAPConnectDirect(address, 0x00, 0x20, 0x30, 0x100, 0); // 125ms interval, 125ms window, active scanning

                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });

                bglib.SendCommand(serialPort, cmd);

                input_state = INPUT_STATE_CONNECTING;

                displayTimer.Start();

            }
            else if (address == OutputBLE113Address)
            {
                Byte[] cmd = bglib.BLECommandGAPConnectDirect(address, 0x00, 0x20, 0x30, 0x100, 0); // 125ms interval, 125ms window, active scanning

                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });

                bglib.SendCommand(serialPort, cmd);

                output_state = OUTPUT_STATE_CONNECTING;
            }
   
        }

        private void DisconnectBLE113(Byte connection)
        {
             if(connection == input_connection)
             { 
                Byte[] cmd = bglib.BLECommandConnectionDisconnect(input_connection);

                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });

                bglib.SendCommand(serialPort, cmd);

                input_state = INPUT_STATE_DISCONNECTING;

            }
            if (connection == output_connection)
            {
                Byte[] cmd = bglib.BLECommandConnectionDisconnect(output_connection);

                ThreadSafeDelegate(delegate { txtLog.AppendText(String.Format("=> TX ({0}) [ {1}]", cmd.Length, ByteArrayToHexString(cmd)) + Environment.NewLine); });

                bglib.SendCommand(serialPort, cmd);

                output_state = OUTPUT_STATE_DISCONNECTING;

                outputTimer.Stop();
            }
        }

        private void UpdateTerminalDevices()
        {

            if (output_connection != 255)
            {

                controller.CalculateNewControlValues(automatedControlCheckBox.Checked);
                Byte[] newThermostatValue = controller.GetNewThermostatValue();
                Byte[] newDimmerValue = controller.GetNewDimmerValue();

                if (newThermostatValue[0] != previousThermostatValue[0])
                {
                    //Thermostat
                    previousThermostatValue = newThermostatValue;
                    Byte[] tcmd = bglib.BLECommandATTClientAttributeWrite(output_connection, thermostat_handle, newThermostatValue);
                    bglib.SendCommand(serialPort, tcmd);
                    System.Threading.Thread.Sleep(200);
                }


                if (newDimmerValue[0] != previousDimmerValue[0])
                {
                    //dimmer
                    previousDimmerValue = newDimmerValue;
                    Byte[] dcmd = bglib.BLECommandATTClientAttributeWrite(output_connection, dimmer_handle, controller.GetNewDimmerValue());
                    bglib.SendCommand(serialPort, dcmd);
                    //System.Threading.Thread.Sleep(200);
                }
                if( musicPlayerID != 0)
                {
                    VolumeMixer.SetApplicationVolume(musicPlayerID, (float)controller.NewMusicVolume);
                }


            }

        }

        private int FindMusicPlayer()
        {
            int result = 0;
            var hWnd = FindWindow("{97E27FAA-C0B3-4b8e-A693-ED7881E99FC1}", "foobar2000 v1.3.8");
            if (hWnd != IntPtr.Zero)
            {
                uint pID;
                GetWindowThreadProcessId(hWnd, out pID);
                if (pID != 0)
                {
                    musicPlayerID = (int)pID;
                    int vol = (int)VolumeMixer.GetApplicationVolume(musicPlayerID);
                    controller.SetMusicVolumeBaseline(vol);
                    this.musicVolumeBar.Value = vol;
                    result = musicPlayerID;
                }
            }
            else
            {
                musicPlayerID = 0;
                controller.SetMusicVolumeBaseline(0);
                this.musicVolumeBar.Value = 0;
            }
            return result;
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
           
            // initialize serial port with all of the normal values (should work with BLED112 on USB)
            serialPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            serialPort.BaudRate = 115200;
            serialPort.DataBits = 8;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceivedHandler);

            // initialize BGLib events we'll need for this script
            bglib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(this.GAPScanResponseEvent);
            bglib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(this.ConnectionStatusEvent);
            bglib.BLEEventATTClientGroupFound += new Bluegiga.BLE.Events.ATTClient.GroupFoundEventHandler(this.ATTClientGroupFoundEvent);
            bglib.BLEEventATTClientFindInformationFound += new Bluegiga.BLE.Events.ATTClient.FindInformationFoundEventHandler(this.ATTClientFindInformationFoundEvent);
            bglib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(this.ATTClientProcedureCompletedEvent);
            bglib.BLEEventATTClientAttributeValue += new Bluegiga.BLE.Events.ATTClient.AttributeValueEventHandler(this.ATTClientAttributeValueEvent);
            bglib.BLEEventConnectionDisconnected += new Bluegiga.BLE.Events.Connection.DisconnectedEventHandler(this.ConnectionDisconnected);

            if (Environment_Controller.Properties.Settings.Default.LastInputBLEUsed == 0x41)
            {
                InputBLE113Address = BLE41Address;
                ble41RadioButtonInput.Checked = true;
            }
            else if (Environment_Controller.Properties.Settings.Default.LastInputBLEUsed == 0x3f)
            {
                InputBLE113Address = BLE3fAddress;
                ble3fRadioButtonInput.Checked = true;
            }
            else if (Environment_Controller.Properties.Settings.Default.LastInputBLEUsed == 0xa8)
            {
                InputBLE113Address = SystemModelAddress;
                systemModelingRadioButtonInput.Checked = true;
                modelTimer.Start();
                displayTimer.Start();
            }

            if (Environment_Controller.Properties.Settings.Default.LastOutputBLEUsed == 0x41)
            {
                OutputBLE113Address = BLE41Address;
                ble41RadioButtonOutput.Checked = true;
            }
            else if (Environment_Controller.Properties.Settings.Default.LastOutputBLEUsed == 0x3f)
            {
                OutputBLE113Address = BLE3fAddress;
                ble3fRadioButtonOutput.Checked = true;
            }

            this.automatedControlCheckBox.Checked = Environment_Controller.Properties.Settings.Default.AutomatedControlOn;

            this.bodyTempModelingTextBox.Text = this.bodyTempBar.Value.ToString();
            this.heartRateModelingTextBox.Text = this.heartRateBar.Value.ToString();

            modelingActivityState = 0;

            btnRefresh_Click(sender, e);

            FindMusicPlayer();

            this.lightIntensityOffsetTextBox.Text = controller.LightIntensityOffset.ToString();
            this.musicVolumeOffsetTextBox.Text = controller.MusicVolumeOffset.ToString();
            this.roomTemperatureOffsetTextBox.Text = controller.RoomTemperatureOffset.ToString();

            this.lightEffectFactorTextBox.Text = this.lightIntensityEffectBar.Value.ToString();
            this.musicVolumeEffectFactorTextBox.Text = this.musicVolumeEffectBar.Value.ToString();

            this.lightIntensityBaselineTextBox.Text = this.lightIntensityBar.Value.ToString();
            this.musicVolumeBaselineTextBox.Text = this.musicVolumeBar.Value.ToString();

            controller.SetLightIntensityBaseline(this.lightIntensityBar.Value);
            controller.SetMusicEffect(this.musicVolumeEffectBar.Value);
            controller.SetLightEffect(this.lightIntensityEffectBar.Value);

        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DisconnectBLE113(input_connection);
            DisconnectBLE113(output_connection);
        }

        private void ble41ButtonInput_CheckedChanged(object sender, EventArgs e)
        {
            //BLE113 0x41
            if(ble41RadioButtonInput.Checked && InputBLE113Address != BLE41Address)
            {
                DisconnectBLE113(input_connection);
                DisconnectBLE113(output_connection);
                InputBLE113Address = BLE41Address;
                Environment_Controller.Properties.Settings.Default.LastInputBLEUsed = 0x41;
                Environment_Controller.Properties.Settings.Default.Save();
                this.ble3fRadioButtonOutput.Checked = true;
            }
        }

        private void ble3fRadioButtonInput_CheckedChanged(object sender, EventArgs e)
        {
            //BLE113 0x3f
            if (ble3fRadioButtonInput.Checked && InputBLE113Address != BLE3fAddress)
            {
                DisconnectBLE113(input_connection);
                DisconnectBLE113(output_connection);
                InputBLE113Address = BLE3fAddress;
                Environment_Controller.Properties.Settings.Default.LastInputBLEUsed = 0x3f;
                Environment_Controller.Properties.Settings.Default.Save();
                this.ble41RadioButtonOutput.Checked = true;
            }
        }

        private void systemModelingRadioButtonInput_CheckedChanged(object sender, EventArgs e)
        {
            //BLE113 0xa8
            if (systemModelingRadioButtonInput.Checked && InputBLE113Address != SystemModelAddress)
            {
                InputBLE113Address = SystemModelAddress;
                Environment_Controller.Properties.Settings.Default.LastInputBLEUsed = 0xa8;
                Environment_Controller.Properties.Settings.Default.Save();
                modelTimer.Start();
                displayTimer.Start();
            }
            else if (!systemModelingRadioButtonInput.Checked)
            {
                modelTimer.Stop();
                displayTimer.Stop();
                ClearInputBoxes();
            }
        }

        private void ble41RadioButtonOutput_CheckedChanged(object sender, EventArgs e)
        {
            //BLE113 0x41
            if (ble41RadioButtonOutput.Checked && OutputBLE113Address != BLE41Address)
            {
                DisconnectBLE113(input_connection);
                DisconnectBLE113(output_connection);
                OutputBLE113Address = BLE41Address;
                Environment_Controller.Properties.Settings.Default.LastOutputBLEUsed = 0x41;
                Environment_Controller.Properties.Settings.Default.Save();
                if (!systemModelingRadioButtonInput.Checked)
                {
                    this.ble3fRadioButtonInput.Checked = true;
                }
            }
        }

        private void ble3fRadioButtonOutput_CheckedChanged(object sender, EventArgs e)
        {
            //BLE113 0x3f
            if (ble3fRadioButtonOutput.Checked && OutputBLE113Address != BLE3fAddress)
            {
                DisconnectBLE113(input_connection);
                DisconnectBLE113(output_connection);
                OutputBLE113Address = BLE3fAddress;
                Environment_Controller.Properties.Settings.Default.LastOutputBLEUsed = 0x3f;
                Environment_Controller.Properties.Settings.Default.Save();
                if(!systemModelingRadioButtonInput.Checked)
                { 
                    this.ble41RadioButtonInput.Checked = true; 
                }
                
            }
        }

        private void bodyTempBar_Scroll(object sender, EventArgs e)
        {
            this.bodyTempModelingTextBox.Text = this.bodyTempBar.Value.ToString();
        }

        private void heartRateBar_Scroll(object sender, EventArgs e)
        {
            this.heartRateModelingTextBox.Text = this.heartRateBar.Value.ToString();
        }

        private void displayTimer_Tick(object sender, EventArgs e)
        {
            UpdateDataDisplay();
        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
            controller.SetAccelerometerData(modelingActivityState);
            controller.SetBodyTempData(bodyTempBar.Value);
            controller.SetHeartRate(heartRateBar.Value);
        }

        private void activityRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            modelingActivityState = 0;
        }

        private void activityRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            modelingActivityState = 1;
        }

        private void activityRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            modelingActivityState = 2;
        }

        private void activityRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            modelingActivityState = 3;
        }

        private void automatedControlBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.automatedControlCheckBox.Checked)
            {
                controller.AutomaticControl = true;   
            }
            else
            {
                controller.AutomaticControl = false;
            }
        }

        private void lightIntensityBar_Scroll(object sender, EventArgs e)
        {
            this.lightIntensityBaselineTextBox.Text = this.lightIntensityBar.Value.ToString();
            controller.SetLightIntensityBaseline(this.lightIntensityBar.Value);
        }

        private void lightIntensityEffectBar_Scroll(object sender, EventArgs e)
        {
            this.lightEffectFactorTextBox.Text = this.lightIntensityEffectBar.Value.ToString();
            controller.SetLightEffect(this.lightIntensityEffectBar.Value);
        }

        private void musicVolumeBar_Scroll(object sender, EventArgs e)
        {
            this.musicVolumeBaselineTextBox.Text = this.musicVolumeBar.Value.ToString();
            controller.SetMusicVolumeBaseline(this.musicVolumeBar.Value);
            if (musicPlayerID != 0)
            {
                VolumeMixer.SetApplicationVolume(musicPlayerID, this.musicVolumeBar.Value);
            }
            else
            {
                if (FindMusicPlayer() == 0)
                {
                    MessageBox.Show("Could not find music player", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void musicVolumeEffectBar_Scroll(object sender, EventArgs e)
        {
            this.musicVolumeEffectFactorTextBox.Text = this.musicVolumeEffectBar.Value.ToString();
            controller.SetMusicEffect(this.musicVolumeEffectBar.Value);
        }

        private void outputSettingsBox_Enter(object sender, EventArgs e)
        {

        }

        private void roomTempEffectFactor_Scroll(object sender, EventArgs e)
        {
            this.roomTempEffectFactorTextBox.Text = this.roomTempEffectFactorBar.Value.ToString();
            controller.SetRoomTemperatureOffset((Int16)this.roomTempEffectFactorBar.Value);
        }

        private void outputTimer_Tick(object sender, EventArgs e)
        {
            UpdateTerminalDevices();
        }


    }


    public class VolumeMixer
    {
        public static float? GetApplicationVolume(int pid)
        {
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return null;

            float level;
            volume.GetMasterVolume(out level);
            Marshal.ReleaseComObject(volume);
            return level * 100;
        }

        public static bool? GetApplicationMute(int pid)
        {
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return null;

            bool mute;
            volume.GetMute(out mute);
            Marshal.ReleaseComObject(volume);
            return mute;
        }

        public static void SetApplicationVolume(int pid, float level)
        {
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return;

            Guid guid = Guid.Empty;
            volume.SetMasterVolume(level / 100, ref guid);
            Marshal.ReleaseComObject(volume);
        }

        public static void SetApplicationMute(int pid, bool mute)
        {
            ISimpleAudioVolume volume = GetVolumeObject(pid);
            if (volume == null)
                return;

            Guid guid = Guid.Empty;
            volume.SetMute(mute, ref guid);
            Marshal.ReleaseComObject(volume);
        }

        private static ISimpleAudioVolume GetVolumeObject(int pid)
        {
            // get the speakers (1st render + multimedia) device
            IMMDeviceEnumerator deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
            IMMDevice speakers;
            deviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out speakers);

            // activate the session manager. we need the enumerator
            Guid IID_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
            object o;
            speakers.Activate(ref IID_IAudioSessionManager2, 0, IntPtr.Zero, out o);
            IAudioSessionManager2 mgr = (IAudioSessionManager2)o;

            // enumerate sessions for on this device
            IAudioSessionEnumerator sessionEnumerator;
            mgr.GetSessionEnumerator(out sessionEnumerator);
            int count;
            
                sessionEnumerator.GetCount(out count);

                // search for an audio session with the required name
                // NOTE: we could also use the process id instead of the app name (with IAudioSessionControl2)
                ISimpleAudioVolume volumeControl = null;
                for (int i = 0; i < count; i++)
                {
                    IAudioSessionControl2 ctl;
                    sessionEnumerator.GetSession(i, out ctl);
                    int cpid;
                    ctl.GetProcessId(out cpid);

                    if (cpid == pid)
                    {
                        volumeControl = ctl as ISimpleAudioVolume;
                        break;
                    }
                    Marshal.ReleaseComObject(ctl);
                }
                Marshal.ReleaseComObject(sessionEnumerator);
                Marshal.ReleaseComObject(mgr);
                Marshal.ReleaseComObject(speakers);
                Marshal.ReleaseComObject(deviceEnumerator);

                return volumeControl; 
           
        }

    }

    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    internal class MMDeviceEnumerator
    {
    }

    internal enum EDataFlow
    {
        eRender,
        eCapture,
        eAll,
        EDataFlow_enum_count
    }

    internal enum ERole
    {
        eConsole,
        eMultimedia,
        eCommunications,
        ERole_enum_count
    }

    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDeviceEnumerator
    {
        int NotImpl1();

        [PreserveSig]
        int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppDevice);

        // the rest is not implemented
    }

    [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMMDevice
    {
        [PreserveSig]
        int Activate(ref Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

        // the rest is not implemented
    }

    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionManager2
    {
        int NotImpl1();
        int NotImpl2();

        [PreserveSig]
        int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

        // the rest is not implemented
    }

    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionEnumerator
    {
        [PreserveSig]
        int GetCount(out int SessionCount);

        [PreserveSig]
        int GetSession(int SessionCount, out IAudioSessionControl2 Session);
    }

    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface ISimpleAudioVolume
    {
        [PreserveSig]
        int SetMasterVolume(float fLevel, ref Guid EventContext);

        [PreserveSig]
        int GetMasterVolume(out float pfLevel);

        [PreserveSig]
        int SetMute(bool bMute, ref Guid EventContext);

        [PreserveSig]
        int GetMute(out bool pbMute);
    }

    [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionControl2
    {
        // IAudioSessionControl
        [PreserveSig]
        int NotImpl0();

        [PreserveSig]
        int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetDisplayName([MarshalAs(UnmanagedType.LPWStr)]string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int SetIconPath([MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int GetGroupingParam(out Guid pRetVal);

        [PreserveSig]
        int SetGroupingParam([MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);

        [PreserveSig]
        int NotImpl1();

        [PreserveSig]
        int NotImpl2();

        // IAudioSessionControl2
        [PreserveSig]
        int GetSessionIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetSessionInstanceIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string pRetVal);

        [PreserveSig]
        int GetProcessId(out int pRetVal);

        [PreserveSig]
        int IsSystemSoundsSession();

        [PreserveSig]
        int SetDuckingPreference(bool optOut);
    }

}
