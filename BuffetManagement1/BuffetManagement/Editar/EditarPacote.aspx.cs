using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySqlConnector;

namespace BuffetManagement.Editar
{
    public partial class EditarPacote : System.Web.UI.Page
    {
        private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var pacote = new Negócio.Pacotes().Read("", "", Convert.ToInt32(Id));
            }
            //connection = new MySqlConnection(SiteMaster.ConnectionString);
            //if (IsPostBack == false)
            //{
            //    if (!IsPostBack)
            //    {
            //        var id = Request.QueryString["id"].ToString();

            //        connection.Open();
            //        var comando = new MySqlCommand($@"SELECT `nome`, `preco`, `id` FROM `pacotes` WHERE `id`= " + Convert.ToInt32(id), connection);
            //        using (var reader = comando.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                txtNomePacote.Text = reader.GetString("nome");
            //                txtPrecoPorPessoa.Text = reader.GetString("preco");
            //            }
            //        }
            //        connection.Close();
            //    }
            //}
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Pacotes EditaPacote = new Modelo.Pacotes();
            EditaPacote.Nome = txtNomePacote.Text;
            EditaPacote.PrecoPP = float.Parse(txtPrecoPorPessoa.Text);
            EditaPacote.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());

            Negócio.Pacotes Acoespacote = new Negócio.Pacotes();
            Acoespacote.Update(EditaPacote);
        }
    }
}