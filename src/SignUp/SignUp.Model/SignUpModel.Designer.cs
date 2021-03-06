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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(SignUp.Model.Country), "Prospects", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SignUp.Model.Prospect))]
[assembly: EdmRelationshipAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(SignUp.Model.Role), "Prospects", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SignUp.Model.Prospect))]

#endregion

namespace SignUp.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SignUpDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SignUpDbEntities object using the connection string found in the 'SignUpDbEntities' section of the application configuration file.
        /// </summary>
        public SignUpDbEntities() : base("name=SignUpDbEntities", "SignUpDbEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SignUpDbEntities object.
        /// </summary>
        public SignUpDbEntities(string connectionString) : base(connectionString, "SignUpDbEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SignUpDbEntities object.
        /// </summary>
        public SignUpDbEntities(EntityConnection connection) : base(connection, "SignUpDbEntities")
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
        public ObjectSet<Country> Countries
        {
            get
            {
                if ((_Countries == null))
                {
                    _Countries = base.CreateObjectSet<Country>("Countries");
                }
                return _Countries;
            }
        }
        private ObjectSet<Country> _Countries;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Prospect> Prospects
        {
            get
            {
                if ((_Prospects == null))
                {
                    _Prospects = base.CreateObjectSet<Prospect>("Prospects");
                }
                return _Prospects;
            }
        }
        private ObjectSet<Prospect> _Prospects;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Role> Roles
        {
            get
            {
                if ((_Roles == null))
                {
                    _Roles = base.CreateObjectSet<Role>("Roles");
                }
                return _Roles;
            }
        }
        private ObjectSet<Role> _Roles;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Countries EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCountries(Country country)
        {
            base.AddObject("Countries", country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Prospects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProspects(Prospect prospect)
        {
            base.AddObject("Prospects", prospect);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRoles(Role role)
        {
            base.AddObject("Roles", role);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SignUpDbModel", Name="Country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Country object.
        /// </summary>
        /// <param name="countryCode">Initial value of the CountryCode property.</param>
        public static Country CreateCountry(global::System.String countryCode)
        {
            Country country = new Country();
            country.CountryCode = countryCode;
            return country;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CountryCode
        {
            get
            {
                return _CountryCode;
            }
            set
            {
                if (_CountryCode != value)
                {
                    OnCountryCodeChanging(value);
                    ReportPropertyChanging("CountryCode");
                    _CountryCode = StructuralObject.SetValidValue(value, false, "CountryCode");
                    ReportPropertyChanged("CountryCode");
                    OnCountryCodeChanged();
                }
            }
        }
        private global::System.String _CountryCode;
        partial void OnCountryCodeChanging(global::System.String value);
        partial void OnCountryCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CountryName
        {
            get
            {
                return _CountryName;
            }
            set
            {
                OnCountryNameChanging(value);
                ReportPropertyChanging("CountryName");
                _CountryName = StructuralObject.SetValidValue(value, true, "CountryName");
                ReportPropertyChanged("CountryName");
                OnCountryNameChanged();
            }
        }
        private global::System.String _CountryName;
        partial void OnCountryNameChanging(global::System.String value);
        partial void OnCountryNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Prospects")]
        public EntityCollection<Prospect> Prospects
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Prospect>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Prospects");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Prospect>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Prospects", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SignUpDbModel", Name="Prospect")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Prospect : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Prospect object.
        /// </summary>
        /// <param name="prospectId">Initial value of the ProspectId property.</param>
        public static Prospect CreateProspect(global::System.Int32 prospectId)
        {
            Prospect prospect = new Prospect();
            prospect.ProspectId = prospectId;
            return prospect;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProspectId
        {
            get
            {
                return _ProspectId;
            }
            set
            {
                if (_ProspectId != value)
                {
                    OnProspectIdChanging(value);
                    ReportPropertyChanging("ProspectId");
                    _ProspectId = StructuralObject.SetValidValue(value, "ProspectId");
                    ReportPropertyChanged("ProspectId");
                    OnProspectIdChanged();
                }
            }
        }
        private global::System.Int32 _ProspectId;
        partial void OnProspectIdChanging(global::System.Int32 value);
        partial void OnProspectIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                OnCompanyNameChanging(value);
                ReportPropertyChanging("CompanyName");
                _CompanyName = StructuralObject.SetValidValue(value, true, "CompanyName");
                ReportPropertyChanged("CompanyName");
                OnCompanyNameChanged();
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true, "EmailAddress");
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries")]
        public Country Country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Country>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Country>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Country> CountryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Country>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Country>("SignUpDbModel.FK_dbo_Prospects_dbo_Countries_Country_CountryCode", "Countries", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles")]
        public Role Role
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Role> RoleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Role>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Roles", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SignUpDbModel", Name="Role")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Role : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Role object.
        /// </summary>
        /// <param name="roleCode">Initial value of the RoleCode property.</param>
        public static Role CreateRole(global::System.String roleCode)
        {
            Role role = new Role();
            role.RoleCode = roleCode;
            return role;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String RoleCode
        {
            get
            {
                return _RoleCode;
            }
            set
            {
                if (_RoleCode != value)
                {
                    OnRoleCodeChanging(value);
                    ReportPropertyChanging("RoleCode");
                    _RoleCode = StructuralObject.SetValidValue(value, false, "RoleCode");
                    ReportPropertyChanged("RoleCode");
                    OnRoleCodeChanged();
                }
            }
        }
        private global::System.String _RoleCode;
        partial void OnRoleCodeChanging(global::System.String value);
        partial void OnRoleCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                OnRoleNameChanging(value);
                ReportPropertyChanging("RoleName");
                _RoleName = StructuralObject.SetValidValue(value, true, "RoleName");
                ReportPropertyChanged("RoleName");
                OnRoleNameChanged();
            }
        }
        private global::System.String _RoleName;
        partial void OnRoleNameChanging(global::System.String value);
        partial void OnRoleNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SignUpDbModel", "FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Prospects")]
        public EntityCollection<Prospect> Prospects
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Prospect>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Prospects");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Prospect>("SignUpDbModel.FK_dbo_Prospects_dbo_Roles_Role_RoleCode", "Prospects", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
