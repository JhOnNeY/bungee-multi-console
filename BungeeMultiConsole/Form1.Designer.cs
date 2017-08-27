namespace BungeeMultiConsole
{
	partial class BungeeMultiConsole
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
            this.multiTabControl = new System.Windows.Forms.TabControl();
            this.singleStartButton = new System.Windows.Forms.Button();
            this.singleStopButton = new System.Windows.Forms.Button();
            this.singleSaveButton = new System.Windows.Forms.Button();
            this.multiStartButton = new System.Windows.Forms.Button();
            this.multiStopButton = new System.Windows.Forms.Button();
            this.multiSaveButton = new System.Windows.Forms.Button();
            this.scanDirectoryButton = new System.Windows.Forms.Button();
            this.customArgsCheckBox = new System.Windows.Forms.CheckBox();
            this.xmsAmountTextBox = new System.Windows.Forms.TextBox();
            this.d64 = new System.Windows.Forms.CheckBox();
            this.xmsLabel = new System.Windows.Forms.Label();
            this.xmxAmountTextBox = new System.Windows.Forms.TextBox();
            this.xmxLabel = new System.Windows.Forms.Label();
            this.xmnLabel = new System.Windows.Forms.Label();
            this.xmnAmountTextBox = new System.Windows.Forms.TextBox();
            this.xmsSuffix = new System.Windows.Forms.ComboBox();
            this.xmxSuffixCombo = new System.Windows.Forms.ComboBox();
            this.xmnSuffixCombo = new System.Windows.Forms.ComboBox();
            this.customArgsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.serverDirButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testFormButton = new System.Windows.Forms.Button();
            this.customArgsFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiTabControl
            // 
            this.multiTabControl.Location = new System.Drawing.Point(148, 110);
            this.multiTabControl.Name = "multiTabControl";
            this.multiTabControl.SelectedIndex = 0;
            this.multiTabControl.Size = new System.Drawing.Size(797, 469);
            this.multiTabControl.TabIndex = 0;
            // 
            // singleStartButton
            // 
            this.singleStartButton.Location = new System.Drawing.Point(953, 143);
            this.singleStartButton.Name = "singleStartButton";
            this.singleStartButton.Size = new System.Drawing.Size(39, 40);
            this.singleStartButton.TabIndex = 1;
            this.singleStartButton.Text = "Start";
            this.singleStartButton.UseVisualStyleBackColor = true;
            this.singleStartButton.Click += new System.EventHandler(this.singleStartButton_Click);
            // 
            // singleStopButton
            // 
            this.singleStopButton.Location = new System.Drawing.Point(953, 198);
            this.singleStopButton.Name = "singleStopButton";
            this.singleStopButton.Size = new System.Drawing.Size(41, 40);
            this.singleStopButton.TabIndex = 1;
            this.singleStopButton.Text = "Stop";
            this.singleStopButton.UseVisualStyleBackColor = true;
            // 
            // singleSaveButton
            // 
            this.singleSaveButton.Location = new System.Drawing.Point(953, 256);
            this.singleSaveButton.Name = "singleSaveButton";
            this.singleSaveButton.Size = new System.Drawing.Size(41, 40);
            this.singleSaveButton.TabIndex = 1;
            this.singleSaveButton.Text = "Save";
            this.singleSaveButton.UseVisualStyleBackColor = true;
            // 
            // multiStartButton
            // 
            this.multiStartButton.Location = new System.Drawing.Point(659, 64);
            this.multiStartButton.Name = "multiStartButton";
            this.multiStartButton.Size = new System.Drawing.Size(75, 40);
            this.multiStartButton.TabIndex = 1;
            this.multiStartButton.Text = "Start All";
            this.multiStartButton.UseVisualStyleBackColor = true;
            this.multiStartButton.Click += new System.EventHandler(this.multiStartButton_Click);
            // 
            // multiStopButton
            // 
            this.multiStopButton.Location = new System.Drawing.Point(758, 64);
            this.multiStopButton.Name = "multiStopButton";
            this.multiStopButton.Size = new System.Drawing.Size(75, 40);
            this.multiStopButton.TabIndex = 1;
            this.multiStopButton.Text = "Stop All";
            this.multiStopButton.UseVisualStyleBackColor = true;
            // 
            // multiSaveButton
            // 
            this.multiSaveButton.Location = new System.Drawing.Point(854, 64);
            this.multiSaveButton.Name = "multiSaveButton";
            this.multiSaveButton.Size = new System.Drawing.Size(75, 40);
            this.multiSaveButton.TabIndex = 1;
            this.multiSaveButton.Text = "Save All";
            this.multiSaveButton.UseVisualStyleBackColor = true;
            // 
            // scanDirectoryButton
            // 
            this.scanDirectoryButton.Location = new System.Drawing.Point(8, 110);
            this.scanDirectoryButton.Name = "scanDirectoryButton";
            this.scanDirectoryButton.Size = new System.Drawing.Size(134, 44);
            this.scanDirectoryButton.TabIndex = 1;
            this.scanDirectoryButton.Text = "Scan Servers";
            this.scanDirectoryButton.UseVisualStyleBackColor = true;
            this.scanDirectoryButton.Click += new System.EventHandler(this.scanDirectoryButton_Click);
            // 
            // customArgsCheckBox
            // 
            this.customArgsCheckBox.AutoSize = true;
            this.customArgsCheckBox.Location = new System.Drawing.Point(3, 3);
            this.customArgsCheckBox.Name = "customArgsCheckBox";
            this.customArgsCheckBox.Size = new System.Drawing.Size(114, 17);
            this.customArgsCheckBox.TabIndex = 1;
            this.customArgsCheckBox.Text = "Custom Arguments";
            this.customArgsCheckBox.UseVisualStyleBackColor = true;
            // 
            // xmsAmountTextBox
            // 
            this.xmsAmountTextBox.Enabled = false;
            this.xmsAmountTextBox.Location = new System.Drawing.Point(212, 3);
            this.xmsAmountTextBox.Name = "xmsAmountTextBox";
            this.xmsAmountTextBox.Size = new System.Drawing.Size(53, 20);
            this.xmsAmountTextBox.TabIndex = 4;
            this.xmsAmountTextBox.Text = "1";
            this.xmsAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d64
            // 
            this.d64.AutoSize = true;
            this.d64.Checked = true;
            this.d64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.d64.Enabled = false;
            this.d64.Location = new System.Drawing.Point(123, 3);
            this.d64.Name = "d64";
            this.d64.Size = new System.Drawing.Size(47, 17);
            this.d64.TabIndex = 2;
            this.d64.Text = "-d64";
            this.d64.UseVisualStyleBackColor = true;
            // 
            // xmsLabel
            // 
            this.xmsLabel.AutoSize = true;
            this.xmsLabel.Location = new System.Drawing.Point(176, 0);
            this.xmsLabel.Name = "xmsLabel";
            this.xmsLabel.Size = new System.Drawing.Size(30, 13);
            this.xmsLabel.TabIndex = 3;
            this.xmsLabel.Text = "-Xms";
            // 
            // xmxAmountTextBox
            // 
            this.xmxAmountTextBox.Enabled = false;
            this.xmxAmountTextBox.Location = new System.Drawing.Point(353, 3);
            this.xmxAmountTextBox.Name = "xmxAmountTextBox";
            this.xmxAmountTextBox.Size = new System.Drawing.Size(55, 20);
            this.xmxAmountTextBox.TabIndex = 7;
            this.xmxAmountTextBox.Text = "2";
            this.xmxAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xmxLabel
            // 
            this.xmxLabel.AutoSize = true;
            this.xmxLabel.Location = new System.Drawing.Point(317, 0);
            this.xmxLabel.Name = "xmxLabel";
            this.xmxLabel.Size = new System.Drawing.Size(30, 13);
            this.xmxLabel.TabIndex = 6;
            this.xmxLabel.Text = "-Xmx";
            // 
            // xmnLabel
            // 
            this.xmnLabel.AutoSize = true;
            this.xmnLabel.Location = new System.Drawing.Point(460, 0);
            this.xmnLabel.Name = "xmnLabel";
            this.xmnLabel.Size = new System.Drawing.Size(31, 13);
            this.xmnLabel.TabIndex = 9;
            this.xmnLabel.Text = "-Xmn";
            // 
            // xmnAmountTextBox
            // 
            this.xmnAmountTextBox.Enabled = false;
            this.xmnAmountTextBox.Location = new System.Drawing.Point(497, 3);
            this.xmnAmountTextBox.Name = "xmnAmountTextBox";
            this.xmnAmountTextBox.Size = new System.Drawing.Size(70, 20);
            this.xmnAmountTextBox.TabIndex = 11;
            this.xmnAmountTextBox.Text = "512";
            this.xmnAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xmsSuffix
            // 
            this.xmsSuffix.Enabled = false;
            this.xmsSuffix.FormattingEnabled = true;
            this.xmsSuffix.Items.AddRange(new object[] {
            "M",
            "G"});
            this.xmsSuffix.Location = new System.Drawing.Point(271, 3);
            this.xmsSuffix.Name = "xmsSuffix";
            this.xmsSuffix.Size = new System.Drawing.Size(40, 21);
            this.xmsSuffix.TabIndex = 5;
            this.xmsSuffix.Text = "G";
            // 
            // xmxSuffixCombo
            // 
            this.xmxSuffixCombo.Enabled = false;
            this.xmxSuffixCombo.FormattingEnabled = true;
            this.xmxSuffixCombo.Items.AddRange(new object[] {
            "M",
            "G"});
            this.xmxSuffixCombo.Location = new System.Drawing.Point(414, 3);
            this.xmxSuffixCombo.Name = "xmxSuffixCombo";
            this.xmxSuffixCombo.Size = new System.Drawing.Size(40, 21);
            this.xmxSuffixCombo.TabIndex = 8;
            this.xmxSuffixCombo.Text = "G";
            // 
            // xmnSuffixCombo
            // 
            this.xmnSuffixCombo.Enabled = false;
            this.xmnSuffixCombo.FormattingEnabled = true;
            this.xmnSuffixCombo.Items.AddRange(new object[] {
            "M",
            "G"});
            this.xmnSuffixCombo.Location = new System.Drawing.Point(573, 3);
            this.xmnSuffixCombo.Name = "xmnSuffixCombo";
            this.xmnSuffixCombo.Size = new System.Drawing.Size(40, 21);
            this.xmnSuffixCombo.TabIndex = 12;
            this.xmnSuffixCombo.Text = "G";
            // 
            // customArgsFlowPanel
            // 
            this.customArgsFlowPanel.Controls.Add(this.customArgsCheckBox);
            this.customArgsFlowPanel.Controls.Add(this.d64);
            this.customArgsFlowPanel.Controls.Add(this.xmsLabel);
            this.customArgsFlowPanel.Controls.Add(this.xmsAmountTextBox);
            this.customArgsFlowPanel.Controls.Add(this.xmsSuffix);
            this.customArgsFlowPanel.Controls.Add(this.xmxLabel);
            this.customArgsFlowPanel.Controls.Add(this.xmxAmountTextBox);
            this.customArgsFlowPanel.Controls.Add(this.xmxSuffixCombo);
            this.customArgsFlowPanel.Controls.Add(this.xmnLabel);
            this.customArgsFlowPanel.Controls.Add(this.xmnAmountTextBox);
            this.customArgsFlowPanel.Controls.Add(this.xmnSuffixCombo);
            this.customArgsFlowPanel.Location = new System.Drawing.Point(300, 588);
            this.customArgsFlowPanel.Name = "customArgsFlowPanel";
            this.customArgsFlowPanel.Size = new System.Drawing.Size(629, 25);
            this.customArgsFlowPanel.TabIndex = 6;
            // 
            // serverDirButton
            // 
            this.serverDirButton.Location = new System.Drawing.Point(8, 160);
            this.serverDirButton.Name = "serverDirButton";
            this.serverDirButton.Size = new System.Drawing.Size(134, 44);
            this.serverDirButton.TabIndex = 7;
            this.serverDirButton.Text = "Servers Directory";
            this.serverDirButton.UseVisualStyleBackColor = true;
            this.serverDirButton.Click += new System.EventHandler(this.serverDirButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ravie", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titleLabel.Location = new System.Drawing.Point(12, 5);
            this.titleLabel.MaximumSize = new System.Drawing.Size(400, 50);
            this.titleLabel.MinimumSize = new System.Drawing.Size(200, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.titleLabel.Size = new System.Drawing.Size(317, 50);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Bungee Multi Console";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(8, 588);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(134, 50);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BungeeMultiConsole.Properties.Resources.bungee_logo_alt;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 99);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // testFormButton
            // 
            this.testFormButton.Location = new System.Drawing.Point(8, 519);
            this.testFormButton.Name = "testFormButton";
            this.testFormButton.Size = new System.Drawing.Size(134, 50);
            this.testFormButton.TabIndex = 13;
            this.testFormButton.Text = "TestConsole";
            this.testFormButton.UseVisualStyleBackColor = true;
            this.testFormButton.Click += new System.EventHandler(this.testFormButton_Click);
            // 
            // BungeeMultiConsole
            // 
            this.AcceptButton = this.multiSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1004, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testFormButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.serverDirButton);
            this.Controls.Add(this.customArgsFlowPanel);
            this.Controls.Add(this.multiSaveButton);
            this.Controls.Add(this.multiStopButton);
            this.Controls.Add(this.multiStartButton);
            this.Controls.Add(this.singleSaveButton);
            this.Controls.Add(this.singleStopButton);
            this.Controls.Add(this.scanDirectoryButton);
            this.Controls.Add(this.singleStartButton);
            this.Controls.Add(this.multiTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BungeeMultiConsole";
            this.Text = "BungeeMultiConsole";
            this.Load += new System.EventHandler(this.BungeeMultiConsole_Load);
            this.customArgsFlowPanel.ResumeLayout(false);
            this.customArgsFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button singleStartButton;
		private System.Windows.Forms.Button singleStopButton;
		private System.Windows.Forms.Button singleSaveButton;
		private System.Windows.Forms.Button multiStartButton;
		private System.Windows.Forms.Button multiStopButton;
		private System.Windows.Forms.Button multiSaveButton;
        private System.Windows.Forms.Button scanDirectoryButton;
        private System.Windows.Forms.CheckBox customArgsCheckBox;
        private System.Windows.Forms.TextBox xmsAmountTextBox;
        private System.Windows.Forms.CheckBox d64;
        private System.Windows.Forms.Label xmsLabel;
        private System.Windows.Forms.TextBox xmxAmountTextBox;
        private System.Windows.Forms.Label xmxLabel;
        private System.Windows.Forms.Label xmnLabel;
        private System.Windows.Forms.TextBox xmnAmountTextBox;
        private System.Windows.Forms.ComboBox xmsSuffix;
        private System.Windows.Forms.ComboBox xmxSuffixCombo;
        private System.Windows.Forms.ComboBox xmnSuffixCombo;
        private System.Windows.Forms.FlowLayoutPanel customArgsFlowPanel;
        private System.Windows.Forms.Button serverDirButton;
        public System.Windows.Forms.TabControl multiTabControl;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testFormButton;
    }
}

