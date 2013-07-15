<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SIADISC2.Presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SIADISC Login</title>
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~")%>Presentacion/resources/bootstrap/css/bootstrap.min.css" />
    <style type="text/css">
        body
        {
            padding-top: 40px;
            padding-bottom: 40px;
            background-color: #f5f5f5;
        }
        
        .form-signin
        {
            max-width: 300px;
            padding: 19px 29px 29px;
            margin: 0 auto 20px;
            background-color: #fff;
            border: 1px solid #e5e5e5;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            -moz-box-shadow: 0 1px 2px rgba(0,0,0,.05);
            box-shadow: 0 1px 2px rgba(0,0,0,.05);
        }
        .form-signin .form-signin-heading, .form-signin .checkbox
        {
            margin-bottom: 10px;
        }
        .form-signin input[type="text"], .form-signin input[type="password"]
        {
            font-size: 16px;
            height: auto;
            margin-bottom: 15px;
            padding: 7px 9px;
        }
        label 
        {
            vertical-align: middle !important;
            padding-right: 9px;
        }
    </style>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="form-signin">
        <h3 class="text-center">Administración MyS</h3>
        <asp:Login ID="formLogin" runat="server" TitleText="" OnAuthenticate="onAuthenticate" UserNameRequiredErrorMessage="El RUT es obligatorio" PasswordRequiredErrorMessage="La Contraseña es obligatoria." UserNameLabelText="RUT:">
        </asp:Login>
        </form>
    </div>
    <script type="text/javascript" src="<%=ResolveUrl("~")%>Presentacion/resources/bootstrap/js/jQuerry.js"></script>
    <script type="text/javascript" src="<%=ResolveUrl("~")%>Presentacion/resources/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="<%=ResolveUrl("~")%>Presentacion/resources/bootstrap/js/jquery.Rut.min.js"></script>
    <script>
        $(function () {
            $('#formLogin_UserName').Rut({
                on_error: function () { alert('El RUT ingresado es incorrecto'); }
            })
        });
    </script>
</body>
</html>
