/*
               File: type_SdtGAMSecurityPolicy
        Description: GAMSecurityPolicy
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:21.31
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
   public class SdtGAMSecurityPolicy : GxUserType, IGxExternalObject
   {
      public SdtGAMSecurityPolicy( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMSecurityPolicy( IGxContext context )
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

      public SdtGAMSecurityPolicy getbyguid( String gxTp_GUID ,
                                             out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         SdtGAMSecurityPolicy returngetbyguid ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returngetbyguid = new SdtGAMSecurityPolicy(context);
         Artech.Security.GAMSecurityPolicy externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = GAMSecurityPolicy_externalReference.GetByGUID(gxTp_GUID, out externalParm1);
         returngetbyguid.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetbyguid ;
      }

      public bool saveas( out SdtGAMSecurityPolicy gxTp_SecurityPolicy ,
                          out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsaveas ;
         gxTp_SecurityPolicy = new SdtGAMSecurityPolicy(context);
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returnsaveas = false;
         Artech.Security.GAMSecurityPolicy externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         returnsaveas = (bool)(GAMSecurityPolicy_externalReference.SaveAs(out externalParm0, out externalParm1));
         gxTp_SecurityPolicy.ExternalInstance = externalParm0;
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnsaveas ;
      }

      public void load( int gxTp_Id )
      {
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         GAMSecurityPolicy_externalReference.Load(gxTp_Id);
         return  ;
      }

      public void save( )
      {
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         GAMSecurityPolicy_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         GAMSecurityPolicy_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMSecurityPolicy_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMSecurityPolicy_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMSecurityPolicy_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returntostring = "";
         returntostring = (String)(GAMSecurityPolicy_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMSecurityPolicy_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMSecurityPolicy_externalReference == null )
         {
            GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMSecurityPolicy_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public int gxTpr_Id
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.Id ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.GUID ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.Name ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public short gxTpr_Allowmultipleconcurrentwebsessions
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.AllowMultipleConcurrentWebSessions ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.AllowMultipleConcurrentWebSessions = value;
            SetDirty("Allowmultipleconcurrentwebsessions");
         }

      }

      public short gxTpr_Websessiontimeout
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.WebSessionTimeout ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.WebSessionTimeout = value;
            SetDirty("Websessiontimeout");
         }

      }

      public int gxTpr_Oauthtokenexpire
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.OauthTokenExpire ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.OauthTokenExpire = value;
            SetDirty("Oauthtokenexpire");
         }

      }

      public short gxTpr_Oauthtokenmaximumrenovations
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.OauthTokenMaximumRenovations ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.OauthTokenMaximumRenovations = value;
            SetDirty("Oauthtokenmaximumrenovations");
         }

      }

      public short gxTpr_Periodchangepassword
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.PeriodChangePassword ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.PeriodChangePassword = value;
            SetDirty("Periodchangepassword");
         }

      }

      public short gxTpr_Minimumtimetochangepasswords
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MinimumTimeToChangePasswords ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MinimumTimeToChangePasswords = value;
            SetDirty("Minimumtimetochangepasswords");
         }

      }

      public short gxTpr_Minimumlengthpassword
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MinimumLengthPassword ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MinimumLengthPassword = value;
            SetDirty("Minimumlengthpassword");
         }

      }

      public short gxTpr_Minimumnumericcharacterspassword
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MinimumNumericCharactersPassword ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MinimumNumericCharactersPassword = value;
            SetDirty("Minimumnumericcharacterspassword");
         }

      }

      public short gxTpr_Minimumuppercasecharacterspassword
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MinimumUpperCaseCharactersPassword ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MinimumUpperCaseCharactersPassword = value;
            SetDirty("Minimumuppercasecharacterspassword");
         }

      }

      public short gxTpr_Minimumspecialcharacterspassword
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MinimumSpecialCharactersPassword ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MinimumSpecialCharactersPassword = value;
            SetDirty("Minimumspecialcharacterspassword");
         }

      }

      public short gxTpr_Maximumpasswordhistoryentries
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.MaximumPasswordHistoryEntries ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.MaximumPasswordHistoryEntries = value;
            SetDirty("Maximumpasswordhistoryentries");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.DateCreated ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.UserCreated ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.DateUpdated ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference.UserUpdated ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GAMSecurityPolicy_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMSecurityPolicy_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMSecurityPolicy_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm2 ;
            externalParm2 = GAMSecurityPolicy_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMSecurityPolicy_externalReference.Properties = externalParm3;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMSecurityPolicy_externalReference == null )
            {
               GAMSecurityPolicy_externalReference = new Artech.Security.GAMSecurityPolicy(context);
            }
            return GAMSecurityPolicy_externalReference ;
         }

         set {
            GAMSecurityPolicy_externalReference = (Artech.Security.GAMSecurityPolicy)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMSecurityPolicy GAMSecurityPolicy_externalReference=null ;
   }

}
