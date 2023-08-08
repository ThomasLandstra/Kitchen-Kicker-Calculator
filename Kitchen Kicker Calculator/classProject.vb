Public Class Project
    ' VARIABLES
    Private _svSaveFile As SaveFile

    Private _lkeKitchenElements As New List(Of KitchenElement)({})

    ' PROPERTIES
    '' Basic properties
    Public Property KitchenElements As List(Of KitchenElement)
        Get
            Return _lkeKitchenElements
        End Get
        Set(lkeKitchenElements As List(Of KitchenElement))
            _lkeKitchenElements = lkeKitchenElements
            _svSaveFile.IsSaved = False
        End Set
    End Property

    '' Output properties
    Public ReadOnly Property SheetsUsed As Byte
        Get
            ' How many strips per sheet
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / dstrHeight.Millimetres)

            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenFr.Millimetres)
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenBa.Millimetres)
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenCr.Millimetres)

            Dim ui16RequiredFr As UInt16
            Dim ui16RequiredBa As UInt16
            Dim ui16RequiredCr As UInt16

            For Each ke In KitchenElements
                ui16RequiredFr += ke.FrontBoards + ke.ExtraFrontBoards
                ui16RequiredBa += ke.BackBoards + ke.ExtraBackBoards
                ui16RequiredCr += ke.CrossBraces + ke.ExtraCrossBraces
            Next

            Dim ui16StripsNeeded As UInt16
            ui16StripsNeeded += Math.Ceiling(ui16RequiredFr / bytFrPerStrip)
            ui16StripsNeeded += Math.Ceiling(ui16RequiredBa / bytBaPerStrip)
            ui16StripsNeeded += Math.Ceiling(ui16RequiredCr / bytCrPerStrip)

            ' What if room left over uhhhh
            ' Fuck it just for loop it or something

            Return Math.Ceiling(ui16StripsNeeded / bytStripsPerSheet)
        End Get
    End Property
    Public ReadOnly Property CutsMade As Byte
    Public ReadOnly Property WasteSquareMillimetreage As UInt32
        Get
            Dim ui16RequiredFr As UInt16
            Dim ui16RequiredBa As UInt16
            Dim ui16RequiredCr As UInt16

            For Each ke In KitchenElements
                ui16RequiredFr += ke.FrontBoards + ke.ExtraFrontBoards
                ui16RequiredBa += ke.BackBoards + ke.ExtraBackBoards
                ui16RequiredCr += ke.CrossBraces + ke.ExtraCrossBraces
            Next

            Dim ui32AreaFr As UInt32 = Convert.ToUInt32(dstrLenFr.Millimetres) * dstrHeight.Millimetres
            Dim ui32AreaBa As UInt32 = Convert.ToUInt32(dstrLenBa.Millimetres) * dstrHeight.Millimetres
            Dim ui32AreaCr As UInt32 = Convert.ToUInt32(dstrLenCr.Millimetres) * dstrHeight.Millimetres

            Dim ui32AreaRequired As UInt32 = ui32AreaFr * ui16RequiredFr + ui32AreaBa * ui16RequiredBa + ui32AreaCr * ui16RequiredCr

            Dim ui32AreaTotal As UInt32 = Convert.ToUInt32(dstrSrcLength.Millimetres) * dstrSrcWidth.Millimetres * SheetsUsed

            Return ui32AreaTotal - ui32AreaRequired
        End Get
    End Property

    '' Save properties
    Public ReadOnly Property SaveFile As SaveFile
        Get
            Return _svSaveFile
        End Get
    End Property

    ' METHODS
    Public Sub New(Optional strProjectFilePath As String = "")
        NewSave(strProjectFilePath)
    End Sub

    Public Sub NewSave(strProjectFilePath As String)
        _svSaveFile = New SaveFile(Me, strProjectFilePath)
    End Sub

    Public Function NewKitchenElement() As KitchenElement
        Dim strNewKitchenElementsCount As String = (KitchenElements.Count + 1).ToString
        Dim strNewElementName As String = "Element " & strNewKitchenElementsCount
        KitchenElements.Add(New KitchenElement(strNewElementName, Me))
        Return KitchenElements.Last
    End Function
End Class
