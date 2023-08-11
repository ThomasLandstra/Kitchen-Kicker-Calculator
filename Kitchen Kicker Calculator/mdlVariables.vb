﻿Module mdlVariables
    ' Main Input/Output related variables
    Public keActiveElement As KitchenElement
    Public prjActiveProject As Project

    ' Settings strings to be easily accessed
    Public dstrLenBa As DistanceString = New DistanceString(My.Settings.strLenBa)
    Public dstrLenFr As DistanceString = New DistanceString(My.Settings.strLenFr)
    Public dstrLenCr As DistanceString = New DistanceString(My.Settings.strLenCr)
    Public dstrHeight As DistanceString = New DistanceString(My.Settings.strHeight)
    Public dstrCutWidth As DistanceString = New DistanceString(My.Settings.strCutWidth)
    Public dstrSrcLength As DistanceString = New DistanceString(My.Settings.strSrcLength)
    Public dstrSrcWidth As DistanceString = New DistanceString(My.Settings.strSrcWidth)
    Public dstrGapCr As DistanceString = New DistanceString(My.Settings.strGapCr)

    ' Properties with
    Public ReadOnly Property LenLongSide As UInt16
        Get
            Return Math.Max(dstrSrcLength.Millimetres, dstrSrcWidth.Millimetres)
        End Get
    End Property

    Public ReadOnly Property LenShortSide As UInt16
        Get
            Return Math.Min(dstrSrcLength.Millimetres, dstrSrcWidth.Millimetres)
        End Get
    End Property
End Module
