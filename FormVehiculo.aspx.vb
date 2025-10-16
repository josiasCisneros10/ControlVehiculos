Public Class FormVehiculo
    Inherits System.Web.UI.Page
    Public vehiculo As New Vehiculo()
    Protected dbVehiculo As New dbVehiculo

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_guardar(sender As Object, e As EventArgs)
        Dim vehiculo As New Vehiculo()

        vehiculo.Marca = txtMarca.Text
        vehiculo.Modelo = txtModelo.Text
        vehiculo.Anio = TxtAnio.Text
        vehiculo.Color = txtColor.Text
        vehiculo.Placa = txtPlaca.Text

        If dbVehiculo.create(vehiculo) Then
            lblMensaje.Text = "Vehiculo guardado correctamente."
            gvVehiculo.DataBind()
        Else
            lblMensaje.Text = "Error al guardar vehiculo."
        End If
    End Sub


    Protected Sub gvVehiculo_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)

        Try
            Dim id As Integer = Convert.ToInt32(gvVehiculo.DataKeys(e.RowIndex).Value)
            dbVehiculo.delete(id)
            e.Cancel = True
            gvVehiculo.DataBind()
        Catch ex As Exception
            lblMensaje.Text = "Error al eliminar el vehiculo: " & ex.Message
        End Try

    End Sub

    Protected Sub gvVehiculo_RowEditing(sender As Object, e As GridViewEditEventArgs)



    End Sub

    Protected Sub gvVehiculo_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs)

        gvVehiculo.EditIndex = -1
        gvVehiculo.DataBind()

    End Sub

    Protected Sub gvVehiculo_RowUpdating(sender As Object, e As GridViewUpdateEventArgs)

        Dim id As Integer = Convert.ToInt32(gvVehiculo.DataKeys(e.RowIndex).Value)
        Dim vehiculo As Vehiculo = New Vehiculo With {
            .Marca = e.NewValues("Marca"),
            .Modelo = e.NewValues("Modelo"),
            .Anio = e.NewValues("Anio"),
            .Color = e.NewValues("Color"),
            .Placa = e.NewValues("Placa"),
            .IdVehiculo = id
        }
        dbVehiculo.update(vehiculo)
        gvVehiculo.DataBind()
        e.Cancel = True
        gvVehiculo.EditIndex = -1
    End Sub

    Protected Sub gvVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim row As GridViewRow = gvVehiculo.SelectedRow()
        Dim id As Integer = Convert.ToInt32(row.Cells(2).Text)
        Dim vehiculo As Vehiculo = New Vehiculo()

        txtMarca.Text = row.Cells(3).Text
        txtModelo.Text = row.Cells(4).Text
        TxtAnio.Text = row.Cells(5).Text
        txtColor.Text = row.Cells(6).Text
        txtPlaca.Text = row.Cells(7).Text
        editando.Value = id

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs)
        Dim vehiculo As New Vehiculo()

        vehiculo.Marca = txtMarca.Text
        vehiculo.Modelo = txtModelo.Text
        vehiculo.Anio = TxtAnio.Text
        vehiculo.Color = txtColor.Text
        vehiculo.Placa = txtPlaca.Text
        vehiculo.IdVehiculo = Convert.ToInt32(editando.Value)

        dbVehiculo.update(vehiculo)
        gvVehiculo.DataBind()
        gvVehiculo.EditIndex = -1
    End Sub
End Class