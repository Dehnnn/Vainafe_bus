namespace Vainafe_bus
{
    partial class cadastro
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
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(324, 55);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(204, 20);
            this.txbNome.TabIndex = 0;
            this.txbNome.Text = "Nome e Sobrenome";
            // 
            // Lblnomecompl
            // 
            this.Lblnomecompl.AutoSize = true;
            this.Lblnomecompl.Location = new System.Drawing.Point(321, 39);
            this.Lblnomecompl.Name = "Lblnomecompl";
            this.Lblnomecompl.Size = new System.Drawing.Size(81, 13);
            this.Lblnomecompl.TabIndex = 1;
            this.Lblnomecompl.Text = "Nome completo";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(321, 87);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(27, 13);
            this.LblCPF.TabIndex = 2;
            this.LblCPF.Text = "CPF";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(325, 103);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(203, 20);
            this.txbCpf.TabIndex = 3;
            this.txbCpf.Text = "***.***.***-**";
            this.txbCpf.TextChanged += new System.EventHandler(this.txbCpf_TextChanged);
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(321, 140);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(49, 13);
            this.LblTel.TabIndex = 4;
            this.LblTel.Text = "Telefone";
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(324, 156);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(204, 20);
            this.txbTel.TabIndex = 5;
            this.txbTel.Text = "(-) ----- - ----";
            // 
            // Lbldatadenasc
            // 
            this.Lbldatadenasc.AutoSize = true;
            this.Lbldatadenasc.Location = new System.Drawing.Point(321, 189);
            this.Lbldatadenasc.Name = "Lbldatadenasc";
            this.Lbldatadenasc.Size = new System.Drawing.Size(104, 13);
            this.Lbldatadenasc.TabIndex = 7;
            this.Lbldatadenasc.Text = "Data de Nascimento";
            // 
            // txbDataN
            // 
            this.txbDataN.Location = new System.Drawing.Point(324, 205);
            this.txbDataN.Name = "txbDataN";
            this.txbDataN.Size = new System.Drawing.Size(204, 20);
            this.txbDataN.TabIndex = 8;
            this.txbDataN.Text = "DD/MM/AAA";
            this.txbDataN.TextChanged += new System.EventHandler(this.txbDataN_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(324, 255);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(204, 20);
            this.txbEmail.TabIndex = 9;
            this.txbEmail.Text = "Seunome@email.com.br";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(324, 304);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(204, 20);
            this.txbSenha.TabIndex = 10;
            this.txbSenha.Text = "*****";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(321, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Location = new System.Drawing.Point(324, 288);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(38, 13);
            this.Lblsenha.TabIndex = 12;
            this.Lblsenha.Text = "Senha";
            // 
            // Btncadastrar
            // 
            this.Btncadastrar.Location = new System.Drawing.Point(394, 339);
            this.Btncadastrar.Name = "Btncadastrar";
            this.Btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btncadastrar.TabIndex = 13;
            this.Btncadastrar.Text = "Cadastrar-se";
            this.Btncadastrar.UseVisualStyleBackColor = true;
            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btncadastrar);
            this.Controls.Add(this.Lblsenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbDataN);
            this.Controls.Add(this.Lbldatadenasc);
            this.Controls.Add(this.txbTel);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.Lblnomecompl);
            this.Controls.Add(this.txbNome);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}