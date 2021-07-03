using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//usando o mySQL
using MySql.Data.MySqlClient;

namespace ControlaGastos
{
    public partial class FrmUsuario : Form
    {
        //criando uma conexão
        private MySqlConnection mConn = new MySqlConnection(
            "Persist Security info = False;" + //evitar que o comando não fique pedindo a senha a cada conexão
            "server = localhost;" + //onde é o banco de dados
            "database = contas;" + // nome do banco de dados
            "uid = root;" + // nome do usuario
            "pwd ="  // senha do usuario
            );
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja sair da Aplicação?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtUsuario.Text != "" && txtSenha.Text != "")
            {
                try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    //Insert no BD
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    // comando sql para inserir uma informação no banco
                    comandoSQL.CommandText = "INSERT INTO login " +
                        "(Nome, user, senha)" +
                        " VALUES " +
                        "('" + txtNome.Text + "','" + txtUsuario.Text + "','" + txtSenha.Text +
                         "')";

                    comandoSQL.ExecuteNonQuery();
                    mConn.Close();

                    MessageBox.Show("Os dados foram gravados com sucesso!");

                    //limpa os campos
                    txtNome.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    
                   
                    //posiciona o cursor no primeiro campos de cadastro
                    txtNome.Focus();
                    //esconde a tela
                    this.TopMost = false;
                    this.Hide();
                    frmLogin frmlog = new frmLogin();
                    frmlog.ShowDialog();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro na conexão com o Banco de Dados. \n\n\n" + erro.ToString(),
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
           }
          
            }
            else
            {
                MessageBox.Show(
                    "Prencha todos os campos!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

       

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
