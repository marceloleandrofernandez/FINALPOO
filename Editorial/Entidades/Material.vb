Public MustInherit Class Material
    Private _titulo As String
    Private _montoContrato As Decimal
    Shared _porcentajeEditorPorBorrador As Byte
    Shared _PorcentajeEditorPorLibro As Byte
    Private Property _Editor As Editor ' property esta de mas
    Private Property _Autores As List(Of Autor) 'property esta de mas
    ' autores debe ser protected

    Public Property Editor As Editor
        Get
            Return _Editor
        End Get
        Friend Set(value As Editor)
            _Editor = value
        End Set
    End Property
    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(value As String)
            If value.Length < 3 Or value.Length > 256 Then
                Throw New ArgumentException("Mayor a 3 y menor a 256 Caracteres")
            End If
            _titulo = value
        End Set
    End Property
    Public Property MontoContrato As Decimal
        Get
            Return _montoContrato
        End Get
        Set(value As Decimal)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos")
            End If
            _montoContrato = value
        End Set
    End Property
    Shared Property PorcentajeEditorPorBorrador As Byte
        Get
            Return _porcentajeEditorPorBorrador
        End Get
        Set(value As Byte)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos")
            Else
                _porcentajeEditorPorBorrador = value
            End If

        End Set
    End Property
    Shared Property PorcentajeEditorPorLibro As Byte
        Get
            Return _PorcentajeEditorPorLibro
        End Get
        Set(value As Byte)
            If value < 0 Then
                Throw New ArgumentException("no se admiten Valores Negativos")
            Else
                _PorcentajeEditorPorLibro = value
            End If
        End Set
    End Property
    Sub New(titulo As String, montoContrato As Decimal)
        Me.Titulo = titulo
        Me.MontoContrato = montoContrato
        _Autores = New List(Of Autor)
    End Sub
    'Public Sub AddAutor(autor As Autor) ' Corregido
    Friend Sub AddAutor(autor As Autor)
        _Autores.Add(autor)
    End Sub
    'Public Sub removeAutor(autor As Autor) ' corregido
    Friend Sub removeAutor(autor As Autor)
        'autor.AddMaterial(Nothing) esta de mas ya que la responsabilidad esta en autor
        _Autores.Remove(autor)
    End Sub
    Public Function getALLAutores() As List(Of Autor)
        Return _Autores
    End Function

    Public MustOverride Function GananciaPorcentajePorAutor() As Byte

    'Public Function GananciaEditor() As Byte ' corregido
    Public Function GananciaEditor() As Decimal
        'Return False ' correccion
        If TypeOf Me Is Borrador Then
            Return MontoContrato * PorcentajeEditorPorBorrador / 100
        Else
            Return MontoContrato * PorcentajeEditorPorLibro / 100
        End If
    End Function
End Class
