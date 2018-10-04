/*
               File: type_SdtGAMAuthenticationWebService
        Description: GAMAuthenticationWebService
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.19
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
   public class SdtGAMAuthenticationWebService : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationWebService( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationWebService( IGxContext context )
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
         if ( GAMAuthenticationWebService_externalReference == null )
         {
            GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationWebService_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationWebService_externalReference == null )
         {
            GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationWebService_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationWebService_externalReference == null )
         {
            GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationWebService_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Version
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Version ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Version = value;
            SetDirty("Version");
         }

      }

      public String gxTpr_Privateencryptkey
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.PrivateEncryptKey ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.PrivateEncryptKey = value;
            SetDirty("Privateencryptkey");
         }

      }

      public int gxTpr_Timeout
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Timeout ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Timeout = value;
            SetDirty("Timeout");
         }

      }

      public String gxTpr_Package
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Package ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Package = value;
            SetDirty("Package");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Extension
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Extension ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Extension = value;
            SetDirty("Extension");
         }

      }

      public String gxTpr_Method
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference.Method ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            GAMAuthenticationWebService_externalReference.Method = value;
            SetDirty("Method");
         }

      }

      public SdtGAMAuthenticationWebServiceServer gxTpr_Server
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            SdtGAMAuthenticationWebServiceServer intValue ;
            intValue = new SdtGAMAuthenticationWebServiceServer(context);
            Artech.Security.GAMAuthenticationWebServiceServer externalParm0 ;
            externalParm0 = GAMAuthenticationWebService_externalReference.Server;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            SdtGAMAuthenticationWebServiceServer intValue ;
            Artech.Security.GAMAuthenticationWebServiceServer externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationWebServiceServer)(intValue.ExternalInstance);
            GAMAuthenticationWebService_externalReference.Server = externalParm1;
            SetDirty("Server");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationWebService_externalReference == null )
            {
               GAMAuthenticationWebService_externalReference = new Artech.Security.GAMAuthenticationWebService(context);
            }
            return GAMAuthenticationWebService_externalReference ;
         }

         set {
            GAMAuthenticationWebService_externalReference = (Artech.Security.GAMAuthenticationWebService)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationWebService GAMAuthenticationWebService_externalReference=null ;
   }

}
