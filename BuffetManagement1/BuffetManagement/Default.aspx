<%@ Page Title="Início" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuffetManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <div class="row">
            <div class="col-sm-4"></div>
            <div class="col-sm-4">
                <h1>Agenda</h1>
                <p class="lead">Confira todos os eventos:</p>
                <div class="row">
                    <asp:GridView runat="server" ID="grdEventos" Width="100%"  AutoGenerateColumns="false"
                        CssClass="table table-sm table-bordered table-condensed table-responsive-sm table-hover table-striped"
                        AllowPaging="true" PageSize="10" OnPageIndexChanging="grdEventos_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="Cliente.Nome" HeaderText="CLIENTE" />
                            <asp:BoundField DataField="Pacotes.Nome" HeaderText="PACOTE" />
                            <asp:BoundField DataField="quantidade" HeaderText="QUANTIDADE" />
                            <asp:BoundField DataField="valor" HeaderText="VALOR" />
                            <asp:BoundField DataField="data_evento" DataFormatString="{0:d}" HeaderText="DATA DO EVENTO" />
                            <asp:BoundField DataField="observacao" HeaderText="OBSERVAÇÃO" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
