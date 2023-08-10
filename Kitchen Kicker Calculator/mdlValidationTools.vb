Imports System.Net.Mail

Module mdlValidationTools
    ' OUTPUT TOOLS
    Public Sub Warning(strText As String)
        MsgBox(strText, vbExclamation)
    End Sub

    ' INPUT TOOLS

    Function IsPathNothing(strName As String) As Boolean
        ' Determines if the name is Nothing.
        If strName Is Nothing Then
            Return True
        ElseIf strName = "" Then
            Return True
        End If

        Return False
    End Function

    Function IsValidCSV(astrFileLines As String()) As Boolean
        If astrFileLines.Length < 2 Then Return False
        If astrFileLines(0) <> My.Resources.csvSaveTemplate.Split(vbLf)(0) Then Return False

        Dim bytCommas As Byte = My.Resources.csvSaveTemplate.Split(",").Length

        For Each strLine In astrFileLines.Skip(1)
            ' Does each line contain a valid number of values
            Dim astrValues As String() = strLine.Split(",")
            If astrValues.Length <> bytCommas Then
                Return False
            End If

            ' Do numeric columns contain numeric values
            Dim abytColumns As Byte() = {1, 2, 3, 4}
            For Each bytColumn In abytColumns
                If Not IsNumeric(astrValues(bytColumn)) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Sub InvalidSrcLengthWarning(strLength As String)
        Warning("To make this change the source sheet must have one side length of at least " & strLength)
    End Sub

    Public Function IsValidSrcLengths(dstrSide1, dstrSide2) As Boolean
        Dim ui16Longest As UInt16 = Math.Max(dstrSide1.Millimetres, dstrSide2.Millimetres)
        Dim ui16Shortest As UInt16 = Math.Min(dstrSide1.Millimetres, dstrSide2.Millimetres)

        ' Ensure that the longest side is long enough for components
        If dstrLenFr.Millimetres + dstrCutWidth.Millimetres > ui16Longest Then
            InvalidSrcLengthWarning(dstrLenFr.Text)
            Return False
        ElseIf dstrLenBa.Millimetres + dstrCutWidth.Millimetres > ui16Longest Then
            InvalidSrcLengthWarning(dstrLenBa.Text)
            Return False
        ElseIf dstrLenCr.Millimetres + dstrCutWidth.Millimetres > ui16Longest Then
            InvalidSrcLengthWarning(dstrLenCr.Text)
            Return False
        End If

        ' Ensure short side is long enough for kitchen length
        If dstrHeight.Millimetres > ui16Longest Then
            Warning("To make this change the source sheet's shortest side must be larger than " & dstrLenCr.Text)
            Return False
        End If

        Return True

    End Function
End Module
