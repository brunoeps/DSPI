<%@ Page Title="Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="BuffetManagement.Contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Contato</h1>
                <p class="lead">Nome:</p>
                <asp:TextBox runat="server" ID="txtNomeRemetente" CssClass="form-control"></asp:TextBox><br />
                <p class="lead">Assunto:</p>
                <asp:DropDownList runat="server" ID="ddlAssunto" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlAssunto_SelectedIndexChanged">
                <asp:ListItem Text="" Value="1"/>
                <asp:ListItem Text="Reclamação" Value="2" />
                <asp:ListItem Text="Elogio" Value="3" />
                <asp:ListItem Text="Sugestão" Value="4" />
                <asp:ListItem Text="Mal funcionamento" Value="5" />

                </asp:DropDownList><br />
                <p class="lead">Mensagem:</p>
                <textarea runat="server" id="txtAreaMensagem" rows="5" cols="50" style="height: 200px; width: 400px;" class="form-control"></textarea><br />
                <p class="lead">E-mail:</p>
                <asp:TextBox runat="server" ID="txtEmailContato" CssClass="form-control" placeholder="Digite seu e-mail de contato"></asp:TextBox>

                <style>
                    .button {
                        background-color: Highlight;
                        border: none;
                        color: white;
                        padding: 10px;
                        text-align: center;
                        text-decoration: none;
                        display: inline-block;
                        font-size: 16px;
                        margin: 2px 2px;
                        cursor: pointer;
                        border-radius: 10%;
                    }
                </style>

                <div style="display: flex; justify-content: center; align-items: center;">
                    <br />
                    <asp:Button runat="server" id="btnEnviar" Text="Enviar" Style="margin-right: 40px" class="button" OnClick="btnEnviar_Click" />
</div>
                </div>
        </div>
</asp:Content>
