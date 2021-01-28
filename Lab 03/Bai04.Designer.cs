namespace Lab_03
{
    partial class Bai04
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
            this.btServer = new System.Windows.Forms.Button();
            this.btClientA = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btServer
            // 
            this.btServer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServer.Location = new System.Drawing.Point(56, 30);
            this.btServer.Name = "btServer";
            this.btServer.Size = new System.Drawing.Size(227, 36);
            this.btServer.TabIndex = 0;
            this.btServer.Text = "Server";
            this.btServer.UseVisualStyleBackColor = true;
            this.btServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClientA
            // 
            this.btClientA.Enabled = false;
            this.btClientA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientA.Location = new System.Drawing.Point(56, 89);
            this.btClientA.Name = "btClientA";
            this.btClientA.Size = new System.Drawing.Size(227, 36);
            this.btClientA.TabIndex = 3;
            this.btClientA.Text = "Client A";
            this.btClientA.UseVisualStyleBackColor = true;
            this.btClientA.Click += new System.EventHandler(this.btClientA_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(56, 146);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(227, 36);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 205);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btClientA);
            this.Controls.Add(this.btServer);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btServer;
        private System.Windows.Forms.Button btClientA;
        private System.Windows.Forms.Button btClose;
    }
}