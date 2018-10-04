/*
               File: type_SdtGAMSessionFullLog
        Description: GAMSessionFullLog
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:22.58
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
   public class SdtGAMSessionFullLog : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionFullLog( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionFullLog( IGxContext context )
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
         if ( GAMSessionFullLog_externalReference == null )
         {
            GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionFullLog_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionFullLog_externalReference == null )
         {
            GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionFullLog_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionFullLog_externalReference == null )
         {
            GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionFullLog_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            return GAMSessionFullLog_externalReference.GUID ;
         }

         set {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            GAMSessionFullLog_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public DateTime gxTpr_Datetime
      {
         get {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            return GAMSessionFullLog_externalReference.DateTime ;
         }

         set {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            GAMSessionFullLog_externalReference.DateTime = value;
            SetDirty("Datetime");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            return GAMSessionFullLog_externalReference.Type ;
         }

         set {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            GAMSessionFullLog_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Detail
      {
         get {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            return GAMSessionFullLog_externalReference.Detail ;
         }

         set {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            GAMSessionFullLog_externalReference.Detail = value;
            SetDirty("Detail");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionFullLog_externalReference == null )
            {
               GAMSessionFullLog_externalReference = new Artech.Security.GAMSessionFullLog(context);
            }
            return GAMSessionFullLog_externalReference ;
         }

         set {
            GAMSessionFullLog_externalReference = (Artech.Security.GAMSessionFullLog)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionFullLog GAMSessionFullLog_externalReference=null ;
   }

}
