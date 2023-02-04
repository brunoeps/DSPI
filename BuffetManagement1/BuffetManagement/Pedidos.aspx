<%@ Page Title="Pedidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="BuffetManagement.Pedidos" %>

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

        <h1>Pedidos</h1>
        <p class="lead">Cliente:</p>
        <asp:DropDownList runat="server" ID="ddlCliente" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        <p class="lead">Pacote:</p>
        <asp:DropDownList runat="server" ID="ddlPacote" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
        <asp:Button runat="server" ID="btnCadastraPedido" Text="Cadastrar" class="button" OnClick="btnCadastraPedido_Click" />
        <asp:Button runat="server" ID="btnPesquisaPedido" Text="Pesquisar" class="button" OnClick="btnPesquisaPedido_Click" />

    </div>
</asp:Content>
