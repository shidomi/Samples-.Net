<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pizzaria.Login" EnableEventValidation="false" %>

<!DOCTYPE HTML>
<html dir="ltr" lang="en-US">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>Login</title>

    <!-- Bootstrap Core CSS -->
    <link href="LayoutScripts/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom CSS -->
    <link href="LayoutScripts/css/sb-admin.css" rel="stylesheet" />

    <!-- Morris Charts CSS -->
    <link href="LayoutScripts/css/plugins/morris.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="LayoutScripts/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <style>
        body {
            background-color: white;
        }
    </style>

</head>

<body>
    <form action="#" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">PizzAdm <%=General.BuildNumber%></h3>
                        </div>
                        <div class="panel-body">
                            <form role="form">
                                <fieldset>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtUser" class="form-control" runat="server" Text="" placeholder="Login"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtSenha" class="form-control" runat="server" TextMode="Password" test="" placeholder="Senha"></asp:TextBox>
                                    </div>
                                    <!-- Change this to a button or input when using this as a form -->
                                    <asp:Button ID="btLogin" class="btn btn-lg btn-success btn-block" runat="server" Text="Entrar" OnClick="btLogin_Click" />
                                </fieldset>
                            </form>
                            <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
