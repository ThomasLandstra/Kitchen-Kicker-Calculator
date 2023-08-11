Public Class Project
    ' PRIVATE VARIABLES
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
    Public ReadOnly Property TotalFrontBoards As UInt16
        Get ' Add up all the front boards from every kitche element
            Dim ui16RequiredFr As UInt16
            For Each ke In KitchenElements
                ui16RequiredFr += ke.FrontBoards + ke.SpareFrontBoards
            Next
            Return ui16RequiredFr
        End Get
    End Property
    Public ReadOnly Property TotalBackBoards As UInt16
        Get ' Add up all the back boards from every kitche element
            Dim ui16RequiredBa As UInt16
            For Each ke In KitchenElements
                ui16RequiredBa += ke.BackBoards + ke.SpareBackBoards
            Next
            Return ui16RequiredBa
        End Get
    End Property
    Public ReadOnly Property TotalCrossBraces As UInt16
        Get ' Add up all the cross braces from every kitche element
            Dim ui16RequiredCr As UInt16
            For Each ke In KitchenElements
                ui16RequiredCr += ke.CrossBraces + ke.SpareCrossBraces
            Next
            Return ui16RequiredCr
        End Get
    End Property
    Public ReadOnly Property SheetsUsed As Byte
        Get
            ' How many strips per sheet (short side length /(height + cut width))
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / (dstrHeight.Millimetres + dstrCutWidth.Millimetres))

            ' How many of each componenet can fit in a strip
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenFr.Millimetres + dstrCutWidth.Millimetres))
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenBa.Millimetres + dstrCutWidth.Millimetres))
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenCr.Millimetres + dstrCutWidth.Millimetres))

            ' Find how many strips are required to make every part
            Dim ui16StripsNeeded As UInt16
            ui16StripsNeeded += Math.Ceiling(TotalFrontBoards / bytFrPerStrip)
            ui16StripsNeeded += Math.Ceiling(TotalBackBoards / bytBaPerStrip)
            ui16StripsNeeded += Math.Ceiling(TotalCrossBraces / bytCrPerStrip)

            ' Find out how many sheets are required for strips
            ' (strips needed / strips per sheet)
            Return Math.Ceiling(ui16StripsNeeded / bytStripsPerSheet)
        End Get
    End Property
    Public ReadOnly Property CutsMade As UInt16
        Get
            ' NOTE:
            ' Every strip will need 1 on its right unless a sheet can hold
            ' strips with no waste leftover, in which case the last strip
            ' will not need a cut as it will be next to an edge. The same
            ' principal applies to components in each strip

            ' Find how many strips per sheet
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / (dstrHeight.Millimetres + dstrCutWidth.Millimetres))

            ' Check if the short side can be divided evenly with no waste
            Dim boolIsSheetPerfectFit As Boolean = Not ui16LenShortSide - (bytStripsPerSheet * (dstrHeight.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres)

            ' How many of each componenet can fit in a strip
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenFr.Millimetres + dstrCutWidth.Millimetres))
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenBa.Millimetres + dstrCutWidth.Millimetres))
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenCr.Millimetres + dstrCutWidth.Millimetres))

            ' Find how many strips are required to make every part
            Dim ui16StripsNeeded As UInt16
            ui16StripsNeeded += Math.Ceiling(Me.TotalFrontBoards / bytFrPerStrip)
            ui16StripsNeeded += Math.Ceiling(Me.TotalBackBoards / bytBaPerStrip)
            ui16StripsNeeded += Math.Ceiling(Me.TotalCrossBraces / bytCrPerStrip)

            ' Find out how many whole boards are required
            ' Rounding down: strips needed / strips per sheet
            Dim bytWholeBoards As Byte = Math.Floor(ui16StripsNeeded / bytStripsPerSheet)

            ' Find out how many strips cannot fit perfectly into sheets
            Dim bytRemainingStrips As Byte = ui16StripsNeeded Mod bytStripsPerSheet

            ' whole boards used * (strips per sheet - (1 if is a perfect fir)) + remaining strips
            Dim ui16LongCuts As UInt16 = (bytWholeBoards * (bytStripsPerSheet - boolIsSheetPerfectFit)) + bytRemainingStrips

            ' Calculate cuts from each part
            Dim ui16ShortCuts As UInt16 = 0
            ui16ShortCuts += Me.TotalFrontBoards + Me.TotalCrossBraces + Me.TotalBackBoards

            Return ui16ShortCuts + ui16LongCuts
        End Get
    End Property

    Public ReadOnly Property WasteSquareMillimetreage As UInt32
        Get
            ' Find the area taken up by each componenet
            Dim ui32AreaFr As UInt32 = Convert.ToUInt32(dstrLenFr.Millimetres) * dstrHeight.Millimetres
            Dim ui32AreaBa As UInt32 = Convert.ToUInt32(dstrLenBa.Millimetres) * dstrHeight.Millimetres
            Dim ui32AreaCr As UInt32 = Convert.ToUInt32(dstrLenCr.Millimetres) * dstrHeight.Millimetres

            Dim ui32AreaRequired As UInt32 = ui32AreaFr * Me.TotalFrontBoards + ui32AreaBa * Me.TotalBackBoards + ui32AreaCr * Me.TotalCrossBraces

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
