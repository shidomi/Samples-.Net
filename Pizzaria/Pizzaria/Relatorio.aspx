<%@ Page Language="C#" MasterPageFile="~/Pizzaria.Master" AutoEventWireup="true" CodeBehind="Relatorio.aspx.cs" Inherits="Pizzaria.Relatorio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="Server">

    <!-- Page Heading -->
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Relatório <small></small>
            </h1>
        </div>
    </div>

    <div class="row">
        <div class="col-lg-12 text-left">
            <div class="panel panel-success">
                <div class="panel-heading">
                    <h3 class="panel-title"><i class="fa fa-bar-chart-o"></i>Gráfico de vendas</h3>
                </div>
                <div class="panel-body">
                    <div id="morris-area-chart"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- /.row -->
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
