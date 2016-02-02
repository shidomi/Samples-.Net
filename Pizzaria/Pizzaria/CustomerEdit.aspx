<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerEdit.aspx.cs" Inherits="Pizzaria.CustomerEdit" EnableEventValidation="false" %>

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
        <br />
        <div class="col-lg-12 text-left">
        <div class="panel panel-success">
            <div class="panel-heading">
                <h3 class="panel-title">Formulário</h3>
            </div>
            <div class="panel-body">
                <div class="panel-body">
                    <form class="form-horizontal">
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Nome</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtNome" runat="server" Width="500"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqNome" runat="server" ErrorMessage="Campo Nome obrigatório" ControlToValidate="txtNome" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtTel" class="col-sm-2 control-label">Telefone</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtTel" runat="server" Width="130"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqTel" runat="server" ErrorMessage="Campo Telefone obrigatório" ControlToValidate="txtTel" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtEnd" class="col-sm-2 control-label">Endereço</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtEnd" runat="server" Width="500"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqEnd" runat="server" ErrorMessage="Campo Endereço obrigatório" ControlToValidate="txtEnd" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtBairro" class="col-sm-2 control-label">Bairro</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtBairro" runat="server" Width="250"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNum" class="col-sm-2 control-label">Número</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtNum" runat="server" Width="60"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqNum" runat="server" ErrorMessage="Campo Número obrigatório" ControlToValidate="txtNum" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtComp" class="col-sm-2 control-label">Complemento</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtComp" runat="server" Width="60"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtObs" class="col-sm-2 control-label">Observação</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtObs" runat="server" TextMode="MultiLine" Rows="4" Width="550"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-sm-8">
                                <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Gravar" OnClick="btGravar_Click"/>
                                <br />
                                <br />
                                <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="#009900" Font-Bold="true"></asp:Label>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
