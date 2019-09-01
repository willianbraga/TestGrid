using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TesteAPP
{
    public partial class _Default : Page
    {

        string strConexao = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            strConexao = @"Data Source=WILL-NOTE\SQLexpress;Initial Catalog=Northwind;Integrated Security=True";
            //chama apenas na primeira carga da pagina
            if (!Page.IsPostBack)
            {
                preencheGrid();
            }
        }

        public void preencheGrid()
        {
            //cria uma conexão usando a string de conexão definida
            SqlConnection con = new SqlConnection(strConexao);
            //abre a conexão
            con.Open();
            //define um objeto Command que usa a stored procedure na conexão criada
            SqlCommand cmd = new SqlCommand("TESTE_SEL_CATEGORIA", con);
            //realizar um acesso somente-leitura no banco de dados
            SqlDataReader dr = cmd.ExecuteReader();
            //cria um datatable que conterá os dados
            DataTable dt = new DataTable();
            //carrega o datatable com os dados do datareader
            dt.Load(dr);
            //exibe os dados no GridView
            grv_teste.DataSource = dt;
            grv_teste.DataBind();
        }
        protected void EmployeeGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int CategoryID = Convert.ToInt32(grv_teste.DataKeys[e.RowIndex].Value.ToString());
            SqlConnection con = new SqlConnection(strConexao);
            con.Open();
            SqlCommand cmd = new SqlCommand("TESTE_DEL_CATEGORIA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryID ", CategoryID);
            cmd.ExecuteNonQuery();
            preencheGrid();
        }
    }
}