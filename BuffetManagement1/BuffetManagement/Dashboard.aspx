<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BuffetManagement.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-6">
                <h1>Dashboard</h1>
                <div class="col-sm-7 text-center">
                    <h4>Total de Clientes</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                        <asp:Label runat="server" ID="lblClientes" Text="0"></asp:Label>
                    </div>
                    <br />
                    <br />
                    <h4>Total de Pacotes</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                        <asp:Label runat="server" ID="lblPacotes" Text="0"></asp:Label>
                    </div>
                    <br />
                    <br />

                    <h4>Total de Eventos</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                        <asp:Label runat="server" ID="lblEventos" Text="0"></asp:Label>
                    </div>
                    <br />
                    <br />

                    <h4>Data do(s) lançamento(s)</h4>
                                  
                    <asp:TextBox TextMode="Date" ID="data" runat="server" OnTextChanged="data_TextChanged" AutoPostBack="true"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label runat="server" ID="lblFinanceiro" class="h4" Text="Valor: "></asp:Label>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
