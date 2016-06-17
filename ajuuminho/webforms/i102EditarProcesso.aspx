<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="i102EditarProcesso.aspx.cs" Inherits="ajuUminho.webforms.i102EditarProcesso" %>

<%@ Register TagPrefix="uc1" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet" />
</head>
<body>
    <form id="form1" runat="server">

        <uc1:i14TerminoDeSessao runat="server" ID="headerID" />
        <div id="BigBox">

            <div class="ViewsBox">

                <div id="ProcessosBox">
                    <div class="AlignBox">
                        <div class="titleh3">
                            <h3>Lista de processos</h3>
                        </div>
                        <asp:ListBox ID="ListBoxProcessosID" runat="server" CssClass="ListBoxProcessos-Item" AutoPostBack="True" OnSelectedIndexChanged="ListBoxProcessosID_SelectedIndexChanged"></asp:ListBox>
                    </div>
                </div>

                <%-- 2ª multiview --%>
                <div class="ViewsButtonsBox">
                    <asp:Button Text="Dados Base" BorderStyle="None" ID="TabDadosBaseID" CssClass="Initial" runat="server"
                        OnClick="TabDadosBase_Click" />
                    <asp:Button Text="Entidades" BorderStyle="None" ID="TabEntidadesID" CssClass="Initial" runat="server"
                        OnClick="TabEntidades_Click" />
                    <asp:Button Text="Credores" BorderStyle="None" ID="TabCredoresID" CssClass="Initial" runat="server"
                        OnClick="TabCredores_Click" />
                    <asp:Button Text="Arquivo" BorderStyle="None" ID="TabArquivoID" CssClass="Initial" runat="server"
                        OnClick="TabArquivo_Click" />
                    <asp:Button Text="Eventos" BorderStyle="None" ID="TabEventosID" CssClass="Initial" runat="server"
                        OnClick="TabEventos_Click" />
                    <asp:Button Text="Bens" BorderStyle="None" ID="TabBensID" CssClass="Initial" runat="server"
                        OnClick="TabBens_Click" />
                    <asp:Button Text="Movimentos financeiros" BorderStyle="None" ID="TabMovimentosFinanceirosID" CssClass="Initial" runat="server"
                        OnClick="TabMovimentosFinanceiros_Click" />
                    <asp:Button Text="Serviços externos" BorderStyle="None" ID="TabServicosExternosID" CssClass="Initial" runat="server"
                        OnClick="TabServicosExternos_Click" />
                    <asp:Button Text="Ficheiros multimédia" BorderStyle="None" ID="TabFicheirosMultimediaID" CssClass="Initial" runat="server"
                        OnClick="TabFicheirosMultimedia_Click" />
                    <asp:Button Text="Ficheiros texto" BorderStyle="None" ID="TabFicheirosTextoID" CssClass="Initial" runat="server"
                        OnClick="TabFicheirosTexto_Click" />
                </div>

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
