Public Class SaveFile
    ' VARIABLES
    Dim _prjProject As Project
    Private _strFilePath As String

    Dim _boolIsSaved As Boolean = True

    ' PROPERTIES
    Public Property IsSaved As Boolean
        Get
            Return _boolIsSaved
        End Get
        Set(boolIsSaved As Boolean)
            ' Should only be able to set _boolIsSaved to False
            If boolIsSaved = False Then
                _boolIsSaved = boolIsSaved
            End If
        End Set
    End Property

    Public Property FilePath As String
        Get
            Return _strFilePath
        End Get
        Set(strFilePath As String)
            _strFilePath = strFilePath
        End Set
    End Property

    ' METHODS
    Public Sub New(prjProject As Project, strFilePath As String)
        _prjProject = prjProject
        _strFilePath = strFilePath
    End Sub

    Public Function Save() As SaveResult
        If _strFilePath = "" Then Return SaveResult.InvalidPath

        Dim strSaveString As String = My.Resources.csvSaveTemplate.Split(vbLf)(0)

        For Each ke As KitchenElement In _prjProject.KitchenElements
            Dim strElement As String = ""
            strElement &= ke.Name & ","
            strElement &= Str(ke.LinearMillimetres) & ","
            strElement &= Str(ke.SpareFrontBoards) & ","
            strElement &= Str(ke.SpareBackBoards) & ","
            strElement &= Str(ke.SpareCrossBraces)
            strSaveString = strSaveString & vbLf & strElement
        Next

        Dim fileSave As IO.StreamWriter
        fileSave = My.Computer.FileSystem.OpenTextFileWriter(_strFilePath, False)
        fileSave.Write(strSaveString)
        fileSave.Close()

        _boolIsSaved = True
        Return SaveResult.Success
    End Function
End Class
