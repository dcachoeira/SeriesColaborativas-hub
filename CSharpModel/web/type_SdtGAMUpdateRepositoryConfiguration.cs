/*
               File: type_SdtGAMUpdateRepositoryConfiguration
        Description: GAMUpdateRepositoryConfiguration
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.44
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
   public class SdtGAMUpdateRepositoryConfiguration : GxUserType, IGxExternalObject
   {
      public SdtGAMUpdateRepositoryConfiguration( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUpdateRepositoryConfiguration( IGxContext context )
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
         if ( GAMUpdateRepositoryConfiguration_externalReference == null )
         {
            GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUpdateRepositoryConfiguration_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUpdateRepositoryConfiguration_externalReference == null )
         {
            GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUpdateRepositoryConfiguration_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUpdateRepositoryConfiguration_externalReference == null )
         {
            GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUpdateRepositoryConfiguration_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Packagedirectorypath
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            return GAMUpdateRepositoryConfiguration_externalReference.PackageDirectoryPath ;
         }

         set {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GAMUpdateRepositoryConfiguration_externalReference.PackageDirectoryPath = value;
            SetDirty("Packagedirectorypath");
         }

      }

      public bool gxTpr_Fullimport
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            return GAMUpdateRepositoryConfiguration_externalReference.FullImport ;
         }

         set {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GAMUpdateRepositoryConfiguration_externalReference.FullImport = value;
            SetDirty("Fullimport");
         }

      }

      public bool gxTpr_Importallroles
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            return GAMUpdateRepositoryConfiguration_externalReference.ImportAllRoles ;
         }

         set {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GAMUpdateRepositoryConfiguration_externalReference.ImportAllRoles = value;
            SetDirty("Importallroles");
         }

      }

      public bool gxTpr_Importallapplications
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            return GAMUpdateRepositoryConfiguration_externalReference.ImportAllApplications ;
         }

         set {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GAMUpdateRepositoryConfiguration_externalReference.ImportAllApplications = value;
            SetDirty("Importallapplications");
         }

      }

      public GXExternalCollection<SdtGAMUpdateRepositoryConfigurationApplicationsToImport> gxTpr_Applicationstoimport
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GXExternalCollection<SdtGAMUpdateRepositoryConfigurationApplicationsToImport> intValue ;
            intValue = new GXExternalCollection<SdtGAMUpdateRepositoryConfigurationApplicationsToImport>( context, "SdtGAMUpdateRepositoryConfigurationApplicationsToImport", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport> externalParm0 ;
            externalParm0 = GAMUpdateRepositoryConfiguration_externalReference.ApplicationsToImport;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            GXExternalCollection<SdtGAMUpdateRepositoryConfigurationApplicationsToImport> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport>), intValue.ExternalInstance);
            GAMUpdateRepositoryConfiguration_externalReference.ApplicationsToImport = externalParm1;
            SetDirty("Applicationstoimport");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUpdateRepositoryConfiguration_externalReference == null )
            {
               GAMUpdateRepositoryConfiguration_externalReference = new Artech.Security.GAMUpdateRepositoryConfiguration(context);
            }
            return GAMUpdateRepositoryConfiguration_externalReference ;
         }

         set {
            GAMUpdateRepositoryConfiguration_externalReference = (Artech.Security.GAMUpdateRepositoryConfiguration)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUpdateRepositoryConfiguration GAMUpdateRepositoryConfiguration_externalReference=null ;
   }

}
