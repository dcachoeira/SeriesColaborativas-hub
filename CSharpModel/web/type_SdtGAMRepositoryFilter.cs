/*
               File: type_SdtGAMRepositoryFilter
        Description: GAMRepositoryFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.79
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
   public class SdtGAMRepositoryFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryFilter( IGxContext context )
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
         if ( GAMRepositoryFilter_externalReference == null )
         {
            GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryFilter_externalReference == null )
         {
            GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryFilter_externalReference == null )
         {
            GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Id
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.Id ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.GUID ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.Name ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Namespace
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.NameSpace ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.NameSpace = value;
            SetDirty("Namespace");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.Start ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference.Limit ;
         }

         set {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            GAMRepositoryFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryFilter_externalReference == null )
            {
               GAMRepositoryFilter_externalReference = new Artech.Security.GAMRepositoryFilter(context);
            }
            return GAMRepositoryFilter_externalReference ;
         }

         set {
            GAMRepositoryFilter_externalReference = (Artech.Security.GAMRepositoryFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryFilter GAMRepositoryFilter_externalReference=null ;
   }

}
