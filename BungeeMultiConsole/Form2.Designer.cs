namespace BungeeMultiConsole
{
    partial class TestConsoleForm
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
            this.testServerReadTextBox = new System.Windows.Forms.TextBox();
            this.testStopBtn = new System.Windows.Forms.Button();
            this.testStartBtn = new System.Windows.Forms.Button();
            this.testServerInputTextBox = new System.Windows.Forms.TextBox();
            this.customArgsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.customArgsCheckBox = new System.Windows.Forms.CheckBox();
            this.d64 = new System.Windows.Forms.CheckBox();
            this.xmsLabel = new System.Windows.Forms.Label();
            this.xmsAmountTextBox = new System.Windows.Forms.TextBox();
            this.xmsSuffix = new System.Windows.Forms.ComboBox();
            this.xmxLabel = new System.Windows.Forms.Label();
            this.xmxAmountTextBox = new System.Windows.Forms.TextBox();
            this.xmxSuffixCombo = new System.Windows.Forms.ComboBox();
            this.xmnLabel = new System.Windows.Forms.Label();
            this.xmnAmountTextBox = new System.Windows.Forms.TextBox();
            this.xmnSuffixCombo = new System.Windows.Forms.ComboBox();
            this.customArgsFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testServerReadTextBox
            // 
            this.testServerReadTextBox.Location = new System.Drawing.Point(28, 31);
            this.testServerReadTextBox.MaximumSize = new System.Drawing.Size(800, 600);
            this.testServerReadTextBox.Multiline = true;
            this.testServerReadTextBox.Name = "testServerReadTextBox";
            this.testServerReadTextBox.Size = new System.Drawing.Size(578, 267);
            this.testServerReadTextBox.TabIndex = 10;
            // 
            // testStopBtn
            // 
            this.testStopBtn.Location = new System.Drawing.Point(109, 330);
            this.testStopBtn.Name = "testStopBtn";
            this.testStopBtn.Size = new System.Drawing.Size(75, 23);
            this.testStopBtn.TabIndex = 14;
            this.testStopBtn.Text = "Stop";
            this.testStopBtn.UseVisualStyleBackColor = true;
            // 
            // testStartBtn
            // 
            this.testStartBtn.Location = new System.Drawing.Point(28, 330);
            this.testStartBtn.Name = "testStartBtn";
            this.testStartBtn.Size = new System.Drawing.Size(75, 23);
            this.testStartBtn.TabIndex = 13;
            this.testStartBtn.Text = "Start";
            this.testStartBtn.UseVisualStyleBackColor = true;
            this.testStartBtn.Click += new System.EventHandler(this.testStartBtn_Click);
            // 
            // testServerInputTextBox
            // 
            this.testServerInputTextBox.Location = new System.Drawing.Point(28, 304);
            this.testServerInputTextBox.Name = "testServerInputTextBox";
            this.testServerInputTextBox.Size = new System.Drawing.Size(578, 20);
            this.testServerInputTextBox.TabIndex = 12;
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
            this.customArgsFlowPanel.Location = new System.Drawing.Point(12, 359);
            this.customArgsFlowPanel.Name = "customArgsFlowPanel";
            this.customArgsFlowPanel.Size = new System.Drawing.Size(629, 25);
            this.customArgsFlowPanel.TabIndex = 15;
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
            // xmxLabel
            // 
            this.xmxLabel.AutoSize = true;
            this.xmxLabel.Location = new System.Drawing.Point(317, 0);
            this.xmxLabel.Name = "xmxLabel";
            this.xmxLabel.Size = new System.Drawing.Size(30, 13);
            this.xmxLabel.TabIndex = 6;
            this.xmxLabel.Text = "-Xmx";
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
            // TestConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 395);
            this.Controls.Add(this.customArgsFlowPanel);
            this.Controls.Add(this.testStopBtn);
            this.Controls.Add(this.testStartBtn);
            this.Controls.Add(this.testServerInputTextBox);
            this.Controls.Add(this.testServerReadTextBox);
            this.Name = "TestConsoleForm";
            this.Text = "Test Console Form";
            this.customArgsFlowPanel.ResumeLayout(false);
            this.customArgsFlowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testServerReadTextBox;
        private System.Windows.Forms.Button testStopBtn;
        private System.Windows.Forms.Button testStartBtn;
        private System.Windows.Forms.TextBox testServerInputTextBox;
        private System.Windows.Forms.FlowLayoutPanel customArgsFlowPanel;
        private System.Windows.Forms.CheckBox customArgsCheckBox;
        private System.Windows.Forms.CheckBox d64;
        private System.Windows.Forms.Label xmsLabel;
        private System.Windows.Forms.TextBox xmsAmountTextBox;
        private System.Windows.Forms.ComboBox xmsSuffix;
        private System.Windows.Forms.Label xmxLabel;
        private System.Windows.Forms.TextBox xmxAmountTextBox;
        private System.Windows.Forms.ComboBox xmxSuffixCombo;
        private System.Windows.Forms.Label xmnLabel;
        private System.Windows.Forms.TextBox xmnAmountTextBox;
        private System.Windows.Forms.ComboBox xmnSuffixCombo;
    }
}