namespace Lab_03
{
    partial class Bai01_udpClient
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
            this.btSend = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbIPhost = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbIPhost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(21, 256);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 31);
            this.btSend.TabIndex = 13;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(18, 104);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(79, 22);
            this.lbMessage.TabIndex = 12;
            this.lbMessage.Text = "Message";
            // 
            // lbIPhost
            // 
            this.lbIPhost.AutoSize = true;
            this.lbIPhost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPhost.Location = new System.Drawing.Point(18, 24);
            this.lbIPhost.Name = "lbIPhost";
            this.lbIPhost.Size = new System.Drawing.Size(133, 22);
            this.lbIPhost.TabIndex = 11;
            this.lbIPhost.Text = "IP Remote Host";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(311, 24);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(43, 22);
            this.lbPort.TabIndex = 10;
            this.lbPort.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.Location = new System.Drawing.Point(314, 58);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(148, 30);
            this.tbPort.TabIndex = 9;
            this.tbPort.Text = "8080";
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessage.Location = new System.Drawing.Point(21, 129);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(441, 112);
            this.tbMessage.TabIndex = 8;
            // 
            // tbIPhost
            // 
            this.tbIPhost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIPhost.Location = new System.Drawing.Point(21, 58);
            this.tbIPhost.Name = "tbIPhost";
            this.tbIPhost.Size = new System.Drawing.Size(220, 30);
            this.tbIPhost.TabIndex = 7;
            this.tbIPhost.Text = "127.0.0.1";
            // 
            // Bai01_udpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 311);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbIPhost);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbIPhost);
            this.Name = "Bai01_udpClient";
            this.Text = "Bai01_udpClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbIPhost;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbIPhost;
    }
}