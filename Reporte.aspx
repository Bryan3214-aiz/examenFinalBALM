<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="examenFinalBALM.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 958px;
            height: 70px;
            border-radius: 5px;
        }
        .auto-style3 {
            height: 37px;
            width: 958px;
        }
        .auto-style4 {
            width: 958px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div cssclass="rigth" class="datagrid">
        <h2 align="center" style="background-color: #99CCFF; font-style: italic; border-radius:6px">Reporte sobre las encuestas</h2>
        <table id="clientListTable" class="auto-style2">
            <thead cssclass="table" >
                <tr>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Numero Encuesta</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Nombre</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Genero</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Edad de nacimiento</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Correo electrónico</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Partido político</th>
                </tr>
                <asp:Repeater runat="server" ID="repeaterEncuestas">
                    <ItemTemplate>
                        <tr style="background-color: #99CCFF; color:black">
                            <td><%# Eval("Numero") %></td>
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Genero") %></td>
                            <td><%# Eval("Edad") %></td>
                            <td><%# Eval("Correo") %></td>
                            <td><%# Eval("Partido") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </thead>
        </table>
    </div>
    <div class="button-container" style="font-size: small; border-radius:6px">
            <a class="button" href="ReporteGenero.aspx" style="font-size: small">Reporte genero</a>
            <a class="button" href="ReporteCantidadEC.aspx" style="font-size: small">Cantidad encuestas</a>            
        </div>
    <div class="footer">
        Copyright &copy; Bryan Leiva - Todos los derechos 2023
    </div>
</asp:Content>
