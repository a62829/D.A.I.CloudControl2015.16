<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ajuUminho.webforms.home" %>
<%@ Register TagPrefix="uc" TagName="i14TerminoDeSessao" Src="~/controls/utilizadores/i14TerminoDeSessao.ascx"%>
<%@ Register TagPrefix="uc1" TagName="i4AlteracaoDeDadosPessoais" Src="~/controls/utilizadores/i4AlteracaoDeDadosPessoais.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Aju-UMinho</title>
    <link rel="stylesheet" type="text/css" href="../css/StyleSheet.css" title="StyleSheet"/>
</head>
<body>
    <form id="Form" runat="server" aria-expanded="true">
        <uc:i14TerminoDeSessao runat="server" ID="headerID" />
        <div id="BigBox">

            <div id="ProcessesHomeBox">
                <div class="AlignBox">
                     <div class="titleHhome"> <h3>Processos</h3> </div>
                    <asp:ListBox ID="ProcessesListID" runat="server" Cssclass="Processes-Item">
                        <asp:ListItem>Processo de Sireve</asp:ListItem>
                        <asp:ListItem>Processo de Revitalização</asp:ListItem>
                        <asp:ListItem>Processo de Divórcio</asp:ListItem>
                        <asp:ListItem>Processo de Insolvencia</asp:ListItem>
                    </asp:ListBox>
                </div>
            </div>

            <div id="CalendarHomeBox">
                     <div class="titleHhome"> <h3>Calendário</h3> </div>
                     <asp:Calendar ID="CalendarID" runat="server" Cssclass="Calendar-Item"></asp:Calendar>
            </div>

            <div id="EventsHomeBox">
                <div class="AlignBox">
                     <div class="titleHhome"> <h3>Eventos</h3> </div>
                    <asp:ListBox ID="EventsListID" runat="server" Cssclass="Events-Item">
                        <asp:ListItem>Assembleia de credores</asp:ListItem>
                        <asp:ListItem>Audiência 1</asp:ListItem>
                        <asp:ListItem>Audiência 2</asp:ListItem>
                        <asp:ListItem>Rateio final</asp:ListItem>
                    </asp:ListBox>
                </div>
            </div>

            <div id="OnlineUsersHomeBox">
                <div class="AlignBox">
                     <div class="titleHhome"> <h3>Utilizadores Online</h3> </div>
                    <asp:ListBox ID="OnlineUsersListID" runat="server" Cssclass="OnlineUsers-Item">
                        <asp:ListItem>Zé</asp:ListItem>
                        <asp:ListItem>Tiago</asp:ListItem>
                        <asp:ListItem>Óscar</asp:ListItem>
                        <asp:ListItem>Joel</asp:ListItem>
                    </asp:ListBox>
                </div>
            </div>

            <div id="DayDetailHomeBox">
                <div class="AlignBox">
                     <div class="titleHhome"> <h3>Detalhes do dia</h3> </div>
                    <asp:Table ID="DayDetailTableID" runat="server" Cssclass="DayDetail-Item">
                        <asp:TableRow>
                            <asp:TableCell>Dia 2 - Reunião com advogada</asp:TableCell>
                            <asp:TableCell>Dia 3 - Reunião com credores</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
           </div>

            <div id="LastAccessesHomeBox">
                <div class="AlignBox">
                     <div class="titleHhome"> <h3>Últimos Acessos</h3> </div>
                    <asp:Table ID="LastAccessesTableID" runat="server" Cssclass="LastAccesses-Item">
                        <asp:TableRow>
                            <asp:TableCell>Dia 12 ás 17:00h</asp:TableCell>
                            <asp:TableCell>Dia 21 ás 18:00h</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>
	   
                <div id="FooterBox">
                    <div id="FooterBox2">
                        <% 
                            Response.WriteFile("../html/footer.html");
                        %>
                    </div>
                </div>

        </div>
    </form>
</body>
</html>
