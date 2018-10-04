/*
               File: type_SdtGAMAuthenticationWebServiceServer
        Description: GAMAuthenticationWebServiceServer
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.26
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
   public class SdtGAMAuthenticationWebServiceServer : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationWebServiceServer( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationWebServiceServer( IGxContext context )
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
         if ( GAMAuthenticationWebServiceServer_externalReference == null )
         {
            GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationWebServiceServer_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationWebServiceServer_externalReference == null )
         {
            GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationWebServiceServer_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationWebServiceServer_externalReference == null )
         {
            GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationWebServiceServer_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            return GAMAuthenticationWebServiceServer_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            GAMAuthenticationWebServiceServer_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public int gxTpr_Port
      {
         get {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            return GAMAuthenticationWebServiceServer_externalReference.Port ;
         }

         set {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            GAMAuthenticationWebServiceServer_externalReference.Port = value;
            SetDirty("Port");
         }

      }

      public String gxTpr_Baseurl
      {
         get {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            return GAMAuthenticationWebServiceServer_externalReference.BaseURL ;
         }

         set {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            GAMAuthenticationWebServiceServer_externalReference.BaseURL = value;
            SetDirty("Baseurl");
         }

      }

      public short gxTpr_Secureprotocol
      {
         get {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            return GAMAuthenticationWebServiceServer_externalReference.SecureProtocol ;
         }

         set {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            GAMAuthenticationWebServiceServer_externalReference.SecureProtocol = value;
            SetDirty("Secureprotocol");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationWebServiceServer_externalReference == null )
            {
               GAMAuthenticationWebServiceServer_externalReference = new Artech.Security.GAMAuthenticationWebServiceServer(context);
            }
            return GAMAuthenticationWebServiceServer_externalReference ;
         }

         set {
            GAMAuthenticationWebServiceServer_externalReference = (Artech.Security.GAMAuthenticationWebServiceServer)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationWebServiceServer GAMAuthenticationWebServiceServer_externalReference=null ;
   }

}
