﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.2803.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'ConstituentAddressPicklistAVAILABLEADDRESSES' data form
''' </summary>
Partial Public Class [ConstituentAddressPicklistAVAILABLEADDRESSESUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.UIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _addressid As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _addressblock As Global.Blackbaud.AppFx.UIModeling.Core.StringField

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2803.0")> _
    Public Sub New()
        MyBase.New()

        _addressid = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _addressblock = New Global.Blackbaud.AppFx.UIModeling.Core.StringField

        '
        '_addressid
        '
        _addressid.Name = "ADDRESSID"
        _addressid.Caption = "ADDRESSID"
        _addressid.Visible = False
        Me.Fields.Add(_addressid)
        '
        '_addressblock
        '
        _addressblock.Name = "ADDRESSBLOCK"
        _addressblock.Caption = "Address"
        Me.Fields.Add(_addressblock)

		OnCreated()

    End Sub
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2803.0")> _
    Public ReadOnly Property [ADDRESSID]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _addressid
        End Get
    End Property
    
    ''' <summary>
    ''' Address
    ''' </summary>
    <System.ComponentModel.Description("Address")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.2803.0")> _
    Public ReadOnly Property [ADDRESSBLOCK]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _addressblock
        End Get
    End Property
    
End Class
