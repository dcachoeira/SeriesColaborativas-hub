/*
               File: type_SdtGAMAuthenticationCustom
        Description: GAMAuthenticationCustom
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.42
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
   public class SdtGAMAuthenticationCustom : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationCustom( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationCustom( IGxContext context )
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
         if ( GAMAuthenticationCustom_externalReference == null )
         {
            GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationCustom_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationCustom_externalReference == null )
         {
            GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationCustom_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationCustom_externalReference == null )
         {
            GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationCustom_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Version
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.Version ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.Version = value;
            SetDirty("Version");
         }

      }

      public String gxTpr_Privateencryptkey
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.PrivateEncryptKey ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.PrivateEncryptKey = value;
            SetDirty("Privateencryptkey");
         }

      }

      public String gxTpr_Filename
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.FileName ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.FileName = value;
            SetDirty("Filename");
         }

      }

      public String gxTpr_Package
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.Package ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.Package = value;
            SetDirty("Package");
         }

      }

      public String gxTpr_Classname
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.ClassName ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.ClassName = value;
            SetDirty("Classname");
         }

      }

      public String gxTpr_Method
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference.Method ;
         }

         set {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            GAMAuthenticationCustom_externalReference.Method = value;
            SetDirty("Method");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationCustom_externalReference == null )
            {
               GAMAuthenticationCustom_externalReference = new Artech.Security.GAMAuthenticationCustom(context);
            }
            return GAMAuthenticationCustom_externalReference ;
         }

         set {
            GAMAuthenticationCustom_externalReference = (Artech.Security.GAMAuthenticationCustom)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationCustom GAMAuthenticationCustom_externalReference=null ;
   }

}
