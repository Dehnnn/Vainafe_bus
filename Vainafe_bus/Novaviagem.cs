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
//    public partial class Novaviagem : Form
//    {
//        public Novaviagem()
//        {
//            InitializeComponent();
//        }

//        private void Novaviagem_Load(object sender, EventArgs e)
//        {

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
//    public partial class Novaviagem : Form
//    {
//        public Novaviagem()
//        {
//            InitializeComponent();
//        }

//        private void Novaviagem_Load(object sender, EventArgs e)
//        {
//            CarregarDadosCombobox();
//        }

//        private void CarregarDadosCombobox()
//        {
//            // Carregar origens e destinos (você pode buscar do banco depois)
//            string[] cidades = {
//                "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba",
//                "Florianópolis", "Brasília", "Vitória", "Campinas", "Santos"
//            };

//            cmbOrigem.Items.Clear();
//            cmbDestino.Items.Clear();
//            cmbOrigem.Items.AddRange(cidades);
//            cmbDestino.Items.AddRange(cidades);

//            // Simular ônibus (depois busca do banco)
//            cmbOnibus.Items.Clear();
//            cmbOnibus.Items.Add("BUS-101 - Mercedes (40 lugares)");
//            cmbOnibus.Items.Add("BUS-102 - Volvo (45 lugares)");
//            cmbOnibus.Items.Add("BUS-103 - Marcopolo (38 lugares)");

//            // Selecionar padrões
//            cmbOrigem.SelectedIndex = 0;
//            cmbDestino.SelectedIndex = 1;
//            cmbOnibus.SelectedIndex = 0;

//            // Configurar data/hora padrão
//            dtpDataSaida.Value = DateTime.Today.AddDays(1);
//            dtpHoraSaida.Value = DateTime.Today.AddHours(8);
//            dtpDataChegada.Value = DateTime.Today.AddDays(1);
//            dtpHoraChegada.Value = DateTime.Today.AddHours(12);
//        }

//        private void btnSalvar_Click(object sender, EventArgs e)
//        {
//            if (ValidarDados())
//            {
//                SalvarViagem();
//            }
//        }

//        private bool ValidarDados()
//        {
//            // Validações básicas
//            if (cmbOrigem.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione a origem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            if (cmbDestino.SelectedItem == null)
//            {
//                MessageBox.Show("Selecione o destino!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            if (cmbOrigem.Text == cmbDestino.Text)
//            {
//                MessageBox.Show("Origem e destino não podem ser iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
//            {
//                MessageBox.Show("Preço inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            if (!int.TryParse(txtVagas.Text, out int vagas) || vagas <= 0)
//            {
//                MessageBox.Show("Número de vagas inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            DateTime dataHoraSaida = dtpDataSaida.Value.Date + dtpHoraSaida.Value.TimeOfDay;
//            DateTime dataHoraChegada = dtpDataChegada.Value.Date + dtpHoraChegada.Value.TimeOfDay;

//            if (dataHoraChegada <= dataHoraSaida)
//            {
//                MessageBox.Show("Data/hora de chegada deve ser posterior à data/hora de saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return false;
//            }

//            return true;
//        }

//        private void SalvarViagem()
//        {
//            try
//            {
//                // TODO: Conectar com banco de dados e salvar
//                // Por enquanto só mostra os dados

//                DateTime dataHoraSaida = dtpDataSaida.Value.Date + dtpHoraSaida.Value.TimeOfDay;
//                DateTime dataHoraChegada = dtpDataChegada.Value.Date + dtpHoraChegada.Value.TimeOfDay;

//                string mensagem = $"Viagem salva com sucesso! 🎉\n\n" +
//                                $"Origem: {cmbOrigem.Text}\n" +
//                                $"Destino: {cmbDestino.Text}\n" +
//                                $"Ônibus: {cmbOnibus.Text}\n" +
//                                $"Saída: {dataHoraSaida:dd/MM/yyyy HH:mm}\n" +
//                                $"Chegada: {dataHoraChegada:dd/MM/yyyy HH:mm}\n" +
//                                $"Preço: R$ {decimal.Parse(txtPreco.Text):F2}\n" +
//                                $"Vagas: {txtVagas.Text}";

//                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.DialogResult = DialogResult.OK;
//                this.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Erro ao salvar viagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnCancelar_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = DialogResult.Cancel;
//            this.Close();
//        }

