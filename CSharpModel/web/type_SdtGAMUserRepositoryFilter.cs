/*
               File: type_SdtGAMUserRepositoryFilter
        Description: GAMUserRepositoryFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.36
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
   public class SdtGAMUserRepositoryFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMUserRepositoryFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUserRepositoryFilter( IGxContext context )
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
         if ( GAMUserRepositoryFilter_externalReference == null )
         {
            GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUserRepositoryFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUserRepositoryFilter_externalReference == null )
         {
            GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUserRepositoryFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUserRepositoryFilter_externalReference == null )
         {
            GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUserRepositoryFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Repositoryid
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.RepositoryId ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.RepositoryId = value;
            SetDirty("Repositoryid");
         }

      }

      public String gxTpr_Repositoryguid
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.RepositoryGUID ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.RepositoryGUID = value;
            SetDirty("Repositoryguid");
         }

      }

      public String gxTpr_Repositoryname
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.RepositoryName ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.RepositoryName = value;
            SetDirty("Repositoryname");
         }

      }

      public String gxTpr_Repositorydescription
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.RepositoryDescription ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.RepositoryDescription = value;
            SetDirty("Repositorydescription");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public long gxTpr_Roleid
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.RoleId ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.RoleId = value;
            SetDirty("Roleid");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.Start ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference.Limit ;
         }

         set {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            GAMUserRepositoryFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUserRepositoryFilter_externalReference == null )
            {
               GAMUserRepositoryFilter_externalReference = new Artech.Security.GAMUserRepositoryFilter(context);
            }
            return GAMUserRepositoryFilter_externalReference ;
         }

         set {
            GAMUserRepositoryFilter_externalReference = (Artech.Security.GAMUserRepositoryFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUserRepositoryFilter GAMUserRepositoryFilter_externalReference=null ;
   }

}
