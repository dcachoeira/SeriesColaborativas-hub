/*
               File: type_SdtGAMAuthenticationTypeGoogle
        Description: GAMAuthenticationTypeGoogle
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.46
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
   public class SdtGAMAuthenticationTypeGoogle : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeGoogle( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeGoogle( IGxContext context )
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
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         GAMAuthenticationTypeGoogle_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         GAMAuthenticationTypeGoogle_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         GAMAuthenticationTypeGoogle_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeGoogle_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeGoogle_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeGoogle_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeGoogle_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeGoogle_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeGoogle_externalReference == null )
         {
            GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeGoogle_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMAuthenticationGoogle gxTpr_Google
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            SdtGAMAuthenticationGoogle intValue ;
            intValue = new SdtGAMAuthenticationGoogle(context);
            Artech.Security.GAMAuthenticationGoogle externalParm0 ;
            externalParm0 = GAMAuthenticationTypeGoogle_externalReference.Google;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            SdtGAMAuthenticationGoogle intValue ;
            Artech.Security.GAMAuthenticationGoogle externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationGoogle)(intValue.ExternalInstance);
            GAMAuthenticationTypeGoogle_externalReference.Google = externalParm1;
            SetDirty("Google");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GAMAuthenticationTypeGoogle_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeGoogle_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeGoogle_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeGoogle_externalReference == null )
            {
               GAMAuthenticationTypeGoogle_externalReference = new Artech.Security.GAMAuthenticationTypeGoogle(context);
            }
            return GAMAuthenticationTypeGoogle_externalReference ;
         }

         set {
            GAMAuthenticationTypeGoogle_externalReference = (Artech.Security.GAMAuthenticationTypeGoogle)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeGoogle GAMAuthenticationTypeGoogle_externalReference=null ;
   }

}
