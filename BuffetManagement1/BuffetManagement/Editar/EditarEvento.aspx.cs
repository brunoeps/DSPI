using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement.Editar
{
    public partial class EditarEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var evento = new Negócio.Evento().Read(0, 0, Convert.ToInt32(Id), "", 0);
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Evento EditaEvento = new Modelo.Evento();
            EditaEvento.IdCliente = Convert.ToInt32(ddlCliente.SelectedValue);
            EditaEvento.IdPacote = Convert.ToInt32(ddlPacote.SelectedValue);
            EditaEvento.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            EditaEvento.Valor = float.Parse(txtValor.Text);
            EditaEvento.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            Negócio.Evento AcoesEvento = new Negócio.Evento();
            AcoesEvento.Update(EditaEvento);
        }
    }
}