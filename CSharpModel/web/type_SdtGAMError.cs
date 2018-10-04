/*
               File: type_SdtGAMError
        Description: GAMError
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.52
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
   public class SdtGAMError : GxUserType, IGxExternalObject
   {
      public SdtGAMError( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMError( IGxContext context )
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
         if ( GAMError_externalReference == null )
         {
            GAMError_externalReference = new Artech.Security.GAMError(context);
         }
         returntostring = "";
         returntostring = (String)(GAMError_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMError_externalReference == null )
         {
            GAMError_externalReference = new Artech.Security.GAMError(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMError_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMError_externalReference == null )
         {
            GAMError_externalReference = new Artech.Security.GAMError(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMError_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Code
      {
         get {
            if ( GAMError_externalReference == null )
            {
               GAMError_externalReference = new Artech.Security.GAMError(context);
            }
            return GAMError_externalReference.Code ;
         }

         set {
            if ( GAMError_externalReference == null )
            {
               GAMError_externalReference = new Artech.Security.GAMError(context);
            }
            GAMError_externalReference.Code = value;
            SetDirty("Code");
         }

      }

      public String gxTpr_Message
      {
         get {
            if ( GAMError_externalReference == null )
            {
               GAMError_externalReference = new Artech.Security.GAMError(context);
            }
            return GAMError_externalReference.Message ;
         }

         set {
            if ( GAMError_externalReference == null )
            {
               GAMError_externalReference = new Artech.Security.GAMError(context);
            }
            GAMError_externalReference.Message = value;
            SetDirty("Message");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMError_externalReference == null )
            {
               GAMError_externalReference = new Artech.Security.GAMError(context);
            }
            return GAMError_externalReference ;
         }

         set {
            GAMError_externalReference = (Artech.Security.GAMError)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMError GAMError_externalReference=null ;
   }

}
