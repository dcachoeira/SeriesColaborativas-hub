/*
               File: type_SdtGAMRepositoryConnection
        Description: GAMRepositoryConnection
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:19.21
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
   public class SdtGAMRepositoryConnection : GxUserType, IGxExternalObject
   {
      public SdtGAMRepositoryConnection( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMRepositoryConnection( IGxContext context )
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
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         GAMRepositoryConnection_externalReference.Load(gxTp_Name);
         return  ;
      }

      public void save( )
      {
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         GAMRepositoryConnection_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         GAMRepositoryConnection_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMRepositoryConnection_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMRepositoryConnection_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMRepositoryConnection_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returntostring = "";
         returntostring = (String)(GAMRepositoryConnection_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMRepositoryConnection_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMRepositoryConnection_externalReference == null )
         {
            GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMRepositoryConnection_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Name
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.Name ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Type
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.Type ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.Type = value;
            SetDirty("Type");
         }

      }

      public String gxTpr_Username
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.UserName ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.UserName = value;
            SetDirty("Username");
         }

      }

      public String gxTpr_Userpassword
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.UserPassword ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.UserPassword = value;
            SetDirty("Userpassword");
         }

      }

      public String gxTpr_Language
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.Language ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.Language = value;
            SetDirty("Language");
         }

      }

      public String gxTpr_Key
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.Key ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.Key = value;
            SetDirty("Key");
         }

      }

      public bool gxTpr_Specifyserver
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.SpecifyServer ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.SpecifyServer = value;
            SetDirty("Specifyserver");
         }

      }

      public int gxTpr_Challengeexpire
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.ChallengeExpire ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.ChallengeExpire = value;
            SetDirty("Challengeexpire");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.DateCreated ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.UserCreated ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.DateUpdated ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference.UserUpdated ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GAMRepositoryConnection_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMRepositoryConnectionAddressList> gxTpr_Addresslist
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GXExternalCollection<SdtGAMRepositoryConnectionAddressList> intValue ;
            intValue = new GXExternalCollection<SdtGAMRepositoryConnectionAddressList>( context, "SdtGAMRepositoryConnectionAddressList", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionAddressList> externalParm0 ;
            externalParm0 = GAMRepositoryConnection_externalReference.AddressList;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionAddressList>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            GXExternalCollection<SdtGAMRepositoryConnectionAddressList> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionAddressList> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionAddressList>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionAddressList>), intValue.ExternalInstance);
            GAMRepositoryConnection_externalReference.AddressList = externalParm1;
            SetDirty("Addresslist");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMRepositoryConnection_externalReference == null )
            {
               GAMRepositoryConnection_externalReference = new Artech.Security.GAMRepositoryConnection(context);
            }
            return GAMRepositoryConnection_externalReference ;
         }

         set {
            GAMRepositoryConnection_externalReference = (Artech.Security.GAMRepositoryConnection)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMRepositoryConnection GAMRepositoryConnection_externalReference=null ;
   }

}
