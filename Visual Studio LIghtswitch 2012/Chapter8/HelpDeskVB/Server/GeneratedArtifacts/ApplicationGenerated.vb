﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication.Implementation

    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)>
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.ServerGenerated.IServerApplicationFactory))>
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public NotInheritable Class ApplicationFactory
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.ServerApplicationFactory

        Protected Overrides Function CreateApplication(ByVal applicationDefinition As Global.Microsoft.LightSwitch.Model.IServiceApplicationDefinition, ByVal logicDispatcher As Global.Microsoft.LightSwitch.Threading.IDispatcher) As Global.Microsoft.LightSwitch.Server.IServerApplication
            Return New Global.LightSwitchApplication.Application(applicationDefinition, logicDispatcher)
        End Function

        Public Overrides Function CreateContext() As Global.Microsoft.LightSwitch.Server.IServerApplicationContext
            Return New Global.LightSwitchApplication.ServerApplicationContext()
        End Function

    End Class

    <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)>
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.IModuleFactory))>
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)>
    <Global.Microsoft.LightSwitch.Framework.Base.ModuleFactory("LightSwitchServiceApplication")>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public NotInheritable Class ModuleFactory
        Inherits Global.Microsoft.LightSwitch.Framework.Base.ModuleFactory

        Public Overrides Function GetModule(ByVal moduleDefinition As Global.Microsoft.LightSwitch.Model.IModuleDefinition) As Global.Microsoft.LightSwitch.IModule
            Return Global.LightSwitchApplication.Application.Current
        End Function

    End Class

End Namespace
