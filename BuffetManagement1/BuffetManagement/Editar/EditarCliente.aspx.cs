using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuffetManagement.Editar
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string Id = Request.QueryString["Id"].ToString();
                var cliente = new Negócio.Cliente().Read("", "", "", Convert.ToInt32(Id));
                //txtNome.Text = cliente.

                // PRÓXIMA AULA INICIAR POR AQUI, E PELA CLASSE NEGÓCIO (READ) POIS VAMOS PRECISAR DE ID PARA RESOLVER O PROBLEMA DA EDIÇÃO!!!!!!!!
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo.Cliente EditaCliente = new Modelo.Cliente();
            EditaCliente.Nome = txtNome.Text;
            EditaCliente.Cpf = txtCPF.Text;
            EditaCliente.Telefone = txtTelefone.Text;
            EditaCliente.Id = Convert.ToInt32(Request.QueryString["Id"].ToString());

            Negócio.Cliente AcoesCliente = new Negócio.Cliente();
            AcoesCliente.Update(EditaCliente);
        }
    }
}

//if(IsPostBack == false)
//            {
//                string Id = Request.QueryString["Id"].ToString();
//var candidato = new Negocio.Candidato().Read("", Convert.ToInt32(Id));
//TxtNome.Text = candidato.Nome;
//            }