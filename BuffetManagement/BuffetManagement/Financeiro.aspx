<%@ Page Title="Financeiro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="BuffetManagement.Financeiro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h1>Clientes</h1>
        <p class="lead">Fornecedor:</p>
        <asp:TextBox runat="server" ID="txtFornecedorFinanceiro" CssClass="form-control" placeholder="Insira o fornecedor"></asp:TextBox>
        <p class="lead">Valor:</p>
        <asp:TextBox runat="server" ID="txtCPFCliente" CssClass="form-control" placeholder="Insira o valor da transação"></asp:TextBox>
        <p class="lead">Vencimento:</p>
        <asp:TextBox runat="server" ID="txtTelefoneCliente" CssClass="form-control" placeholder="Insira o prazo da transação"></asp:TextBox>
        <button runat="server" id="btnCadastrarCliente">Adicionar saída</button>

    </div>
</asp:Content>
