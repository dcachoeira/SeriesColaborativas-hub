/*
               File: type_SdtGAMUserAttribute
        Description: GAMUserAttribute
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.2
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
   public class SdtGAMUserAttribute : GxUserType, IGxExternalObject
   {
      public SdtGAMUserAttribute( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUserAttribute( IGxContext context )
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
         if ( GAMUserAttribute_externalReference == null )
         {
            GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUserAttribute_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUserAttribute_externalReference == null )
         {
            GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUserAttribute_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUserAttribute_externalReference == null )
         {
            GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUserAttribute_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            return GAMUserAttribute_externalReference.Id ;
         }

         set {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            GAMUserAttribute_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public bool gxTpr_Ismultivalue
      {
         get {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            return GAMUserAttribute_externalReference.IsMultiValue ;
         }

         set {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            GAMUserAttribute_externalReference.IsMultiValue = value;
            SetDirty("Ismultivalue");
         }

      }

      public String gxTpr_Value
      {
         get {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            return GAMUserAttribute_externalReference.Value ;
         }

         set {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            GAMUserAttribute_externalReference.Value = value;
            SetDirty("Value");
         }

      }

      public GXExternalCollection<SdtGAMUserAttributeMultiValues> gxTpr_Multivalues
      {
         get {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            GXExternalCollection<SdtGAMUserAttributeMultiValues> intValue ;
            intValue = new GXExternalCollection<SdtGAMUserAttributeMultiValues>( context, "SdtGAMUserAttributeMultiValues", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMUserAttributeMultiValues> externalParm0 ;
            externalParm0 = GAMUserAttribute_externalReference.MultiValues;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUserAttributeMultiValues>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            GXExternalCollection<SdtGAMUserAttributeMultiValues> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMUserAttributeMultiValues> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMUserAttributeMultiValues>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUserAttributeMultiValues>), intValue.ExternalInstance);
            GAMUserAttribute_externalReference.MultiValues = externalParm1;
            SetDirty("Multivalues");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUserAttribute_externalReference == null )
            {
               GAMUserAttribute_externalReference = new Artech.Security.GAMUserAttribute(context);
            }
            return GAMUserAttribute_externalReference ;
         }

         set {
            GAMUserAttribute_externalReference = (Artech.Security.GAMUserAttribute)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUserAttribute GAMUserAttribute_externalReference=null ;
   }

}
