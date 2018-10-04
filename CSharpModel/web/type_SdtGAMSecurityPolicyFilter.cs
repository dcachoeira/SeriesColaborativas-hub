/*
               File: type_SdtGAMSecurityPolicyFilter
        Description: GAMSecurityPolicyFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:21.63
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
   public class SdtGAMSecurityPolicyFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMSecurityPolicyFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSecurityPolicyFilter( IGxContext context )
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
         if ( GAMSecurityPolicyFilter_externalReference == null )
         {
            GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSecurityPolicyFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSecurityPolicyFilter_externalReference == null )
         {
            GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSecurityPolicyFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSecurityPolicyFilter_externalReference == null )
         {
            GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSecurityPolicyFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.GUID ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.Name ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.Description ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMDescription gxTpr_Descriptions
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            SdtGAMDescription intValue ;
            intValue = new SdtGAMDescription(context);
            Artech.Security.GAMDescription externalParm0 ;
            externalParm0 = GAMSecurityPolicyFilter_externalReference.Descriptions;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            SdtGAMDescription intValue ;
            Artech.Security.GAMDescription externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMDescription)(intValue.ExternalInstance);
            GAMSecurityPolicyFilter_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.Start ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.Limit ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public int gxTpr_Id
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.Id ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public SdtGAMProperty gxTpr_Properties
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            SdtGAMProperty intValue ;
            intValue = new SdtGAMProperty(context);
            Artech.Security.GAMProperty externalParm2 ;
            externalParm2 = GAMSecurityPolicyFilter_externalReference.Properties;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            SdtGAMProperty intValue ;
            Artech.Security.GAMProperty externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMProperty)(intValue.ExternalInstance);
            GAMSecurityPolicyFilter_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            GAMSecurityPolicyFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSecurityPolicyFilter_externalReference == null )
            {
               GAMSecurityPolicyFilter_externalReference = new Artech.Security.GAMSecurityPolicyFilter(context);
            }
            return GAMSecurityPolicyFilter_externalReference ;
         }

         set {
            GAMSecurityPolicyFilter_externalReference = (Artech.Security.GAMSecurityPolicyFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSecurityPolicyFilter GAMSecurityPolicyFilter_externalReference=null ;
   }

}
