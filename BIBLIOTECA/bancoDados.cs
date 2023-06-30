using System;
using System.Collections.Generic;
using System.Data.SqlClient; //biblioteca banco
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    class bancoDados
    {

        SqlConnection con;
        public SqlConnection abrir_conexao()
        {
            con = new SqlConnection();

            con.ConnectionString = @"Data Source = (LocalDB)\v11.0;AttachDbFilename= C:\Users\francisco.asousa4\Desktop\BIBLIOTECA\BIBLIOTECA\BIBLIOTECA\Database1.mdf;Integrated Security = True";
                                                   
            con.Open();
            return con;
        }

        public void fechar_conexao(SqlConnection con)
        {
            con.Close();
        }


    }
}
