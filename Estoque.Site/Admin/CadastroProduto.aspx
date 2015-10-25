<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="Estoque.Site.Admin.CadastroProduto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-md-4 col-md-offset-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Cadastro de Produtos
                        </div>
                        <div class="panel-body">
                            <label>Nome:</label>
                            <br />
                            <asp:TextBox ID="txtNome" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqNome" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtNome" runat="server" ErrorMessage="Campo Nome é obrigatório."></asp:RequiredFieldValidator>
                            <br />
                            <label>Preço:</label>
                            <br />
                            <asp:TextBox ID="txtPreco" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqPreco" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtPreco" runat="server" ErrorMessage="Campo Preço é obrigatório."></asp:RequiredFieldValidator>
                            <br />
                            <label>Quantidade:</label>
                            <br />
                            <asp:TextBox ID="txtQuantidade" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqQuantidade" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtQuantidade" runat="server" ErrorMessage="Campo Quantidade é obrigatório."></asp:RequiredFieldValidator>
                            <br />
                            <label>Descrição:</label>
                            <br />
                            <asp:TextBox ID="txtDescricao" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqDescricao" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtDescricao" runat="server" ErrorMessage="Campo Descrição é obrigatório."></asp:RequiredFieldValidator>
                            <br />
                            <label>Selecione o Fornecedor:</label>
                            <br />
                            <asp:DropDownList ID="DropDownFornecedor" runat="server">
                            </asp:DropDownList>
                        </div>
                        <div class="panel-footer">
                            <asp:Button ID="btnCadastro" runat="server"
                                Text="Cadastrar Produto"
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
