/*
               File: type_SdtGAMApplicationToken
        Description: GAMApplicationToken
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:54.24
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
   public class SdtGAMApplicationToken : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationToken( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationToken( IGxContext context )
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

      public void load( String gxTp_GUID )
      {
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         GAMApplicationToken_externalReference.Load(gxTp_GUID);
         return  ;
      }

      public void save( )
      {
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         GAMApplicationToken_externalReference.Save();
         return  ;
      }

      public void delete( )
      {
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         GAMApplicationToken_externalReference.Delete();
         return  ;
      }

      public bool success( )
      {
         bool returnsuccess ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returnsuccess = false;
         returnsuccess = (bool)(GAMApplicationToken_externalReference.Success());
         return returnsuccess ;
      }

      public bool fail( )
      {
         bool returnfail ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returnfail = false;
         returnfail = (bool)(GAMApplicationToken_externalReference.Fail());
         return returnfail ;
      }

      public GXExternalCollection<SdtGAMError> geterrors( )
      {
         GXExternalCollection<SdtGAMError> returngeterrors ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returngeterrors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         externalParm0 = GAMApplicationToken_externalReference.GetErrors();
         returngeterrors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngeterrors ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationToken_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationToken_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationToken_externalReference == null )
         {
            GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationToken_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            return GAMApplicationToken_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GAMApplicationToken_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            return GAMApplicationToken_externalReference.Name ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GAMApplicationToken_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            return GAMApplicationToken_externalReference.Description ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GAMApplicationToken_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMApplicationToken_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplicationToken_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMApplicationTokenElement> gxTpr_Elements
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GXExternalCollection<SdtGAMApplicationTokenElement> intValue ;
            intValue = new GXExternalCollection<SdtGAMApplicationTokenElement>( context, "SdtGAMApplicationTokenElement", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMApplicationTokenElement> externalParm2 ;
            externalParm2 = GAMApplicationToken_externalReference.Elements;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationTokenElement>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GXExternalCollection<SdtGAMApplicationTokenElement> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMApplicationTokenElement> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMApplicationTokenElement>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMApplicationTokenElement>), intValue.ExternalInstance);
            GAMApplicationToken_externalReference.Elements = externalParm3;
            SetDirty("Elements");
         }

      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            return GAMApplicationToken_externalReference.ApplicationId ;
         }

         set {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            GAMApplicationToken_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationToken_externalReference == null )
            {
               GAMApplicationToken_externalReference = new Artech.Security.GAMApplicationToken(context);
            }
            return GAMApplicationToken_externalReference ;
         }

         set {
            GAMApplicationToken_externalReference = (Artech.Security.GAMApplicationToken)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationToken GAMApplicationToken_externalReference=null ;
   }

}
