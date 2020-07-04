namespace PingTracer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPingsPerSecond = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblReplSuccessful = new System.Windows.Forms.Label();
            this.lblReplFailed = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_Graphs = new System.Windows.Forms.Panel();
            this.labelGraphIntro = new System.Windows.Forms.Label();
            this.cbTraceroute = new System.Windows.Forms.CheckBox();
            this.contextMenuStripHostHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.cbReverseDNS = new System.Windows.Forms.CheckBox();
            this.menuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mi_File = new System.Windows.Forms.MenuItem();
            this.mi_File_Exit = new System.Windows.Forms.MenuItem();
            this.mi_Export = new System.Windows.Forms.MenuItem();
            this.mi_Export_snapshotGraphs = new System.Windows.Forms.MenuItem();
            this.mi_Tools = new System.Windows.Forms.MenuItem();
            this.mi_Tools_Options = new System.Windows.Forms.MenuItem();
            this.mi_Tools_deleteHost = new System.Windows.Forms.MenuItem();
            this.comboPingsPerSecond = new System.Windows.Forms.ComboBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.groupBoxPingOpts = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxGraphOpts = new System.Windows.Forms.GroupBox();
            this.cbLastPing = new System.Windows.Forms.CheckBox();
            this.cbJitter = new System.Windows.Forms.CheckBox();
            this.cbAverage = new System.Windows.Forms.CheckBox();
            this.cbAlwaysShowServerNames = new System.Windows.Forms.CheckBox();
            this.cbMinMax = new System.Windows.Forms.CheckBox();
            this.cbPacketLoss = new System.Windows.Forms.CheckBox();
            this.nudBadThreshold = new System.Windows.Forms.NumericUpDown();
            this.nudWorseThreshold = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSuccessLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSuccessValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFailLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFailValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPingsPerSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Graphs.SuspendLayout();
            this.groupBoxPingOpts.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxGraphOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBadThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorseThreshold)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOut.Location = new System.Drawing.Point(0, 0);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(940, 30);
            this.txtOut.TabIndex = 15;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.ForeColor = System.Drawing.Color.Blue;
            this.lblHost.Location = new System.Drawing.Point(5, 24);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host:";
            this.toolTip1.SetToolTip(this.lblHost, "Enter a comma delimited IP address and/or host name list of destination(s) you wi" +
        "sh to monitor.\r\n\r\n You may click the blue Host label to choose a previously ente" +
        "red set name.");
            this.lblHost.Click += new System.EventHandler(this.lblHost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate:";
            this.toolTip1.SetToolTip(this.label2, "A rate of 1 ping per second is recommended \r\nfor all long-term monitoring.");
            // 
            // nudPingsPerSecond
            // 
            this.nudPingsPerSecond.Location = new System.Drawing.Point(43, 47);
            this.nudPingsPerSecond.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPingsPerSecond.Name = "nudPingsPerSecond";
            this.nudPingsPerSecond.Size = new System.Drawing.Size(46, 20);
            this.nudPingsPerSecond.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nudPingsPerSecond, "A rate of 1 ping per second is recommended \r\nfor all long-term monitoring.");
            this.nudPingsPerSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPingsPerSecond.ValueChanged += new System.EventHandler(this.nudPingsPerSecond_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(523, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 46);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Click to Start";
            this.toolTip1.SetToolTip(this.btnStart, "This button shows the current status of ping monitoring.\r\n\r\nClick the button to s" +
        "tart or stop.");
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblReplSuccessful
            // 
            this.lblReplSuccessful.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReplSuccessful.AutoSize = true;
            this.lblReplSuccessful.Location = new System.Drawing.Point(80, 367);
            this.lblReplSuccessful.Name = "lblReplSuccessful";
            this.lblReplSuccessful.Size = new System.Drawing.Size(13, 13);
            this.lblReplSuccessful.TabIndex = 9;
            this.lblReplSuccessful.Text = "0";
            // 
            // lblReplFailed
            // 
            this.lblReplFailed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReplFailed.AutoSize = true;
            this.lblReplFailed.Location = new System.Drawing.Point(206, 367);
            this.lblReplFailed.Name = "lblReplFailed";
            this.lblReplFailed.Size = new System.Drawing.Size(13, 13);
            this.lblReplFailed.TabIndex = 11;
            this.lblReplFailed.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 181);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtOut);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Graphs);
            this.splitContainer1.Size = new System.Drawing.Size(940, 206);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 12;
            // 
            // panel_Graphs
            // 
            this.panel_Graphs.BackColor = System.Drawing.SystemColors.Window;
            this.panel_Graphs.Controls.Add(this.statusStrip1);
            this.panel_Graphs.Controls.Add(this.labelGraphIntro);
            this.panel_Graphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Graphs.Location = new System.Drawing.Point(0, 0);
            this.panel_Graphs.Name = "panel_Graphs";
            this.panel_Graphs.Size = new System.Drawing.Size(940, 172);
            this.panel_Graphs.TabIndex = 16;
            this.panel_Graphs.Click += new System.EventHandler(this.panel_Graphs_Click);
            this.panel_Graphs.Resize += new System.EventHandler(this.panel_Graphs_Resize);
            // 
            // labelGraphIntro
            // 
            this.labelGraphIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGraphIntro.BackColor = System.Drawing.SystemColors.Window;
            this.labelGraphIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelGraphIntro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelGraphIntro.Location = new System.Drawing.Point(2, 12);
            this.labelGraphIntro.Name = "labelGraphIntro";
            this.labelGraphIntro.Size = new System.Drawing.Size(935, 91);
            this.labelGraphIntro.TabIndex = 0;
            this.labelGraphIntro.Text = "Ping response graphs will appear here. \r\n\r\nTry clicking the graph(s) after you ac" +
    "tivate ping tracing.";
            this.labelGraphIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTraceroute
            // 
            this.cbTraceroute.AutoSize = true;
            this.cbTraceroute.Checked = true;
            this.cbTraceroute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTraceroute.Location = new System.Drawing.Point(246, 48);
            this.cbTraceroute.Name = "cbTraceroute";
            this.cbTraceroute.Size = new System.Drawing.Size(86, 17);
            this.cbTraceroute.TabIndex = 6;
            this.cbTraceroute.Text = "Trace Route";
            this.toolTip1.SetToolTip(this.cbTraceroute, "If checked, a traceroute operation will be performed \r\nand multiple destinations " +
        "may be monitored.");
            this.cbTraceroute.UseVisualStyleBackColor = true;
            this.cbTraceroute.CheckedChanged += new System.EventHandler(this.cbTraceroute_CheckedChanged);
            // 
            // contextMenuStripHostHistory
            // 
            this.contextMenuStripHostHistory.Name = "contextMenuStripHostHistory";
            this.contextMenuStripHostHistory.ShowImageMargin = false;
            this.contextMenuStripHostHistory.Size = new System.Drawing.Size(36, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Display Name:";
            this.toolTip1.SetToolTip(this.label1, "(Optional) \r\nA memorable name to show in the history \r\nwhen you click on the blue" +
        " Host label.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 50;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(314, 21);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(195, 20);
            this.txtDisplayName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDisplayName, "(Optional) \r\nA memorable name to show in the history \r\nwhen you click on the blue" +
        " Host label.");
            this.txtDisplayName.TextChanged += new System.EventHandler(this.txtDisplayName_TextChanged);
            // 
            // cbReverseDNS
            // 
            this.cbReverseDNS.AutoSize = true;
            this.cbReverseDNS.Checked = true;
            this.cbReverseDNS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReverseDNS.Location = new System.Drawing.Point(355, 48);
            this.cbReverseDNS.Name = "cbReverseDNS";
            this.cbReverseDNS.Size = new System.Drawing.Size(161, 17);
            this.cbReverseDNS.TabIndex = 7;
            this.cbReverseDNS.Text = "Reverse DNS Lookup (slow)";
            this.toolTip1.SetToolTip(this.cbReverseDNS, "If checked, reverse DNS lookups are performed on each IP address to find the host" +
        " name.");
            this.cbReverseDNS.UseVisualStyleBackColor = true;
            this.cbReverseDNS.CheckedChanged += new System.EventHandler(this.cbReverseDNS_CheckedChanged);
            // 
            // menuMain
            // 
            this.menuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_File,
            this.mi_Export,
            this.mi_Tools});
            // 
            // mi_File
            // 
            this.mi_File.Index = 0;
            this.mi_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_File_Exit});
            this.mi_File.Text = "&File";
            // 
            // mi_File_Exit
            // 
            this.mi_File_Exit.Index = 0;
            this.mi_File_Exit.Text = "E&xit";
            this.mi_File_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // mi_Export
            // 
            this.mi_Export.Index = 1;
            this.mi_Export.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_Export_snapshotGraphs});
            this.mi_Export.Text = "E&xport";
            // 
            // mi_Export_snapshotGraphs
            // 
            this.mi_Export_snapshotGraphs.Index = 0;
            this.mi_Export_snapshotGraphs.Text = "&Snapshot of graphs";
            this.mi_Export_snapshotGraphs.Click += new System.EventHandler(this.mi_snapshotGraphs_Click);
            // 
            // mi_Tools
            // 
            this.mi_Tools.Index = 2;
            this.mi_Tools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi_Tools_Options,
            this.mi_Tools_deleteHost});
            this.mi_Tools.Text = "&Tools";
            // 
            // mi_Tools_Options
            // 
            this.mi_Tools_Options.Index = 0;
            this.mi_Tools_Options.Text = "&Options";
            this.mi_Tools_Options.Click += new System.EventHandler(this.mi_Options_Click);
            // 
            // mi_Tools_deleteHost
            // 
            this.mi_Tools_deleteHost.Index = 1;
            this.mi_Tools_deleteHost.Text = "Delete Current Host";
            this.mi_Tools_deleteHost.Click += new System.EventHandler(this.mi_deleteHost_Click);
            // 
            // comboPingsPerSecond
            // 
            this.comboPingsPerSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPingsPerSecond.FormattingEnabled = true;
            this.comboPingsPerSecond.Items.AddRange(new object[] {
            "pings per second",
            "seconds per ping"});
            this.comboPingsPerSecond.Location = new System.Drawing.Point(95, 46);
            this.comboPingsPerSecond.Name = "comboPingsPerSecond";
            this.comboPingsPerSecond.Size = new System.Drawing.Size(132, 21);
            this.comboPingsPerSecond.TabIndex = 5;
            this.comboPingsPerSecond.SelectedIndexChanged += new System.EventHandler(this.selectPingsPerSecond_SelectedIndexChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(43, 21);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(184, 20);
            this.txtHost.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtHost, "Enter a comma delimited IP address and/or host name list of destination(s) you wi" +
        "sh to monitor.\r\n\r\n You may click the blue Host label to choose a previously ente" +
        "red set name.");
            // 
            // groupBoxPingOpts
            // 
            this.groupBoxPingOpts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxPingOpts.Controls.Add(this.comboPingsPerSecond);
            this.groupBoxPingOpts.Controls.Add(this.txtHost);
            this.groupBoxPingOpts.Controls.Add(this.lblHost);
            this.groupBoxPingOpts.Controls.Add(this.cbReverseDNS);
            this.groupBoxPingOpts.Controls.Add(this.label2);
            this.groupBoxPingOpts.Controls.Add(this.nudPingsPerSecond);
            this.groupBoxPingOpts.Controls.Add(this.txtDisplayName);
            this.groupBoxPingOpts.Controls.Add(this.btnStart);
            this.groupBoxPingOpts.Controls.Add(this.label1);
            this.groupBoxPingOpts.Controls.Add(this.cbTraceroute);
            this.groupBoxPingOpts.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPingOpts.Name = "groupBoxPingOpts";
            this.groupBoxPingOpts.Size = new System.Drawing.Size(600, 95);
            this.groupBoxPingOpts.TabIndex = 23;
            this.groupBoxPingOpts.TabStop = false;
            this.groupBoxPingOpts.Text = "Ping Options:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxPingOpts);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxGraphOpts);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 181);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // groupBoxGraphOpts
            // 
            this.groupBoxGraphOpts.Controls.Add(this.cbLastPing);
            this.groupBoxGraphOpts.Controls.Add(this.cbJitter);
            this.groupBoxGraphOpts.Controls.Add(this.cbAverage);
            this.groupBoxGraphOpts.Controls.Add(this.cbAlwaysShowServerNames);
            this.groupBoxGraphOpts.Controls.Add(this.cbMinMax);
            this.groupBoxGraphOpts.Controls.Add(this.cbPacketLoss);
            this.groupBoxGraphOpts.Controls.Add(this.nudBadThreshold);
            this.groupBoxGraphOpts.Controls.Add(this.nudWorseThreshold);
            this.groupBoxGraphOpts.Controls.Add(this.label8);
            this.groupBoxGraphOpts.Controls.Add(this.label9);
            this.groupBoxGraphOpts.Location = new System.Drawing.Point(3, 104);
            this.groupBoxGraphOpts.Name = "groupBoxGraphOpts";
            this.groupBoxGraphOpts.Size = new System.Drawing.Size(479, 74);
            this.groupBoxGraphOpts.TabIndex = 24;
            this.groupBoxGraphOpts.TabStop = false;
            this.groupBoxGraphOpts.Text = "Graph Options:";
            // 
            // cbLastPing
            // 
            this.cbLastPing.AutoSize = true;
            this.cbLastPing.Location = new System.Drawing.Point(6, 45);
            this.cbLastPing.Name = "cbLastPing";
            this.cbLastPing.Size = new System.Drawing.Size(70, 17);
            this.cbLastPing.TabIndex = 13;
            this.cbLastPing.Text = "Last Ping";
            this.toolTip1.SetToolTip(this.cbLastPing, "If checked, the most recent ping response time is overlaid in text form.");
            this.cbLastPing.UseVisualStyleBackColor = true;
            // 
            // cbJitter
            // 
            this.cbJitter.AutoSize = true;
            this.cbJitter.Location = new System.Drawing.Point(164, 45);
            this.cbJitter.Name = "cbJitter";
            this.cbJitter.Size = new System.Drawing.Size(48, 17);
            this.cbJitter.TabIndex = 15;
            this.cbJitter.Text = "Jitter";
            this.toolTip1.SetToolTip(this.cbJitter, "If checked, the jitter (across visible ping times) is overlaid in text form.");
            this.cbJitter.UseVisualStyleBackColor = true;
            // 
            // cbAverage
            // 
            this.cbAverage.AutoSize = true;
            this.cbAverage.Location = new System.Drawing.Point(87, 45);
            this.cbAverage.Name = "cbAverage";
            this.cbAverage.Size = new System.Drawing.Size(66, 17);
            this.cbAverage.TabIndex = 14;
            this.cbAverage.Text = "Average";
            this.toolTip1.SetToolTip(this.cbAverage, "If checked, the average response time (of visible ping times) is overlaid in text" +
        " form.");
            this.cbAverage.UseVisualStyleBackColor = true;
            // 
            // cbAlwaysShowServerNames
            // 
            this.cbAlwaysShowServerNames.AutoSize = true;
            this.cbAlwaysShowServerNames.Checked = true;
            this.cbAlwaysShowServerNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlwaysShowServerNames.Location = new System.Drawing.Point(6, 19);
            this.cbAlwaysShowServerNames.Name = "cbAlwaysShowServerNames";
            this.cbAlwaysShowServerNames.Size = new System.Drawing.Size(93, 17);
            this.cbAlwaysShowServerNames.TabIndex = 10;
            this.cbAlwaysShowServerNames.Text = "Server Names";
            this.toolTip1.SetToolTip(this.cbAlwaysShowServerNames, "If checked, each server\'s name/address is overlaid on its graph.");
            this.cbAlwaysShowServerNames.UseVisualStyleBackColor = true;
            // 
            // cbMinMax
            // 
            this.cbMinMax.AutoSize = true;
            this.cbMinMax.Location = new System.Drawing.Point(223, 45);
            this.cbMinMax.Name = "cbMinMax";
            this.cbMinMax.Size = new System.Drawing.Size(74, 17);
            this.cbMinMax.TabIndex = 16;
            this.cbMinMax.Text = "Min / Max";
            this.toolTip1.SetToolTip(this.cbMinMax, "If checked, the shortest and longest visible ping times are overlaid in text form" +
        ".");
            this.cbMinMax.UseVisualStyleBackColor = true;
            // 
            // cbPacketLoss
            // 
            this.cbPacketLoss.AutoSize = true;
            this.cbPacketLoss.Checked = true;
            this.cbPacketLoss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPacketLoss.Location = new System.Drawing.Point(110, 19);
            this.cbPacketLoss.Name = "cbPacketLoss";
            this.cbPacketLoss.Size = new System.Drawing.Size(96, 17);
            this.cbPacketLoss.TabIndex = 12;
            this.cbPacketLoss.Text = "Packet Loss %";
            this.toolTip1.SetToolTip(this.cbPacketLoss, "If checked, each graph\'s visible packet loss is overlaid as a percentage.");
            this.cbPacketLoss.UseVisualStyleBackColor = true;
            // 
            // nudBadThreshold
            // 
            this.nudBadThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBadThreshold.Location = new System.Drawing.Point(417, 18);
            this.nudBadThreshold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudBadThreshold.Name = "nudBadThreshold";
            this.nudBadThreshold.Size = new System.Drawing.Size(56, 20);
            this.nudBadThreshold.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nudBadThreshold, "Pings exceeding this threshold are drawn in faded yellow color, \r\nand the backgro" +
        "und of the ping graph will be yellow tinted \r\nabove this point.");
            this.nudBadThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudWorseThreshold
            // 
            this.nudWorseThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWorseThreshold.Location = new System.Drawing.Point(417, 44);
            this.nudWorseThreshold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudWorseThreshold.Name = "nudWorseThreshold";
            this.nudWorseThreshold.Size = new System.Drawing.Size(56, 20);
            this.nudWorseThreshold.TabIndex = 18;
            this.toolTip1.SetToolTip(this.nudWorseThreshold, "Pings exceeding this threshold are drawn in bright yellow color, \r\nand the backgr" +
        "ound of the ping graph will be red tinted \r\nabove this point.");
            this.nudWorseThreshold.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bad threshold:";
            this.toolTip1.SetToolTip(this.label8, "Pings exceeding this threshold are drawn in faded yellow color, \r\nand the backgro" +
        "und of the ping graph will be yellow tinted \r\nabove this point.");
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Worse threshold:";
            this.toolTip1.SetToolTip(this.label9, "Pings exceeding this threshold are drawn in bright yellow color, \r\nand the backgr" +
        "ound of the ping graph will be red tinted \r\nabove this point.");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSuccessLabel,
            this.toolStripSuccessValue,
            this.toolStripFailLabel,
            this.toolStripFailValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSuccessLabel
            // 
            this.toolStripSuccessLabel.Name = "toolStripSuccessLabel";
            this.toolStripSuccessLabel.Size = new System.Drawing.Size(51, 17);
            this.toolStripSuccessLabel.Text = "Success:";
            // 
            // toolStripSuccessValue
            // 
            this.toolStripSuccessValue.Name = "toolStripSuccessValue";
            this.toolStripSuccessValue.Size = new System.Drawing.Size(13, 17);
            this.toolStripSuccessValue.Text = "0";
            // 
            // toolStripFailLabel
            // 
            this.toolStripFailLabel.Name = "toolStripFailLabel";
            this.toolStripFailLabel.Size = new System.Drawing.Size(28, 17);
            this.toolStripFailLabel.Text = "Fail:";
            // 
            // toolStripFailValue
            // 
            this.toolStripFailValue.Name = "toolStripFailValue";
            this.toolStripFailValue.Size = new System.Drawing.Size(13, 17);
            this.toolStripFailValue.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 387);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblReplFailed);
            this.Controls.Add(this.lblReplSuccessful);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Text = "Ping Tracer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPingsPerSecond)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Graphs.ResumeLayout(false);
            this.panel_Graphs.PerformLayout();
            this.groupBoxPingOpts.ResumeLayout(false);
            this.groupBoxPingOpts.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxGraphOpts.ResumeLayout(false);
            this.groupBoxGraphOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBadThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorseThreshold)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.TextBox txtHost;
		private System.Windows.Forms.Label lblHost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudPingsPerSecond;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblReplSuccessful;
		private System.Windows.Forms.Label lblReplFailed;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox cbTraceroute;
		private System.Windows.Forms.Panel panel_Graphs;
		private System.Windows.Forms.Label labelGraphIntro;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripHostHistory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtDisplayName;
		private System.Windows.Forms.MainMenu menuMain;
		private System.Windows.Forms.MenuItem mi_Export;
		private System.Windows.Forms.MenuItem mi_Export_snapshotGraphs;
		private System.Windows.Forms.MenuItem mi_Tools;
		private System.Windows.Forms.MenuItem mi_Tools_Options;
		private System.Windows.Forms.MenuItem mi_File;
		private System.Windows.Forms.MenuItem mi_File_Exit;
		private System.Windows.Forms.CheckBox cbReverseDNS;
		private System.Windows.Forms.ComboBox comboPingsPerSecond;
		private System.Windows.Forms.MenuItem mi_Tools_deleteHost;
        private System.Windows.Forms.GroupBox groupBoxPingOpts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxGraphOpts;
        private System.Windows.Forms.CheckBox cbLastPing;
        private System.Windows.Forms.CheckBox cbJitter;
        private System.Windows.Forms.CheckBox cbAverage;
        private System.Windows.Forms.CheckBox cbAlwaysShowServerNames;
        private System.Windows.Forms.CheckBox cbMinMax;
        private System.Windows.Forms.CheckBox cbPacketLoss;
        private System.Windows.Forms.NumericUpDown nudBadThreshold;
        private System.Windows.Forms.NumericUpDown nudWorseThreshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSuccessLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSuccessValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFailLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFailValue;
    }
}

