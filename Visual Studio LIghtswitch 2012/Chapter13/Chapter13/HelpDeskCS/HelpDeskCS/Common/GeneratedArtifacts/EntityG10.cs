﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class LogEntry : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the LogEntry entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public LogEntry()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public LogEntry(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.LogEntry> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.LogEntry.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LogEntry_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LogEntry_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int LogEntryID
        {
            get
            {
                return global::LightSwitchApplication.LogEntry.DetailsClass.GetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.LogEntryID);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LogEntryID_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LogEntryID_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void LogEntryID_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Message
        {
            get
            {
                return global::LightSwitchApplication.LogEntry.DetailsClass.GetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.Message);
            }
            set
            {
                global::LightSwitchApplication.LogEntry.DetailsClass.SetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.Message, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Message_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Message_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Message_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime EventDateTime
        {
            get
            {
                return global::LightSwitchApplication.LogEntry.DetailsClass.GetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventDateTime);
            }
            set
            {
                global::LightSwitchApplication.LogEntry.DetailsClass.SetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventDateTime, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventDateTime_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventDateTime_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventDateTime_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.LogSource EventSource
        {
            get
            {
                return global::LightSwitchApplication.LogEntry.DetailsClass.GetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource);
            }
            set
            {
                global::LightSwitchApplication.LogEntry.DetailsClass.SetValue(this, global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventSource_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventSource_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void EventSource_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.LogEntry,
                global::LightSwitchApplication.LogEntry.DetailsClass,
                global::LightSwitchApplication.LogEntry.DetailsClass.IImplementation,
                global::LightSwitchApplication.LogEntry.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.LogEntryID;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>.Entry
                __LogEntryEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>.Entry(
                    global::LightSwitchApplication.LogEntry.DetailsClass.__LogEntry_CreateNew,
                    global::LightSwitchApplication.LogEntry.DetailsClass.__LogEntry_Created,
                    global::LightSwitchApplication.LogEntry.DetailsClass.__LogEntry_AllowSaveWithErrors);
            private static global::LightSwitchApplication.LogEntry __LogEntry_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.LogEntry> es)
            {
                return new global::LightSwitchApplication.LogEntry(es);
            }
            private static void __LogEntry_Created(global::LightSwitchApplication.LogEntry e)
            {
                e.LogEntry_Created();
            }
            private static bool __LogEntry_AllowSaveWithErrors(global::LightSwitchApplication.LogEntry e)
            {
                bool result = false;
                e.LogEntry_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.LogEntry.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int> LogEntryID
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.LogEntryID) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string> Message
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.Message) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime> EventDateTime
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventDateTime) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource> EventSource
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int LogEntryID { get; }
                new string Message { get; set; }
                new global::System.DateTime EventDateTime { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation EventSource { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int>.Entry
                    LogEntryID = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int>.Entry(
                        "LogEntryID",
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._LogEntryID_Stub,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._LogEntryID_ComputeIsReadOnly,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._LogEntryID_Validate,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._LogEntryID_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._LogEntryID_OnValueChanged);
                private static void _LogEntryID_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LogEntry.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int>.Data> c, global::LightSwitchApplication.LogEntry.DetailsClass d, object sf)
                {
                    c(d, ref d._LogEntryID, sf);
                }
                private static bool _LogEntryID_ComputeIsReadOnly(global::LightSwitchApplication.LogEntry e)
                {
                    bool result = false;
                    e.LogEntryID_IsReadOnly(ref result);
                    return result;
                }
                private static void _LogEntryID_Validate(global::LightSwitchApplication.LogEntry e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.LogEntryID_Validate(r);
                }
                private static int _LogEntryID_GetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    return d.ImplementationEntity.LogEntryID;
                }
                private static void _LogEntryID_OnValueChanged(global::LightSwitchApplication.LogEntry e)
                {
                    e.LogEntryID_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string>.Entry
                    Message = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string>.Entry(
                        "Message",
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_Stub,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_ComputeIsReadOnly,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_Validate,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_GetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_SetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._Message_OnValueChanged);
                private static void _Message_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LogEntry.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string>.Data> c, global::LightSwitchApplication.LogEntry.DetailsClass d, object sf)
                {
                    c(d, ref d._Message, sf);
                }
                private static bool _Message_ComputeIsReadOnly(global::LightSwitchApplication.LogEntry e)
                {
                    bool result = false;
                    e.Message_IsReadOnly(ref result);
                    return result;
                }
                private static void _Message_Validate(global::LightSwitchApplication.LogEntry e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Message_Validate(r);
                }
                private static string _Message_GetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    return d.ImplementationEntity.Message;
                }
                private static void _Message_SetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Message = v;
                }
                private static void _Message_OnValueChanged(global::LightSwitchApplication.LogEntry e)
                {
                    e.Message_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime>.Entry
                    EventDateTime = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime>.Entry(
                        "EventDateTime",
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_Stub,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_ComputeIsReadOnly,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_Validate,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_GetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_SetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventDateTime_OnValueChanged);
                private static void _EventDateTime_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LogEntry.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime>.Data> c, global::LightSwitchApplication.LogEntry.DetailsClass d, object sf)
                {
                    c(d, ref d._EventDateTime, sf);
                }
                private static bool _EventDateTime_ComputeIsReadOnly(global::LightSwitchApplication.LogEntry e)
                {
                    bool result = false;
                    e.EventDateTime_IsReadOnly(ref result);
                    return result;
                }
                private static void _EventDateTime_Validate(global::LightSwitchApplication.LogEntry e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.EventDateTime_Validate(r);
                }
                private static global::System.DateTime _EventDateTime_GetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    return d.ImplementationEntity.EventDateTime;
                }
                private static void _EventDateTime_SetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d, global::System.DateTime v)
                {
                    d.ImplementationEntity.EventDateTime = global::LightSwitchApplication.LogEntry.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _EventDateTime_OnValueChanged(global::LightSwitchApplication.LogEntry e)
                {
                    e.EventDateTime_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource>.Entry
                    EventSource = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource>.Entry(
                        "EventSource",
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_Stub,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_ComputeIsReadOnly,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_Validate,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_GetCoreImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_GetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_SetImplementationValue,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_Refresh,
                        global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties._EventSource_OnValueChanged);
                private static void _EventSource_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.LogEntry.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource>.Data> c, global::LightSwitchApplication.LogEntry.DetailsClass d, object sf)
                {
                    c(d, ref d._EventSource, sf);
                }
                private static bool _EventSource_ComputeIsReadOnly(global::LightSwitchApplication.LogEntry e)
                {
                    bool result = false;
                    e.EventSource_IsReadOnly(ref result);
                    return result;
                }
                private static void _EventSource_Validate(global::LightSwitchApplication.LogEntry e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.EventSource_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _EventSource_GetCoreImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    return d.ImplementationEntity.EventSource;
                }
                private static global::LightSwitchApplication.LogSource _EventSource_GetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.LogSource, global::LightSwitchApplication.LogSource.DetailsClass>(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource, ref d._EventSource);
                }
                private static void _EventSource_SetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass d, global::LightSwitchApplication.LogSource v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource, ref d._EventSource, (i, ev) => i.EventSource = ev, v);
                }
                private static void _EventSource_Refresh(global::LightSwitchApplication.LogEntry.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.LogEntry.DetailsClass.PropertySetProperties.EventSource, ref d._EventSource);
                }
                private static void _EventSource_OnValueChanged(global::LightSwitchApplication.LogEntry e)
                {
                    e.EventSource_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, int>.Data _LogEntryID;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, string>.Data _Message;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::System.DateTime>.Data _EventDateTime;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.LogEntry, global::LightSwitchApplication.LogEntry.DetailsClass, global::LightSwitchApplication.LogSource>.Data _EventSource;
            
        }
    
        #endregion
    }
    
    #endregion
}
