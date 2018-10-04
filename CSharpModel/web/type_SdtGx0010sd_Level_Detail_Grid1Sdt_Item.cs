/*
               File: type_SdtGx0010sd_Level_Detail_Grid1Sdt_Item
        Description: Gx0010sd_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.46
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
   public class SdtGx0010sd_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtGx0010sd_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome = "";
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem = "";
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi = "";
      }

      public SdtGx0010sd_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieid), 18, 0)), false);
         AddObjectProperty("SerieNome", gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome, false);
         AddObjectProperty("SerieImagem", gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem, false);
         AddObjectProperty("SerieImagem_GXI", gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieid ;
         }

         set {
            gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome ;
         }

         set {
            gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem ;
         }

         set {
            gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome = "";
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem = "";
         gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi = "";
         return  ;
      }

      protected long gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieid ;
      protected String gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serienome ;
      protected String gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem_gxi ;
      protected String gxTv_SdtGx0010sd_Level_Detail_Grid1Sdt_Item_Serieimagem ;
   }

   [DataContract(Name = @"Gx0010sd_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtGx0010sd_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtGx0010sd_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtGx0010sd_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SerieId" , Order = 0 )]
      public String gxTpr_Serieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Serieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Serieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SerieNome" , Order = 1 )]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "SerieImagem" , Order = 2 )]
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

      public SdtGx0010sd_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtGx0010sd_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtGx0010sd_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
