/*
               File: type_SdtGAMMenuOptionList
        Description: GAMMenuOptionList
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:56.88
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
   public class SdtGAMMenuOptionList : GxUserType, IGxExternalObject
   {
      public SdtGAMMenuOptionList( )
      {
         /* Constructor for serialization */
      }

      public SdtGAMMenuOptionList( IGxContext context )
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
         if ( GAMMenuOptionList_externalReference == null )
         {
            GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
         }
         returntostring = "";
         returntostring = (String)(GAMMenuOptionList_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAMMenuOptionList_externalReference == null )
         {
            GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAMMenuOptionList_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAMMenuOptionList_externalReference == null )
         {
            GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAMMenuOptionList_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public long gxTpr_Id
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference.Id ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GAMMenuOptionList_externalReference.Id = value;
            SetDirty("Id");
         }

      }

      public String gxTpr_Name
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference.Name ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GAMMenuOptionList_externalReference.Name = value;
            SetDirty("Name");
         }

      }

      public String gxTpr_Link
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference.Link ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GAMMenuOptionList_externalReference.Link = value;
            SetDirty("Link");
         }

      }

      public GXExternalCollection<SdtGAMMenuOptionList> gxTpr_Nodes
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMMenuOptionList> intValue ;
            intValue = new GXExternalCollection<SdtGAMMenuOptionList>( context, "SdtGAMMenuOptionList", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMMenuOptionList> externalParm0 ;
            externalParm0 = GAMMenuOptionList_externalReference.Nodes;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMMenuOptionList>), externalParm0);
            return intValue ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMMenuOptionList> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMMenuOptionList> externalParm1 ;
            intValue = value;
            externalParm1 = (System.Collections.Generic.List<Artech.Security.GAMMenuOptionList>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMMenuOptionList>), intValue.ExternalInstance);
            GAMMenuOptionList_externalReference.Nodes = externalParm1;
            SetDirty("Nodes");
         }

      }

      public String gxTpr_Description
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference.Description ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GAMMenuOptionList_externalReference.Description = value;
            SetDirty("Description");
         }

      }

      public bool gxTpr_Authorized
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference.Authorized ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GAMMenuOptionList_externalReference.Authorized = value;
            SetDirty("Authorized");
         }

      }

      public GXExternalCollection<SdtGAMDescription> gxTpr_Descriptions
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            intValue = new GXExternalCollection<SdtGAMDescription>( context, "SdtGAMDescription", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm2 ;
            externalParm2 = GAMMenuOptionList_externalReference.Descriptions;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), externalParm2);
            return intValue ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMDescription> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMDescription> externalParm3 ;
            intValue = value;
            externalParm3 = (System.Collections.Generic.List<Artech.Security.GAMDescription>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMDescription>), intValue.ExternalInstance);
            GAMMenuOptionList_externalReference.Descriptions = externalParm3;
            SetDirty("Descriptions");
         }

      }

      public GXExternalCollection<SdtGAMProperty> gxTpr_Properties
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            intValue = new GXExternalCollection<SdtGAMProperty>( context, "SdtGAMProperty", "GeneXus.Programs");
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm4 ;
            externalParm4 = GAMMenuOptionList_externalReference.Properties;
            intValue.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), externalParm4);
            return intValue ;
         }

         set {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            GXExternalCollection<SdtGAMProperty> intValue ;
            System.Collections.Generic.List<Artech.Security.GAMProperty> externalParm5 ;
            intValue = value;
            externalParm5 = (System.Collections.Generic.List<Artech.Security.GAMProperty>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMProperty>), intValue.ExternalInstance);
            GAMMenuOptionList_externalReference.Properties = externalParm5;
            SetDirty("Properties");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAMMenuOptionList_externalReference == null )
            {
               GAMMenuOptionList_externalReference = new Artech.Security.GAMMenuOptionList(context);
            }
            return GAMMenuOptionList_externalReference ;
         }

         set {
            GAMMenuOptionList_externalReference = (Artech.Security.GAMMenuOptionList)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAMMenuOptionList GAMMenuOptionList_externalReference=null ;
   }

}
