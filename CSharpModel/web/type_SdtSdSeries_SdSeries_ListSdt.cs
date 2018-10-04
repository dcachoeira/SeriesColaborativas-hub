/*
               File: type_SdtSdSeries_SdSeries_ListSdt
        Description: SdSeries_SdSeries_ListSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.67
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
   [XmlRoot(ElementName = "SdSeries_SdSeries_ListSdt" )]
   [XmlType(TypeName =  "SdSeries_SdSeries_ListSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSdSeries_SdSeries_ListSdt : GxUserType
   {
      public SdtSdSeries_SdSeries_ListSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop = "";
      }

      public SdtSdSeries_SdSeries_ListSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtSdSeries_SdSeries_ListSdt_Gxdynprop ;
   }

   [DataContract(Name = @"SdSeries_SdSeries_ListSdt", Namespace = "http://tempuri.org/")]
   public class SdtSdSeries_SdSeries_ListSdt_RESTInterface : GxGenericCollectionItem<SdtSdSeries_SdSeries_ListSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSdSeries_SdSeries_ListSdt_RESTInterface( ) : base()
      {
      }

      public SdtSdSeries_SdSeries_ListSdt_RESTInterface( SdtSdSeries_SdSeries_ListSdt psdt ) : base(psdt)
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

      public SdtSdSeries_SdSeries_ListSdt sdt
      {
         get {
            return (SdtSdSeries_SdSeries_ListSdt)Sdt ;
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
            sdt = new SdtSdSeries_SdSeries_ListSdt() ;
         }
      }

   }

}
