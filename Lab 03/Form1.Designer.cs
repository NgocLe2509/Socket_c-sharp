namespace Lab_03
{
    partial class Menu
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
            this.btBai02 = new System.Windows.Forms.Button();
            this.btBai03 = new System.Windows.Forms.Button();
            this.btBai04 = new System.Windows.Forms.Button();
            this.btBai01 = new System.Windows.Forms.Button();
            this.lbTitelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBai02
            // 
            this.btBai02.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai02.Location = new System.Drawing.Point(137, 183);
            this.btBai02.Name = "btBai02";
            this.btBai02.Size = new System.Drawing.Size(139, 41);
            this.btBai02.TabIndex = 9;
            this.btBai02.Text = "BÀI 02";
            this.btBai02.UseVisualStyleBackColor = true;
            this.btBai02.Click += new System.EventHandler(this.btBai02_Click);
            // 
            // btBai03
            // 
            this.btBai03.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai03.Location = new System.Drawing.Point(137, 247);
            this.btBai03.Name = "btBai03";
            this.btBai03.Size = new System.Drawing.Size(139, 41);
            this.btBai03.TabIndex = 8;
            this.btBai03.Text = "BÀI 03";
            this.btBai03.UseVisualStyleBackColor = true;
            this.btBai03.Click += new System.EventHandler(this.btBai03_Click);
            // 
            // btBai04
            // 
            this.btBai04.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai04.Location = new System.Drawing.Point(136, 312);
            this.btBai04.Name = "btBai04";
            this.btBai04.Size = new System.Drawing.Size(139, 41);
            this.btBai04.TabIndex = 7;
            this.btBai04.Text = "BÀI 04";
            this.btBai04.UseVisualStyleBackColor = true;
            this.btBai04.Click += new System.EventHandler(this.btBai04_Click);
            // 
            // btBai01
            // 
            this.btBai01.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai01.Location = new System.Drawing.Point(136, 117);
            this.btBai01.Name = "btBai01";
            this.btBai01.Size = new System.Drawing.Size(139, 41);
            this.btBai01.TabIndex = 6;
            this.btBai01.Text = "BÀI 01";
            this.btBai01.UseVisualStyleBackColor = true;
            this.btBai01.Click += new System.EventHandler(this.btBai01_Click);
            // 
            // lbTitelMenu
            // 
            this.lbTitelMenu.AutoSize = true;
            this.lbTitelMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitelMenu.Location = new System.Drawing.Point(154, 45);
            this.lbTitelMenu.Name = "lbTitelMenu";
            this.lbTitelMenu.Size = new System.Drawing.Size(109, 32);
            this.lbTitelMenu.TabIndex = 5;
            this.lbTitelMenu.Text = "LAB 03";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btBai02);
            this.Controls.Add(this.btBai03);
            this.Controls.Add(this.btBai04);
            this.Controls.Add(this.btBai01);
            this.Controls.Add(this.lbTitelMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBai02;
        private System.Windows.Forms.Button btBai03;
        private System.Windows.Forms.Button btBai04;
        private System.Windows.Forms.Button btBai01;
        private System.Windows.Forms.Label lbTitelMenu;
    }
}

