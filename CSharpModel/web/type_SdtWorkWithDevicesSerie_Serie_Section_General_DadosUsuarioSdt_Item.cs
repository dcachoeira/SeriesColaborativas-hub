/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item
        Description: WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 20:58:38.19
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
   public class SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi = "";
      }

      public SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item( IGxContext context )
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
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Serieid), 18, 0)), false);
         AddObjectProperty("Favoritar", gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar, false);
         AddObjectProperty("Favoritar_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi, false);
         AddObjectProperty("Marcarassistido", gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido, false);
         AddObjectProperty("Marcarassistido_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "Favoritar" )]
      [  XmlElement( ElementName = "Favoritar"   )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar = value;
            SetDirty("Favoritar");
         }

      }

      [  SoapElement( ElementName = "Favoritar_GXI" )]
      [  XmlElement( ElementName = "Favoritar_GXI"   )]
      public String gxTpr_Favoritar_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi = value;
            SetDirty("Favoritar_gxi");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido" )]
      [  XmlElement( ElementName = "Marcarassistido"   )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido = value;
            SetDirty("Marcarassistido");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido_GXI" )]
      [  XmlElement( ElementName = "Marcarassistido_GXI"   )]
      public String gxTpr_Marcarassistido_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi = value;
            SetDirty("Marcarassistido_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Serieid ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Favoritar ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_Marcarassistido ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item psdt ) : base(psdt)
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

      [DataMember( Name = "Favoritar" , Order = 1 )]
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

      [DataMember( Name = "Marcarassistido" , Order = 2 )]
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

      public SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_General_DadosUsuarioSdt_Item() ;
         }
      }

   }

}
