<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BuffetManagement.Dashboard" %>

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
                    <br />
                    <br />

                    <input type="date" id="dateInput" name="dateInput" runat="server" />
                    <asp:Button ID="btnSubmit" runat="server" Text="Enviar" OnClick="btnSubmit_Click" />
                    <br />
                    <asp:Label runat="server" ID="lblFinanceiro" Text="0"></asp:Label>

                </div>
            </div>
        </div>
    </div>
    >





</asp:Content>
