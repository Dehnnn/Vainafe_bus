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
//    public partial class GerenciarUsuarios : Form
//    {
//        public GerenciarUsuarios()
//        {

//        }

//        private void GerenciarUsuarios_Load(object sender, EventArgs e)
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
    public partial class GerenciarUsuarios : Form
    {
        private string _conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";

        // Componentes do Designer (JÁ ADICIONADOS ACIMA)
        private DataGridView dataGridViewUsuarios;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnFechar;
        private Button btnNovoUsuario;
        private Panel panel1;
        private Label label1;
        private TextBox txtPesquisar;
        private Button btnPesquisar;

        public GerenciarUsuarios()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarUsuarios();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsuarios.MultiSelect = false;
            dataGridViewUsuarios.ReadOnly = true;
            dataGridViewUsuarios.AllowUserToAddRows = false;
            dataGridViewUsuarios.BackgroundColor = Color.White;
            dataGridViewUsuarios.RowHeadersVisible = false;

            dataGridViewUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(102, 126, 234);
            dataGridViewUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
        }

        private void CarregarUsuarios()
        {
            string sql = @"
                SELECT 
                    ID_USUARIO AS 'ID',
                    NOME AS 'Nome',
                    EMAIL AS 'E-mail',
                    TELEFONE AS 'Telefone',
                    CONVERT(VARCHAR, NASCIMENTO, 103) AS 'Nascimento',
                    TIPO_USUARIO AS 'Tipo'
                FROM USUARIOS 
                ORDER BY NOME";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewUsuarios.DataSource = dt;
                    this.Text = $"Gerenciar Usuários - {dt.Rows.Count} cadastrados";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar usuários: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                string nome = dataGridViewUsuarios.SelectedRows[0].Cells["Nome"].Value.ToString();
                string email = dataGridViewUsuarios.SelectedRows[0].Cells["E-mail"].Value.ToString();

                DialogResult r = MessageBox.Show(
                    $"Excluir usuário:\n\n{nome}\n{email}?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    int idUsuario = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["ID"].Value);
                    ExcluirUsuario(idUsuario);
                }
            }
            else
            {
                MessageBox.Show("Selecione um usuário.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExcluirUsuario(int id)
        {
            string sql = "DELETE FROM USUARIOS WHERE ID_USUARIO = @Id";

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
                        MessageBox.Show("Usuário excluído com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarUsuarios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
            MessageBox.Show("Lista atualizada!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade 'Novo Usuário' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(pesquisa) || pesquisa == "Pesquisar usuário...")
            {
                CarregarUsuarios();
                return;
            }

            string sql = @"
                SELECT 
                    ID_USUARIO AS 'ID',
                    NOME AS 'Nome',
                    EMAIL AS 'E-mail',
                    TELEFONE AS 'Telefone',
                    CONVERT(VARCHAR, NASCIMENTO, 103) AS 'Nascimento',
                    TIPO_USUARIO AS 'Tipo'
                FROM USUARIOS 
                WHERE NOME LIKE @Pesquisa OR EMAIL LIKE @Pesquisa
                ORDER BY NOME";

            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Pesquisa", $"%{pesquisa}%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewUsuarios.DataSource = dt;
                    this.Text = $"Gerenciar Usuários - {dt.Rows.Count} encontrados";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na pesquisa: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            // Foco no DataGridView
            dataGridViewUsuarios.Focus();
        }
    }
}