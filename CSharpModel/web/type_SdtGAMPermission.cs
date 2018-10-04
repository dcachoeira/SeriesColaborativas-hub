/*
               File: type_SdtGAMPermission
        Description: GAMPermission
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.98
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
   public class SdtGAMPermission : GxUserType, IGxExternalObject
   {
      public SdtGAMPermission( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMPermission( IGxContext context )
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
         if ( GAMPermission_externalReference == null )
         {
            GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
         }
         returntostring = "";
         returntostring = (String)(GAMPermission_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMPermission_externalReference == null )
         {
            GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMPermission_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMPermission_externalReference == null )
         {
            GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMPermission_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.ApplicationId ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.GUID ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.Name ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.Description ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Token
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.Token ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.Token = value;
            SetDirty("Token");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.Type ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public bool gxTpr_Inherited
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.Inherited ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.Inherited = value;
            SetDirty("Inherited");
         }

      }

      public bool gxTpr_Isautomaticpermission
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.IsAutomaticPermission ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.IsAutomaticPermission = value;
            SetDirty("Isautomaticpermission");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.DateCreated ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.UserCreated ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.DateUpdated ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference.UserUpdated ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GAMPermission_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm0 ;
            externalParm0 = GAMPermission_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMPermission_externalReference.Properties = externalParm1;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMPermission_externalReference == null )
            {
               GAMPermission_externalReference = new Artech.Security.GAMPermission(context);
            }
            return GAMPermission_externalReference ;
         }

         set {
            GAMPermission_externalReference = (Artech.Security.GAMPermission)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMPermission GAMPermission_externalReference=null ;
   }

}
