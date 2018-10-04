/*
               File: type_SdtGAMCountryLanguages
        Description: GAMCountryLanguages
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.47
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
   public class SdtGAMCountryLanguages : GxUserType, IGxExternalObject
   {
      public SdtGAMCountryLanguages( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMCountryLanguages( IGxContext context )
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
         if ( GAMCountryLanguages_externalReference == null )
         {
            GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
         }
         returntostring = "";
         returntostring = (String)(GAMCountryLanguages_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMCountryLanguages_externalReference == null )
         {
            GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMCountryLanguages_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMCountryLanguages_externalReference == null )
         {
            GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMCountryLanguages_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMCountryLanguages_externalReference == null )
            {
               GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
            }
            return GAMCountryLanguages_externalReference.Id ;
         }

         set {
            if ( GAMCountryLanguages_externalReference == null )
            {
               GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
            }
            GAMCountryLanguages_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMCountryLanguages_externalReference == null )
            {
               GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
            }
            return GAMCountryLanguages_externalReference.Name ;
         }

         set {
            if ( GAMCountryLanguages_externalReference == null )
            {
               GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
            }
            GAMCountryLanguages_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMCountryLanguages_externalReference == null )
            {
               GAMCountryLanguages_externalReference = new Artech.Security.GAMCountryLanguages(context);
            }
            return GAMCountryLanguages_externalReference ;
         }

         set {
            GAMCountryLanguages_externalReference = (Artech.Security.GAMCountryLanguages)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMCountryLanguages GAMCountryLanguages_externalReference=null ;
   }

}
