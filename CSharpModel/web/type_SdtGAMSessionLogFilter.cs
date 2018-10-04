/*
               File: type_SdtGAMSessionLogFilter
        Description: GAMSessionLogFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.5
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
   public class SdtGAMSessionLogFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionLogFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionLogFilter( IGxContext context )
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
         if ( GAMSessionLogFilter_externalReference == null )
         {
            GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionLogFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionLogFilter_externalReference == null )
         {
            GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionLogFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionLogFilter_externalReference == null )
         {
            GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionLogFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Token
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Token ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public String gxTpr_Userguid
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.UserGUID ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.UserGUID = value;
            SetDirty("Userguid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Name ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public DateTime gxTpr_Datefrom
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.DateFrom ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.DateFrom = value;
            SetDirty("Datefrom");
         }

      }

      public DateTime gxTpr_Dateto
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.DateTo ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.DateTo = value;
            SetDirty("Dateto");
         }

      }

      public String gxTpr_Status
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Status ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public short gxTpr_Type
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Type ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Initialurl
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.InitialURL ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.InitialURL = value;
            SetDirty("Initialurl");
         }

      }

      public String gxTpr_Initialipaddress
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.InitialIPAddress ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.InitialIPAddress = value;
            SetDirty("Initialipaddress");
         }

      }

      public String gxTpr_Initialdeviceid
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.InitialDeviceId ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.InitialDeviceId = value;
            SetDirty("Initialdeviceid");
         }

      }

      public short gxTpr_Browserid
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.BrowserId ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.BrowserId = value;
            SetDirty("Browserid");
         }

      }

      public DateTime gxTpr_Lastaccessfrom
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LastAccessFrom ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LastAccessFrom = value;
            SetDirty("Lastaccessfrom");
         }

      }

      public DateTime gxTpr_Lastaccessto
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LastAccessTo ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LastAccessTo = value;
            SetDirty("Lastaccessto");
         }

      }

      public String gxTpr_Lasturl
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LastURL ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LastURL = value;
            SetDirty("Lasturl");
         }

      }

      public DateTime gxTpr_Logindatefrom
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LoginDateFrom ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LoginDateFrom = value;
            SetDirty("Logindatefrom");
         }

      }

      public DateTime gxTpr_Logindateto
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LoginDateTo ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LoginDateTo = value;
            SetDirty("Logindateto");
         }

      }

      public int gxTpr_Loginretrycount
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LoginRetryCount ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LoginRetryCount = value;
            SetDirty("Loginretrycount");
         }

      }

      public String gxTpr_Anonymous
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Anonymous ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Anonymous = value;
            SetDirty("Anonymous");
         }

      }

      public String gxTpr_Externaltoken
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.ExternalToken ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.ExternalToken = value;
            SetDirty("Externaltoken");
         }

      }

      public DateTime gxTpr_Endedfrom
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.EndedFrom ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.EndedFrom = value;
            SetDirty("Endedfrom");
         }

      }

      public DateTime gxTpr_Endedto
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.EndedTo ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.EndedTo = value;
            SetDirty("Endedto");
         }

      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.ApplicationId ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public String gxTpr_Applicationdata
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.ApplicationData ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.ApplicationData = value;
            SetDirty("Applicationdata");
         }

      }

      public DateTime gxTpr_Tokenexpiresfrom
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.TokenExpiresFrom ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.TokenExpiresFrom = value;
            SetDirty("Tokenexpiresfrom");
         }

      }

      public DateTime gxTpr_Tokenexpiresto
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.TokenExpiresTo ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.TokenExpiresTo = value;
            SetDirty("Tokenexpiresto");
         }

      }

      public String gxTpr_Refreshtoken
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.RefreshToken ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.RefreshToken = value;
            SetDirty("Refreshtoken");
         }

      }

      public bool gxTpr_Loadloginretries
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LoadLoginRetries ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LoadLoginRetries = value;
            SetDirty("Loadloginretries");
         }

      }

      public String gxTpr_Includeloginretrieslog
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.IncludeLoginRetriesLog ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.IncludeLoginRetriesLog = value;
            SetDirty("Includeloginretrieslog");
         }

      }

      public bool gxTpr_Loadfulllog
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.LoadFullLog ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.LoadFullLog = value;
            SetDirty("Loadfulllog");
         }

      }

      public String gxTpr_Includefulllog
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.IncludeFullLog ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.IncludeFullLog = value;
            SetDirty("Includefulllog");
         }

      }

      public String gxTpr_Fulllogtype
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.FullLogType ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.FullLogType = value;
            SetDirty("Fulllogtype");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Start ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference.Limit ;
         }

         set {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            GAMSessionLogFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionLogFilter_externalReference == null )
            {
               GAMSessionLogFilter_externalReference = new Artech.Security.GAMSessionLogFilter(context);
            }
            return GAMSessionLogFilter_externalReference ;
         }

         set {
            GAMSessionLogFilter_externalReference = (Artech.Security.GAMSessionLogFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionLogFilter GAMSessionLogFilter_externalReference=null ;
   }

}
