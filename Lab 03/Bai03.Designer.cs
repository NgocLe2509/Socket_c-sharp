namespace Lab_03
{
    partial class Bai03
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
            this.btOpenTCPClient = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpenTCPServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenTCPClient
            // 
            this.btOpenTCPClient.Enabled = false;
            this.btOpenTCPClient.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenTCPClient.Location = new System.Drawing.Point(51, 89);
            this.btOpenTCPClient.Name = "btOpenTCPClient";
            this.btOpenTCPClient.Size = new System.Drawing.Size(257, 41);
            this.btOpenTCPClient.TabIndex = 5;
            this.btOpenTCPClient.Text = "Open TCP Client";
            this.btOpenTCPClient.UseVisualStyleBackColor = true;
            this.btOpenTCPClient.Click += new System.EventHandler(this.btOpenTCPClient_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(51, 157);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(257, 41);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpenTCPServer
            // 
            this.btOpenTCPServer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenTCPServer.Location = new System.Drawing.Point(51, 22);
            this.btOpenTCPServer.Name = "btOpenTCPServer";
            this.btOpenTCPServer.Size = new System.Drawing.Size(257, 41);
            this.btOpenTCPServer.TabIndex = 3;
            this.btOpenTCPServer.Text = "Open TCP Server";
            this.btOpenTCPServer.UseVisualStyleBackColor = true;
            this.btOpenTCPServer.Click += new System.EventHandler(this.btOpenTCPServer_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 246);
            this.Controls.Add(this.btOpenTCPClient);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btOpenTCPServer);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenTCPClient;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btOpenTCPServer;
    }
}