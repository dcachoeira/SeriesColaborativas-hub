/*
               File: type_SdtGAMAuthenticationTwitter
        Description: GAMAuthenticationTwitter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.58
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
   public class SdtGAMAuthenticationTwitter : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTwitter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTwitter( IGxContext context )
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
         if ( GAMAuthenticationTwitter_externalReference == null )
         {
            GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTwitter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTwitter_externalReference == null )
         {
            GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTwitter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTwitter_externalReference == null )
         {
            GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTwitter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Consumerkey
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference.ConsumerKey ;
         }

         set {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            GAMAuthenticationTwitter_externalReference.ConsumerKey = value;
            SetDirty("Consumerkey");
         }

      }

      public String gxTpr_Consumersecret
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference.ConsumerSecret ;
         }

         set {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            GAMAuthenticationTwitter_externalReference.ConsumerSecret = value;
            SetDirty("Consumersecret");
         }

      }

      public String gxTpr_Callbackurl
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference.CallbackURL ;
         }

         set {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            GAMAuthenticationTwitter_externalReference.CallbackURL = value;
            SetDirty("Callbackurl");
         }

      }

      public String gxTpr_Additionalscope
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference.AdditionalScope ;
         }

         set {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            GAMAuthenticationTwitter_externalReference.AdditionalScope = value;
            SetDirty("Additionalscope");
         }

      }

      public String gxTpr_Versionpath
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference.VersionPath ;
         }

         set {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            GAMAuthenticationTwitter_externalReference.VersionPath = value;
            SetDirty("Versionpath");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTwitter_externalReference == null )
            {
               GAMAuthenticationTwitter_externalReference = new Artech.Security.GAMAuthenticationTwitter(context);
            }
            return GAMAuthenticationTwitter_externalReference ;
         }

         set {
            GAMAuthenticationTwitter_externalReference = (Artech.Security.GAMAuthenticationTwitter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTwitter GAMAuthenticationTwitter_externalReference=null ;
   }

}
