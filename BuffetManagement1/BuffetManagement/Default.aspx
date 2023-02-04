<%@ Page Title="Início" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuffetManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <style>
            body {
                background-color: lightcyan
            }
        </style>
        <h1>Calendário de eventos</h1>
        <p class="lead">Consulte abaixo as datas dos eventos</p>
    </div>

    <style>
        /* Estilo para a data atual */
        .today {
            background-color: lightblue;
        }
    </style>

    <div style="margin-left: 475px">
    
        <table>

            <caption id="monthYear"></caption>
            <tr>
                <th>Dom</th>
                <th>Seg</th>
                <th>Ter</th>
                <th>Qua</th>
                <th>Qui</th>
                <th>Sex</th>
                <th>Sáb</th>
            </tr>
            <tr>
                <td>01</td>
                <td>02</td>
                <td>03</td>
                <td>04</td>
                <td>05</td>
                <td>06</td>
                <td>07</td>
            </tr>
            <tr>
                <td>08</td>
                <td>09</td>
                <td>10</td>
                <td>11</td>
                <td>12</td>
                <td>13</td>
                <td>14</td>
            </tr>
            <tr>
                <td>15</td>
                <td>16</td>
                <td>17</td>
                <td>18</td>
                <td>19</td>
                <td>20</td>
                <td>21</td>
            </tr>
            <tr>
                <td>22</td>
                <td>23</td>
                <td>24</td>
                <td>25</td>
                <td>26</td>
                <td>27</td>
                <td>28</td>
            </tr>
            <tr>
                <td>29</td>
                <td>30</td>
                <td>31</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <script>
            // Adiciona a classe "today" à célula com a data atual
            var today = new Date();
            var monthName = new Array();
            monthName[0] = "Janeiro";
            monthName[1] = "Fevereiro";
            monthName[2] = "Março";
            monthName[3] = "Abril";
            monthName[4] = "Maio";
            monthName[5] = "Junho";
            monthName[6] = "Julho";
            monthName[7] = "Agosto";
            monthName[8] = "Setembro";
            monthName[9] = "Outubro";
            monthName[10] = "Novembro";
            monthName[11] = "Dezembro";

            var currentMonth = monthName[today.getMonth()];
            var currentYear = today.getFullYear();
            var currentDate = today.getDate();
            var cells = document.getElementsByTagName("td");
            for (var i = 0; i < cells.length; i++) {
                if (cells[i].textContent == currentDate) {
                    cells[i].classList.add("today");
                }
            }
            document.getElementById("monthYear").innerHTML = currentMonth + " de " + currentYear;
        </script>
    </div>
</asp:Content>