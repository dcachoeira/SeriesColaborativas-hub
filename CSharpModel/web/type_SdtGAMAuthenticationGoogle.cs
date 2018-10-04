/*
               File: type_SdtGAMAuthenticationGoogle
        Description: GAMAuthenticationGoogle
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.54
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
   public class SdtGAMAuthenticationGoogle : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationGoogle( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationGoogle( IGxContext context )
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
         if ( GAMAuthenticationGoogle_externalReference == null )
         {
            GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationGoogle_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationGoogle_externalReference == null )
         {
            GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationGoogle_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationGoogle_externalReference == null )
         {
            GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationGoogle_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Clientid
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference.ClientId ;
         }

         set {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            GAMAuthenticationGoogle_externalReference.ClientId = value;
            SetDirty("Clientid");
         }

      }

      public String gxTpr_Clientsecret
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference.ClientSecret ;
         }

         set {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            GAMAuthenticationGoogle_externalReference.ClientSecret = value;
            SetDirty("Clientsecret");
         }

      }

      public String gxTpr_Siteurl
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference.SiteURL ;
         }

         set {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            GAMAuthenticationGoogle_externalReference.SiteURL = value;
            SetDirty("Siteurl");
         }

      }

      public String gxTpr_Additionalscope
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference.AdditionalScope ;
         }

         set {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            GAMAuthenticationGoogle_externalReference.AdditionalScope = value;
            SetDirty("Additionalscope");
         }

      }

      public String gxTpr_Versionpath
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference.VersionPath ;
         }

         set {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            GAMAuthenticationGoogle_externalReference.VersionPath = value;
            SetDirty("Versionpath");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationGoogle_externalReference == null )
            {
               GAMAuthenticationGoogle_externalReference = new Artech.Security.GAMAuthenticationGoogle(context);
            }
            return GAMAuthenticationGoogle_externalReference ;
         }

         set {
            GAMAuthenticationGoogle_externalReference = (Artech.Security.GAMAuthenticationGoogle)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationGoogle GAMAuthenticationGoogle_externalReference=null ;
   }

}
