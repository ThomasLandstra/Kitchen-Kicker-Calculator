Public Class KitchenElement
    ' PRIVATE VARIABLES
    ReadOnly _prjProject As Project
    ReadOnly _dstrLinearMetres As New DistanceString
    Dim _strName As String
    Dim _bytSpareFr As Byte = 0
    Dim _bytSpareBa As Byte = 0
    Dim _bytSpareCr As Byte = 0



    ' PROPERTIES
    '' Basic properties
    Public Property Name As String
        Get
            Return _strName
        End Get
        Set(strName As String)
            _strName = strName
            _prjProject.SaveFile.IsSaved = False
        End Set
    End Property

    Public ReadOnly Property Project As Project
        Get
            Return _prjProject
        End Get
    End Property

    '' Element inpus properties
    Public Property LinearMillimetres As Single
        Get
            Return _dstrLinearMetres.Millimetres
        End Get
        Set(sglLinearMetre As Single)
            _prjProject.SaveFile.IsSaved = False
            _dstrLinearMetres.Millimetres = sglLinearMetre
        End Set
    End Property
    Public Property MeasurementUnit As String
        Get
            Return _dstrLinearMetres.Unit
        End Get
        Set(strUnit As String)
            _prjProject.SaveFile.IsSaved = False
            _dstrLinearMetres.Unit = strUnit
        End Set
    End Property
    Public Property LinearDistanceText As String
        Get
            Return _dstrLinearMetres.Text
        End Get
        Set(strLinearString As String)
            _prjProject.SaveFile.IsSaved = False
            _dstrLinearMetres.Text = strLinearString
        End Set
    End Property

    '' Spare Component Properties
    Public Property SpareFrontBoards As Byte
        Get
            Return _bytSpareFr
        End Get
        Set(bytExtraFr As Byte)
            _prjProject.SaveFile.IsSaved = False
            _bytSpareFr = bytExtraFr
        End Set
    End Property
    Public Property SpareBackBoards As Byte
        Get
            Return _bytSpareBa
        End Get
        Set(bytExtraBa As Byte)
            _prjProject.SaveFile.IsSaved = False
            _bytSpareBa = bytExtraBa
        End Set
    End Property
    Public Property SpareCrossBraces As Byte
        Get
            Return _bytSpareCr
        End Get
        Set(bytExtraCr As Byte)
            _prjProject.SaveFile.IsSaved = False
            _bytSpareCr = bytExtraCr
        End Set
    End Property

    '' Element output properties
    Public ReadOnly Property BackBoards As Byte
        Get
            ' Divide linear meters by length of Back Board and round up
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrLenBa.Millimetres)
        End Get
    End Property

    Public ReadOnly Property FrontBoards As Byte
        Get
            ' Divide linear meters by length of Front Board and round up
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrLenFr.Millimetres)
        End Get
    End Property

    Public ReadOnly Property CrossBraces As Byte
        Get
            ' Divide linear meters by length of Cross Brace and round up
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrGapCr.Millimetres) + 1
        End Get
    End Property



    ' METHODS
    Public Sub New(strName As String, prjProject As Project)
        _strName = strName
        _prjProject = prjProject
    End Sub

    Public Function CreateDiagram() As Bitmap
        ' If no distance has been entered return an empty image
        If LinearMillimetres = 0 Then
            Return New Bitmap(10, 10)
        End If

        ' Generate points
        Dim ptElementWidth As New Point(0, dstrLenCr.Millimetres)
        Dim ptElementLength As New Point(LinearMillimetres, 0)

        ' pt(T/B)(L/R) or pt(Top/Botton)(Left/Right)
        Dim ptTL As New Point(10, 10)
        Dim ptBL As Point = ptTL + ptElementWidth
        Dim ptTR As Point = ptTL + ptElementLength
        Dim ptBR As Point = ptTR + ptElementWidth

        ' Generate Image
        Dim bmImage As New Bitmap(ptElementLength.X + 20, ptElementWidth.Y + 20)
        Dim grpImageGraphic As Graphics = Graphics.FromImage(bmImage)

        ' Generate Pens with colour and pen width
        Dim penBack As New Pen(My.Settings.clrBackBoard, My.Settings.bytWidthBa)
        Dim penFront As New Pen(My.Settings.clrFrontBoard, My.Settings.bytWidthFr)
        Dim penCross As New Pen(My.Settings.clrCrossBrace, My.Settings.bytWidthCr)

        ' Add background
        grpImageGraphic.FillRectangle(Brushes.White, New Rectangle(New Point(0, 0), bmImage.Size))

        ' Draw lines
        grpImageGraphic.DrawLine(penBack, ptTL, ptTR)
        grpImageGraphic.DrawLine(penFront, ptBL, ptBR)
        grpImageGraphic.DrawLine(penCross, ptTL, ptBL)
        grpImageGraphic.DrawLine(penCross, ptTR, ptBR)

        ' Draw Cross Braces
        Dim ui16CrossBraceGap As UInt16 = LinearMillimetres / (CrossBraces - 1)

        ' Loop through every cross brace excluding first and last
        For byt As Byte = 1 To CrossBraces - 2
            Dim ui16AxisX = byt * ui16CrossBraceGap ' Find X value
            Dim ptTop = New Point(ui16AxisX, 0) + ptTL ' Find top point
            Dim ptBottom = ptTop + ptElementWidth ' Find bottom point
            grpImageGraphic.DrawLine(penCross, ptTop, ptBottom) ' Draw
        Next

        Return bmImage
    End Function
End Class
