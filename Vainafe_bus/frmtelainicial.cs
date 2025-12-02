//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vainafe_bus
//{
//    public partial class Tela_Inicial : Form
//    {
//        public Tela_Inicial()
//        {
//            InitializeComponent();
//            CarregarCidadesEDatas();
//        }

//        private void CarregarCidadesEDatas()
//        {
//            // Carrega cidades nos ComboBox
//            string[] cidades = {
//                "São Paulo", "Rio de Janeiro", "Campinas", "Santos",
//                "São José dos Campos", "Mogi das Cruzes", "Ubatuba", "Paraty",
//                "Angra dos Reis", "Campos do Jordão", "Aparecida", "Guarulhos",
//                "São Sebastião", "Caraguatatuba", "Ilhabela", "Bertioga",
//                "Jacareí", "Suzano", "Pouso Alegre (MG)", "Cachoeira de Minas (MG)"
//            };

//            Array.Sort(cidades);

//            comboxorigem.Items.Clear();
//            comboxdestino.Items.Clear();

//            comboxorigem.Items.AddRange(cidades);
//            comboxdestino.Items.AddRange(cidades);

//            // Configura datas nos ComboBox
//            ConfigurarDatasComboBox();
//        }

//        private void ConfigurarDatasComboBox()
//        {
//            comboxida.Items.Clear();
//            comboxvolta.Items.Clear();

//            // Adiciona datas dos próximos 30 dias
//            for (int i = 0; i < 30; i++)
//            {
//                DateTime data = DateTime.Today.AddDays(i);
//                string dataFormatada = data.ToString("dd/MM/yyyy");

//                comboxida.Items.Add(dataFormatada);
//                comboxvolta.Items.Add(dataFormatada);
//            }

//            // Seleciona hoje e amanhã como padrão
//            comboxida.SelectedIndex = 0; // Hoje
//            comboxvolta.SelectedIndex = 1; // Amanhã
//        }

//        private void comboxbusca_Click(object sender, EventArgs e)
//        {
//            // Validação SIMPLES - só o básico
//            if (comboxorigem.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a cidade de origem.");
//                return;
//            }

//            if (comboxdestino.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a cidade de destino.");
//                return;
//            }

//            if (comboxida.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a data de ida.");
//                return;
//            }

//            // MOSTRA O QUE FOI SELECIONADO
//            string mensagem = $"Buscar passagens:\n\n" +
//                             $"Origem: {comboxorigem.Text}\n" +
//                             $"Destino: {comboxdestino.Text}\n" +
//                             $"Data Ida: {comboxida.Text}\n" +
//                             $"Data Volta: {comboxvolta.Text}";

//            MessageBox.Show(mensagem, "Buscar Passagens");
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Tela_Cadastro product = new Tela_Cadastro();
//            this.Visible = false;
//            product.ShowDialog();
//            this.Visible = true;
//        }

//        private void BtnLogin_Click(object sender, EventArgs e)
//        {
//            Login_Tela product = new Login_Tela();
//            this.Visible = false;
//            product.ShowDialog();
//            this.Visible = true;
//        }

//        private void label2_Click(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void Tela_Inicial_Load(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxdestino_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxida_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxvolta_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vainafe_bus
//{
//    public partial class Tela_Inicial : Form
//    {
//        public Tela_Inicial()
//        {
//            InitializeComponent();
//            CarregarCidadesEDatas();
//        }

//        private void CarregarCidadesEDatas()
//        {
//            // Carrega cidades nos ComboBox
//            string[] cidades = {
//                "São Paulo", "Rio de Janeiro", "Campinas", "Santos",
//                "São José dos Campos", "Mogi das Cruzes", "Ubatuba", "Paraty",
//                "Angra dos Reis", "Campos do Jordão", "Aparecida", "Guarulhos",
//                "São Sebastião", "Caraguatatuba", "Ilhabela", "Bertioga",
//                "Jacareí", "Suzano", "Pouso Alegre (MG)", "Cachoeira de Minas (MG)"
//            };

//            Array.Sort(cidades);

//            comboxorigem.Items.Clear();
//            comboxdestino.Items.Clear();

//            comboxorigem.Items.AddRange(cidades);
//            comboxdestino.Items.AddRange(cidades);

