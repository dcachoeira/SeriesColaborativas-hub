/*
               File: type_SdtGAMRole
        Description: GAMRole
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.84
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
   public class SdtGAMRole : GxUserType, IGxExternalObject
   {
      public SdtGAMRole( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRole( IGxContext context )
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

      public SdtGAMRole getbyguid( String gxTp_GUID ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRole returngetbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetbyguid = new SdtGAMRole(context);
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRole_externalReference.GetByGUID(gxTp_GUID, out externalParm1);
         returngetbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyguid ;
      }

      public SdtGAMRole getbyname( String gxTp_Name ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRole returngetbyname ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetbyname = new SdtGAMRole(context);
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRole_externalReference.GetByName(gxTp_Name, out externalParm1);
         returngetbyname.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyname ;
      }

      public SdtGAMRole getbyexternalid( String gxTp_ExternalId ,
                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRole returngetbyexternalid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetbyexternalid = new SdtGAMRole(context);
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRole_externalReference.GetByExternalId(gxTp_ExternalId, out externalParm1);
         returngetbyexternalid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyexternalid ;
      }

      public bool saveas( out SdtGAMRole gxTp_Role ,
                          out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsaveas ;
         gxTp_Role = new SdtGAMRole(context);
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnsaveas = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         returnsaveas = (bool)(GAMRole_externalReference.SaveAs(out externalParm0, out externalParm1));
         gxTp_Role.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnsaveas ;
      }

      public GXExternalCollection<SdtGAMRole> getchildren( SdtGAMRoleFilter gxTp_RoleFilter ,
                                                           ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetchildren ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetchildren = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         Artech.Security.GAMRoleFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRoleFilter)(gxTp_RoleFilter.ExternalInstance);
         externalParm2 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         externalParm0 = GAMRole_externalReference.GetChildren(externalParm1, ref externalParm2);
         returngetchildren.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetchildren ;
      }

      public GXExternalCollection<SdtGAMRole> getallchildren( SdtGAMRoleFilter gxTp_RoleFilter ,
                                                              ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetallchildren ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetallchildren = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         Artech.Security.GAMRoleFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRoleFilter)(gxTp_RoleFilter.ExternalInstance);
         externalParm2 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         externalParm0 = GAMRole_externalReference.GetAllChildren(externalParm1, ref externalParm2);
         returngetallchildren.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetallchildren ;
      }

      public GXExternalCollection<SdtGAMRole> getunassignedroles( SdtGAMRoleFilter gxTp_RoleFilter ,
                                                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetunassignedroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetunassignedroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         Artech.Security.GAMRoleFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRoleFilter)(gxTp_RoleFilter.ExternalInstance);
         externalParm0 = GAMRole_externalReference.GetUnassignedRoles(externalParm1, out externalParm2);
         returngetunassignedroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetunassignedroles ;
      }

      public bool addrolebyid( long gxTp_RoleId ,
                               ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrolebyid ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnaddrolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         returnaddrolebyid = (bool)(GAMRole_externalReference.AddRoleById(gxTp_RoleId, ref externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnaddrolebyid ;
      }

      public bool addrole( SdtGAMRole gxTp_Role ,
                           ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrole ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnaddrole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         returnaddrole = (bool)(GAMRole_externalReference.AddRole(externalParm0, ref externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddrole ;
      }

      public bool deleterolebyid( long gxTp_RoleId ,
                                  ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterolebyid ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returndeleterolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         returndeleterolebyid = (bool)(GAMRole_externalReference.DeleteRoleById(gxTp_RoleId, ref externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeleterolebyid ;
      }

      public bool deleterole( SdtGAMRole gxTp_Role ,
                              ref GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterole ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returndeleterole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMError>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), gxTp_Errors.ExternalInstance);
         returndeleterole = (bool)(GAMRole_externalReference.DeleteRole(externalParm0, ref externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeleterole ;
      }

      public GXExternalCollection<SdtGAMUser> getusers( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMUser> returngetusers ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetusers = new GXExternalCollection<SdtGAMUser>( context, "SdtGAMUser", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMUser> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRole_externalReference.GetUsers(out externalParm1);
         returngetusers.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUser>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetusers ;
      }

      public GXExternalCollection<SdtGAMApplication> getapplicationswithpermission( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplication> returngetapplicationswithpermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetapplicationswithpermission = new GXExternalCollection<SdtGAMApplication>( context, "SdtGAMApplication", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplication> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRole_externalReference.GetApplicationsWithPermission(out externalParm1);
         returngetapplicationswithpermission.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplication>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetapplicationswithpermission ;
      }

      public GXExternalCollection<SdtGAMPermission> getpermissions( SdtGAMPermissionFilter gxTp_PermissionFilter ,
                                                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMPermission> returngetpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetpermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMPermission> externalParm0 ;
         Artech.Security.GAMPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMRole_externalReference.GetPermissions(externalParm1, out externalParm2);
         returngetpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetpermissions ;
      }

      public GXExternalCollection<SdtGAMPermission> getunassignedpermissions( SdtGAMPermissionFilter gxTp_PermissionFilter ,
                                                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMPermission> returngetunassignedpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngetunassignedpermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMPermission> externalParm0 ;
         Artech.Security.GAMPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMRole_externalReference.GetUnassignedPermissions(externalParm1, out externalParm2);
         returngetunassignedpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetunassignedpermissions ;
      }

      public bool addpermission( SdtGAMPermission gxTp_Permission ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddpermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnaddpermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returnaddpermission = (bool)(GAMRole_externalReference.AddPermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddpermission ;
      }

      public bool deletepermission( SdtGAMPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returndeletepermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returndeletepermission = (bool)(GAMRole_externalReference.DeletePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletepermission ;
      }

      public bool deletepermissionbyid( long gxTp_ApplicationId ,
                                        String gxTp_PermissionGUID ,
                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermissionbyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returndeletepermissionbyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeletepermissionbyid = (bool)(GAMRole_externalReference.DeletePermissionById(gxTp_ApplicationId, gxTp_PermissionGUID, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeletepermissionbyid ;
      }

      public bool updatepermission( SdtGAMPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnupdatepermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returnupdatepermission = (bool)(GAMRole_externalReference.UpdatePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatepermission ;
      }

      public void load( long gxTp_Id )
      {
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         GAMRole_externalReference.Load(gxTp_Id);
         return  ;
      }

      public void save( )
      {
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         GAMRole_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         GAMRole_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMRole_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMRole_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMRole_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRole_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRole_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRole_externalReference == null )
         {
            GAMRole_externalReference = new Artech.Security.GAMRole(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRole_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Id
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.Id ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.GUID ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Externalid
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.ExternalId ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.ExternalId = value;
            SetDirty("Externalid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.Name ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.Description ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.DateCreated ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.UserCreated ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.DateUpdated ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference.UserUpdated ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GAMRole_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMRole_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMRole_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMRole_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMRole_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRole_externalReference == null )
            {
               GAMRole_externalReference = new Artech.Security.GAMRole(context);
            }
            return GAMRole_externalReference ;
         }

         set {
            GAMRole_externalReference = (Artech.Security.GAMRole)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRole GAMRole_externalReference=null ;
   }

}
