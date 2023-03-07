using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement.Editar
{
    public partial class EditarPacote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var pacote = new Negócio.Pacotes().Read("", "", Convert.ToInt32(Id));
            }
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