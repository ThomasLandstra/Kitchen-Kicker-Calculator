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
            Return 0

            ' How many strips per sheet
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / dstrHeight.Millimetres)

            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenFr.Millimetres)
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenBa.Millimetres)
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / dstrLenCr.Millimetres)

            Dim ui16RequiredFr As UInt16
            Dim ui16RequiredBa As UInt16
            Dim ui16RequiredCr As UInt16

            For Each ke In KitchenElements
                If ke.FrontBoards = 0 Or ke.BackBoards = 0 Then
                    Continue For
                End If
                ui16RequiredFr += ke.FrontBoards
                ui16RequiredBa += ke.BackBoards
                ui16RequiredCr += ke.CrossBraces
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
            Return 0
            Dim dblTotalWaste As Double = 0

            ' How many strips per sheet
            Dim bytStripsPerSheet As Byte = Math.Floor(ui16LenShortSide / dstrHeight.Millimetres)

            ' How much waste per sheet
            Dim a = (bytStripsPerSheet * dstrHeight.Millimetres)
            Dim b As UInt64 = (ui16LenShortSide - a)
            Dim ui16WastePerSheet As UInt64 = ui16LenLongSide * b
            dblTotalWaste += ui16WastePerSheet * SheetsUsed

            ' How much waste per each componenet
            Dim bytFrPerStrip As Byte = Math.Floor(ui16LenLongSide / ui16LenFr)
            Dim bytBaPerStrip As Byte = Math.Floor(ui16LenLongSide / ui16LenBa)
            Dim bytCrPerStrip As Byte = Math.Floor(ui16LenLongSide / ui16LenCr)

            Dim ui16RequiredFr As UInt16
            Dim ui16RequiredBa As UInt16
            Dim ui16RequiredCr As UInt16

            For Each ke In KitchenElements
                If ke.FrontBoards = 0 Or ke.BackBoards = 0 Then
                    Continue For
                End If
                ui16RequiredFr += ke.FrontBoards
                ui16RequiredBa += ke.BackBoards
                ui16RequiredCr += ke.CrossBraces
            Next

            ' Stupid rounding and stuff
            Dim bytFullStripsFr As Byte = Math.Floor(ui16RequiredFr / bytFrPerStrip)
            Dim bytFullStripsBa As Byte = Math.Floor(ui16RequiredBa / bytBaPerStrip)
            Dim bytFullStripsCr As Byte = Math.Floor(ui16RequiredCr / bytCrPerStrip)

            Dim dblWastePerFullFrStrip As Byte = ui16LenLongSide - (bytFrPerStrip * ui16LenFr)
            Dim dblWastePerFullBaStrip As Byte = ui16LenLongSide - (bytBaPerStrip * ui16LenBa)
            Dim dblWastePerFullCrStrip As Byte = ui16LenLongSide - (bytCrPerStrip * ui16LenCr)

            dblTotalWaste += bytFullStripsFr * dblWastePerFullFrStrip
            dblTotalWaste += bytFullStripsBa * dblWastePerFullBaStrip
            dblTotalWaste += bytFullStripsCr * dblWastePerFullCrStrip

            Dim bytMissingFr As Byte = ui16RequiredFr - (bytFullStripsFr * bytFrPerStrip)
            Dim bytUnusedRoomFr As Byte = bytFrPerStrip - bytMissingFr
            dblTotalWaste += ui16LenFr * bytUnusedRoomFr
            dblTotalWaste += dblWastePerFullFrStrip * (bytUnusedRoomFr > 0)

            Dim bytMissingBa As Byte = ui16RequiredBa - (bytFullStripsBa * bytBaPerStrip)
            Dim bytUnusedRoomBa As Byte = bytBaPerStrip - bytMissingBa
            dblTotalWaste += ui16LenBa * bytUnusedRoomBa
            dblTotalWaste += dblWastePerFullBaStrip * (bytUnusedRoomBa > 0)

            Dim bytMissingCr As Byte = ui16RequiredCr - (bytFullStripsCr * bytCrPerStrip)
            Dim bytUnusedRoomCr As Byte = bytCrPerStrip - bytMissingCr
            dblTotalWaste += ui16LenFr * bytUnusedRoomCr
            dblTotalWaste += dblWastePerFullCrStrip * (bytUnusedRoomCr > 0)

            Return dblTotalWaste
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
