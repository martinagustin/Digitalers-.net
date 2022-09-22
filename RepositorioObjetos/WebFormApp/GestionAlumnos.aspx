<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionAlumnos.aspx.cs" Inherits="WebFormApp.GestionAlumnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestion de alumnso</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 >Formulario Web de Inscripcion Alumnos </h2>
        </div>
        <asp:HyperLink runat="server" NavigateUrl="~/Home.html">navegar con hyperlink</asp:HyperLink><br />
        <asp:Label ID="Label3" runat="server" Text="Codigo:"></asp:Label>
        <asp:TextBox ID="txtcod" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="txtnom" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
        
        <asp:TextBox ID="txtape" runat="server" CssClass="text text-bg-dark"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" cssClass="btn btn-danger   " /><br /><br />
        <asp:Label ID="lblDatosAlumnos" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnviajar" runat="server" Text="moverse" OnClick="btnviajar_Click" />
    </form>
</body>
</html>
