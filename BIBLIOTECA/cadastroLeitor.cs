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

namespace BIBLIOTECA
{
    public partial class cadastroLeitor : Form
    {
        public cadastroLeitor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastroLeitor_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            

            String strNome = txtNome.Text;
            String strEndereco = txtEnd.Text;
            int intNumero = Convert.ToInt32(txtNum.Text);
            String strCPF = txtCpf.Text;
            String strTelefoe = txtFone.Text;


            bancoDados banco = new bancoDados();
            banco = new bancoDados();

            System.Data.SqlClient.SqlConnection con;

            con = banco.abrir_conexao();


            string inserir = @"insert into Leitor (nome, endereco, num, cpf, fone) values ('" + strNome + "','" + strEndereco + "','" + intNumero + "','" + strCPF + "','" + strTelefoe + "')";


            SqlCommand _cmd = new SqlCommand(inserir, con);

            // executa o comando

            _cmd.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
            //Exibe Mensagem!!

            MessageBox.Show("LEITOR CADASTRADO COM SUCESSO!");
        }
           


        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEnd.Clear();
            txtNum.Clear();
            txtCpf.Clear();
            txtFone.Clear();
        }

        private void lIvroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
