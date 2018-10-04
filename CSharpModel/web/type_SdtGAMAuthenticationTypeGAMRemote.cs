/*
               File: type_SdtGAMAuthenticationTypeGAMRemote
        Description: GAMAuthenticationTypeGAMRemote
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:55.28
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
   public class SdtGAMAuthenticationTypeGAMRemote : GxUserType, IGxExternalObject
   {
      public SdtGAMAuthenticationTypeGAMRemote( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMAuthenticationTypeGAMRemote( IGxContext context )
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
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         GAMAuthenticationTypeGAMRemote_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         GAMAuthenticationTypeGAMRemote_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         GAMAuthenticationTypeGAMRemote_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMAuthenticationTypeGAMRemote_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMAuthenticationTypeGAMRemote_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMAuthenticationTypeGAMRemote_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returntostring = "";
         returntostring = (String)(GAMAuthenticationTypeGAMRemote_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMAuthenticationTypeGAMRemote_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
         {
            GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMAuthenticationTypeGAMRemote_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.Name ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Functionid
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.FunctionId ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.FunctionId = value;
            SetDirty("Functionid");
         }

      }

      public bool gxTpr_Isenable
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.IsEnable ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.IsEnable = value;
            SetDirty("Isenable");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.Description ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public SdtGAMAuthenticationGAMRemote gxTpr_Gamremote
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            SdtGAMAuthenticationGAMRemote intValue ;
            intValue = new SdtGAMAuthenticationGAMRemote(context);
            Artech.Security.GAMAuthenticationGAMRemote externalParm0 ;
            externalParm0 = GAMAuthenticationTypeGAMRemote_externalReference.GAMRemote;
            intValue.ExternalInstance = externalParm0;
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            SdtGAMAuthenticationGAMRemote intValue ;
            Artech.Security.GAMAuthenticationGAMRemote externalParm1 ;
            intValue = value;
            externalParm1 = (Artech.Security.GAMAuthenticationGAMRemote)(intValue.ExternalInstance);
            GAMAuthenticationTypeGAMRemote_externalReference.GAMRemote = externalParm1;
            SetDirty("Gamremote");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.DateCreated ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.UserCreated ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.DateUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.UserUpdated ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMAuthenticationTypeGAMRemote_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMAuthenticationTypeGAMRemote_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public String gxTpr_Impersonate
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference.Impersonate ;
         }

         set {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            GAMAuthenticationTypeGAMRemote_externalReference.Impersonate = value;
            SetDirty("Impersonate");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMAuthenticationTypeGAMRemote_externalReference == null )
            {
               GAMAuthenticationTypeGAMRemote_externalReference = new Artech.Security.GAMAuthenticationTypeGAMRemote(context);
            }
            return GAMAuthenticationTypeGAMRemote_externalReference ;
         }

         set {
            GAMAuthenticationTypeGAMRemote_externalReference = (Artech.Security.GAMAuthenticationTypeGAMRemote)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMAuthenticationTypeGAMRemote GAMAuthenticationTypeGAMRemote_externalReference=null ;
   }

}
