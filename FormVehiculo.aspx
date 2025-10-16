<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormVehiculo.aspx.vb" Inherits="ControlVehiculos.FormVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:HiddenField ID="editando" runat="server"/> 

    <div class="container d-flex flex-column mb-3 gap-2">

    <asp:TextBox ID="txtMarca" CssClass="form-control" placeholder="Marca" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtModelo" CssClass="form-control" placeholder="Modelo" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtAnio" CssClass="form-control" placeholder="Año" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtColor" CssClass="form-control" placeholder="Color" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPlaca" CssClass="form-control" placeholder="Placa" runat="server"></asp:TextBox>
    
    

    <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary btn-hover-move" Text="Guardar" OnClick="btn_guardar" />
    <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-primary btn-hover-move" Text="Actualizar" OnClick="btnActualizar_Click" />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:II-46ConnectionString %>" 
    SelectCommand="SELECT * FROM [Vehiculo]"></asp:SqlDataSource>
 
        <asp:GridView ID="gvVehiculo" runat="server" AutoGenerateColumns="False" DataKeyNames="idVehiculo" DataSourceID="SqlDataSource1"
         OnRowDeleting="gvVehiculo_RowDeleting" OnRowEditing="gvVehiculo_RowEditing" OnRowCancelingEdit="gvVehiculo_RowCancelingEdit"
         OnRowUpdating="gvVehiculo_RowUpdating" OnSelectedIndexChanged="gvVehiculo_SelectedIndexChanged"
        Width="1392px">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass ="btn btn-success" />
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass ="btn btn-primary" />
            <asp:BoundField DataField="idVehiculo" HeaderText="idVehiculo" InsertVisible="False" ReadOnly="True" SortExpression="idVehiculo" />
            <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
            <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
            <asp:BoundField DataField="Anio" HeaderText="Anio" SortExpression="Anio" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="Placa" HeaderText="Placa" SortExpression="Placa" />
            <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass ="btn btn-danger" />
        </Columns>
    </asp:GridView>
</asp:Content>
