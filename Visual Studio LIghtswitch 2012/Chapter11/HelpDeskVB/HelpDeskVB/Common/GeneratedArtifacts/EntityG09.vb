﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __Office = LightSwitchApplication.Office

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class Office
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Office, __Office.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Office entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Office))
            MyBase.New(entitySet)
            
            __Office.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Office_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Office_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.RowVersion, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property OfficeName As String
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.OfficeName)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.OfficeName, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OfficeName_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OfficeName_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub OfficeName_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Address1 As String
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.Address1)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.Address1, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address1_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address1_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address1_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Address2 As String
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.Address2)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.Address2, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address2_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address2_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Address2_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property BuildingCapacity As Integer
            Get
                Return __Office.DetailsClass.GetValue(Me, __Office.DetailsClass.PropertySetProperties.BuildingCapacity)
            End Get
            Set
                __Office.DetailsClass.SetValue(Me, __Office.DetailsClass.PropertySetProperties.BuildingCapacity, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub BuildingCapacity_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub BuildingCapacity_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub BuildingCapacity_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Office, _
                __Office.DetailsClass, _
                __Office.DetailsClass.IImplementation, _
                __Office.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Office, __Office.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Office, __Office.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Office.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __OfficeEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Office, __Office.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Office, __Office.DetailsClass).Entry( _
                    AddressOf __Office.DetailsClass.__Office_CreateNew, _
                    AddressOf __Office.DetailsClass.__Office_Created, _
                    AddressOf __Office.DetailsClass.__Office_AllowSaveWithErrors)
            Private Shared Function __Office_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Office)) As __Office
                Return New __Office(es)
            End Function
            Private Shared Sub __Office_Created(e As __Office)
                e.Office_Created()
            End Sub
            Private Shared Function __Office_AllowSaveWithErrors(e As __Office) As Boolean
                Dim result As Boolean = False
                e.Office_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Office, __Office.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Office, __Office.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Office.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Office, __Office.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property OfficeName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.OfficeName),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Address1 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.Address1),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Address2 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.Address2),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property BuildingCapacity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Office.DetailsClass.PropertySetProperties.BuildingCapacity),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property OfficeName As String
                Shadows Property Address1 As String
                Shadows Property Address2 As String
                Shadows Property BuildingCapacity As Integer
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __Office.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __Office.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __Office)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte()).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __Office.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __Office.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __Office)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly OfficeName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry( _
                        "OfficeName", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._OfficeName_OnValueChanged)
                Private Shared Sub _OfficeName_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._OfficeName, sf)
                End Sub
                Private Shared Function _OfficeName_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.OfficeName_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _OfficeName_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.OfficeName_Validate(r)
                End Sub
                Private Shared Function _OfficeName_GetImplementationValue(d As __Office.DetailsClass) As String
                    Return d.ImplementationEntity.OfficeName
                End Function
                Private Shared Sub _OfficeName_SetImplementationValue(d As __Office.DetailsClass, v As String)
                    d.ImplementationEntity.OfficeName = v
                End Sub
                Private Shared Sub _OfficeName_OnValueChanged(e As __Office)
                    e.OfficeName_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Address1 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry( _
                        "Address1", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address1_OnValueChanged)
                Private Shared Sub _Address1_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._Address1, sf)
                End Sub
                Private Shared Function _Address1_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.Address1_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Address1_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Address1_Validate(r)
                End Sub
                Private Shared Function _Address1_GetImplementationValue(d As __Office.DetailsClass) As String
                    Return d.ImplementationEntity.Address1
                End Function
                Private Shared Sub _Address1_SetImplementationValue(d As __Office.DetailsClass, v As String)
                    d.ImplementationEntity.Address1 = v
                End Sub
                Private Shared Sub _Address1_OnValueChanged(e As __Office)
                    e.Address1_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Address2 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Entry( _
                        "Address2", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._Address2_OnValueChanged)
                Private Shared Sub _Address2_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._Address2, sf)
                End Sub
                Private Shared Function _Address2_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.Address2_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Address2_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Address2_Validate(r)
                End Sub
                Private Shared Function _Address2_GetImplementationValue(d As __Office.DetailsClass) As String
                    Return d.ImplementationEntity.Address2
                End Function
                Private Shared Sub _Address2_SetImplementationValue(d As __Office.DetailsClass, v As String)
                    d.ImplementationEntity.Address2 = v
                End Sub
                Private Shared Sub _Address2_OnValueChanged(e As __Office)
                    e.Address2_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly BuildingCapacity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Entry( _
                        "BuildingCapacity", _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_Stub, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_ComputeIsReadOnly, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_Validate, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_GetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_SetImplementationValue, _
                        AddressOf __Office.DetailsClass.PropertySetProperties._BuildingCapacity_OnValueChanged)
                Private Shared Sub _BuildingCapacity_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Office.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Data), d As __Office.DetailsClass, sf As Object)
                    c(d, d._BuildingCapacity, sf)
                End Sub
                Private Shared Function _BuildingCapacity_ComputeIsReadOnly(e As __Office) As Boolean
                    Dim result As Boolean = False
                    e.BuildingCapacity_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _BuildingCapacity_Validate(e As __Office, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.BuildingCapacity_Validate(r)
                End Sub
                Private Shared Function _BuildingCapacity_GetImplementationValue(d As __Office.DetailsClass) As Integer
                    Return d.ImplementationEntity.BuildingCapacity
                End Function
                Private Shared Sub _BuildingCapacity_SetImplementationValue(d As __Office.DetailsClass, v As Integer)
                    d.ImplementationEntity.BuildingCapacity = v
                End Sub
                Private Shared Sub _BuildingCapacity_OnValueChanged(e As __Office)
                    e.BuildingCapacity_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _OfficeName As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Address1 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Address2 As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _BuildingCapacity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Office, __Office.DetailsClass, Integer).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
