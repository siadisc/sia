<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro_Postulante.aspx.cs" Inherits="SIADISC.Registro_Postulante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <p>
        <asp:Label ID="Label2" runat="server" Text="Ingrese los datos solicitados a continuación:" Font-Bold="True"></asp:Label>
        </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="Label_Semestre" runat="server" Text="Semestre:  "></asp:Label>
        <asp:TextBox ID="TextBox_Semestre" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label_Año" runat="server" Text="Año: "></asp:Label>
        <asp:TextBox ID="TextBox_Año" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />

        
    </p>
    <asp:Panel ID="Panel_DatosPersonales" runat="server" BorderStyle="Outset">    
        <p>
            <asp:Label ID="Label1" runat="server" Text="DATOS PERSONALES" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label_NombreCompleto" runat="server" Text="Nombre Completo:  "></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox_NombreCompleto" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_Rut" runat="server" Text="Rut:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Rut" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label_Direccion" runat="server" Text="Dirección:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Direccion" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_FechaNac" runat="server" Text="Fecha de Nacimiento:  "></asp:Label>
            <asp:TextBox ID="TextBox_FechaNac" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:Label ID="Label_Email" runat="server" Text="Email:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Email" runat="server" TextMode="Email"></asp:TextBox>                        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
            <asp:Label ID="Label_Telefono" runat="server" Text="Teléfono :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Telefono" runat="server" TextMode="Phone"></asp:TextBox>
            <br />
            <asp:Label ID="Label_Carrera" runat="server" Text="Carrera:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Carrera" runat="server"></asp:TextBox>      
                        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_Matricula" runat="server" Text="Matrícula:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Matricula" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label_FechaPost" runat="server" Text="Fecha de Postulación:  "></asp:Label>
            <asp:TextBox ID="TextBox_FechaDePost" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:Label ID="Label_NumeroAyudantias" runat="server" Text="Número de ayudantías en el departamento (serán verificadas) :  "></asp:Label>
            <asp:TextBox ID="TextBox_NumeroAyudantias" runat="server" TextMode="Number"></asp:TextBox>
        </p>
    </asp:Panel>
    <asp:Panel ID="Panel_AyudantiaSolicitada" runat="server" BorderStyle="Outset" >
        <asp:Label ID="Label_AyudantiaSolcitada" runat="server" Text="AYUDANTIA SOLICITADA" Font-Bold="True"></asp:Label>
        <p style="margin-left: 40px">
            
            <br /> 
            <br />
            <asp:Label ID="Label_Asignatura" runat="server" Text="Asignatura:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Asignatura" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_Codigo" runat="server" Text="Código:  "></asp:Label>
            <asp:TextBox ID="TextBox_Codigo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label_NotaAprob" runat="server" Text="Nota Aprobación:  "></asp:Label>
            <asp:TextBox ID="TextBox_NotaAprob" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label_NombreProfesor" runat="server" Text="Nombre del profesor:  "></asp:Label>
            <asp:TextBox ID="TextBox_NombreProfesor" runat="server" Width="576px"></asp:TextBox>
            <br />
            <asp:Label ID="Label_NumHoras" runat="server" Text="Académico sugiere número de horas:  "></asp:Label>
            <asp:TextBox ID="TextBox_NumHoras" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label_FechaInicioAyudantia" runat="server" Text="Fecha de inicio de ayudantía:  "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_Finicio" runat="server" Enabled="False"></asp:TextBox>
        </p>
    </asp:Panel>
</asp:Content>
