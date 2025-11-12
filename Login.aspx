<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="ControlVehiculos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Iniciar Sesión</h2>
    <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    <asp:Panel ID="PanelLogin" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label></td>
                <td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblContrasena" runat="server" Text="Contraseña:"></asp:Label></td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" OnClick="btnIniciarSesion_Click1" />
                </td>
            </tr>
        </table>
    </asp:Panel>
   
</asp:Content>
