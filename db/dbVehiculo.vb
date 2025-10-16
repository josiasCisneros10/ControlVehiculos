Imports System.Data.SqlClient

Public Class dbVehiculo
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("II-46ConnectionString").ConnectionString
    Public Function create(Vehiculo As Vehiculo) As Boolean
        Try
            Dim sql As String = "INSERT INTO Vehiculo (Marca, Modelo, Anio, Color, Placa) VALUES (@Marca, @Modelo, @Anio, @Color, @Placa)"
            Dim Parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Marca", Vehiculo.Marca),
            New SqlParameter("Modelo", Vehiculo.Modelo),
            New SqlParameter("@Anio", Vehiculo.Anio),
            New SqlParameter("@Color", Vehiculo.Color),
            New SqlParameter("@Placa", Vehiculo.Placa)
            }

            Using connetion As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connetion)
                    command.Parameters.AddRange(Parametros.ToArray())
                    connetion.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function delete(ByRef id As Integer) As String
        Try
            Dim sql As String = "DELETE FROM Vehiculo WHERE idVehiculo = @idVehiculo"
            Dim Parametros As New List(Of SqlParameter) From {
            New SqlParameter("@idVehiculo", id)
        }
            Using connetion As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connetion)
                    command.Parameters.AddRange(Parametros.ToArray())
                    connetion.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return "Vehiculo eliminado"
    End Function

    Public Function update(ByRef Vehiculo As Vehiculo) As String
        Try
            Dim sql As String = "UPDATE Vehiculo SET Marca = @Marca, Modelo = @Modelo, Anio = @Anio, Color = @Color, Placa = @Placa WHERE idVehiculo = @idVehiculo"
            Dim Parametros As New List(Of SqlParameter) From {
            New SqlParameter("@idVehiculo", Vehiculo.IdVehiculo),
            New SqlParameter("@Marca", Vehiculo.Marca),
            New SqlParameter("@Modelo", Vehiculo.Modelo),
            New SqlParameter("@Anio", Vehiculo.Anio),
            New SqlParameter("@Color", Vehiculo.Color),
            New SqlParameter("@Placa", Vehiculo.Placa)
            }

            Using connetion As New SqlConnection(connectionString)
                Using command As New SqlCommand(sql, connetion)
                    command.Parameters.AddRange(Parametros.ToArray())
                    connetion.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return "Vehiculo actualizado"
    End Function
End Class
