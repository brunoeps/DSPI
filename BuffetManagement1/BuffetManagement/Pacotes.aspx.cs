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

        protected void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo.Pacotes NovoPacote = new Modelo.Pacotes();
                NovoPacote.Nome = txtNomePacote.Text;
                NovoPacote.PrecoPP = txtPrecoPorPessoa.Text;
                

                Negócio.Cliente AcoesCliente = new Negócio.Cliente();
                AcoesCliente.Create(NovoCliente);
            }
            catch (Exception er)
            {
                SiteMaster.ExibirAlert(this, "Erro no cadastro!");
                Log.Error("Erro! " + er.Message);
            }
        }

        protected void btnPesquisaProduto_Click(object sender, EventArgs e)
        {

        }
    }
}