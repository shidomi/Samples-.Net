<%@ Page Language="C#" MasterPageFile="~/Pizzaria.Master" AutoEventWireup="true" CodeBehind="Estoque.aspx.cs" Inherits="Pizzaria.Estoque" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="Server">
    <script src="Scripts/number_format.js"></script>

    <!-- Page Heading -->
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Estoque <small>Cadastrar</small>
            </h1>
        </div>
    </div>

    <div class="col-lg-12 text-left">
        <div class="panel panel-success">
            <div class="panel-heading">
                <h3 class="panel-title">Formulário</h3>
            </div>
            <div class="panel-body">
                <div class="panel-body">
                    <form class="form-horizontal">
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Categoria</label>
                            <div class="col-sm-8">
                                <asp:DropDownList ID="drpCategoria" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="drpCategoria_SelectedIndexChanged"></asp:DropDownList>
                                <asp:Label ID="lblCategoria" runat="server" Text="" Font-Size="Smaller" ForeColor="red"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Item</label>
                            <div class="col-sm-8">
                                <asp:DropDownList ID="drpItem" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Fornecedor</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtFornecedor" runat="server" Width="350"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtFornecedor" runat="server" ErrorMessage="Campo Fornecedor obrigatório" ControlToValidate="txtFornecedor" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Nº Documento</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtDocumento" runat="server" Width="350"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtDocumento" runat="server" ErrorMessage="Campo Nº Documento obrigatório" ControlToValidate="txtDocumento" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Valor</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtValor" runat="server" Width="100"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtValor" runat="server" ErrorMessage="Campo Valor obrigatório" ControlToValidate="txtValor" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Quantidade</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtQuantidade" runat="server" Width="70"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtQuantidade" runat="server" ErrorMessage="Campo Quantidade obrigatório" ControlToValidate="txtQuantidade" Font-Size="Smaller" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <label for="txtNome" class="col-sm-2 control-label">Observações</label>
                            <div class="col-sm-8">
                                <asp:TextBox CssClass="form-control" ID="txtObs" runat="server" TextMode="MultiLine" Rows="4" Width="550"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-sm-8">
                                <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Gravar" OnClick="btGravar_Click" />
                            </div>
                        </div>
                    </form>
                </div>
                <br />
                <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="#009900" Font-Bold="true"></asp:Label>
            </div>
        </div>
    </div>

    <!-- Footer -->
    <hr class="featurette-divider" />
    <footer>
        <div class="row">
            <div class="col-lg-12">
                <small>
                    <p>©Copyright 2015 Casting Consultoria.</p>
                </small>
            </div>
        </div>
    </footer>
</asp:Content>
