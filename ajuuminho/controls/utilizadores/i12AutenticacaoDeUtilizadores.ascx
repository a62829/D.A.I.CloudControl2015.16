<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="i12AutenticacaoDeUtilizadores.ascx.cs" Inherits="ajuUminho.controls.utilizadores.i12AutenticacaoDeUtilizadores" %>
            
        <div id="IndexBox">
                <div id="ImgBox">
                    <div id="LoginBox">
            	        <form id="Login" runat="server">
    				    <h1>Iniciar Sessão</h1><br/>
                            <div id="LoginBox-UserName">
                                <asp:TextBox ID="TextBoxUserNameID" runat="server" placeholder="Username" CssClass="InputUserName"></asp:TextBox>
                            </div>
                            <div id="LoginBox-Password">
                                <asp:TextBox ID="TextBoxPasswordID" type="password" placeholder="Password" runat="server" CssClass="InputPassword"></asp:TextBox>
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