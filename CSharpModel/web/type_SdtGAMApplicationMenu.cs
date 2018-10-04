/*
               File: type_SdtGAMApplicationMenu
        Description: GAMApplicationMenu
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:53.16
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
   public class SdtGAMApplicationMenu : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationMenu( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationMenu( IGxContext context )
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

      public GXExternalCollection<SdtGAMApplicationMenuOption> getmenuoptions( long gxTp_ApplicationId ,
                                                                               SdtGAMApplicationMenuOptionFilter gxTp_MenuOptionFilter ,
                                                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationMenuOption> returngetmenuoptions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returngetmenuoptions = new GXExternalCollection<SdtGAMApplicationMenuOption>( context, "SdtGAMApplicationMenuOption", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationMenuOption> externalParm0 ;
         Artech.Security.GAMApplicationMenuOptionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationMenuOptionFilter)(gxTp_MenuOptionFilter.ExternalInstance);
         externalParm0 = GAMApplicationMenu_externalReference.GetMenuOptions(gxTp_ApplicationId, externalParm1, out externalParm2);
         returngetmenuoptions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationMenuOption>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetmenuoptions ;
      }

      public SdtGAMApplicationMenuOption getmenuoptionbyid( long gxTp_ApplicationId ,
                                                            long gxTp_MenuOptionId ,
                                                            out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplicationMenuOption returngetmenuoptionbyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returngetmenuoptionbyid = new SdtGAMApplicationMenuOption(context);
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplicationMenu_externalReference.GetMenuOptionById(gxTp_ApplicationId, gxTp_MenuOptionId, out externalParm1);
         returngetmenuoptionbyid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetmenuoptionbyid ;
      }

      public bool addmenuoption( long gxTp_ApplicationId ,
                                 SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddmenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returnaddmenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returnaddmenuoption = (bool)(GAMApplicationMenu_externalReference.AddMenuOption(gxTp_ApplicationId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddmenuoption ;
      }

      public bool updatemenuoption( long gxTp_ApplicationId ,
                                    SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatemenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returnupdatemenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returnupdatemenuoption = (bool)(GAMApplicationMenu_externalReference.UpdateMenuOption(gxTp_ApplicationId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatemenuoption ;
      }

      public bool deletemenuoption( long gxTp_ApplicationId ,
                                    SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletemenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returndeletemenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returndeletemenuoption = (bool)(GAMApplicationMenu_externalReference.DeleteMenuOption(gxTp_ApplicationId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletemenuoption ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationMenu_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationMenu_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationMenu_externalReference == null )
         {
            GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationMenu_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.Id ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Token
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.Token ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.Name ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.Description ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.DateCreated ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.UserCreated ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.DateUpdated ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference.UserUpdated ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GAMApplicationMenu_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMApplicationMenu_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplicationMenu_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMApplicationMenu_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMApplicationMenu_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationMenu_externalReference == null )
            {
               GAMApplicationMenu_externalReference = new Artech.Security.GAMApplicationMenu(context);
            }
            return GAMApplicationMenu_externalReference ;
         }

         set {
            GAMApplicationMenu_externalReference = (Artech.Security.GAMApplicationMenu)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationMenu GAMApplicationMenu_externalReference=null ;
   }

}
