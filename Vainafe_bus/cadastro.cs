using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Se este botão era para voltar/fechar, use:
            this.Close();

            // OU se era para abrir outra tela (por exemplo, login):
            // login telaLogin = new login();
            // this.Hide();
            // telaLogin.ShowDialog();
            // this.Show();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                MessageBox.Show("Por favor, preencha o nome.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCpf.Text))
            {
                MessageBox.Show("Por favor, preencha o CPF.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCpf.Focus();
                return;
            }

            // Validação do CPF
            if (!ValidarCPF(txbCpf.Text))
            {
                MessageBox.Show("CPF inválido! Por favor, verifique o número digitado.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCpf.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbTel.Text))
            {
                MessageBox.Show("Por favor, preencha o telefone.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTel.Focus();
                return;
            }

            // Validação do telefone
            if (!ValidarTelefone(txbTel.Text))
            {
                MessageBox.Show("Telefone inválido! Use o formato (XX) XXXXX-XXXX ou (XX) XXXX-XXXX", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTel.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbDataN.Text))
            {
                MessageBox.Show("Por favor, preencha a data de nascimento.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDataN.Focus();
                return;
            }

            // Validação de data
            DateTime dataNascimento;
            if (!DateTime.TryParse(txbDataN.Text, out dataNascimento))
            {
                MessageBox.Show("Data de nascimento inválida. Use o formato dd/MM/yyyy.", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDataN.Focus();
                return;
            }

            // Validar se a pessoa tem pelo menos 16 anos
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            if (idade < 16)
            {
                MessageBox.Show("É necessário ter pelo menos 16 anos para se cadastrar.", "Idade Mínima", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Por favor, preencha o e-mail.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return;
            }

            // Validação do e-mail
            if (!ValidarEmail(txbEmail.Text))
            {
                MessageBox.Show("E-mail inválido! Verifique o formato digitado.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbSenha.Text))
            {
                MessageBox.Show("Por favor, preencha a senha.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Focus();
                return;
            }

            // Validação de senha forte
            if (txbSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.", "Senha Fraca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbSenha.Focus();
                return;
            }

            // Coletar dados validados
            string Nome = txbNome.Text.Trim();
            string Cpf = FormatarCPF(txbCpf.Text.Trim()); // Formata o CPF antes de salvar
            string Telefone = txbTel.Text.Trim();
            string Email = txbEmail.Text.Trim();
            string Senha = CriptografarSenha(txbSenha.Text); // Criptografa a senha antes de salvar

            // ⚠️ TESTE ESTAS OPÇÕES NA ORDEM - descomente uma de cada vez:

            // OPÇÃO 1: LocalDB (Visual Studio) - TENTE ESTA PRIMEIRO
            string conexao = "Server=sqlexpress;;Database=cj3027759dpr2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO USUARIOS (NOME, CPF, TELEFONE, NASCIMENTO, EMAIL, SENHA, TIPO_USUARIO) " +
            "VALUES (@Nome, @Cpf, @Telefone, @Nascimento, @Email, @Senha, @Tipo)";

            using (SqlConnection conn = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);
                cmd.Parameters.AddWithValue("@Nascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                cmd.Parameters.AddWithValue("@Tipo", "cliente");
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar os campos após cadastro bem-sucedido
                    LimparCampos();
                }
                catch (SqlException ex)
                {
                    // Tratamento específico para erros de SQL
                    if (ex.Number == 2627 || ex.Number == 2601) // Violação de chave única
                    {
                        MessageBox.Show("Este CPF ou e-mail já está cadastrado no sistema.", "Cadastro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cpf = txbCpf.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Por favor, digite um CPF.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ValidarCPF(cpf))
            {
                MessageBox.Show("✅ CPF VÁLIDO!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ CPF INVÁLIDO!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCPF(string cpf)
        {
            // Remove caracteres não numéricos
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            // Verifica se tem 11 dígitos e se são todos números
            if (cpf.Length != 11 || !long.TryParse(cpf, out _))
                return false;

            // Verifica CPFs com todos os dígitos iguais
            string[] invalidos = {
                "00000000000", "11111111111", "22222222222", "33333333333",
                "44444444444", "55555555555", "66666666666", "77777777777",
                "88888888888", "99999999999"
            };

            if (Array.Exists(invalidos, e => e == cpf))
                return false;

            // Validação do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            // Validação do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
        }

        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Expressão regular para validar e-mail
                string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, padrao, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
                return false;

            // Remove caracteres não numéricos
            string telefoneLimpo = Regex.Replace(telefone, @"[^\d]", "");

            // Valida se tem 10 ou 11 dígitos (com DDD)
            return telefoneLimpo.Length == 10 || telefoneLimpo.Length == 11;
        }

        private string FormatarCPF(string cpf)
        {
            // Remove tudo que não é número
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            // Se tiver 11 dígitos, formata: 123.456.789-10
            if (cpf.Length == 11)
            {
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";
            }

            // Se já estiver formatado ou inválido, retorna como está
            return cpf;
        }

        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a senha em bytes
                byte[] bytes = Encoding.UTF8.GetBytes(senha);

                // Calcula o hash SHA256
                byte[] hash = sha256.ComputeHash(bytes);

                // Converte o hash para string hexadecimal
                StringBuilder resultado = new StringBuilder();
                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }

        private void LimparCampos()
        {
            txbNome.Clear();
            txbCpf.Clear();
            txbTel.Clear();
            txbDataN.Clear();
            txbEmail.Clear();
            txbSenha.Clear();
            txbNome.Focus();
        }

        private void txbDataN_TextChanged(object sender, EventArgs e)
        {
            // Pode adicionar máscara de data aqui se necessário
        }

        private void txbCpf_TextChanged(object sender, EventArgs e)
        {
            // Pode adicionar máscara de CPF aqui se necessário
        }
    }
}