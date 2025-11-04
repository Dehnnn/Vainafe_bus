namespace Vainafe_bus
{
    partial class Paineladmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntrelatorios = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnviagens = new System.Windows.Forms.Button();
            this.btnpassagens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntrelatorios);
            this.panel1.Controls.Add(this.btnusuarios);
            this.panel1.Controls.Add(this.btnviagens);
            this.panel1.Controls.Add(this.btnpassagens);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 451);
            this.panel1.TabIndex = 1;
            // 
            // bntrelatorios
            // 
            this.bntrelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntrelatorios.Location = new System.Drawing.Point(12, 271);
            this.bntrelatorios.Name = "bntrelatorios";
            this.bntrelatorios.Size = new System.Drawing.Size(192, 29);
            this.bntrelatorios.TabIndex = 5;
            this.bntrelatorios.Text = "Relatórios";
            this.bntrelatorios.UseVisualStyleBackColor = true;
            // 
            // btnusuarios
            // 
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.Location = new System.Drawing.Point(12, 206);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(192, 29);
            this.btnusuarios.TabIndex = 4;
            this.btnusuarios.Text = "Gerenciar Usuários";
            this.btnusuarios.UseVisualStyleBackColor = true;
            // 
            // btnviagens
            // 
            this.btnviagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviagens.Location = new System.Drawing.Point(12, 69);
            this.btnviagens.Name = "btnviagens";
            this.btnviagens.Size = new System.Drawing.Size(192, 29);
            this.btnviagens.TabIndex = 3;
            this.btnviagens.Text = "gerenciar Viagens";
            this.btnviagens.UseVisualStyleBackColor = true;
            this.btnviagens.Click += new System.EventHandler(this.btnviagens_Click);
            // 
            // btnpassagens
            // 
            this.btnpassagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpassagens.Location = new System.Drawing.Point(12, 140);
            this.btnpassagens.Name = "btnpassagens";
            this.btnpassagens.Size = new System.Drawing.Size(192, 29);
            this.btnpassagens.TabIndex = 0;
            this.btnpassagens.Text = "Gerenciar Passagens";
            this.btnpassagens.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel do Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seja bem Vindo!";
            // 
            // Paineladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Paineladmin";
            this.Text = "Paineladmin";
            this.Load += new System.EventHandler(this.Paineladmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnviagens;
        private System.Windows.Forms.Button btnpassagens;
        private System.Windows.Forms.Button bntrelatorios;
        private System.Windows.Forms.Button btnusuarios;
    }
}