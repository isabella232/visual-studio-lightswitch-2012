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

Imports __EngineerSkill = LightSwitchApplication.EngineerSkill

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class EngineerSkill
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __EngineerSkill, __EngineerSkill.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the EngineerSkill entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __EngineerSkill))
            MyBase.New(entitySet)
            
            __EngineerSkill.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EngineerSkill_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub EngineerSkill_AllowSaveWithErrors(ByRef result As Boolean)
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
                Return __EngineerSkill.DetailsClass.GetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __EngineerSkill.DetailsClass.SetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Id, Value)
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
                Return __EngineerSkill.DetailsClass.GetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __EngineerSkill.DetailsClass.SetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.RowVersion, Value)
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
        Public Property Skill As Global.LightSwitchApplication.Skill
            Get
                Return __EngineerSkill.DetailsClass.GetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Skill)
            End Get
            Set
                __EngineerSkill.DetailsClass.SetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Skill, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Skill_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Skill_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Skill_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Engineer As Global.LightSwitchApplication.Engineer
            Get
                Return __EngineerSkill.DetailsClass.GetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Engineer)
            End Get
            Set
                __EngineerSkill.DetailsClass.SetValue(Me, __EngineerSkill.DetailsClass.PropertySetProperties.Engineer, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Engineer_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Engineer_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Engineer_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __EngineerSkill, _
                __EngineerSkill.DetailsClass, _
                __EngineerSkill.DetailsClass.IImplementation, _
                __EngineerSkill.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __EngineerSkill, __EngineerSkill.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __EngineerSkill, __EngineerSkill.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __EngineerSkill.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __EngineerSkillEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __EngineerSkill, __EngineerSkill.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __EngineerSkill, __EngineerSkill.DetailsClass).Entry( _
                    AddressOf __EngineerSkill.DetailsClass.__EngineerSkill_CreateNew, _
                    AddressOf __EngineerSkill.DetailsClass.__EngineerSkill_Created, _
                    AddressOf __EngineerSkill.DetailsClass.__EngineerSkill_AllowSaveWithErrors)
            Private Shared Function __EngineerSkill_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __EngineerSkill)) As __EngineerSkill
                Return New __EngineerSkill(es)
            End Function
            Private Shared Sub __EngineerSkill_Created(e As __EngineerSkill)
                e.EngineerSkill_Created()
            End Sub
            Private Shared Function __EngineerSkill_AllowSaveWithErrors(e As __EngineerSkill) As Boolean
                Dim result As Boolean = False
                e.EngineerSkill_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __EngineerSkill, __EngineerSkill.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __EngineerSkill, __EngineerSkill.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __EngineerSkill.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __EngineerSkill, __EngineerSkill.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__EngineerSkill.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__EngineerSkill.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Skill As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__EngineerSkill.DetailsClass.PropertySetProperties.Skill),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill))
                    End Get
                End Property
                
                Public ReadOnly Property Engineer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__EngineerSkill.DetailsClass.PropertySetProperties.Engineer),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property Skill As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                Shadows Property Engineer As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __EngineerSkill.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer).Data), d As __EngineerSkill.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __EngineerSkill) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __EngineerSkill, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __EngineerSkill.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __EngineerSkill.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __EngineerSkill)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __EngineerSkill.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte()).Data), d As __EngineerSkill.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __EngineerSkill) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __EngineerSkill, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __EngineerSkill.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __EngineerSkill.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __EngineerSkill)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Skill As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill).Entry( _
                        "Skill", _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_Stub, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_ComputeIsReadOnly, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_Validate, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_GetCoreImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_GetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_SetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_Refresh, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Skill_OnValueChanged)
                Private Shared Sub _Skill_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __EngineerSkill.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill).Data), d As __EngineerSkill.DetailsClass, sf As Object)
                    c(d, d._Skill, sf)
                End Sub
                Private Shared Function _Skill_ComputeIsReadOnly(e As __EngineerSkill) As Boolean
                    Dim result As Boolean = False
                    e.Skill_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Skill_Validate(e As __EngineerSkill, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Skill_Validate(r)
                End Sub
                Private Shared Function _Skill_GetCoreImplementationValue(d as __EngineerSkill.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Skill
                End Function
                Private Shared Function _Skill_GetImplementationValue(d as __EngineerSkill.DetailsClass) As Global.LightSwitchApplication.Skill
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Skill, Global.LightSwitchApplication.Skill.DetailsClass)(__EngineerSkill.DetailsClass.PropertySetProperties.Skill, d._Skill)
                End Function
                Private Shared Sub _Skill_SetImplementationValue(d As __EngineerSkill.DetailsClass, v As Global.LightSwitchApplication.Skill)
                    d.SetImplementationValue(__EngineerSkill.DetailsClass.PropertySetProperties.Skill, d._Skill, Sub(i, ev) i.Skill = ev, v)
                End Sub
                Private Shared Sub _Skill_Refresh(d As __EngineerSkill.DetailsClass)
                    d.RefreshNavigationProperty(__EngineerSkill.DetailsClass.PropertySetProperties.Skill, d._Skill)
                End Sub
                Private Shared Sub _Skill_OnValueChanged(e As __EngineerSkill)
                    e.Skill_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Engineer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer).Entry( _
                        "Engineer", _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_Stub, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_ComputeIsReadOnly, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_Validate, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_GetCoreImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_GetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_SetImplementationValue, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_Refresh, _
                        AddressOf __EngineerSkill.DetailsClass.PropertySetProperties._Engineer_OnValueChanged)
                Private Shared Sub _Engineer_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __EngineerSkill.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer).Data), d As __EngineerSkill.DetailsClass, sf As Object)
                    c(d, d._Engineer, sf)
                End Sub
                Private Shared Function _Engineer_ComputeIsReadOnly(e As __EngineerSkill) As Boolean
                    Dim result As Boolean = False
                    e.Engineer_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Engineer_Validate(e As __EngineerSkill, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Engineer_Validate(r)
                End Sub
                Private Shared Function _Engineer_GetCoreImplementationValue(d as __EngineerSkill.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Engineer
                End Function
                Private Shared Function _Engineer_GetImplementationValue(d as __EngineerSkill.DetailsClass) As Global.LightSwitchApplication.Engineer
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Engineer, Global.LightSwitchApplication.Engineer.DetailsClass)(__EngineerSkill.DetailsClass.PropertySetProperties.Engineer, d._Engineer)
                End Function
                Private Shared Sub _Engineer_SetImplementationValue(d As __EngineerSkill.DetailsClass, v As Global.LightSwitchApplication.Engineer)
                    d.SetImplementationValue(__EngineerSkill.DetailsClass.PropertySetProperties.Engineer, d._Engineer, Sub(i, ev) i.Engineer = ev, v)
                End Sub
                Private Shared Sub _Engineer_Refresh(d As __EngineerSkill.DetailsClass)
                    d.RefreshNavigationProperty(__EngineerSkill.DetailsClass.PropertySetProperties.Engineer, d._Engineer)
                End Sub
                Private Shared Sub _Engineer_OnValueChanged(e As __EngineerSkill)
                    e.Engineer_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Skill As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Skill).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Engineer As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __EngineerSkill, __EngineerSkill.DetailsClass, Global.LightSwitchApplication.Engineer).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace