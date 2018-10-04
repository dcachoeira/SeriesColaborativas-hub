/*
               File: type_SdtSDSeries_Level_Detail_GridSeriesSdt_Item
        Description: SDSeries_Level_Detail_GridSeriesSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 20:57:32.13
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
   [XmlRoot(ElementName = "Item" )]
   [XmlType(TypeName =  "Item" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDSeries_Level_Detail_GridSeriesSdt_Item : GxUserType
   {
      public SdtSDSeries_Level_Detail_GridSeriesSdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem = "";
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi = "";
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop = "";
      }

      public SdtSDSeries_Level_Detail_GridSeriesSdt_Item( IGxContext context )
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
         AddObjectProperty("Serieid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieid), 18, 0)), false);
         AddObjectProperty("Serieimagem", gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem, false);
         AddObjectProperty("Serieimagem_GXI", gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Serieid" )]
      [  XmlElement( ElementName = "Serieid"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieid ;
         }

         set {
            gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "Serieimagem" )]
      [  XmlElement( ElementName = "Serieimagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem ;
         }

         set {
            gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "Serieimagem_GXI" )]
      [  XmlElement( ElementName = "Serieimagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem = "";
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi = "";
         gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop = "";
         return  ;
      }

      protected long gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieid ;
      protected String gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Gxdynprop ;
      protected String gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem_gxi ;
      protected String gxTv_SdtSDSeries_Level_Detail_GridSeriesSdt_Item_Serieimagem ;
   }

   [DataContract(Name = @"SDSeries_Level_Detail_GridSeriesSdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDSeries_Level_Detail_GridSeriesSdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDSeries_Level_Detail_GridSeriesSdt_Item_RESTInterface( SdtSDSeries_Level_Detail_GridSeriesSdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Serieid" , Order = 0 )]
      public String gxTpr_Serieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Serieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Serieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Serieimagem" , Order = 1 )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Serieimagem)) ? PathUtil.RelativeURL( sdt.gxTpr_Serieimagem) : StringUtil.RTrim( sdt.gxTpr_Serieimagem_gxi)) ;
         }

         set {
            sdt.gxTpr_Serieimagem = value;
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 2 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSDSeries_Level_Detail_GridSeriesSdt_Item sdt
      {
         get {
            return (SdtSDSeries_Level_Detail_GridSeriesSdt_Item)Sdt ;
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
            sdt = new SdtSDSeries_Level_Detail_GridSeriesSdt_Item() ;
         }
      }

   }

}
