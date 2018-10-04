/*
               File: type_SdtGAMCountry
        Description: GAMCountry
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.41
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
   public class SdtGAMCountry : GxUserType, IGxExternalObject
   {
      public SdtGAMCountry( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMCountry( IGxContext context )
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
         if ( GAMCountry_externalReference == null )
         {
            GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
         }
         returntostring = "";
         returntostring = (String)(GAMCountry_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMCountry_externalReference == null )
         {
            GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMCountry_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMCountry_externalReference == null )
         {
            GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMCountry_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.Id ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.Name ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Iso_3
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.ISO_3 ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.ISO_3 = value;
            SetDirty("Iso_3");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.DateCreated ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.UserCreated ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.DateUpdated ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference.UserUpdated ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GAMCountry_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMCountryLanguages> gxTpr_Languages
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GXExternalCollection<SdtGAMCountryLanguages> intValue ;
            intValue = new GXExternalCollection<SdtGAMCountryLanguages>( context, "SdtGAMCountryLanguages", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMCountryLanguages> externalParm0 ;
            externalParm0 = GAMCountry_externalReference.Languages;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMCountryLanguages>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            GXExternalCollection<SdtGAMCountryLanguages> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMCountryLanguages> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMCountryLanguages>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMCountryLanguages>), intValue.ExternalInstance);
            GAMCountry_externalReference.Languages = externalParm1;
            SetDirty("Languages");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMCountry_externalReference == null )
            {
               GAMCountry_externalReference = new Artech.Security.GAMCountry(context);
            }
            return GAMCountry_externalReference ;
         }

         set {
            GAMCountry_externalReference = (Artech.Security.GAMCountry)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMCountry GAMCountry_externalReference=null ;
   }

}
