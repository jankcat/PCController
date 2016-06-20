namespace PCController.TestApp
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
            this.btn6On = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btn6Off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn6On
            // 
            this.btn6On.Location = new System.Drawing.Point(12, 12);
            this.btn6On.Name = "btn6On";
            this.btn6On.Size = new System.Drawing.Size(75, 23);
            this.btn6On.TabIndex = 0;
            this.btn6On.Text = "6 On";
            this.btn6On.UseVisualStyleBackColor = true;
            this.btn6On.Click += new System.EventHandler(this.btn6On_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(93, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read 6";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(93, 41);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "label1";
            // 
            // btn6Off
            // 
            this.btn6Off.Location = new System.Drawing.Point(12, 41);
            this.btn6Off.Name = "btn6Off";
            this.btn6Off.Size = new System.Drawing.Size(75, 23);
            this.btn6Off.TabIndex = 3;
            this.btn6Off.Text = "6 Off";
            this.btn6Off.UseVisualStyleBackColor = true;
            this.btn6Off.Click += new System.EventHandler(this.btn6Off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 477);
            this.Controls.Add(this.btn6Off);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btn6On);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn6On;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btn6Off;
    }
}

