/*
               File: type_SdtGAMUserRepository
        Description: GAMUserRepository
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.26
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
   public class SdtGAMUserRepository : GxUserType, IGxExternalObject
   {
      public SdtGAMUserRepository( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUserRepository( IGxContext context )
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
         if ( GAMUserRepository_externalReference == null )
         {
            GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUserRepository_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUserRepository_externalReference == null )
         {
            GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUserRepository_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUserRepository_externalReference == null )
         {
            GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUserRepository_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Repositoryid
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.RepositoryId ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.RepositoryId = value;
            SetDirty("Repositoryid");
         }

      }

      public String gxTpr_Repositoryguid
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.RepositoryGUID ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.RepositoryGUID = value;
            SetDirty("Repositoryguid");
         }

      }

      public String gxTpr_Repositoryname
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.RepositoryName ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.RepositoryName = value;
            SetDirty("Repositoryname");
         }

      }

      public String gxTpr_Repositorydescription
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.RepositoryDescription ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.RepositoryDescription = value;
            SetDirty("Repositorydescription");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public long gxTpr_Roleid
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.RoleId ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.RoleId = value;
            SetDirty("Roleid");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.DateCreated ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.UserCreated ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.DateUpdated ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference.UserUpdated ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GAMUserRepository_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm0 ;
            externalParm0 = GAMUserRepository_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMUserRepository_externalReference.Properties = externalParm1;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUserRepository_externalReference == null )
            {
               GAMUserRepository_externalReference = new Artech.Security.GAMUserRepository(context);
            }
            return GAMUserRepository_externalReference ;
         }

         set {
            GAMUserRepository_externalReference = (Artech.Security.GAMUserRepository)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUserRepository GAMUserRepository_externalReference=null ;
   }

}
