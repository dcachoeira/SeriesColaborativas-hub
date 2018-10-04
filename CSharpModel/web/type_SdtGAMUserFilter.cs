/*
               File: type_SdtGAMUserFilter
        Description: GAMUserFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.9
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtGAMUserFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMUserFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUserFilter( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMUserFilter_externalReference == null )
         {
            GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUserFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUserFilter_externalReference == null )
         {
            GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUserFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUserFilter_externalReference == null )
         {
            GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUserFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.GUID ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Namespace
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.NameSpace ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.NameSpace = value;
            SetDirty("Namespace");
         }

      }

      public String gxTpr_Authenticationtypename
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.AuthenticationTypeName ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.AuthenticationTypeName = value;
            SetDirty("Authenticationtypename");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Name ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Email
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.EMail ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.EMail = value;
            SetDirty("Email");
         }

      }

      public String gxTpr_Names
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Names ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Names = value;
            SetDirty("Names");
         }

      }

      public String gxTpr_Externalid
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.ExternalId ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.ExternalId = value;
            SetDirty("Externalid");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public String gxTpr_Gender
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Gender ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Gender = value;
            SetDirty("Gender");
         }

      }

      public String gxTpr_Isblocked
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.IsBlocked ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.IsBlocked = value;
            SetDirty("Isblocked");
         }

      }

      public String gxTpr_Isactive
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.IsActive ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.IsActive = value;
            SetDirty("Isactive");
         }

      }

      public String gxTpr_Isdeleted
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.IsDeleted ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.IsDeleted = value;
            SetDirty("Isdeleted");
         }

      }

      public String gxTpr_Isenabledinrepository
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.IsEnabledInRepository ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.IsEnabledInRepository = value;
            SetDirty("Isenabledinrepository");
         }

      }

      public bool gxTpr_Loadcustomattributes
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.LoadCustomAttributes ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.LoadCustomAttributes = value;
            SetDirty("Loadcustomattributes");
         }

      }

      public long gxTpr_Roleid
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.RoleId ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.RoleId = value;
            SetDirty("Roleid");
         }

      }

      public bool gxTpr_Searchrolesinherited
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.SearchRolesInherited ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.SearchRolesInherited = value;
            SetDirty("Searchrolesinherited");
         }

      }

      public String gxTpr_Searchable
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Searchable ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Searchable = value;
            SetDirty("Searchable");
         }

      }

      public bool gxTpr_Returnanonymoususer
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.ReturnAnonymousUser ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.ReturnAnonymousUser = value;
            SetDirty("Returnanonymoususer");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Start ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.Limit ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public GxSimpleCollection<long> gxTpr_Roles
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GxSimpleCollection<long> intValue ;
            intValue = new GxSimpleCollection<long>();
            System.Collections.Generic.List<System.Int64> externalParm0 ;
            externalParm0 = GAMUserFilter_externalReference.Roles;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<System.Int64>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GxSimpleCollection<long> intValue ;
            System.Collections.Generic.List<System.Int64> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<System.Int64>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<System.Int64>), intValue.ExternalInstance);
            GAMUserFilter_externalReference.Roles = externalParm1;
            SetDirty("Roles");
         }

      }

      public bool gxTpr_Withoutroles
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference.WithoutRoles ;
         }

         set {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            GAMUserFilter_externalReference.WithoutRoles = value;
            SetDirty("Withoutroles");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUserFilter_externalReference == null )
            {
               GAMUserFilter_externalReference = new Artech.Security.GAMUserFilter(context);
            }
            return GAMUserFilter_externalReference ;
         }

         set {
            GAMUserFilter_externalReference = (Artech.Security.GAMUserFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUserFilter GAMUserFilter_externalReference=null ;
   }

}
