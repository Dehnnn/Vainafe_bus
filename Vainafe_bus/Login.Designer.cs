//namespace Vainafe_bus
//{
//    partial class Login_Tela
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                //components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblEmail = new System.Windows.Forms.Label();
//            this.lblsenha = new System.Windows.Forms.Label();
//            this.textemail = new System.Windows.Forms.TextBox();
//            this.textsenha = new System.Windows.Forms.TextBox();
//            this.btnenter = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // lblEmail
//            // 
//            this.lblEmail.AutoSize = true;
//            this.lblEmail.Location = new System.Drawing.Point(320, 105);
//            this.lblEmail.Name = "lblEmail";
//            this.lblEmail.Size = new System.Drawing.Size(36, 13);
//            this.lblEmail.TabIndex = 0;
//            this.lblEmail.Text = "E-Mail";
//            // 
//            // lblsenha
//            // 
//            this.lblsenha.AutoSize = true;
//            this.lblsenha.Location = new System.Drawing.Point(321, 180);
//            this.lblsenha.Name = "lblsenha";
//            this.lblsenha.Size = new System.Drawing.Size(38, 13);
//            this.lblsenha.TabIndex = 1;
//            this.lblsenha.Text = "Senha";
//            // 
//            // textemail
//            // 
//            this.textemail.Location = new System.Drawing.Point(323, 121);
//            this.textemail.Name = "textemail";
//            this.textemail.Size = new System.Drawing.Size(212, 20);
//            this.textemail.TabIndex = 2;
//            this.textemail.Text = "seunome@email.com.br";
//            this.textemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
//            // 
//            // textsenha
//            // 
//            this.textsenha.Location = new System.Drawing.Point(324, 196);
//            this.textsenha.Name = "textsenha";
//            this.textsenha.Size = new System.Drawing.Size(211, 20);
//            this.textsenha.TabIndex = 3;
//            this.textsenha.Text = "******";
//            this.textsenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
//            // 
//            // btnenter
//            // 
//            this.btnenter.Location = new System.Drawing.Point(361, 232);
//            this.btnenter.Name = "btnenter";
//            this.btnenter.Size = new System.Drawing.Size(145, 26);
//            this.btnenter.TabIndex = 4;
//            this.btnenter.Text = "entrar";
//            this.btnenter.UseVisualStyleBackColor = true;
//            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
//            // 
//            // Login_Tela
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.btnenter);
//            this.Controls.Add(this.textsenha);
//            this.Controls.Add(this.textemail);
//            this.Controls.Add(this.lblsenha);
//            this.Controls.Add(this.lblEmail);
//            this.Name = "Login_Tela";
//            this.Text = "Login";
//            this.Load += new System.EventHandler(this.Login_Tela_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label lblEmail;
//        private System.Windows.Forms.Label lblsenha;
//        private System.Windows.Forms.TextBox textemail;
//        private System.Windows.Forms.TextBox textsenha;
//        private System.Windows.Forms.Button btnenter;
//    }
////}
///

namespace Vainafe_bus
{
    partial class Login_Tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Tela));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(50, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsenha.Location = new System.Drawing.Point(50, 140);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(49, 15);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha";
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.Color.White;
            this.textemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
           
            this.textemail.ForeColor = System.Drawing.Color.Gray;
            this.textemail.Location = new System.Drawing.Point(53, 98);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(244, 21);
            this.textemail.TabIndex = 1;
            this.textemail.Text = "seunome@email.com.br";
           
            
            // 
            // textsenha
            // 
            this.textsenha.BackColor = System.Drawing.Color.White;
            this.textsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.textsenha.ForeColor = System.Drawing.Color.Gray;
            this.textsenha.Location = new System.Drawing.Point(53, 158);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(244, 21);
            this.textsenha.TabIndex = 2;
            this.textsenha.Text = "Digite sua senha";
            this.textsenha.UseSystemPasswordChar = true;
           
           
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.btnenter.FlatAppearance.BorderSize = 0;
            this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.Location = new System.Drawing.Point(53, 200);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(244, 35);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "Entrar";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(750, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
           
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vainafe Bus";
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.linkCadastro);
            this.panelLogin.Controls.Add(this.labelSubtitle);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.textemail);
            this.panelLogin.Controls.Add(this.btnenter);
            this.panelLogin.Controls.Add(this.lblsenha);
            this.panelLogin.Controls.Add(this.textsenha);
            this.panelLogin.Location = new System.Drawing.Point(200, 120);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(350, 280);
            this.panelLogin.TabIndex = 6;
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCadastro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.linkCadastro.Location = new System.Drawing.Point(120, 250);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(110, 13);
            this.linkCadastro.TabIndex = 4;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Criar uma conta nova";
            
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.labelSubtitle.Location = new System.Drawing.Point(48, 30);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(254, 24);
            this.labelSubtitle.TabIndex = 5;
            this.labelSubtitle.Text = "Faça login na sua conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(570, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Tela_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}