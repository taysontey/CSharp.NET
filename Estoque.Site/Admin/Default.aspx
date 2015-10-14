<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Estoque.Site.Admin.Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">

    <div class="container">
        <div class="row">
            <div class="active">
                Bem Vindo, 
        <asp:Label ID="lblFuncionario" runat="server" />.
        <br />
                <br />
                <br />
                <form id="form1" runat="server">
                    <asp:Button ID="btnLogout" Width="80" CssClass="btn btn-success btn-block" runat="server" Text="Sair" OnClick="btnLogout_Click" />
                </form>
                <hr />
            </div>
        </div>
    </div>

</asp:Content>
