/*
               File: type_SdtGAMConnectionInfoProperties
        Description: GAMConnectionInfoProperties
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.38
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
   public class SdtGAMConnectionInfoProperties : GxUserType, IGxExternalObject
   {
      public SdtGAMConnectionInfoProperties( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMConnectionInfoProperties( IGxContext context )
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
         if ( GAMConnectionInfoProperties_externalReference == null )
         {
            GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
         }
         returntostring = "";
         returntostring = (String)(GAMConnectionInfoProperties_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMConnectionInfoProperties_externalReference == null )
         {
            GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMConnectionInfoProperties_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMConnectionInfoProperties_externalReference == null )
         {
            GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMConnectionInfoProperties_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMConnectionInfoProperties_externalReference == null )
            {
               GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
            }
            return GAMConnectionInfoProperties_externalReference.Id ;
         }

         set {
            if ( GAMConnectionInfoProperties_externalReference == null )
            {
               GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
            }
            GAMConnectionInfoProperties_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Value
      {
         get {
            if ( GAMConnectionInfoProperties_externalReference == null )
            {
               GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
            }
            return GAMConnectionInfoProperties_externalReference.Value ;
         }

         set {
            if ( GAMConnectionInfoProperties_externalReference == null )
            {
               GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
            }
            GAMConnectionInfoProperties_externalReference.Value = value;
            SetDirty("Value");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMConnectionInfoProperties_externalReference == null )
            {
               GAMConnectionInfoProperties_externalReference = new Artech.Security.GAMConnectionInfoProperties(context);
            }
            return GAMConnectionInfoProperties_externalReference ;
         }

         set {
            GAMConnectionInfoProperties_externalReference = (Artech.Security.GAMConnectionInfoProperties)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMConnectionInfoProperties GAMConnectionInfoProperties_externalReference=null ;
   }

}
