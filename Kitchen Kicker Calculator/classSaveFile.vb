Public Class SaveFile
    ' PRIVATE VARIABLES
    Dim _prjProject As Project
    Dim _strFilePath As String
    Dim _boolIsSaved As Boolean = True



    ' PROPERTIES
    Public Property IsSaved As Boolean
        Get
            Return _boolIsSaved
        End Get
        Set(boolIsSaved As Boolean)
            _boolIsSaved = boolIsSaved
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
        ' Check to see if path is valid
        If _strFilePath = "" Then Return SaveResult.InvalidPath

        ' Make the string to be saved
        Dim strSaveString As String = My.Resources.csvSaveTemplate.Split(vbLf)(0)

        ' Add each kitchen elements info to a row in csv format
        For Each ke As KitchenElement In _prjProject.KitchenElements
            Dim strElement As String = ""
            strElement &= ke.Name & ","
            strElement &= Str(ke.LinearMillimetres) & ","
            strElement &= Str(ke.SpareFrontBoards) & ","
            strElement &= Str(ke.SpareBackBoards) & ","
            strElement &= Str(ke.SpareCrossBraces)
            strSaveString = strSaveString & vbLf & strElement
        Next

        ' Write the string to the file
        Dim fileSave As IO.StreamWriter
        fileSave = My.Computer.FileSystem.OpenTextFileWriter(_strFilePath, False)
        fileSave.Write(strSaveString)
        fileSave.Close()

        ' Set is saved to true and return a success message
        _boolIsSaved = True
        Return SaveResult.Success
    End Function
End Class
