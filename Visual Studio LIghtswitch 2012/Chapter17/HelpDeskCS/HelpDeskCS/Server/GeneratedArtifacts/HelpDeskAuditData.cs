﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace HelpDeskAuditData.Implementation
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class HelpDeskAuditDataObjectContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new HelpDeskAuditDataObjectContext object using the connection string found in the 'HelpDeskAuditDataObjectContext' section of the application configuration file.
        /// </summary>
        public HelpDeskAuditDataObjectContext() : base("name=HelpDeskAuditDataObjectContext", "HelpDeskAuditDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HelpDeskAuditDataObjectContext object.
        /// </summary>
        public HelpDeskAuditDataObjectContext(string connectionString) : base(connectionString, "HelpDeskAuditDataObjectContext")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new HelpDeskAuditDataObjectContext object.
        /// </summary>
        public HelpDeskAuditDataObjectContext(EntityConnection connection) : base(connection, "HelpDeskAuditDataObjectContext")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AuditDetail> AuditDetails
        {
            get
            {
                if ((_AuditDetails == null))
                {
                    _AuditDetails = base.CreateObjectSet<AuditDetail>("AuditDetails");
                }
                return _AuditDetails;
            }
        }
        private ObjectSet<AuditDetail> _AuditDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AuditDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAuditDetails(AuditDetail auditDetail)
        {
            base.AddObject("AuditDetails", auditDetail);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="AuditDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AuditDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AuditDetail object.
        /// </summary>
        /// <param name="auditID">Initial value of the AuditID property.</param>
        public static AuditDetail CreateAuditDetail(global::System.Int32 auditID)
        {
            AuditDetail auditDetail = new AuditDetail();
            auditDetail.AuditID = auditID;
            return auditDetail;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AuditID
        {
            get
            {
                return _AuditID;
            }
            set
            {
                if (_AuditID != value)
                {
                    OnAuditIDChanging(value);
                    ReportPropertyChanging("AuditID");
                    _AuditID = value;
                    ReportPropertyChanged("AuditID");
                    OnAuditIDChanged();
                }
            }
        }
        private global::System.Int32 _AuditID;
        partial void OnAuditIDChanging(global::System.Int32 value);
        partial void OnAuditIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AuditDesc
        {
            get
            {
                return _AuditDesc;
            }
            set
            {
                OnAuditDescChanging(value);
                ReportPropertyChanging("AuditDesc");
                _AuditDesc = value;
                ReportPropertyChanged("AuditDesc");
                OnAuditDescChanged();
            }
        }
        private global::System.String _AuditDesc;
        partial void OnAuditDescChanging(global::System.String value);
        partial void OnAuditDescChanged();

        #endregion

    
    }

    #endregion

    
}
