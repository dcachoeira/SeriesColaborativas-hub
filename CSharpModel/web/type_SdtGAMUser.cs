/*
               File: type_SdtGAMUser
        Description: GAMUser
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.52
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
   public class SdtGAMUser : GxUserType, IGxExternalObject
   {
      public SdtGAMUser( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUser( IGxContext context )
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

      public SdtGAMUser get( )
      {
         SdtGAMUser returnget ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnget = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         externalParm0 = GAMUser_externalReference.Get();
         returnget.ExternalInstance = externalParm0;
         return returnget ;
      }

      public SdtGAMUser getbyguid( String gxTp_GUID ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetbyguid = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetByGUID(gxTp_GUID, out externalParm1);
         returngetbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyguid ;
      }

      public SdtGAMUser getbyexternalid( String gxTp_ExternalId ,
                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetbyexternalid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetbyexternalid = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetByExternalId(gxTp_ExternalId, out externalParm1);
         returngetbyexternalid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyexternalid ;
      }

      public SdtGAMUser getbylogin( String gxTp_AuthenticationTypeName ,
                                    String gxTp_UserName ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetbylogin ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetbylogin = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetByLogin(gxTp_AuthenticationTypeName, gxTp_UserName, out externalParm1);
         returngetbylogin.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbylogin ;
      }

      public String getid( )
      {
         String returngetid ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetid = "";
         returngetid = (String)(GAMUser_externalReference.GetId());
         return returngetid ;
      }

      public String getlogin( )
      {
         String returngetlogin ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetlogin = "";
         returngetlogin = (String)(GAMUser_externalReference.GetLogin());
         return returngetlogin ;
      }

      public String getname( )
      {
         String returngetname ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetname = "";
         returngetname = (String)(GAMUser_externalReference.GetName());
         return returngetname ;
      }

      public String getexternalid( )
      {
         String returngetexternalid ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetexternalid = "";
         returngetexternalid = (String)(GAMUser_externalReference.GetExternalId());
         return returngetexternalid ;
      }

      public String getemail( )
      {
         String returngetemail ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetemail = "";
         returngetemail = (String)(GAMUser_externalReference.GetEmail());
         return returngetemail ;
      }

      public bool isanonymous( )
      {
         bool returnisanonymous ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnisanonymous = false;
         returnisanonymous = (bool)(GAMUser_externalReference.isAnonymous());
         return returnisanonymous ;
      }

      public bool checkrole( String gxTp_RoleName )
      {
         bool returncheckrole ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returncheckrole = false;
         returncheckrole = (bool)(GAMUser_externalReference.CheckRole(gxTp_RoleName));
         return returncheckrole ;
      }

      public bool checkrolebyid( long gxTp_RoleId )
      {
         bool returncheckrolebyid ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returncheckrolebyid = false;
         returncheckrolebyid = (bool)(GAMUser_externalReference.CheckRoleById(gxTp_RoleId));
         return returncheckrolebyid ;
      }

      public bool checkrolebyguid( String gxTp_GUID )
      {
         bool returncheckrolebyguid ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returncheckrolebyguid = false;
         returncheckrolebyguid = (bool)(GAMUser_externalReference.CheckRoleByGUID(gxTp_GUID));
         return returncheckrolebyguid ;
      }

      public bool checkrolebyexternalid( String gxTp_ExternalId )
      {
         bool returncheckrolebyexternalid ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returncheckrolebyexternalid = false;
         returncheckrolebyexternalid = (bool)(GAMUser_externalReference.CheckRoleByExternalId(gxTp_ExternalId));
         return returncheckrolebyexternalid ;
      }

      public GXExternalCollection<SdtGAMRole> getroles( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetRoles(out externalParm1);
         returngetroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetroles ;
      }

      public GXExternalCollection<SdtGAMRole> getallroles( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetallroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetallroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetAllRoles(out externalParm1);
         returngetallroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetallroles ;
      }

      public String getactivationkey( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         String returngetactivationkey ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetactivationkey = "";
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngetactivationkey = (String)(GAMUser_externalReference.GetActivationKey(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetactivationkey ;
      }

      public SdtGAMUserAttribute getattribute( String gxTp_AttibuteId ,
                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUserAttribute returngetattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetattribute = new SdtGAMUserAttribute(context);
         Artech.Security.GAMUserAttribute externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetAttribute(gxTp_AttibuteId, out externalParm1);
         returngetattribute.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetattribute ;
      }

      public bool setattribute( SdtGAMUserAttribute gxTp_Attibute ,
                                out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnsetattribute = false;
         Artech.Security.GAMUserAttribute externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUserAttribute)(gxTp_Attibute.ExternalInstance);
         returnsetattribute = (bool)(GAMUser_externalReference.SetAttribute(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnsetattribute ;
      }

      public bool deleteattribute( SdtGAMUserAttribute gxTp_Attibute ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleteattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeleteattribute = false;
         Artech.Security.GAMUserAttribute externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUserAttribute)(gxTp_Attibute.ExternalInstance);
         returndeleteattribute = (bool)(GAMUser_externalReference.DeleteAttribute(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeleteattribute ;
      }

      public String getmultivaluedattribute( String gxTp_AttibuteId ,
                                             String gxTp_ValueId ,
                                             out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         String returngetmultivaluedattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetmultivaluedattribute = "";
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngetmultivaluedattribute = (String)(GAMUser_externalReference.GetMultivaluedAttribute(gxTp_AttibuteId, gxTp_ValueId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetmultivaluedattribute ;
      }

      public bool setmultivaluedattribute( String gxTp_AttibuteId ,
                                           String gxTp_ValueId ,
                                           String gxTp_Value ,
                                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetmultivaluedattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnsetmultivaluedattribute = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetmultivaluedattribute = (bool)(GAMUser_externalReference.SetMultivaluedAttribute(gxTp_AttibuteId, gxTp_ValueId, gxTp_Value, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetmultivaluedattribute ;
      }

      public bool deletemultivaluedattribute( String gxTp_AttibuteId ,
                                              String gxTp_ValueId ,
                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletemultivaluedattribute ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeletemultivaluedattribute = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeletemultivaluedattribute = (bool)(GAMUser_externalReference.DeleteMultivaluedAttribute(gxTp_AttibuteId, gxTp_ValueId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeletemultivaluedattribute ;
      }

      public bool setpassword( String gxTp_PasswordNew ,
                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetpassword ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnsetpassword = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetpassword = (bool)(GAMUser_externalReference.SetPassword(gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetpassword ;
      }

      public bool changeyourpassword( String gxTp_PasswordOld ,
                                      String gxTp_PasswordNew ,
                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnchangeyourpassword ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnchangeyourpassword = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnchangeyourpassword = (bool)(GAMUser_externalReference.ChangeYourPassword(gxTp_PasswordOld, gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnchangeyourpassword ;
      }

      public bool changepassword( String gxTp_PasswordOld ,
                                  String gxTp_PasswordNew ,
                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnchangepassword ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnchangepassword = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnchangepassword = (bool)(GAMUser_externalReference.ChangePassword(gxTp_PasswordOld, gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnchangepassword ;
      }

      public String recoverpassword( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         String returnrecoverpassword ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnrecoverpassword = "";
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnrecoverpassword = (String)(GAMUser_externalReference.RecoverPassword(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnrecoverpassword ;
      }

      public String recoverpasswordbykey( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         String returnrecoverpasswordbykey ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnrecoverpasswordbykey = "";
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnrecoverpasswordbykey = (String)(GAMUser_externalReference.RecoverPasswordByKey(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnrecoverpasswordbykey ;
      }

      public bool changepasswordbykey( String gxTp_PasswordKey ,
                                       String gxTp_PasswordNew ,
                                       out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnchangepasswordbykey ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnchangepasswordbykey = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnchangepasswordbykey = (bool)(GAMUser_externalReference.ChangePasswordByKey(gxTp_PasswordKey, gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnchangepasswordbykey ;
      }

      public bool changepasswordbyquestion( int gxTp_QuestionId ,
                                            String gxTp_Answer ,
                                            String gxTp_PasswordNew ,
                                            out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnchangepasswordbyquestion ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnchangepasswordbyquestion = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnchangepasswordbyquestion = (bool)(GAMUser_externalReference.ChangePasswordByQuestion(gxTp_QuestionId, gxTp_Answer, gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnchangepasswordbyquestion ;
      }

      public bool addrolebyid( long gxTp_RoleId ,
                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrolebyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnaddrolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnaddrolebyid = (bool)(GAMUser_externalReference.AddRoleById(gxTp_RoleId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnaddrolebyid ;
      }

      public bool addrole( SdtGAMRole gxTp_Role ,
                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddrole ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnaddrole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         returnaddrole = (bool)(GAMUser_externalReference.AddRole(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddrole ;
      }

      public bool deleterole( SdtGAMRole gxTp_Role ,
                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterole ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeleterole = false;
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRole)(gxTp_Role.ExternalInstance);
         returndeleterole = (bool)(GAMUser_externalReference.DeleteRole(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeleterole ;
      }

      public bool deleterolebyid( long gxTp_RoleId ,
                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterolebyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeleterolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeleterolebyid = (bool)(GAMUser_externalReference.DeleteRoleById(gxTp_RoleId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeleterolebyid ;
      }

      public bool setmainrolebyid( long gxTp_RoleId ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetmainrolebyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnsetmainrolebyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetmainrolebyid = (bool)(GAMUser_externalReference.SetMainRoleById(gxTp_RoleId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetmainrolebyid ;
      }

      public bool killsessions( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnkillsessions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnkillsessions = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnkillsessions = (bool)(GAMUser_externalReference.KillSessions(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnkillsessions ;
      }

      public bool repositoryenable( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnrepositoryenable ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnrepositoryenable = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnrepositoryenable = (bool)(GAMUser_externalReference.RepositoryEnable(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnrepositoryenable ;
      }

      public bool repositorydisable( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnrepositorydisable ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnrepositorydisable = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnrepositorydisable = (bool)(GAMUser_externalReference.RepositoryDisable(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnrepositorydisable ;
      }

      public GXExternalCollection<SdtGAMUserRepository> getrepositories( SdtGAMUserRepositoryFilter gxTp_UserRepositoryFilter ,
                                                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMUserRepository> returngetrepositories ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetrepositories = new GXExternalCollection<SdtGAMUserRepository>( context, "SdtGAMUserRepository", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMUserRepository> externalParm0 ;
         Artech.Security.GAMUserRepositoryFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMUserRepositoryFilter)(gxTp_UserRepositoryFilter.ExternalInstance);
         externalParm0 = GAMUser_externalReference.GetRepositories(externalParm1, out externalParm2);
         returngetrepositories.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUserRepository>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetrepositories ;
      }

      public bool addpermission( SdtGAMPermission gxTp_Permission ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnaddpermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnaddpermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returnaddpermission = (bool)(GAMUser_externalReference.AddPermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnaddpermission ;
      }

      public GXExternalCollection<SdtGAMPermission> getpermissions( SdtGAMPermissionFilter gxTp_PermissionFilter ,
                                                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMPermission> returngetpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetpermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMPermission> externalParm0 ;
         Artech.Security.GAMPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMUser_externalReference.GetPermissions(externalParm1, out externalParm2);
         returngetpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetpermissions ;
      }

      public GXExternalCollection<SdtGAMPermission> getunassignedpermissions( SdtGAMPermissionFilter gxTp_PermissionFilter ,
                                                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMPermission> returngetunassignedpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetunassignedpermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMPermission> externalParm0 ;
         Artech.Security.GAMPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMUser_externalReference.GetUnassignedPermissions(externalParm1, out externalParm2);
         returngetunassignedpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetunassignedpermissions ;
      }

      public GXExternalCollection<SdtGAMPermission> getallpermissions( SdtGAMPermissionFilter gxTp_PermissionFilter ,
                                                                       out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMPermission> returngetallpermissions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetallpermissions = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMPermission> externalParm0 ;
         Artech.Security.GAMPermissionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMPermissionFilter)(gxTp_PermissionFilter.ExternalInstance);
         externalParm0 = GAMUser_externalReference.GetAllPermissions(externalParm1, out externalParm2);
         returngetallpermissions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMPermission>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetallpermissions ;
      }

      public bool deletepermission( SdtGAMPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeletepermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returndeletepermission = (bool)(GAMUser_externalReference.DeletePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returndeletepermission ;
      }

      public bool deletepermissionbyid( long gxTp_ApplicationId ,
                                        String gxTp_PermissionGUID ,
                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeletepermissionbyid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returndeletepermissionbyid = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeletepermissionbyid = (bool)(GAMUser_externalReference.DeletePermissionById(gxTp_ApplicationId, gxTp_PermissionGUID, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeletepermissionbyid ;
      }

      public bool updatepermission( SdtGAMPermission gxTp_Permission ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatepermission ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnupdatepermission = false;
         Artech.Security.GAMPermission externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMPermission)(gxTp_Permission.ExternalInstance);
         returnupdatepermission = (bool)(GAMUser_externalReference.UpdatePermission(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatepermission ;
      }

      public GXExternalCollection<SdtGAMRole> getapplicationroles( long gxTp_ApplicationId ,
                                                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetapplicationroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetapplicationroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetApplicationRoles(gxTp_ApplicationId, out externalParm1);
         returngetapplicationroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetapplicationroles ;
      }

      public GXExternalCollection<SdtGAMRole> getallapplicationroles( long gxTp_ApplicationId ,
                                                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetallapplicationroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngetallapplicationroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMUser_externalReference.GetAllApplicationRoles(gxTp_ApplicationId, out externalParm1);
         returngetallapplicationroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetallapplicationroles ;
      }

      public void load( String gxTp_GUID )
      {
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         GAMUser_externalReference.Load(gxTp_GUID);
         return  ;
      }

      public void save( )
      {
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         GAMUser_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         GAMUser_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMUser_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMUser_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMUser_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUser_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUser_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUser_externalReference == null )
         {
            GAMUser_externalReference = new Artech.Security.GAMUser(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUser_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.GUID ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Namespace
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.NameSpace ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.NameSpace = value;
            SetDirty("Namespace");
         }

      }

      public String gxTpr_Authenticationtypename
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.AuthenticationTypeName ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.AuthenticationTypeName = value;
            SetDirty("Authenticationtypename");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Name ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Login
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Login ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Login = value;
            SetDirty("Login");
         }

      }

      public String gxTpr_Email
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.EMail ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.EMail = value;
            SetDirty("Email");
         }

      }

      public String gxTpr_Externalid
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.ExternalId ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.ExternalId = value;
            SetDirty("Externalid");
         }

      }

      public String gxTpr_Password
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Password ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Password = value;
            SetDirty("Password");
         }

      }

      public String gxTpr_Firstname
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.FirstName ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.FirstName = value;
            SetDirty("Firstname");
         }

      }

      public String gxTpr_Lastname
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.LastName ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.LastName = value;
            SetDirty("Lastname");
         }

      }

      public DateTime gxTpr_Birthday
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Birthday ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Birthday = value;
            SetDirty("Birthday");
         }

      }

      public String gxTpr_Gender
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Gender ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Gender = value;
            SetDirty("Gender");
         }

      }

      public String gxTpr_Urlimage
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.URLImage ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.URLImage = value;
            SetDirty("Urlimage");
         }

      }

      public String gxTpr_Urlprofile
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.URLProfile ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.URLProfile = value;
            SetDirty("Urlprofile");
         }

      }

      public String gxTpr_Phone
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Phone ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Phone = value;
            SetDirty("Phone");
         }

      }

      public String gxTpr_Address
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Address ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Address = value;
            SetDirty("Address");
         }

      }

      public String gxTpr_Address2
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Address2 ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Address2 = value;
            SetDirty("Address2");
         }

      }

      public String gxTpr_City
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.City ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.City = value;
            SetDirty("City");
         }

      }

      public String gxTpr_State
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.State ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.State = value;
            SetDirty("State");
         }

      }

      public String gxTpr_Postcode
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.PostCode ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.PostCode = value;
            SetDirty("Postcode");
         }

      }

      public SdtGAMCountry gxTpr_Country
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            SdtGAMCountry intValue ;
            intValue = new SdtGAMCountry(context);
            Artech.Security.GAMCountry externalParm0 ;
            externalParm0 = GAMUser_externalReference.Country;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            SdtGAMCountry intValue ;
            Artech.Security.GAMCountry externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMCountry)(intValue.ExternalInstance);
            GAMUser_externalReference.Country = externalParm1;
            SetDirty("Country");
         }

      }

      public String gxTpr_Language
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.Language ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.Language = value;
            SetDirty("Language");
         }

      }

      public String gxTpr_Timezone
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.TimeZone ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.TimeZone = value;
            SetDirty("Timezone");
         }

      }

      public bool gxTpr_Dontreceiveinformation
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DontReceiveInformation ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DontReceiveInformation = value;
            SetDirty("Dontreceiveinformation");
         }

      }

      public bool gxTpr_Isblocked
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.IsBlocked ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.IsBlocked = value;
            SetDirty("Isblocked");
         }

      }

      public DateTime gxTpr_Lastblockeddate
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.LastBlockedDate ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.LastBlockedDate = value;
            SetDirty("Lastblockeddate");
         }

      }

      public bool gxTpr_Isactive
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.IsActive ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.IsActive = value;
            SetDirty("Isactive");
         }

      }

      public DateTime gxTpr_Activationdate
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.ActivationDate ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.ActivationDate = value;
            SetDirty("Activationdate");
         }

      }

      public bool gxTpr_Cannotchangepassword
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.CannotChangePassword ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.CannotChangePassword = value;
            SetDirty("Cannotchangepassword");
         }

      }

      public bool gxTpr_Mustchangepassword
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.MustChangePassword ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.MustChangePassword = value;
            SetDirty("Mustchangepassword");
         }

      }

      public bool gxTpr_Passwordneverexpires
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.PasswordNeverExpires ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.PasswordNeverExpires = value;
            SetDirty("Passwordneverexpires");
         }

      }

      public DateTime gxTpr_Datelastchangepassword
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DateLastChangePassword ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DateLastChangePassword = value;
            SetDirty("Datelastchangepassword");
         }

      }

      public int gxTpr_Securitypolicyid
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.SecurityPolicyId ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.SecurityPolicyId = value;
            SetDirty("Securitypolicyid");
         }

      }

      public long gxTpr_Defaultroleid
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DefaultRoleId ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DefaultRoleId = value;
            SetDirty("Defaultroleid");
         }

      }

      public DateTime gxTpr_Datelastauthentication
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DateLastAuthentication ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DateLastAuthentication = value;
            SetDirty("Datelastauthentication");
         }

      }

      public bool gxTpr_Isautoregistereduser
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.IsAutoRegisteredUser ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.IsAutoRegisteredUser = value;
            SetDirty("Isautoregistereduser");
         }

      }

      public bool gxTpr_Isdeleted
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.IsDeleted ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.IsDeleted = value;
            SetDirty("Isdeleted");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DateCreated ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.UserCreated ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.DateUpdated ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public bool gxTpr_Isenabledinrepository
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.IsEnabledInRepository ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.IsEnabledInRepository = value;
            SetDirty("Isenabledinrepository");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference.UserUpdated ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GAMUser_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMUserAttribute> gxTpr_Attributes
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GXExternalCollection<SdtGAMUserAttribute> intValue ;
            intValue = new GXExternalCollection<SdtGAMUserAttribute>( context, "SdtGAMUserAttribute", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMUserAttribute> externalParm2 ;
            externalParm2 = GAMUser_externalReference.Attributes;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUserAttribute>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            GXExternalCollection<SdtGAMUserAttribute> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMUserAttribute> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMUserAttribute>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUserAttribute>), intValue.ExternalInstance);
            GAMUser_externalReference.Attributes = externalParm3;
            SetDirty("Attributes");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUser_externalReference == null )
            {
               GAMUser_externalReference = new Artech.Security.GAMUser(context);
            }
            return GAMUser_externalReference ;
         }

         set {
            GAMUser_externalReference = (Artech.Security.GAMUser)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUser GAMUser_externalReference=null ;
   }

}
