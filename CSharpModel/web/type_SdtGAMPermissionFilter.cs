/*
               File: type_SdtGAMPermissionFilter
        Description: GAMPermissionFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:57.8
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
   public class SdtGAMPermissionFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMPermissionFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMPermissionFilter( IGxContext context )
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
         if ( GAMPermissionFilter_externalReference == null )
         {
            GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMPermissionFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMPermissionFilter_externalReference == null )
         {
            GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMPermissionFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMPermissionFilter_externalReference == null )
         {
            GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMPermissionFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.ApplicationId ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.GUID ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Name ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Name_expression
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Name_Expression ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Name_Expression = value;
            SetDirty("Name_expression");
         }

      }

      public String gxTpr_Descripcion
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Descripcion ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Descripcion = value;
            SetDirty("Descripcion");
         }

      }

      public String gxTpr_Accesstype
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.AccessType ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.AccessType = value;
            SetDirty("Accesstype");
         }

      }

      public String gxTpr_Isautomaticpermission
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.IsAutomaticPermission ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.IsAutomaticPermission = value;
            SetDirty("Isautomaticpermission");
         }

      }

      public String gxTpr_Inherited
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Inherited ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Inherited = value;
            SetDirty("Inherited");
         }

      }

      public String gxTpr_Token
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Token ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Start ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference.Limit ;
         }

         set {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            GAMPermissionFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMPermissionFilter_externalReference == null )
            {
               GAMPermissionFilter_externalReference = new Artech.Security.GAMPermissionFilter(context);
            }
            return GAMPermissionFilter_externalReference ;
         }

         set {
            GAMPermissionFilter_externalReference = (Artech.Security.GAMPermissionFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMPermissionFilter GAMPermissionFilter_externalReference=null ;
   }

}
