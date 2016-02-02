<%@ Page Language="C#" MasterPageFile="~/Pizzaria.Master" AutoEventWireup="true" CodeBehind="CustomerSearch.aspx.cs" Inherits="Pizzaria.CustomerSearch" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="Server">
    <script>
        function EditCustomer(id) {
            var w = 780;
            var h = 610;
            var left = Number((screen.width / 2) - (w / 2));
            var tops = Number((screen.height / 2) - (h / 2));
            window.open("CustomerEdit.aspx?id=" + id, '', 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=no, resizable=no, copyhistory=no, width=' + w + ', height=' + h + ', top=' + tops + ', left=' + left);
        }
    </script>
    <!-- Page Heading -->
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Cliente <small>Pesquisar</small>
            </h1>
        </div>
    </div>

    <div class="col-lg-12 text-left">
        <div class="panel panel-success">
            <div class="panel-heading">
                <h3 class="panel-title">Busca</h3>
            </div>
            <div class="panel-body">
                <div class="panel-body">
                    <form class="form-inline" role="form">

                        <div class="row">
                            <!-- /.col-lg-6 -->
                            <div class="col-lg-6">
                                <label for="txtPesquisa">Nome: </label>
                                <div class="input-group">
                                    <asp:TextBox ID="txtPesquisa" CssClass="form-control" placeholder="Procurar por..." runat="server"></asp:TextBox>
                                    <span class="input-group-btn">
                                        <asp:Button ID="btPesquisa" CssClass="btn btn-default" runat="server" Text="Pesquisar" OnClick="btPesquisa_Click" />
                                    </span>
                                </div>
                                <!-- /input-group -->
                            </div>
                            <!-- /.col-lg-6 -->
                        </div>
                        <!-- /.row -->
                    </form>
                    <div class="row">
                        <div class="col-lg-12">
                            <h1></h1>
                            <div class="table-responsive">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" class="table table-bordered table-hover table-striped">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="ID" />
                                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                        <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                                        <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                                        <asp:BoundField DataField="Bairro" HeaderText="Bairro" />
                                        <asp:BoundField DataField="Numero" HeaderText="Número" />
                                        <asp:BoundField DataField="Complemento" HeaderText="Complemento" />
                                        <asp:BoundField DataField="Observacoes" HeaderText="Observações" />
                                        <asp:TemplateField HeaderText="Opções">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName="ShowDetails" CausesValidation="False" OnClick="LinkButton1_Click">Editar</asp:LinkButton>
                                                |
                                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="ShowDetails" CausesValidation="False" OnClick="LinkButton2_Click">Pedido</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Footer -->

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