//            // Configura datas nos ComboBox
//            ConfigurarDatasComboBox();
//        }

//        private void ConfigurarDatasComboBox()
//        {
//            comboxida.Items.Clear();
//            comboxvolta.Items.Clear();

//            // Adiciona datas dos próximos 30 dias
//            for (int i = 0; i < 30; i++)
//            {
//                DateTime data = DateTime.Today.AddDays(i);
//                string dataFormatada = data.ToString("dd/MM/yyyy");

//                comboxida.Items.Add(dataFormatada);
//                comboxvolta.Items.Add(dataFormatada);
//            }

//            // Seleciona hoje e amanhã como padrão
//            comboxida.SelectedIndex = 0; // Hoje
//            comboxvolta.SelectedIndex = 1; // Amanhã
//        }

//        private void comboxbusca_Click(object sender, EventArgs e)
//        {
//            // Validação SIMPLES
//            if (comboxorigem.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a cidade de origem.");
//                return;
//            }

//            if (comboxdestino.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a cidade de destino.");
//                return;
//            }

//            if (comboxida.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a data de ida.");
//                return;
//            }

//            // Converte data
//            DateTime dataIda;
//            if (!DateTime.TryParseExact(comboxida.Text, "dd/MM/yyyy", null, 
//                System.Globalization.DateTimeStyles.None, out dataIda))
//            {
//                MessageBox.Show("Data de ida inválida.");
//                return;
//            }

//            // SIMULA VIAGENS DO BANCO
//            List<Viagem> viagensEncontradas = SimularViagensDoBanco(
//                comboxorigem.Text, 
//                comboxdestino.Text, 
//                dataIda
//            );

//            DateTime? volta = comboxvolta.SelectedItem != null ? 
//                DateTime.ParseExact(comboxvolta.Text, "dd/MM/yyyy", null) : 
//                (DateTime?)null;

//            // Abre tela de resultados
//            TelaResultadosBusca resultados = new TelaResultadosBusca(viagensEncontradas, volta);
//            this.Hide();
//            resultados.ShowDialog();
//            this.Show();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Tela_Cadastro product = new Tela_Cadastro();
//            this.Visible = false;
//            product.ShowDialog();
//            this.Visible = true;
//        }

//        private void BtnLogin_Click(object sender, EventArgs e)
//        {
//            Login_Tela product = new Login_Tela();
//            this.Visible = false;
//            product.ShowDialog();
//            this.Visible = true;
//        }

//        private void label2_Click(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void Tela_Inicial_Load(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxdestino_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxida_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        private void comboxvolta_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Não faz nada
//        }

//        // Método que SIMULA o banco de dados
//        private List<Viagem> SimularViagensDoBanco(string origem, string destino, DateTime dataIda)
//        {
//            var random = new Random();
//            var viagens = new List<Viagem>();

//            // Simula 3-5 viagens
//            int quantidade = random.Next(3, 6);

//            for (int i = 0; i < quantidade; i++)
//            {
//                viagens.Add(new Viagem
//                {

//                    Origem = origem,
//                    Destino = destino,
//                    DataSaida = dataIda.AddHours(6 + (i * 3)), // 06:00, 09:00, 12:00, etc
//                    DataChegada = dataIda.AddHours(6 + (i * 3) + 4), // 4 horas de viagem
//                    Preco = random.Next(3000, 8000) / 100m, // R$ 30,00 a R$ 80,00
//                    AssentosDisponiveis = random.Next(5, 43),
//                    OnibusNumero = $"BUS-{random.Next(100, 500)}"
//                });
//            }

//            return viagens;
//        }
//    }

//    // Classe Viagem para representar os dados

//    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // ← ADICIONA ISSO!

