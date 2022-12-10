<%@ Page Title="Pedidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="BuffetManagement.Pedidos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Clientes</h1>
        <p class="lead">Cliente:</p>
        <asp:DropDownList runat="server" ID="ddlCliente" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        <p class="lead">Pacote:</p>
        <asp:DropDownList runat="server" ID="ddlPacote" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        <button runat="server" id="btnCadastrarCliente">Cadastrar</button>
        <button runat="server" id="btnPesquisarCliente">Pesquisar</button>
    </div>
</asp:Content>
