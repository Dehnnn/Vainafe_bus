using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class GerenciarViagens : Form
    {
        private string _conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";

        public GerenciarViagens()
        {
            InitializeComponent();
            ConfigurarFormulario();
            ConfigurarDataGridView();
            CarregarViagens();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Gerenciar Viagens";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(102, 126, 234);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void CarregarViagens()
        {
            string sql = @"SELECT 
                            ID_VIAGEM AS 'ID',
                            PLACA AS 'Placa',
                            ORIGEM AS 'Origem',
                            DESTINO AS 'Destino',
                            CONVERT(VARCHAR, DATA_HORA_SAIDA, 103) AS 'Data',
                            CONVERT(VARCHAR, DATA_HORA_SAIDA, 108) AS 'Horário',
                            PRECO AS 'Preço',
                            CAPACIDADE AS 'Vagas'
                          FROM VW_VIAGENS_COMPLETA
                          ORDER BY DATA_HORA_SAIDA DESC";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("Preço"))
                    {
                        dataGridView1.Columns["Preço"].DefaultCellStyle.Format = "C2";
                    }

                    this.Text = $"Gerenciar Viagens - {dt.Rows.Count} viagens cadastradas";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar viagens: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string origem = dataGridView1.SelectedRows[0].Cells["Origem"].Value.ToString();
                string destino = dataGridView1.SelectedRows[0].Cells["Destino"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Deseja realmente excluir a viagem:\n\n{origem} → {destino}?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idViagem = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                    ExcluirViagem(idViagem);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma viagem para excluir.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcluirViagem(int idViagem)
        {
            string sql = "DELETE FROM VIAGENS WHERE ID_VIAGEM = @Id";

            using (SqlConnection conn = new SqlConnection(_conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", idViagem);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Viagem excluída com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarViagens();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarViagens();
            MessageBox.Show("Lista atualizada!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade 'Nova Viagem' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade 'Editar' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GerenciarViagens_Load(object sender, EventArgs e)
        {

        }
    }
}