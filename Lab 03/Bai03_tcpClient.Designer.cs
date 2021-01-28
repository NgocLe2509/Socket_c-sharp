namespace Lab_03
{
    partial class Bai03_tcpClient
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
            this.lbIP = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.lvMess = new System.Windows.Forms.ListView();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIP.Location = new System.Drawing.Point(14, 9);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(96, 22);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP Address";
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(116, 6);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(96, 30);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "127.0.0.1";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(234, 9);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(43, 22);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.Location = new System.Drawing.Point(283, 6);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(74, 30);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "8080";
            // 
            // btSend
            // 
            this.btSend.Enabled = false;
            this.btSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(411, 45);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 30);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvMess
            // 
            this.lvMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(12, 91);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(475, 305);
            this.lvMess.TabIndex = 6;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            this.lvMess.View = System.Windows.Forms.View.List;
            // 
            // tbMess
            // 
            this.tbMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMess.Location = new System.Drawing.Point(13, 47);
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(392, 30);
            this.tbMess.TabIndex = 7;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(363, 6);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(124, 30);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Bai03_tcpClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 408);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.lvMess);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lbIP);
            this.Name = "Bai03_tcpClient";
            this.Text = "Bai03_tcpClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.ListView lvMess;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Button btConnect;
    }
}