/*
               File: type_SdtGAMRepositoryConnectionFileFilter
        Description: GAMRepositoryConnectionFileFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.39
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
   public class SdtGAMRepositoryConnectionFileFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryConnectionFileFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryConnectionFileFilter( IGxContext context )
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
         if ( GAMRepositoryConnectionFileFilter_externalReference == null )
         {
            GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryConnectionFileFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryConnectionFileFilter_externalReference == null )
         {
            GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryConnectionFileFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryConnectionFileFilter_externalReference == null )
         {
            GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryConnectionFileFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRepositoryConnectionFileFilter_externalReference == null )
            {
               GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
            }
            return GAMRepositoryConnectionFileFilter_externalReference.GUID ;
         }

         set {
            if ( GAMRepositoryConnectionFileFilter_externalReference == null )
            {
               GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
            }
            GAMRepositoryConnectionFileFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRepositoryConnectionFileFilter_externalReference == null )
            {
               GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
            }
            return GAMRepositoryConnectionFileFilter_externalReference.Name ;
         }

         set {
            if ( GAMRepositoryConnectionFileFilter_externalReference == null )
            {
               GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
            }
            GAMRepositoryConnectionFileFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryConnectionFileFilter_externalReference == null )
            {
               GAMRepositoryConnectionFileFilter_externalReference = new Artech.Security.GAMRepositoryConnectionFileFilter(context);
            }
            return GAMRepositoryConnectionFileFilter_externalReference ;
         }

         set {
            GAMRepositoryConnectionFileFilter_externalReference = (Artech.Security.GAMRepositoryConnectionFileFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryConnectionFileFilter GAMRepositoryConnectionFileFilter_externalReference=null ;
   }

}
