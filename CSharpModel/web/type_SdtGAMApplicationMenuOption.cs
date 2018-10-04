/*
               File: type_SdtGAMApplicationMenuOption
        Description: GAMApplicationMenuOption
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:53.60
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
   public class SdtGAMApplicationMenuOption : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationMenuOption( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationMenuOption( IGxContext context )
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

      public void moveup( int gxTp_RepositoryId ,
                          long gxTp_ApplicationId ,
                          long gxTp_MenuId ,
                          out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenuOption_externalReference == null )
         {
            GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
         }
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         GAMApplicationMenuOption_externalReference.MoveUp(gxTp_RepositoryId, gxTp_ApplicationId, gxTp_MenuId, out externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return  ;
      }

      public void movedown( int gxTp_RepositoryId ,
                            long gxTp_ApplicationId ,
                            long gxTp_MenuId ,
                            out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenuOption_externalReference == null )
         {
            GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
         }
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         GAMApplicationMenuOption_externalReference.MoveDown(gxTp_RepositoryId, gxTp_ApplicationId, gxTp_MenuId, out externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return  ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMApplicationMenuOption_externalReference == null )
         {
            GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationMenuOption_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationMenuOption_externalReference == null )
         {
            GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationMenuOption_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationMenuOption_externalReference == null )
         {
            GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationMenuOption_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Menuid
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.MenuId ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.MenuId = value;
            SetDirty("Menuid");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Id ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Name ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Description ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Type ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public short gxTpr_Order
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Order ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Order = value;
            SetDirty("Order");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.DateCreated ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.UserCreated ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.DateUpdated ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.UserUpdated ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMApplicationMenuOption_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplicationMenuOption_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMApplicationMenuOption_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMApplicationMenuOption_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public long gxTpr_Submenuid
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.SubMenuId ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.SubMenuId = value;
            SetDirty("Submenuid");
         }

      }

      public String gxTpr_Permissionresourceguid
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.PermissionResourceGUID ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.PermissionResourceGUID = value;
            SetDirty("Permissionresourceguid");
         }

      }

      public String gxTpr_Permissionresourceparameters
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.PermissionResourceParameters ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.PermissionResourceParameters = value;
            SetDirty("Permissionresourceparameters");
         }

      }

      public String gxTpr_Resource
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.Resource ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.Resource = value;
            SetDirty("Resource");
         }

      }

      public String gxTpr_Resourceparameters
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference.ResourceParameters ;
         }

         set {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            GAMApplicationMenuOption_externalReference.ResourceParameters = value;
            SetDirty("Resourceparameters");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationMenuOption_externalReference == null )
            {
               GAMApplicationMenuOption_externalReference = new Artech.Security.GAMApplicationMenuOption(context);
            }
            return GAMApplicationMenuOption_externalReference ;
         }

         set {
            GAMApplicationMenuOption_externalReference = (Artech.Security.GAMApplicationMenuOption)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationMenuOption GAMApplicationMenuOption_externalReference=null ;
   }

}
