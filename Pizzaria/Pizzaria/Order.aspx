<%@ Page Language="C#" MasterPageFile="~/Pizzaria.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Pizzarias.Order" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="Server">
    <style>
        #DropDown {
            font-size: small;
        }

        #tbl {
            display: none;
        }
    </style>
    <!-- Page Heading -->
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Pedido <small>Gerar</small>
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
                    <div class="form-group">
                        <div id="DropDown">
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <div id="tbl">
                                        <div class="col-lg-5">
                                            <div class="well well-sm">
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <label>Nome</label>
                                                            <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                                                        </td>
                                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                        <td>
                                                            <label>Bairro</label>
                                                            <asp:Label ID="lblEnd" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <label>Telefone</label>
                                                            <asp:Label ID="lblTel" runat="server" Text=""></asp:Label>
                                                        </td>
                                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                        <td>
                                                            <label>Número</label>
                                                            <asp:Label ID="lblNum" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <label>Endereço</label>
                                                            <asp:Label ID="lblBarr" runat="server" Text=""></asp:Label>
                                                        </td>
                                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        </td>
                                                        <td>
                                                            <label>Complemento</label>
                                                            <asp:Label ID="lblComp" runat="server" Text=""></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-10 text-left">
                                    <label>Sabor</label>
                                    <asp:DropDownList ID="DropDownListSabor1" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <label>Quantidade</label>
                                    <asp:DropDownList ID="DropDownListQuant1" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor2" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant2" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor3" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant3" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor4" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant4" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor5" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant5" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor6" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant6" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor7" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant7" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-lg-10 text-left">
                                    <asp:DropDownList ID="DropDownListSabor8" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                                <div class="col-lg-1 text-left">
                                    <asp:DropDownList ID="DropDownListQuant8" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                            <br />
                            <br />
                            <div class="form-group">
                                <div class="col-sm-8">
                                    <asp:Button CssClass="btn btn-default" ID="btGravar" runat="server" Text="Gerar Pedido" OnClick="btGravar_Click" />
                                    <br />
                                    <br />
                                    <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="red" Font-Bold="true"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
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
    <!-- jQuery -->
    <script src="LayoutScripts/js/jquery.js"></script>
    <script>
        $(document).ready(function () {
            var currentURL = window.location.href;
            if (currentURL.includes("id=")) {
                $("#tbl").css("display", "block");
            }
        });
    </script>

</asp:Content>
