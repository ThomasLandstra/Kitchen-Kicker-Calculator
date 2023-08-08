Public Class DistanceString
    Dim _strUnit As String = "m"
    Dim _ui16Millimeters As UInt16 = 0

    Private Function ValidateUnit(strUnit As String) As Boolean
        If {"mm", "cm", "m"}.Contains(strUnit) Then
            Return True
        Else
            Warning("'" & strUnit & "' is not a valid unit of measurement. Please use 'mm', 'cm' or 'm'")
            Return False
        End If
    End Function

    Public Property Unit As String
        Get
            Return _strUnit
        End Get
        Set(strUnit As String)
            strUnit = strUnit.ToLower()
            If ValidateUnit(strUnit) Then
                _strUnit = strUnit
            End If
        End Set
    End Property

    Public Property Millimetres As UInt16
        Get
            Return _ui16Millimeters
        End Get
        Set(ui16Distance As UInt16)
            _ui16Millimeters = ui16Distance
        End Set
    End Property

    Public Property Text As String
        Get
            Dim dblDistanceInUnit As Double = _ui16Millimeters
            Select Case _strUnit
                Case "cm"
                    dblDistanceInUnit /= 10
                Case "m"
                    dblDistanceInUnit /= 1000
            End Select

            Return Str(dblDistanceInUnit) & " " & _strUnit
        End Get
        Set(strText As String)
            'Clean string of spaces
            strText = strText.Trim()
            While strText.Contains("  ")
                strText = strText.Replace("  ", " ")
            End While

            ' Ensure only one space remains
            Dim astrTextSplit As String() = strText.Split(" ")
            If astrTextSplit.Length <> 2 Then
                Warning("There can only be two words in the distance")
                Exit Property
            End If

            ' Ensure value unit is valid
            If Not ValidateUnit(astrTextSplit.Last) Then Exit Property

            ' Ensure value is valid
            Dim dblValue As Double = Val(astrTextSplit(0))

            Select Case astrTextSplit.Last
                Case "mm"
                    dblValue = Math.Floor(dblValue)
                Case "cm"
                    dblValue = Math.Floor(dblValue * 10)
                Case "m"
                    dblValue = Math.Floor(dblValue * 1000)
            End Select

            If dblValue < 0 Then
                Warning("Value must be larger than 0")
                Exit Property
            ElseIf dblValue > 65535 Then
                ' 65535 is the largest value an unsigned 16 bit
                ' integar can hold in memory
                Warning("Maximum distance is 65535mm")
                Exit Property
            End If

            Unit = astrTextSplit.Last
            Millimetres = dblValue
        End Set
    End Property

    Public Sub New(Optional strText = "0.0 m")
        Text = strText
    End Sub
End Class

