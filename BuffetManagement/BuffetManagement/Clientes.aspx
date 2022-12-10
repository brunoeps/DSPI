<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="BuffetManagement.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Clientes</h1>
        <p class="lead">Nome:</p>
        <asp:TextBox runat="server" ID="txtNomeCliente" CssClass="form-control" placeholder="Insira o nome do cliente"></asp:TextBox>
        <p class="lead">CPF:</p>
        <asp:TextBox runat="server" ID="txtCPFCliente" CssClass="form-control" placeholder="Insira o CPF do cliente"></asp:TextBox>
        <p class="lead">Telefone:</p>
        <asp:TextBox runat="server" ID="txtTelefoneCliente" CssClass="form-control" placeholder="Insira o telefone do cliente"></asp:TextBox>
        <button runat="server" id="btnCadastrarCliente">Cadastrar</button>
        <button runat="server" id="btnPesquisarCliente">Pesquisar</button>
    </div>
</asp:Content>
