/*
               File: type_SdtGAMAuthenticationTypeWebService
        Description: GAMAuthenticationTypeWebService
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.1
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
   public class SdtGAMAuthenticationTypeWebService : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeWebService( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeWebService( IGxContext context )
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
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         GAMAuthenticationTypeWebService_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         GAMAuthenticationTypeWebService_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         GAMAuthenticationTypeWebService_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeWebService_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeWebService_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeWebService_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeWebService_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeWebService_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeWebService_externalReference == null )
         {
            GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeWebService_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Functionid
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.FunctionId ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.FunctionId = value;
            SetDirty("Functionid");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Impersonate
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.Impersonate ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.Impersonate = value;
            SetDirty("Impersonate");
         }

      }

      public SdtGAMAuthenticationWebService gxTpr_Webservice
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            SdtGAMAuthenticationWebService intValue ;
            intValue = new SdtGAMAuthenticationWebService(context);
            Artech.Security.GAMAuthenticationWebService externalParm0 ;
            externalParm0 = GAMAuthenticationTypeWebService_externalReference.WebService;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            SdtGAMAuthenticationWebService intValue ;
            Artech.Security.GAMAuthenticationWebService externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationWebService)(intValue.ExternalInstance);
            GAMAuthenticationTypeWebService_externalReference.WebService = externalParm1;
            SetDirty("Webservice");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GAMAuthenticationTypeWebService_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeWebService_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeWebService_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeWebService_externalReference == null )
            {
               GAMAuthenticationTypeWebService_externalReference = new Artech.Security.GAMAuthenticationTypeWebService(context);
            }
            return GAMAuthenticationTypeWebService_externalReference ;
         }

         set {
            GAMAuthenticationTypeWebService_externalReference = (Artech.Security.GAMAuthenticationTypeWebService)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeWebService GAMAuthenticationTypeWebService_externalReference=null ;
   }

}
