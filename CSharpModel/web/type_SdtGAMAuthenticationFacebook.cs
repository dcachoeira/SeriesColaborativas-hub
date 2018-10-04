/*
               File: type_SdtGAMAuthenticationFacebook
        Description: GAMAuthenticationFacebook
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.46
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
   public class SdtGAMAuthenticationFacebook : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationFacebook( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationFacebook( IGxContext context )
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
         if ( GAMAuthenticationFacebook_externalReference == null )
         {
            GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationFacebook_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationFacebook_externalReference == null )
         {
            GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationFacebook_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationFacebook_externalReference == null )
         {
            GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationFacebook_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Clientid
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference.ClientId ;
         }

         set {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            GAMAuthenticationFacebook_externalReference.ClientId = value;
            SetDirty("Clientid");
         }

      }

      public String gxTpr_Clientsecret
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference.ClientSecret ;
         }

         set {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            GAMAuthenticationFacebook_externalReference.ClientSecret = value;
            SetDirty("Clientsecret");
         }

      }

      public String gxTpr_Siteurl
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference.SiteURL ;
         }

         set {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            GAMAuthenticationFacebook_externalReference.SiteURL = value;
            SetDirty("Siteurl");
         }

      }

      public String gxTpr_Additionalscope
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference.AdditionalScope ;
         }

         set {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            GAMAuthenticationFacebook_externalReference.AdditionalScope = value;
            SetDirty("Additionalscope");
         }

      }

      public String gxTpr_Versionpath
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference.VersionPath ;
         }

         set {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            GAMAuthenticationFacebook_externalReference.VersionPath = value;
            SetDirty("Versionpath");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationFacebook_externalReference == null )
            {
               GAMAuthenticationFacebook_externalReference = new Artech.Security.GAMAuthenticationFacebook(context);
            }
            return GAMAuthenticationFacebook_externalReference ;
         }

         set {
            GAMAuthenticationFacebook_externalReference = (Artech.Security.GAMAuthenticationFacebook)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationFacebook GAMAuthenticationFacebook_externalReference=null ;
   }

}
