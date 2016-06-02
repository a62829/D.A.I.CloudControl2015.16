<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ajuUminho.webforms.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>

    <body>
            <div id="IndexBox">
                <div id="ImgBox">
                    <div id="LoginBox">
            	        <form id="Login" runat="server">
    				    <h1>Iniciar Sessão</h1><br/>
                            <div id="LoginBox-UserName">
                                <asp:TextBox ID="TextBoxUserNameID" runat="server" CssClass="InputUserName"></asp:TextBox>
                            </div>
                            <div id="LoginBox-Password">
                                <asp:TextBox ID="TextBoxPasswordID" type="password" runat="server" CssClass="InputPassword"></asp:TextBox>
                            </div>
                            <div id="LoginBox-Button">
                                <asp:Button ID="ButtonAutenticarID" runat="server" Text="Autenticar" Cssclass="AutenticateButton" OnClick="SignIn"/>
                            </div>
				        </form>
                    </div>
                </div>
	         </div>

                <div id="FooterBox">
                    <div id="FooterBox1">
                    <% 
                        Response.WriteFile("../html/footer.html");
                    %>
                    </div>
                </div>

    </body>
</html>
<a href="login.aspx">login.aspx</a>