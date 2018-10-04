/*
               File: type_SdtGAMAuthenticationTypeFilter
        Description: GAMAuthenticationTypeFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.20
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
   public class SdtGAMAuthenticationTypeFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeFilter( IGxContext context )
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
         if ( GAMAuthenticationTypeFilter_externalReference == null )
         {
            GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeFilter_externalReference == null )
         {
            GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeFilter_externalReference == null )
         {
            GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            GAMAuthenticationTypeFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference.Type ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            GAMAuthenticationTypeFilter_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            GAMAuthenticationTypeFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMDescription gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            SdtGAMDescription intValue ;
            intValue = new SdtGAMDescription(context);
            Artech.Security.GAMDescription externalParm0 ;
            externalParm0 = GAMAuthenticationTypeFilter_externalReference.Descriptions;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            SdtGAMDescription intValue ;
            Artech.Security.GAMDescription externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMDescription)(intValue.ExternalInstance);
            GAMAuthenticationTypeFilter_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public SdtGAMProperty gxTpr_Properties
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            SdtGAMProperty intValue ;
            intValue = new SdtGAMProperty(context);
            Artech.Security.GAMProperty externalParm2 ;
            externalParm2 = GAMAuthenticationTypeFilter_externalReference.Properties;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            SdtGAMProperty intValue ;
            Artech.Security.GAMProperty externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMProperty)(intValue.ExternalInstance);
            GAMAuthenticationTypeFilter_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference.Start ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            GAMAuthenticationTypeFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference.Limit ;
         }

         set {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            GAMAuthenticationTypeFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeFilter_externalReference == null )
            {
               GAMAuthenticationTypeFilter_externalReference = new Artech.Security.GAMAuthenticationTypeFilter(context);
            }
            return GAMAuthenticationTypeFilter_externalReference ;
         }

         set {
            GAMAuthenticationTypeFilter_externalReference = (Artech.Security.GAMAuthenticationTypeFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeFilter GAMAuthenticationTypeFilter_externalReference=null ;
   }

}
