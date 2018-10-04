/*
               File: type_SdtGAMAuthenticationTypeLocal
        Description: GAMAuthenticationTypeLocal
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.64
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
   public class SdtGAMAuthenticationTypeLocal : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeLocal( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeLocal( IGxContext context )
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

      public void load( String gxTp_Name )
      {
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         GAMAuthenticationTypeLocal_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         GAMAuthenticationTypeLocal_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         GAMAuthenticationTypeLocal_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeLocal_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeLocal_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeLocal_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeLocal_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeLocal_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeLocal_externalReference == null )
         {
            GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeLocal_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Functionid
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.FunctionId ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.FunctionId = value;
            SetDirty("Functionid");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GAMAuthenticationTypeLocal_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMAuthenticationTypeLocal_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeLocal_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeLocal_externalReference == null )
            {
               GAMAuthenticationTypeLocal_externalReference = new Artech.Security.GAMAuthenticationTypeLocal(context);
            }
            return GAMAuthenticationTypeLocal_externalReference ;
         }

         set {
            GAMAuthenticationTypeLocal_externalReference = (Artech.Security.GAMAuthenticationTypeLocal)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeLocal GAMAuthenticationTypeLocal_externalReference=null ;
   }

}
