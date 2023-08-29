<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="ReporteCantidadEC.aspx.cs" Inherits="examenFinalBALM.ReporteCantidadEC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 958px;
            height: 70px;
            border-radius: 5px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div cssclass="rigth" class="datagrid">
        <h2 align="center" style="background-color: #99CCFF; font-style: italic; border-radius:6px">Reporte sobre las encuestas</h2>
        <table id="clientListTable" class="auto-style2">
            <thead cssclass="table" >
                <tr>
                    <th class="auto-style2" style="background-color: #1B325E; color: #ffffff">Cantidad de encuestas</th>
                </tr>
                <asp:Repeater runat="server" ID="repeaterCantidad">
                    <ItemTemplate>
                        <tr style="background-color: #99CCFF; color:black">
                            <td><%# Eval("cantidadTotal") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </thead>
        </table>
    </div>
</asp:Content>
