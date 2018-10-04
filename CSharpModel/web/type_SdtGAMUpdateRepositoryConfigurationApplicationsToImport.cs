/*
               File: type_SdtGAMUpdateRepositoryConfigurationApplicationsToImport
        Description: GAMUpdateRepositoryConfigurationApplicationsToImport
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.48
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
   public class SdtGAMUpdateRepositoryConfigurationApplicationsToImport : GxUserType, IGxExternalObject
   {
      public SdtGAMUpdateRepositoryConfigurationApplicationsToImport( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUpdateRepositoryConfigurationApplicationsToImport( IGxContext context )
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
         if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
         {
            GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
         {
            GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
         {
            GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Identifier
      {
         get {
            if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
            {
               GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
            }
            return GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference.Identifier ;
         }

         set {
            if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
            {
               GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
            }
            GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference.Identifier = value;
            SetDirty("Identifier");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference == null )
            {
               GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = new Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport(context);
            }
            return GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference ;
         }

         set {
            GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference = (Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUpdateRepositoryConfigurationApplicationsToImport GAMUpdateRepositoryConfigurationApplicationsToImport_externalReference=null ;
   }

}
