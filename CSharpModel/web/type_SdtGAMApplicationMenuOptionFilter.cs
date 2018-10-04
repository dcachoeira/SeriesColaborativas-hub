/*
               File: type_SdtGAMApplicationMenuOptionFilter
        Description: GAMApplicationMenuOptionFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:53.84
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
   public class SdtGAMApplicationMenuOptionFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationMenuOptionFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationMenuOptionFilter( IGxContext context )
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
         if ( GAMApplicationMenuOptionFilter_externalReference == null )
         {
            GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationMenuOptionFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationMenuOptionFilter_externalReference == null )
         {
            GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationMenuOptionFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationMenuOptionFilter_externalReference == null )
         {
            GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationMenuOptionFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Name ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Description ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Id ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Type ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public int gxTpr_Order
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Order ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Order = value;
            SetDirty("Order");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Start ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference.Limit ;
         }

         set {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            GAMApplicationMenuOptionFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationMenuOptionFilter_externalReference == null )
            {
               GAMApplicationMenuOptionFilter_externalReference = new Artech.Security.GAMApplicationMenuOptionFilter(context);
            }
            return GAMApplicationMenuOptionFilter_externalReference ;
         }

         set {
            GAMApplicationMenuOptionFilter_externalReference = (Artech.Security.GAMApplicationMenuOptionFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationMenuOptionFilter GAMApplicationMenuOptionFilter_externalReference=null ;
   }

}
