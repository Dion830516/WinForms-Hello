namespace WinForms_Hello
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSay = new System.Windows.Forms.Button();
            this.labSay = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSay
            // 
            this.BtnSay.Location = new System.Drawing.Point(291, 136);
            this.BtnSay.Name = "BtnSay";
            this.BtnSay.Size = new System.Drawing.Size(125, 37);
            this.BtnSay.TabIndex = 0;
            this.BtnSay.Text = "Say";
            this.BtnSay.UseVisualStyleBackColor = true;
            this.BtnSay.Click += new System.EventHandler(this.button1_Click);
            // 
            // labSay
            // 
            this.labSay.AutoSize = true;
            this.labSay.Location = new System.Drawing.Point(330, 93);
            this.labSay.Name = "labSay";
            this.labSay.Size = new System.Drawing.Size(27, 15);
            this.labSay.TabIndex = 1;
            this.labSay.Text = "Say";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(81, 280);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(150, 37);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Couct";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(90, 235);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(41, 15);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "Count";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(476, 280);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(177, 56);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(476, 240);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(35, 15);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "Time";
            // 
            // btnTS
            // 
            this.btnTS.Location = new System.Drawing.Point(475, 354);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(182, 55);
            this.btnTS.TabIndex = 6;
            this.btnTS.Text = "TimeStop";
            this.btnTS.UseVisualStyleBackColor = true;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnCS
            // 
            this.btnCS.Location = new System.Drawing.Point(78, 360);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(161, 42);
            this.btnCS.TabIndex = 7;
            this.btnCS.Text = "CountStop";
            this.btnCS.UseVisualStyleBackColor = true;
            this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.btnTS);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.labSay);
            this.Controls.Add(this.BtnSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnSay;
        private Label labSay;
        private Button btnCount;
        private Label labCount;
        private Button btnTime;
        private Label labTime;
        private Button btnTS;
        private Button btnCS;
    }
}