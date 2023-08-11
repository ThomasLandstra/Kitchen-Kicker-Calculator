Public Class DistanceTextBox
    Inherits EscapableTextBox

    ' PRIVATE VARIABLES
    ReadOnly _dstrDistance As New DistanceString()



    ' PRIVATE EVENT HANDLERS
    Private Sub FocusWasLost() Handles Me.LostFocus
        _dstrDistance.Text = Text
        Text = _dstrDistance.Text
    End Sub



    ' PUBLIC PROPERTIES
    '' interfaces with distance text object
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(strText As String)
            MyBase.Text = strText
            _dstrDistance.Text = MyBase.Text
        End Set
    End Property
    Public Property Millimetres As UInt16
        Get

            Return _dstrDistance.Millimetres
        End Get
        Set(ui16Millimetres As UInt16)
            _dstrDistance.Millimetres = ui16Millimetres
            Text = _dstrDistance.Text
        End Set
    End Property
    Public Property Unit As String
        Get
            Return _dstrDistance.Unit
        End Get
        Set(strUnit As String)
            _dstrDistance.Unit = strUnit
            Text = _dstrDistance.Text
        End Set
    End Property



    ' METHODS
    Public Sub New()
        MyBase.New()
    End Sub
End Class
