Public Class FormPersona
    Inherits System.Web.UI.Page
    Public persona As New Persona()
    Protected dbPersona As New dbPersona

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_guardar(sender As Object, e As EventArgs)
        Dim persona As New Persona()

        persona.Nombre = txtNombre.Text
        persona.Apellido1 = txtApellido1.Text
        persona.Apellido2 = TxtApellido2.Text
        persona.Nacionalidad = txtNacionalidad.Text
        persona.Telefono = txtTelefono.Text

        Dim fechaNacimiento As DateTime
        If DateTime.TryParse(txtFechanac.Text, fechaNacimiento) Then
            persona.FechaNacimiento = fechaNacimiento
        Else
            lblMensaje.Text = "Fecha de nacimiento inválida."
            Exit Sub
        End If

        If dbPersona.create(persona) Then
            lblMensaje.Text = "Persona guardada correctamente."
            gvPersonas.DataBind()
        Else
            lblMensaje.Text = "Error al guardar persona."
        End If
    End Sub


    Protected Sub gvPersonas_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)

        Try
            Dim id As Integer = Convert.ToInt32(gvPersonas.DataKeys(e.RowIndex).Value)
            dbPersona.delete(id)
            e.Cancel = True
            gvPersonas.DataBind()
        Catch ex As Exception
            lblMensaje.Text = "Error al eliminar la persona: " & ex.Message
        End Try

    End Sub

    Protected Sub gvPersonas_RowEditing(sender As Object, e As GridViewEditEventArgs)



    End Sub

    Protected Sub gvPersonas_RowCancelingEdit(sender As Object, e As GridViewCancelEditEventArgs)

        gvPersonas.EditIndex = -1
        gvPersonas.DataBind()


    End Sub

    Protected Sub gvPersonas_RowUpdating(sender As Object, e As GridViewUpdateEventArgs)


        Dim id As Integer = Convert.ToInt32(gvPersonas.DataKeys(e.RowIndex).Value)
        Dim persona As Persona = New Persona With {
            .Nombre = e.NewValues("Nombre"),
            .Apellido1 = e.NewValues("Apellido1"),
            .Apellido2 = e.NewValues("Apellido2"),
            .Nacionalidad = e.NewValues("Nacionalidad"),
            .FechaNacimiento = e.NewValues("FechaNacimiento"),
            .Telefono = e.NewValues("Telefono"),
            .IdPersona = id
        }
        dbPersona.update(persona)
        gvPersonas.DataBind()
        e.Cancel = True
        gvPersonas.EditIndex = -1
    End Sub

    Protected Sub gvPersonas_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim row As GridViewRow = gvPersonas.SelectedRow()
        Dim id As Integer = Convert.ToInt32(row.Cells(2).Text)
        Dim persona As Persona = New Persona()

        txtNombre.Text = row.Cells(3).Text
        txtApellido1.Text = row.Cells(4).Text
        TxtApellido2.Text = row.Cells(5).Text
        txtNacionalidad.Text = row.Cells(6).Text
        txtFechanac.Text = row.Cells(7).Text
        txtTelefono.Text = row.Cells(8).Text
        editando.Value = id

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs)
        Dim persona As New Persona()

        persona.Nombre = txtNombre.Text
        persona.Apellido1 = txtApellido1.Text
        persona.Apellido2 = TxtApellido2.Text
        persona.Nacionalidad = txtNacionalidad.Text
        persona.Telefono = txtTelefono.Text
        persona.IdPersona = Convert.ToInt32(editando.Value)

        Dim fechaNacimiento As DateTime
        If DateTime.TryParse(txtFechanac.Text, fechaNacimiento) Then
            persona.FechaNacimiento = fechaNacimiento
        Else
            lblMensaje.Text = "Fecha inválida."
            Exit Sub
        End If

        dbPersona.update(persona)
        gvPersonas.DataBind()
        gvPersonas.EditIndex = -1
    End Sub

End Class