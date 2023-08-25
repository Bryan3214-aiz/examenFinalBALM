<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="examenFinalBALM.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            left: -48px;
            top: 0px;
            width: 1030px;
            height: 362px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="mensaje" aria-orientation="horizontal" class="auto-style1">
        <h2><em>TRIBUNAL SUPREMO DE ELECCIONES</em> </h2>
        <p style="font-family: Arial">
            El Tribunal Supremo de Elecciones (TSE) es una institución que existe en varios países, y su función principal es velar por la organización y supervisión de los procesos electorales y referendos, así como garantizar el cumplimiento de las normas y regulaciones relacionadas con el ejercicio del sufragio y la participación ciudadana en el sistema democrático.<br />
            <br /><br />
            En Costa Rica, por ejemplo, el Tribunal Supremo de Elecciones es el ente encargado de administrar, organizar y supervisar las elecciones nacionales, municipales y otros procesos de consulta popular. Su objetivo es asegurar la transparencia, imparcialidad y legalidad de los procesos electorales, así como garantizar los derechos de los ciudadanos a votar y ser elegidos.<br /><br />
            En otros países, el nombre y la estructura de esta institución pueden variar. Por ejemplo, en España se conoce como el Tribunal Supremo Electoral y es el encargado de supervisar y garantizar la regularidad de los procesos electorales y referendos.
            Es importante tener en cuenta que las funciones y atribuciones del Tribunal Supremo de Elecciones pueden variar según el país y su marco legal específico.
        </p>
        <div class="button-container">
            <a class="button" href="https://es.wikipedia.org/wiki/Tribunal_Supremo_de_Elecciones_de_Costa_Rica">Leer más</a>
            <a class="button" href="GuiaUso.aspx">Guia de uso</a>            
        </div>
    </div>
        <div class="footer">
            Copyright &copy; Bryan Leiva - Todos los derechos 2023
        </div>
</asp:Content>
