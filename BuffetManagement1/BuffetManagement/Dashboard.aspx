<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BuffetManagement.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Dashboard</h1>
                <div class="col-lg-7 text-center">
                    <h4>Total de Clientes</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                        <asp:Label runat="server" ID="lblClientes" Text="0"></asp:Label>
                    </div>
                    <br />
                    <h4>Total de Pacotes</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                        <asp:Label runat="server" ID="lblPacotes" Text="0"></asp:Label>
                    </div>
                    <br />
                    <h4>Selecione a data do(s) lançamento(s)</h4>
                    <div class="progress-bar progress-bar-info" role="progressbar" style="width: 100%">
                    </div>

                    <asp:TextBox TextMode="Date" ID="data" runat="server" OnTextChanged="data_TextChanged" AutoPostBack="true"></asp:TextBox>

                    <br />
                    <asp:Label runat="server" ID="lblFinanceiro" Text="Valor: "></asp:Label>

                </div>
            </div>
        </div>
    </div>

</asp:Content>
