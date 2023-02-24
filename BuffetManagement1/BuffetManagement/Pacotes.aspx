<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pacotes.aspx.cs" Inherits="BuffetManagement.Contact" %>

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

        <h1>Pacotes</h1>
        <p class="lead">Nome:</p>
        <asp:TextBox runat="server" ID="txtNomePacote" CssClass="form-control" placeholder="Insira o nome do pacote"></asp:TextBox>
        <p class="lead">Preço por Pessoa:</p>
        <asp:TextBox runat="server" ID="txtPrecoPorPessoa" CssClass="form-control" placeholder="insira o valor do por pessoa do pacote"></asp:TextBox>
        <asp:TextBox runat="server" ID="txtQuantidadeProduto" CssClass="form-control" placeholder="Insira a quantidade de produtos"></asp:TextBox>
        <asp:Button runat="server" ID="btnCadastraProduto" Text="Cadastrar" class="button" OnClick="btnCadastraProduto_Click" />
        <asp:Button runat="server" ID="btnPesquisaProduto" Text="Pesquisar" class="button" OnClick="btnPesquisaProduto_Click" />

    </div>
</asp:Content>