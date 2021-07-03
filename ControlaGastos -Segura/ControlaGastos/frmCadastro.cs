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
using System.Globalization;

namespace ControlaGastos
{
    public partial class frmCadastro : Form
    {
        //criando uma conexão
        private MySqlConnection mConn = new MySqlConnection(
            "Persist Security info = False;" + //evitar que o comando não fique pedindo a senha a cada conexão
            "server = localhost;" + //onde é o banco de dados
            "database = contas;" + // nome do banco de dados
            "uid = root;" + // nome do usuario
            "pwd ="  // senha do usuario
            );
        public frmCadastro()
        {
            InitializeComponent();
            txtValor.Text = string.Format("{0:#,##0.00}", 0d);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frmum = new Form1();
            frmum.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtConta.Text != "" && cmbTipo.Text != "" && txtValor.Text != "" && cmbPago.Text != "")
            {
                try
                {
                    mConn.Open();

                    if (mConn.State == ConnectionState.Open)
                    {
                        //Insert no BD
                        MySqlCommand comandoSQL = mConn.CreateCommand();

                        //tratamento de valor ponto para virgula
                        string valor =Convert.ToDecimal(txtValor.Text).ToString("0.00", CultureInfo.InvariantCulture).ToString();

                        // comando sql para inserir uma informação no banco
                        comandoSQL.CommandText = "INSERT INTO contas " +
                            "(compra, tipo, valor, pago)" +
                            " VALUES " +
                            "('" + txtConta.Text + "','" + cmbTipo.Text + "','" + valor + "','" + cmbPago.Text + "')";


                        comandoSQL.ExecuteNonQuery();
                        mConn.Close();

                        MessageBox.Show("Os dados foram gravados com sucesso!");
                        if (MessageBox.Show("Quer realizar outro cadastro?",
               "Confirmação",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
                        {
                            this.Close();
                        }

                        //limpa os campos
                        txtConta.Clear();
                        cmbTipo.Text = "Selecione...";
                        txtValor.Clear();
                        cmbPago.Text = "Selecione...";


                        //posiciona o cursor no primeiro campos de cadastro
                        txtConta.Focus();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

