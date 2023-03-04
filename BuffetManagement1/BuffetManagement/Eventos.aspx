<%@ Page Title="Pedidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eventos.aspx.cs" Inherits="BuffetManagement.Pedidos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Eventos</h1>
                <p class="lead">Cliente:</p>
                <asp:DropDownList runat="server" ID="ddlCliente" AutoPostBack="true" CssClass="form-control" ></asp:DropDownList><br />
                <p class="lead">Pacote:</p>
                <asp:DropDownList runat="server" ID="ddlPacote" AutoPostBack="true" CssClass="form-control" ></asp:DropDownList><br />

                <p class="lead">Quantidade:</p>
                <asp:Button ID="btnSubtrair" runat="server" Text="-1" OnClick="btnSubtrair_Click" />
                <asp:TextBox runat="server" ID="txtQuantidade" Text="0" OnTextChanged="txtQuantidade_TextChanged" AutoPostBack="true"></asp:TextBox>
                <asp:HiddenField ID="hdnContador" runat="server" Value=" 0 " />
                <asp:Button ID="btnAdicionar" runat="server" Text="+1" OnClick="btnAdicionar_Click" />
                <br />
                <br />
                <br />

                <p class="lead">Valor:</p>
                <asp:Label runat="server" ID="lblValor"></asp:Label>


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
                    <asp:Button runat="server" ID="btnCadastraEvento" Text="Cadastrar" Style="margin-right: 40px" class="button" OnClick="btnCadastraEvento_Click" />
                    <asp:Button runat="server" ID="btnPesquisaEvento" Text="Pesquisar" Style="margin-right: 40px" class="button" OnClick="btnPesquisaEvento_Click" />
                </div>
                <br />
                <br />
                <%--<div class="row">
            <asp:GridView runat="server" ID="grdEventos" Width="100%" AutoGenerateColumns="false"
                CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                OnRowCommand="grdEventos_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdEventos_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="nome" HeaderText="CLIENTE" />
                    <asp:BoundField DataField="cpf" HeaderText="PACOTE" />
                    <asp:BoundField DataField="telefone" HeaderText="QUANTIDADE" />
                    <asp:ButtonField ButtonType="Link" CommandName="editar" ControlStyle-CssClass="btn btn-warning" Text="Editar" />
                    <asp:ButtonField ButtonType="Link" CommandName="excluir" ControlStyle-CssClass="btn btn-danger" Text="Excluir" />
                </Columns>
            </asp:GridView>--%>
            </div>
        </div>
    </div>
</asp:Content>
