<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="ListarFornecedores.aspx.cs" Inherits="Estoque.Site.Admin.ListarFornecedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-md-4 col-md-offset-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Lista de Fornecedores
                        </div>
                        <asp:GridView ID="gridFornecedor" EmptyDataText="Não há registros para exibir" runat="server" AutoGenerateColumns="false" DataKeyNames="idFornecedor" OnRowDeleting="gridFornecedor_RowDeleting">
                            <RowStyle BackColor="#e6e6e6" />
                            <Columns>
                                <asp:TemplateField HeaderText="Código" HeaderStyle-CssClass="text-center" ItemStyle-Width="100" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lblIdFornecedor" runat="server" Text='<%#Eval("IdFornecedor") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Nome" HeaderStyle-CssClass="text-center" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNome" runat="server" Text='<%#Eval("Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowDeleteButton="true" ButtonType="Button" />
                            </Columns>
                        </asp:GridView>
                    </div>
                    <hr />
                    <asp:Label ID="lblMensagem" runat="server" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
