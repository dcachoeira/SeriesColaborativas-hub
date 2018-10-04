/*
               File: type_SdtGAMAuthenticationGAMRemote
        Description: GAMAuthenticationGAMRemote
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.50
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
   public class SdtGAMAuthenticationGAMRemote : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationGAMRemote( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationGAMRemote( IGxContext context )
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
         if ( GAMAuthenticationGAMRemote_externalReference == null )
         {
            GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationGAMRemote_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationGAMRemote_externalReference == null )
         {
            GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationGAMRemote_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationGAMRemote_externalReference == null )
         {
            GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationGAMRemote_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Clientid
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.ClientId ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.ClientId = value;
            SetDirty("Clientid");
         }

      }

      public String gxTpr_Clientsecret
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.ClientSecret ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.ClientSecret = value;
            SetDirty("Clientsecret");
         }

      }

      public String gxTpr_Siteurl
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.SiteURL ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.SiteURL = value;
            SetDirty("Siteurl");
         }

      }

      public String gxTpr_Additionalscope
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.AdditionalScope ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.AdditionalScope = value;
            SetDirty("Additionalscope");
         }

      }

      public String gxTpr_Remoteserverurl
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.RemoteServerURL ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.RemoteServerURL = value;
            SetDirty("Remoteserverurl");
         }

      }

      public String gxTpr_Remoteserverkey
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.RemoteServerKey ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.RemoteServerKey = value;
            SetDirty("Remoteserverkey");
         }

      }

      public String gxTpr_Remoterepositoryguid
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference.RemoteRepositoryGUID ;
         }

         set {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            GAMAuthenticationGAMRemote_externalReference.RemoteRepositoryGUID = value;
            SetDirty("Remoterepositoryguid");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationGAMRemote_externalReference == null )
            {
               GAMAuthenticationGAMRemote_externalReference = new Artech.Security.GAMAuthenticationGAMRemote(context);
            }
            return GAMAuthenticationGAMRemote_externalReference ;
         }

         set {
            GAMAuthenticationGAMRemote_externalReference = (Artech.Security.GAMAuthenticationGAMRemote)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationGAMRemote GAMAuthenticationGAMRemote_externalReference=null ;
   }

}
