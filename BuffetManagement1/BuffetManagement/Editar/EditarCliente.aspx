<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="BuffetManagement.Editar.EditarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row text-center">
            <b>Edição de Clientes</b>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-2">Nome:</div>
            <div class="col-sm-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNome"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-2">CPF:</div>
            <div class="col-sm-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCPF"></asp:TextBox>
            </div>
            <div class="row">
                <div class="col-sm-2">Telefone:</div>
                <div class="col-sm-4">
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtTelefone"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row text-center">
                <asp:Button runat="server" ID="btnEditar" CssClass="btn btn-success" OnClick="btnEditar_Click" Text="Editar Cliente" />
            </div>
        </div>
    </div>
</asp:Content>
