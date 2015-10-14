<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/AdminTemplate.Master" AutoEventWireup="true" CodeBehind="ListarProdutos.aspx.cs" Inherits="Estoque.Site.Admin.ListarProdutos" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contentPrincipal" runat="server">
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class=" col-sm-10 col-md-12 col-md-offset-0">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Lista de Produtos
                        </div>
                        <asp:GridView ID="gridProduto" runat="server" EmptyDataText="Não há registros para exibir" AutoGenerateColumns="false" DataKeyNames="idProduto" OnRowDeleting="gridProdutos_RowDeleting" OnRowEditing="gridProduto_RowEditing" OnRowUpdating="gridProduto_RowUpdating" OnRowCancelingEdit="gridProduto_RowCancelingEdit">
                            <RowStyle BackColor="#e6e6e6" />
                            <Columns>

                                <asp:TemplateField HeaderText="Código" HeaderStyle-CssClass="text-center" ItemStyle-Width="70" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lblIdProduto" runat="server" Text='<%#Eval("IdProduto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Fornecedor" HeaderStyle-CssClass="text-center" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:Label ID="lblFornecedorNome" runat="server" Text='<%#Eval("Fornecedor.Nome") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                             
                                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Nome" HeaderStyle-CssClass="text-center" ItemStyle-Width="200" ItemStyle-HorizontalAlign="Center" DataField="Nome" HtmlEncode="False" />

                                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Preço" HeaderStyle-CssClass="text-center" ItemStyle-Width="100" ItemStyle-HorizontalAlign="Center" DataField="Preco" DataFormatString="{0:c}" HtmlEncode="False" />

                                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Quantidade" HeaderStyle-CssClass="text-center" ItemStyle-Width="100" ItemStyle-HorizontalAlign="Center" DataField="Quantidade" HtmlEncode="False" />

                                <asp:BoundField ItemStyle-CssClass="t-cost" HeaderText="Descrição" HeaderStyle-CssClass="text-center" ItemStyle-Width="300" ItemStyle-HorizontalAlign="Center" DataField="Descricao" HtmlEncode="False" />

                                <asp:CommandField ShowEditButton="true" ItemStyle-Width="100" ControlStyle-CssClass="col-md-12" ButtonType="Button" />
                                <asp:CommandField ShowDeleteButton="true" ItemStyle-Width="100" ControlStyle-CssClass="col-md-12" ButtonType="Button" />

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
