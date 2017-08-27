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
            // 
            // testServerInputTextBox
            // 
            this.testServerInputTextBox.Location = new System.Drawing.Point(28, 304);
            this.testServerInputTextBox.Name = "testServerInputTextBox";
            this.testServerInputTextBox.Size = new System.Drawing.Size(578, 20);
            this.testServerInputTextBox.TabIndex = 12;
            // 
            // TestConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 395);
            this.Controls.Add(this.testStopBtn);
            this.Controls.Add(this.testStartBtn);
            this.Controls.Add(this.testServerInputTextBox);
            this.Controls.Add(this.testServerReadTextBox);
            this.Name = "TestConsoleForm";
            this.Text = "Test Console Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testServerReadTextBox;
        private System.Windows.Forms.Button testStopBtn;
        private System.Windows.Forms.Button testStartBtn;
        private System.Windows.Forms.TextBox testServerInputTextBox;
    }
}