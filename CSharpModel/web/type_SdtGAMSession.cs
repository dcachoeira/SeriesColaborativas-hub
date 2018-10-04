/*
               File: type_SdtGAMSession
        Description: GAMSession
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:21.74
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
   public class SdtGAMSession : GxUserType, IGxExternalObject
   {
      public SdtGAMSession( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSession( IGxContext context )
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

      public SdtGAMSession get( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMSession returnget ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returnget = new SdtGAMSession(context);
         Artech.Security.GAMSession externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMSession_externalReference.Get(out externalParm1);
         returnget.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnget ;
      }

      public String gettoken( )
      {
         String returngettoken ;
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returngettoken = "";
         returngettoken = (String)(GAMSession_externalReference.GetToken());
         return returngettoken ;
      }

      public bool isvalid( out SdtGAMSession gxTp_Session ,
                           out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnisvalid ;
         gxTp_Session = new SdtGAMSession(context);
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returnisvalid = false;
         Artech.Security.GAMSession externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         returnisvalid = (bool)(GAMSession_externalReference.IsValid(out externalParm0, out externalParm1));
         gxTp_Session.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnisvalid ;
      }

      public bool isanonymoususer( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnisanonymoususer ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returnisanonymoususer = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnisanonymoususer = (bool)(GAMSession_externalReference.IsAnonymousUser(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnisanonymoususer ;
      }

      public GXExternalCollection<SdtGAMRole> getroles( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRole> returngetroles ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returngetroles = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRole> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMSession_externalReference.GetRoles(out externalParm1);
         returngetroles.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRole>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetroles ;
      }

      public bool setapplicationdata( String gxTp_ApplicationData ,
                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetapplicationdata ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returnsetapplicationdata = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetapplicationdata = (bool)(GAMSession_externalReference.SetApplicationData((string)(gxTp_ApplicationData), out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetapplicationdata ;
      }

      public String getapplicationdata( )
      {
         String returngetapplicationdata ;
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returngetapplicationdata = "";
         returngetapplicationdata = (String)(GAMSession_externalReference.GetApplicationData());
         return returngetapplicationdata ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSession_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSession_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSession_externalReference == null )
         {
            GAMSession_externalReference = new Artech.Security.GAMSession(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSession_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Token
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Token ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public SdtGAMUser gxTpr_User
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            SdtGAMUser intValue ;
            intValue = new SdtGAMUser(context);
            Artech.Security.GAMUser externalParm0 ;
            externalParm0 = GAMSession_externalReference.User;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            SdtGAMUser intValue ;
            Artech.Security.GAMUser externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMUser)(intValue.ExternalInstance);
            GAMSession_externalReference.User = externalParm1;
            SetDirty("User");
         }

      }

      public DateTime gxTpr_Date
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Date ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Date = value;
            SetDirty("Date");
         }

      }

      public String gxTpr_Status
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Status ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Type ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Initialurl
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.InitialURL ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.InitialURL = value;
            SetDirty("Initialurl");
         }

      }

      public String gxTpr_Initialipaddress
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.InitialIPAddress ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.InitialIPAddress = value;
            SetDirty("Initialipaddress");
         }

      }

      public String gxTpr_Initialdeviceid
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.InitialDeviceId ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.InitialDeviceId = value;
            SetDirty("Initialdeviceid");
         }

      }

      public short gxTpr_Browserid
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.BrowserId ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.BrowserId = value;
            SetDirty("Browserid");
         }

      }

      public short gxTpr_Operatingsystemid
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.OperatingSystemId ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.OperatingSystemId = value;
            SetDirty("Operatingsystemid");
         }

      }

      public DateTime gxTpr_Lastaccess
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.LastAccess ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.LastAccess = value;
            SetDirty("Lastaccess");
         }

      }

      public String gxTpr_Lasturl
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.LastURL ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.LastURL = value;
            SetDirty("Lasturl");
         }

      }

      public SdtGAMSecurityPolicy gxTpr_Securitypolicy
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            SdtGAMSecurityPolicy intValue ;
            intValue = new SdtGAMSecurityPolicy(context);
            Artech.Security.GAMSecurityPolicy externalParm2 ;
            externalParm2 = GAMSession_externalReference.SecurityPolicy;
            intValue.ExternalInstance = externalParm2;
            return intValue ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            SdtGAMSecurityPolicy intValue ;
            Artech.Security.GAMSecurityPolicy externalParm3 ;
            intValue = value;
            externalParm3 = (Artech.Security.GAMSecurityPolicy)(intValue.ExternalInstance);
            GAMSession_externalReference.SecurityPolicy = externalParm3;
            SetDirty("Securitypolicy");
         }

      }

      public DateTime gxTpr_Logindate
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.LoginDate ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.LoginDate = value;
            SetDirty("Logindate");
         }

      }

      public String gxTpr_Authenticationtypename
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.AuthenticationTypeName ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.AuthenticationTypeName = value;
            SetDirty("Authenticationtypename");
         }

      }

      public int gxTpr_Loginretrycount
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.LoginRetryCount ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.LoginRetryCount = value;
            SetDirty("Loginretrycount");
         }

      }

      public bool gxTpr_Isanonymous
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.IsAnonymous ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.IsAnonymous = value;
            SetDirty("Isanonymous");
         }

      }

      public String gxTpr_Externaltoken
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.ExternalToken ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.ExternalToken = value;
            SetDirty("Externaltoken");
         }

      }

      public bool gxTpr_Isended
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.IsEnded ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.IsEnded = value;
            SetDirty("Isended");
         }

      }

      public DateTime gxTpr_Ended
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Ended ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Ended = value;
            SetDirty("Ended");
         }

      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.ApplicationId ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public DateTime gxTpr_Expires
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Expires ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Expires = value;
            SetDirty("Expires");
         }

      }

      public String gxTpr_Refreshtoken
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.RefreshToken ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.RefreshToken = value;
            SetDirty("Refreshtoken");
         }

      }

      public String gxTpr_Permissiontoken
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.PermissionToken ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.PermissionToken = value;
            SetDirty("Permissiontoken");
         }

      }

      public GXExternalCollection<SdtGAMSessionLoginRetry> gxTpr_Loginretries
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GXExternalCollection<SdtGAMSessionLoginRetry> intValue ;
            intValue = new GXExternalCollection<SdtGAMSessionLoginRetry>( context, "SdtGAMSessionLoginRetry", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMSessionLoginRetry> externalParm4 ;
            externalParm4 = GAMSession_externalReference.LoginRetries;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLoginRetry>), externalParm4);
            return intValue ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GXExternalCollection<SdtGAMSessionLoginRetry> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMSessionLoginRetry> externalParm5 ;
            intValue = value;
            externalParm5 = (System.Collections.Generic.List<Artech.Security.GAMSessionLoginRetry>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLoginRetry>), intValue.ExternalInstance);
            GAMSession_externalReference.LoginRetries = externalParm5;
            SetDirty("Loginretries");
         }

      }

      public DateTime gxTpr_Lastaccessdb
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.LastAccessDB ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.LastAccessDB = value;
            SetDirty("Lastaccessdb");
         }

      }

      public bool gxTpr_Sessionindb
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.SessionInDB ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.SessionInDB = value;
            SetDirty("Sessionindb");
         }

      }

      public GXExternalCollection<SdtGAMSessionRole> gxTpr_Roles
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GXExternalCollection<SdtGAMSessionRole> intValue ;
            intValue = new GXExternalCollection<SdtGAMSessionRole>( context, "SdtGAMSessionRole", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMSessionRole> externalParm6 ;
            externalParm6 = GAMSession_externalReference.Roles;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionRole>), externalParm6);
            return intValue ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GXExternalCollection<SdtGAMSessionRole> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMSessionRole> externalParm7 ;
            intValue = value;
            externalParm7 = (System.Collections.Generic.List<Artech.Security.GAMSessionRole>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionRole>), intValue.ExternalInstance);
            GAMSession_externalReference.Roles = externalParm7;
            SetDirty("Roles");
         }

      }

      public String gxTpr_Scope
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference.Scope ;
         }

         set {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            GAMSession_externalReference.Scope = value;
            SetDirty("Scope");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSession_externalReference == null )
            {
               GAMSession_externalReference = new Artech.Security.GAMSession(context);
            }
            return GAMSession_externalReference ;
         }

         set {
            GAMSession_externalReference = (Artech.Security.GAMSession)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSession GAMSession_externalReference=null ;
   }

}
