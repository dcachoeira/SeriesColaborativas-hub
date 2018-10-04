/*
               File: type_SdtGAMEventSubscriptionFilter
        Description: GAMEventSubscriptionFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.71
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
   public class SdtGAMEventSubscriptionFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMEventSubscriptionFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMEventSubscriptionFilter( IGxContext context )
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
         if ( GAMEventSubscriptionFilter_externalReference == null )
         {
            GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMEventSubscriptionFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMEventSubscriptionFilter_externalReference == null )
         {
            GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMEventSubscriptionFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMEventSubscriptionFilter_externalReference == null )
         {
            GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMEventSubscriptionFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.Id ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Descripction
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.Descripction ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.Descripction = value;
            SetDirty("Descripction");
         }

      }

      public String gxTpr_Status
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.Status ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public String gxTpr_Event
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.Event ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.Event = value;
            SetDirty("Event");
         }

      }

      public String gxTpr_Filename
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.FileName ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.FileName = value;
            SetDirty("Filename");
         }

      }

      public String gxTpr_Classname
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.ClassName ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.ClassName = value;
            SetDirty("Classname");
         }

      }

      public String gxTpr_Methodname
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference.MethodName ;
         }

         set {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            GAMEventSubscriptionFilter_externalReference.MethodName = value;
            SetDirty("Methodname");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMEventSubscriptionFilter_externalReference == null )
            {
               GAMEventSubscriptionFilter_externalReference = new Artech.Security.GAMEventSubscriptionFilter(context);
            }
            return GAMEventSubscriptionFilter_externalReference ;
         }

         set {
            GAMEventSubscriptionFilter_externalReference = (Artech.Security.GAMEventSubscriptionFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMEventSubscriptionFilter GAMEventSubscriptionFilter_externalReference=null ;
   }

}
