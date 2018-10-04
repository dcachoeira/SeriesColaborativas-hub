/*
               File: type_SdtGAMUserAttributeMultiValues
        Description: GAMUserAttributeMultiValues
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.7
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
   public class SdtGAMUserAttributeMultiValues : GxUserType, IGxExternalObject
   {
      public SdtGAMUserAttributeMultiValues( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUserAttributeMultiValues( IGxContext context )
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
         if ( GAMUserAttributeMultiValues_externalReference == null )
         {
            GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUserAttributeMultiValues_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUserAttributeMultiValues_externalReference == null )
         {
            GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUserAttributeMultiValues_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUserAttributeMultiValues_externalReference == null )
         {
            GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUserAttributeMultiValues_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMUserAttributeMultiValues_externalReference == null )
            {
               GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
            }
            return GAMUserAttributeMultiValues_externalReference.Id ;
         }

         set {
            if ( GAMUserAttributeMultiValues_externalReference == null )
            {
               GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
            }
            GAMUserAttributeMultiValues_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Value
      {
         get {
            if ( GAMUserAttributeMultiValues_externalReference == null )
            {
               GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
            }
            return GAMUserAttributeMultiValues_externalReference.Value ;
         }

         set {
            if ( GAMUserAttributeMultiValues_externalReference == null )
            {
               GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
            }
            GAMUserAttributeMultiValues_externalReference.Value = value;
            SetDirty("Value");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUserAttributeMultiValues_externalReference == null )
            {
               GAMUserAttributeMultiValues_externalReference = new Artech.Security.GAMUserAttributeMultiValues(context);
            }
            return GAMUserAttributeMultiValues_externalReference ;
         }

         set {
            GAMUserAttributeMultiValues_externalReference = (Artech.Security.GAMUserAttributeMultiValues)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUserAttributeMultiValues GAMUserAttributeMultiValues_externalReference=null ;
   }

}
