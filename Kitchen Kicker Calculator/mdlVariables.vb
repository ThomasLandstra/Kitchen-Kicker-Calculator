Module mdlVariables
    Public keActiveElement As KitchenElement
    Public prjActiveProject As Project

    ' Settings
    Public dstrLenBa As DistanceString = New DistanceString(My.Settings.strLenBa)
    Public dstrLenFr As DistanceString = New DistanceString(My.Settings.strLenFr)
    Public dstrLenCr As DistanceString = New DistanceString(My.Settings.strLenCr)
    Public dstrHeight As DistanceString = New DistanceString(My.Settings.strHeight)
    Public dstrCutWidth As DistanceString = New DistanceString(My.Settings.strCutWidth)
    Public dstrSrcLength As DistanceString = New DistanceString(My.Settings.strSrcLength)
    Public dstrSrcWidth As DistanceString = New DistanceString(My.Settings.strSrcWidth)
    Public dstrGapCr As DistanceString = New DistanceString(My.Settings.strGapCr)

    Public Property ui16LenBa As UInt16
        Get
            Return dstrLenBa.Millimetres
        End Get
        Set(ui16 As UInt16)
            dstrLenBa.Millimetres = ui16
        End Set
    End Property

    Public ReadOnly Property ui16LenFr As UInt16
        Get
            Return dstrLenFr.Millimetres
        End Get
    End Property

    Public ReadOnly Property ui16LenCr As UInt16
        Get
            Return dstrLenCr.Millimetres
        End Get
    End Property

    Public ReadOnly Property ui16LenLongSide As UInt16
        Get
            Return Math.Max(dstrSrcLength.Millimetres, dstrSrcWidth.Millimetres)
        End Get
    End Property

    Public ReadOnly Property ui16LenShortSide As UInt16
        Get
            Return Math.Min(dstrSrcLength.Millimetres, dstrSrcWidth.Millimetres)
        End Get
    End Property
End Module
