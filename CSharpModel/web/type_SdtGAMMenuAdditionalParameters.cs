/*
               File: type_SdtGAMMenuAdditionalParameters
        Description: GAMMenuAdditionalParameters
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.84
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
   public class SdtGAMMenuAdditionalParameters : GxUserType, IGxExternalObject
   {
      public SdtGAMMenuAdditionalParameters( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMMenuAdditionalParameters( IGxContext context )
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
         if ( GAMMenuAdditionalParameters_externalReference == null )
         {
            GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
         }
         returntostring = "";
         returntostring = (String)(GAMMenuAdditionalParameters_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMMenuAdditionalParameters_externalReference == null )
         {
            GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMMenuAdditionalParameters_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMMenuAdditionalParameters_externalReference == null )
         {
            GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMMenuAdditionalParameters_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public bool gxTpr_Ignoreuserpermissions
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.IgnoreUserPermissions ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.IgnoreUserPermissions = value;
            SetDirty("Ignoreuserpermissions");
         }

      }

      public int gxTpr_Levels
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.Levels ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.Levels = value;
            SetDirty("Levels");
         }

      }

      public String gxTpr_Returnabsoluteurlbyenvironment
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.ReturnAbsoluteUrlByEnvironment ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.ReturnAbsoluteUrlByEnvironment = value;
            SetDirty("Returnabsoluteurlbyenvironment");
         }

      }

      public bool gxTpr_Returnoptionswithoutpermission
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.ReturnOptionsWithoutPermission ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.ReturnOptionsWithoutPermission = value;
            SetDirty("Returnoptionswithoutpermission");
         }

      }

      public String gxTpr_Urloptionswithoutpermissions
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.URLOptionsWithoutPermissions ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.URLOptionsWithoutPermissions = value;
            SetDirty("Urloptionswithoutpermissions");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference.LoadProperties ;
         }

         set {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            GAMMenuAdditionalParameters_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMMenuAdditionalParameters_externalReference == null )
            {
               GAMMenuAdditionalParameters_externalReference = new Artech.Security.GAMMenuAdditionalParameters(context);
            }
            return GAMMenuAdditionalParameters_externalReference ;
         }

         set {
            GAMMenuAdditionalParameters_externalReference = (Artech.Security.GAMMenuAdditionalParameters)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMMenuAdditionalParameters GAMMenuAdditionalParameters_externalReference=null ;
   }

}
