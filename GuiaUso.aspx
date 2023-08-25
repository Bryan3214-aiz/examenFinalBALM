<%@ Page Title="" Language="C#" MasterPageFile="~/MenuPrincipal.Master" AutoEventWireup="true" CodeBehind="GuiaUso.aspx.cs" Inherits="examenFinalBALM.GuiaUso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="faq-container">
        <details>
            <summary>
                <spam class="faq-title">
                    ¿Qué somos?
                </spam>
                <img src="assets/plus.svg" class="expand-icon" />
            </summary>
            <div class="faq-content">
                La sección de inicio cumple el propósito de brindar una introducción concisa al Tribunal Supremo de Justicia. Aquí, los visitantes encontrarán una breve descripción sobre la relevancia y el papel fundamental que desempeña esta institución en el sistema judicial. 
            </div>
        </details>
        <details>
            <summary>
                <spam class="faq-title">
                    Encuesta de Preferencias Políticas
                </spam>
                <img src="assets/plus.svg" class="expand-icon" />
            </summary>
            <div class="faq-content">
                La encuesta de preferencias políticas ofrece a los usuarios la oportunidad de expresar sus opiniones políticas de manera anónima y estructurada. Los participantes pueden proporcionar información esencial, como su nombre, correo electrónico, edad (restringida a la franja de 18 a 50 años) y su partido político de preferencia
            </div>
        </details>
        <details>
            <summary>
                <spam class="faq-title">Reporte de Encuestas</spam>
                <img src="assets/plus.svg" class="expand-icon" />
            </summary>
            <div class="faq-content">Muestra una tabla con los datos de todas las personas que han llenado la encuesta.</div>
        </details>
        <details>
            <summary>
                <spam class="faq-title">
                    Revista Digital sobre Derecho Electoral
                </spam>
                <img src="assets/plus.svg" class="expand-icon" />
            </summary>
            <div class="faq-content">La revista digital sobre derecho electoral es una fuente valiosa para aquellos interesados en cuestiones jurídicas y políticas.</div>
        </details>
        <details>
            <summary>
                <spam class="faq-title">Información del Creador</spam>
                <img src="assets/plus.svg" class="expand-icon" />
            </summary>
            <div class="faq-content">En la sección de contactenos se brinda la información personal del desarrollador.</div>
        </details>
    </div>
    <div class="footer">
        Copyright &copy; Bryan Leiva - Todos los derechos 2023
    </div>
    <script src="script.js"></script>
</asp:Content>
