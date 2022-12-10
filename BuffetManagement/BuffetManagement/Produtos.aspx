<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="BuffetManagement.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Produtos</h1>
        <p class="lead">Item:</p>
        <asp:TextBox runat="server" ID="txtItemProduto" CssClass="form-control" placeholder="Insira o nome do produto"></asp:TextBox>
        <p class="lead">Quantidade:</p>
        <asp:TextBox runat="server" ID="txtQuantidadeProduto" CssClass="form-control" placeholder="Insira a quantidade de produtos"></asp:TextBox>
        <button runat="server" id="btnCadastrarProduto">Cadastrar</button>
        <button runat="server" id="btnPesquisarProduto">Pesquisar</button>
    </div>
</asp:Content>
