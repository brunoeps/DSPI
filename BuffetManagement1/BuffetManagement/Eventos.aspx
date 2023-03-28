<%@ Page Title="Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="BuffetManagement.Pedidos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <%--<div class="row justify-content-center">--%>
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Eventos</h1>
                <p class="lead">Cliente:</p>
                <asp:DropDownList runat="server" ID="ddlCliente" AutoPostBack="true" CssClass="form-control">
                    <%--<asp:ListItem Text="" Value="" />--%>
                </asp:DropDownList><br />
                <p class="lead">Pacote:</p>
                <asp:DropDownList runat="server" ID="ddlPacote" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlPacote_SelectedIndexChanged">
                    <%--<asp:ListItem Text="" Value="" />--%>
                </asp:DropDownList><br />
                <p class="lead">Quantidade:</p>
                <asp:TextBox runat="server" ID="txtQuantidade" CssClass="form-control" Text="0" OnTextChanged="txtQuantidade_TextChanged" AutoPostBack="true"></asp:TextBox>
                <br />
                <p class="lead">Valor:</p>
                <asp:TextBox runat="server" ID="txtValor" CssClass="form-control" Enabled="false" AutoPostBack="true"></asp:TextBox>
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
                    <asp:Button runat="server" ID="btnCadastraEvento" Text="Cadastrar" Style="margin-right: 40px" Enabled="false" class="button" OnClick="btnCadastraEvento_Click" />
                    <asp:Button runat="server" ID="btnPesquisaEvento" Text="Pesquisar" Style="margin-right: 40px" class="button" OnClick="btnPesquisaEvento_Click" />
                </div>
                <br />
                <br />
                <div class="row">
                    <asp:GridView runat="server" ID="grdEventos" Width="100%" AutoGenerateColumns="false"
                        CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                        OnRowCommand="grdEventos_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdEventos_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="Cliente.Nome" HeaderText="CLIENTE" />
                            <asp:BoundField DataField="Pacote.Nome" HeaderText="PACOTE" />
                            <asp:BoundField DataField="quantidade" HeaderText="QUANTIDADE" />
                            <asp:BoundField DataField="valor" HeaderText="VALOR" />
                            <asp:ButtonField ButtonType="Link" CommandName="editar" ControlStyle-CssClass="btn btn-warning" Text="Editar" />
                            <asp:ButtonField ButtonType="Link" CommandName="excluir" ControlStyle-CssClass="btn btn-danger" Text="Excluir" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
