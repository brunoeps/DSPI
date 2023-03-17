using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ddlAsunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            Negócio.Contato contato = new Negócio.Contato();
            string mensagem = $@"Nome: {txtNomeRemetente.Text}<br>
                              Assunto: {(ddlAsunto.SelectedItem.Text)}<br>
                              Mensagem: {txtAreaMensagem.Value}<br>
                              E-mail de contato: {txtEmailContato.Text}";                
           
           contato.Envio(ddlAsunto.SelectedItem.Text,mensagem);
        
        }
    }
}