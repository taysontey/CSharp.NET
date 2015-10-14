<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="CadastroFornecedor.aspx.cs" Inherits="Estoque.Site.Admin.CadastroFornecedor" %>



<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-md-4 col-md-offset-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Cadastro de Fornecedores
                        </div>
                        <div class="panel-body">
                            <label>Nome:</label>
                            <br />
                            <asp:TextBox ID="txtNome" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqNome" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtNome" runat="server" ErrorMessage="Campo Nome é obrigatório."></asp:RequiredFieldValidator>
                        </div>
                        <div class="panel-footer">
                            <asp:Button ID="btnCadastro" runat="server"
                                Text="Cadastrar Fornecedor"
                                CssClass="btn btn-success btn-block" OnClick="btnCadastro_Click" />
                            <hr />
                            <asp:Label ID="lblMensagem" runat="server" />
                        </div>
                    </div>
                    <hr />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
