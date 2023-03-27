﻿<%@ Page Title="Editar cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="BuffetManagement.Editar.EditarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Editar</h1>
                <p class="lead">Nome:</p>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtNome"></asp:TextBox>
                <br />
                <p class="lead">CPF:</p>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtCPF"></asp:TextBox>
                <br />
                <p class="lead">Telefone:</p>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtTelefone"></asp:TextBox>
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
                    <asp:Button runat="server" ID="btnEditar" Style="margin-right: 40px" class="button" OnClick="btnEditar_Click" Text="Editar cliente" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
