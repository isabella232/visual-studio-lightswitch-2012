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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
    public sealed partial class TimeTracking : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the TimeTracking entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public TimeTracking()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public TimeTracking(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.TimeTracking> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.TimeTracking.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void TimeTracking_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void TimeTracking_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.TimeTracking.DetailsClass.GetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.TimeTracking.DetailsClass.SetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] RowVersion
        {
            get
            {
                return global::LightSwitchApplication.TimeTracking.DetailsClass.GetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.RowVersion);
            }
            set
            {
                global::LightSwitchApplication.TimeTracking.DetailsClass.SetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.RowVersion, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void RowVersion_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int DurationMins
        {
            get
            {
                return global::LightSwitchApplication.TimeTracking.DetailsClass.GetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.DurationMins);
            }
            set
            {
                global::LightSwitchApplication.TimeTracking.DetailsClass.SetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.DurationMins, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DurationMins_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DurationMins_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DurationMins_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Engineer Engineers
        {
            get
            {
                return global::LightSwitchApplication.TimeTracking.DetailsClass.GetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers);
            }
            set
            {
                global::LightSwitchApplication.TimeTracking.DetailsClass.SetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Engineers_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Engineers_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Engineers_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Issue Issue
        {
            get
            {
                return global::LightSwitchApplication.TimeTracking.DetailsClass.GetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue);
            }
            set
            {
                global::LightSwitchApplication.TimeTracking.DetailsClass.SetValue(this, global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Issue_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Issue_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Issue_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.TimeTracking,
                global::LightSwitchApplication.TimeTracking.DetailsClass,
                global::LightSwitchApplication.TimeTracking.DetailsClass.IImplementation,
                global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>.Entry
                __TimeTrackingEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>.Entry(
                    global::LightSwitchApplication.TimeTracking.DetailsClass.__TimeTracking_CreateNew,
                    global::LightSwitchApplication.TimeTracking.DetailsClass.__TimeTracking_Created,
                    global::LightSwitchApplication.TimeTracking.DetailsClass.__TimeTracking_AllowSaveWithErrors);
            private static global::LightSwitchApplication.TimeTracking __TimeTracking_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.TimeTracking> es)
            {
                return new global::LightSwitchApplication.TimeTracking(es);
            }
            private static void __TimeTracking_Created(global::LightSwitchApplication.TimeTracking e)
            {
                e.TimeTracking_Created();
            }
            private static bool __TimeTracking_AllowSaveWithErrors(global::LightSwitchApplication.TimeTracking e)
            {
                bool result = false;
                e.TimeTracking_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]> RowVersion
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.RowVersion) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int> DurationMins
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.DurationMins) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer> Engineers
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue> Issue
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new byte[] RowVersion { get; set; }
                new int DurationMins { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Engineers { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Issue { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.3.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.TimeTracking.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Data> c, global::LightSwitchApplication.TimeTracking.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.TimeTracking e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.TimeTracking e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.TimeTracking e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]>.Entry
                    RowVersion = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]>.Entry(
                        "RowVersion",
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_Stub,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_Validate,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged);
                private static void _RowVersion_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.TimeTracking.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.TimeTracking.DetailsClass d, object sf)
                {
                    c(d, ref d._RowVersion, sf);
                }
                private static bool _RowVersion_ComputeIsReadOnly(global::LightSwitchApplication.TimeTracking e)
                {
                    bool result = false;
                    e.RowVersion_IsReadOnly(ref result);
                    return result;
                }
                private static void _RowVersion_Validate(global::LightSwitchApplication.TimeTracking e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.RowVersion_Validate(r);
                }
                private static byte[] _RowVersion_GetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.ImplementationEntity.RowVersion;
                }
                private static void _RowVersion_SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.RowVersion = v;
                }
                private static void _RowVersion_OnValueChanged(global::LightSwitchApplication.TimeTracking e)
                {
                    e.RowVersion_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Entry
                    DurationMins = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Entry(
                        "DurationMins",
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_Stub,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_ComputeIsReadOnly,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_Validate,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_GetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_SetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._DurationMins_OnValueChanged);
                private static void _DurationMins_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.TimeTracking.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Data> c, global::LightSwitchApplication.TimeTracking.DetailsClass d, object sf)
                {
                    c(d, ref d._DurationMins, sf);
                }
                private static bool _DurationMins_ComputeIsReadOnly(global::LightSwitchApplication.TimeTracking e)
                {
                    bool result = false;
                    e.DurationMins_IsReadOnly(ref result);
                    return result;
                }
                private static void _DurationMins_Validate(global::LightSwitchApplication.TimeTracking e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.DurationMins_Validate(r);
                }
                private static int _DurationMins_GetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.ImplementationEntity.DurationMins;
                }
                private static void _DurationMins_SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d, int v)
                {
                    d.ImplementationEntity.DurationMins = v;
                }
                private static void _DurationMins_OnValueChanged(global::LightSwitchApplication.TimeTracking e)
                {
                    e.DurationMins_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer>.Entry
                    Engineers = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer>.Entry(
                        "Engineers",
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_Stub,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_ComputeIsReadOnly,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_Validate,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_GetCoreImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_GetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_SetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_Refresh,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Engineers_OnValueChanged);
                private static void _Engineers_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.TimeTracking.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer>.Data> c, global::LightSwitchApplication.TimeTracking.DetailsClass d, object sf)
                {
                    c(d, ref d._Engineers, sf);
                }
                private static bool _Engineers_ComputeIsReadOnly(global::LightSwitchApplication.TimeTracking e)
                {
                    bool result = false;
                    e.Engineers_IsReadOnly(ref result);
                    return result;
                }
                private static void _Engineers_Validate(global::LightSwitchApplication.TimeTracking e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Engineers_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Engineers_GetCoreImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.ImplementationEntity.Engineers;
                }
                private static global::LightSwitchApplication.Engineer _Engineers_GetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Engineer, global::LightSwitchApplication.Engineer.DetailsClass>(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers, ref d._Engineers);
                }
                private static void _Engineers_SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d, global::LightSwitchApplication.Engineer v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers, ref d._Engineers, (i, ev) => i.Engineers = ev, v);
                }
                private static void _Engineers_Refresh(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Engineers, ref d._Engineers);
                }
                private static void _Engineers_OnValueChanged(global::LightSwitchApplication.TimeTracking e)
                {
                    e.Engineers_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue>.Entry
                    Issue = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue>.Entry(
                        "Issue",
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_Stub,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_ComputeIsReadOnly,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_Validate,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_GetCoreImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_GetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_SetImplementationValue,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_Refresh,
                        global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties._Issue_OnValueChanged);
                private static void _Issue_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.TimeTracking.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue>.Data> c, global::LightSwitchApplication.TimeTracking.DetailsClass d, object sf)
                {
                    c(d, ref d._Issue, sf);
                }
                private static bool _Issue_ComputeIsReadOnly(global::LightSwitchApplication.TimeTracking e)
                {
                    bool result = false;
                    e.Issue_IsReadOnly(ref result);
                    return result;
                }
                private static void _Issue_Validate(global::LightSwitchApplication.TimeTracking e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Issue_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Issue_GetCoreImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.ImplementationEntity.Issue;
                }
                private static global::LightSwitchApplication.Issue _Issue_GetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Issue, global::LightSwitchApplication.Issue.DetailsClass>(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue, ref d._Issue);
                }
                private static void _Issue_SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass d, global::LightSwitchApplication.Issue v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue, ref d._Issue, (i, ev) => i.Issue = ev, v);
                }
                private static void _Issue_Refresh(global::LightSwitchApplication.TimeTracking.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.TimeTracking.DetailsClass.PropertySetProperties.Issue, ref d._Issue);
                }
                private static void _Issue_OnValueChanged(global::LightSwitchApplication.TimeTracking e)
                {
                    e.Issue_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, byte[]>.Data _RowVersion;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, int>.Data _DurationMins;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Engineer>.Data _Engineers;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.TimeTracking, global::LightSwitchApplication.TimeTracking.DetailsClass, global::LightSwitchApplication.Issue>.Data _Issue;
            
        }
    
        #endregion
    }
    
    #endregion
}