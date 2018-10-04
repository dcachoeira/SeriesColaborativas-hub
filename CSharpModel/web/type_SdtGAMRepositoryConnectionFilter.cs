/*
               File: type_SdtGAMRepositoryConnectionFilter
        Description: GAMRepositoryConnectionFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.42
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
   public class SdtGAMRepositoryConnectionFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryConnectionFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryConnectionFilter( IGxContext context )
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
         if ( GAMRepositoryConnectionFilter_externalReference == null )
         {
            GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryConnectionFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryConnectionFilter_externalReference == null )
         {
            GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryConnectionFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryConnectionFilter_externalReference == null )
         {
            GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryConnectionFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Connectionname
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference.ConnectionName ;
         }

         set {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            GAMRepositoryConnectionFilter_externalReference.ConnectionName = value;
            SetDirty("Connectionname");
         }

      }

      public String gxTpr_Connectiontype
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference.ConnectionType ;
         }

         set {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            GAMRepositoryConnectionFilter_externalReference.ConnectionType = value;
            SetDirty("Connectiontype");
         }

      }

      public String gxTpr_Username
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference.UserName ;
         }

         set {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            GAMRepositoryConnectionFilter_externalReference.UserName = value;
            SetDirty("Username");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference.Start ;
         }

         set {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            GAMRepositoryConnectionFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference.Limit ;
         }

         set {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            GAMRepositoryConnectionFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryConnectionFilter_externalReference == null )
            {
               GAMRepositoryConnectionFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFilter(context);
            }
            return GAMRepositoryConnectionFilter_externalReference ;
         }

         set {
            GAMRepositoryConnectionFilter_externalReference = (Artech.Security.GAMRepositoryConnectionFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryConnectionFilter GAMRepositoryConnectionFilter_externalReference=null ;
   }

}
