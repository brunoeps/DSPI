<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pacotes.aspx.cs" Inherits="BuffetManagement.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Pacotes</h1>
                <p class="lead">Nome:</p>
                <asp:TextBox runat="server" ID="txtNomePacote" CssClass="form-control" placeholder="Insira o nome do pacote"></asp:TextBox>
                <br />
                <p class="lead">Preço:</p>
                <asp:TextBox runat="server" ID="txtPrecoPorPessoa" CssClass="form-control" placeholder="Insira o valor do pacote (por pessoa)"></asp:TextBox>
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
                    <asp:Button runat="server" ID="btnCadastraPacote" Text="Cadastrar" Style="margin-right: 40px" class="button" OnClick="btnCadastraPacote_Click" />
                    <asp:Button runat="server" ID="btnPesquisaPacote" Text="Pesquisar" Style="margin-right: 40px" class="button" OnClick="btnPesquisaPacote_Click" />
                </div>

            <div class="row">
                <asp:GridView runat="server" ID="grdPacotes" Width="100%" AutoGenerateColumns="false"
                    CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                    OnRowCommand="grdPacotes_RowCommand" AllowPaging="true" PageSize="10" OnPageIndexChanging="grdPacotes_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="nome" HeaderText="NOME" />
                        <asp:BoundField DataField="precopp" HeaderText="PREÇO" />
                        <asp:ButtonField ButtonType="Link" CommandName="editar" ControlStyle-CssClass="btn btn-warning" Text="Editar" />
                        <asp:ButtonField ButtonType="Link" CommandName="excluir" ControlStyle-CssClass="btn btn-danger" Text="Excluir" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
