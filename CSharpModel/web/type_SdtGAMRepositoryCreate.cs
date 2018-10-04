/*
               File: type_SdtGAMRepositoryCreate
        Description: GAMRepositoryCreate
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.50
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
   public class SdtGAMRepositoryCreate : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryCreate( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryCreate( IGxContext context )
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
         if ( GAMRepositoryCreate_externalReference == null )
         {
            GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryCreate_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryCreate_externalReference == null )
         {
            GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryCreate_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryCreate_externalReference == null )
         {
            GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryCreate_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.GUID ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Namespace
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.NameSpace ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.NameSpace = value;
            SetDirty("Namespace");
         }

      }

      public bool gxTpr_Canregisterusers
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CanRegisterUsers ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CanRegisterUsers = value;
            SetDirty("Canregisterusers");
         }

      }

      public bool gxTpr_Allowoauthaccess
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.AllowOauthAccess ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.AllowOauthAccess = value;
            SetDirty("Allowoauthaccess");
         }

      }

      public bool gxTpr_Giveanonymoussession
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.GiveAnonymousSession ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.GiveAnonymousSession = value;
            SetDirty("Giveanonymoussession");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.Name ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.Description ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Administratorusername
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.AdministratorUserName ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.AdministratorUserName = value;
            SetDirty("Administratorusername");
         }

      }

      public String gxTpr_Administratoruserpassword
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.AdministratorUserPassword ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.AdministratorUserPassword = value;
            SetDirty("Administratoruserpassword");
         }

      }

      public String gxTpr_Connectionusername
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.ConnectionUserName ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.ConnectionUserName = value;
            SetDirty("Connectionusername");
         }

      }

      public String gxTpr_Connectionuserpassword
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.ConnectionUserPassword ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.ConnectionUserPassword = value;
            SetDirty("Connectionuserpassword");
         }

      }

      public bool gxTpr_Allowuseexistingnamespace
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.AllowUseExistingNamespace ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.AllowUseExistingNamespace = value;
            SetDirty("Allowuseexistingnamespace");
         }

      }

      public String gxTpr_Generatesessionstatistics
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.GenerateSessionStatistics ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.GenerateSessionStatistics = value;
            SetDirty("Generatesessionstatistics");
         }

      }

      public String gxTpr_Useractivationmethod
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserActivationMethod ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserActivationMethod = value;
            SetDirty("Useractivationmethod");
         }

      }

      public String gxTpr_Userremembermetype
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserRememberMeType ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserRememberMeType = value;
            SetDirty("Userremembermetype");
         }

      }

      public short gxTpr_Userremembermetimeout
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserRememberMeTimeout ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserRememberMeTimeout = value;
            SetDirty("Userremembermetimeout");
         }

      }

      public String gxTpr_Useridentification
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserIdentification ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserIdentification = value;
            SetDirty("Useridentification");
         }

      }

      public int gxTpr_Usersessioncachetimeout
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserSessionCacheTimeout ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserSessionCacheTimeout = value;
            SetDirty("Usersessioncachetimeout");
         }

      }

      public short gxTpr_Minimumamountcharactersinlogin
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.MinimumAmountCharactersInLogin ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.MinimumAmountCharactersInLogin = value;
            SetDirty("Minimumamountcharactersinlogin");
         }

      }

      public short gxTpr_Loginattemptstolockuser
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.LoginAttemptsToLockUser ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.LoginAttemptsToLockUser = value;
            SetDirty("Loginattemptstolockuser");
         }

      }

      public short gxTpr_Loginattemptstolocksession
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.LoginAttemptsToLockSession ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.LoginAttemptsToLockSession = value;
            SetDirty("Loginattemptstolocksession");
         }

      }

      public short gxTpr_Gamunblockusertimeout
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.GAMUnblockUserTimeout ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.GAMUnblockUserTimeout = value;
            SetDirty("Gamunblockusertimeout");
         }

      }

      public short gxTpr_Userautomaticactivationtimeout
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.UserAutomaticActivationTimeout ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.UserAutomaticActivationTimeout = value;
            SetDirty("Userautomaticactivationtimeout");
         }

      }

      public bool gxTpr_Creategamapplication
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CreateGAMApplication ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CreateGAMApplication = value;
            SetDirty("Creategamapplication");
         }

      }

      public SdtGAMApplication gxTpr_Application
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            SdtGAMApplication intValue ;
            intValue = new SdtGAMApplication(context);
            Artech.Security.GAMApplication externalParm0 ;
            externalParm0 = GAMRepositoryCreate_externalReference.Application;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            SdtGAMApplication intValue ;
            Artech.Security.GAMApplication externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMApplication)(intValue.ExternalInstance);
            GAMRepositoryCreate_externalReference.Application = externalParm1;
            SetDirty("Application");
         }

      }

      public int gxTpr_Copyfromrepositoryid
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopyFromRepositoryId ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopyFromRepositoryId = value;
            SetDirty("Copyfromrepositoryid");
         }

      }

      public bool gxTpr_Copyroles
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopyRoles ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopyRoles = value;
            SetDirty("Copyroles");
         }

      }

      public long gxTpr_Administratorroleid
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.AdministratorRoleId ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.AdministratorRoleId = value;
            SetDirty("Administratorroleid");
         }

      }

      public bool gxTpr_Copysecuritypolicies
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopySecurityPolicies ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopySecurityPolicies = value;
            SetDirty("Copysecuritypolicies");
         }

      }

      public bool gxTpr_Copyapplication
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopyApplication ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopyApplication = value;
            SetDirty("Copyapplication");
         }

      }

      public long gxTpr_Copyfromapplicationid
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopyFromApplicationId ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopyFromApplicationId = value;
            SetDirty("Copyfromapplicationid");
         }

      }

      public bool gxTpr_Copyapplicationrolepermissions
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference.CopyApplicationRolePermissions ;
         }

         set {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            GAMRepositoryCreate_externalReference.CopyApplicationRolePermissions = value;
            SetDirty("Copyapplicationrolepermissions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryCreate_externalReference == null )
            {
               GAMRepositoryCreate_externalReference = new Artech.Security.GAMRepositoryCreate(context);
            }
            return GAMRepositoryCreate_externalReference ;
         }

         set {
            GAMRepositoryCreate_externalReference = (Artech.Security.GAMRepositoryCreate)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryCreate GAMRepositoryCreate_externalReference=null ;
   }

}
