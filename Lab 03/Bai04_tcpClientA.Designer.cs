namespace Lab_03
{
    partial class Bai04_tcpClientA
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
            this.lvMess = new System.Windows.Forms.ListView();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMess = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMess
            // 
            this.lvMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(13, 13);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(409, 317);
            this.lvMess.TabIndex = 0;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            this.lvMess.View = System.Windows.Forms.View.List;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(13, 338);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(99, 22);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Your Name";
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMess.Location = new System.Drawing.Point(13, 396);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(79, 22);
            this.lbMess.TabIndex = 2;
            this.lbMess.Text = "Message";
            // 
            // btSend
            // 
            this.btSend.Enabled = false;
            this.btSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(347, 424);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 29);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(13, 363);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(160, 30);
            this.tbName.TabIndex = 4;
            // 
            // tbMess
            // 
            this.tbMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMess.Location = new System.Drawing.Point(13, 423);
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(328, 30);
            this.tbMess.TabIndex = 5;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(278, 388);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(144, 29);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Bai04_tcpClientA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 465);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lvMess);
            this.Name = "Bai04_tcpClientA";
            this.Text = "Bai04_tcpClientA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMess;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Button btConnect;
    }
}