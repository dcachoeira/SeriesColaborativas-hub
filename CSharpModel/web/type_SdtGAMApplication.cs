/*
               File: type_SdtGAMApplication
        Description: GAMApplication
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:46.51
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
   public class SdtGAMApplication : GxUserType, IGxExternalObject
   {
      public SdtGAMApplication( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplication( IGxContext context )
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

      public SdtGAMApplication get( )
      {
         SdtGAMApplication returnget ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnget = new SdtGAMApplication(context);
         Artech.Security.GAMApplication externalParm0 ;
         externalParm0 = GAMApplication_externalReference.Get();
         returnget.ExternalInstance = externalParm0;
         return returnget ;
      }

      public SdtGAMApplication getbyguid( String gxTp_GUID ,
                                          out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplication returngetbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetbyguid = new SdtGAMApplication(context);
         Artech.Security.GAMApplication externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetByGUID(gxTp_GUID, out externalParm1);
         returngetbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyguid ;
      }

      public String getguid( )
      {
         String returngetguid ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetguid = "";
         returngetguid = (String)(GAMApplication_externalReference.GetGUID());
         return returngetguid ;
      }

      public void gohome( )
      {
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         GAMApplication_externalReference.GoHome();
         return  ;
      }

      public GXExternalCollection<SdtGAMApplicationPermission> getpermissions( SdtGAMApplicationPermissionFilter gxTp_PermissionFilter ,
                                                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationPermission> returngetpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetpermissions = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationPermission> externalParm0 ;
         Artech.Security.GAMApplicationPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetPermissions(externalParm1, out externalParm2);
         returngetpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetpermissions ;
      }

      public SdtGAMApplicationPermission getpermissionbyguid( String gxTp_PermissionId ,
                                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplicationPermission returngetpermissionbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetpermissionbyguid = new SdtGAMApplicationPermission(context);
         Artech.Security.GAMApplicationPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetPermissionByGUID(gxTp_PermissionId, out externalParm1);
         returngetpermissionbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetpermissionbyguid ;
      }

      public SdtGAMApplicationPermission getpermissionbyname( String gxTp_PermissionName ,
                                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplicationPermission returngetpermissionbyname ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetpermissionbyname = new SdtGAMApplicationPermission(context);
         Artech.Security.GAMApplicationPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetPermissionByName(gxTp_PermissionName, out externalParm1);
         returngetpermissionbyname.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetpermissionbyname ;
      }

      public GXExternalCollection<SdtGAMApplicationPermission> getpermissionchildren( String gxTp_PermissionId ,
                                                                                      SdtGAMApplicationPermissionFilter gxTp_PermissionFilter ,
                                                                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationPermission> returngetpermissionchildren ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetpermissionchildren = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationPermission> externalParm0 ;
         Artech.Security.GAMApplicationPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetPermissionChildren(gxTp_PermissionId, externalParm1, out externalParm2);
         returngetpermissionchildren.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetpermissionchildren ;
      }

      public GXExternalCollection<SdtGAMApplicationPermission> getunassignedpermissiontoparent( String gxTp_PermissionId ,
                                                                                                SdtGAMApplicationPermissionFilter gxTp_PermissionFilter ,
                                                                                                out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationPermission> returngetunassignedpermissiontoparent ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetunassignedpermissiontoparent = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationPermission> externalParm0 ;
         Artech.Security.GAMApplicationPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetUnassignedPermissionToParent(gxTp_PermissionId, externalParm1, out externalParm2);
         returngetunassignedpermissiontoparent.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetunassignedpermissiontoparent ;
      }

      public bool addpermission( SdtGAMApplicationPermission gxTp_Permission ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddpermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddpermission = false;
         Artech.Security.GAMApplicationPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationPermission)(gxTp_Permission.ExternalInstance);
         returnaddpermission = (bool)(GAMApplication_externalReference.AddPermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddpermission ;
      }

      public bool updatepermission( SdtGAMApplicationPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnupdatepermission = false;
         Artech.Security.GAMApplicationPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationPermission)(gxTp_Permission.ExternalInstance);
         returnupdatepermission = (bool)(GAMApplication_externalReference.UpdatePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatepermission ;
      }

      public bool deletepermission( SdtGAMApplicationPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeletepermission = false;
         Artech.Security.GAMApplicationPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationPermission)(gxTp_Permission.ExternalInstance);
         returndeletepermission = (bool)(GAMApplication_externalReference.DeletePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletepermission ;
      }

      public bool addpermissionchild( String gxTp_PermissionId ,
                                      String gxTp_PermissionChildId ,
                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddpermissionchild ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddpermissionchild = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnaddpermissionchild = (bool)(GAMApplication_externalReference.AddPermissionChild(gxTp_PermissionId, gxTp_PermissionChildId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnaddpermissionchild ;
      }

      public bool deletepermissionchild( String gxTp_PermissionId ,
                                         String gxTp_PermissionChildId ,
                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermissionchild ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeletepermissionchild = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeletepermissionchild = (bool)(GAMApplication_externalReference.DeletePermissionChild(gxTp_PermissionId, gxTp_PermissionChildId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeletepermissionchild ;
      }

      public GXExternalCollection<SdtGAMApplicationMenu> getmenus( SdtGAMApplicationMenuFilter gxTp_MenuFilter ,
                                                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationMenu> returngetmenus ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetmenus = new GXExternalCollection<SdtGAMApplicationMenu>( context, "SdtGAMApplicationMenu", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationMenu> externalParm0 ;
         Artech.Security.GAMApplicationMenuFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationMenuFilter)(gxTp_MenuFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetMenus(externalParm1, out externalParm2);
         returngetmenus.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationMenu>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetmenus ;
      }

      public GXExternalCollection<SdtGAMApplicationMenu> getsubmenus( long gxTp_MenuId ,
                                                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationMenu> returngetsubmenus ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetsubmenus = new GXExternalCollection<SdtGAMApplicationMenu>( context, "SdtGAMApplicationMenu", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationMenu> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetSubMenus(gxTp_MenuId, out externalParm1);
         returngetsubmenus.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationMenu>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetsubmenus ;
      }

      public SdtGAMApplicationMenu getmenu( long gxTp_MenuId ,
                                            out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplicationMenu returngetmenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetmenu = new SdtGAMApplicationMenu(context);
         Artech.Security.GAMApplicationMenu externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetMenu(gxTp_MenuId, out externalParm1);
         returngetmenu.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetmenu ;
      }

      public bool addmenu( SdtGAMApplicationMenu gxTp_Menu ,
                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddmenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddmenu = false;
         Artech.Security.GAMApplicationMenu externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenu)(gxTp_Menu.ExternalInstance);
         returnaddmenu = (bool)(GAMApplication_externalReference.AddMenu(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddmenu ;
      }

      public bool updatemenu( SdtGAMApplicationMenu gxTp_Menu ,
                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatemenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnupdatemenu = false;
         Artech.Security.GAMApplicationMenu externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenu)(gxTp_Menu.ExternalInstance);
         returnupdatemenu = (bool)(GAMApplication_externalReference.UpdateMenu(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatemenu ;
      }

      public bool deletemenu( SdtGAMApplicationMenu gxTp_Menu ,
                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletemenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeletemenu = false;
         Artech.Security.GAMApplicationMenu externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenu)(gxTp_Menu.ExternalInstance);
         returndeletemenu = (bool)(GAMApplication_externalReference.DeleteMenu(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletemenu ;
      }

      public GXExternalCollection<SdtGAMApplicationMenuOption> getmenuoptions( long gxTp_MenuId ,
                                                                               SdtGAMApplicationMenuOptionFilter gxTp_MenuOptionFilter ,
                                                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationMenuOption> returngetmenuoptions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetmenuoptions = new GXExternalCollection<SdtGAMApplicationMenuOption>( context, "SdtGAMApplicationMenuOption", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationMenuOption> externalParm0 ;
         Artech.Security.GAMApplicationMenuOptionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationMenuOptionFilter)(gxTp_MenuOptionFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetMenuOptions(gxTp_MenuId, externalParm1, out externalParm2);
         returngetmenuoptions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationMenuOption>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetmenuoptions ;
      }

      public SdtGAMApplicationMenuOption getmenuoption( long gxTp_MenuId ,
                                                        long gxTp_MenuOptionId ,
                                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplicationMenuOption returngetmenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetmenuoption = new SdtGAMApplicationMenuOption(context);
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetMenuOption(gxTp_MenuId, gxTp_MenuOptionId, out externalParm1);
         returngetmenuoption.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetmenuoption ;
      }

      public bool addmenuoption( long gxTp_MenuId ,
                                 SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddmenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddmenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returnaddmenuoption = (bool)(GAMApplication_externalReference.AddMenuOption(gxTp_MenuId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddmenuoption ;
      }

      public bool updatemenuoption( long gxTp_MenuId ,
                                    SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatemenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnupdatemenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returnupdatemenuoption = (bool)(GAMApplication_externalReference.UpdateMenuOption(gxTp_MenuId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatemenuoption ;
      }

      public bool deletemenuoption( long gxTp_MenuId ,
                                    SdtGAMApplicationMenuOption gxTp_MenuOption ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletemenuoption ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeletemenuoption = false;
         Artech.Security.GAMApplicationMenuOption externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMApplicationMenuOption)(gxTp_MenuOption.ExternalInstance);
         returndeletemenuoption = (bool)(GAMApplication_externalReference.DeleteMenuOption(gxTp_MenuId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletemenuoption ;
      }

      public SdtGAMMenuOptionList getusermainmenu( SdtGAMMenuAdditionalParameters gxTp_AdditionalParameters ,
                                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMMenuOptionList returngetusermainmenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetusermainmenu = new SdtGAMMenuOptionList(context);
         Artech.Security.GAMMenuOptionList externalParm0 ;
         Artech.Security.GAMMenuAdditionalParameters externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMMenuAdditionalParameters)(gxTp_AdditionalParameters.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetUserMainMenu(externalParm1, out externalParm2);
         returngetusermainmenu.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetusermainmenu ;
      }

      public SdtGAMMenuOptionList getusermenu( long gxTp_MenuId ,
                                               SdtGAMMenuAdditionalParameters gxTp_AdditionalParameters ,
                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMMenuOptionList returngetusermenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetusermenu = new SdtGAMMenuOptionList(context);
         Artech.Security.GAMMenuOptionList externalParm0 ;
         Artech.Security.GAMMenuAdditionalParameters externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMMenuAdditionalParameters)(gxTp_AdditionalParameters.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetUserMenu(gxTp_MenuId, externalParm1, out externalParm2);
         returngetusermenu.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetusermenu ;
      }

      public SdtGAMMenuOptionList getusermenubyguid( String gxTp_MenuGUID ,
                                                     SdtGAMMenuAdditionalParameters gxTp_AdditionalParameters ,
                                                     out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMMenuOptionList returngetusermenubyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetusermenubyguid = new SdtGAMMenuOptionList(context);
         Artech.Security.GAMMenuOptionList externalParm0 ;
         Artech.Security.GAMMenuAdditionalParameters externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMMenuAdditionalParameters)(gxTp_AdditionalParameters.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetUserMenuByGUID(gxTp_MenuGUID, externalParm1, out externalParm2);
         returngetusermenubyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetusermenubyguid ;
      }

      public GXExternalCollection<SdtGAMApplicationPermission> getpermissionresources( SdtGAMApplicationPermissionFilter gxTp_PermissionFilter ,
                                                                                       out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplicationPermission> returngetpermissionresources ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetpermissionresources = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplicationPermission> externalParm0 ;
         Artech.Security.GAMApplicationPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMApplication_externalReference.GetPermissionResources(externalParm1, out externalParm2);
         returngetpermissionresources.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetpermissionresources ;
      }

      public bool revokeclient( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnrevokeclient ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnrevokeclient = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnrevokeclient = (bool)(GAMApplication_externalReference.RevokeClient(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnrevokeclient ;
      }

      public bool authorizeclient( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnauthorizeclient ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnauthorizeclient = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnauthorizeclient = (bool)(GAMApplication_externalReference.AuthorizeClient(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnauthorizeclient ;
      }

      public bool checkpermission( String gxTp_PermissionName )
      {
         bool returncheckpermission ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returncheckpermission = false;
         returncheckpermission = (bool)(GAMApplication_externalReference.CheckPermission(gxTp_PermissionName));
         return returncheckpermission ;
      }

      public GXExternalCollection<SdtGAMRole> getroles( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetRoles(out externalParm1);
         returngetroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetroles ;
      }

      public GXExternalCollection<SdtGAMRole> getallroles( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetallroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngetallroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMApplication_externalReference.GetAllRoles(out externalParm1);
         returngetallroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetallroles ;
      }

      public bool addrole( SdtGAMRole gxTp_Role ,
                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrole ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddrole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         returnaddrole = (bool)(GAMApplication_externalReference.AddRole(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddrole ;
      }

      public bool addrolebyid( long gxTp_RoleId ,
                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrolebyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnaddrolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnaddrolebyid = (bool)(GAMApplication_externalReference.AddRoleById(gxTp_RoleId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnaddrolebyid ;
      }

      public bool deleterole( SdtGAMRole gxTp_Role ,
                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterole ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeleterole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         returndeleterole = (bool)(GAMApplication_externalReference.DeleteRole(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeleterole ;
      }

      public bool deleterolebyid( long gxTp_RoleId ,
                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterolebyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returndeleterolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeleterolebyid = (bool)(GAMApplication_externalReference.DeleteRoleById(gxTp_RoleId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeleterolebyid ;
      }

      public void load( long gxTp_Id )
      {
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         GAMApplication_externalReference.Load(gxTp_Id);
         return  ;
      }

      public void save( )
      {
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         GAMApplication_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         GAMApplication_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMApplication_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMApplication_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMApplication_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplication_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplication_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplication_externalReference == null )
         {
            GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplication_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Id ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.GUID ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Version
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Version ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Version = value;
            SetDirty("Version");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Name ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Description ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMApplicationEnvironment gxTpr_Environment
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            intValue = new SdtGAMApplicationEnvironment(context);
            Artech.Security.GAMApplicationEnvironment externalParm0 ;
            externalParm0 = GAMApplication_externalReference.Environment;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            SdtGAMApplicationEnvironment intValue ;
            Artech.Security.GAMApplicationEnvironment externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMApplicationEnvironment)(intValue.ExternalInstance);
            GAMApplication_externalReference.Environment = externalParm1;
            SetDirty("Environment");
         }

      }

      public String gxTpr_Companyname
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.CompanyName ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.CompanyName = value;
            SetDirty("Companyname");
         }

      }

      public String gxTpr_Copyright
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Copyright ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Copyright = value;
            SetDirty("Copyright");
         }

      }

      public bool gxTpr_Useabsoluteurlbyenvironment
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.UseAbsoluteUrlByEnvironment ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.UseAbsoluteUrlByEnvironment = value;
            SetDirty("Useabsoluteurlbyenvironment");
         }

      }

      public String gxTpr_Homeobject
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.HomeObject ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.HomeObject = value;
            SetDirty("Homeobject");
         }

      }

      public String gxTpr_Logoutobject
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.LogoutObject ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.LogoutObject = value;
            SetDirty("Logoutobject");
         }

      }

      public long gxTpr_Mainmenuid
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.MainMenuId ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.MainMenuId = value;
            SetDirty("Mainmenuid");
         }

      }

      public bool gxTpr_Isbaseapplication
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.IsBaseApplication ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.IsBaseApplication = value;
            SetDirty("Isbaseapplication");
         }

      }

      public long gxTpr_Applicationbase
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ApplicationBase ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ApplicationBase = value;
            SetDirty("Applicationbase");
         }

      }

      public long gxTpr_Applicationparent
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ApplicationParent ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ApplicationParent = value;
            SetDirty("Applicationparent");
         }

      }

      public bool gxTpr_Returnmenuoptionswithoutpermission
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ReturnMenuOptionsWithoutPermission ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ReturnMenuOptionsWithoutPermission = value;
            SetDirty("Returnmenuoptionswithoutpermission");
         }

      }

      public bool gxTpr_Accessrequirespermission
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.AccessRequiresPermission ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.AccessRequiresPermission = value;
            SetDirty("Accessrequirespermission");
         }

      }

      public int gxTpr_Order
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Order ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Order = value;
            SetDirty("Order");
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.Type ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public bool gxTpr_Isauthorizationdelegated
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.IsAuthorizationDelegated ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.IsAuthorizationDelegated = value;
            SetDirty("Isauthorizationdelegated");
         }

      }

      public SdtGAMApplicationDelegateAuthorization gxTpr_Delegateauthorization
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            SdtGAMApplicationDelegateAuthorization intValue ;
            intValue = new SdtGAMApplicationDelegateAuthorization(context);
            Artech.Security.GAMApplicationDelegateAuthorization externalParm2 ;
            externalParm2 = GAMApplication_externalReference.DelegateAuthorization;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            SdtGAMApplicationDelegateAuthorization intValue ;
            Artech.Security.GAMApplicationDelegateAuthorization externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMApplicationDelegateAuthorization)(intValue.ExternalInstance);
            GAMApplication_externalReference.DelegateAuthorization = externalParm3;
            SetDirty("Delegateauthorization");
         }

      }

      public bool gxTpr_Clientautoregisteranomymoususer
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientAutoRegisterAnomymousUser ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientAutoRegisterAnomymousUser = value;
            SetDirty("Clientautoregisteranomymoususer");
         }

      }

      public String gxTpr_Clientid
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientId ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientId = value;
            SetDirty("Clientid");
         }

      }

      public String gxTpr_Clientsecret
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientSecret ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientSecret = value;
            SetDirty("Clientsecret");
         }

      }

      public bool gxTpr_Clientaccessuniquebyuser
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientAccessUniqueByUser ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientAccessUniqueByUser = value;
            SetDirty("Clientaccessuniquebyuser");
         }

      }

      public DateTime gxTpr_Clientrevoked
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientRevoked ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientRevoked = value;
            SetDirty("Clientrevoked");
         }

      }

      public bool gxTpr_Clientallowremoteauthentication
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientAllowRemoteAuthentication ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientAllowRemoteAuthentication = value;
            SetDirty("Clientallowremoteauthentication");
         }

      }

      public bool gxTpr_Clientallowgetuseradditionaldata
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientAllowGetUserAdditionalData ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientAllowGetUserAdditionalData = value;
            SetDirty("Clientallowgetuseradditionaldata");
         }

      }

      public bool gxTpr_Clientallowgetuserroles
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientAllowGetUserRoles ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientAllowGetUserRoles = value;
            SetDirty("Clientallowgetuserroles");
         }

      }

      public String gxTpr_Clientlocalloginurl
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientLocalLoginURL ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientLocalLoginURL = value;
            SetDirty("Clientlocalloginurl");
         }

      }

      public String gxTpr_Clientcallbackurl
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientCallbackURL ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientCallbackURL = value;
            SetDirty("Clientcallbackurl");
         }

      }

      public String gxTpr_Clientimageurl
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientImageURL ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientImageURL = value;
            SetDirty("Clientimageurl");
         }

      }

      public String gxTpr_Clientencryptionkey
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientEncryptionKey ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientEncryptionKey = value;
            SetDirty("Clientencryptionkey");
         }

      }

      public String gxTpr_Clientrepositoryguid
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.ClientRepositoryGUID ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.ClientRepositoryGUID = value;
            SetDirty("Clientrepositoryguid");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm4 ;
            externalParm4 = GAMApplication_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm4);
            return intValue ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm5 ;
            intValue = value;
            externalParm5 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplication_externalReference.Descriptions = externalParm5;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm6 ;
            externalParm6 = GAMApplication_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm6);
            return intValue ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm7 ;
            intValue = value;
            externalParm7 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMApplication_externalReference.Properties = externalParm7;
            SetDirty("Properties");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.DateCreated ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.UserCreated ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.DateUpdated ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference.UserUpdated ;
         }

         set {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            GAMApplication_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplication_externalReference == null )
            {
               GAMApplication_externalReference = new Artech.Security.GAMApplication(context);
            }
            return GAMApplication_externalReference ;
         }

         set {
            GAMApplication_externalReference = (Artech.Security.GAMApplication)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplication GAMApplication_externalReference=null ;
   }

}
