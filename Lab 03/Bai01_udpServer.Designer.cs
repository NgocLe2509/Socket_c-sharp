namespace Lab_03
{
    partial class Bai01_udpServer
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
            this.lwReceived = new System.Windows.Forms.ListView();
            this.lbReceived = new System.Windows.Forms.Label();
            this.btListen = new System.Windows.Forms.Button();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lwReceived
            // 
            this.lwReceived.HideSelection = false;
            this.lwReceived.Location = new System.Drawing.Point(26, 98);
            this.lwReceived.Name = "lwReceived";
            this.lwReceived.Size = new System.Drawing.Size(472, 222);
            this.lwReceived.TabIndex = 10;
            this.lwReceived.UseCompatibleStateImageBehavior = false;
            this.lwReceived.View = System.Windows.Forms.View.List;
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceived.Location = new System.Drawing.Point(22, 62);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(159, 22);
            this.lbReceived.TabIndex = 9;
            this.lbReceived.Text = "Received Message";
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(414, 20);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(84, 30);
            this.btListen.TabIndex = 8;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(22, 23);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(43, 22);
            this.lbPort.TabIndex = 7;
            this.lbPort.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.Location = new System.Drawing.Point(71, 20);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(154, 30);
            this.tbPort.TabIndex = 6;
            this.tbPort.Text = "8080";
            // 
            // Bai01_udpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 341);
            this.Controls.Add(this.lwReceived);
            this.Controls.Add(this.lbReceived);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.tbPort);
            this.Name = "Bai01_udpServer";
            this.Text = "Bai01_udpServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwReceived;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
    }
}