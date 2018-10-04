/*
               File: type_SdtGAMSessionLoginRetry
        Description: GAMSessionLoginRetry
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.31
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
   public class SdtGAMSessionLoginRetry : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionLoginRetry( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionLoginRetry( IGxContext context )
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
         if ( GAMSessionLoginRetry_externalReference == null )
         {
            GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionLoginRetry_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionLoginRetry_externalReference == null )
         {
            GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionLoginRetry_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionLoginRetry_externalReference == null )
         {
            GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionLoginRetry_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Userlogin
      {
         get {
            if ( GAMSessionLoginRetry_externalReference == null )
            {
               GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
            }
            return GAMSessionLoginRetry_externalReference.UserLogin ;
         }

         set {
            if ( GAMSessionLoginRetry_externalReference == null )
            {
               GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
            }
            GAMSessionLoginRetry_externalReference.UserLogin = value;
            SetDirty("Userlogin");
         }

      }

      public short gxTpr_Number
      {
         get {
            if ( GAMSessionLoginRetry_externalReference == null )
            {
               GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
            }
            return GAMSessionLoginRetry_externalReference.Number ;
         }

         set {
            if ( GAMSessionLoginRetry_externalReference == null )
            {
               GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
            }
            GAMSessionLoginRetry_externalReference.Number = value;
            SetDirty("Number");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionLoginRetry_externalReference == null )
            {
               GAMSessionLoginRetry_externalReference = new Artech.Security.GAMSessionLoginRetry(context);
            }
            return GAMSessionLoginRetry_externalReference ;
         }

         set {
            GAMSessionLoginRetry_externalReference = (Artech.Security.GAMSessionLoginRetry)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionLoginRetry GAMSessionLoginRetry_externalReference=null ;
   }

}
