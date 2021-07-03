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
//usando o excel
using Excel = Microsoft.Office.Interop.Excel;


namespace ControlaGastos
{



    public partial class Form1 : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
           "Persist Security info = False;" + //evitar que o comando
           "server = localhost;" + //onde é o banco de dados
           "database = contas;" + // nome do banco de dados
           "uid = root ;" + // nome do usuario
           "pwd = "  // senha do usuario
           );
        string valorID = null;
        
        
        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnAtualizar.PerformClick();
        }




        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {



        }
        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGastos_MouseClick(object sender, MouseEventArgs e)
        {
            int linhaSelecionada = dgvGastos.CurrentRow.Index;
            int colunaRetorno = 0;
            valorID = dgvGastos.Rows[linhaSelecionada].Cells[colunaRetorno].Value.ToString();
            //MessageBox.Show(valorId);

        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //abrir nova janela
            frmCadastro form = new frmCadastro();
            form.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();  //abrir uma conexão



                if (mConn.State == ConnectionState.Open)
                {
                    //limpara o DataGridView antes de atualizar os dados da tabela. 

                    dgvGastos.Rows.Clear();
                    //adicionando as colunas do DatagridView
                    dgvGastos.ColumnCount = 5;
                    dgvGastos.Columns[0].Width = 40;
                    dgvGastos.Columns[0].Name = "#";

                    dgvGastos.Columns[1].Width = 200;
                    dgvGastos.Columns[1].Name = "compra";

                    dgvGastos.Columns[2].Width = 100;
                    dgvGastos.Columns[2].Name = "tipo";

                    dgvGastos.Columns[3].Width = 100;
                    dgvGastos.Columns[3].Name = "valor";

                    dgvGastos.Columns[4].Width = 90;
                    dgvGastos.Columns[4].Name = "pago";

                    //Buscar os dados na tabela
                    //Criar uma variavel que terá o comando SQL. 
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    //comandoSQL.CommandText = "SELECT * FROM clientes";> Pega todas as informações do banco.
                    comandoSQL.CommandText = "SELECT  idContas, compra, tipo, valor, pago	FROM contas";
                    //definir a conexão com o banco



                    //Criar uma variavel que ira receber todos os dados selecionados
                    MySqlDataReader dadosClientes = comandoSQL.ExecuteReader();

                    string[] linha;
                    while (dadosClientes.Read())
                    {
                        linha = new string[]
                        {
                            dadosClientes["idContas"].ToString(),
                            dadosClientes["compra"].ToString(),
                            dadosClientes["tipo"].ToString(),
                            dadosClientes["valor"].ToString(),
                             dadosClientes["pago"].ToString(),
                        };
                        dgvGastos.Rows.Add(linha);

                    }

                }
                mConn.Close();

            }
            catch (Exception Erro)
            {

                MessageBox.Show(
                    "Erro na conexão do banco de Dados.\n\n\n" +
                    Erro.Message.ToString()
                    );
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (valorID != null)
            {
                //abrir nova janela
                frmEdita formEdita = new frmEdita(valorID);
                formEdita.ShowDialog();
                //atualiza o datagridviewe
                btnAtualizar.PerformClick();
                //variavel valorID volta a valer null
                valorID = null;
            }
            else
            {
                MessageBox.Show("Selecione um registro para alteração",
                "Informação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);


            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo SaveFileDialog


            Excel.Application App; // Aplicação Excel
            Excel.Workbook WorkBook; // Pasta
            Excel.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            // passa as celulas do DataGridView para a Pasta do Excel
            for (i = 0; i <= dgvGastos.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvGastos.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvGastos[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            // define algumas propriedades da caixa salvar
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            // salva o arquivo
            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

            MessageBox.Show("Exportado com sucesso!");
        }



        private void tmtPagar_Tick(object sender, EventArgs e)
        {
            lblPagar.Text = string.Format("{0:#,##0.00}", 0d);
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)

                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();
                    comandoSQL.CommandText = "SELECT SUM(valor) as valor FROM contas WHERE pago = 'Não'";
                    comandoSQL.Connection = mConn;
                    //definir a conexão com o banco



                    string contador = (comandoSQL.ExecuteScalar().ToString());
                    
                   
                    MySqlDataReader dadosClientes = comandoSQL.ExecuteReader();

                    // decimal resultado;

                    dadosClientes.Read();
                    if (contador != "")
                    {
                        //resultado = Convert.ToDecimal(dadosClientes["valor"].ToString());
                        lblPagar.Text = Convert.ToDecimal(dadosClientes["valor"].ToString()).ToString("C");
                    }
                    else
                    {
                        lblPagar.Text = "00,00";
                    }
                    


                    mConn.Close();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão com o banco de dados! \n\n\n" + erro.ToString());
            }
        }

        private void dgvGastos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (valorID != null)
            {
                Frmexcluir frmExc = new Frmexcluir(valorID);
                frmExc.ShowDialog();
                btnAtualizar.PerformClick();
                valorID = null;
            }
            else
            {
                MessageBox.Show(
                    "Clique em um registro para exclusão.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void tmtPago_Tick(object sender, EventArgs e)
        {
            lblPago.Text = string.Format("{0:#,##0.00}", 0d);
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)

                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();
                    comandoSQL.CommandText = "SELECT SUM(valor) as valor FROM contas WHERE pago = 'Sim'";
                    comandoSQL.Connection = mConn;
                    //definir a conexão com o banco



                    string contador = (comandoSQL.ExecuteScalar().ToString());

                    MySqlDataReader dadosClientes = comandoSQL.ExecuteReader();

                    // decimal resultado;

                    dadosClientes.Read();
                    if (contador != "")
                    {
                        //resultado = Convert.ToDecimal(dadosClientes["valor"].ToString());
                        lblPago.Text = Convert.ToDecimal(dadosClientes["valor"].ToString()).ToString("C");
                       
                        

                    }
                    else
                    {
                        
                        lblPago.Text = "00,00";
                    }


                    mConn.Close();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão com o banco de dados! \n\n\n" + erro.ToString());
            }
        }

                    
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (valorID != null)
            {
                Frmexcluir frmExc = new Frmexcluir(valorID);
                frmExc.ShowDialog();
                btnAtualizar.PerformClick();
                valorID = null;
            }
            else
            {
                MessageBox.Show(
                    "Clique em um registro para exclusão.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void lblPago_Click(object sender, EventArgs e)
        {

        }
    }
}



        
    
