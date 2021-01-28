namespace Lab_03
{
    partial class Bai02
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
            this.btListen = new System.Windows.Forms.Button();
            this.lwShow = new System.Windows.Forms.ListView();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btListen
            // 
            this.btListen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(333, 15);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(83, 34);
            this.btListen.TabIndex = 3;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // lwShow
            // 
            this.lwShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwShow.HideSelection = false;
            this.lwShow.Location = new System.Drawing.Point(12, 64);
            this.lwShow.Name = "lwShow";
            this.lwShow.Size = new System.Drawing.Size(405, 237);
            this.lwShow.TabIndex = 2;
            this.lwShow.UseCompatibleStateImageBehavior = false;
            this.lwShow.View = System.Windows.Forms.View.List;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(333, 307);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(83, 34);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 350);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.lwShow);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.ListView lwShow;
        private System.Windows.Forms.Button btClose;
    }
}