<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarPacote.aspx.cs" Inherits="BuffetManagement.Editar.EditarPacote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row text-center">
            <b>Edição de Pacotes</b>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-2">Nome:</div>
            <div class="col-sm-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNomePacote"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-2">Preço:</div>
            <div class="col-sm-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtPrecoPorPessoa"></asp:TextBox>
            </div>
            <br />
            <div class="row text-center">
                <asp:Button runat="server" ID="btnEditar" CssClass="btn btn-success" OnClick="btnEditar_Click" Text="Editar Pacote" />
            </div>
        </div>
    </div>

</asp:Content>
