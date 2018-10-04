/*
               File: type_SdtGAMDescription
        Description: GAMDescription
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.49
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
   public class SdtGAMDescription : GxUserType, IGxExternalObject
   {
      public SdtGAMDescription( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMDescription( IGxContext context )
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
         if ( GAMDescription_externalReference == null )
         {
            GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
         }
         returntostring = "";
         returntostring = (String)(GAMDescription_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMDescription_externalReference == null )
         {
            GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMDescription_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMDescription_externalReference == null )
         {
            GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMDescription_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Language
      {
         get {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            return GAMDescription_externalReference.Language ;
         }

         set {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            GAMDescription_externalReference.Language = value;
            SetDirty("Language");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            return GAMDescription_externalReference.Name ;
         }

         set {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            GAMDescription_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Text
      {
         get {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            return GAMDescription_externalReference.Text ;
         }

         set {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            GAMDescription_externalReference.Text = value;
            SetDirty("Text");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMDescription_externalReference == null )
            {
               GAMDescription_externalReference = new Artech.Security.GAMDescription(context);
            }
            return GAMDescription_externalReference ;
         }

         set {
            GAMDescription_externalReference = (Artech.Security.GAMDescription)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMDescription GAMDescription_externalReference=null ;
   }

}
