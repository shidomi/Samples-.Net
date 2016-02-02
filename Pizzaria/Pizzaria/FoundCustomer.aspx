<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FoundCustomer.aspx.cs" Inherits="Pizzaria.FoundCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap Core CSS -->
    <link href="LayoutScripts/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom Fonts -->
    <link href="LayoutScripts/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />

    <style>
        body {
            background-color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-lg-12 text-left">
            <br />
            <div class="alert alert-success">
                <strong><b><asp:Label ID="lblTel" runat="server" Text=""></asp:Label></b></strong>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <b><h3 class="panel-title"><asp:Label ID="lblNome" runat="server" Text=""></asp:Label></h3></b>
                </div>
                <div class="panel-body">
                    <b>Endereço:</b>
                    <asp:Label ID="lblEnd" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Bairro:</b>
                    <asp:Label ID="lblBairro" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Número:</b>
                    <asp:Label ID="lblNum" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Complemento:</b>
                    <asp:Label ID="lblComp" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Observações:</b>
                    <asp:Label ID="lblObs" runat="server" Text=""></asp:Label><br />
                </div>
            </div>
            <div class="col-lg-12 text-right">
                <div class="col-sm-10">
                    <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Gerar Pedido" OnClick="btGravar_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
