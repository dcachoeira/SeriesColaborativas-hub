/*
               File: type_SdtGAMAuthenticationTypeSimple
        Description: GAMAuthenticationTypeSimple
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.78
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
   public class SdtGAMAuthenticationTypeSimple : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeSimple( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeSimple( IGxContext context )
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
         if ( GAMAuthenticationTypeSimple_externalReference == null )
         {
            GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeSimple_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeSimple_externalReference == null )
         {
            GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeSimple_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeSimple_externalReference == null )
         {
            GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeSimple_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            GAMAuthenticationTypeSimple_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            GAMAuthenticationTypeSimple_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference.Type ;
         }

         set {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            GAMAuthenticationTypeSimple_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public bool gxTpr_Needusername
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference.NeedUserName ;
         }

         set {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            GAMAuthenticationTypeSimple_externalReference.NeedUserName = value;
            SetDirty("Needusername");
         }

      }

      public bool gxTpr_Redirtoauthenticate
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference.RedirToAuthenticate ;
         }

         set {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            GAMAuthenticationTypeSimple_externalReference.RedirToAuthenticate = value;
            SetDirty("Redirtoauthenticate");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeSimple_externalReference == null )
            {
               GAMAuthenticationTypeSimple_externalReference = new Artech.Security.GAMAuthenticationTypeSimple(context);
            }
            return GAMAuthenticationTypeSimple_externalReference ;
         }

         set {
            GAMAuthenticationTypeSimple_externalReference = (Artech.Security.GAMAuthenticationTypeSimple)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeSimple GAMAuthenticationTypeSimple_externalReference=null ;
   }

}
