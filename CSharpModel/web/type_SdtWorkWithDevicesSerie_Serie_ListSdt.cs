/*
               File: type_SdtWorkWithDevicesSerie_Serie_ListSdt
        Description: WorkWithDevicesSerie_Serie_ListSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.96
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
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "WorkWithDevicesSerie_Serie_ListSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesSerie_Serie_ListSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_ListSdt : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_ListSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesSerie_Serie_ListSdt( IGxContext context )
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

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtWorkWithDevicesSerie_Serie_ListSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_ListSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_ListSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_ListSdt_RESTInterface( SdtWorkWithDevicesSerie_Serie_ListSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Gxdynprop" , Order = 0 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_ListSdt sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_ListSdt)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtWorkWithDevicesSerie_Serie_ListSdt() ;
         }
      }

   }

}
