namespace STM32_Solar_Tracker_Control_Panel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PortLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BaudRateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAuto = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.led2StatusLabel = new System.Windows.Forms.Label();
            this.led4StatusLabel = new System.Windows.Forms.Label();
            this.ServoStatusLabel = new System.Windows.Forms.Label();
            this.Sensor2StatusLabel = new System.Windows.Forms.Label();
            this.Sensor1StatusLabel = new System.Windows.Forms.Label();
            this.led5StatusLabel = new System.Windows.Forms.Label();
            this.led3StatusLabel = new System.Windows.Forms.Label();
            this.led1StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.ledPanel = new System.Windows.Forms.Panel();
            this.ledSym1 = new System.Windows.Forms.PictureBox();
            this.ledSym2 = new System.Windows.Forms.PictureBox();
            this.ledSym3 = new System.Windows.Forms.PictureBox();
            this.ledSym4 = new System.Windows.Forms.PictureBox();
            this.ledSym5 = new System.Windows.Forms.PictureBox();
            this.armSym = new System.Windows.Forms.PictureBox();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.Receive = new System.Windows.Forms.GroupBox();
            this.receiveField = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valueOptionLed = new System.Windows.Forms.GroupBox();
            this.btnOFF = new System.Windows.Forms.RadioButton();
            this.btnON = new System.Windows.Forms.RadioButton();
            this.valueOptionServo = new System.Windows.Forms.GroupBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valueScrollBar = new System.Windows.Forms.TrackBar();
            this.deviceNumberList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAuto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.ledPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armSym)).BeginInit();
            this.tabManual.SuspendLayout();
            this.Receive.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.valueOptionLed.SuspendLayout();
            this.valueOptionServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueScrollBar)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            resources.ApplyResources(this.portToolStripMenuItem, "portToolStripMenuItem");
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.DropDownOpening += new System.EventHandler(this.portToolStripMenuItem_Click);
            this.portToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.portToolStripMenuItem_DropDownItemClicked);
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            resources.ApplyResources(this.speedToolStripMenuItem, "speedToolStripMenuItem");
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedToolStripMenuItem_DropDownItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.CheckOnClick = true;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.CheckOnClick = true;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.CheckOnClick = true;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            resources.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.CheckOnClick = true;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            resources.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.CheckOnClick = true;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            resources.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.CheckOnClick = true;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            resources.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortLabel,
            this.BaudRateLabel,
            this.StatusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // PortLabel
            // 
            this.PortLabel.Name = "PortLabel";
            resources.ApplyResources(this.PortLabel, "PortLabel");
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.Name = "BaudRateLabel";
            resources.ApplyResources(this.BaudRateLabel, "BaudRateLabel");
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAuto);
            this.tabControl1.Controls.Add(this.tabManual);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabAuto
            // 
            this.tabAuto.Controls.Add(this.groupBox3);
            this.tabAuto.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabAuto, "tabAuto");
            this.tabAuto.Name = "tabAuto";
            this.tabAuto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataPanel);
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // led2StatusLabel
            // 
            resources.ApplyResources(this.led2StatusLabel, "led2StatusLabel");
            this.led2StatusLabel.Name = "led2StatusLabel";
            // 
            // led4StatusLabel
            // 
            resources.ApplyResources(this.led4StatusLabel, "led4StatusLabel");
            this.led4StatusLabel.Name = "led4StatusLabel";
            // 
            // ServoStatusLabel
            // 
            resources.ApplyResources(this.ServoStatusLabel, "ServoStatusLabel");
            this.ServoStatusLabel.Name = "ServoStatusLabel";
            // 
            // Sensor2StatusLabel
            // 
            resources.ApplyResources(this.Sensor2StatusLabel, "Sensor2StatusLabel");
            this.Sensor2StatusLabel.Name = "Sensor2StatusLabel";
            // 
            // Sensor1StatusLabel
            // 
            resources.ApplyResources(this.Sensor1StatusLabel, "Sensor1StatusLabel");
            this.Sensor1StatusLabel.Name = "Sensor1StatusLabel";
            // 
            // led5StatusLabel
            // 
            resources.ApplyResources(this.led5StatusLabel, "led5StatusLabel");
            this.led5StatusLabel.Name = "led5StatusLabel";
            // 
            // led3StatusLabel
            // 
            resources.ApplyResources(this.led3StatusLabel, "led3StatusLabel");
            this.led3StatusLabel.Name = "led3StatusLabel";
            // 
            // led1StatusLabel
            // 
            resources.ApplyResources(this.led1StatusLabel, "led1StatusLabel");
            this.led1StatusLabel.Name = "led1StatusLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledPanel);
            this.groupBox1.Controls.Add(this.armSym);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.led1StatusLabel);
            this.dataPanel.Controls.Add(this.led2StatusLabel);
            this.dataPanel.Controls.Add(this.led3StatusLabel);
            this.dataPanel.Controls.Add(this.led4StatusLabel);
            this.dataPanel.Controls.Add(this.led5StatusLabel);
            this.dataPanel.Controls.Add(this.ServoStatusLabel);
            this.dataPanel.Controls.Add(this.Sensor1StatusLabel);
            this.dataPanel.Controls.Add(this.Sensor2StatusLabel);
            resources.ApplyResources(this.dataPanel, "dataPanel");
            this.dataPanel.Name = "dataPanel";
            // 
            // ledPanel
            // 
            this.ledPanel.Controls.Add(this.ledSym1);
            this.ledPanel.Controls.Add(this.ledSym2);
            this.ledPanel.Controls.Add(this.ledSym4);
            this.ledPanel.Controls.Add(this.ledSym3);
            this.ledPanel.Controls.Add(this.ledSym5);
            resources.ApplyResources(this.ledPanel, "ledPanel");
            this.ledPanel.Name = "ledPanel";
            // 
            // ledSym1
            // 
            this.ledSym1.Image = global::STM32_Solar_Tracker_Control_Panel.Properties.Resources.led;
            resources.ApplyResources(this.ledSym1, "ledSym1");
            this.ledSym1.Name = "ledSym1";
            this.ledSym1.TabStop = false;
            // 
            // ledSym2
            // 
            this.ledSym2.Image = global::STM32_Solar_Tracker_Control_Panel.Properties.Resources.led;
            resources.ApplyResources(this.ledSym2, "ledSym2");
            this.ledSym2.Name = "ledSym2";
            this.ledSym2.TabStop = false;
            // 
            // ledSym3
            // 
            this.ledSym3.Image = global::STM32_Solar_Tracker_Control_Panel.Properties.Resources.led;
            resources.ApplyResources(this.ledSym3, "ledSym3");
            this.ledSym3.Name = "ledSym3";
            this.ledSym3.TabStop = false;
            // 
            // ledSym4
            // 
            this.ledSym4.Image = global::STM32_Solar_Tracker_Control_Panel.Properties.Resources.led;
            resources.ApplyResources(this.ledSym4, "ledSym4");
            this.ledSym4.Name = "ledSym4";
            this.ledSym4.TabStop = false;
            // 
            // ledSym5
            // 
            this.ledSym5.Image = global::STM32_Solar_Tracker_Control_Panel.Properties.Resources.led;
            resources.ApplyResources(this.ledSym5, "ledSym5");
            this.ledSym5.Name = "ledSym5";
            this.ledSym5.TabStop = false;
            // 
            // armSym
            // 
            resources.ApplyResources(this.armSym, "armSym");
            this.armSym.Name = "armSym";
            this.armSym.TabStop = false;
            this.armSym.Paint += new System.Windows.Forms.PaintEventHandler(this.armSym_Paint);
            // 
            // tabManual
            // 
            this.tabManual.Controls.Add(this.Receive);
            this.tabManual.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabManual, "tabManual");
            this.tabManual.Name = "tabManual";
            this.tabManual.UseVisualStyleBackColor = true;
            // 
            // Receive
            // 
            this.Receive.Controls.Add(this.receiveField);
            resources.ApplyResources(this.Receive, "Receive");
            this.Receive.Name = "Receive";
            this.Receive.TabStop = false;
            // 
            // receiveField
            // 
            resources.ApplyResources(this.receiveField, "receiveField");
            this.receiveField.Name = "receiveField";
            this.receiveField.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deviceNumberList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.deviceTypeComboBox);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.valueOptionServo);
            this.groupBox2.Controls.Add(this.valueOptionLed);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // valueOptionLed
            // 
            this.valueOptionLed.Controls.Add(this.btnOFF);
            this.valueOptionLed.Controls.Add(this.btnON);
            resources.ApplyResources(this.valueOptionLed, "valueOptionLed");
            this.valueOptionLed.Name = "valueOptionLed";
            this.valueOptionLed.TabStop = false;
            this.valueOptionLed.MouseHover += new System.EventHandler(this.valueOptionLed_MouseHover);
            // 
            // btnOFF
            // 
            resources.ApplyResources(this.btnOFF, "btnOFF");
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.TabStop = true;
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // btnON
            // 
            resources.ApplyResources(this.btnON, "btnON");
            this.btnON.Name = "btnON";
            this.btnON.TabStop = true;
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // valueOptionServo
            // 
            this.valueOptionServo.Controls.Add(this.valueBox);
            this.valueOptionServo.Controls.Add(this.label4);
            this.valueOptionServo.Controls.Add(this.valueScrollBar);
            resources.ApplyResources(this.valueOptionServo, "valueOptionServo");
            this.valueOptionServo.Name = "valueOptionServo";
            this.valueOptionServo.TabStop = false;
            this.valueOptionServo.MouseHover += new System.EventHandler(this.valueOptionServo_MouseHover);
            // 
            // valueBox
            // 
            this.valueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.valueBox, "valueBox");
            this.valueBox.Name = "valueBox";
            this.valueBox.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // valueScrollBar
            // 
            resources.ApplyResources(this.valueScrollBar, "valueScrollBar");
            this.valueScrollBar.Maximum = 180;
            this.valueScrollBar.Name = "valueScrollBar";
            this.valueScrollBar.ValueChanged += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // deviceNumberList
            // 
            this.deviceNumberList.FormattingEnabled = true;
            resources.ApplyResources(this.deviceNumberList, "deviceNumberList");
            this.deviceNumberList.Name = "deviceNumberList";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // deviceTypeComboBox
            // 
            this.deviceTypeComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.deviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("deviceTypeComboBox.Items"),
            resources.GetString("deviceTypeComboBox.Items1")});
            resources.ApplyResources(this.deviceTypeComboBox, "deviceTypeComboBox");
            this.deviceTypeComboBox.Name = "deviceTypeComboBox";
            this.deviceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceTypeComboBox_SelectedIndexChanged);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAuto.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ledPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledSym1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSym5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armSym)).EndInit();
            this.tabManual.ResumeLayout(false);
            this.Receive.ResumeLayout(false);
            this.Receive.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.valueOptionLed.ResumeLayout(false);
            this.valueOptionLed.PerformLayout();
            this.valueOptionServo.ResumeLayout(false);
            this.valueOptionServo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueScrollBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PortLabel;
        private System.Windows.Forms.ToolStripStatusLabel BaudRateLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAuto;
        private System.Windows.Forms.TabPage tabManual;
        private System.Windows.Forms.GroupBox Receive;
        private System.Windows.Forms.TextBox receiveField;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox valueOptionLed;
        private System.Windows.Forms.RadioButton btnOFF;
        private System.Windows.Forms.RadioButton btnON;
        private System.Windows.Forms.GroupBox valueOptionServo;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar valueScrollBar;
        private System.Windows.Forms.ListBox deviceNumberList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox deviceTypeComboBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox ledSym5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox armSym;
        private System.Windows.Forms.PictureBox ledSym1;
        private System.Windows.Forms.PictureBox ledSym2;
        private System.Windows.Forms.PictureBox ledSym3;
        private System.Windows.Forms.PictureBox ledSym4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label led2StatusLabel;
        private System.Windows.Forms.Label led4StatusLabel;
        private System.Windows.Forms.Label ServoStatusLabel;
        private System.Windows.Forms.Label Sensor2StatusLabel;
        private System.Windows.Forms.Label Sensor1StatusLabel;
        private System.Windows.Forms.Label led5StatusLabel;
        private System.Windows.Forms.Label led3StatusLabel;
        private System.Windows.Forms.Label led1StatusLabel;
        private System.Windows.Forms.Panel ledPanel;
        private System.Windows.Forms.Panel dataPanel;
    }
}

