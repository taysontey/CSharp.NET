<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Estoque.Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.js"></script>
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
                            Sistema de Estoque
                        </div>
                        <div class="panel-body">
                            <asp:TextBox ID="txtLogin" runat="server"
                                CssClass="form-control" placeholder="Login" />
                            <asp:RequiredFieldValidator ID="reqLogin" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtLogin" runat="server" ErrorMessage="Preencha o campo Login."></asp:RequiredFieldValidator>

                            <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"
                                CssClass="form-control" placeholder="Senha" />
                            <asp:RequiredFieldValidator ID="reqSenha" ForeColor="Red" Font-Italic="true" Font-Bold="true" ControlToValidate="txtSenha" runat="server" ErrorMessage="Preencha o campo Senha."></asp:RequiredFieldValidator>
                        </div>
                        <div class="panel-footer">
                            <asp:Button ID="btnLogin" runat="server"
                                Text="Entrar"
                                CssClass="btn btn-success btn-block" OnClick="btnLogin_Click" />
                            <br />
                            <asp:CheckBox ID="checkLogin" runat="server" />
                            Manter conectado.                            
                            <a href="Pages/CadastroFuncionario.aspx" class="text-center new-account" style="float: right;">Cadastrar Funcionário</a>
                        </div>
                    </div>
                    <asp:Label ID="lblMensagem" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
