/*
               File: type_SdtGAMApplicationFilter
        Description: GAMApplicationFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:52.96
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
   public class SdtGAMApplicationFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationFilter( IGxContext context )
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
         if ( GAMApplicationFilter_externalReference == null )
         {
            GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationFilter_externalReference == null )
         {
            GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationFilter_externalReference == null )
         {
            GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public short gxTpr_Type
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Type ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Id ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Name ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Description ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMApplicationEnvironment gxTpr_Environment
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            intValue = new SdtGAMApplicationEnvironment(context);
            Artech.Security.GAMApplicationEnvironment externalParm0 ;
            externalParm0 = GAMApplicationFilter_externalReference.Environment;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            Artech.Security.GAMApplicationEnvironment externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMApplicationEnvironment)(intValue.ExternalInstance);
            GAMApplicationFilter_externalReference.Environment = externalParm1;
            SetDirty("Environment");
         }

      }

      public String gxTpr_Companyname
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.CompanyName ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.CompanyName = value;
            SetDirty("Companyname");
         }

      }

      public SdtGAMDescription gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMDescription intValue ;
            intValue = new SdtGAMDescription(context);
            Artech.Security.GAMDescription externalParm2 ;
            externalParm2 = GAMApplicationFilter_externalReference.Descriptions;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMDescription intValue ;
            Artech.Security.GAMDescription externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMDescription)(intValue.ExternalInstance);
            GAMApplicationFilter_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public SdtGAMProperty gxTpr_Properties
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMProperty intValue ;
            intValue = new SdtGAMProperty(context);
            Artech.Security.GAMProperty externalParm4 ;
            externalParm4 = GAMApplicationFilter_externalReference.Properties;
            intValue.ExternalInstance = externalParm4;
            return intValue ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            SdtGAMProperty intValue ;
            Artech.Security.GAMProperty externalParm5 ;
            intValue = value;
            externalParm5 = (Artech.Security.GAMProperty)(intValue.ExternalInstance);
            GAMApplicationFilter_externalReference.Properties = externalParm5;
            SetDirty("Properties");
         }

      }

      public String gxTpr_Isbasedapplications
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.IsBasedApplications ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.IsBasedApplications = value;
            SetDirty("Isbasedapplications");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public bool gxTpr_Loadenvironments
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.LoadEnvironments ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.LoadEnvironments = value;
            SetDirty("Loadenvironments");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Start ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference.Limit ;
         }

         set {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            GAMApplicationFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationFilter_externalReference == null )
            {
               GAMApplicationFilter_externalReference = new Artech.Security.GAMApplicationFilter(context);
            }
            return GAMApplicationFilter_externalReference ;
         }

         set {
            GAMApplicationFilter_externalReference = (Artech.Security.GAMApplicationFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationFilter GAMApplicationFilter_externalReference=null ;
   }

}
