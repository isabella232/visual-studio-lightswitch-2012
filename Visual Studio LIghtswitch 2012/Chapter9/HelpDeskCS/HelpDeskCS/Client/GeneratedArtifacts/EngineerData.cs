﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 27/07/2013 00:23:54
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for EngineerDataObjectContext in the schema.
    /// </summary>
    public partial class EngineerDataObjectContext : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new EngineerDataObjectContext object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public EngineerDataObjectContext(global::System.Uri serviceRoot) : 
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
        /// There are no comments for EngineerRecords in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<EngineerRecord> EngineerRecords
        {
            get
            {
                if ((this._EngineerRecords == null))
                {
                    this._EngineerRecords = base.CreateQuery<EngineerRecord>("EngineerRecords");
                }
                return this._EngineerRecords;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<EngineerRecord> _EngineerRecords;
        /// <summary>
        /// There are no comments for EngineerRecords in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToEngineerRecords(EngineerRecord engineerRecord)
        {
            base.AddObject("EngineerRecords", engineerRecord);
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.EngineerRecord in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("EngineerRecords")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class EngineerRecord : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineerRecord object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="surname">Initial value of Surname.</param>
        /// <param name="firstname">Initial value of Firstname.</param>
        /// <param name="dateOfBirth">Initial value of DateOfBirth.</param>
        /// <param name="securityVetted">Initial value of SecurityVetted.</param>
        /// <param name="issueCount">Initial value of IssueCount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static EngineerRecord CreateEngineerRecord(int ID, string surname, string firstname, global::System.DateTime dateOfBirth, bool securityVetted, int issueCount)
        {
            EngineerRecord engineerRecord = new EngineerRecord();
            engineerRecord.Id = ID;
            engineerRecord.Surname = surname;
            engineerRecord.Firstname = firstname;
            engineerRecord.DateOfBirth = dateOfBirth;
            engineerRecord.SecurityVetted = securityVetted;
            engineerRecord.IssueCount = issueCount;
            return engineerRecord;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                if (object.Equals(this.Id, value))
                {
                    return;
                }
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Surname in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Surname
        {
            get
            {
                return this._Surname;
            }
            set
            {
                this.OnSurnameChanging(value);
                if (object.Equals(this.Surname, value))
                {
                    return;
                }
                this._Surname = value;
                this.OnSurnameChanged();
                this.OnPropertyChanged("Surname");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Surname;
        partial void OnSurnameChanging(string value);
        partial void OnSurnameChanged();
        /// <summary>
        /// There are no comments for Property Firstname in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Firstname
        {
            get
            {
                return this._Firstname;
            }
            set
            {
                this.OnFirstnameChanging(value);
                if (object.Equals(this.Firstname, value))
                {
                    return;
                }
                this._Firstname = value;
                this.OnFirstnameChanged();
                this.OnPropertyChanged("Firstname");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Firstname;
        partial void OnFirstnameChanging(string value);
        partial void OnFirstnameChanged();
        /// <summary>
        /// There are no comments for Property DateOfBirth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime DateOfBirth
        {
            get
            {
                return this._DateOfBirth;
            }
            set
            {
                this.OnDateOfBirthChanging(value);
                if (object.Equals(this.DateOfBirth, value))
                {
                    return;
                }
                this._DateOfBirth = value;
                this.OnDateOfBirthChanged();
                this.OnPropertyChanged("DateOfBirth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.DateTime value);
        partial void OnDateOfBirthChanged();
        /// <summary>
        /// There are no comments for Property SecurityVetted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool SecurityVetted
        {
            get
            {
                return this._SecurityVetted;
            }
            set
            {
                this.OnSecurityVettedChanging(value);
                if (object.Equals(this.SecurityVetted, value))
                {
                    return;
                }
                this._SecurityVetted = value;
                this.OnSecurityVettedChanged();
                this.OnPropertyChanged("SecurityVetted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _SecurityVetted;
        partial void OnSecurityVettedChanging(bool value);
        partial void OnSecurityVettedChanged();
        /// <summary>
        /// There are no comments for Property IssueCount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int IssueCount
        {
            get
            {
                return this._IssueCount;
            }
            set
            {
                this.OnIssueCountChanging(value);
                if (object.Equals(this.IssueCount, value))
                {
                    return;
                }
                this._IssueCount = value;
                this.OnIssueCountChanged();
                this.OnPropertyChanged("IssueCount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _IssueCount;
        partial void OnIssueCountChanging(int value);
        partial void OnIssueCountChanged();
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
