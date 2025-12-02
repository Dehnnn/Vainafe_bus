using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class TelaResultadosBusca : Form
    {
        private List<Viagem> viagens; // ✅ CORRIGIDO
        private DateTime? dataVolta;

        public TelaResultadosBusca(List<Viagem> viagensEncontradas, DateTime? volta) // ✅ CORRIGIDO
        {
            InitializeComponent();
            this.viagens = viagensEncontradas;
            this.dataVolta = volta;
            CarregarResultados();
        }

        private void CarregarResultados()
        {
            // Limpa resultados anteriores
            panelResultados.Controls.Clear();

            if (viagens == null || viagens.Count == 0)
            {
                Label lblSemResultados = new Label();
                lblSemResultados.Text = "Nenhuma passagem encontrada 😔";
                lblSemResultados.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblSemResultados.ForeColor = Color.Gray;
                lblSemResultados.AutoSize = true;
                lblSemResultados.Location = new Point(20, 20);
                panelResultados.Controls.Add(lblSemResultados);
                return;
            }

            int yPos = 10;

            foreach (var viagem in viagens)
            {
                // Cria um panel para cada viagem
                Panel panelViagem = new Panel();
                panelViagem.BorderStyle = BorderStyle.FixedSingle;
                panelViagem.BackColor = Color.White;
                panelViagem.Size = new Size(600, 80);
                panelViagem.Location = new Point(10, yPos);

                // Horário
                Label lblHorario = new Label();
                lblHorario.Text = viagem.DataSaida.ToString("HH:mm");
                lblHorario.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                lblHorario.ForeColor = Color.FromArgb(70, 130, 180);
                lblHorario.AutoSize = true;
                lblHorario.Location = new Point(10, 10);
                panelViagem.Controls.Add(lblHorario);

                // Origem -> Destino
                Label lblRota = new Label();
                lblRota.Text = $"{viagem.Origem} → {viagem.Destino}";
                lblRota.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                lblRota.AutoSize = true;
                lblRota.Location = new Point(80, 15);
                panelViagem.Controls.Add(lblRota);

                // Ônibus
                Label lblOnibus = new Label();
                lblOnibus.Text = $"Ônibus: {viagem.OnibusNumero}";
                lblOnibus.Font = new Font("Microsoft Sans Serif", 8);
                lblOnibus.ForeColor = Color.Gray;
                lblOnibus.AutoSize = true;
                lblOnibus.Location = new Point(80, 35);
                panelViagem.Controls.Add(lblOnibus);

                // Assentos
                Label lblAssentos = new Label();
                lblAssentos.Text = $"{viagem.AssentosDisponiveis} assentos disponíveis";
                lblAssentos.Font = new Font("Microsoft Sans Serif", 8);
                lblAssentos.ForeColor = viagem.AssentosDisponiveis > 10 ? Color.Green : Color.Orange;
                lblAssentos.AutoSize = true;
                lblAssentos.Location = new Point(80, 50);
                panelViagem.Controls.Add(lblAssentos);

                // Preço
                Label lblPreco = new Label();
                lblPreco.Text = $"R$ {viagem.Preco:F2}";
                lblPreco.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblPreco.ForeColor = Color.FromArgb(40, 167, 69);
                lblPreco.AutoSize = true;
                lblPreco.Location = new Point(450, 25);
                panelViagem.Controls.Add(lblPreco);

                // Botão Selecionar
                Button btnSelecionar = new Button();
                btnSelecionar.Text = "🎫 Selecionar";
                btnSelecionar.BackColor = Color.FromArgb(70, 130, 180);
                btnSelecionar.ForeColor = Color.White;
                btnSelecionar.FlatStyle = FlatStyle.Flat;
                btnSelecionar.Size = new Size(100, 30);
                btnSelecionar.Location = new Point(480, 45);
                btnSelecionar.Tag = viagem; // Guarda a viagem no botão
                btnSelecionar.Click += BtnSelecionar_Click;
                panelViagem.Controls.Add(btnSelecionar);

                panelResultados.Controls.Add(panelViagem);
                yPos += 90;
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Viagem viagemSelecionada = (Viagem)btn.Tag; // ✅ CORRIGIDO

            MessageBox.Show($"🎉 Passagem selecionada!\n\n" +
                          $"⏰ {viagemSelecionada.DataSaida:HH:mm}\n" +
                          $"📍 {viagemSelecionada.Origem} → {viagemSelecionada.Destino}\n" +
                          $"💺 {viagemSelecionada.OnibusNumero}\n" +
                          $"💰 R$ {viagemSelecionada.Preco:F2}\n\n" +
                          $"Próximo passo: tela de pagamento!",
                          "Passagem Selecionada",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelResultados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}