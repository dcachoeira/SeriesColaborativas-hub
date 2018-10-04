/*
               File: type_SdtGAMAuthenticationTypeFacebook
        Description: GAMAuthenticationTypeFacebook
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.3
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
   public class SdtGAMAuthenticationTypeFacebook : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeFacebook( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeFacebook( IGxContext context )
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
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         GAMAuthenticationTypeFacebook_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         GAMAuthenticationTypeFacebook_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         GAMAuthenticationTypeFacebook_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeFacebook_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeFacebook_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeFacebook_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeFacebook_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeFacebook_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeFacebook_externalReference == null )
         {
            GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeFacebook_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMAuthenticationFacebook gxTpr_Facebook
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            SdtGAMAuthenticationFacebook intValue ;
            intValue = new SdtGAMAuthenticationFacebook(context);
            Artech.Security.GAMAuthenticationFacebook externalParm0 ;
            externalParm0 = GAMAuthenticationTypeFacebook_externalReference.Facebook;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            SdtGAMAuthenticationFacebook intValue ;
            Artech.Security.GAMAuthenticationFacebook externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationFacebook)(intValue.ExternalInstance);
            GAMAuthenticationTypeFacebook_externalReference.Facebook = externalParm1;
            SetDirty("Facebook");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GAMAuthenticationTypeFacebook_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeFacebook_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeFacebook_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeFacebook_externalReference == null )
            {
               GAMAuthenticationTypeFacebook_externalReference = new Artech.Security.GAMAuthenticationTypeFacebook(context);
            }
            return GAMAuthenticationTypeFacebook_externalReference ;
         }

         set {
            GAMAuthenticationTypeFacebook_externalReference = (Artech.Security.GAMAuthenticationTypeFacebook)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeFacebook GAMAuthenticationTypeFacebook_externalReference=null ;
   }

}
