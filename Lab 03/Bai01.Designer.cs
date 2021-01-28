namespace Lab_03
{
    partial class Bai01
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
            this.btUDP_Client = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUDP_Client
            // 
            this.btUDP_Client.Enabled = false;
            this.btUDP_Client.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUDP_Client.Location = new System.Drawing.Point(268, 37);
            this.btUDP_Client.Name = "btUDP_Client";
            this.btUDP_Client.Size = new System.Drawing.Size(154, 33);
            this.btUDP_Client.TabIndex = 3;
            this.btUDP_Client.Text = "UDP Client";
            this.btUDP_Client.UseVisualStyleBackColor = true;
            this.btUDP_Client.Click += new System.EventHandler(this.btUDP_Client_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "UDP Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(172, 105);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(117, 39);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 170);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUDP_Client);
            this.Controls.Add(this.button1);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUDP_Client;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btClose;
    }
}