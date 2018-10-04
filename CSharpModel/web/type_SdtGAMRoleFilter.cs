/*
               File: type_SdtGAMRoleFilter
        Description: GAMRoleFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:21.19
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
   public class SdtGAMRoleFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMRoleFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRoleFilter( IGxContext context )
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
         if ( GAMRoleFilter_externalReference == null )
         {
            GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRoleFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRoleFilter_externalReference == null )
         {
            GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRoleFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRoleFilter_externalReference == null )
         {
            GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRoleFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.GUID ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Externalid
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.ExternalId ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.ExternalId = value;
            SetDirty("Externalid");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.Name ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.Description ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.Id ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public SdtGAMDescription gxTpr_Descriptions
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            SdtGAMDescription intValue ;
            intValue = new SdtGAMDescription(context);
            Artech.Security.GAMDescription externalParm0 ;
            externalParm0 = GAMRoleFilter_externalReference.Descriptions;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            SdtGAMDescription intValue ;
            Artech.Security.GAMDescription externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMDescription)(intValue.ExternalInstance);
            GAMRoleFilter_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public SdtGAMProperty gxTpr_Properties
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            SdtGAMProperty intValue ;
            intValue = new SdtGAMProperty(context);
            Artech.Security.GAMProperty externalParm2 ;
            externalParm2 = GAMRoleFilter_externalReference.Properties;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            SdtGAMProperty intValue ;
            Artech.Security.GAMProperty externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMProperty)(intValue.ExternalInstance);
            GAMRoleFilter_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.Start ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference.Limit ;
         }

         set {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            GAMRoleFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRoleFilter_externalReference == null )
            {
               GAMRoleFilter_externalReference = new Artech.Security.GAMRoleFilter(context);
            }
            return GAMRoleFilter_externalReference ;
         }

         set {
            GAMRoleFilter_externalReference = (Artech.Security.GAMRoleFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRoleFilter GAMRoleFilter_externalReference=null ;
   }

}
