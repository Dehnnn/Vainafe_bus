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
//    public partial class GerenciarPassagens : Form
//    {
//        public GerenciarPassagens()
//        {
//            InitializeComponent();
//        }

//        private void dataGridViewPassagens_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class GerenciarPassagens : Form
    {
        private string _conexao =
            "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";

        public GerenciarPassagens()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            CarregarPassagensUltraSimples(); // SÓ ISSO, sem testes!
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Gerenciar Passagens";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewPassagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPassagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPassagens.MultiSelect = false;
            dataGridViewPassagens.ReadOnly = true;
            dataGridViewPassagens.AllowUserToAddRows = false;
            dataGridViewPassagens.BackgroundColor = Color.White;
            dataGridViewPassagens.RowHeadersVisible = false;

            dataGridViewPassagens.DefaultCellStyle.SelectionBackColor = Color.FromArgb(102, 126, 234);
            dataGridViewPassagens.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewPassagens.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        }

        // ----------------------------------------------------------------------
        //              CARREGAR PASSAGENS - VERSÃO LIMPA
        // ----------------------------------------------------------------------
        private void CarregarPassagensUltraSimples()
        {
            // Query APENAS com colunas que FUNCIONAM
            string sql = @"
                SELECT 
                    V.ID_VENDA AS 'ID',
                    U.NOME AS 'Passageiro',
                    V.POLTRONA AS 'Assento',
                    V.PRECO AS 'Preço',
                    CONVERT(VARCHAR, V.DATA_VENDA, 103) AS 'Data Compra'
                FROM VENDA V
                INNER JOIN USUARIOS U ON U.ID_USUARIO = V.ID_USUARIOS
                ORDER BY V.DATA_VENDA DESC";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewPassagens.DataSource = dt;

                    if (dataGridViewPassagens.Columns.Contains("Preço"))
                        dataGridViewPassagens.Columns["Preço"].DefaultCellStyle.Format = "C2";

                    this.Text = $"Gerenciar Passagens - {dt.Rows.Count} registradas";
                }
                catch (Exception ex)
                {
                    // Se der erro, tenta carregar só VENDA
                    CarregarSoVenda();
                }
            }
        }

        // ----------------------------------------------------------------------
        //              MODO EMERGÊNCIA: SÓ VENDA
        // ----------------------------------------------------------------------
        private void CarregarSoVenda()
        {
            string sql = @"
                SELECT 
                    ID_VENDA AS 'ID',
                    POLTRONA AS 'Assento',
                    PRECO AS 'Preço',
                    CONVERT(VARCHAR, DATA_VENDA, 103) AS 'Data Compra',
                    ID_USUARIOS AS 'ID Usuário'
                FROM VENDA 
                ORDER BY DATA_VENDA DESC";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewPassagens.DataSource = dt;

                    if (dataGridViewPassagens.Columns.Contains("Preço"))
                        dataGridViewPassagens.Columns["Preço"].DefaultCellStyle.Format = "C2";

                    this.Text = $"Gerenciar Passagens - {dt.Rows.Count} registradas";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ----------------------------------------------------------------------
        //                       EXCLUIR PASSAGEM
        // ----------------------------------------------------------------------
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPassagens.SelectedRows.Count > 0)
            {
                int idPassagem = Convert.ToInt32(dataGridViewPassagens.SelectedRows[0].Cells["ID"].Value);

                DialogResult r = MessageBox.Show(
                    $"Excluir passagem ID: {idPassagem}?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    ExcluirPassagem(idPassagem);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma passagem.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcluirPassagem(int id)
        {
            string sql = "DELETE FROM VENDA WHERE ID_VENDA = @Id";

            using (SqlConnection conn = new SqlConnection(_conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                try
                {
                    conn.Open();
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Passagem excluída com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarPassagensUltraSimples();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ----------------------------------------------------------------------
        //                       ATUALIZAR LISTA
        // ----------------------------------------------------------------------
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarPassagensUltraSimples();
        }

        // ----------------------------------------------------------------------
        //                       FECHAR TELA
        // ----------------------------------------------------------------------
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ----------------------------------------------------------------------
        //                         NOVA PASSAGEM
        // ----------------------------------------------------------------------
        private void btnNovaPassagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função 'Nova Passagem' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}