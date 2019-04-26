namespace EmailTest
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
            this.btnSendMail = new System.Windows.Forms.Button();
            this.tbxMailAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendMail.Location = new System.Drawing.Point(371, 125);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(138, 54);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "SendMail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // tbxMailAddress
            // 
            this.tbxMailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMailAddress.Location = new System.Drawing.Point(32, 133);
            this.tbxMailAddress.MaximumSize = new System.Drawing.Size(500, 100);
            this.tbxMailAddress.Name = "tbxMailAddress";
            this.tbxMailAddress.Size = new System.Drawing.Size(303, 35);
            this.tbxMailAddress.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 353);
            this.Controls.Add(this.tbxMailAddress);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox tbxMailAddress;
    }
}

