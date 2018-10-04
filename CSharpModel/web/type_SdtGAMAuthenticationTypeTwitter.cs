/*
               File: type_SdtGAMAuthenticationTypeTwitter
        Description: GAMAuthenticationTypeTwitter
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.81
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
   public class SdtGAMAuthenticationTypeTwitter : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeTwitter( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeTwitter( IGxContext context )
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
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         GAMAuthenticationTypeTwitter_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         GAMAuthenticationTypeTwitter_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         GAMAuthenticationTypeTwitter_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeTwitter_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeTwitter_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeTwitter_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeTwitter_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeTwitter_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeTwitter_externalReference == null )
         {
            GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeTwitter_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMAuthenticationTwitter gxTpr_Twitter
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            SdtGAMAuthenticationTwitter intValue ;
            intValue = new SdtGAMAuthenticationTwitter(context);
            Artech.Security.GAMAuthenticationTwitter externalParm0 ;
            externalParm0 = GAMAuthenticationTypeTwitter_externalReference.Twitter;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            SdtGAMAuthenticationTwitter intValue ;
            Artech.Security.GAMAuthenticationTwitter externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationTwitter)(intValue.ExternalInstance);
            GAMAuthenticationTypeTwitter_externalReference.Twitter = externalParm1;
            SetDirty("Twitter");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GAMAuthenticationTypeTwitter_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeTwitter_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeTwitter_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeTwitter_externalReference == null )
            {
               GAMAuthenticationTypeTwitter_externalReference = new Artech.Security.GAMAuthenticationTypeTwitter(context);
            }
            return GAMAuthenticationTypeTwitter_externalReference ;
         }

         set {
            GAMAuthenticationTypeTwitter_externalReference = (Artech.Security.GAMAuthenticationTypeTwitter)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeTwitter GAMAuthenticationTypeTwitter_externalReference=null ;
   }

}
