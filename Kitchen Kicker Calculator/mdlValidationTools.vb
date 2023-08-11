Module mdlValidationTools
    ' OUTPUT TOOLS
    Public Sub Warning(strText As String)
        MsgBox(strText, vbExclamation)
    End Sub



    ' INPUT TOOLS
    Function IsPathNothing(strString As String) As Boolean
        ' Determines if the string is Nothing or empty
        If strString Is Nothing Then
            Return True
        ElseIf strString = "" Then
            Return True
        End If

        Return False
    End Function

    Function IsValidCSV(astrFileLines As String()) As Boolean
        ' NOTE: This does NOT accept CSV files with trailing commas

        ' Ensure that there are at least 2 lines
        If astrFileLines.Length < 2 Then Return False
        ' Ensure the header matches the header of the save template
        If astrFileLines(0) <> My.Resources.csvSaveTemplate.Split(vbLf)(0) Then Return False

        Dim bytNumberOfCommas As Byte = My.Resources.csvSaveTemplate.Split(",").Length

        For Each strLine In astrFileLines.Skip(1)
            ' Does each line contain a valid number of values (i.e the same number of commas)
            Dim astrValues As String() = strLine.Split(",")
            If astrValues.Length <> bytNumberOfCommas Then
                Return False
            End If

            ' Do numeric columns/cells contain numeric values
            Dim abytColumns As Byte() = {1, 2, 3, 4}
            For Each bytColumn In abytColumns
                If Not IsNumeric(astrValues(bytColumn)) Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function
End Module
