<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RemoveItem.aspx.cs" Inherits="Pizzaria.RemoveItem" %>

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
                <strong><b><asp:Label ID="lblTop" runat="server" Text="Remover do Estoque"></asp:Label></b></strong>
            </div>
            <div class="panel panel-default">
                <div class="panel-heading">
                    <b><h3 class="panel-title"><asp:Label ID="lblItem" runat="server" Text="Produto"></asp:Label></h3></b>
                </div>
                <div class="panel-body">
                    <b>Nome do Fornecedor:</b>
                    <asp:Label ID="lblNf" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Número do Documento:</b>
                    <asp:Label ID="lblNd" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Nome do Produto:</b>
                    <asp:Label ID="lblNp" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b>Quantidade:</b>
                    <asp:Label ID="lblQt" runat="server" Text=""></asp:Label><br />
                    <br />
                    <b> Remover :</b>
                    <asp:TextBox ID="txtQt" CssClass="form-control" Width="70" runat="server" placeholder="Quant."></asp:TextBox>
                </div>
                </div>
            </div>
            <div class="col-lg-12 text-right">                
                <div class="col-sm-10">
                    <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Remover" OnClick="btGravar_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
