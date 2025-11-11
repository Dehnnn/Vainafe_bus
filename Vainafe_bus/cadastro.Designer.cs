//namespace Vainafe_bus
//{
//    partial class Tela_Cadastro
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
//                components.Dispose();
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
//            this.txbNome = new System.Windows.Forms.TextBox();
//            this.Lblnomecompl = new System.Windows.Forms.Label();
//            this.LblCPF = new System.Windows.Forms.Label();
//            this.txbCpf = new System.Windows.Forms.TextBox();
//            this.LblTel = new System.Windows.Forms.Label();
//            this.txbTel = new System.Windows.Forms.TextBox();
//            this.Lbldatadenasc = new System.Windows.Forms.Label();
//            this.txbDataN = new System.Windows.Forms.TextBox();
//            this.txbEmail = new System.Windows.Forms.TextBox();
//            this.txbSenha = new System.Windows.Forms.TextBox();
//            this.lblEmail = new System.Windows.Forms.Label();
//            this.Lblsenha = new System.Windows.Forms.Label();
//            this.Btncadastrar = new System.Windows.Forms.Button();
//            this.SuspendLayout();
//            // 
//            // txbNome
//            // 
//            this.txbNome.Location = new System.Drawing.Point(324, 55);
//            this.txbNome.Name = "txbNome";
//            this.txbNome.Size = new System.Drawing.Size(204, 20);
//            this.txbNome.TabIndex = 0;
//            this.txbNome.Text = "Nome e Sobrenome";
//            // 
//            // Lblnomecompl
//            // 
//            this.Lblnomecompl.AutoSize = true;
//            this.Lblnomecompl.Location = new System.Drawing.Point(321, 39);
//            this.Lblnomecompl.Name = "Lblnomecompl";
//            this.Lblnomecompl.Size = new System.Drawing.Size(81, 13);
//            this.Lblnomecompl.TabIndex = 1;
//            this.Lblnomecompl.Text = "Nome completo";
//            // 
//            // LblCPF
//            // 
//            this.LblCPF.AutoSize = true;
//            this.LblCPF.Location = new System.Drawing.Point(321, 87);
//            this.LblCPF.Name = "LblCPF";
//            this.LblCPF.Size = new System.Drawing.Size(27, 13);
//            this.LblCPF.TabIndex = 2;
//            this.LblCPF.Text = "CPF";
//            // 
//            // txbCpf
//            // 
//            this.txbCpf.Location = new System.Drawing.Point(325, 103);
//            this.txbCpf.Name = "txbCpf";
//            this.txbCpf.Size = new System.Drawing.Size(203, 20);
//            this.txbCpf.TabIndex = 3;
//            this.txbCpf.Text = "***.***.***-**";
//            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
//            // 
//            // LblTel
//            // 
//            this.LblTel.AutoSize = true;
//            this.LblTel.Location = new System.Drawing.Point(321, 140);
//            this.LblTel.Name = "LblTel";
//            this.LblTel.Size = new System.Drawing.Size(49, 13);
//            this.LblTel.TabIndex = 4;
//            this.LblTel.Text = "Telefone";
//            // 
//            // txbTel
//            // 
//            this.txbTel.Location = new System.Drawing.Point(324, 156);
//            this.txbTel.Name = "txbTel";
//            this.txbTel.Size = new System.Drawing.Size(204, 20);
//            this.txbTel.TabIndex = 5;
//            this.txbTel.Text = "(-) ----- - ----";
//            // 
//            // Lbldatadenasc
//            // 
//            this.Lbldatadenasc.AutoSize = true;
//            this.Lbldatadenasc.Location = new System.Drawing.Point(321, 189);
//            this.Lbldatadenasc.Name = "Lbldatadenasc";
//            this.Lbldatadenasc.Size = new System.Drawing.Size(104, 13);
//            this.Lbldatadenasc.TabIndex = 7;
//            this.Lbldatadenasc.Text = "Data de Nascimento";
//            // 
//            // txbDataN
//            // 
//            this.txbDataN.Location = new System.Drawing.Point(324, 205);
//            this.txbDataN.Name = "txbDataN";
//            this.txbDataN.Size = new System.Drawing.Size(204, 20);
//            this.txbDataN.TabIndex = 8;
//            this.txbDataN.Text = "DD/MM/AAA";
//            this.txbDataN.TextChanged += new System.EventHandler(this.txbDataN_TextChanged);
//            // 
//            // txbEmail
//            // 
//            this.txbEmail.Location = new System.Drawing.Point(324, 255);
//            this.txbEmail.Name = "txbEmail";
//            this.txbEmail.Size = new System.Drawing.Size(204, 20);
//            this.txbEmail.TabIndex = 9;
//            this.txbEmail.Text = "Seunome@email.com.br";
//            // 
//            // txbSenha
//            // 
//            this.txbSenha.Location = new System.Drawing.Point(324, 304);
//            this.txbSenha.Name = "txbSenha";
//            this.txbSenha.Size = new System.Drawing.Size(204, 20);
//            this.txbSenha.TabIndex = 10;
//            this.txbSenha.Text = "*****";
//            // 
//            // lblEmail
//            // 
//            this.lblEmail.AutoSize = true;
//            this.lblEmail.Location = new System.Drawing.Point(321, 239);
//            this.lblEmail.Name = "lblEmail";
//            this.lblEmail.Size = new System.Drawing.Size(35, 13);
//            this.lblEmail.TabIndex = 11;
//            this.lblEmail.Text = "E-mail";
//            // 
//            // Lblsenha
//            // 
//            this.Lblsenha.AutoSize = true;
//            this.Lblsenha.Location = new System.Drawing.Point(324, 288);
//            this.Lblsenha.Name = "Lblsenha";
//            this.Lblsenha.Size = new System.Drawing.Size(38, 13);
//            this.Lblsenha.TabIndex = 12;
//            this.Lblsenha.Text = "Senha";
//            // 
//            // Btncadastrar
//            // 
//            this.Btncadastrar.Location = new System.Drawing.Point(394, 339);
//            this.Btncadastrar.Name = "Btncadastrar";
//            this.Btncadastrar.Size = new System.Drawing.Size(75, 23);
//            this.Btncadastrar.TabIndex = 13;
//            this.Btncadastrar.Text = "Cadastrar-se";
//            this.Btncadastrar.UseVisualStyleBackColor = true;
//            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
//            // 
//            // Tela_Cadastro
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.Btncadastrar);
//            this.Controls.Add(this.Lblsenha);
//            this.Controls.Add(this.lblEmail);
//            this.Controls.Add(this.txbSenha);
//            this.Controls.Add(this.txbEmail);
//            this.Controls.Add(this.txbDataN);
//            this.Controls.Add(this.Lbldatadenasc);
//            this.Controls.Add(this.txbTel);
//            this.Controls.Add(this.LblTel);
//            this.Controls.Add(this.txbCpf);
//            this.Controls.Add(this.LblCPF);
//            this.Controls.Add(this.Lblnomecompl);
//            this.Controls.Add(this.txbNome);
//            this.Name = "Tela_Cadastro";
//            this.Text = "cadastro";
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.TextBox txbNome;
//        private System.Windows.Forms.Label Lblnomecompl;
//        private System.Windows.Forms.Label LblCPF;
//        private System.Windows.Forms.TextBox txbCpf;
//        private System.Windows.Forms.Label LblTel;
//        private System.Windows.Forms.TextBox txbTel;
//        private System.Windows.Forms.Label Lbldatadenasc;
//        private System.Windows.Forms.TextBox txbDataN;
//        private System.Windows.Forms.TextBox txbEmail;
//        private System.Windows.Forms.TextBox txbSenha;
//        private System.Windows.Forms.Label lblEmail;
//        private System.Windows.Forms.Label Lblsenha;
//        private System.Windows.Forms.Button Btncadastrar;
//    }
//}

