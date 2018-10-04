/*
               File: type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.94
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
   [XmlRoot(ElementName = "WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome = "";
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt( IGxContext context )
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
         AddObjectProperty("UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieid), 18, 0)), false);
         AddObjectProperty("UsuarioSerieNota", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserienota, false);
         AddObjectProperty("UsuarioSerieAssistida", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieassistida, false);
         AddObjectProperty("UsuarioSerieComentario", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario, false);
         AddObjectProperty("UsuarioSerieFavorita", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriefavorita, false);
         AddObjectProperty("SerieNome", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome, false);
         AddObjectProperty("SerieImagem", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem, false);
         AddObjectProperty("SerieImagem_GXI", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi, false);
         AddObjectProperty("GeneroNome", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioSerieId" )]
      [  XmlElement( ElementName = "UsuarioSerieId"   )]
      public long gxTpr_Usuarioserieid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieid = value;
            SetDirty("Usuarioserieid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieNota" )]
      [  XmlElement( ElementName = "UsuarioSerieNota"   )]
      public short gxTpr_Usuarioserienota
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserienota ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserienota = value;
            SetDirty("Usuarioserienota");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieAssistida" )]
      [  XmlElement( ElementName = "UsuarioSerieAssistida"   )]
      public bool gxTpr_Usuarioserieassistida
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieassistida ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieassistida = value;
            SetDirty("Usuarioserieassistida");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieComentario" )]
      [  XmlElement( ElementName = "UsuarioSerieComentario"   )]
      public String gxTpr_Usuarioseriecomentario
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario = value;
            SetDirty("Usuarioseriecomentario");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieFavorita" )]
      [  XmlElement( ElementName = "UsuarioSerieFavorita"   )]
      public bool gxTpr_Usuarioseriefavorita
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriefavorita ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriefavorita = value;
            SetDirty("Usuarioseriefavorita");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome = value;
            SetDirty("Generonome");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserienota ;
      protected long gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieid ;
      protected long gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioid ;
      protected long gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieid ;
      protected bool gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioserieassistida ;
      protected bool gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriefavorita ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Usuarioseriecomentario ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serienome ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem_gxi ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Generonome ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_Serieimagem ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioSerieId" , Order = 0 )]
      public String gxTpr_Usuarioserieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioserieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioserieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioId" , Order = 1 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SerieId" , Order = 2 )]
      public String gxTpr_Serieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Serieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Serieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioSerieNota" , Order = 3 )]
      public Nullable<short> gxTpr_Usuarioserienota
      {
         get {
            return sdt.gxTpr_Usuarioserienota ;
         }

         set {
            sdt.gxTpr_Usuarioserienota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UsuarioSerieAssistida" , Order = 4 )]
      public bool gxTpr_Usuarioserieassistida
      {
         get {
            return sdt.gxTpr_Usuarioserieassistida ;
         }

         set {
            sdt.gxTpr_Usuarioserieassistida = value;
         }

      }

      [DataMember( Name = "UsuarioSerieComentario" , Order = 5 )]
      public String gxTpr_Usuarioseriecomentario
      {
         get {
            return sdt.gxTpr_Usuarioseriecomentario ;
         }

         set {
            sdt.gxTpr_Usuarioseriecomentario = value;
         }

      }

      [DataMember( Name = "UsuarioSerieFavorita" , Order = 6 )]
      public bool gxTpr_Usuarioseriefavorita
      {
         get {
            return sdt.gxTpr_Usuarioseriefavorita ;
         }

         set {
            sdt.gxTpr_Usuarioseriefavorita = value;
         }

      }

      [DataMember( Name = "SerieNome" , Order = 7 )]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "SerieImagem" , Order = 8 )]
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

      [DataMember( Name = "GeneroNome" , Order = 9 )]
      public String gxTpr_Generonome
      {
         get {
            return sdt.gxTpr_Generonome ;
         }

         set {
            sdt.gxTpr_Generonome = value;
         }

      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt() ;
         }
      }

   }

}
