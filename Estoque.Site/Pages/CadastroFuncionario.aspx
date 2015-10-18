<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="Estoque.Site.Pages.CadastroFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap-theme.css" rel="stylesheet" />
    <script src="../Scripts/jquery-2.1.4.js"></script>

</head>
<body>
    <br />
    <br />
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-md-4 col-md-offset-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            Cadastro de Funcionários
                        </div>
                        <div class="panel-body">

                            <label>Nome:</label>
                            <br />
                            <asp:TextBox ID="txtNome" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqNome" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtNome" runat="server" ErrorMessage="Campo Nome é obrigatório."></asp:RequiredFieldValidator>
                            <br />

                            <label>Login:</label>
                            <br />
                            <asp:TextBox ID="txtLogin" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqLogin" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtLogin" runat="server" ErrorMessage="Campo Login é obrigatório."></asp:RequiredFieldValidator>
                            <br />

                            <label>Senha:</label>
                            <br />
                            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqSenha" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtSenha" runat="server" ErrorMessage="Campo Senha é obrigatório."></asp:RequiredFieldValidator>
                            <br />

                            <label>Confirme sua Senha:</label>
                            <br />
                            <asp:TextBox ID="txtConfirmSenha" TextMode="Password" runat="server"
                                CssClass="form-control" />
                            <asp:RequiredFieldValidator ID="reqConfirmSenha" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtConfirmSenha" runat="server" ErrorMessage="A Confirmação da Senha é obrigatória."></asp:RequiredFieldValidator>
   
                        </div>
                        <div class="panel-footer">
                            <asp:Button ID="btnCadastro" runat="server"
                                Text="Cadastrar Funcionário"
                                CssClass="btn btn-success btn-block" OnClick="btnCadastro_Click" />
                            
                            <asp:Label ID="lblMensagem" runat="server" />
                        </div>
                    </div>
                    <a href="/Default.aspx">Voltar</a>
                    <hr />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
