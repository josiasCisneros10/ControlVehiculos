Public Class Vehiculo
    Private _idVehiculo As Integer
    Private _marca As String
    Private _modelo As String
    Private _anio As String
    Private _color As String
    Private _placa As String

    Public Sub New()
    End Sub

    Public Sub New(idVehiculo As Integer, marca As String, modelo As String, anio As String, color As String, placa As String)
        Me.IdVehiculo = idVehiculo
        Me.Marca = marca
        Me.Modelo = modelo
        Me.Anio = anio
        Me.Color = color
        Me.Placa = placa
    End Sub

    Public Property IdVehiculo As Integer
        Get
            Return _idVehiculo
        End Get
        Set(value As Integer)
            _idVehiculo = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Anio As String
        Get
            Return _anio
        End Get
        Set(value As String)
            _anio = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property Placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property
End Class
