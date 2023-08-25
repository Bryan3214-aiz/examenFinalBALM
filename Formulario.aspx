<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="examenFinalBALM.Formulario1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 style="text-align:center">Encuesta sobre política</h1>
        <label for="participant-name">Nombre del participante:</label>
        <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
        <label for="gender">Género:</label>
        <asp:DropDownList ID="tGenero" runat="server">
            <asp:ListItem Text="Masculino" Value="M" />
            <asp:ListItem Text="Femenino" Value="F" />
            <asp:ListItem Text="Otro" Value="O" />
        </asp:DropDownList>

        <label for="age">Edad de Nacimiento:</label>
        <asp:TextBox type="number" ID="tedad" runat="server" min="18" max="50" ></asp:TextBox>
        <label for="email">Correo Electrónico:</label>
        <asp:TextBox id="tcorreo" runat="server"></asp:TextBox>
        <label for="political-party">Partido Político:</label>
        <asp:DropDownList ID="tpartido" runat="server">
            <asp:ListItem Text="PLN" Value="PLN" />
            <asp:ListItem Text="PUSC" Value="PUSC" />
            <asp:ListItem Text="PAC" Value="PAC" />
        </asp:DropDownList>

        <asp:Button Class="button" runat="server" Text="Enviar Encuesta" OnClick="EnviarEncuesta_Click"/> 
        <div class="footer">
            Copyright &copy; Bryan Leiva - Todos los derechos 2023
        </div>
    </div>

</asp:Content>
