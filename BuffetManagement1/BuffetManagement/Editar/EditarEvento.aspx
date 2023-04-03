<%@ Page Title="Editar evento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarEvento.aspx.cs" Inherits="BuffetManagement.Editar.EditarEvento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Editar</h1>
                <p class="lead">Cliente:</p>
                <asp:DropDownList runat="server" ID="ddlCliente" AutoPostBack="true" CssClass="form-control"></asp:DropDownList><br />
                <p class="lead">Pacote:</p>
                <asp:DropDownList runat="server" ID="ddlPacote" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlPacote_SelectedIndexChanged"></asp:DropDownList><br />
                <p class="lead">Quantidade:</p>
                <asp:TextBox runat="server" ID="txtQuantidade" CssClass="form-control" Text="0" OnTextChanged="txtQuantidade_TextChanged" AutoPostBack="true"></asp:TextBox>
                <br />
                <p class="lead">Valor:</p>
                <asp:TextBox runat="server" ID="txtValor" CssClass="form-control" Enabled="false" AutoPostBack="true"></asp:TextBox>
                <br />
                <p class="lead">Data do evento:</p>
                <asp:TextBox runat="server" ID="txtDataEvento" CssClass="form-control" placeholder="Insira a data do evento"></asp:TextBox>
                <br />
                <p class="lead">Observação:</p>
                <textarea runat="server" id="txtObservacao" rows="5" cols="50" style="height: 200px; width: 400px;" class="form-control"></textarea><br />
                
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
                    <asp:Button runat="server" ID="btnEditar" Style="margin-right: 40px" class="button" OnClick="btnEditar_Click" Text="Editar evento" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
