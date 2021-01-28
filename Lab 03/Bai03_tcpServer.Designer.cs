namespace Lab_03
{
    partial class Bai03_tcpServer
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
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lvMess = new System.Windows.Forms.ListView();
            this.btListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPort.Location = new System.Drawing.Point(66, 33);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 30);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "8080";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(17, 36);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(43, 22);
            this.lbPort.TabIndex = 6;
            this.lbPort.Text = "Port";
            // 
            // lvMess
            // 
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(17, 81);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(425, 331);
            this.lvMess.TabIndex = 5;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            this.lvMess.View = System.Windows.Forms.View.List;
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(340, 23);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(107, 40);
            this.btListen.TabIndex = 4;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click_1);
            // 
            // Bai03_tcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 424);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lvMess);
            this.Controls.Add(this.btListen);
            this.Name = "Bai03_tcpServer";
            this.Text = "Bai03_tcpServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.ListView lvMess;
        private System.Windows.Forms.Button btListen;
    }
}