/*
               File: type_SdtGAMRepository
        Description: GAMRepository
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:57.21
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
   public class SdtGAMRepository : GxUserType, IGxExternalObject
   {
      public SdtGAMRepository( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepository( IGxContext context )
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

      public SdtGAMRepository get( )
      {
         SdtGAMRepository returnget ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnget = new SdtGAMRepository(context);
         Artech.Security.GAMRepository externalParm0 ;
         externalParm0 = GAMRepository_externalReference.Get();
         returnget.ExternalInstance = externalParm0;
         return returnget ;
      }

      public SdtGAMRepository getbyguid( String gxTp_GUID ,
                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRepository returngetbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetbyguid = new SdtGAMRepository(context);
         Artech.Security.GAMRepository externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetByGUID(gxTp_GUID, out externalParm1);
         returngetbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyguid ;
      }

      public int getid( )
      {
         int returngetid ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetid = 0;
         returngetid = (int)(GAMRepository_externalReference.GetId());
         return returngetid ;
      }

      public bool updatefrompackage( SdtGAMUpdateRepositoryConfiguration gxTp_UpdateConfiguration ,
                                     out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdatefrompackage ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnupdatefrompackage = false;
         Artech.Security.GAMUpdateRepositoryConfiguration externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUpdateRepositoryConfiguration)(gxTp_UpdateConfiguration.ExternalInstance);
         returnupdatefrompackage = (bool)(GAMRepository_externalReference.UpdateFromPackage(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdatefrompackage ;
      }

      public bool login( String gxTp_UserName ,
                         String gxTp_Password ,
                         SdtGAMLoginAdditionalParameters gxTp_AdditionalParameters ,
                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnlogin ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnlogin = false;
         Artech.Security.GAMLoginAdditionalParameters externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMLoginAdditionalParameters)(gxTp_AdditionalParameters.ExternalInstance);
         returnlogin = (bool)(GAMRepository_externalReference.Login(gxTp_UserName, gxTp_Password, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnlogin ;
      }

      public void loginfacebook( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.LoginFacebook();
         return  ;
      }

      public void logingoogle( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.LoginGoogle();
         return  ;
      }

      public void logingamremote( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.LoginGAMRemote();
         return  ;
      }

      public void logintwitter( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.LoginTwitter();
         return  ;
      }

      public bool logout( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnlogout ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnlogout = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnlogout = (bool)(GAMRepository_externalReference.Logout(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnlogout ;
      }

      public bool getrememberlogin( out String gxTp_AuthenticationTypeName ,
                                    out String gxTp_UserName ,
                                    out short gxTp_RememberUserType ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returngetrememberlogin ;
         gxTp_AuthenticationTypeName = "";
         gxTp_UserName = "";
         gxTp_RememberUserType = 0;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetrememberlogin = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngetrememberlogin = (bool)(GAMRepository_externalReference.GetRememberLogin(out gxTp_AuthenticationTypeName, out gxTp_UserName, out gxTp_RememberUserType, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetrememberlogin ;
      }

      public GXExternalCollection<SdtGAMAuthenticationTypeSimple> getenabledauthenticationtypes( String gxTp_Language ,
                                                                                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMAuthenticationTypeSimple> returngetenabledauthenticationtypes ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetenabledauthenticationtypes = new GXExternalCollection<SdtGAMAuthenticationTypeSimple>( context, "SdtGAMAuthenticationTypeSimple", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMAuthenticationTypeSimple> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetEnabledAuthenticationTypes(gxTp_Language, out externalParm1);
         returngetenabledauthenticationtypes.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMAuthenticationTypeSimple>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetenabledauthenticationtypes ;
      }

      public bool canauthenticatewith( String gxTp_AuthenticationTypeType )
      {
         bool returncanauthenticatewith ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncanauthenticatewith = false;
         returncanauthenticatewith = (bool)(GAMRepository_externalReference.CanAuthenticateWith(gxTp_AuthenticationTypeType));
         return returncanauthenticatewith ;
      }

      public bool generateconnectionfile( String gxTp_User ,
                                          out String gxTp_TextXML ,
                                          out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returngenerateconnectionfile ;
         gxTp_TextXML = "";
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngenerateconnectionfile = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngenerateconnectionfile = (bool)(GAMRepository_externalReference.GenerateConnectionFile(gxTp_User, out gxTp_TextXML, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngenerateconnectionfile ;
      }

      public bool canregisteruser( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returncanregisteruser ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncanregisteruser = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returncanregisteruser = (bool)(GAMRepository_externalReference.CanRegisterUser(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returncanregisteruser ;
      }

      public GXExternalCollection<SdtGAMError> getlasterrors( )
      {
         GXExternalCollection<SdtGAMError> returngetlasterrors ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetlasterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMRepository_externalReference.GetLastErrors();
         returngetlasterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetlasterrors ;
      }

      public String getlasterrorsurl( )
      {
         String returngetlasterrorsurl ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetlasterrorsurl = "";
         returngetlasterrorsurl = (String)(GAMRepository_externalReference.GetLastErrorsURL());
         return returngetlasterrorsurl ;
      }

      public SdtGAMSecurityPolicy getsecuritypolicy( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMSecurityPolicy returngetsecuritypolicy ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsecuritypolicy = new SdtGAMSecurityPolicy(context);
         Artech.Security.GAMSecurityPolicy externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetSecurityPolicy(out externalParm1);
         returngetsecuritypolicy.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetsecuritypolicy ;
      }

      public GXExternalCollection<SdtGAMUser> getusers( SdtGAMUserFilter gxTp_UserFilter ,
                                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMUser> returngetusers ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetusers = new GXExternalCollection<SdtGAMUser>( context, "SdtGAMUser", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMUser> externalParm0 ;
         Artech.Security.GAMUserFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMUserFilter)(gxTp_UserFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetUsers(externalParm1, out externalParm2);
         returngetusers.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUser>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetusers ;
      }

      public GXExternalCollection<SdtGAMUser> getusersorderby( SdtGAMUserFilter gxTp_UserFilter ,
                                                               short gxTp_Order ,
                                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMUser> returngetusersorderby ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetusersorderby = new GXExternalCollection<SdtGAMUser>( context, "SdtGAMUser", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMUser> externalParm0 ;
         Artech.Security.GAMUserFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMUserFilter)(gxTp_UserFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetUsersOrderBy(externalParm1, gxTp_Order, out externalParm2);
         returngetusersorderby.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMUser>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetusersorderby ;
      }

      public bool activateuser( String gxTp_ActivationKey ,
                                bool gxTp_AuthenticateUser ,
                                out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnactivateuser ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnactivateuser = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnactivateuser = (bool)(GAMRepository_externalReference.ActivateUser(gxTp_ActivationKey, gxTp_AuthenticateUser, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnactivateuser ;
      }

      public SdtGAMUser getuserbykeytocompleteuserdata( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetuserbykeytocompleteuserdata ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetuserbykeytocompleteuserdata = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetUserByKeyToCompleteUserData(out externalParm1);
         returngetuserbykeytocompleteuserdata.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetuserbykeytocompleteuserdata ;
      }

      public bool updateuserbykeytocompleteuserdata( SdtGAMUser gxTp_User ,
                                                     out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdateuserbykeytocompleteuserdata ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnupdateuserbykeytocompleteuserdata = false;
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUser)(gxTp_User.ExternalInstance);
         returnupdateuserbykeytocompleteuserdata = (bool)(GAMRepository_externalReference.UpdateUserByKeyToCompleteUserData(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdateuserbykeytocompleteuserdata ;
      }

      public SdtGAMUser getusertochangepassword( )
      {
         SdtGAMUser returngetusertochangepassword ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetusertochangepassword = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         externalParm0 = GAMRepository_externalReference.GetUserToChangePassword();
         returngetusertochangepassword.ExternalInstance = externalParm0;
         return returngetusertochangepassword ;
      }

      public bool updateusertochangepassword( String gxTp_PasswordOld ,
                                              String gxTp_PasswordNew ,
                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdateusertochangepassword ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnupdateusertochangepassword = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnupdateusertochangepassword = (bool)(GAMRepository_externalReference.UpdateUserToChangePassword(gxTp_PasswordOld, gxTp_PasswordNew, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnupdateusertochangepassword ;
      }

      public SdtGAMUser getuserbyguid( String gxTp_GUID ,
                                       out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetuserbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetuserbyguid = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetUserByGUID(gxTp_GUID, out externalParm1);
         returngetuserbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetuserbyguid ;
      }

      public SdtGAMUser getuserbyexternalid( String gxTp_ExternalId ,
                                             out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetuserbyexternalid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetuserbyexternalid = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetUserByExternalId(gxTp_ExternalId, out externalParm1);
         returngetuserbyexternalid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetuserbyexternalid ;
      }

      public SdtGAMUser getuserbylogin( String gxTp_AuthenticationTypeName ,
                                        String gxTp_UserName ,
                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMUser returngetuserbylogin ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetuserbylogin = new SdtGAMUser(context);
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetUserByLogin(gxTp_AuthenticationTypeName, gxTp_UserName, out externalParm1);
         returngetuserbylogin.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetuserbylogin ;
      }

      public GXExternalCollection<SdtGAMSessionLog> getsessionlogs( SdtGAMSessionLogFilter gxTp_SessionLogFilter ,
                                                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMSessionLog> returngetsessionlogs ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsessionlogs = new GXExternalCollection<SdtGAMSessionLog>( context, "SdtGAMSessionLog", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMSessionLog> externalParm0 ;
         Artech.Security.GAMSessionLogFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMSessionLogFilter)(gxTp_SessionLogFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetSessionLogs(externalParm1, out externalParm2);
         returngetsessionlogs.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLog>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetsessionlogs ;
      }

      public GXExternalCollection<SdtGAMSessionLog> getsessionlogsorderby( SdtGAMSessionLogFilter gxTp_SessionLogFilter ,
                                                                           short gxTp_Order ,
                                                                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMSessionLog> returngetsessionlogsorderby ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsessionlogsorderby = new GXExternalCollection<SdtGAMSessionLog>( context, "SdtGAMSessionLog", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMSessionLog> externalParm0 ;
         Artech.Security.GAMSessionLogFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMSessionLogFilter)(gxTp_SessionLogFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetSessionLogsOrderBy(externalParm1, gxTp_Order, out externalParm2);
         returngetsessionlogsorderby.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLog>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetsessionlogsorderby ;
      }

      public int getactivesessioncount( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         int returngetactivesessioncount ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetactivesessioncount = 0;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngetactivesessioncount = (int)(GAMRepository_externalReference.GetActiveSessionCount(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetactivesessioncount ;
      }

      public GXExternalCollection<SdtGAMRole> getroles( SdtGAMRoleFilter gxTp_RoleFilter ,
                                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         Artech.Security.GAMRoleFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRoleFilter)(gxTp_RoleFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetRoles(externalParm1, out externalParm2);
         returngetroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetroles ;
      }

      public SdtGAMRole getrolebyguid( String gxTp_RoleGUID ,
                                       out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRole returngetrolebyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetrolebyguid = new SdtGAMRole(context);
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetRoleByGUID(gxTp_RoleGUID, out externalParm1);
         returngetrolebyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetrolebyguid ;
      }

      public SdtGAMRole getrolebyexternalid( String gxTp_ExternalId ,
                                             out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMRole returngetrolebyexternalid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetrolebyexternalid = new SdtGAMRole(context);
         Artech.Security.GAMRole externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetRoleByExternalId(gxTp_ExternalId, out externalParm1);
         returngetrolebyexternalid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetrolebyexternalid ;
      }

      public GXExternalCollection<SdtGAMSecurityPolicy> getsecuritypolicies( SdtGAMSecurityPolicyFilter gxTp_SecurityPolicyFilter ,
                                                                             out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMSecurityPolicy> returngetsecuritypolicies ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsecuritypolicies = new GXExternalCollection<SdtGAMSecurityPolicy>( context, "SdtGAMSecurityPolicy", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMSecurityPolicy> externalParm0 ;
         Artech.Security.GAMSecurityPolicyFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMSecurityPolicyFilter)(gxTp_SecurityPolicyFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetSecurityPolicies(externalParm1, out externalParm2);
         returngetsecuritypolicies.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSecurityPolicy>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetsecuritypolicies ;
      }

      public SdtGAMSecurityPolicy getsecuritypolicybyguid( String gxTp_GUID ,
                                                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMSecurityPolicy returngetsecuritypolicybyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsecuritypolicybyguid = new SdtGAMSecurityPolicy(context);
         Artech.Security.GAMSecurityPolicy externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetSecurityPolicyByGUID(gxTp_GUID, out externalParm1);
         returngetsecuritypolicybyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetsecuritypolicybyguid ;
      }

      public GXExternalCollection<SdtGAMAuthenticationType> getauthenticationtypes( SdtGAMAuthenticationTypeFilter gxTp_AuthenticationTypeFilter ,
                                                                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMAuthenticationType> returngetauthenticationtypes ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetauthenticationtypes = new GXExternalCollection<SdtGAMAuthenticationType>( context, "SdtGAMAuthenticationType", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMAuthenticationType> externalParm0 ;
         Artech.Security.GAMAuthenticationTypeFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMAuthenticationTypeFilter)(gxTp_AuthenticationTypeFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetAuthenticationTypes(externalParm1, out externalParm2);
         returngetauthenticationtypes.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMAuthenticationType>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetauthenticationtypes ;
      }

      public GXExternalCollection<SdtGAMRepositoryConnection> getconnections( SdtGAMRepositoryConnectionFilter gxTp_RepositoryConnectionFilter ,
                                                                              out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRepositoryConnection> returngetconnections ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetconnections = new GXExternalCollection<SdtGAMRepositoryConnection>( context, "SdtGAMRepositoryConnection", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRepositoryConnection> externalParm0 ;
         Artech.Security.GAMRepositoryConnectionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRepositoryConnectionFilter)(gxTp_RepositoryConnectionFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetConnections(externalParm1, out externalParm2);
         returngetconnections.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRepositoryConnection>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetconnections ;
      }

      public GXExternalCollection<SdtGAMApplication> getapplications( SdtGAMApplicationFilter gxTp_ApplicationFilter ,
                                                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMApplication> returngetapplications ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetapplications = new GXExternalCollection<SdtGAMApplication>( context, "SdtGAMApplication", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMApplication> externalParm0 ;
         Artech.Security.GAMApplicationFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMApplicationFilter)(gxTp_ApplicationFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetApplications(externalParm1, out externalParm2);
         returngetapplications.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplication>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetapplications ;
      }

      public SdtGAMApplication getapplicationbyguid( String gxTp_GUID ,
                                                     out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplication returngetapplicationbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetapplicationbyguid = new SdtGAMApplication(context);
         Artech.Security.GAMApplication externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetApplicationByGUID(gxTp_GUID, out externalParm1);
         returngetapplicationbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetapplicationbyguid ;
      }

      public SdtGAMMenuOptionList getapplicationmenu( String gxTp_ApplicationGUID ,
                                                      String gxTp_MenuGUID ,
                                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMMenuOptionList returngetapplicationmenu ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetapplicationmenu = new SdtGAMMenuOptionList(context);
         Artech.Security.GAMMenuOptionList externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetApplicationMenu(gxTp_ApplicationGUID, gxTp_MenuGUID, out externalParm1);
         returngetapplicationmenu.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetapplicationmenu ;
      }

      public bool validaccesstoken( String gxTp_AccessToken ,
                                    out SdtGAMSession gxTp_Session ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnvalidaccesstoken ;
         gxTp_Session = new SdtGAMSession(context);
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnvalidaccesstoken = false;
         Artech.Security.GAMSession externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         returnvalidaccesstoken = (bool)(GAMRepository_externalReference.ValidAccessToken(gxTp_AccessToken, out externalParm0, out externalParm1));
         gxTp_Session.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnvalidaccesstoken ;
      }

      public bool checkpermission( String gxTp_PermissionName )
      {
         bool returncheckpermission ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncheckpermission = false;
         returncheckpermission = (bool)(GAMRepository_externalReference.CheckPermission(gxTp_PermissionName));
         return returncheckpermission ;
      }

      public bool checkrole( String gxTp_RoleName )
      {
         bool returncheckrole ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncheckrole = false;
         returncheckrole = (bool)(GAMRepository_externalReference.CheckRole(gxTp_RoleName));
         return returncheckrole ;
      }

      public bool checkrolebyid( long gxTp_RoleId )
      {
         bool returncheckrolebyid ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncheckrolebyid = false;
         returncheckrolebyid = (bool)(GAMRepository_externalReference.CheckRoleById(gxTp_RoleId));
         return returncheckrolebyid ;
      }

      public bool checkrolebyguid( String gxTp_GUID )
      {
         bool returncheckrolebyguid ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncheckrolebyguid = false;
         returncheckrolebyguid = (bool)(GAMRepository_externalReference.CheckRoleByGUID(gxTp_GUID));
         return returncheckrolebyguid ;
      }

      public bool checkrolebyexternalid( String gxTp_ExternalId )
      {
         bool returncheckrolebyexternalid ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returncheckrolebyexternalid = false;
         returncheckrolebyexternalid = (bool)(GAMRepository_externalReference.CheckRoleByExternalId(gxTp_ExternalId));
         return returncheckrolebyexternalid ;
      }

      public bool isgamadministrator( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnisgamadministrator ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnisgamadministrator = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnisgamadministrator = (bool)(GAMRepository_externalReference.IsGAMAdministrator(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnisgamadministrator ;
      }

      public void clearcache( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.ClearCache();
         return  ;
      }

      public bool isremoteauthentication( String gxTp_ClientId )
      {
         bool returnisremoteauthentication ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnisremoteauthentication = false;
         returnisremoteauthentication = (bool)(GAMRepository_externalReference.IsRemoteAuthentication(gxTp_ClientId));
         return returnisremoteauthentication ;
      }

      public void inputexternalauthentication( String gxTp_Response )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.InputExternalAuthentication(gxTp_Response);
         return  ;
      }

      public SdtGAMApplication getremoteapplication( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMApplication returngetremoteapplication ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetremoteapplication = new SdtGAMApplication(context);
         Artech.Security.GAMApplication externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMRepository_externalReference.GetRemoteApplication(out externalParm1);
         returngetremoteapplication.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetremoteapplication ;
      }

      public void redirecttoremoteauthentication( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.RedirectToRemoteAuthentication();
         return  ;
      }

      public GXExternalCollection<SdtGAMEventSubscription> geteventsubscriptions( SdtGAMEventSubscriptionFilter gxTp_EventSubscriptionFilter ,
                                                                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMEventSubscription> returngeteventsubscriptions ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngeteventsubscriptions = new GXExternalCollection<SdtGAMEventSubscription>( context, "SdtGAMEventSubscription", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMEventSubscription> externalParm0 ;
         Artech.Security.GAMEventSubscriptionFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMEventSubscriptionFilter)(gxTp_EventSubscriptionFilter.ExternalInstance);
         externalParm0 = GAMRepository_externalReference.GetEventSubscriptions(externalParm1, out externalParm2);
         returngeteventsubscriptions.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMEventSubscription>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngeteventsubscriptions ;
      }

      public bool subscribeevent( String gxTp_EventId ,
                                  out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsubscribeevent ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnsubscribeevent = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsubscribeevent = (bool)(GAMRepository_externalReference.SubscribeEvent(gxTp_EventId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsubscribeevent ;
      }

      public bool unsubscribeevent( String gxTp_EventId ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnunsubscribeevent ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnunsubscribeevent = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnunsubscribeevent = (bool)(GAMRepository_externalReference.UnsubscribeEvent(gxTp_EventId, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnunsubscribeevent ;
      }

      public void applicationgohome( String gxTp_ApplicationGUID )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.ApplicationGoHome(gxTp_ApplicationGUID);
         return  ;
      }

      public bool setdefaultauthenticationtypeaslocal( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetdefaultauthenticationtypeaslocal ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnsetdefaultauthenticationtypeaslocal = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetdefaultauthenticationtypeaslocal = (bool)(GAMRepository_externalReference.SetDefaultAuthenticationTypeAsLocal(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetdefaultauthenticationtypeaslocal ;
      }

      public int getuserscount( SdtGAMUsersCountFilter gxTp_UsersCountFilter )
      {
         int returngetuserscount ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetuserscount = 0;
         Artech.Security.GAMUsersCountFilter externalParm0 ;
         externalParm0 = (Artech.Security.GAMUsersCountFilter)(gxTp_UsersCountFilter.ExternalInstance);
         returngetuserscount = (int)(GAMRepository_externalReference.GetUsersCount(externalParm0));
         return returngetuserscount ;
      }

      public int getsessionscount( SdtGAMSessionsCountFilter gxTp_SessionsCountFilter )
      {
         int returngetsessionscount ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetsessionscount = 0;
         Artech.Security.GAMSessionsCountFilter externalParm0 ;
         externalParm0 = (Artech.Security.GAMSessionsCountFilter)(gxTp_SessionsCountFilter.ExternalInstance);
         returngetsessionscount = (int)(GAMRepository_externalReference.GetSessionsCount(externalParm0));
         return returngetsessionscount ;
      }

      public int getrolescount( )
      {
         int returngetrolescount ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetrolescount = 0;
         returngetrolescount = (int)(GAMRepository_externalReference.GetRolesCount());
         return returngetrolescount ;
      }

      public int getrolerolescount( long gxTp_RoleId )
      {
         int returngetrolerolescount ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngetrolerolescount = 0;
         returngetrolerolescount = (int)(GAMRepository_externalReference.GetRoleRolesCount(gxTp_RoleId));
         return returngetrolerolescount ;
      }

      public void load( int gxTp_Id )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.Load(gxTp_Id);
         return  ;
      }

      public void save( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         GAMRepository_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMRepository_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMRepository_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMRepository_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepository_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepository_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepository_externalReference == null )
         {
            GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepository_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Id
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.Id ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GUID ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Namespace
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.NameSpace ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.NameSpace = value;
            SetDirty("Namespace");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.Name ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.Description ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Defaultauthenticationtypename
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.DefaultAuthenticationTypeName ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.DefaultAuthenticationTypeName = value;
            SetDirty("Defaultauthenticationtypename");
         }

      }

      public String gxTpr_Useridentification
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserIdentification ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserIdentification = value;
            SetDirty("Useridentification");
         }

      }

      public bool gxTpr_Useremailisunique
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserEmailisUnique ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserEmailisUnique = value;
            SetDirty("Useremailisunique");
         }

      }

      public bool gxTpr_Allowoauthaccess
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.AllowOauthAccess ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.AllowOauthAccess = value;
            SetDirty("Allowoauthaccess");
         }

      }

      public bool gxTpr_Canregisterusers
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.CanRegisterUsers ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.CanRegisterUsers = value;
            SetDirty("Canregisterusers");
         }

      }

      public String gxTpr_Generateauditory
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GenerateAuditory ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GenerateAuditory = value;
            SetDirty("Generateauditory");
         }

      }

      public String gxTpr_Generatesessionstatistics
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GenerateSessionStatistics ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GenerateSessionStatistics = value;
            SetDirty("Generatesessionstatistics");
         }

      }

      public String gxTpr_Useractivationmethod
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserActivationMethod ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserActivationMethod = value;
            SetDirty("Useractivationmethod");
         }

      }

      public short gxTpr_Userautomaticactivationtimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserAutomaticActivationTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserAutomaticActivationTimeout = value;
            SetDirty("Userautomaticactivationtimeout");
         }

      }

      public bool gxTpr_Sessionexpiresonipchange
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.SessionExpiresOnIPChange ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.SessionExpiresOnIPChange = value;
            SetDirty("Sessionexpiresonipchange");
         }

      }

      public String gxTpr_Userremembermetype
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserRememberMeType ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserRememberMeType = value;
            SetDirty("Userremembermetype");
         }

      }

      public short gxTpr_Userremembermetimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserRememberMeTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserRememberMeTimeout = value;
            SetDirty("Userremembermetimeout");
         }

      }

      public short gxTpr_Userrecoverypasswordkeytimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserRecoveryPasswordKeyTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserRecoveryPasswordKeyTimeout = value;
            SetDirty("Userrecoverypasswordkeytimeout");
         }

      }

      public short gxTpr_Minimumamountcharactersinlogin
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.MinimumAmountCharactersInLogin ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.MinimumAmountCharactersInLogin = value;
            SetDirty("Minimumamountcharactersinlogin");
         }

      }

      public short gxTpr_Loginattemptstolockuser
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.LoginAttemptsToLockUser ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.LoginAttemptsToLockUser = value;
            SetDirty("Loginattemptstolockuser");
         }

      }

      public short gxTpr_Gamunblockusertimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GAMUnblockUserTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GAMUnblockUserTimeout = value;
            SetDirty("Gamunblockusertimeout");
         }

      }

      public short gxTpr_Loginattemptstolocksession
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.LoginAttemptsToLockSession ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.LoginAttemptsToLockSession = value;
            SetDirty("Loginattemptstolocksession");
         }

      }

      public int gxTpr_Usersessioncachetimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserSessionCacheTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserSessionCacheTimeout = value;
            SetDirty("Usersessioncachetimeout");
         }

      }

      public int gxTpr_Cachetimeout
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.CacheTimeout ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.CacheTimeout = value;
            SetDirty("Cachetimeout");
         }

      }

      public String gxTpr_Securityadministratoremail
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.SecurityAdministratorEmail ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.SecurityAdministratorEmail = value;
            SetDirty("Securityadministratoremail");
         }

      }

      public bool gxTpr_Giveanonymoussession
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GiveAnonymousSession ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GiveAnonymousSession = value;
            SetDirty("Giveanonymoussession");
         }

      }

      public String gxTpr_Anonymoususerguid
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.AnonymousUserGUID ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.AnonymousUserGUID = value;
            SetDirty("Anonymoususerguid");
         }

      }

      public long gxTpr_Defaultroleid
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.DefaultRoleId ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.DefaultRoleId = value;
            SetDirty("Defaultroleid");
         }

      }

      public int gxTpr_Defaultsecuritypolicyid
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.DefaultSecurityPolicyId ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.DefaultSecurityPolicyId = value;
            SetDirty("Defaultsecuritypolicyid");
         }

      }

      public short gxTpr_Enabletracing
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.EnableTracing ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.EnableTracing = value;
            SetDirty("Enabletracing");
         }

      }

      public bool gxTpr_Canbedeletedbyanyuser
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.CanBeDeletedByAnyUser ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.CanBeDeletedByAnyUser = value;
            SetDirty("Canbedeletedbyanyuser");
         }

      }

      public bool gxTpr_Requiredpassword
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredPassword ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredPassword = value;
            SetDirty("Requiredpassword");
         }

      }

      public bool gxTpr_Requiredemail
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredEmail ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredEmail = value;
            SetDirty("Requiredemail");
         }

      }

      public bool gxTpr_Requiredfirstname
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredFirstName ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredFirstName = value;
            SetDirty("Requiredfirstname");
         }

      }

      public bool gxTpr_Requiredlastname
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredLastName ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredLastName = value;
            SetDirty("Requiredlastname");
         }

      }

      public bool gxTpr_Requiredbirthday
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredBirthday ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredBirthday = value;
            SetDirty("Requiredbirthday");
         }

      }

      public bool gxTpr_Requiredgender
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredGender ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredGender = value;
            SetDirty("Requiredgender");
         }

      }

      public bool gxTpr_Requiredphone
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredPhone ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredPhone = value;
            SetDirty("Requiredphone");
         }

      }

      public bool gxTpr_Requiredaddress
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredAddress ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredAddress = value;
            SetDirty("Requiredaddress");
         }

      }

      public bool gxTpr_Requiredcity
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredCity ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredCity = value;
            SetDirty("Requiredcity");
         }

      }

      public bool gxTpr_Requiredstate
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredState ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredState = value;
            SetDirty("Requiredstate");
         }

      }

      public bool gxTpr_Requiredpostcode
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredPostCode ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredPostCode = value;
            SetDirty("Requiredpostcode");
         }

      }

      public bool gxTpr_Requiredcountry
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredCountry ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredCountry = value;
            SetDirty("Requiredcountry");
         }

      }

      public bool gxTpr_Requiredlanguage
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredLanguage ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredLanguage = value;
            SetDirty("Requiredlanguage");
         }

      }

      public bool gxTpr_Requiredtimezone
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredTimeZone ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredTimeZone = value;
            SetDirty("Requiredtimezone");
         }

      }

      public bool gxTpr_Requiredphoto
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.RequiredPhoto ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.RequiredPhoto = value;
            SetDirty("Requiredphoto");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.DateCreated ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserCreated ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.DateUpdated ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.UserUpdated ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMRepository_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMRepository_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMRepository_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMRepository_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public String gxTpr_Gamremotelogoutbehavior
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference.GAMRemoteLogoutBehavior ;
         }

         set {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            GAMRepository_externalReference.GAMRemoteLogoutBehavior = value;
            SetDirty("Gamremotelogoutbehavior");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepository_externalReference == null )
            {
               GAMRepository_externalReference = new Artech.Security.GAMRepository(context);
            }
            return GAMRepository_externalReference ;
         }

         set {
            GAMRepository_externalReference = (Artech.Security.GAMRepository)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepository GAMRepository_externalReference=null ;
   }

}
