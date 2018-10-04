/*
               File: type_SdtGAMSessionLogLoginRetry
        Description: GAMSessionLogLoginRetry
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.34
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
   public class SdtGAMSessionLogLoginRetry : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionLogLoginRetry( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionLogLoginRetry( IGxContext context )
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
         if ( GAMSessionLogLoginRetry_externalReference == null )
         {
            GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionLogLoginRetry_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionLogLoginRetry_externalReference == null )
         {
            GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionLogLoginRetry_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionLogLoginRetry_externalReference == null )
         {
            GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionLogLoginRetry_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Userlogin
      {
         get {
            if ( GAMSessionLogLoginRetry_externalReference == null )
            {
               GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
            }
            return GAMSessionLogLoginRetry_externalReference.UserLogin ;
         }

         set {
            if ( GAMSessionLogLoginRetry_externalReference == null )
            {
               GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
            }
            GAMSessionLogLoginRetry_externalReference.UserLogin = value;
            SetDirty("Userlogin");
         }

      }

      public short gxTpr_Number
      {
         get {
            if ( GAMSessionLogLoginRetry_externalReference == null )
            {
               GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
            }
            return GAMSessionLogLoginRetry_externalReference.Number ;
         }

         set {
            if ( GAMSessionLogLoginRetry_externalReference == null )
            {
               GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
            }
            GAMSessionLogLoginRetry_externalReference.Number = value;
            SetDirty("Number");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionLogLoginRetry_externalReference == null )
            {
               GAMSessionLogLoginRetry_externalReference = new Artech.Security.GAMSessionLogLoginRetry(context);
            }
            return GAMSessionLogLoginRetry_externalReference ;
         }

         set {
            GAMSessionLogLoginRetry_externalReference = (Artech.Security.GAMSessionLogLoginRetry)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionLogLoginRetry GAMSessionLogLoginRetry_externalReference=null ;
   }

}
