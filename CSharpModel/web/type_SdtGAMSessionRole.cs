/*
               File: type_SdtGAMSessionRole
        Description: GAMSessionRole
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:23.36
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
   public class SdtGAMSessionRole : GxUserType, IGxExternalObject
   {
      public SdtGAMSessionRole( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSessionRole( IGxContext context )
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
         if ( GAMSessionRole_externalReference == null )
         {
            GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSessionRole_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSessionRole_externalReference == null )
         {
            GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSessionRole_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSessionRole_externalReference == null )
         {
            GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSessionRole_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Id
      {
         get {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            return GAMSessionRole_externalReference.Id ;
         }

         set {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            GAMSessionRole_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            return GAMSessionRole_externalReference.GUID ;
         }

         set {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            GAMSessionRole_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            return GAMSessionRole_externalReference.Name ;
         }

         set {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            GAMSessionRole_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Externalid
      {
         get {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            return GAMSessionRole_externalReference.ExternalId ;
         }

         set {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            GAMSessionRole_externalReference.ExternalId = value;
            SetDirty("Externalid");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSessionRole_externalReference == null )
            {
               GAMSessionRole_externalReference = new Artech.Security.GAMSessionRole(context);
            }
            return GAMSessionRole_externalReference ;
         }

         set {
            GAMSessionRole_externalReference = (Artech.Security.GAMSessionRole)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSessionRole GAMSessionRole_externalReference=null ;
   }

}
