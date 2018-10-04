/*
               File: type_SdtGAMConnectionInfo
        Description: GAMConnectionInfo
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.32
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
   public class SdtGAMConnectionInfo : GxUserType, IGxExternalObject
   {
      public SdtGAMConnectionInfo( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMConnectionInfo( IGxContext context )
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
         if ( GAMConnectionInfo_externalReference == null )
         {
            GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
         }
         returntostring = "";
         returntostring = (String)(GAMConnectionInfo_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMConnectionInfo_externalReference == null )
         {
            GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMConnectionInfo_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMConnectionInfo_externalReference == null )
         {
            GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMConnectionInfo_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.Name ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Repositoryname
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.RepositoryName ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.RepositoryName = value;
            SetDirty("Repositoryname");
         }

      }

      public String gxTpr_Repositoryguid
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.RepositoryGUID ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.RepositoryGUID = value;
            SetDirty("Repositoryguid");
         }

      }

      public String gxTpr_Repositorynamespace
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.RepositoryNameSpace ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.RepositoryNameSpace = value;
            SetDirty("Repositorynamespace");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.Type ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Language
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.Language ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.Language = value;
            SetDirty("Language");
         }

      }

      public String gxTpr_Username
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.UserName ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.UserName = value;
            SetDirty("Username");
         }

      }

      public String gxTpr_Userpassword
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference.UserPassword ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GAMConnectionInfo_externalReference.UserPassword = value;
            SetDirty("Userpassword");
         }

      }

      public GXExternalCollection<SdtGAMConnectionInfoProperties> gxTpr_Properties
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GXExternalCollection<SdtGAMConnectionInfoProperties> intValue ;
            intValue = new GXExternalCollection<SdtGAMConnectionInfoProperties>( context, "SdtGAMConnectionInfoProperties", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMConnectionInfoProperties> externalParm0 ;
            externalParm0 = GAMConnectionInfo_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMConnectionInfoProperties>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            GXExternalCollection<SdtGAMConnectionInfoProperties> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMConnectionInfoProperties> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMConnectionInfoProperties>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMConnectionInfoProperties>), intValue.ExternalInstance);
            GAMConnectionInfo_externalReference.Properties = externalParm1;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMConnectionInfo_externalReference == null )
            {
               GAMConnectionInfo_externalReference = new Artech.Security.GAMConnectionInfo(context);
            }
            return GAMConnectionInfo_externalReference ;
         }

         set {
            GAMConnectionInfo_externalReference = (Artech.Security.GAMConnectionInfo)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMConnectionInfo GAMConnectionInfo_externalReference=null ;
   }

}
