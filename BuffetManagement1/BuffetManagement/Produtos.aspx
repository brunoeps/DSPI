<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="BuffetManagement.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <style>
            .button {
                background-color: lightblue;
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

        <h1>Produtos</h1>
        <p class="lead">Item:</p>
        <asp:TextBox runat="server" ID="txtItemProduto" CssClass="form-control" placeholder="Insira o nome do produto"></asp:TextBox>
        <p class="lead">Quantidade:</p>
        <asp:TextBox runat="server" ID="txtQuantidadeProduto" CssClass="form-control" placeholder="Insira a quantidade de produtos"></asp:TextBox>
        <asp:Button runat="server" ID="btnCadastraProduto" Text="Cadastrar" class="button" OnClick="btnCadastraProduto_Click" />
        <asp:Button runat="server" ID="btnPesquisaProduto" Text="Pesquisar" class="button" OnClick="btnPesquisaProduto_Click" />

    </div>
</asp:Content>