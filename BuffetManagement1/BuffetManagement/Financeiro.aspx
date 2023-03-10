<%@ Page Title="Financeiro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="BuffetManagement.Financeiro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">

                <h1>Financeiro</h1>
                <p class="lead">Fornecedor:</p>
                <asp:TextBox runat="server" ID="txtFornecedor" CssClass="form-control" placeholder="Insira o nome do fornecedor"></asp:TextBox>
                <br />
                <p class="lead">Valor:</p>
                <asp:TextBox runat="server" ID="txtValor" CssClass="form-control" placeholder="Insira o valor da transação"></asp:TextBox>
                <br />
                <p class="lead">Vencimento:</p>
                <asp:TextBox runat="server" ID="txtDataVencimento" CssClass="form-control" placeholder="Insira a data de vencimento"></asp:TextBox>
                <br />
                <br />

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
                    <asp:Button runat="server" ID="btnCadastraGasto" Text="Cadastrar" Style="margin-right: 40px" CssClass="button" OnClick="btnCadastraGasto_Click" />
                    <asp:Button runat="server" ID="btnPesquisaGasto" Text="Pesquisar" Style="margin-right: 40px" CssClass="button" OnClick="btnPesquisaGasto_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
