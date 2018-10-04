/*
               File: type_SdtGAMApplicationDelegateAuthorization
        Description: GAMApplicationDelegateAuthorization
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:52.78
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
   public class SdtGAMApplicationDelegateAuthorization : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationDelegateAuthorization( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationDelegateAuthorization( IGxContext context )
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
         if ( GAMApplicationDelegateAuthorization_externalReference == null )
         {
            GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationDelegateAuthorization_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationDelegateAuthorization_externalReference == null )
         {
            GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationDelegateAuthorization_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationDelegateAuthorization_externalReference == null )
         {
            GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationDelegateAuthorization_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Version
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference.Version ;
         }

         set {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            GAMApplicationDelegateAuthorization_externalReference.Version = value;
            SetDirty("Version");
         }

      }

      public String gxTpr_Filename
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference.FileName ;
         }

         set {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            GAMApplicationDelegateAuthorization_externalReference.FileName = value;
            SetDirty("Filename");
         }

      }

      public String gxTpr_Package
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference.Package ;
         }

         set {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            GAMApplicationDelegateAuthorization_externalReference.Package = value;
            SetDirty("Package");
         }

      }

      public String gxTpr_Classname
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference.ClassName ;
         }

         set {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            GAMApplicationDelegateAuthorization_externalReference.ClassName = value;
            SetDirty("Classname");
         }

      }

      public String gxTpr_Method
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference.Method ;
         }

         set {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            GAMApplicationDelegateAuthorization_externalReference.Method = value;
            SetDirty("Method");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationDelegateAuthorization_externalReference == null )
            {
               GAMApplicationDelegateAuthorization_externalReference = new Artech.Security.GAMApplicationDelegateAuthorization(context);
            }
            return GAMApplicationDelegateAuthorization_externalReference ;
         }

         set {
            GAMApplicationDelegateAuthorization_externalReference = (Artech.Security.GAMApplicationDelegateAuthorization)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationDelegateAuthorization GAMApplicationDelegateAuthorization_externalReference=null ;
   }

}
