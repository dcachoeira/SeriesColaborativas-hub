/*
               File: type_SdtGAMEventSubscription
        Description: GAMEventSubscription
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.55
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
   public class SdtGAMEventSubscription : GxUserType, IGxExternalObject
   {
      public SdtGAMEventSubscription( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMEventSubscription( IGxContext context )
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

      public void load( String gxTp_Id )
      {
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         GAMEventSubscription_externalReference.Load(gxTp_Id);
         return  ;
      }

      public void save( )
      {
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         GAMEventSubscription_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         GAMEventSubscription_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMEventSubscription_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMEventSubscription_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMEventSubscription_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returntostring = "";
         returntostring = (String)(GAMEventSubscription_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMEventSubscription_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMEventSubscription_externalReference == null )
         {
            GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMEventSubscription_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Id
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.Id ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.Description ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Status
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.Status ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.Status = value;
            SetDirty("Status");
         }

      }

      public String gxTpr_Event
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.Event ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.Event = value;
            SetDirty("Event");
         }

      }

      public String gxTpr_Filename
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.FileName ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.FileName = value;
            SetDirty("Filename");
         }

      }

      public String gxTpr_Classname
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.ClassName ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.ClassName = value;
            SetDirty("Classname");
         }

      }

      public String gxTpr_Methodname
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.MethodName ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.MethodName = value;
            SetDirty("Methodname");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.DateCreated ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.UserCreated ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.DateUpdated ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference.UserUpdated ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GAMEventSubscription_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm0 ;
            externalParm0 = GAMEventSubscription_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMEventSubscription_externalReference.Properties = externalParm1;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMEventSubscription_externalReference == null )
            {
               GAMEventSubscription_externalReference = new Artech.Security.GAMEventSubscription(context);
            }
            return GAMEventSubscription_externalReference ;
         }

         set {
            GAMEventSubscription_externalReference = (Artech.Security.GAMEventSubscription)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMEventSubscription GAMEventSubscription_externalReference=null ;
   }

}
