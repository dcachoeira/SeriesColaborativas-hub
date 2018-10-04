/*
               File: type_SdtGAMSessionsCountFilter
        Description: GAMSessionsCountFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.39
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
   public class SdtGAMSessionsCountFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionsCountFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionsCountFilter( IGxContext context )
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
         if ( GAMSessionsCountFilter_externalReference == null )
         {
            GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionsCountFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionsCountFilter_externalReference == null )
         {
            GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionsCountFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionsCountFilter_externalReference == null )
         {
            GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionsCountFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Status
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference.Status ;
         }

         set {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            GAMSessionsCountFilter_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference.Type ;
         }

         set {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            GAMSessionsCountFilter_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public short gxTpr_Browser
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference.Browser ;
         }

         set {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            GAMSessionsCountFilter_externalReference.Browser = value;
            SetDirty("Browser");
         }

      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference.ApplicationId ;
         }

         set {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            GAMSessionsCountFilter_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public String gxTpr_Authenticationtypename
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference.AuthenticationTypeName ;
         }

         set {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            GAMSessionsCountFilter_externalReference.AuthenticationTypeName = value;
            SetDirty("Authenticationtypename");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionsCountFilter_externalReference == null )
            {
               GAMSessionsCountFilter_externalReference = new Artech.Security.GAMSessionsCountFilter(context);
            }
            return GAMSessionsCountFilter_externalReference ;
         }

         set {
            GAMSessionsCountFilter_externalReference = (Artech.Security.GAMSessionsCountFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionsCountFilter GAMSessionsCountFilter_externalReference=null ;
   }

}
