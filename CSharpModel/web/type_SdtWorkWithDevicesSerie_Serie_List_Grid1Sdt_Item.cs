/*
               File: type_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item
        Description: WorkWithDevicesSerie_Serie_List_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.98
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
   public class SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi = "";
      }

      public SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieid), 18, 0)), false);
         AddObjectProperty("SerieImagem", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem, false);
         AddObjectProperty("SerieImagem_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi, false);
         AddObjectProperty("SerieNome", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome, false);
         AddObjectProperty("GeneroNome", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome, false);
         AddObjectProperty("GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generoid), 18, 0)), false);
         AddObjectProperty("Assistido", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Assistido, false);
         AddObjectProperty("Favorito", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favorito, false);
         AddObjectProperty("Favoritar", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar, false);
         AddObjectProperty("Favoritar_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi, false);
         AddObjectProperty("Marcarassistido", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido, false);
         AddObjectProperty("Marcarassistido_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome = value;
            SetDirty("Generonome");
         }

      }

      [  SoapElement( ElementName = "GeneroId" )]
      [  XmlElement( ElementName = "GeneroId"   )]
      public long gxTpr_Generoid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generoid = value;
            SetDirty("Generoid");
         }

      }

      [  SoapElement( ElementName = "Assistido" )]
      [  XmlElement( ElementName = "Assistido"   )]
      public bool gxTpr_Assistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Assistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Assistido = value;
            SetDirty("Assistido");
         }

      }

      [  SoapElement( ElementName = "Favorito" )]
      [  XmlElement( ElementName = "Favorito"   )]
      public bool gxTpr_Favorito
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favorito ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favorito = value;
            SetDirty("Favorito");
         }

      }

      [  SoapElement( ElementName = "Favoritar" )]
      [  XmlElement( ElementName = "Favoritar"   )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar = value;
            SetDirty("Favoritar");
         }

      }

      [  SoapElement( ElementName = "Favoritar_GXI" )]
      [  XmlElement( ElementName = "Favoritar_GXI"   )]
      public String gxTpr_Favoritar_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi = value;
            SetDirty("Favoritar_gxi");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido" )]
      [  XmlElement( ElementName = "Marcarassistido"   )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido = value;
            SetDirty("Marcarassistido");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido_GXI" )]
      [  XmlElement( ElementName = "Marcarassistido_GXI"   )]
      public String gxTpr_Marcarassistido_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi = value;
            SetDirty("Marcarassistido_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieid ;
      protected long gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generoid ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Assistido ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favorito ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serienome ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Generonome ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Serieimagem ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Favoritar ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_Marcarassistido ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_List_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item psdt ) : base(psdt)
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

      [DataMember( Name = "SerieImagem" , Order = 1 )]
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

      [DataMember( Name = "SerieNome" , Order = 2 )]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "GeneroNome" , Order = 3 )]
      public String gxTpr_Generonome
      {
         get {
            return sdt.gxTpr_Generonome ;
         }

         set {
            sdt.gxTpr_Generonome = value;
         }

      }

      [DataMember( Name = "GeneroId" , Order = 4 )]
      public String gxTpr_Generoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Generoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Generoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Assistido" , Order = 5 )]
      public bool gxTpr_Assistido
      {
         get {
            return sdt.gxTpr_Assistido ;
         }

         set {
            sdt.gxTpr_Assistido = value;
         }

      }

      [DataMember( Name = "Favorito" , Order = 6 )]
      public bool gxTpr_Favorito
      {
         get {
            return sdt.gxTpr_Favorito ;
         }

         set {
            sdt.gxTpr_Favorito = value;
         }

      }

      [DataMember( Name = "Favoritar" , Order = 7 )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Favoritar)) ? PathUtil.RelativeURL( sdt.gxTpr_Favoritar) : StringUtil.RTrim( sdt.gxTpr_Favoritar_gxi)) ;
         }

         set {
            sdt.gxTpr_Favoritar = value;
         }

      }

      [DataMember( Name = "Marcarassistido" , Order = 8 )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Marcarassistido)) ? PathUtil.RelativeURL( sdt.gxTpr_Marcarassistido) : StringUtil.RTrim( sdt.gxTpr_Marcarassistido_gxi)) ;
         }

         set {
            sdt.gxTpr_Marcarassistido = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item() ;
         }
      }

   }

}
