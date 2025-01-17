﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 04/11/2012 22:24:15
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for SQLEngineersObjectContext in the schema.
    /// </summary>
    public partial class SQLEngineersObjectContext : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SQLEngineersObjectContext object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public SQLEngineersObjectContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("LightSwitchApplication", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("LightSwitchApplication.Implementation", typeName.Substring(22)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("LightSwitchApplication.Implementation", global::System.StringComparison.Ordinal))
            {
                return string.Concat("LightSwitchApplication.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Employee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Employee> Employee
        {
            get
            {
                if ((this._Employee == null))
                {
                    this._Employee = base.CreateQuery<Employee>("Employee");
                }
                return this._Employee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Employee> _Employee;
        /// <summary>
        /// There are no comments for Employee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToEmployee(Employee employee)
        {
            base.AddObject("Employee", employee);
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.Employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EngineerId
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Employee")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("EngineerId")]
    public partial class Employee : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="engineerId">Initial value of EngineerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Employee CreateEmployee(int engineerId)
        {
            Employee employee = new Employee();
            employee.EngineerId = engineerId;
            return employee;
        }
        /// <summary>
        /// There are no comments for Property EngineerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int EngineerId
        {
            get
            {
                return this._EngineerId;
            }
            set
            {
                this.OnEngineerIdChanging(value);
                if (object.Equals(this.EngineerId, value))
                {
                    return;
                }
                this._EngineerId = value;
                this.OnEngineerIdChanged();
                this.OnPropertyChanged("EngineerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _EngineerId;
        partial void OnEngineerIdChanging(int value);
        partial void OnEngineerIdChanged();
        /// <summary>
        /// There are no comments for Property SSN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SSN
        {
            get
            {
                return this._SSN;
            }
            set
            {
                this.OnSSNChanging(value);
                if (object.Equals(this.SSN, value))
                {
                    return;
                }
                this._SSN = value;
                this.OnSSNChanged();
                this.OnPropertyChanged("SSN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SSN;
        partial void OnSSNChanging(string value);
        partial void OnSSNChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
