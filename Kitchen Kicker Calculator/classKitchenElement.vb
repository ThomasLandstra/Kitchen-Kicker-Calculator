Public Class KitchenElement
    ' VARIABLES
    ReadOnly _prjProject As Project
    ReadOnly _dstrLinearMetres As New DistanceString
    Dim _bytExtraFr As Byte = 0
    Dim _bytExtraBa As Byte = 0
    Dim _bytExtraCr As Byte = 0

    ' PROPERTIES
    '' Basic properties
    Public Property Name As String

    Public ReadOnly Property Project As Project
        Get
            Return _prjProject
        End Get
    End Property

    '' Element inputs properties
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
            _dstrLinearMetres.Unit = strUnit
        End Set
    End Property
    Public Property LinearString As String
        Get
            Return _dstrLinearMetres.Text
        End Get
        Set(strLinearString As String)
            _dstrLinearMetres.Text = strLinearString
        End Set
    End Property

    '' Element output properties
    Public ReadOnly Property BackBoards As Byte
        Get
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrLenBa.Millimetres)
        End Get
    End Property

    Public ReadOnly Property FrontBoards As Byte
        Get
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrLenFr.Millimetres)
        End Get
    End Property

    Public ReadOnly Property CrossBraces As Byte
        Get
            Return Math.Ceiling(_dstrLinearMetres.Millimetres / dstrGapCr.Millimetres) + 1
        End Get
    End Property

    '' Extra Component Properties
    Public SpareFrontBoards As Byte = 0
    Public SpareBackBoards As Byte = 0
    Public SpareCrossBraces As Byte = 0

    ' METHODS
    Public Sub New(strName As String, prjProject As Project)
        Name = strName
        _prjProject = prjProject
    End Sub

    Public Function CreateDiagram() As Bitmap
        ' Generate points
        Dim ptElementWidth As New Point(0, dstrLenCr.Millimetres)
        Dim ptElementLength As New Point(LinearMillimetres, 0)

        Dim ptTL As New Point(10, 10)
        Dim ptBL As Point = ptTL + ptElementWidth
        Dim ptTR As Point = ptTL + ptElementLength
        Dim ptBR As Point = ptTR + ptElementWidth

        ' Generate Image

        Dim bmImage As New Bitmap(ptElementLength.X + 20, ptElementWidth.Y + 20)
        Dim grpImageGraphic As Graphics = Graphics.FromImage(bmImage)

        ' Generate Pens
        Dim penBack As New Pen(My.Settings.clrBackBoard, My.Settings.bytWidthBa)
        Dim penFront As New Pen(My.Settings.clrFrontBoard, My.Settings.bytWidthFr)
        Dim penCross As New Pen(My.Settings.clrCrossBrace, My.Settings.bytWidthCr)

        ' Add background
        grpImageGraphic.FillRectangle(Brushes.White, New Rectangle(New Point(0, 0), bmImage.Size))

        grpImageGraphic.DrawLine(penBack, ptTL, ptTR)
        grpImageGraphic.DrawLine(penFront, ptBL, ptBR)
        grpImageGraphic.DrawLine(penCross, ptTL, ptBL)
        grpImageGraphic.DrawLine(penCross, ptTR, ptBR)

        ' Draw Cross Braces
        If CrossBraces < 2 Then
            Exit Function
        End If
        Dim ui16CrossBraceGap As UInt16 = LinearMillimetres / (CrossBraces - 1)
        For byt As Byte = 1 To CrossBraces - 2
            Dim ui16AxisX = byt * ui16CrossBraceGap
            Dim ptTop = New Point(ui16AxisX, 0) + ptTL
            Dim ptBottom = ptTop + ptElementWidth
            grpImageGraphic.DrawLine(penCross, ptTop, ptBottom)
        Next

        Return bmImage
    End Function
End Class
