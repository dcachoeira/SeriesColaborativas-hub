/*
               File: type_SdtGAMAuthenticationTypeCustom
        Description: GAMAuthenticationTypeCustom
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.84
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
   public class SdtGAMAuthenticationTypeCustom : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeCustom( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeCustom( IGxContext context )
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
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         GAMAuthenticationTypeCustom_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         GAMAuthenticationTypeCustom_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         GAMAuthenticationTypeCustom_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeCustom_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeCustom_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeCustom_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeCustom_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeCustom_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeCustom_externalReference == null )
         {
            GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeCustom_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Functionid
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.FunctionId ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.FunctionId = value;
            SetDirty("Functionid");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public String gxTpr_Impersonate
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.Impersonate ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.Impersonate = value;
            SetDirty("Impersonate");
         }

      }

      public SdtGAMAuthenticationCustom gxTpr_Custom
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            SdtGAMAuthenticationCustom intValue ;
            intValue = new SdtGAMAuthenticationCustom(context);
            Artech.Security.GAMAuthenticationCustom externalParm0 ;
            externalParm0 = GAMAuthenticationTypeCustom_externalReference.Custom;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            SdtGAMAuthenticationCustom intValue ;
            Artech.Security.GAMAuthenticationCustom externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationCustom)(intValue.ExternalInstance);
            GAMAuthenticationTypeCustom_externalReference.Custom = externalParm1;
            SetDirty("Custom");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GAMAuthenticationTypeCustom_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeCustom_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeCustom_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeCustom_externalReference == null )
            {
               GAMAuthenticationTypeCustom_externalReference = new Artech.Security.GAMAuthenticationTypeCustom(context);
            }
            return GAMAuthenticationTypeCustom_externalReference ;
         }

         set {
            GAMAuthenticationTypeCustom_externalReference = (Artech.Security.GAMAuthenticationTypeCustom)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeCustom GAMAuthenticationTypeCustom_externalReference=null ;
   }

}
