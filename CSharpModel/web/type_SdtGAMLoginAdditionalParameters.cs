/*
               File: type_SdtGAMLoginAdditionalParameters
        Description: GAMLoginAdditionalParameters
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.80
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
   public class SdtGAMLoginAdditionalParameters : GxUserType, IGxExternalObject
   {
      public SdtGAMLoginAdditionalParameters( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMLoginAdditionalParameters( IGxContext context )
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
         if ( GAMLoginAdditionalParameters_externalReference == null )
         {
            GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
         }
         returntostring = "";
         returntostring = (String)(GAMLoginAdditionalParameters_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMLoginAdditionalParameters_externalReference == null )
         {
            GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMLoginAdditionalParameters_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMLoginAdditionalParameters_externalReference == null )
         {
            GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMLoginAdditionalParameters_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Authenticationtypename
      {
         get {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            return GAMLoginAdditionalParameters_externalReference.AuthenticationTypeName ;
         }

         set {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            GAMLoginAdditionalParameters_externalReference.AuthenticationTypeName = value;
            SetDirty("Authenticationtypename");
         }

      }

      public short gxTpr_Rememberusertype
      {
         get {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            return GAMLoginAdditionalParameters_externalReference.RememberUserType ;
         }

         set {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            GAMLoginAdditionalParameters_externalReference.RememberUserType = value;
            SetDirty("Rememberusertype");
         }

      }

      public bool gxTpr_Isbatch
      {
         get {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            return GAMLoginAdditionalParameters_externalReference.isBatch ;
         }

         set {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            GAMLoginAdditionalParameters_externalReference.isBatch = value;
            SetDirty("Isbatch");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm0 ;
            externalParm0 = GAMLoginAdditionalParameters_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMLoginAdditionalParameters_externalReference.Properties = externalParm1;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMLoginAdditionalParameters_externalReference == null )
            {
               GAMLoginAdditionalParameters_externalReference = new Artech.Security.GAMLoginAdditionalParameters(context);
            }
            return GAMLoginAdditionalParameters_externalReference ;
         }

         set {
            GAMLoginAdditionalParameters_externalReference = (Artech.Security.GAMLoginAdditionalParameters)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMLoginAdditionalParameters GAMLoginAdditionalParameters_externalReference=null ;
   }

}