namespace Vainafe_bus
{
    partial class Tela_Cadastro
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.Lblnomecompl = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.LblTel = new System.Windows.Forms.Label();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.Lbldatadenasc = new System.Windows.Forms.Label();
            this.txbDataN = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.Lblsenha = new System.Windows.Forms.Label();
            this.Btncadastrar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.White;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.Color.Gray;
            this.txbNome.Location = new System.Drawing.Point(53, 70);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(244, 21);
            this.txbNome.TabIndex = 1;
            this.txbNome.Text = "Nome e Sobrenome";
          
            // 
            // Lblnomecompl
            // 
            this.Lblnomecompl.AutoSize = true;
            this.Lblnomecompl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblnomecompl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lblnomecompl.Location = new System.Drawing.Point(50, 52);
            this.Lblnomecompl.Name = "Lblnomecompl";
            this.Lblnomecompl.Size = new System.Drawing.Size(100, 15);
            this.Lblnomecompl.TabIndex = 1;
            this.Lblnomecompl.Text = "Nome completo";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblCPF.Location = new System.Drawing.Point(50, 105);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(32, 15);
            this.LblCPF.TabIndex = 2;
            this.LblCPF.Text = "CPF";
            // 
            // txbCpf
            // 
            this.txbCpf.BackColor = System.Drawing.Color.White;
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCpf.ForeColor = System.Drawing.Color.Gray;
            this.txbCpf.Location = new System.Drawing.Point(53, 123);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(244, 21);
            this.txbCpf.TabIndex = 2;
            this.txbCpf.Text = "***.***.***-**";
           
           
            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTel.Location = new System.Drawing.Point(50, 158);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(61, 15);
            this.LblTel.TabIndex = 4;
            this.LblTel.Text = "Telefone";
            // 
            // txbTel
            // 
            this.txbTel.BackColor = System.Drawing.Color.White;
            this.txbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTel.ForeColor = System.Drawing.Color.Gray;
            this.txbTel.Location = new System.Drawing.Point(53, 176);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(244, 21);
            this.txbTel.TabIndex = 3;
            this.txbTel.Text = "( ) ----- - ----";
           
            
            // 
            // Lbldatadenasc
            // 
            this.Lbldatadenasc.AutoSize = true;
            this.Lbldatadenasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldatadenasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbldatadenasc.Location = new System.Drawing.Point(50, 211);
            this.Lbldatadenasc.Name = "Lbldatadenasc";
            this.Lbldatadenasc.Size = new System.Drawing.Size(130, 15);
            this.Lbldatadenasc.TabIndex = 7;
            this.Lbldatadenasc.Text = "Data de Nascimento";
            // 
            // txbDataN
            // 
            this.txbDataN.BackColor = System.Drawing.Color.White;
            this.txbDataN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDataN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataN.ForeColor = System.Drawing.Color.Gray;
            this.txbDataN.Location = new System.Drawing.Point(53, 229);
            this.txbDataN.Name = "txbDataN";
            this.txbDataN.Size = new System.Drawing.Size(244, 21);
            this.txbDataN.TabIndex = 4;
            this.txbDataN.Text = "DD/MM/AAAA";
           
           
            this.txbDataN.TextChanged += new System.EventHandler(this.txbDataN_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.Gray;
            this.txbEmail.Location = new System.Drawing.Point(53, 282);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(244, 21);
            this.txbEmail.TabIndex = 5;
            this.txbEmail.Text = "Seunome@email.com.br";
            
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.White;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.ForeColor = System.Drawing.Color.Gray;
            this.txbSenha.Location = new System.Drawing.Point(53, 335);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(244, 21);
            this.txbSenha.TabIndex = 6;
            this.txbSenha.Text = "Digite sua senha";
            
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(50, 264);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lblsenha.Location = new System.Drawing.Point(50, 317);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(47, 15);
            this.Lblsenha.TabIndex = 12;
            this.Lblsenha.Text = "Senha";
            // 
            // Btncadastrar
            // 
            this.Btncadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.Btncadastrar.FlatAppearance.BorderSize = 0;
            this.Btncadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastrar.ForeColor = System.Drawing.Color.White;
            this.Btncadastrar.Location = new System.Drawing.Point(53, 380);
            this.Btncadastrar.Name = "Btncadastrar";
            this.Btncadastrar.Size = new System.Drawing.Size(244, 35);
            this.Btncadastrar.TabIndex = 7;
            this.Btncadastrar.Text = "Cadastrar-se";
            this.Btncadastrar.UseVisualStyleBackColor = false;
            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.panelHeader.Controls.Add(this.btnVoltar);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(750, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(30, 30);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "←";
            this.btnVoltar.UseVisualStyleBackColor = false;
           
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
            // panelCadastro
            // 
            this.panelCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCadastro.BackColor = System.Drawing.Color.White;
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.labelSubtitle);
            this.panelCadastro.Controls.Add(this.Lblnomecompl);
            this.panelCadastro.Controls.Add(this.Btncadastrar);
            this.panelCadastro.Controls.Add(this.txbNome);
            this.panelCadastro.Controls.Add(this.Lblsenha);
            this.panelCadastro.Controls.Add(this.LblCPF);
            this.panelCadastro.Controls.Add(this.lblEmail);
            this.panelCadastro.Controls.Add(this.txbCpf);
            this.panelCadastro.Controls.Add(this.txbSenha);
            this.panelCadastro.Controls.Add(this.LblTel);
            this.panelCadastro.Controls.Add(this.txbEmail);
            this.panelCadastro.Controls.Add(this.txbTel);
            this.panelCadastro.Controls.Add(this.txbDataN);
            this.panelCadastro.Controls.Add(this.Lbldatadenasc);
            this.panelCadastro.Location = new System.Drawing.Point(200, 80);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(350, 450);
            this.panelCadastro.TabIndex = 15;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.labelSubtitle.Location = new System.Drawing.Point(48, 20);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(254, 24);
            this.labelSubtitle.TabIndex = 13;
            this.labelSubtitle.Text = "Crie sua conta Vainafe Bus";
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label Lblnomecompl;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.Label Lbldatadenasc;
        private System.Windows.Forms.TextBox txbDataN;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.Button Btncadastrar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label labelSubtitle;
    }
}