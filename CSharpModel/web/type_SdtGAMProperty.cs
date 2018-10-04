/*
               File: type_SdtGAMProperty
        Description: GAMProperty
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:57.14
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
   public class SdtGAMProperty : GxUserType, IGxExternalObject
   {
      public SdtGAMProperty( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMProperty( IGxContext context )
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
         if ( GAMProperty_externalReference == null )
         {
            GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
         }
         returntostring = "";
         returntostring = (String)(GAMProperty_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMProperty_externalReference == null )
         {
            GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMProperty_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMProperty_externalReference == null )
         {
            GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMProperty_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            return GAMProperty_externalReference.Id ;
         }

         set {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            GAMProperty_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Token
      {
         get {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            return GAMProperty_externalReference.Token ;
         }

         set {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            GAMProperty_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public String gxTpr_Value
      {
         get {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            return GAMProperty_externalReference.Value ;
         }

         set {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            GAMProperty_externalReference.Value = value;
            SetDirty("Value");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMProperty_externalReference == null )
            {
               GAMProperty_externalReference = new Artech.Security.GAMProperty(context);
            }
            return GAMProperty_externalReference ;
         }

         set {
            GAMProperty_externalReference = (Artech.Security.GAMProperty)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMProperty GAMProperty_externalReference=null ;
   }

}
