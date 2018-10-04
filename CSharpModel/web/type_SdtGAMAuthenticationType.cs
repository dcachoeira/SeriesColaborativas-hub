/*
               File: type_SdtGAMAuthenticationType
        Description: GAMAuthenticationType
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.62
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
   public class SdtGAMAuthenticationType : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationType( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationType( IGxContext context )
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

      public String gettypebyname( String gxTp_Name ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         String returngettypebyname ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMAuthenticationType_externalReference == null )
         {
            GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
         }
         returngettypebyname = "";
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngettypebyname = (String)(GAMAuthenticationType_externalReference.GetTypeByName(gxTp_Name, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngettypebyname ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationType_externalReference == null )
         {
            GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationType_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationType_externalReference == null )
         {
            GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationType_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationType_externalReference == null )
         {
            GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationType_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Typeid
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.TypeId ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.TypeId = value;
            SetDirty("Typeid");
         }

      }

      public String gxTpr_Functionid
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.FunctionId ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.FunctionId = value;
            SetDirty("Functionid");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GAMAuthenticationType_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMAuthenticationType_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationType_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMAuthenticationType_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMAuthenticationType_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationType_externalReference == null )
            {
               GAMAuthenticationType_externalReference = new Artech.Security.GAMAuthenticationType(context);
            }
            return GAMAuthenticationType_externalReference ;
         }

         set {
            GAMAuthenticationType_externalReference = (Artech.Security.GAMAuthenticationType)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationType GAMAuthenticationType_externalReference=null ;
   }

}
