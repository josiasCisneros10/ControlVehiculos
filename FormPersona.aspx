﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormPersona.aspx.vb" Inherits="ControlVehiculos.FormPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="editando" runat="server"/> 

<div class="container d-flex flex-column mb-3 gap-2">

    <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtApellido1" CssClass="form-control" placeholder="Primer Apellido" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtApellido2" CssClass="form-control" placeholder="Segundo Apellido" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtNacionalidad" CssClass="form-control" placeholder="Nacionalidad" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtFechanac" TextMode="Date" CssClass="form-control" placeholder="Fecha de Nacimiento" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtTelefono" CssClass="form-control" placeholder="Telefono" runat="server"></asp:TextBox>
    
    

    <asp:Button ID="btnGuardar" runat="server" CssClass="btn btn-primary btn-hover-move" Text="Guardar" OnClick="btn_guardar" />
    <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-primary btn-hover-move" Text="Actualizar" OnClick="btnActualizar_Click" />
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

</div>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:II-46ConnectionString %>" 
    SelectCommand="SELECT * FROM [Personas]"></asp:SqlDataSource>
 
    <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False" DataKeyNames="idPersona" DataSourceID="SqlDataSource1"
        OnRowDeleting="gvPersonas_RowDeleting" OnRowCancelingEdit="gvPersonas_RowCancelingEdit" OnRowUpdating="gvPersonas_RowUpdating" 
        OnSelectedIndexChanged="gvPersonas_SelectedIndexChanged"
        Width="1462px">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ControlStyle-CssClass ="btn btn-success" />
            <asp:CommandField ShowEditButton="true" ControlStyle-CssClass ="btn btn-primary" />
            <asp:BoundField DataField="idPersona" HeaderText="idPersona" InsertVisible="False" ReadOnly="True" SortExpression="idPersona" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Apellido1" HeaderText="Apellido1" SortExpression="Apellido1" />
            <asp:BoundField DataField="Apellido2" HeaderText="Apellido2" SortExpression="Apellido2" />
            <asp:BoundField DataField="Nacionalidad" HeaderText="Nacionalidad" SortExpression="Nacionalidad" />
            <asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
            <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass ="btn btn-danger" />
        </Columns>
    </asp:GridView>
</asp:Content>



