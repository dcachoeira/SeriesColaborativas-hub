/*
               File: type_SdtGAMImportRepositoryConfiguration
        Description: GAMImportRepositoryConfiguration
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.76
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
   public class SdtGAMImportRepositoryConfiguration : GxUserType, IGxExternalObject
   {
      public SdtGAMImportRepositoryConfiguration( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMImportRepositoryConfiguration( IGxContext context )
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
         if ( GAMImportRepositoryConfiguration_externalReference == null )
         {
            GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
         }
         returntostring = "";
         returntostring = (String)(GAMImportRepositoryConfiguration_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMImportRepositoryConfiguration_externalReference == null )
         {
            GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMImportRepositoryConfiguration_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMImportRepositoryConfiguration_externalReference == null )
         {
            GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMImportRepositoryConfiguration_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Packagedirectorypath
      {
         get {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            return GAMImportRepositoryConfiguration_externalReference.PackageDirectoryPath ;
         }

         set {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            GAMImportRepositoryConfiguration_externalReference.PackageDirectoryPath = value;
            SetDirty("Packagedirectorypath");
         }

      }

      public SdtGAMRepositoryCreate gxTpr_Repositorycreate
      {
         get {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            SdtGAMRepositoryCreate intValue ;
            intValue = new SdtGAMRepositoryCreate(context);
            Artech.Security.GAMRepositoryCreate externalParm0 ;
            externalParm0 = GAMImportRepositoryConfiguration_externalReference.RepositoryCreate;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            SdtGAMRepositoryCreate intValue ;
            Artech.Security.GAMRepositoryCreate externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMRepositoryCreate)(intValue.ExternalInstance);
            GAMImportRepositoryConfiguration_externalReference.RepositoryCreate = externalParm1;
            SetDirty("Repositorycreate");
         }

      }

      public bool gxTpr_Updateconnectionfile
      {
         get {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            return GAMImportRepositoryConfiguration_externalReference.UpdateConnectionFile ;
         }

         set {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            GAMImportRepositoryConfiguration_externalReference.UpdateConnectionFile = value;
            SetDirty("Updateconnectionfile");
         }

      }

      public String gxTpr_Administratorrole
      {
         get {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            return GAMImportRepositoryConfiguration_externalReference.AdministratorRole ;
         }

         set {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            GAMImportRepositoryConfiguration_externalReference.AdministratorRole = value;
            SetDirty("Administratorrole");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMImportRepositoryConfiguration_externalReference == null )
            {
               GAMImportRepositoryConfiguration_externalReference = new Artech.Security.GAMImportRepositoryConfiguration(context);
            }
            return GAMImportRepositoryConfiguration_externalReference ;
         }

         set {
            GAMImportRepositoryConfiguration_externalReference = (Artech.Security.GAMImportRepositoryConfiguration)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMImportRepositoryConfiguration GAMImportRepositoryConfiguration_externalReference=null ;
   }

}
