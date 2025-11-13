using System.Drawing;
using System.Windows.Forms;
using System;

namespace Vainafe_bus
{
    partial class Novaviagem
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Panel panelForm;
        private ComboBox cmbOrigem;
        private ComboBox cmbDestino;
        private ComboBox cmbOnibus;
        private DateTimePicker dtpDataSaida;
        private DateTimePicker dtpDataChegada;
        private TextBox txtPreco;
        private TextBox txtVagas;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label lblOrigem;
        private Label lblDestino;
        private Label lblOnibus;
        private Label lblDataSaida;
        private Label lblHoraSaida;
        private Label lblDataChegada;
        private Label lblHoraChegada;
        private Label lblPreco;
        private Label lblVagas;
        private ComboBox cmbHoraSaida;    // ← NOVO
        private ComboBox cmbHoraChegada;  // ← NOVO

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.cmbHoraChegada = new System.Windows.Forms.ComboBox();
            this.cmbHoraSaida = new System.Windows.Forms.ComboBox();
            this.lblVagas = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblHoraChegada = new System.Windows.Forms.Label();
            this.lblDataChegada = new System.Windows.Forms.Label();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblOnibus = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.dtpDataChegada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.cmbOnibus = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🚌 Nova Viagem";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.cmbHoraChegada);
            this.panelForm.Controls.Add(this.cmbHoraSaida);
            this.panelForm.Controls.Add(this.lblVagas);
            this.panelForm.Controls.Add(this.lblPreco);
            this.panelForm.Controls.Add(this.lblHoraChegada);
            this.panelForm.Controls.Add(this.lblDataChegada);
            this.panelForm.Controls.Add(this.lblHoraSaida);
            this.panelForm.Controls.Add(this.lblDataSaida);
            this.panelForm.Controls.Add(this.lblOnibus);
            this.panelForm.Controls.Add(this.lblDestino);
            this.panelForm.Controls.Add(this.lblOrigem);
            this.panelForm.Controls.Add(this.btnCancelar);
            this.panelForm.Controls.Add(this.btnSalvar);
            this.panelForm.Controls.Add(this.txtVagas);
            this.panelForm.Controls.Add(this.txtPreco);
            this.panelForm.Controls.Add(this.dtpDataChegada);
            this.panelForm.Controls.Add(this.dtpDataSaida);
            this.panelForm.Controls.Add(this.cmbOnibus);
            this.panelForm.Controls.Add(this.cmbDestino);
            this.panelForm.Controls.Add(this.cmbOrigem);
            this.panelForm.Location = new System.Drawing.Point(20, 60);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(500, 400);
            this.panelForm.TabIndex = 1;
            // 
            // cmbHoraChegada
            // 
            this.cmbHoraChegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbHoraChegada.FormattingEnabled = true;
            this.cmbHoraChegada.Location = new System.Drawing.Point(310, 190);
            this.cmbHoraChegada.Name = "cmbHoraChegada";
            this.cmbHoraChegada.Size = new System.Drawing.Size(140, 24);
            this.cmbHoraChegada.TabIndex = 21;
            // 
            // cmbHoraSaida
            // 
            this.cmbHoraSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbHoraSaida.FormattingEnabled = true;
            this.cmbHoraSaida.Location = new System.Drawing.Point(310, 150);
            this.cmbHoraSaida.Name = "cmbHoraSaida";
            this.cmbHoraSaida.Size = new System.Drawing.Size(140, 24);
            this.cmbHoraSaida.TabIndex = 20;
            // 
            // lblVagas
            // 
            this.lblVagas.AutoSize = true;
            this.lblVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblVagas.Location = new System.Drawing.Point(30, 273);
            this.lblVagas.Name = "lblVagas";
            this.lblVagas.Size = new System.Drawing.Size(108, 17);
            this.lblVagas.TabIndex = 19;
            this.lblVagas.Text = "Vagas Totais:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPreco.Location = new System.Drawing.Point(30, 233);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(55, 17);
            this.lblPreco.TabIndex = 18;
            this.lblPreco.Text = "Preço:";
            // 
            // lblHoraChegada
            // 
            this.lblHoraChegada.AutoSize = true;
            this.lblHoraChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoraChegada.Location = new System.Drawing.Point(300, 193);
            this.lblHoraChegada.Name = "lblHoraChegada";
            this.lblHoraChegada.Size = new System.Drawing.Size(48, 17);
            this.lblHoraChegada.TabIndex = 17;
            this.lblHoraChegada.Text = "Hora:";
            // 
            // lblDataChegada
            // 
            this.lblDataChegada.AutoSize = true;
            this.lblDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataChegada.Location = new System.Drawing.Point(30, 193);
            this.lblDataChegada.Name = "lblDataChegada";
            this.lblDataChegada.Size = new System.Drawing.Size(116, 17);
            this.lblDataChegada.TabIndex = 16;
            this.lblDataChegada.Text = "Data Chegada:";
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoraSaida.Location = new System.Drawing.Point(300, 153);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(48, 17);
            this.lblHoraSaida.TabIndex = 15;
            this.lblHoraSaida.Text = "Hora:";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataSaida.Location = new System.Drawing.Point(30, 153);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(93, 17);
            this.lblDataSaida.TabIndex = 14;
            this.lblDataSaida.Text = "Data Saída:";
            // 
            // lblOnibus
            // 
            this.lblOnibus.AutoSize = true;
            this.lblOnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOnibus.Location = new System.Drawing.Point(30, 113);
            this.lblOnibus.Name = "lblOnibus";
            this.lblOnibus.Size = new System.Drawing.Size(64, 17);
            this.lblOnibus.TabIndex = 13;
            this.lblOnibus.Text = "Ônibus:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDestino.Location = new System.Drawing.Point(30, 73);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(68, 17);
            this.lblDestino.TabIndex = 12;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrigem.Location = new System.Drawing.Point(30, 33);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(65, 17);
            this.lblOrigem.TabIndex = 11;
            this.lblOrigem.Text = "Origem:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(380, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(270, 320);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "💾 Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtVagas
            // 
            this.txtVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVagas.Location = new System.Drawing.Point(150, 270);
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(300, 23);
            this.txtVagas.TabIndex = 8;
            this.txtVagas.Text = "40";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPreco.Location = new System.Drawing.Point(150, 230);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(300, 23);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.Text = "0,00";
            // 
            // dtpDataChegada
            // 
            this.dtpDataChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDataChegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataChegada.Location = new System.Drawing.Point(150, 190);
            this.dtpDataChegada.Name = "dtpDataChegada";
            this.dtpDataChegada.Size = new System.Drawing.Size(140, 23);
            this.dtpDataChegada.TabIndex = 5;
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(150, 150);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(140, 23);
            this.dtpDataSaida.TabIndex = 3;
            // 
            // cmbOnibus
            // 
            this.cmbOnibus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOnibus.FormattingEnabled = true;
            this.cmbOnibus.Location = new System.Drawing.Point(150, 110);
            this.cmbOnibus.Name = "cmbOnibus";
            this.cmbOnibus.Size = new System.Drawing.Size(300, 24);
            this.cmbOnibus.TabIndex = 2;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(150, 70);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(300, 24);
            this.cmbDestino.TabIndex = 1;
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Location = new System.Drawing.Point(150, 30);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(300, 24);
            this.cmbOrigem.TabIndex = 0;
            // 
            // Novaviagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(544, 481);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Novaviagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Viagem - Vainafe Bus";
            this.Load += new System.EventHandler(this.Novaviagem_Load);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}