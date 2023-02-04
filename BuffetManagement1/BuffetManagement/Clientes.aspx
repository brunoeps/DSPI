<%@ Page Title="Clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="BuffetManagement.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Clientes</h1>
                <br />
                <br />
                <p class="lead">Nome:</p>
                <asp:TextBox runat="server" ID="txtNomeCliente" CssClass="form-control" placeholder="Insira o nome do cliente"></asp:TextBox><br />
                <p class="lead">CPF:</p>
                <asp:TextBox runat="server" ID="txtCPFCliente" CssClass="form-control" placeholder="Insira o CPF do cliente"></asp:TextBox><br />
                <p class="lead">Telefone:</p>
                <asp:TextBox runat="server" ID="txtTelefoneCliente" CssClass="form-control" placeholder="Insira o telefone do cliente"></asp:TextBox><br />
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
                    <asp:Button runat="server" ID="btnCadastraCliente" Text="Cadastrar"  style="margin-right:40px" class="button" OnClick="btnCadastraCliente_Click" />
                    <asp:Button runat="server" ID="btnPesquisaCliente" Text="Pesquisar" style="margin-right:40px" class="button" OnClick="btnPesquisaCliente_Click" />
                </div>
                <br />
                <br />
                <div class="row">
                    <asp:GridView runat="server" ID="grdClientes" Width="100%" AutoGenerateColumns="false"
                        CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                        OnRowCommand="grdClientes_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdClientes_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="nome" HeaderText="NOME" />
                            <asp:BoundField DataField="cpf" HeaderText="CPF" />
                            <asp:BoundField DataField="telefone" HeaderText="TELEFONE" />
                            <asp:ButtonField ButtonType="Link" CommandName="editar" ControlStyle-CssClass="btn btn-warning" Text="Editar" />
                            <asp:ButtonField ButtonType="Link" CommandName="excluir" ControlStyle-CssClass="btn btn-danger" Text="Excluir" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
