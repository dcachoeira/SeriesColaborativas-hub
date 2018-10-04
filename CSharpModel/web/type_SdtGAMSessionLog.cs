/*
               File: type_SdtGAMSessionLog
        Description: GAMSessionLog
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:22.61
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
   public class SdtGAMSessionLog : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionLog( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionLog( IGxContext context )
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

      public bool killsession( String gxTp_Token ,
                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnkillsession ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSessionLog_externalReference == null )
         {
            GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
         }
         returnkillsession = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnkillsession = (bool)(GAMSessionLog_externalReference.KillSession(gxTp_Token, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnkillsession ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMSessionLog_externalReference == null )
         {
            GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionLog_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionLog_externalReference == null )
         {
            GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionLog_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionLog_externalReference == null )
         {
            GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionLog_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Token
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Token ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public SdtGAMUser gxTpr_User
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            SdtGAMUser intValue ;
            intValue = new SdtGAMUser(context);
            Artech.Security.GAMUser externalParm0 ;
            externalParm0 = GAMSessionLog_externalReference.User;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            SdtGAMUser intValue ;
            Artech.Security.GAMUser externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMUser)(intValue.ExternalInstance);
            GAMSessionLog_externalReference.User = externalParm1;
            SetDirty("User");
         }

      }

      public DateTime gxTpr_Date
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Date ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Date = value;
            SetDirty("Date");
         }

      }

      public String gxTpr_Status
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Status ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Type ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Initialurl
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.InitialURL ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.InitialURL = value;
            SetDirty("Initialurl");
         }

      }

      public String gxTpr_Initialipaddress
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.InitialIPAddress ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.InitialIPAddress = value;
            SetDirty("Initialipaddress");
         }

      }

      public String gxTpr_Initialdeviceid
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.InitialDeviceId ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.InitialDeviceId = value;
            SetDirty("Initialdeviceid");
         }

      }

      public short gxTpr_Browserid
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.BrowserId ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.BrowserId = value;
            SetDirty("Browserid");
         }

      }

      public short gxTpr_Operatingsystemid
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.OperatingSystemId ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.OperatingSystemId = value;
            SetDirty("Operatingsystemid");
         }

      }

      public DateTime gxTpr_Lastaccess
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.LastAccess ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.LastAccess = value;
            SetDirty("Lastaccess");
         }

      }

      public String gxTpr_Lasturl
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.LastURL ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.LastURL = value;
            SetDirty("Lasturl");
         }

      }

      public DateTime gxTpr_Logindate
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.LoginDate ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.LoginDate = value;
            SetDirty("Logindate");
         }

      }

      public int gxTpr_Loginretrycount
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.LoginRetryCount ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.LoginRetryCount = value;
            SetDirty("Loginretrycount");
         }

      }

      public bool gxTpr_Isanonymous
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.IsAnonymous ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.IsAnonymous = value;
            SetDirty("Isanonymous");
         }

      }

      public String gxTpr_Externaltoken
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.ExternalToken ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.ExternalToken = value;
            SetDirty("Externaltoken");
         }

      }

      public DateTime gxTpr_Ended
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Ended ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Ended = value;
            SetDirty("Ended");
         }

      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.ApplicationId ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public String gxTpr_Applicationdata
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.ApplicationData ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.ApplicationData = value;
            SetDirty("Applicationdata");
         }

      }

      public String gxTpr_Authenticatedlogin
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.AuthenticatedLogin ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.AuthenticatedLogin = value;
            SetDirty("Authenticatedlogin");
         }

      }

      public short gxTpr_Timeout
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Timeout ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Timeout = value;
            SetDirty("Timeout");
         }

      }

      public DateTime gxTpr_Tokenexpires
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.TokenExpires ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.TokenExpires = value;
            SetDirty("Tokenexpires");
         }

      }

      public String gxTpr_Refreshtoken
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.RefreshToken ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.RefreshToken = value;
            SetDirty("Refreshtoken");
         }

      }

      public short gxTpr_Tokenmaximumrenovations
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.TokenMaximumRenovations ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.TokenMaximumRenovations = value;
            SetDirty("Tokenmaximumrenovations");
         }

      }

      public String gxTpr_Scope
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference.Scope ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GAMSessionLog_externalReference.Scope = value;
            SetDirty("Scope");
         }

      }

      public GXExternalCollection<SdtGAMSessionLogLoginRetry> gxTpr_Loginretries
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GXExternalCollection<SdtGAMSessionLogLoginRetry> intValue ;
            intValue = new GXExternalCollection<SdtGAMSessionLogLoginRetry>( context, "SdtGAMSessionLogLoginRetry", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMSessionLogLoginRetry> externalParm2 ;
            externalParm2 = GAMSessionLog_externalReference.LoginRetries;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLogLoginRetry>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GXExternalCollection<SdtGAMSessionLogLoginRetry> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMSessionLogLoginRetry> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMSessionLogLoginRetry>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionLogLoginRetry>), intValue.ExternalInstance);
            GAMSessionLog_externalReference.LoginRetries = externalParm3;
            SetDirty("Loginretries");
         }

      }

      public GXExternalCollection<SdtGAMSessionFullLog> gxTpr_Fulllog
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GXExternalCollection<SdtGAMSessionFullLog> intValue ;
            intValue = new GXExternalCollection<SdtGAMSessionFullLog>( context, "SdtGAMSessionFullLog", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMSessionFullLog> externalParm4 ;
            externalParm4 = GAMSessionLog_externalReference.FullLog;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionFullLog>), externalParm4);
            return intValue ;
         }

         set {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            GXExternalCollection<SdtGAMSessionFullLog> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMSessionFullLog> externalParm5 ;
            intValue = value;
            externalParm5 = (System.Collections.Generic.List<Artech.Security.GAMSessionFullLog>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMSessionFullLog>), intValue.ExternalInstance);
            GAMSessionLog_externalReference.FullLog = externalParm5;
            SetDirty("Fulllog");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionLog_externalReference == null )
            {
               GAMSessionLog_externalReference = new Artech.Security.GAMSessionLog(context);
            }
            return GAMSessionLog_externalReference ;
         }

         set {
            GAMSessionLog_externalReference = (Artech.Security.GAMSessionLog)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionLog GAMSessionLog_externalReference=null ;
   }

}
