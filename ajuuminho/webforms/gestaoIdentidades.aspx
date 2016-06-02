<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestaoIdentidades.aspx.cs" Inherits="ajuUminho.webforms.gestaoIdentidades" %>
<%@ Register TagPrefix="uc" TagName="header" Src="~/controls/header.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <uc:header runat="server" ID="header" />
    <div id="BigBox">
        <div id="IdentidadesBox">
            <h3>Utilizadores do sistema</h3> <div class="hr-alignMore"> <hr /> </div>
            <div id="ListBoxIdentidades">
                       <asp:ListBox ID="ListBoxIdentidadesID" runat="server" CssClass="ListBoxIdentidades-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxIdentidadesID_SelectedIndexChanged"></asp:ListBox>
            </div>

            <div id="AtributosBoxIdentidades">
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelNomeID" runat="server" Text="Label" CssClass="Labels-Item">
                           Nome: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelEmailID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Email: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxEmailID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelTelefoneID" runat="server" Text="Label" CssClass="Labels-Item">
                           Telefone: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTelefoneID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelPasswordID" runat="server" Text="Label" CssClass="Labels-Item">
                            Password: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxPasswordID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                   <tr>
                      <td> <asp:Label ID="LabelConfirmPasswordID" runat="server" Text="Label" CssClass="Labels-Item"> 
                            Confirmar Password: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxConfirmPasswordID" runat="server" CssClass="LabelsInputs-Item" Height="20px" ></asp:TextBox> </td>
                  </tr>
            </table>

          </div>

        </div>

            <div id="RolesBox">
                <h3>Perfis</h3> <div class="hr-alignMore"> <hr /> </div>
                <div id="PerfisListBox1">
                    <div id="PerfisListBox3">
                        <h4>Perfis do Sistema</h4> <div class="hr-alignLess"> <hr /> </div>
                    <div class="PerfisListBox-Item">
                        <asp:ListBox ID="ListBoxPerfisID" runat="server" CssClass="PerfisList-Item" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ListBoxPerfisID_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </div>
                <div id="PerfisButtonsBox">
                    <asp:Button ID="ButtonMoreID" runat="server" Text=">" CssClass="MoreButton" OnClick="ButtonMoreID_Click"/>
                    <asp:Button ID="ButtonLessID" runat="server" Text="<" CssClass="LessButton" OnClick="ButtonLessID_Click"/>
                </div>
                    <div id="PerfisListBox4">
                        <h4>Perfis Associados ao Utilizador</h4> <div class="hr-alignLess"> <hr /> </div>
                    <div class="PerfisListBox-Item">
                        <asp:ListBox ID="ListBoxPerfisAssociadosID" runat="server" CssClass="PerfisList-Item" AutoPostBack="True"></asp:ListBox>
                    </div>
                    </div>
                </div>

                <div id="PerfisListBox2">
                    <div id="AdicionarPerfilBox">
                    <h4>Adicionar novo perfil ao sistema</h4> <div class="hr-alignLess"> <hr /> </div>
                    <asp:TextBox ID="TextBoxAdicionarPerfilID" runat="server"></asp:TextBox>
                    <asp:Button ID="ButtonAdicionarPerfilID" runat="server" Text="+" Width="25px" CssClass="AdicionarPerfilButton" OnClick="ButtonAdicionarPerfilID_Click" />
                    </div>
                   </div>
            </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar" CssClass="ContentButton" OnClick="ButtonEditarID_Click"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar" CssClass="ContentButton" OnClick="ButtonEliminarID_Click"/>
            <asp:Button ID="ButtonGravarID" runat="server" Text="Gravar" CssClass="ContentButton" OnClick="ButtonGravar_Click"/>
            <asp:Button ID="ButtonAlterarPasswordID" runat="server" Text="Alterar Password" CssClass="ContentButton" OnClick="ButtonAlterarPasswordID_Click"/>
        </div>
    </div>
    </form>


        <div id="FooterBox">
            <div id="FooterBox2">
                <% 
                    Response.WriteFile("../html/footer.html");
                %>
            </div>
        </div>
</body>
</html>
