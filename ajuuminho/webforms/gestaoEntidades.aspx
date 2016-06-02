<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gestaoEntidades.aspx.cs" Inherits="ajuUminho.webforms.gestaoEntidades" %>
<%@ Register TagPrefix="uc" TagName="header" Src="~/controls/header.ascx"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>
<body>
    <form id="Form" runat="server">
    <uc:header runat="server" ID="header" />
    <div id="BigBox">
        <div id="EntidadesBox">
            <h3>Entidades Existentes</h3> <div class="hr-alignMore"> <hr /> </div>
            <div id="ListEdentidades">
                <div class="AlignBox">
                    <asp:ListBox ID="ListBoxEntidadesID" runat="server" CssClass="ListBoxEntidades-Item" OnSelectedIndexChanged="ListBoxEntidadesID_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                    <div id="TipoEntidadeDrpdownBox">
                        <table class="ContentTable">
                    <tr>
                      <td> <asp:Label ID="LabelTipoID" runat="server" Text="Label"  CssClass="Labels-Item">
                          Tipo: </asp:Label> </td>
                      <td> <asp:DropDownList ID="DropDownListTipoID" runat="server" CssClass="LabelsInputs2-Item" OnSelectedIndexChanged="DropDownListTipoID_SelectedIndexChanged" AutoPostBack="True">
                          <asp:ListItem>juiz</asp:ListItem>
                          <asp:ListItem>credor</asp:ListItem>
                          <asp:ListItem>insolvente</asp:ListItem>
                          <asp:ListItem>contabilista</asp:ListItem>
                          <asp:ListItem>tribunal</asp:ListItem>
                          <asp:ListItem>outraEntidade</asp:ListItem>
                          <asp:ListItem>prestadorServico</asp:ListItem>
                          <asp:ListItem>administradorJudicial</asp:ListItem>
                          </asp:DropDownList> </td>
                  </tr>
                  </table>
                  </div>
                </div>
        </div>
        <div id="AtributosBox">
              <table class="ContentTable">
                  <tr>
                      <td> <asp:Label ID="LabelNomeID" runat="server" Text="Label"  CssClass="Labels-Item">
                          Nome: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNomeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelMoradaID" runat="server" Text="Label"  CssClass="Labels-Item">
                           Morada: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxMoradaID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelCodPostalID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Cód-Postal: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxCodPostalID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelLocalidadeID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Localidade: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxLocalidadeID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
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
                      <td> <asp:Label ID="LabelTelemovelID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Telemóvel: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxTelemovelID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelFaxID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Fax: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxFaxID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelCcID" runat="server" Text="Label" CssClass="Labels-Item"> 
                          Cartão de cidadão: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxCcID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelIbanID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Iban: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxIbanID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelNifID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           NIF: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxNifID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
                  <tr>
                      <td> <asp:Label ID="LabelLastChangedID" runat="server" Text="Label" CssClass="Labels-Item"> 
                           Alterado por: </asp:Label> </td>
                      <td> <asp:TextBox ID="TextBoxLastChangedID" runat="server" CssClass="LabelsInputs-Item"></asp:TextBox> </td>
                  </tr>
             </table>
          </div>
        </div>

        <div id="ContentButtonsBox">
            <asp:Button ID="ButtonCriarID" runat="server" Text="Criar"  CssClass="ContentButton" OnClick="ButtonCriarID_Click"/>
            <asp:Button ID="ButtonEditarID" runat="server" Text="Editar"  CssClass="ContentButton" OnClick="ButtonEditarID_Click"/>
            <asp:Button ID="ButtonEliminarID" runat="server" Text="Eliminar"  CssClass="ContentButton" OnClick="ButtonEliminarID_Click"/>
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
