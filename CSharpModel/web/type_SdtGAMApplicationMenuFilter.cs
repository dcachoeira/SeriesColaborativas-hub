/*
               File: type_SdtGAMApplicationMenuFilter
        Description: GAMApplicationMenuFilter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:53.49
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
   public class SdtGAMApplicationMenuFilter : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationMenuFilter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationMenuFilter( IGxContext context )
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
         if ( GAMApplicationMenuFilter_externalReference == null )
         {
            GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationMenuFilter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationMenuFilter_externalReference == null )
         {
            GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationMenuFilter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationMenuFilter_externalReference == null )
         {
            GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationMenuFilter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Name ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Description ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Id ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public bool gxTpr_Loaddescriptions
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.LoadDescriptions ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.LoadDescriptions = value;
            SetDirty("Loaddescriptions");
         }

      }

      public bool gxTpr_Loadproperties
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.LoadProperties ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.LoadProperties = value;
            SetDirty("Loadproperties");
         }

      }

      public int gxTpr_Start
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Start ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Start = value;
            SetDirty("Start");
         }

      }

      public int gxTpr_Limit
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Limit ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Limit = value;
            SetDirty("Limit");
         }

      }

      public String gxTpr_Token
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference.Token ;
         }

         set {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            GAMApplicationMenuFilter_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationMenuFilter_externalReference == null )
            {
               GAMApplicationMenuFilter_externalReference = new Artech.Security.GAMApplicationMenuFilter(context);
            }
            return GAMApplicationMenuFilter_externalReference ;
         }

         set {
            GAMApplicationMenuFilter_externalReference = (Artech.Security.GAMApplicationMenuFilter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationMenuFilter GAMApplicationMenuFilter_externalReference=null ;
   }

}
