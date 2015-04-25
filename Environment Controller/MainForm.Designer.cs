namespace Environment_Controller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.terminalDeviceGroupBox = new System.Windows.Forms.GroupBox();
            this.tempOffsetGroupBox = new System.Windows.Forms.GroupBox();
            this.roomTempFLabel = new System.Windows.Forms.Label();
            this.roomTemperatureOffsetTextBox = new System.Windows.Forms.TextBox();
            this.tempOffsetLabel = new System.Windows.Forms.Label();
            this.musicGroupBox = new System.Windows.Forms.GroupBox();
            this.musicVolumePercentageLabel = new System.Windows.Forms.Label();
            this.musicVolumeTextBox = new System.Windows.Forms.TextBox();
            this.musicVolumeLabel = new System.Windows.Forms.Label();
            this.lightGroupBox = new System.Windows.Forms.GroupBox();
            this.lightPercentageLabel = new System.Windows.Forms.Label();
            this.lightIntensityTextBox = new System.Windows.Forms.TextBox();
            this.lightLabel = new System.Windows.Forms.Label();
            this.outputBLEBox = new System.Windows.Forms.GroupBox();
            this.ble41RadioButtonOutput = new System.Windows.Forms.RadioButton();
            this.ble3fRadioButtonOutput = new System.Windows.Forms.RadioButton();
            this.connectionStateBoxOutput = new System.Windows.Forms.GroupBox();
            this.disconnectButtonOutput = new System.Windows.Forms.Button();
            this.connectPanelOutput = new System.Windows.Forms.Panel();
            this.connectButtonOutput = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.activityOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.activityOutputRadio4 = new System.Windows.Forms.RadioButton();
            this.activityOutputRadio3 = new System.Windows.Forms.RadioButton();
            this.activityOutputRadio2 = new System.Windows.Forms.RadioButton();
            this.activityOutputRadio1 = new System.Windows.Forms.RadioButton();
            this.accelGroupBox = new System.Windows.Forms.GroupBox();
            this.zGLabel = new System.Windows.Forms.Label();
            this.accelZAxisTextBox = new System.Windows.Forms.TextBox();
            this.accelZAxisRawDataTextBox = new System.Windows.Forms.TextBox();
            this.accelZAxisLabel = new System.Windows.Forms.Label();
            this.yGLabel = new System.Windows.Forms.Label();
            this.accelYAxisTextBox = new System.Windows.Forms.TextBox();
            this.accelYAxisRawDataTextBox = new System.Windows.Forms.TextBox();
            this.accelYAxisLabel = new System.Windows.Forms.Label();
            this.xGLabel = new System.Windows.Forms.Label();
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.accelRawDataLabel = new System.Windows.Forms.Label();
            this.accelXAxisTextBox = new System.Windows.Forms.TextBox();
            this.accelXAxisRawDataTextBox = new System.Windows.Forms.TextBox();
            this.accelXAxisLabel = new System.Windows.Forms.Label();
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temperatureMeasurementLabel = new System.Windows.Forms.Label();
            this.temperatureRawDataLabel = new System.Windows.Forms.Label();
            this.bodyTempTextBox = new System.Windows.Forms.TextBox();
            this.tempRawDataTextBox = new System.Windows.Forms.TextBox();
            this.currentTemperatureMeasurementLabel = new System.Windows.Forms.Label();
            this.heartRateBox = new System.Windows.Forms.GroupBox();
            this.bpmLabel = new System.Windows.Forms.Label();
            this.heartRateActualMeasurementLabel = new System.Windows.Forms.Label();
            this.heartRateRawDataLabel = new System.Windows.Forms.Label();
            this.heartRateTextBox = new System.Windows.Forms.TextBox();
            this.heartRateRawDataTextBox = new System.Windows.Forms.TextBox();
            this.heartRateMeasurementLabel = new System.Windows.Forms.Label();
            this.inputBLEBox = new System.Windows.Forms.GroupBox();
            this.systemModelingRadioButtonInput = new System.Windows.Forms.RadioButton();
            this.ble41RadioButtonInput = new System.Windows.Forms.RadioButton();
            this.ble3fRadioButtonInput = new System.Windows.Forms.RadioButton();
            this.connectionStateBoxInput = new System.Windows.Forms.GroupBox();
            this.disconnectButtonInput = new System.Windows.Forms.Button();
            this.connectedPanelInput = new System.Windows.Forms.Panel();
            this.connectedButtonInput = new System.Windows.Forms.Button();
            this.serialPortGroupBox = new System.Windows.Forms.GroupBox();
            this.serialPortPanel = new System.Windows.Forms.Panel();
            this.lblPorts = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.modelTab = new System.Windows.Forms.TabPage();
            this.outputSettingsBox = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.roomTempEffectFactorTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.roomTempEffectFactorBar = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.musicVolumeEffectFactorTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lightEffectFactorTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.musicVolumeOffsetTextBox = new System.Windows.Forms.TextBox();
            this.musicVolumeBaselineTextBox = new System.Windows.Forms.TextBox();
            this.lightIntensityOffsetTextBox = new System.Windows.Forms.TextBox();
            this.lightIntensityBaselineTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.automatedControlCheckBox = new System.Windows.Forms.CheckBox();
            this.lightIntensityEffectFactor = new System.Windows.Forms.Label();
            this.lightIntensityLabel = new System.Windows.Forms.Label();
            this.lightIntensityHighLabel = new System.Windows.Forms.Label();
            this.lightIntensityLowLabel = new System.Windows.Forms.Label();
            this.lightIntensityEffectFactorLowLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musicVolumeEffectBar = new System.Windows.Forms.TrackBar();
            this.musicVolumeBar = new System.Windows.Forms.TrackBar();
            this.lightIntensityEffectBar = new System.Windows.Forms.TrackBar();
            this.lightIntensityBar = new System.Windows.Forms.TrackBar();
            this.inputModelGroup = new System.Windows.Forms.GroupBox();
            this.bodyTempModelingTextBox = new System.Windows.Forms.TextBox();
            this.heartRateModelingTextBox = new System.Windows.Forms.TextBox();
            this.tempHighLabel = new System.Windows.Forms.Label();
            this.activityGroup = new System.Windows.Forms.GroupBox();
            this.activityRadioButton4 = new System.Windows.Forms.RadioButton();
            this.activityRadioButton3 = new System.Windows.Forms.RadioButton();
            this.activityRadioButton2 = new System.Windows.Forms.RadioButton();
            this.activityRadioButton1 = new System.Windows.Forms.RadioButton();
            this.tempLowLabel = new System.Windows.Forms.Label();
            this.bodyTempLabel = new System.Windows.Forms.Label();
            this.hr120Label = new System.Windows.Forms.Label();
            this.hr36Label = new System.Windows.Forms.Label();
            this.heartRateModelLabel = new System.Windows.Forms.Label();
            this.bodyTempBar = new System.Windows.Forms.TrackBar();
            this.heartRateBar = new System.Windows.Forms.TrackBar();
            this.logTab = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.modelTimer = new System.Windows.Forms.Timer(this.components);
            this.outputTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.inputTab.SuspendLayout();
            this.terminalDeviceGroupBox.SuspendLayout();
            this.tempOffsetGroupBox.SuspendLayout();
            this.musicGroupBox.SuspendLayout();
            this.lightGroupBox.SuspendLayout();
            this.outputBLEBox.SuspendLayout();
            this.connectionStateBoxOutput.SuspendLayout();
            this.inputBox.SuspendLayout();
            this.activityOutputGroupBox.SuspendLayout();
            this.accelGroupBox.SuspendLayout();
            this.temperatureGroupBox.SuspendLayout();
            this.heartRateBox.SuspendLayout();
            this.inputBLEBox.SuspendLayout();
            this.connectionStateBoxInput.SuspendLayout();
            this.serialPortGroupBox.SuspendLayout();
            this.modelTab.SuspendLayout();
            this.outputSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTempEffectFactorBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeEffectBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightIntensityEffectBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightIntensityBar)).BeginInit();
            this.inputModelGroup.SuspendLayout();
            this.activityGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyTempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateBar)).BeginInit();
            this.logTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.modelTab);
            this.tabControl.Controls.Add(this.logTab);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 22);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 668);
            this.tabControl.TabIndex = 0;
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.terminalDeviceGroupBox);
            this.inputTab.Controls.Add(this.inputBox);
            this.inputTab.Controls.Add(this.serialPortGroupBox);
            this.inputTab.Location = new System.Drawing.Point(4, 26);
            this.inputTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputTab.Size = new System.Drawing.Size(837, 638);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "Device Status";
            this.inputTab.UseVisualStyleBackColor = true;
            this.inputTab.Click += new System.EventHandler(this.inputTab_Click);
            // 
            // terminalDeviceGroupBox
            // 
            this.terminalDeviceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalDeviceGroupBox.Controls.Add(this.tempOffsetGroupBox);
            this.terminalDeviceGroupBox.Controls.Add(this.musicGroupBox);
            this.terminalDeviceGroupBox.Controls.Add(this.lightGroupBox);
            this.terminalDeviceGroupBox.Controls.Add(this.outputBLEBox);
            this.terminalDeviceGroupBox.Controls.Add(this.connectionStateBoxOutput);
            this.terminalDeviceGroupBox.Location = new System.Drawing.Point(11, 393);
            this.terminalDeviceGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terminalDeviceGroupBox.Name = "terminalDeviceGroupBox";
            this.terminalDeviceGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terminalDeviceGroupBox.Size = new System.Drawing.Size(815, 228);
            this.terminalDeviceGroupBox.TabIndex = 1;
            this.terminalDeviceGroupBox.TabStop = false;
            this.terminalDeviceGroupBox.Text = "Terminal Device";
            // 
            // tempOffsetGroupBox
            // 
            this.tempOffsetGroupBox.Controls.Add(this.roomTempFLabel);
            this.tempOffsetGroupBox.Controls.Add(this.roomTemperatureOffsetTextBox);
            this.tempOffsetGroupBox.Controls.Add(this.tempOffsetLabel);
            this.tempOffsetGroupBox.Location = new System.Drawing.Point(417, 121);
            this.tempOffsetGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempOffsetGroupBox.Name = "tempOffsetGroupBox";
            this.tempOffsetGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempOffsetGroupBox.Size = new System.Drawing.Size(392, 64);
            this.tempOffsetGroupBox.TabIndex = 33;
            this.tempOffsetGroupBox.TabStop = false;
            this.tempOffsetGroupBox.Text = "Temperature Control";
            // 
            // roomTempFLabel
            // 
            this.roomTempFLabel.AutoSize = true;
            this.roomTempFLabel.Location = new System.Drawing.Point(349, 27);
            this.roomTempFLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomTempFLabel.Name = "roomTempFLabel";
            this.roomTempFLabel.Size = new System.Drawing.Size(16, 17);
            this.roomTempFLabel.TabIndex = 2;
            this.roomTempFLabel.Text = "F";
            // 
            // roomTemperatureOffsetTextBox
            // 
            this.roomTemperatureOffsetTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomTemperatureOffsetTextBox.Location = new System.Drawing.Point(112, 23);
            this.roomTemperatureOffsetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomTemperatureOffsetTextBox.Name = "roomTemperatureOffsetTextBox";
            this.roomTemperatureOffsetTextBox.ReadOnly = true;
            this.roomTemperatureOffsetTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomTemperatureOffsetTextBox.Size = new System.Drawing.Size(228, 22);
            this.roomTemperatureOffsetTextBox.TabIndex = 1;
            // 
            // tempOffsetLabel
            // 
            this.tempOffsetLabel.AutoSize = true;
            this.tempOffsetLabel.Location = new System.Drawing.Point(17, 27);
            this.tempOffsetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempOffsetLabel.Name = "tempOffsetLabel";
            this.tempOffsetLabel.Size = new System.Drawing.Size(86, 17);
            this.tempOffsetLabel.TabIndex = 0;
            this.tempOffsetLabel.Text = "Temp Offset";
            // 
            // musicGroupBox
            // 
            this.musicGroupBox.Controls.Add(this.musicVolumePercentageLabel);
            this.musicGroupBox.Controls.Add(this.musicVolumeTextBox);
            this.musicGroupBox.Controls.Add(this.musicVolumeLabel);
            this.musicGroupBox.Location = new System.Drawing.Point(417, 49);
            this.musicGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicGroupBox.Name = "musicGroupBox";
            this.musicGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicGroupBox.Size = new System.Drawing.Size(392, 64);
            this.musicGroupBox.TabIndex = 32;
            this.musicGroupBox.TabStop = false;
            this.musicGroupBox.Text = "Music";
            // 
            // musicVolumePercentageLabel
            // 
            this.musicVolumePercentageLabel.AutoSize = true;
            this.musicVolumePercentageLabel.Location = new System.Drawing.Point(349, 27);
            this.musicVolumePercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicVolumePercentageLabel.Name = "musicVolumePercentageLabel";
            this.musicVolumePercentageLabel.Size = new System.Drawing.Size(20, 17);
            this.musicVolumePercentageLabel.TabIndex = 2;
            this.musicVolumePercentageLabel.Text = "%";
            // 
            // musicVolumeTextBox
            // 
            this.musicVolumeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.musicVolumeTextBox.Location = new System.Drawing.Point(112, 23);
            this.musicVolumeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeTextBox.Name = "musicVolumeTextBox";
            this.musicVolumeTextBox.ReadOnly = true;
            this.musicVolumeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musicVolumeTextBox.Size = new System.Drawing.Size(228, 22);
            this.musicVolumeTextBox.TabIndex = 1;
            // 
            // musicVolumeLabel
            // 
            this.musicVolumeLabel.AutoSize = true;
            this.musicVolumeLabel.Location = new System.Drawing.Point(7, 27);
            this.musicVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicVolumeLabel.Name = "musicVolumeLabel";
            this.musicVolumeLabel.Size = new System.Drawing.Size(95, 17);
            this.musicVolumeLabel.TabIndex = 0;
            this.musicVolumeLabel.Text = "Music Volume";
            // 
            // lightGroupBox
            // 
            this.lightGroupBox.Controls.Add(this.lightPercentageLabel);
            this.lightGroupBox.Controls.Add(this.lightIntensityTextBox);
            this.lightGroupBox.Controls.Add(this.lightLabel);
            this.lightGroupBox.Location = new System.Drawing.Point(8, 121);
            this.lightGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightGroupBox.Name = "lightGroupBox";
            this.lightGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightGroupBox.Size = new System.Drawing.Size(392, 64);
            this.lightGroupBox.TabIndex = 31;
            this.lightGroupBox.TabStop = false;
            this.lightGroupBox.Text = "Lighting";
            // 
            // lightPercentageLabel
            // 
            this.lightPercentageLabel.AutoSize = true;
            this.lightPercentageLabel.Location = new System.Drawing.Point(349, 27);
            this.lightPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightPercentageLabel.Name = "lightPercentageLabel";
            this.lightPercentageLabel.Size = new System.Drawing.Size(20, 17);
            this.lightPercentageLabel.TabIndex = 2;
            this.lightPercentageLabel.Text = "%";
            // 
            // lightIntensityTextBox
            // 
            this.lightIntensityTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lightIntensityTextBox.Location = new System.Drawing.Point(112, 23);
            this.lightIntensityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightIntensityTextBox.Name = "lightIntensityTextBox";
            this.lightIntensityTextBox.ReadOnly = true;
            this.lightIntensityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lightIntensityTextBox.Size = new System.Drawing.Size(228, 22);
            this.lightIntensityTextBox.TabIndex = 1;
            // 
            // lightLabel
            // 
            this.lightLabel.AutoSize = true;
            this.lightLabel.Location = new System.Drawing.Point(8, 27);
            this.lightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightLabel.Name = "lightLabel";
            this.lightLabel.Size = new System.Drawing.Size(95, 17);
            this.lightLabel.TabIndex = 0;
            this.lightLabel.Text = "Light Intensity";
            // 
            // outputBLEBox
            // 
            this.outputBLEBox.Controls.Add(this.ble41RadioButtonOutput);
            this.outputBLEBox.Controls.Add(this.ble3fRadioButtonOutput);
            this.outputBLEBox.Location = new System.Drawing.Point(7, 22);
            this.outputBLEBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputBLEBox.Name = "outputBLEBox";
            this.outputBLEBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputBLEBox.Size = new System.Drawing.Size(148, 91);
            this.outputBLEBox.TabIndex = 27;
            this.outputBLEBox.TabStop = false;
            this.outputBLEBox.Text = "Output Device";
            // 
            // ble41RadioButtonOutput
            // 
            this.ble41RadioButtonOutput.AutoSize = true;
            this.ble41RadioButtonOutput.Location = new System.Drawing.Point(11, 26);
            this.ble41RadioButtonOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ble41RadioButtonOutput.Name = "ble41RadioButtonOutput";
            this.ble41RadioButtonOutput.Size = new System.Drawing.Size(123, 21);
            this.ble41RadioButtonOutput.TabIndex = 15;
            this.ble41RadioButtonOutput.Text = "BLE113 (0x41)";
            this.ble41RadioButtonOutput.UseVisualStyleBackColor = true;
            this.ble41RadioButtonOutput.CheckedChanged += new System.EventHandler(this.ble41RadioButtonOutput_CheckedChanged);
            // 
            // ble3fRadioButtonOutput
            // 
            this.ble3fRadioButtonOutput.AutoSize = true;
            this.ble3fRadioButtonOutput.Enabled = false;
            this.ble3fRadioButtonOutput.Location = new System.Drawing.Point(11, 52);
            this.ble3fRadioButtonOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ble3fRadioButtonOutput.Name = "ble3fRadioButtonOutput";
            this.ble3fRadioButtonOutput.Size = new System.Drawing.Size(119, 21);
            this.ble3fRadioButtonOutput.TabIndex = 16;
            this.ble3fRadioButtonOutput.Text = "BLE113 (0x3f)";
            this.ble3fRadioButtonOutput.UseVisualStyleBackColor = true;
            this.ble3fRadioButtonOutput.CheckedChanged += new System.EventHandler(this.ble3fRadioButtonOutput_CheckedChanged);
            // 
            // connectionStateBoxOutput
            // 
            this.connectionStateBoxOutput.Controls.Add(this.disconnectButtonOutput);
            this.connectionStateBoxOutput.Controls.Add(this.connectPanelOutput);
            this.connectionStateBoxOutput.Controls.Add(this.connectButtonOutput);
            this.connectionStateBoxOutput.Location = new System.Drawing.Point(161, 23);
            this.connectionStateBoxOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionStateBoxOutput.Name = "connectionStateBoxOutput";
            this.connectionStateBoxOutput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionStateBoxOutput.Size = new System.Drawing.Size(239, 90);
            this.connectionStateBoxOutput.TabIndex = 28;
            this.connectionStateBoxOutput.TabStop = false;
            this.connectionStateBoxOutput.Text = "Connection State: Disconnected";
            // 
            // disconnectButtonOutput
            // 
            this.disconnectButtonOutput.Location = new System.Drawing.Point(8, 54);
            this.disconnectButtonOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnectButtonOutput.Name = "disconnectButtonOutput";
            this.disconnectButtonOutput.Size = new System.Drawing.Size(111, 28);
            this.disconnectButtonOutput.TabIndex = 29;
            this.disconnectButtonOutput.Text = "Disconnect";
            this.disconnectButtonOutput.UseVisualStyleBackColor = true;
            this.disconnectButtonOutput.Click += new System.EventHandler(this.disconnectButtonOutput_Click);
            // 
            // connectPanelOutput
            // 
            this.connectPanelOutput.BackColor = System.Drawing.Color.OrangeRed;
            this.connectPanelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectPanelOutput.Location = new System.Drawing.Point(127, 21);
            this.connectPanelOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectPanelOutput.Name = "connectPanelOutput";
            this.connectPanelOutput.Size = new System.Drawing.Size(103, 61);
            this.connectPanelOutput.TabIndex = 2;
            // 
            // connectButtonOutput
            // 
            this.connectButtonOutput.Location = new System.Drawing.Point(8, 21);
            this.connectButtonOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectButtonOutput.Name = "connectButtonOutput";
            this.connectButtonOutput.Size = new System.Drawing.Size(111, 28);
            this.connectButtonOutput.TabIndex = 28;
            this.connectButtonOutput.Text = "Connect";
            this.connectButtonOutput.UseVisualStyleBackColor = true;
            this.connectButtonOutput.Click += new System.EventHandler(this.connectButtonOutput_Click);
            // 
            // inputBox
            // 
            this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox.Controls.Add(this.activityOutputGroupBox);
            this.inputBox.Controls.Add(this.accelGroupBox);
            this.inputBox.Controls.Add(this.temperatureGroupBox);
            this.inputBox.Controls.Add(this.heartRateBox);
            this.inputBox.Controls.Add(this.inputBLEBox);
            this.inputBox.Controls.Add(this.connectionStateBoxInput);
            this.inputBox.Location = new System.Drawing.Point(11, 85);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.Size = new System.Drawing.Size(811, 300);
            this.inputBox.TabIndex = 30;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Wearable Device";
            // 
            // activityOutputGroupBox
            // 
            this.activityOutputGroupBox.Controls.Add(this.activityOutputRadio4);
            this.activityOutputGroupBox.Controls.Add(this.activityOutputRadio3);
            this.activityOutputGroupBox.Controls.Add(this.activityOutputRadio2);
            this.activityOutputGroupBox.Controls.Add(this.activityOutputRadio1);
            this.activityOutputGroupBox.Location = new System.Drawing.Point(436, 172);
            this.activityOutputGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputGroupBox.Name = "activityOutputGroupBox";
            this.activityOutputGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputGroupBox.Size = new System.Drawing.Size(361, 116);
            this.activityOutputGroupBox.TabIndex = 21;
            this.activityOutputGroupBox.TabStop = false;
            this.activityOutputGroupBox.Text = "Activity";
            // 
            // activityOutputRadio4
            // 
            this.activityOutputRadio4.AutoSize = true;
            this.activityOutputRadio4.Enabled = false;
            this.activityOutputRadio4.Location = new System.Drawing.Point(8, 90);
            this.activityOutputRadio4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputRadio4.Name = "activityOutputRadio4";
            this.activityOutputRadio4.Size = new System.Drawing.Size(172, 21);
            this.activityOutputRadio4.TabIndex = 5;
            this.activityOutputRadio4.Text = "Excercise / Very Active";
            this.activityOutputRadio4.UseVisualStyleBackColor = true;
            // 
            // activityOutputRadio3
            // 
            this.activityOutputRadio3.AutoSize = true;
            this.activityOutputRadio3.Enabled = false;
            this.activityOutputRadio3.Location = new System.Drawing.Point(8, 66);
            this.activityOutputRadio3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputRadio3.Name = "activityOutputRadio3";
            this.activityOutputRadio3.Size = new System.Drawing.Size(67, 21);
            this.activityOutputRadio3.TabIndex = 4;
            this.activityOutputRadio3.Text = "Active";
            this.activityOutputRadio3.UseVisualStyleBackColor = true;
            // 
            // activityOutputRadio2
            // 
            this.activityOutputRadio2.AutoSize = true;
            this.activityOutputRadio2.Enabled = false;
            this.activityOutputRadio2.Location = new System.Drawing.Point(8, 44);
            this.activityOutputRadio2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputRadio2.Name = "activityOutputRadio2";
            this.activityOutputRadio2.Size = new System.Drawing.Size(60, 21);
            this.activityOutputRadio2.TabIndex = 3;
            this.activityOutputRadio2.Text = "Calm";
            this.activityOutputRadio2.UseVisualStyleBackColor = true;
            // 
            // activityOutputRadio1
            // 
            this.activityOutputRadio1.AutoSize = true;
            this.activityOutputRadio1.Checked = true;
            this.activityOutputRadio1.Enabled = false;
            this.activityOutputRadio1.Location = new System.Drawing.Point(8, 21);
            this.activityOutputRadio1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityOutputRadio1.Name = "activityOutputRadio1";
            this.activityOutputRadio1.Size = new System.Drawing.Size(77, 21);
            this.activityOutputRadio1.TabIndex = 2;
            this.activityOutputRadio1.TabStop = true;
            this.activityOutputRadio1.Text = "Resting";
            this.activityOutputRadio1.UseVisualStyleBackColor = true;
            // 
            // accelGroupBox
            // 
            this.accelGroupBox.Controls.Add(this.zGLabel);
            this.accelGroupBox.Controls.Add(this.accelZAxisTextBox);
            this.accelGroupBox.Controls.Add(this.accelZAxisRawDataTextBox);
            this.accelGroupBox.Controls.Add(this.accelZAxisLabel);
            this.accelGroupBox.Controls.Add(this.yGLabel);
            this.accelGroupBox.Controls.Add(this.accelYAxisTextBox);
            this.accelGroupBox.Controls.Add(this.accelYAxisRawDataTextBox);
            this.accelGroupBox.Controls.Add(this.accelYAxisLabel);
            this.accelGroupBox.Controls.Add(this.xGLabel);
            this.accelGroupBox.Controls.Add(this.accelerationLabel);
            this.accelGroupBox.Controls.Add(this.accelRawDataLabel);
            this.accelGroupBox.Controls.Add(this.accelXAxisTextBox);
            this.accelGroupBox.Controls.Add(this.accelXAxisRawDataTextBox);
            this.accelGroupBox.Controls.Add(this.accelXAxisLabel);
            this.accelGroupBox.Location = new System.Drawing.Point(436, 23);
            this.accelGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelGroupBox.Name = "accelGroupBox";
            this.accelGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelGroupBox.Size = new System.Drawing.Size(361, 145);
            this.accelGroupBox.TabIndex = 20;
            this.accelGroupBox.TabStop = false;
            this.accelGroupBox.Text = "Accelerometer";
            // 
            // zGLabel
            // 
            this.zGLabel.AutoSize = true;
            this.zGLabel.Location = new System.Drawing.Point(279, 107);
            this.zGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zGLabel.Name = "zGLabel";
            this.zGLabel.Size = new System.Drawing.Size(67, 17);
            this.zGLabel.TabIndex = 19;
            this.zGLabel.Text = "g (m/s^2)";
            // 
            // accelZAxisTextBox
            // 
            this.accelZAxisTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelZAxisTextBox.Location = new System.Drawing.Point(171, 103);
            this.accelZAxisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelZAxisTextBox.Name = "accelZAxisTextBox";
            this.accelZAxisTextBox.ReadOnly = true;
            this.accelZAxisTextBox.Size = new System.Drawing.Size(105, 22);
            this.accelZAxisTextBox.TabIndex = 18;
            // 
            // accelZAxisRawDataTextBox
            // 
            this.accelZAxisRawDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelZAxisRawDataTextBox.Location = new System.Drawing.Point(64, 103);
            this.accelZAxisRawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelZAxisRawDataTextBox.Name = "accelZAxisRawDataTextBox";
            this.accelZAxisRawDataTextBox.ReadOnly = true;
            this.accelZAxisRawDataTextBox.Size = new System.Drawing.Size(97, 22);
            this.accelZAxisRawDataTextBox.TabIndex = 17;
            // 
            // accelZAxisLabel
            // 
            this.accelZAxisLabel.AutoSize = true;
            this.accelZAxisLabel.Location = new System.Drawing.Point(8, 107);
            this.accelZAxisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accelZAxisLabel.Name = "accelZAxisLabel";
            this.accelZAxisLabel.Size = new System.Drawing.Size(46, 17);
            this.accelZAxisLabel.TabIndex = 16;
            this.accelZAxisLabel.Text = "Z Axis";
            // 
            // yGLabel
            // 
            this.yGLabel.AutoSize = true;
            this.yGLabel.Location = new System.Drawing.Point(279, 75);
            this.yGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yGLabel.Name = "yGLabel";
            this.yGLabel.Size = new System.Drawing.Size(67, 17);
            this.yGLabel.TabIndex = 15;
            this.yGLabel.Text = "g (m/s^2)";
            // 
            // accelYAxisTextBox
            // 
            this.accelYAxisTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelYAxisTextBox.Location = new System.Drawing.Point(171, 71);
            this.accelYAxisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelYAxisTextBox.Name = "accelYAxisTextBox";
            this.accelYAxisTextBox.ReadOnly = true;
            this.accelYAxisTextBox.Size = new System.Drawing.Size(105, 22);
            this.accelYAxisTextBox.TabIndex = 14;
            // 
            // accelYAxisRawDataTextBox
            // 
            this.accelYAxisRawDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelYAxisRawDataTextBox.Location = new System.Drawing.Point(64, 71);
            this.accelYAxisRawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelYAxisRawDataTextBox.Name = "accelYAxisRawDataTextBox";
            this.accelYAxisRawDataTextBox.ReadOnly = true;
            this.accelYAxisRawDataTextBox.Size = new System.Drawing.Size(97, 22);
            this.accelYAxisRawDataTextBox.TabIndex = 13;
            // 
            // accelYAxisLabel
            // 
            this.accelYAxisLabel.AutoSize = true;
            this.accelYAxisLabel.Location = new System.Drawing.Point(8, 75);
            this.accelYAxisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accelYAxisLabel.Name = "accelYAxisLabel";
            this.accelYAxisLabel.Size = new System.Drawing.Size(46, 17);
            this.accelYAxisLabel.TabIndex = 12;
            this.accelYAxisLabel.Text = "Y Axis";
            // 
            // xGLabel
            // 
            this.xGLabel.AutoSize = true;
            this.xGLabel.Location = new System.Drawing.Point(279, 43);
            this.xGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xGLabel.Name = "xGLabel";
            this.xGLabel.Size = new System.Drawing.Size(67, 17);
            this.xGLabel.TabIndex = 11;
            this.xGLabel.Text = "g (m/s^2)";
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Location = new System.Drawing.Point(167, 20);
            this.accelerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(86, 17);
            this.accelerationLabel.TabIndex = 10;
            this.accelerationLabel.Text = "Acceleration";
            // 
            // accelRawDataLabel
            // 
            this.accelRawDataLabel.AutoSize = true;
            this.accelRawDataLabel.Location = new System.Drawing.Point(60, 20);
            this.accelRawDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accelRawDataLabel.Name = "accelRawDataLabel";
            this.accelRawDataLabel.Size = new System.Drawing.Size(69, 17);
            this.accelRawDataLabel.TabIndex = 9;
            this.accelRawDataLabel.Text = "Raw Data";
            // 
            // accelXAxisTextBox
            // 
            this.accelXAxisTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelXAxisTextBox.Location = new System.Drawing.Point(171, 39);
            this.accelXAxisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelXAxisTextBox.Name = "accelXAxisTextBox";
            this.accelXAxisTextBox.ReadOnly = true;
            this.accelXAxisTextBox.Size = new System.Drawing.Size(105, 22);
            this.accelXAxisTextBox.TabIndex = 8;
            // 
            // accelXAxisRawDataTextBox
            // 
            this.accelXAxisRawDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accelXAxisRawDataTextBox.Location = new System.Drawing.Point(64, 39);
            this.accelXAxisRawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelXAxisRawDataTextBox.Name = "accelXAxisRawDataTextBox";
            this.accelXAxisRawDataTextBox.ReadOnly = true;
            this.accelXAxisRawDataTextBox.Size = new System.Drawing.Size(97, 22);
            this.accelXAxisRawDataTextBox.TabIndex = 7;
            // 
            // accelXAxisLabel
            // 
            this.accelXAxisLabel.AutoSize = true;
            this.accelXAxisLabel.Location = new System.Drawing.Point(8, 43);
            this.accelXAxisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accelXAxisLabel.Name = "accelXAxisLabel";
            this.accelXAxisLabel.Size = new System.Drawing.Size(46, 17);
            this.accelXAxisLabel.TabIndex = 6;
            this.accelXAxisLabel.Text = "X Axis";
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Controls.Add(this.label1);
            this.temperatureGroupBox.Controls.Add(this.temperatureMeasurementLabel);
            this.temperatureGroupBox.Controls.Add(this.temperatureRawDataLabel);
            this.temperatureGroupBox.Controls.Add(this.bodyTempTextBox);
            this.temperatureGroupBox.Controls.Add(this.tempRawDataTextBox);
            this.temperatureGroupBox.Controls.Add(this.currentTemperatureMeasurementLabel);
            this.temperatureGroupBox.Location = new System.Drawing.Point(9, 208);
            this.temperatureGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperatureGroupBox.Size = new System.Drawing.Size(415, 80);
            this.temperatureGroupBox.TabIndex = 19;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Text = "Body Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "F";
            // 
            // temperatureMeasurementLabel
            // 
            this.temperatureMeasurementLabel.AutoSize = true;
            this.temperatureMeasurementLabel.Location = new System.Drawing.Point(257, 20);
            this.temperatureMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureMeasurementLabel.Name = "temperatureMeasurementLabel";
            this.temperatureMeasurementLabel.Size = new System.Drawing.Size(90, 17);
            this.temperatureMeasurementLabel.TabIndex = 10;
            this.temperatureMeasurementLabel.Text = "Temperature";
            // 
            // temperatureRawDataLabel
            // 
            this.temperatureRawDataLabel.AutoSize = true;
            this.temperatureRawDataLabel.Location = new System.Drawing.Point(151, 20);
            this.temperatureRawDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temperatureRawDataLabel.Name = "temperatureRawDataLabel";
            this.temperatureRawDataLabel.Size = new System.Drawing.Size(69, 17);
            this.temperatureRawDataLabel.TabIndex = 9;
            this.temperatureRawDataLabel.Text = "Raw Data";
            // 
            // bodyTempTextBox
            // 
            this.bodyTempTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bodyTempTextBox.Location = new System.Drawing.Point(261, 39);
            this.bodyTempTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyTempTextBox.Name = "bodyTempTextBox";
            this.bodyTempTextBox.ReadOnly = true;
            this.bodyTempTextBox.Size = new System.Drawing.Size(105, 22);
            this.bodyTempTextBox.TabIndex = 8;
            // 
            // tempRawDataTextBox
            // 
            this.tempRawDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tempRawDataTextBox.Location = new System.Drawing.Point(155, 39);
            this.tempRawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tempRawDataTextBox.Name = "tempRawDataTextBox";
            this.tempRawDataTextBox.ReadOnly = true;
            this.tempRawDataTextBox.Size = new System.Drawing.Size(97, 22);
            this.tempRawDataTextBox.TabIndex = 7;
            // 
            // currentTemperatureMeasurementLabel
            // 
            this.currentTemperatureMeasurementLabel.AutoSize = true;
            this.currentTemperatureMeasurementLabel.Location = new System.Drawing.Point(9, 43);
            this.currentTemperatureMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTemperatureMeasurementLabel.Name = "currentTemperatureMeasurementLabel";
            this.currentTemperatureMeasurementLabel.Size = new System.Drawing.Size(145, 17);
            this.currentTemperatureMeasurementLabel.TabIndex = 6;
            this.currentTemperatureMeasurementLabel.Text = "Current Measurement";
            // 
            // heartRateBox
            // 
            this.heartRateBox.Controls.Add(this.bpmLabel);
            this.heartRateBox.Controls.Add(this.heartRateActualMeasurementLabel);
            this.heartRateBox.Controls.Add(this.heartRateRawDataLabel);
            this.heartRateBox.Controls.Add(this.heartRateTextBox);
            this.heartRateBox.Controls.Add(this.heartRateRawDataTextBox);
            this.heartRateBox.Controls.Add(this.heartRateMeasurementLabel);
            this.heartRateBox.Location = new System.Drawing.Point(8, 121);
            this.heartRateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateBox.Name = "heartRateBox";
            this.heartRateBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateBox.Size = new System.Drawing.Size(415, 80);
            this.heartRateBox.TabIndex = 18;
            this.heartRateBox.TabStop = false;
            this.heartRateBox.Text = "Heart Rate";
            // 
            // bpmLabel
            // 
            this.bpmLabel.AutoSize = true;
            this.bpmLabel.Location = new System.Drawing.Point(369, 46);
            this.bpmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bpmLabel.Name = "bpmLabel";
            this.bpmLabel.Size = new System.Drawing.Size(35, 17);
            this.bpmLabel.TabIndex = 5;
            this.bpmLabel.Text = "bpm";
            // 
            // heartRateActualMeasurementLabel
            // 
            this.heartRateActualMeasurementLabel.AutoSize = true;
            this.heartRateActualMeasurementLabel.Location = new System.Drawing.Point(256, 20);
            this.heartRateActualMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateActualMeasurementLabel.Name = "heartRateActualMeasurementLabel";
            this.heartRateActualMeasurementLabel.Size = new System.Drawing.Size(28, 17);
            this.heartRateActualMeasurementLabel.TabIndex = 4;
            this.heartRateActualMeasurementLabel.Text = "HR";
            // 
            // heartRateRawDataLabel
            // 
            this.heartRateRawDataLabel.AutoSize = true;
            this.heartRateRawDataLabel.Location = new System.Drawing.Point(149, 20);
            this.heartRateRawDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateRawDataLabel.Name = "heartRateRawDataLabel";
            this.heartRateRawDataLabel.Size = new System.Drawing.Size(69, 17);
            this.heartRateRawDataLabel.TabIndex = 3;
            this.heartRateRawDataLabel.Text = "Raw Data";
            // 
            // heartRateTextBox
            // 
            this.heartRateTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.heartRateTextBox.Location = new System.Drawing.Point(260, 39);
            this.heartRateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateTextBox.Name = "heartRateTextBox";
            this.heartRateTextBox.ReadOnly = true;
            this.heartRateTextBox.Size = new System.Drawing.Size(105, 22);
            this.heartRateTextBox.TabIndex = 2;
            // 
            // heartRateRawDataTextBox
            // 
            this.heartRateRawDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.heartRateRawDataTextBox.Location = new System.Drawing.Point(153, 39);
            this.heartRateRawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateRawDataTextBox.Name = "heartRateRawDataTextBox";
            this.heartRateRawDataTextBox.ReadOnly = true;
            this.heartRateRawDataTextBox.Size = new System.Drawing.Size(97, 22);
            this.heartRateRawDataTextBox.TabIndex = 1;
            // 
            // heartRateMeasurementLabel
            // 
            this.heartRateMeasurementLabel.AutoSize = true;
            this.heartRateMeasurementLabel.Location = new System.Drawing.Point(8, 43);
            this.heartRateMeasurementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateMeasurementLabel.Name = "heartRateMeasurementLabel";
            this.heartRateMeasurementLabel.Size = new System.Drawing.Size(145, 17);
            this.heartRateMeasurementLabel.TabIndex = 0;
            this.heartRateMeasurementLabel.Text = "Current Measurement";
            // 
            // inputBLEBox
            // 
            this.inputBLEBox.Controls.Add(this.systemModelingRadioButtonInput);
            this.inputBLEBox.Controls.Add(this.ble41RadioButtonInput);
            this.inputBLEBox.Controls.Add(this.ble3fRadioButtonInput);
            this.inputBLEBox.Location = new System.Drawing.Point(9, 22);
            this.inputBLEBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBLEBox.Name = "inputBLEBox";
            this.inputBLEBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBLEBox.Size = new System.Drawing.Size(148, 91);
            this.inputBLEBox.TabIndex = 17;
            this.inputBLEBox.TabStop = false;
            this.inputBLEBox.Text = "Input Device";
            // 
            // systemModelingRadioButtonInput
            // 
            this.systemModelingRadioButtonInput.AutoSize = true;
            this.systemModelingRadioButtonInput.Location = new System.Drawing.Point(11, 64);
            this.systemModelingRadioButtonInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.systemModelingRadioButtonInput.Name = "systemModelingRadioButtonInput";
            this.systemModelingRadioButtonInput.Size = new System.Drawing.Size(136, 21);
            this.systemModelingRadioButtonInput.TabIndex = 17;
            this.systemModelingRadioButtonInput.TabStop = true;
            this.systemModelingRadioButtonInput.Text = "System Modeling";
            this.systemModelingRadioButtonInput.UseVisualStyleBackColor = true;
            this.systemModelingRadioButtonInput.CheckedChanged += new System.EventHandler(this.systemModelingRadioButtonInput_CheckedChanged);
            // 
            // ble41RadioButtonInput
            // 
            this.ble41RadioButtonInput.AutoSize = true;
            this.ble41RadioButtonInput.Enabled = false;
            this.ble41RadioButtonInput.Location = new System.Drawing.Point(11, 18);
            this.ble41RadioButtonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ble41RadioButtonInput.Name = "ble41RadioButtonInput";
            this.ble41RadioButtonInput.Size = new System.Drawing.Size(123, 21);
            this.ble41RadioButtonInput.TabIndex = 15;
            this.ble41RadioButtonInput.Text = "BLE113 (0x41)";
            this.ble41RadioButtonInput.UseVisualStyleBackColor = true;
            this.ble41RadioButtonInput.CheckedChanged += new System.EventHandler(this.ble41ButtonInput_CheckedChanged);
            // 
            // ble3fRadioButtonInput
            // 
            this.ble3fRadioButtonInput.AutoSize = true;
            this.ble3fRadioButtonInput.Location = new System.Drawing.Point(11, 41);
            this.ble3fRadioButtonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ble3fRadioButtonInput.Name = "ble3fRadioButtonInput";
            this.ble3fRadioButtonInput.Size = new System.Drawing.Size(119, 21);
            this.ble3fRadioButtonInput.TabIndex = 16;
            this.ble3fRadioButtonInput.Text = "BLE113 (0x3f)";
            this.ble3fRadioButtonInput.UseVisualStyleBackColor = true;
            this.ble3fRadioButtonInput.CheckedChanged += new System.EventHandler(this.ble3fRadioButtonInput_CheckedChanged);
            // 
            // connectionStateBoxInput
            // 
            this.connectionStateBoxInput.Controls.Add(this.disconnectButtonInput);
            this.connectionStateBoxInput.Controls.Add(this.connectedPanelInput);
            this.connectionStateBoxInput.Controls.Add(this.connectedButtonInput);
            this.connectionStateBoxInput.Location = new System.Drawing.Point(183, 23);
            this.connectionStateBoxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionStateBoxInput.Name = "connectionStateBoxInput";
            this.connectionStateBoxInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionStateBoxInput.Size = new System.Drawing.Size(239, 90);
            this.connectionStateBoxInput.TabIndex = 17;
            this.connectionStateBoxInput.TabStop = false;
            this.connectionStateBoxInput.Text = "Connection State: Disconnected";
            // 
            // disconnectButtonInput
            // 
            this.disconnectButtonInput.Location = new System.Drawing.Point(8, 54);
            this.disconnectButtonInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnectButtonInput.Name = "disconnectButtonInput";
            this.disconnectButtonInput.Size = new System.Drawing.Size(111, 28);
            this.disconnectButtonInput.TabIndex = 29;
            this.disconnectButtonInput.Text = "Disconnect";
            this.disconnectButtonInput.UseVisualStyleBackColor = true;
            this.disconnectButtonInput.Click += new System.EventHandler(this.disconnectButtonInput_Click);
            // 
            // connectedPanelInput
            // 
            this.connectedPanelInput.BackColor = System.Drawing.Color.OrangeRed;
            this.connectedPanelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedPanelInput.Location = new System.Drawing.Point(127, 21);
            this.connectedPanelInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectedPanelInput.Name = "connectedPanelInput";
            this.connectedPanelInput.Size = new System.Drawing.Size(103, 61);
            this.connectedPanelInput.TabIndex = 2;
            // 
            // connectedButtonInput
            // 
            this.connectedButtonInput.Location = new System.Drawing.Point(8, 21);
            this.connectedButtonInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectedButtonInput.Name = "connectedButtonInput";
            this.connectedButtonInput.Size = new System.Drawing.Size(111, 28);
            this.connectedButtonInput.TabIndex = 28;
            this.connectedButtonInput.Text = "Connect";
            this.connectedButtonInput.UseVisualStyleBackColor = true;
            this.connectedButtonInput.Click += new System.EventHandler(this.connectedButtonInput_Click);
            // 
            // serialPortGroupBox
            // 
            this.serialPortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortGroupBox.Controls.Add(this.serialPortPanel);
            this.serialPortGroupBox.Controls.Add(this.lblPorts);
            this.serialPortGroupBox.Controls.Add(this.btnAttach);
            this.serialPortGroupBox.Controls.Add(this.comboPorts);
            this.serialPortGroupBox.Controls.Add(this.btnRefresh);
            this.serialPortGroupBox.Location = new System.Drawing.Point(7, 6);
            this.serialPortGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serialPortGroupBox.Name = "serialPortGroupBox";
            this.serialPortGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serialPortGroupBox.Size = new System.Drawing.Size(815, 71);
            this.serialPortGroupBox.TabIndex = 29;
            this.serialPortGroupBox.TabStop = false;
            this.serialPortGroupBox.Text = "Serial Port Connection";
            // 
            // serialPortPanel
            // 
            this.serialPortPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.serialPortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serialPortPanel.Location = new System.Drawing.Point(727, 12);
            this.serialPortPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serialPortPanel.Name = "serialPortPanel";
            this.serialPortPanel.Size = new System.Drawing.Size(78, 52);
            this.serialPortPanel.TabIndex = 15;
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(8, 32);
            this.lblPorts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(69, 17);
            this.lblPorts.TabIndex = 8;
            this.lblPorts.Text = "COM Port";
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttach.Location = new System.Drawing.Point(645, 26);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 28);
            this.btnAttach.TabIndex = 12;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(87, 28);
            this.comboPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(469, 24);
            this.comboPorts.TabIndex = 13;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.comboPorts_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(565, 26);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 28);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // modelTab
            // 
            this.modelTab.Controls.Add(this.outputSettingsBox);
            this.modelTab.Controls.Add(this.inputModelGroup);
            this.modelTab.Location = new System.Drawing.Point(4, 26);
            this.modelTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelTab.Name = "modelTab";
            this.modelTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelTab.Size = new System.Drawing.Size(837, 638);
            this.modelTab.TabIndex = 2;
            this.modelTab.Text = "System Modeling and Settings";
            this.modelTab.UseVisualStyleBackColor = true;
            // 
            // outputSettingsBox
            // 
            this.outputSettingsBox.Controls.Add(this.label18);
            this.outputSettingsBox.Controls.Add(this.roomTempEffectFactorTextBox);
            this.outputSettingsBox.Controls.Add(this.label17);
            this.outputSettingsBox.Controls.Add(this.label16);
            this.outputSettingsBox.Controls.Add(this.label15);
            this.outputSettingsBox.Controls.Add(this.roomTempEffectFactorBar);
            this.outputSettingsBox.Controls.Add(this.label14);
            this.outputSettingsBox.Controls.Add(this.musicVolumeEffectFactorTextBox);
            this.outputSettingsBox.Controls.Add(this.label13);
            this.outputSettingsBox.Controls.Add(this.lightEffectFactorTextBox);
            this.outputSettingsBox.Controls.Add(this.label12);
            this.outputSettingsBox.Controls.Add(this.label11);
            this.outputSettingsBox.Controls.Add(this.label10);
            this.outputSettingsBox.Controls.Add(this.label9);
            this.outputSettingsBox.Controls.Add(this.musicVolumeOffsetTextBox);
            this.outputSettingsBox.Controls.Add(this.musicVolumeBaselineTextBox);
            this.outputSettingsBox.Controls.Add(this.lightIntensityOffsetTextBox);
            this.outputSettingsBox.Controls.Add(this.lightIntensityBaselineTextBox);
            this.outputSettingsBox.Controls.Add(this.label8);
            this.outputSettingsBox.Controls.Add(this.label7);
            this.outputSettingsBox.Controls.Add(this.label6);
            this.outputSettingsBox.Controls.Add(this.label5);
            this.outputSettingsBox.Controls.Add(this.label4);
            this.outputSettingsBox.Controls.Add(this.label3);
            this.outputSettingsBox.Controls.Add(this.automatedControlCheckBox);
            this.outputSettingsBox.Controls.Add(this.lightIntensityEffectFactor);
            this.outputSettingsBox.Controls.Add(this.lightIntensityLabel);
            this.outputSettingsBox.Controls.Add(this.lightIntensityHighLabel);
            this.outputSettingsBox.Controls.Add(this.lightIntensityLowLabel);
            this.outputSettingsBox.Controls.Add(this.lightIntensityEffectFactorLowLabel);
            this.outputSettingsBox.Controls.Add(this.label2);
            this.outputSettingsBox.Controls.Add(this.musicVolumeEffectBar);
            this.outputSettingsBox.Controls.Add(this.musicVolumeBar);
            this.outputSettingsBox.Controls.Add(this.lightIntensityEffectBar);
            this.outputSettingsBox.Controls.Add(this.lightIntensityBar);
            this.outputSettingsBox.Location = new System.Drawing.Point(11, 210);
            this.outputSettingsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputSettingsBox.Name = "outputSettingsBox";
            this.outputSettingsBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputSettingsBox.Size = new System.Drawing.Size(813, 379);
            this.outputSettingsBox.TabIndex = 10;
            this.outputSettingsBox.TabStop = false;
            this.outputSettingsBox.Text = "Output";
            this.outputSettingsBox.Enter += new System.EventHandler(this.outputSettingsBox_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(719, 160);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Temp Offset";
            // 
            // roomTempEffectFactorTextBox
            // 
            this.roomTempEffectFactorTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomTempEffectFactorTextBox.Location = new System.Drawing.Point(723, 178);
            this.roomTempEffectFactorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomTempEffectFactorTextBox.Name = "roomTempEffectFactorTextBox";
            this.roomTempEffectFactorTextBox.ReadOnly = true;
            this.roomTempEffectFactorTextBox.Size = new System.Drawing.Size(71, 22);
            this.roomTempEffectFactorTextBox.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(677, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(672, 347);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "-3";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(615, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Room Temp Offset";
            // 
            // roomTempEffectFactorBar
            // 
            this.roomTempEffectFactorBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomTempEffectFactorBar.Location = new System.Drawing.Point(665, 97);
            this.roomTempEffectFactorBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomTempEffectFactorBar.Maximum = 3;
            this.roomTempEffectFactorBar.Minimum = -3;
            this.roomTempEffectFactorBar.Name = "roomTempEffectFactorBar";
            this.roomTempEffectFactorBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.roomTempEffectFactorBar.Size = new System.Drawing.Size(56, 252);
            this.roomTempEffectFactorBar.TabIndex = 29;
            this.roomTempEffectFactorBar.Scroll += new System.EventHandler(this.roomTempEffectFactor_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 311);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Effect Factor";
            // 
            // musicVolumeEffectFactorTextBox
            // 
            this.musicVolumeEffectFactorTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicVolumeEffectFactorTextBox.Location = new System.Drawing.Point(413, 331);
            this.musicVolumeEffectFactorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeEffectFactorTextBox.Name = "musicVolumeEffectFactorTextBox";
            this.musicVolumeEffectFactorTextBox.ReadOnly = true;
            this.musicVolumeEffectFactorTextBox.Size = new System.Drawing.Size(71, 22);
            this.musicVolumeEffectFactorTextBox.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Effect Factor";
            // 
            // lightEffectFactorTextBox
            // 
            this.lightEffectFactorTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightEffectFactorTextBox.Location = new System.Drawing.Point(413, 178);
            this.lightEffectFactorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightEffectFactorTextBox.Name = "lightEffectFactorTextBox";
            this.lightEffectFactorTextBox.ReadOnly = true;
            this.lightEffectFactorTextBox.Size = new System.Drawing.Size(71, 22);
            this.lightEffectFactorTextBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 233);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Offset";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Offset";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 233);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Baseline";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Baseline";
            // 
            // musicVolumeOffsetTextBox
            // 
            this.musicVolumeOffsetTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicVolumeOffsetTextBox.Location = new System.Drawing.Point(493, 252);
            this.musicVolumeOffsetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeOffsetTextBox.Name = "musicVolumeOffsetTextBox";
            this.musicVolumeOffsetTextBox.ReadOnly = true;
            this.musicVolumeOffsetTextBox.Size = new System.Drawing.Size(71, 22);
            this.musicVolumeOffsetTextBox.TabIndex = 20;
            // 
            // musicVolumeBaselineTextBox
            // 
            this.musicVolumeBaselineTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicVolumeBaselineTextBox.Location = new System.Drawing.Point(413, 252);
            this.musicVolumeBaselineTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeBaselineTextBox.Name = "musicVolumeBaselineTextBox";
            this.musicVolumeBaselineTextBox.ReadOnly = true;
            this.musicVolumeBaselineTextBox.Size = new System.Drawing.Size(71, 22);
            this.musicVolumeBaselineTextBox.TabIndex = 19;
            // 
            // lightIntensityOffsetTextBox
            // 
            this.lightIntensityOffsetTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightIntensityOffsetTextBox.Location = new System.Drawing.Point(493, 95);
            this.lightIntensityOffsetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightIntensityOffsetTextBox.Name = "lightIntensityOffsetTextBox";
            this.lightIntensityOffsetTextBox.ReadOnly = true;
            this.lightIntensityOffsetTextBox.Size = new System.Drawing.Size(71, 22);
            this.lightIntensityOffsetTextBox.TabIndex = 18;
            // 
            // lightIntensityBaselineTextBox
            // 
            this.lightIntensityBaselineTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightIntensityBaselineTextBox.Location = new System.Drawing.Point(413, 95);
            this.lightIntensityBaselineTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightIntensityBaselineTextBox.Name = "lightIntensityBaselineTextBox";
            this.lightIntensityBaselineTextBox.ReadOnly = true;
            this.lightIntensityBaselineTextBox.Size = new System.Drawing.Size(71, 22);
            this.lightIntensityBaselineTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "-10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Music Volume Effect Factor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Music Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "100%";
            // 
            // automatedControlCheckBox
            // 
            this.automatedControlCheckBox.AutoSize = true;
            this.automatedControlCheckBox.Location = new System.Drawing.Point(8, 23);
            this.automatedControlCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.automatedControlCheckBox.Name = "automatedControlCheckBox";
            this.automatedControlCheckBox.Size = new System.Drawing.Size(230, 21);
            this.automatedControlCheckBox.TabIndex = 10;
            this.automatedControlCheckBox.Text = "Automated Environment Control";
            this.automatedControlCheckBox.UseVisualStyleBackColor = true;
            this.automatedControlCheckBox.CheckedChanged += new System.EventHandler(this.automatedControlBox_CheckedChanged);
            // 
            // lightIntensityEffectFactor
            // 
            this.lightIntensityEffectFactor.AutoSize = true;
            this.lightIntensityEffectFactor.Location = new System.Drawing.Point(45, 137);
            this.lightIntensityEffectFactor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightIntensityEffectFactor.Name = "lightIntensityEffectFactor";
            this.lightIntensityEffectFactor.Size = new System.Drawing.Size(179, 17);
            this.lightIntensityEffectFactor.TabIndex = 9;
            this.lightIntensityEffectFactor.Text = "Light Intensity Effect Factor";
            // 
            // lightIntensityLabel
            // 
            this.lightIntensityLabel.AutoSize = true;
            this.lightIntensityLabel.Location = new System.Drawing.Point(45, 54);
            this.lightIntensityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightIntensityLabel.Name = "lightIntensityLabel";
            this.lightIntensityLabel.Size = new System.Drawing.Size(95, 17);
            this.lightIntensityLabel.TabIndex = 8;
            this.lightIntensityLabel.Text = "Light Intensity";
            // 
            // lightIntensityHighLabel
            // 
            this.lightIntensityHighLabel.AutoSize = true;
            this.lightIntensityHighLabel.Location = new System.Drawing.Point(361, 98);
            this.lightIntensityHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightIntensityHighLabel.Name = "lightIntensityHighLabel";
            this.lightIntensityHighLabel.Size = new System.Drawing.Size(44, 17);
            this.lightIntensityHighLabel.TabIndex = 7;
            this.lightIntensityHighLabel.Text = "100%";
            // 
            // lightIntensityLowLabel
            // 
            this.lightIntensityLowLabel.AutoSize = true;
            this.lightIntensityLowLabel.Location = new System.Drawing.Point(9, 98);
            this.lightIntensityLowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightIntensityLowLabel.Name = "lightIntensityLowLabel";
            this.lightIntensityLowLabel.Size = new System.Drawing.Size(28, 17);
            this.lightIntensityLowLabel.TabIndex = 6;
            this.lightIntensityLowLabel.Text = "0%";
            // 
            // lightIntensityEffectFactorLowLabel
            // 
            this.lightIntensityEffectFactorLowLabel.AutoSize = true;
            this.lightIntensityEffectFactorLowLabel.Location = new System.Drawing.Point(8, 182);
            this.lightIntensityEffectFactorLowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lightIntensityEffectFactorLowLabel.Name = "lightIntensityEffectFactorLowLabel";
            this.lightIntensityEffectFactorLowLabel.Size = new System.Drawing.Size(29, 17);
            this.lightIntensityEffectFactorLowLabel.TabIndex = 5;
            this.lightIntensityEffectFactorLowLabel.Text = "-10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "10";
            // 
            // musicVolumeEffectBar
            // 
            this.musicVolumeEffectBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicVolumeEffectBar.Location = new System.Drawing.Point(49, 314);
            this.musicVolumeEffectBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeEffectBar.Minimum = -10;
            this.musicVolumeEffectBar.Name = "musicVolumeEffectBar";
            this.musicVolumeEffectBar.Size = new System.Drawing.Size(304, 56);
            this.musicVolumeEffectBar.TabIndex = 3;
            this.musicVolumeEffectBar.Value = 7;
            this.musicVolumeEffectBar.Scroll += new System.EventHandler(this.musicVolumeEffectBar_Scroll);
            // 
            // musicVolumeBar
            // 
            this.musicVolumeBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicVolumeBar.Location = new System.Drawing.Point(45, 235);
            this.musicVolumeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicVolumeBar.Maximum = 100;
            this.musicVolumeBar.Name = "musicVolumeBar";
            this.musicVolumeBar.Size = new System.Drawing.Size(308, 56);
            this.musicVolumeBar.TabIndex = 2;
            this.musicVolumeBar.TickFrequency = 10;
            this.musicVolumeBar.Value = 50;
            this.musicVolumeBar.Scroll += new System.EventHandler(this.musicVolumeBar_Scroll);
            // 
            // lightIntensityEffectBar
            // 
            this.lightIntensityEffectBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightIntensityEffectBar.Location = new System.Drawing.Point(45, 156);
            this.lightIntensityEffectBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightIntensityEffectBar.Minimum = -10;
            this.lightIntensityEffectBar.Name = "lightIntensityEffectBar";
            this.lightIntensityEffectBar.Size = new System.Drawing.Size(308, 56);
            this.lightIntensityEffectBar.TabIndex = 1;
            this.lightIntensityEffectBar.Value = 7;
            this.lightIntensityEffectBar.Scroll += new System.EventHandler(this.lightIntensityEffectBar_Scroll);
            // 
            // lightIntensityBar
            // 
            this.lightIntensityBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lightIntensityBar.Location = new System.Drawing.Point(45, 78);
            this.lightIntensityBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lightIntensityBar.Maximum = 100;
            this.lightIntensityBar.Name = "lightIntensityBar";
            this.lightIntensityBar.Size = new System.Drawing.Size(308, 56);
            this.lightIntensityBar.TabIndex = 0;
            this.lightIntensityBar.TickFrequency = 10;
            this.lightIntensityBar.Value = 50;
            this.lightIntensityBar.Scroll += new System.EventHandler(this.lightIntensityBar_Scroll);
            // 
            // inputModelGroup
            // 
            this.inputModelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputModelGroup.Controls.Add(this.bodyTempModelingTextBox);
            this.inputModelGroup.Controls.Add(this.heartRateModelingTextBox);
            this.inputModelGroup.Controls.Add(this.tempHighLabel);
            this.inputModelGroup.Controls.Add(this.activityGroup);
            this.inputModelGroup.Controls.Add(this.tempLowLabel);
            this.inputModelGroup.Controls.Add(this.bodyTempLabel);
            this.inputModelGroup.Controls.Add(this.hr120Label);
            this.inputModelGroup.Controls.Add(this.hr36Label);
            this.inputModelGroup.Controls.Add(this.heartRateModelLabel);
            this.inputModelGroup.Controls.Add(this.bodyTempBar);
            this.inputModelGroup.Controls.Add(this.heartRateBar);
            this.inputModelGroup.Location = new System.Drawing.Point(11, 7);
            this.inputModelGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputModelGroup.Name = "inputModelGroup";
            this.inputModelGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputModelGroup.Size = new System.Drawing.Size(813, 196);
            this.inputModelGroup.TabIndex = 1;
            this.inputModelGroup.TabStop = false;
            this.inputModelGroup.Text = "Input Signals";
            // 
            // bodyTempModelingTextBox
            // 
            this.bodyTempModelingTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bodyTempModelingTextBox.Location = new System.Drawing.Point(432, 140);
            this.bodyTempModelingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyTempModelingTextBox.Name = "bodyTempModelingTextBox";
            this.bodyTempModelingTextBox.ReadOnly = true;
            this.bodyTempModelingTextBox.Size = new System.Drawing.Size(71, 22);
            this.bodyTempModelingTextBox.TabIndex = 9;
            // 
            // heartRateModelingTextBox
            // 
            this.heartRateModelingTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heartRateModelingTextBox.Location = new System.Drawing.Point(432, 60);
            this.heartRateModelingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateModelingTextBox.Name = "heartRateModelingTextBox";
            this.heartRateModelingTextBox.ReadOnly = true;
            this.heartRateModelingTextBox.Size = new System.Drawing.Size(71, 22);
            this.heartRateModelingTextBox.TabIndex = 6;
            // 
            // tempHighLabel
            // 
            this.tempHighLabel.AutoSize = true;
            this.tempHighLabel.Location = new System.Drawing.Point(372, 149);
            this.tempHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempHighLabel.Name = "tempHighLabel";
            this.tempHighLabel.Size = new System.Drawing.Size(44, 17);
            this.tempHighLabel.TabIndex = 8;
            this.tempHighLabel.Text = "120.0";
            // 
            // activityGroup
            // 
            this.activityGroup.Controls.Add(this.activityRadioButton4);
            this.activityGroup.Controls.Add(this.activityRadioButton3);
            this.activityGroup.Controls.Add(this.activityRadioButton2);
            this.activityGroup.Controls.Add(this.activityRadioButton1);
            this.activityGroup.Location = new System.Drawing.Point(548, 23);
            this.activityGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityGroup.Name = "activityGroup";
            this.activityGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityGroup.Size = new System.Drawing.Size(251, 139);
            this.activityGroup.TabIndex = 3;
            this.activityGroup.TabStop = false;
            this.activityGroup.Text = "Activity";
            // 
            // activityRadioButton4
            // 
            this.activityRadioButton4.AutoSize = true;
            this.activityRadioButton4.Location = new System.Drawing.Point(8, 108);
            this.activityRadioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityRadioButton4.Name = "activityRadioButton4";
            this.activityRadioButton4.Size = new System.Drawing.Size(172, 21);
            this.activityRadioButton4.TabIndex = 5;
            this.activityRadioButton4.Text = "Excercise / Very Active";
            this.activityRadioButton4.UseVisualStyleBackColor = true;
            this.activityRadioButton4.CheckedChanged += new System.EventHandler(this.activityRadioButton4_CheckedChanged);
            // 
            // activityRadioButton3
            // 
            this.activityRadioButton3.AutoSize = true;
            this.activityRadioButton3.Location = new System.Drawing.Point(8, 80);
            this.activityRadioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityRadioButton3.Name = "activityRadioButton3";
            this.activityRadioButton3.Size = new System.Drawing.Size(67, 21);
            this.activityRadioButton3.TabIndex = 4;
            this.activityRadioButton3.Text = "Active";
            this.activityRadioButton3.UseVisualStyleBackColor = true;
            this.activityRadioButton3.CheckedChanged += new System.EventHandler(this.activityRadioButton3_CheckedChanged);
            // 
            // activityRadioButton2
            // 
            this.activityRadioButton2.AutoSize = true;
            this.activityRadioButton2.Location = new System.Drawing.Point(8, 52);
            this.activityRadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityRadioButton2.Name = "activityRadioButton2";
            this.activityRadioButton2.Size = new System.Drawing.Size(60, 21);
            this.activityRadioButton2.TabIndex = 3;
            this.activityRadioButton2.Text = "Calm";
            this.activityRadioButton2.UseVisualStyleBackColor = true;
            this.activityRadioButton2.CheckedChanged += new System.EventHandler(this.activityRadioButton2_CheckedChanged);
            // 
            // activityRadioButton1
            // 
            this.activityRadioButton1.AutoSize = true;
            this.activityRadioButton1.Checked = true;
            this.activityRadioButton1.Location = new System.Drawing.Point(8, 23);
            this.activityRadioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activityRadioButton1.Name = "activityRadioButton1";
            this.activityRadioButton1.Size = new System.Drawing.Size(77, 21);
            this.activityRadioButton1.TabIndex = 2;
            this.activityRadioButton1.TabStop = true;
            this.activityRadioButton1.Text = "Resting";
            this.activityRadioButton1.UseVisualStyleBackColor = true;
            this.activityRadioButton1.CheckedChanged += new System.EventHandler(this.activityRadioButton1_CheckedChanged);
            // 
            // tempLowLabel
            // 
            this.tempLowLabel.AutoSize = true;
            this.tempLowLabel.Location = new System.Drawing.Point(20, 149);
            this.tempLowLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempLowLabel.Name = "tempLowLabel";
            this.tempLowLabel.Size = new System.Drawing.Size(36, 17);
            this.tempLowLabel.TabIndex = 2;
            this.tempLowLabel.Text = "80.0";
            // 
            // bodyTempLabel
            // 
            this.bodyTempLabel.AutoSize = true;
            this.bodyTempLabel.Location = new System.Drawing.Point(59, 108);
            this.bodyTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bodyTempLabel.Name = "bodyTempLabel";
            this.bodyTempLabel.Size = new System.Drawing.Size(80, 17);
            this.bodyTempLabel.TabIndex = 7;
            this.bodyTempLabel.Text = "Body Temp";
            // 
            // hr120Label
            // 
            this.hr120Label.AutoSize = true;
            this.hr120Label.Location = new System.Drawing.Point(372, 69);
            this.hr120Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hr120Label.Name = "hr120Label";
            this.hr120Label.Size = new System.Drawing.Size(32, 17);
            this.hr120Label.TabIndex = 6;
            this.hr120Label.Text = "120";
            // 
            // hr36Label
            // 
            this.hr36Label.AutoSize = true;
            this.hr36Label.Location = new System.Drawing.Point(35, 69);
            this.hr36Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hr36Label.Name = "hr36Label";
            this.hr36Label.Size = new System.Drawing.Size(24, 17);
            this.hr36Label.TabIndex = 5;
            this.hr36Label.Text = "36";
            // 
            // heartRateModelLabel
            // 
            this.heartRateModelLabel.AutoSize = true;
            this.heartRateModelLabel.Location = new System.Drawing.Point(59, 27);
            this.heartRateModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heartRateModelLabel.Name = "heartRateModelLabel";
            this.heartRateModelLabel.Size = new System.Drawing.Size(118, 17);
            this.heartRateModelLabel.TabIndex = 4;
            this.heartRateModelLabel.Text = "Heart Rate (bpm)";
            // 
            // bodyTempBar
            // 
            this.bodyTempBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bodyTempBar.Location = new System.Drawing.Point(63, 128);
            this.bodyTempBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyTempBar.Maximum = 120;
            this.bodyTempBar.Minimum = 80;
            this.bodyTempBar.Name = "bodyTempBar";
            this.bodyTempBar.Size = new System.Drawing.Size(308, 56);
            this.bodyTempBar.TabIndex = 1;
            this.bodyTempBar.TickFrequency = 2;
            this.bodyTempBar.Value = 99;
            this.bodyTempBar.Scroll += new System.EventHandler(this.bodyTempBar_Scroll);
            // 
            // heartRateBar
            // 
            this.heartRateBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.heartRateBar.Location = new System.Drawing.Point(63, 47);
            this.heartRateBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heartRateBar.Maximum = 120;
            this.heartRateBar.Minimum = 36;
            this.heartRateBar.Name = "heartRateBar";
            this.heartRateBar.Size = new System.Drawing.Size(308, 56);
            this.heartRateBar.TabIndex = 0;
            this.heartRateBar.TickFrequency = 6;
            this.heartRateBar.Value = 70;
            this.heartRateBar.Scroll += new System.EventHandler(this.heartRateBar_Scroll);
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.txtLog);
            this.logTab.Location = new System.Drawing.Point(4, 26);
            this.logTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logTab.Size = new System.Drawing.Size(837, 638);
            this.logTab.TabIndex = 4;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(8, 7);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(812, 613);
            this.txtLog.TabIndex = 0;
            // 
            // displayTimer
            // 
            this.displayTimer.Interval = 2000;
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // modelTimer
            // 
            this.modelTimer.Interval = 500;
            this.modelTimer.Tick += new System.EventHandler(this.modelTimer_Tick);
            // 
            // outputTimer
            // 
            this.outputTimer.Interval = 1000;
            this.outputTimer.Tick += new System.EventHandler(this.outputTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 668);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(861, 670);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Environment Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.terminalDeviceGroupBox.ResumeLayout(false);
            this.tempOffsetGroupBox.ResumeLayout(false);
            this.tempOffsetGroupBox.PerformLayout();
            this.musicGroupBox.ResumeLayout(false);
            this.musicGroupBox.PerformLayout();
            this.lightGroupBox.ResumeLayout(false);
            this.lightGroupBox.PerformLayout();
            this.outputBLEBox.ResumeLayout(false);
            this.outputBLEBox.PerformLayout();
            this.connectionStateBoxOutput.ResumeLayout(false);
            this.inputBox.ResumeLayout(false);
            this.activityOutputGroupBox.ResumeLayout(false);
            this.activityOutputGroupBox.PerformLayout();
            this.accelGroupBox.ResumeLayout(false);
            this.accelGroupBox.PerformLayout();
            this.temperatureGroupBox.ResumeLayout(false);
            this.temperatureGroupBox.PerformLayout();
            this.heartRateBox.ResumeLayout(false);
            this.heartRateBox.PerformLayout();
            this.inputBLEBox.ResumeLayout(false);
            this.inputBLEBox.PerformLayout();
            this.connectionStateBoxInput.ResumeLayout(false);
            this.serialPortGroupBox.ResumeLayout(false);
            this.serialPortGroupBox.PerformLayout();
            this.modelTab.ResumeLayout(false);
            this.outputSettingsBox.ResumeLayout(false);
            this.outputSettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTempEffectFactorBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeEffectBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightIntensityEffectBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightIntensityBar)).EndInit();
            this.inputModelGroup.ResumeLayout(false);
            this.inputModelGroup.PerformLayout();
            this.activityGroup.ResumeLayout(false);
            this.activityGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bodyTempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateBar)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.Label lblPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.RadioButton ble41RadioButtonInput;
        private System.Windows.Forms.GroupBox inputBLEBox;
        private System.Windows.Forms.RadioButton ble3fRadioButtonInput;
        private System.Windows.Forms.GroupBox connectionStateBoxInput;
        private System.Windows.Forms.Panel connectedPanelInput;
        private System.Windows.Forms.GroupBox outputBLEBox;
        private System.Windows.Forms.RadioButton ble41RadioButtonOutput;
        private System.Windows.Forms.RadioButton ble3fRadioButtonOutput;
        private System.Windows.Forms.GroupBox connectionStateBoxOutput;
        private System.Windows.Forms.Button disconnectButtonOutput;
        private System.Windows.Forms.Panel connectPanelOutput;
        private System.Windows.Forms.Button connectButtonOutput;
        private System.Windows.Forms.Button disconnectButtonInput;
        private System.Windows.Forms.Button connectedButtonInput;
        private System.Windows.Forms.GroupBox serialPortGroupBox;
        private System.Windows.Forms.Panel serialPortPanel;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox terminalDeviceGroupBox;
        private System.Windows.Forms.GroupBox tempOffsetGroupBox;
        private System.Windows.Forms.Label roomTempFLabel;
        private System.Windows.Forms.TextBox roomTemperatureOffsetTextBox;
        private System.Windows.Forms.Label tempOffsetLabel;
        private System.Windows.Forms.GroupBox musicGroupBox;
        private System.Windows.Forms.Label musicVolumePercentageLabel;
        private System.Windows.Forms.TextBox musicVolumeTextBox;
        private System.Windows.Forms.Label musicVolumeLabel;
        private System.Windows.Forms.GroupBox lightGroupBox;
        private System.Windows.Forms.Label lightPercentageLabel;
        private System.Windows.Forms.TextBox lightIntensityTextBox;
        private System.Windows.Forms.Label lightLabel;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.GroupBox accelGroupBox;
        private System.Windows.Forms.Label zGLabel;
        private System.Windows.Forms.TextBox accelZAxisTextBox;
        private System.Windows.Forms.TextBox accelZAxisRawDataTextBox;
        private System.Windows.Forms.Label accelZAxisLabel;
        private System.Windows.Forms.Label yGLabel;
        private System.Windows.Forms.TextBox accelYAxisTextBox;
        private System.Windows.Forms.TextBox accelYAxisRawDataTextBox;
        private System.Windows.Forms.Label accelYAxisLabel;
        private System.Windows.Forms.Label xGLabel;
        private System.Windows.Forms.Label accelerationLabel;
        private System.Windows.Forms.Label accelRawDataLabel;
        private System.Windows.Forms.TextBox accelXAxisTextBox;
        private System.Windows.Forms.TextBox accelXAxisRawDataTextBox;
        private System.Windows.Forms.Label accelXAxisLabel;
        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temperatureMeasurementLabel;
        private System.Windows.Forms.Label temperatureRawDataLabel;
        private System.Windows.Forms.TextBox bodyTempTextBox;
        private System.Windows.Forms.TextBox tempRawDataTextBox;
        private System.Windows.Forms.Label currentTemperatureMeasurementLabel;
        private System.Windows.Forms.GroupBox heartRateBox;
        private System.Windows.Forms.Label bpmLabel;
        private System.Windows.Forms.Label heartRateActualMeasurementLabel;
        private System.Windows.Forms.Label heartRateRawDataLabel;
        private System.Windows.Forms.TextBox heartRateTextBox;
        private System.Windows.Forms.TextBox heartRateRawDataTextBox;
        private System.Windows.Forms.Label heartRateMeasurementLabel;
        private System.Windows.Forms.TabPage modelTab;
        private System.Windows.Forms.GroupBox inputModelGroup;
        private System.Windows.Forms.Label heartRateModelLabel;
        private System.Windows.Forms.GroupBox activityGroup;
        private System.Windows.Forms.RadioButton activityRadioButton1;
        private System.Windows.Forms.TrackBar bodyTempBar;
        private System.Windows.Forms.TrackBar heartRateBar;
        private System.Windows.Forms.Label tempHighLabel;
        private System.Windows.Forms.Label tempLowLabel;
        private System.Windows.Forms.Label bodyTempLabel;
        private System.Windows.Forms.Label hr120Label;
        private System.Windows.Forms.Label hr36Label;
        private System.Windows.Forms.RadioButton activityRadioButton4;
        private System.Windows.Forms.RadioButton activityRadioButton3;
        private System.Windows.Forms.RadioButton activityRadioButton2;
        private System.Windows.Forms.TextBox bodyTempModelingTextBox;
        private System.Windows.Forms.TextBox heartRateModelingTextBox;
        private System.Windows.Forms.RadioButton systemModelingRadioButtonInput;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Timer modelTimer;
        private System.Windows.Forms.GroupBox outputSettingsBox;
        private System.Windows.Forms.TrackBar musicVolumeEffectBar;
        private System.Windows.Forms.TrackBar musicVolumeBar;
        private System.Windows.Forms.TrackBar lightIntensityEffectBar;
        private System.Windows.Forms.TrackBar lightIntensityBar;
        private System.Windows.Forms.Label lightIntensityLabel;
        private System.Windows.Forms.Label lightIntensityHighLabel;
        private System.Windows.Forms.Label lightIntensityLowLabel;
        private System.Windows.Forms.Label lightIntensityEffectFactorLowLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox automatedControlCheckBox;
        private System.Windows.Forms.Label lightIntensityEffectFactor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox musicVolumeOffsetTextBox;
        private System.Windows.Forms.TextBox musicVolumeBaselineTextBox;
        private System.Windows.Forms.TextBox lightIntensityOffsetTextBox;
        private System.Windows.Forms.TextBox lightIntensityBaselineTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox musicVolumeEffectFactorTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lightEffectFactorTextBox;
        private System.Windows.Forms.GroupBox activityOutputGroupBox;
        private System.Windows.Forms.RadioButton activityOutputRadio4;
        private System.Windows.Forms.RadioButton activityOutputRadio3;
        private System.Windows.Forms.RadioButton activityOutputRadio2;
        private System.Windows.Forms.RadioButton activityOutputRadio1;
        private System.Windows.Forms.TrackBar roomTempEffectFactorBar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox roomTempEffectFactorTextBox;
        private System.Windows.Forms.Timer outputTimer;
    }
}

