<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="Pizzaria.NewCustomer" %>

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
            <div class="panel panel-default">
                <div class="panel-heading">
                    <b>Novo Cliente</b>
                </div>
                <div class="panel-body">
                    <asp:TextBox CssClass="form-control" ID="txtNome" runat="server" Width="300" placeholder="Nome"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqNome" runat="server" ErrorMessage="Campo Nome obrigatório" ControlToValidate="txtNome" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtTel" runat="server" Width="130" placeholder="Telefone"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqTel" runat="server" ErrorMessage="Campo Telefone obrigatório" ControlToValidate="txtTel" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtEnd" runat="server" Width="450" placeholder="Endereço"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqEnd" runat="server" ErrorMessage="Campo Endereço obrigatório" ControlToValidate="txtEnd" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtBairro" runat="server" Width="250" placeholder="Bairro"></asp:TextBox>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtNum" runat="server" Width="80" placeholder="Número"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="reqNum" runat="server" ErrorMessage="Campo Número obrigatório" ControlToValidate="txtNum" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtComp" runat="server" Width="150" placeholder="Complemento"></asp:TextBox>
                    <br />

                    <asp:TextBox CssClass="form-control" ID="txtObs" runat="server" TextMode="MultiLine" Rows="4" Width="450" placeholder="Observação"></asp:TextBox>
                    <br />

                    <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Gravar" OnClick="btGravar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
