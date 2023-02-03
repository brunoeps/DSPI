<%@ Page Title="Financeiro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="BuffetManagement.Financeiro" %>

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

        <h1>Financeiro</h1>
        <p class="lead">Fornecedor:</p>
        <asp:TextBox runat="server" ID="txtFornecedorFinanceiro" CssClass="form-control" placeholder="Insira o fornecedor"></asp:TextBox>
        <p class="lead">Valor:</p>
        <asp:TextBox runat="server" ID="txtCPFCliente" CssClass="form-control" placeholder="Insira o valor da transação"></asp:TextBox>
        <p class="lead">Vencimento:</p>
        <asp:TextBox runat="server" ID="txtTelefoneCliente" CssClass="form-control" placeholder="Insira o prazo da transação"></asp:TextBox>
        <asp:Button runat="server" ID="btnGasto" Text="Adicionar gasto" CssClass="button" OnClick="btnGasto_Click" />

    </div>
</asp:Content>
