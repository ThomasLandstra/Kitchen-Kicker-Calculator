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

            ' Do the strips but perfectly
            If (bytStripsPerSheet + 1) * (dstrHeight.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenShortSide Then
                bytStripsPerSheet += 1
            End If

            ' How many of each componenet can fit in a strip
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenFr.Millimetres + dstrCutWidth.Millimetres))
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenBa.Millimetres + dstrCutWidth.Millimetres))
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenCr.Millimetres + dstrCutWidth.Millimetres))

            ' Check if any of the strips fit perfectly
            If (bytFrPerStrip + 1) * (dstrLenFr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytFrPerStrip += 1
            End If
            If (bytBaPerStrip + 1) * (dstrLenBa.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytBaPerStrip += 1
            End If
            If (bytCrPerStrip + 1) * (dstrLenCr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytBaPerStrip += 1
            End If

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
            ' How many strips per sheet (short side length /(height + cut width))
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / (dstrHeight.Millimetres + dstrCutWidth.Millimetres))

            ' Do the strips but perfectly
            If (bytStripsPerSheet + 1) * (dstrHeight.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenShortSide Then
                bytStripsPerSheet += 1
            End If

            ' How many of each componenet can fit in a strip
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenFr.Millimetres + dstrCutWidth.Millimetres))
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenBa.Millimetres + dstrCutWidth.Millimetres))
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenCr.Millimetres + dstrCutWidth.Millimetres))

            ' Check if any of the strips fit perfectly
            If (bytFrPerStrip + 1) * (dstrLenFr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytFrPerStrip += 1
            End If
            If (bytBaPerStrip + 1) * (dstrLenBa.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytBaPerStrip += 1
            End If
            If (bytCrPerStrip + 1) * (dstrLenCr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                bytBaPerStrip += 1
            End If

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

            ' whole boards used * strips per sheet + remaining strips
            Dim ui16LongCuts As UInt16 = (bytWholeBoards * bytStripsPerSheet) + bytRemainingStrips

            ' Calculate cuts from each part
            Dim ui16ShortCuts As UInt16 = 0
            ui16ShortCuts += Me.TotalFrontBoards + Me.TotalCrossBraces + Me.TotalBackBoards

            Return ui16ShortCuts + ui16LongCuts
        End Get
    End Property

    Public ReadOnly Property WasteSquareMillimetreage As UInt32
        Get
            ' Find the area taken up by each componenet
            Dim ui32AreaFr As UInt32 = Convert.ToUInt32(dstrLenFr.Millimetres + dstrCutWidth.Millimetres) * (dstrHeight.Millimetres + dstrCutWidth.Millimetres)
            Dim ui32AreaBa As UInt32 = Convert.ToUInt32(dstrLenBa.Millimetres + dstrCutWidth.Millimetres) * (dstrHeight.Millimetres + dstrCutWidth.Millimetres)
            Dim ui32AreaCr As UInt32 = Convert.ToUInt32(dstrLenCr.Millimetres + dstrCutWidth.Millimetres) * (dstrHeight.Millimetres + dstrCutWidth.Millimetres)

            ' How many of each componenet can fit in a strip
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenFr.Millimetres + dstrCutWidth.Millimetres))
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenBa.Millimetres + dstrCutWidth.Millimetres))
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / (dstrLenCr.Millimetres + dstrCutWidth.Millimetres))

            Dim ui32AreaRequired As UInt32 = ui32AreaFr * Me.TotalFrontBoards + ui32AreaBa * Me.TotalBackBoards + ui32AreaCr * Me.TotalCrossBraces

            ' Remove area in case of perfect fit
            ' Check if any of the strips fit perfectly, if so do:
            ' Area -= Number of full strips * cut width
            If (bytFrPerStrip + 1) * (dstrLenFr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                ui32AreaRequired -= Math.Floor(Me.TotalFrontBoards / (bytFrPerStrip + 1)) * dstrCutWidth.Millimetres
            End If
            If (bytBaPerStrip + 1) * (dstrLenBa.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                ui32AreaRequired -= Math.Floor(Me.TotalBackBoards / (bytBaPerStrip + 1)) * dstrCutWidth.Millimetres
            End If
            If (bytCrPerStrip + 1) * (dstrLenCr.Millimetres + dstrCutWidth.Millimetres) - dstrCutWidth.Millimetres = ui16LenLongSide Then
                ui32AreaRequired -= Math.Floor(Me.TotalCrossBraces / (bytCrPerStrip + 1)) * dstrCutWidth.Millimetres
            End If

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
