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
    public partial class consultaLeitor : Form
    {
        public consultaLeitor()
        {
            InitializeComponent();
        }

        private void texNome_TextChanged(object sender, EventArgs e)
        {
            bancoDados banco = new bancoDados();

            SqlConnection con;
            con = banco.abrir_conexao();

            String strNome = txtNome.Text;

            string selecionar = @"SELECT nome, Id_leitor, endereco, num, cpf, fone FROM Leitor where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dataGridView.DataSource = tabela;
            con.Close();

        }
    }
}