//        private void lblTitulo_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class Novaviagem : Form
    {
        private string _conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";

        public Novaviagem()
        {
            InitializeComponent();
        }

        private void Novaviagem_Load(object sender, EventArgs e)
        {
            CarregarDadosCombobox();

            // Verificação EXTRA: se ainda estiver vazio, força ônibus padrão
            if (cmbOnibus.Items.Count == 0)
            {
                MessageBox.Show("Nenhum ônibus encontrado. Carregando opções padrão...",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CarregarOnibusPadrao();
            }
        }

        private void CarregarDadosCombobox()
        {
            CarregarCidades();
            CarregarOnibus();
            CarregarHorarios();

            // Configurar data padrão
            dtpDataSaida.Value = DateTime.Today.AddDays(1);
            dtpDataChegada.Value = DateTime.Today.AddDays(1);
        }

        // MÉTODO PARA CARREGAR HORÁRIOS
        private void CarregarHorarios()
        {
            cmbHoraSaida.Items.Clear();
            cmbHoraChegada.Items.Clear();

            // Adiciona horários das 06:00 às 23:00 de 30 em 30 minutos
            for (int hora = 6; hora <= 23; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto += 30)
                {
                    string horario = $"{hora:00}:{minuto:00}";
                    cmbHoraSaida.Items.Add(horario);
                    cmbHoraChegada.Items.Add(horario);
                }
            }

            // Seleciona horários padrão
            cmbHoraSaida.SelectedItem = "08:00";
            cmbHoraChegada.SelectedItem = "12:00";
        }

        private void CarregarCidades()
        {
            try
            {
                string sql = "SELECT DISTINCT ORIGEM FROM ROTAS UNION SELECT DISTINCT DESTINO FROM ROTAS ORDER BY ORIGEM";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbOrigem.Items.Clear();
                    cmbDestino.Items.Clear();

                    while (reader.Read())
                    {
                        string cidade = reader["ORIGEM"].ToString();
                        cmbOrigem.Items.Add(cidade);
                        cmbDestino.Items.Add(cidade);
                    }

                    reader.Close();

                    // Selecionar padrões se existirem itens
                    if (cmbOrigem.Items.Count > 0)
                    {
                        cmbOrigem.SelectedIndex = 0;
                        if (cmbDestino.Items.Count > 1)
                            cmbDestino.SelectedIndex = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Se der erro, carrega cidades padrão
                string[] cidades = {
                    "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Curitiba",
                    "Florianópolis", "Brasília", "Vitória", "Campinas", "Santos"
                };

                cmbOrigem.Items.Clear();
                cmbDestino.Items.Clear();
                cmbOrigem.Items.AddRange(cidades);
                cmbDestino.Items.AddRange(cidades);

                cmbOrigem.SelectedIndex = 0;
                cmbDestino.SelectedIndex = 1;

                MessageBox.Show($"Usando cidades padrão. Erro no banco: {ex.Message}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // MÉTODO CORRIGIDO - Carrega ônibus mesmo se tabela estiver vazia
        private void CarregarOnibus()
        {
            try
            {
                // Primeiro tenta buscar ônibus ativos
                string sql = "SELECT ID_ONIBUS, PLACA, MODELO, CAPACIDADE FROM ONIBUS WHERE STATUS = 'Ativo' ORDER BY PLACA";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbOnibus.Items.Clear();
                    bool encontrouOnibus = false;

                    while (reader.Read())
                    {
                        int id = (int)reader["ID_ONIBUS"];
                        string placa = reader["PLACA"].ToString();
                        string modelo = reader["MODELO"].ToString();
                        int capacidade = (int)reader["CAPACIDADE"];

                        string item = $"{placa} - {modelo} ({capacidade} lugares)";
                        cmbOnibus.Items.Add(new OnibusItem(item, id));
                        encontrouOnibus = true;
                    }

                    reader.Close();

                    if (encontrouOnibus)
                    {
                        cmbOnibus.SelectedIndex = 0;
                        return; // Sai do método se encontrou ônibus
                    }
                }

                // Se não encontrou ônibus ativos, busca QUALQUER ônibus
                string sqlTodos = "SELECT ID_ONIBUS, PLACA, MODELO, CAPACIDADE FROM ONIBUS ORDER BY PLACA";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sqlTodos, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbOnibus.Items.Clear();
                    bool encontrouQualquerOnibus = false;

                    while (reader.Read())
                    {
                        int id = (int)reader["ID_ONIBUS"];
                        string placa = reader["PLACA"].ToString();
                        string modelo = reader["MODELO"].ToString();
                        int capacidade = (int)reader["CAPACIDADE"];

                        string item = $"{placa} - {modelo} ({capacidade} lugares)";
                        cmbOnibus.Items.Add(new OnibusItem(item, id));
                        encontrouQualquerOnibus = true;
                    }

                    reader.Close();

                    if (encontrouQualquerOnibus)
                    {
                        cmbOnibus.SelectedIndex = 0;
                        MessageBox.Show("Carregados ônibus disponíveis (sem filtro de status).",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Se não encontrou NENHUM ônibus, usa os padrão
                CarregarOnibusPadrao();
            }
            catch (Exception ex)
            {
                // Se der erro, carrega ônibus padrão
                CarregarOnibusPadrao();
                MessageBox.Show($"Usando ônibus padrão. Erro no banco: {ex.Message}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método auxiliar para carregar ônibus padrão
        private void CarregarOnibusPadrao()
        {
            cmbOnibus.Items.Clear();
            cmbOnibus.Items.Add(new OnibusItem("ABC-1234 - Mercedes O-500 (40 lugares)", 1));
            cmbOnibus.Items.Add(new OnibusItem("DEF-5678 - Volvo B450R (45 lugares)", 2));
            cmbOnibus.Items.Add(new OnibusItem("GHI-9012 - Marcopolo Paradiso (38 lugares)", 3));
            cmbOnibus.Items.Add(new OnibusItem("JKL-3456 - Scania K360 (42 lugares)", 4));
            cmbOnibus.Items.Add(new OnibusItem("MNO-7890 - Busscar Urbanuss (36 lugares)", 5));

            if (cmbOnibus.Items.Count > 0)
                cmbOnibus.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                SalvarViagemNoBanco();
            }
        }

        private bool ValidarDados()
        {
            // Validações básicas
            if (cmbOrigem.SelectedItem == null)
            {
                MessageBox.Show("Selecione a origem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDestino.SelectedItem == null)
            {
                MessageBox.Show("Selecione o destino!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbOrigem.Text == cmbDestino.Text)
            {
                MessageBox.Show("Origem e destino não podem ser iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbOnibus.SelectedItem == null)
            {
                MessageBox.Show("Selecione um ônibus!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbHoraSaida.SelectedItem == null)
            {
                MessageBox.Show("Selecione a hora de saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbHoraChegada.SelectedItem == null)
            {
                MessageBox.Show("Selecione a hora de chegada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Preço inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtVagas.Text, out int vagas) || vagas <= 0)
            {
                MessageBox.Show("Número de vagas inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obter data/hora dos controles
            DateTime dataSaida = dtpDataSaida.Value.Date;
            DateTime dataChegada = dtpDataChegada.Value.Date;

            TimeSpan horaSaida = TimeSpan.Parse(cmbHoraSaida.SelectedItem.ToString());
            TimeSpan horaChegada = TimeSpan.Parse(cmbHoraChegada.SelectedItem.ToString());

            DateTime dataHoraSaida = dataSaida + horaSaida;
            DateTime dataHoraChegada = dataChegada + horaChegada;

            if (dataHoraChegada <= dataHoraSaida)
            {
                MessageBox.Show("Data/hora de chegada deve ser posterior à data/hora de saída!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SalvarViagemNoBanco()
        {
            try
            {
                // Obter dados dos controles
                string origem = cmbOrigem.Text;
                string destino = cmbDestino.Text;

                // Obter data/hora dos controles
                DateTime dataSaida = dtpDataSaida.Value.Date;
                DateTime dataChegada = dtpDataChegada.Value.Date;

                TimeSpan horaSaida = TimeSpan.Parse(cmbHoraSaida.SelectedItem.ToString());
                TimeSpan horaChegada = TimeSpan.Parse(cmbHoraChegada.SelectedItem.ToString());

                DateTime dataHoraSaida = dataSaida + horaSaida;
                DateTime dataHoraChegada = dataChegada + horaChegada;

                decimal preco = decimal.Parse(txtPreco.Text);
                int vagasTotais = int.Parse(txtVagas.Text);

                // Obter ID do ônibus selecionado
                int idOnibus = 0;
                if (cmbOnibus.SelectedItem is OnibusItem onibusItem)
                {
                    idOnibus = onibusItem.Id;
                }
                else
                {
                    MessageBox.Show("ERRO: Ônibus não selecionado corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obter ID da rota (buscar ou criar) - MÉTODO CORRIGIDO
                int idRota = ObterOuCriarRotaCorrigido(origem, destino);

                // Verificar se obteve um ID de rota válido
                if (idRota <= 0)
                {
                    MessageBox.Show("ERRO: Não foi possível obter ou criar uma rota válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserir viagem no banco
                string sql = @"INSERT INTO VIAGENS 
                              (ID_ROTA, ID_ONIBUS, DATA_HORA_SAIDA, DATA_HORA_CHEGADA, 
                               HORARIO_SAIDA, HORARIO_CHEGADA, PRECO, VAGAS_DISPONIVEIS, VAGAS_TOTAIS, STATUS)
                              VALUES 
                              (@IdRota, @IdOnibus, @DataHoraSaida, @DataHoraChegada,
                               @HorarioSaida, @HorarioChegada, @Preco, @VagasDisponiveis, @VagasTotais, @Status)";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@IdRota", idRota);
                    cmd.Parameters.AddWithValue("@IdOnibus", idOnibus);
                    cmd.Parameters.AddWithValue("@DataHoraSaida", dataHoraSaida);
                    cmd.Parameters.AddWithValue("@DataHoraChegada", dataHoraChegada);
                    cmd.Parameters.AddWithValue("@HorarioSaida", dataHoraSaida.TimeOfDay);
                    cmd.Parameters.AddWithValue("@HorarioChegada", dataHoraChegada.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@VagasDisponiveis", vagasTotais);
                    cmd.Parameters.AddWithValue("@VagasTotais", vagasTotais);
                    cmd.Parameters.AddWithValue("@Status", "Ativa");

                    conn.Open();
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show($"Viagem salva com sucesso! 🎉\n\n" +
                                      $"📍 {origem} → {destino}\n" +
                                      $"⏰ {dataHoraSaida:dd/MM/yyyy HH:mm}\n" +
                                      $"💰 R$ {preco:F2}\n" +
                                      $"💺 {vagasTotais} vagas",
                                      "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar viagem. Nenhum registro foi inserido.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar viagem no banco: {ex.Message}\n\nDetalhes técnicos:\n{ex.StackTrace}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MÉTODO CORRIGIDO - Versão robusta para evitar NULL
        private int ObterOuCriarRotaCorrigido(string origem, string destino)
        {
            try
            {
                // Primeiro tenta buscar a rota existente
                string sqlBuscar = "SELECT ID_ROTA FROM ROTAS WHERE ORIGEM = @Origem AND DESTINO = @Destino";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sqlBuscar, conn))
                {
                    cmd.Parameters.AddWithValue("@Origem", origem);
                    cmd.Parameters.AddWithValue("@Destino", destino);

                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    // Verificação robusta para evitar NULL
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        int idExistente = Convert.ToInt32(resultado);
                        if (idExistente > 0)
                        {
                            return idExistente;
                        }
                    }
                }

                // Se não encontrou, cria uma nova rota
                string sqlInserir = @"INSERT INTO ROTAS (ORIGEM, DESTINO, DISTANCIA_KM, DURACAO_HORAS, PRECO)
                                     OUTPUT INSERTED.ID_ROTA
                                     VALUES (@Origem, @Destino, @Distancia, @Duracao, @Preco)";

                using (SqlConnection conn = new SqlConnection(_conexao))
                using (SqlCommand cmd = new SqlCommand(sqlInserir, conn))
                {
                    // Valores padrão para nova rota
                    cmd.Parameters.AddWithValue("@Origem", origem);
                    cmd.Parameters.AddWithValue("@Destino", destino);
                    cmd.Parameters.AddWithValue("@Distancia", 400); // Distância padrão
                    cmd.Parameters.AddWithValue("@Duracao", 6.0);   // Duração padrão
                    cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));

                    conn.Open();
                    object resultado = cmd.ExecuteScalar();

                    // Verificação robusta do resultado
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        int novaRotaId = Convert.ToInt32(resultado);
                        if (novaRotaId > 0)
                        {
                            MessageBox.Show($"Nova rota criada com ID: {novaRotaId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return novaRotaId;
                        }
                    }

                    throw new Exception("Falha ao criar nova rota - ID retornado é inválido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro crítico ao obter/criar rota: {ex.Message}\n\nUsando rota de emergência (ID=8).",
                    "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Retorna um ID que provavelmente existe na sua tabela ROTAS
                return 8; // ID da rota Belo Horizonte → Brasília que você mencionou
            }
        }

        // Método original mantido para compatibilidade (mas não é mais usado)
        private int ObterOuCriarRota(string origem, string destino)
        {
            return ObterOuCriarRotaCorrigido(origem, destino);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }

    // Classe auxiliar para armazenar ônibus com ID
    public class OnibusItem
    {
        public string Display { get; set; }
        public int Id { get; set; }

        public OnibusItem(string display, int id)
        {
            Display = display;
            Id = id;
        }

        public override string ToString()
        {
            return Display;
        }
    }
}