namespace Vainafe_bus
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
            CarregarCidadesEDatas();
        }

        private void CarregarCidadesEDatas()
        {
            // Carrega cidades nos ComboBox - ATUALIZA COM SUAS ROTAS!
            string[] cidades = {
                "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba",
                "Florianópolis", "Brasília", "Vitória", "Campinas"
            };

            Array.Sort(cidades);

            comboxorigem.Items.Clear();
            comboxdestino.Items.Clear();

            comboxorigem.Items.AddRange(cidades);
            comboxdestino.Items.AddRange(cidades);

            // Configura datas nos ComboBox
            ConfigurarDatasComboBox();
        }

        private void ConfigurarDatasComboBox()
        {
            comboxida.Items.Clear();
            comboxvolta.Items.Clear();

            // Adiciona datas dos próximos 30 dias
            for (int i = 0; i < 30; i++)
            {
                DateTime data = DateTime.Today.AddDays(i);
                string dataFormatada = data.ToString("dd/MM/yyyy");

                comboxida.Items.Add(dataFormatada);
                comboxvolta.Items.Add(dataFormatada);
            }

            // Seleciona hoje e amanhã como padrão
            comboxida.SelectedIndex = 0; // Hoje
            comboxvolta.SelectedIndex = 1; // Amanhã
        }

        private void comboxbusca_Click(object sender, EventArgs e)
        {
            // Validação SIMPLES
            if (comboxorigem.SelectedItem == null)
            {
                MessageBox.Show("Selecione a cidade de origem.");
                return;
            }

            if (comboxdestino.SelectedItem == null)
            {
                MessageBox.Show("Selecione a cidade de destino.");
                return;
            }

            if (comboxida.SelectedItem == null)
            {
                MessageBox.Show("Selecione a data de ida.");
                return;
            }

            // Converte data
            DateTime dataIda;
            if (!DateTime.TryParseExact(comboxida.Text, "dd/MM/yyyy", null,
                System.Globalization.DateTimeStyles.None, out dataIda))
            {
                MessageBox.Show("Data de ida inválida.");
                return;
            }

            // BUSCA NO BANCO REAL - USA SEU BANCO!
            List<Viagem> viagensEncontradas = BuscarViagensNoBanco(
                comboxorigem.Text,
                comboxdestino.Text,
                dataIda
            );

            DateTime? volta = comboxvolta.SelectedItem != null ?
                DateTime.ParseExact(comboxvolta.Text, "dd/MM/yyyy", null) :
                (DateTime?)null;

            if (viagensEncontradas.Count > 0)
            {
                // Abre tela de resultados
                TelaResultadosBusca resultados = new TelaResultadosBusca(viagensEncontradas, volta);
                this.Hide();
                resultados.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nenhuma passagem encontrada para esta rota e data.\n\n" +
                               "Tente outras datas ou cidades diferentes.",
                               "Busca sem resultados",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<Viagem> BuscarViagensNoBanco(string origem, string destino, DateTime dataIda)
        {
            List<Viagem> viagens = new List<Viagem>();

            string conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";

            // USA A SUA VIEW QUE JÁ TEM TUDO!
            string sql = @"
                SELECT 
                    ID_VIAGEM,
                    ORIGEM,
                    DESTINO,
                    DATA_HORA_SAIDA,
                    DATA_HORA_CHEGADA,
                    PRECO,
                    CAPACIDADE,
                    PLACA,
                    MODELO
                FROM VW_VIAGENS_COMPLETA 
                WHERE ORIGEM = @Origem 
                AND DESTINO = @Destino 
                AND CAST(DATA_HORA_SAIDA AS DATE) = @DataIda
                AND CAPACIDADE > 0
                ORDER BY DATA_HORA_SAIDA";

            try
            {
                using (SqlConnection conn = new SqlConnection(conexao))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Origem", origem);
                    cmd.Parameters.AddWithValue("@Destino", destino);
                    cmd.Parameters.AddWithValue("@DataIda", dataIda.Date);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Viagem viagem = new Viagem
                        {
                           
                            Origem = reader.GetString(1),
                            Destino = reader.GetString(2),
                            DataSaida = reader.GetDateTime(3),
                            DataChegada = reader.GetDateTime(4),
                            Preco = reader.GetDecimal(5),
                            AssentosDisponiveis = reader.GetInt32(6), // CAPACIDADE do ônibus
                            OnibusNumero = reader.GetString(7) + " - " + reader.GetString(8) // PLACA + MODELO
                        };
                        viagens.Add(viagem);
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao buscar no banco: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return viagens;
        }

        // ... (os outros métodos permanecem iguais)
        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Cadastro product = new Tela_Cadastro();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login_Tela product = new Login_Tela();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        // ... (outros métodos)
    }
}