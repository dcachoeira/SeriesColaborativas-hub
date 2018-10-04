/*
               File: type_SdtGAMUsersCountFilter
        Description: GAMUsersCountFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.43
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
   public class SdtGAMUsersCountFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMUsersCountFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMUsersCountFilter( IGxContext context )
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
         if ( GAMUsersCountFilter_externalReference == null )
         {
            GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMUsersCountFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMUsersCountFilter_externalReference == null )
         {
            GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMUsersCountFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMUsersCountFilter_externalReference == null )
         {
            GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMUsersCountFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Activeusers
      {
         get {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            return GAMUsersCountFilter_externalReference.ActiveUsers ;
         }

         set {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            GAMUsersCountFilter_externalReference.ActiveUsers = value;
            SetDirty("Activeusers");
         }

      }

      public String gxTpr_Blockedusers
      {
         get {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            return GAMUsersCountFilter_externalReference.BlockedUsers ;
         }

         set {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            GAMUsersCountFilter_externalReference.BlockedUsers = value;
            SetDirty("Blockedusers");
         }

      }

      public String gxTpr_Usergender
      {
         get {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            return GAMUsersCountFilter_externalReference.UserGender ;
         }

         set {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            GAMUsersCountFilter_externalReference.UserGender = value;
            SetDirty("Usergender");
         }

      }

      public String gxTpr_Isdeviceanonymoususer
      {
         get {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            return GAMUsersCountFilter_externalReference.IsDeviceAnonymousUser ;
         }

         set {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            GAMUsersCountFilter_externalReference.IsDeviceAnonymousUser = value;
            SetDirty("Isdeviceanonymoususer");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMUsersCountFilter_externalReference == null )
            {
               GAMUsersCountFilter_externalReference = new Artech.Security.GAMUsersCountFilter(context);
            }
            return GAMUsersCountFilter_externalReference ;
         }

         set {
            GAMUsersCountFilter_externalReference = (Artech.Security.GAMUsersCountFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMUsersCountFilter GAMUsersCountFilter_externalReference=null ;
   }

}
