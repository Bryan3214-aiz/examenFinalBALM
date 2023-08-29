<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ReporteGenero.aspx.cs" Inherits="examenFinalBALM.ReporteGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 961px;
        }
        .auto-style2 {
            width: 599px;
        }
        .auto-style3 {
            width: 576px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div cssclass="rigth" class="datagrid">
        <h2 align="center" style="background-color: #99CCFF; font-style: italic; border-radius:6px">Reporte sobre las encuestas</h2>
        <table id="clientListTable" class="auto-style1">
            <thead cssclass="table" >
                <tr>
                    <th class="auto-style3" style="background-color: #1B325E; color: #FFFFFF">Cantidad Masculina</th>
                    <th class="auto-style2" style="background-color: #1B325E; color: #FFFFFF">Cantidad Femenina</th>
                </tr>
                <asp:Repeater runat="server" ID="repeaterGenero">
                    <ItemTemplate>
                        <tr style="background-color: #99CCFF; color:black">
                            <td><%# Eval("cantidadM") %></td>
                            <td><%# Eval("cantidadF") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </thead>
        </table>
    </div>
</asp:Content>
