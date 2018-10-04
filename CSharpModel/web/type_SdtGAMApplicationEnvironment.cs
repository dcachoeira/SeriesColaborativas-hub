/*
               File: type_SdtGAMApplicationEnvironment
        Description: GAMApplicationEnvironment
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:52.82
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
   public class SdtGAMApplicationEnvironment : GxUserType, IGxExternalObject
   {
      public SdtGAMApplicationEnvironment( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMApplicationEnvironment( IGxContext context )
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

      public String tostring( )
      {
         String returntostring ;
         if ( GAMApplicationEnvironment_externalReference == null )
         {
            GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
         }
         returntostring = "";
         returntostring = (String)(GAMApplicationEnvironment_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMApplicationEnvironment_externalReference == null )
         {
            GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMApplicationEnvironment_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMApplicationEnvironment_externalReference == null )
         {
            GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMApplicationEnvironment_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Applicationid
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.ApplicationId ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.ApplicationId = value;
            SetDirty("Applicationid");
         }

      }

      public long gxTpr_Id
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.Id ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Guid
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.GUID ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.GUID = value;
            SetDirty("Guid");
         }

      }

      public String gxTpr_Host
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.Host ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.Host = value;
            SetDirty("Host");
         }

      }

      public int gxTpr_Port
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.Port ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.Port = value;
            SetDirty("Port");
         }

      }

      public String gxTpr_Virtualdirectory
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.VirtualDirectory ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.VirtualDirectory = value;
            SetDirty("Virtualdirectory");
         }

      }

      public bool gxTpr_Secureprotocol
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.SecureProtocol ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.SecureProtocol = value;
            SetDirty("Secureprotocol");
         }

      }

      public String gxTpr_Programpackage
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.ProgramPackage ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.ProgramPackage = value;
            SetDirty("Programpackage");
         }

      }

      public String gxTpr_Programextension
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.ProgramExtension ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.ProgramExtension = value;
            SetDirty("Programextension");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.Name ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public int gxTpr_Order
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.Order ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.Order = value;
            SetDirty("Order");
         }

      }

      public DateTime gxTpr_Datecreated
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.DateCreated ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.DateCreated = value;
            SetDirty("Datecreated");
         }

      }

      public String gxTpr_Usercreated
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.UserCreated ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.UserCreated = value;
            SetDirty("Usercreated");
         }

      }

      public DateTime gxTpr_Dateupdated
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.DateUpdated ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.DateUpdated = value;
            SetDirty("Dateupdated");
         }

      }

      public String gxTpr_Userupdated
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.UserUpdated ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.UserUpdated = value;
            SetDirty("Userupdated");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm0 ;
            externalParm0 = GAMApplicationEnvironment_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMApplicationEnvironment_externalReference.Descriptions = externalParm1;
            SetDirty("Descriptions");
         }

      }

      public String gxTpr_Url
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference.URL ;
         }

         set {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            GAMApplicationEnvironment_externalReference.URL = value;
            SetDirty("Url");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMApplicationEnvironment_externalReference == null )
            {
               GAMApplicationEnvironment_externalReference = new Artech.Security.GAMApplicationEnvironment(context);
            }
            return GAMApplicationEnvironment_externalReference ;
         }

         set {
            GAMApplicationEnvironment_externalReference = (Artech.Security.GAMApplicationEnvironment)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMApplicationEnvironment GAMApplicationEnvironment_externalReference=null ;
   }

}
