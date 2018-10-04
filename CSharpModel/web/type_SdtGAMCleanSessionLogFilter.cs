/*
               File: type_SdtGAMCleanSessionLogFilter
        Description: GAMCleanSessionLogFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.29
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
   public class SdtGAMCleanSessionLogFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMCleanSessionLogFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMCleanSessionLogFilter( IGxContext context )
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
         if ( GAMCleanSessionLogFilter_externalReference == null )
         {
            GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMCleanSessionLogFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMCleanSessionLogFilter_externalReference == null )
         {
            GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMCleanSessionLogFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMCleanSessionLogFilter_externalReference == null )
         {
            GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMCleanSessionLogFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Repositoryid
      {
         get {
            if ( GAMCleanSessionLogFilter_externalReference == null )
            {
               GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
            }
            return GAMCleanSessionLogFilter_externalReference.RepositoryId ;
         }

         set {
            if ( GAMCleanSessionLogFilter_externalReference == null )
            {
               GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
            }
            GAMCleanSessionLogFilter_externalReference.RepositoryId = value;
            SetDirty("Repositoryid");
         }

      }

      public DateTime gxTpr_Cleanuptodate
      {
         get {
            if ( GAMCleanSessionLogFilter_externalReference == null )
            {
               GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
            }
            return GAMCleanSessionLogFilter_externalReference.CleanUpToDate ;
         }

         set {
            if ( GAMCleanSessionLogFilter_externalReference == null )
            {
               GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
            }
            GAMCleanSessionLogFilter_externalReference.CleanUpToDate = value;
            SetDirty("Cleanuptodate");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMCleanSessionLogFilter_externalReference == null )
            {
               GAMCleanSessionLogFilter_externalReference = new Artech.Security.GAMCleanSessionLogFilter(context);
            }
            return GAMCleanSessionLogFilter_externalReference ;
         }

         set {
            GAMCleanSessionLogFilter_externalReference = (Artech.Security.GAMCleanSessionLogFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMCleanSessionLogFilter GAMCleanSessionLogFilter_externalReference=null ;
   }

}
