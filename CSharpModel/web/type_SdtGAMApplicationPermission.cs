/*
               File: type_SdtGAMApplicationPermission
        Description: GAMApplicationPermission
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:53.90
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
   public class SdtGAMApplicationPermission : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationPermission( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationPermission( IGxContext context )
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
         if ( GAMApplicationPermission_externalReference == null )
         {
            GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationPermission_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationPermission_externalReference == null )
         {
            GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationPermission_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationPermission_externalReference == null )
         {
            GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationPermission_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public SdtGAMApplicationEnvironment gxTpr_Environment
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            intValue = new SdtGAMApplicationEnvironment(context);
            Artech.Security.GAMApplicationEnvironment externalParm0 ;
            externalParm0 = GAMApplicationPermission_externalReference.Environment;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            Artech.Security.GAMApplicationEnvironment externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMApplicationEnvironment)(intValue.ExternalInstance);
            GAMApplicationPermission_externalReference.Environment = externalParm1;
            SetDirty("Environment");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.Name ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.Description ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Accesstype
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.AccessType ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.AccessType = value;
            SetDirty("Accesstype");
         }

      }

      public SdtGAMApplicationToken gxTpr_Token
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            SdtGAMApplicationToken intValue ;
            intValue = new SdtGAMApplicationToken(context);
            Artech.Security.GAMApplicationToken externalParm2 ;
            externalParm2 = GAMApplicationPermission_externalReference.Token;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            SdtGAMApplicationToken intValue ;
            Artech.Security.GAMApplicationToken externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMApplicationToken)(intValue.ExternalInstance);
            GAMApplicationPermission_externalReference.Token = externalParm3;
            SetDirty("Token");
         }

      }

      public bool gxTpr_Isparent
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.IsParent ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.IsParent = value;
            SetDirty("Isparent");
         }

      }

      public bool gxTpr_Isautomaticpermission
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.IsAutomaticPermission ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.IsAutomaticPermission = value;
            SetDirty("Isautomaticpermission");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.DateCreated ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.UserCreated ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.DateUpdated ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.UserUpdated ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm4 ;
            externalParm4 = GAMApplicationPermission_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm4);
            return intValue ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm5 ;
            intValue = value;
            externalParm5 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMApplicationPermission_externalReference.Properties = externalParm5;
            SetDirty("Properties");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm6 ;
            externalParm6 = GAMApplicationPermission_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm6);
            return intValue ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm7 ;
            intValue = value;
            externalParm7 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplicationPermission_externalReference.Descriptions = externalParm7;
            SetDirty("Descriptions");
         }

      }

      public String gxTpr_Resource
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.Resource ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.Resource = value;
            SetDirty("Resource");
         }

      }

      public String gxTpr_Resourceparameters
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference.ResourceParameters ;
         }

         set {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            GAMApplicationPermission_externalReference.ResourceParameters = value;
            SetDirty("Resourceparameters");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationPermission_externalReference == null )
            {
               GAMApplicationPermission_externalReference = new Artech.Security.GAMApplicationPermission(context);
            }
            return GAMApplicationPermission_externalReference ;
         }

         set {
            GAMApplicationPermission_externalReference = (Artech.Security.GAMApplicationPermission)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationPermission GAMApplicationPermission_externalReference=null ;
   }

}
