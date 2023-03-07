using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastraPacote_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Pacotes NovoPacote = new Modelo.Pacotes();
                NovoPacote.Nome = txtNomePacote.Text;
                NovoPacote.PrecoPP = float.Parse(txtPrecoPorPessoa.Text);


                Negócio.Pacotes AcoesPacotes = new Negócio.Pacotes();
                AcoesPacotes.Create(NovoPacote);
            }
            catch (Exception er)
            {
                SiteMaster.ExibirAlert(this, "Erro no cadastro!");

            }
        }

        protected void btnPesquisaPacote_Click(object sender, EventArgs e)
        {
            var pacotes = new Negócio.Pacotes().Read(txtNomePacote.Text, txtPrecoPorPessoa.Text, 0);
            Session["dados"] = pacotes;
            grdPacotes.DataSource = pacotes;
            grdPacotes.DataBind();
        }

        protected void grdPacotes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var pacotes = (List<Modelo.Pacotes>)Session["dados"];

            if (e.CommandName == "excluir")
            {
                if (new Negócio.Pacotes().Delete(pacotes[index].Id))
                    SiteMaster.ExibirAlert(this, "Pacote excluído com sucesso!");
                else
                    SiteMaster.ExibirAlert(this, "O pacote não pode ser excluído porque ele está sendo usado!");
                btnPesquisaPacote_Click(null, null);
            }

            if (e.CommandName == "editar")
            {
                Response.Redirect("Editar/EditarPacote.aspx?id=" + pacotes[index].Id);
            }
        }

        protected void grdPacotes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            var pacotes = (List<Modelo.Pacotes>)Session["dados"];
            grdPacotes.PageIndex = e.NewPageIndex;
            grdPacotes.DataSource = pacotes;
            grdPacotes.DataBind();
        }
    }
}