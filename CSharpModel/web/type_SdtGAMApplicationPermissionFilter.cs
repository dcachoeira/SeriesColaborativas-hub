/*
               File: type_SdtGAMApplicationPermissionFilter
        Description: GAMApplicationPermissionFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.16
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
   public class SdtGAMApplicationPermissionFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationPermissionFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationPermissionFilter( IGxContext context )
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
         if ( GAMApplicationPermissionFilter_externalReference == null )
         {
            GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationPermissionFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationPermissionFilter_externalReference == null )
         {
            GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationPermissionFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationPermissionFilter_externalReference == null )
         {
            GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationPermissionFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Name ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Name_expression
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Name_Expression ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Name_Expression = value;
            SetDirty("Name_expression");
         }

      }

      public String gxTpr_Accesstypedefault
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.AccessTypeDefault ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.AccessTypeDefault = value;
            SetDirty("Accesstypedefault");
         }

      }

      public String gxTpr_Typefilter
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.TypeFilter ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.TypeFilter = value;
            SetDirty("Typefilter");
         }

      }

      public String gxTpr_Isautomaticpermission
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.IsAutomaticPermission ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.IsAutomaticPermission = value;
            SetDirty("Isautomaticpermission");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Start ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Limit ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Description ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Resource
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.Resource ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.Resource = value;
            SetDirty("Resource");
         }

      }

      public String gxTpr_Resourceparameters
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference.ResourceParameters ;
         }

         set {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            GAMApplicationPermissionFilter_externalReference.ResourceParameters = value;
            SetDirty("Resourceparameters");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationPermissionFilter_externalReference == null )
            {
               GAMApplicationPermissionFilter_externalReference = new Artech.Security.GAMApplicationPermissionFilter(context);
            }
            return GAMApplicationPermissionFilter_externalReference ;
         }

         set {
            GAMApplicationPermissionFilter_externalReference = (Artech.Security.GAMApplicationPermissionFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationPermissionFilter GAMApplicationPermissionFilter_externalReference=null ;
   }

}
