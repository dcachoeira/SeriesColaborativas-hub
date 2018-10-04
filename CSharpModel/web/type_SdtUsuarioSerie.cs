/*
               File: type_SdtUsuarioSerie
        Description: Usuário série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:21.60
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "UsuarioSerie" )]
   [XmlType(TypeName =  "UsuarioSerie" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtUsuarioSerie : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioSerie( )
      {
      }

      public SdtUsuarioSerie( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
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

      public void Load( long AV13UsuarioSerieId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV13UsuarioSerieId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UsuarioSerieId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "UsuarioSerie");
         metadata.Set("BT", "UsuarioSerie");
         metadata.Set("PK", "[ \"UsuarioSerieId\" ]");
         metadata.Set("PKAssigned", "[ \"UsuarioSerieId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SerieId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UsuarioId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GxStringCollection StateAttributes( )
      {
         GxStringCollection state = new GxStringCollection() ;
         state.Add("gxTpr_Serieimagem_gxi");
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Usuarioserieid_Z");
         state.Add("gxTpr_Usuarioid_Z");
         state.Add("gxTpr_Serieid_Z");
         state.Add("gxTpr_Serienome_Z");
         state.Add("gxTpr_Generonome_Z");
         state.Add("gxTpr_Usuarioserienota_Z");
         state.Add("gxTpr_Usuarioserieassistida_Z");
         state.Add("gxTpr_Usuarioseriecomentario_Z");
         state.Add("gxTpr_Usuarioseriefavorita_Z");
         state.Add("gxTpr_Serieimagem_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtUsuarioSerie sdt ;
         sdt = (SdtUsuarioSerie)(source);
         gxTv_SdtUsuarioSerie_Usuarioserieid = sdt.gxTv_SdtUsuarioSerie_Usuarioserieid ;
         gxTv_SdtUsuarioSerie_Usuarioid = sdt.gxTv_SdtUsuarioSerie_Usuarioid ;
         gxTv_SdtUsuarioSerie_Serieid = sdt.gxTv_SdtUsuarioSerie_Serieid ;
         gxTv_SdtUsuarioSerie_Serienome = sdt.gxTv_SdtUsuarioSerie_Serienome ;
         gxTv_SdtUsuarioSerie_Serieimagem = sdt.gxTv_SdtUsuarioSerie_Serieimagem ;
         gxTv_SdtUsuarioSerie_Serieimagem_gxi = sdt.gxTv_SdtUsuarioSerie_Serieimagem_gxi ;
         gxTv_SdtUsuarioSerie_Generonome = sdt.gxTv_SdtUsuarioSerie_Generonome ;
         gxTv_SdtUsuarioSerie_Usuarioserienota = sdt.gxTv_SdtUsuarioSerie_Usuarioserienota ;
         gxTv_SdtUsuarioSerie_Usuarioserieassistida = sdt.gxTv_SdtUsuarioSerie_Usuarioserieassistida ;
         gxTv_SdtUsuarioSerie_Usuarioseriecomentario = sdt.gxTv_SdtUsuarioSerie_Usuarioseriecomentario ;
         gxTv_SdtUsuarioSerie_Usuarioseriefavorita = sdt.gxTv_SdtUsuarioSerie_Usuarioseriefavorita ;
         gxTv_SdtUsuarioSerie_Mode = sdt.gxTv_SdtUsuarioSerie_Mode ;
         gxTv_SdtUsuarioSerie_Initialized = sdt.gxTv_SdtUsuarioSerie_Initialized ;
         gxTv_SdtUsuarioSerie_Usuarioserieid_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioserieid_Z ;
         gxTv_SdtUsuarioSerie_Usuarioid_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioid_Z ;
         gxTv_SdtUsuarioSerie_Serieid_Z = sdt.gxTv_SdtUsuarioSerie_Serieid_Z ;
         gxTv_SdtUsuarioSerie_Serienome_Z = sdt.gxTv_SdtUsuarioSerie_Serienome_Z ;
         gxTv_SdtUsuarioSerie_Generonome_Z = sdt.gxTv_SdtUsuarioSerie_Generonome_Z ;
         gxTv_SdtUsuarioSerie_Usuarioserienota_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioserienota_Z ;
         gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z ;
         gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z ;
         gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z = sdt.gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z ;
         gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z = sdt.gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Usuarioserieid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Usuarioid), 18, 0)), false);
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Serieid), 18, 0)), false);
         AddObjectProperty("SerieNome", gxTv_SdtUsuarioSerie_Serienome, false);
         AddObjectProperty("SerieImagem", gxTv_SdtUsuarioSerie_Serieimagem, false);
         AddObjectProperty("GeneroNome", gxTv_SdtUsuarioSerie_Generonome, false);
         AddObjectProperty("UsuarioSerieNota", gxTv_SdtUsuarioSerie_Usuarioserienota, false);
         AddObjectProperty("UsuarioSerieAssistida", gxTv_SdtUsuarioSerie_Usuarioserieassistida, false);
         AddObjectProperty("UsuarioSerieComentario", gxTv_SdtUsuarioSerie_Usuarioseriecomentario, false);
         AddObjectProperty("UsuarioSerieFavorita", gxTv_SdtUsuarioSerie_Usuarioseriefavorita, false);
         if ( includeState )
         {
            AddObjectProperty("SerieImagem_GXI", gxTv_SdtUsuarioSerie_Serieimagem_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtUsuarioSerie_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtUsuarioSerie_Initialized, false);
            AddObjectProperty("UsuarioSerieId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Usuarioserieid_Z), 18, 0)), false);
            AddObjectProperty("UsuarioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Usuarioid_Z), 18, 0)), false);
            AddObjectProperty("SerieId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioSerie_Serieid_Z), 18, 0)), false);
            AddObjectProperty("SerieNome_Z", gxTv_SdtUsuarioSerie_Serienome_Z, false);
            AddObjectProperty("GeneroNome_Z", gxTv_SdtUsuarioSerie_Generonome_Z, false);
            AddObjectProperty("UsuarioSerieNota_Z", gxTv_SdtUsuarioSerie_Usuarioserienota_Z, false);
            AddObjectProperty("UsuarioSerieAssistida_Z", gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z, false);
            AddObjectProperty("UsuarioSerieComentario_Z", gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z, false);
            AddObjectProperty("UsuarioSerieFavorita_Z", gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z, false);
            AddObjectProperty("SerieImagem_GXI_Z", gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtUsuarioSerie sdt )
      {
         if ( sdt.IsDirty("UsuarioSerieId") )
         {
            gxTv_SdtUsuarioSerie_Usuarioserieid = sdt.gxTv_SdtUsuarioSerie_Usuarioserieid ;
         }
         if ( sdt.IsDirty("UsuarioId") )
         {
            gxTv_SdtUsuarioSerie_Usuarioid = sdt.gxTv_SdtUsuarioSerie_Usuarioid ;
         }
         if ( sdt.IsDirty("SerieId") )
         {
            gxTv_SdtUsuarioSerie_Serieid = sdt.gxTv_SdtUsuarioSerie_Serieid ;
         }
         if ( sdt.IsDirty("SerieNome") )
         {
            gxTv_SdtUsuarioSerie_Serienome = sdt.gxTv_SdtUsuarioSerie_Serienome ;
         }
         if ( sdt.IsDirty("SerieImagem") )
         {
            gxTv_SdtUsuarioSerie_Serieimagem = sdt.gxTv_SdtUsuarioSerie_Serieimagem ;
         }
         if ( sdt.IsDirty("SerieImagem") )
         {
            gxTv_SdtUsuarioSerie_Serieimagem_gxi = sdt.gxTv_SdtUsuarioSerie_Serieimagem_gxi ;
         }
         if ( sdt.IsDirty("GeneroNome") )
         {
            gxTv_SdtUsuarioSerie_Generonome = sdt.gxTv_SdtUsuarioSerie_Generonome ;
         }
         if ( sdt.IsDirty("UsuarioSerieNota") )
         {
            gxTv_SdtUsuarioSerie_Usuarioserienota = sdt.gxTv_SdtUsuarioSerie_Usuarioserienota ;
         }
         if ( sdt.IsDirty("UsuarioSerieAssistida") )
         {
            gxTv_SdtUsuarioSerie_Usuarioserieassistida = sdt.gxTv_SdtUsuarioSerie_Usuarioserieassistida ;
         }
         if ( sdt.IsDirty("UsuarioSerieComentario") )
         {
            gxTv_SdtUsuarioSerie_Usuarioseriecomentario = sdt.gxTv_SdtUsuarioSerie_Usuarioseriecomentario ;
         }
         if ( sdt.IsDirty("UsuarioSerieFavorita") )
         {
            gxTv_SdtUsuarioSerie_Usuarioseriefavorita = sdt.gxTv_SdtUsuarioSerie_Usuarioseriefavorita ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioSerieId" )]
      [  XmlElement( ElementName = "UsuarioSerieId"   )]
      public long gxTpr_Usuarioserieid
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserieid ;
         }

         set {
            if ( gxTv_SdtUsuarioSerie_Usuarioserieid != value )
            {
               gxTv_SdtUsuarioSerie_Mode = "INS";
               this.gxTv_SdtUsuarioSerie_Usuarioserieid_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Usuarioid_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Serieid_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Serienome_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Generonome_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Usuarioserienota_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z_SetNull( );
               this.gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z_SetNull( );
            }
            gxTv_SdtUsuarioSerie_Usuarioserieid = value;
            SetDirty("Usuarioserieid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioid ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtUsuarioSerie_Serieid ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtUsuarioSerie_Serienome ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtUsuarioSerie_Serieimagem ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtUsuarioSerie_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtUsuarioSerie_Generonome ;
         }

         set {
            gxTv_SdtUsuarioSerie_Generonome = value;
            SetDirty("Generonome");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieNota" )]
      [  XmlElement( ElementName = "UsuarioSerieNota"   )]
      public short gxTpr_Usuarioserienota
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserienota ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioserienota = value;
            SetDirty("Usuarioserienota");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieAssistida" )]
      [  XmlElement( ElementName = "UsuarioSerieAssistida"   )]
      public bool gxTpr_Usuarioserieassistida
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserieassistida ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioserieassistida = value;
            SetDirty("Usuarioserieassistida");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieComentario" )]
      [  XmlElement( ElementName = "UsuarioSerieComentario"   )]
      public String gxTpr_Usuarioseriecomentario
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioseriecomentario ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioseriecomentario = value;
            SetDirty("Usuarioseriecomentario");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieFavorita" )]
      [  XmlElement( ElementName = "UsuarioSerieFavorita"   )]
      public bool gxTpr_Usuarioseriefavorita
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioseriefavorita ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioseriefavorita = value;
            SetDirty("Usuarioseriefavorita");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtUsuarioSerie_Mode ;
         }

         set {
            gxTv_SdtUsuarioSerie_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtUsuarioSerie_Mode_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Mode = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtUsuarioSerie_Initialized ;
         }

         set {
            gxTv_SdtUsuarioSerie_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtUsuarioSerie_Initialized_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioSerieId_Z" )]
      [  XmlElement( ElementName = "UsuarioSerieId_Z"   )]
      public long gxTpr_Usuarioserieid_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserieid_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioserieid_Z = value;
            SetDirty("Usuarioserieid_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioserieid_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioserieid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioserieid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioId_Z" )]
      [  XmlElement( ElementName = "UsuarioId_Z"   )]
      public long gxTpr_Usuarioid_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioid_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioid_Z = value;
            SetDirty("Usuarioid_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioid_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieId_Z" )]
      [  XmlElement( ElementName = "SerieId_Z"   )]
      public long gxTpr_Serieid_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Serieid_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serieid_Z = value;
            SetDirty("Serieid_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Serieid_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Serieid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Serieid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieNome_Z" )]
      [  XmlElement( ElementName = "SerieNome_Z"   )]
      public String gxTpr_Serienome_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Serienome_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serienome_Z = value;
            SetDirty("Serienome_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Serienome_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Serienome_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Serienome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GeneroNome_Z" )]
      [  XmlElement( ElementName = "GeneroNome_Z"   )]
      public String gxTpr_Generonome_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Generonome_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Generonome_Z = value;
            SetDirty("Generonome_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Generonome_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Generonome_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Generonome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioSerieNota_Z" )]
      [  XmlElement( ElementName = "UsuarioSerieNota_Z"   )]
      public short gxTpr_Usuarioserienota_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserienota_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioserienota_Z = value;
            SetDirty("Usuarioserienota_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioserienota_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioserienota_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioserienota_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioSerieAssistida_Z" )]
      [  XmlElement( ElementName = "UsuarioSerieAssistida_Z"   )]
      public bool gxTpr_Usuarioserieassistida_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z = value;
            SetDirty("Usuarioserieassistida_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z = false;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioSerieComentario_Z" )]
      [  XmlElement( ElementName = "UsuarioSerieComentario_Z"   )]
      public String gxTpr_Usuarioseriecomentario_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z = value;
            SetDirty("Usuarioseriecomentario_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioSerieFavorita_Z" )]
      [  XmlElement( ElementName = "UsuarioSerieFavorita_Z"   )]
      public bool gxTpr_Usuarioseriefavorita_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z = value;
            SetDirty("Usuarioseriefavorita_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z = false;
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieImagem_GXI_Z" )]
      [  XmlElement( ElementName = "SerieImagem_GXI_Z"   )]
      public String gxTpr_Serieimagem_gxi_Z
      {
         get {
            return gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z ;
         }

         set {
            gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z = value;
            SetDirty("Serieimagem_gxi_Z");
         }

      }

      public void gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z_SetNull( )
      {
         gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtUsuarioSerie_Serienome = "";
         gxTv_SdtUsuarioSerie_Serieimagem = "";
         gxTv_SdtUsuarioSerie_Serieimagem_gxi = "";
         gxTv_SdtUsuarioSerie_Generonome = "";
         gxTv_SdtUsuarioSerie_Usuarioseriecomentario = "";
         gxTv_SdtUsuarioSerie_Mode = "";
         gxTv_SdtUsuarioSerie_Serienome_Z = "";
         gxTv_SdtUsuarioSerie_Generonome_Z = "";
         gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z = "";
         gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "usuarioserie", "GeneXus.Programs.usuarioserie_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtUsuarioSerie_Usuarioserienota ;
      private short gxTv_SdtUsuarioSerie_Initialized ;
      private short gxTv_SdtUsuarioSerie_Usuarioserienota_Z ;
      private long gxTv_SdtUsuarioSerie_Usuarioserieid ;
      private long gxTv_SdtUsuarioSerie_Usuarioid ;
      private long gxTv_SdtUsuarioSerie_Serieid ;
      private long gxTv_SdtUsuarioSerie_Usuarioserieid_Z ;
      private long gxTv_SdtUsuarioSerie_Usuarioid_Z ;
      private long gxTv_SdtUsuarioSerie_Serieid_Z ;
      private String gxTv_SdtUsuarioSerie_Mode ;
      private bool gxTv_SdtUsuarioSerie_Usuarioserieassistida ;
      private bool gxTv_SdtUsuarioSerie_Usuarioseriefavorita ;
      private bool gxTv_SdtUsuarioSerie_Usuarioserieassistida_Z ;
      private bool gxTv_SdtUsuarioSerie_Usuarioseriefavorita_Z ;
      private String gxTv_SdtUsuarioSerie_Serienome ;
      private String gxTv_SdtUsuarioSerie_Serieimagem_gxi ;
      private String gxTv_SdtUsuarioSerie_Generonome ;
      private String gxTv_SdtUsuarioSerie_Usuarioseriecomentario ;
      private String gxTv_SdtUsuarioSerie_Serienome_Z ;
      private String gxTv_SdtUsuarioSerie_Generonome_Z ;
      private String gxTv_SdtUsuarioSerie_Usuarioseriecomentario_Z ;
      private String gxTv_SdtUsuarioSerie_Serieimagem_gxi_Z ;
      private String gxTv_SdtUsuarioSerie_Serieimagem ;
   }

   [DataContract(Name = @"UsuarioSerie", Namespace = "SeriesColaborativas")]
   public class SdtUsuarioSerie_RESTInterface : GxGenericCollectionItem<SdtUsuarioSerie>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioSerie_RESTInterface( ) : base()
      {
      }

      public SdtUsuarioSerie_RESTInterface( SdtUsuarioSerie psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioSerieId" , Order = 0 )]
      [GxSeudo()]
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
      [GxSeudo()]
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
      [GxSeudo()]
      public String gxTpr_Serieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Serieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Serieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SerieNome" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "SerieImagem" , Order = 4 )]
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

      [DataMember( Name = "GeneroNome" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Generonome
      {
         get {
            return sdt.gxTpr_Generonome ;
         }

         set {
            sdt.gxTpr_Generonome = value;
         }

      }

      [DataMember( Name = "UsuarioSerieNota" , Order = 6 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Usuarioserienota
      {
         get {
            return sdt.gxTpr_Usuarioserienota ;
         }

         set {
            sdt.gxTpr_Usuarioserienota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UsuarioSerieAssistida" , Order = 7 )]
      [GxSeudo()]
      public bool gxTpr_Usuarioserieassistida
      {
         get {
            return sdt.gxTpr_Usuarioserieassistida ;
         }

         set {
            sdt.gxTpr_Usuarioserieassistida = value;
         }

      }

      [DataMember( Name = "UsuarioSerieComentario" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Usuarioseriecomentario
      {
         get {
            return sdt.gxTpr_Usuarioseriecomentario ;
         }

         set {
            sdt.gxTpr_Usuarioseriecomentario = value;
         }

      }

      [DataMember( Name = "UsuarioSerieFavorita" , Order = 9 )]
      [GxSeudo()]
      public bool gxTpr_Usuarioseriefavorita
      {
         get {
            return sdt.gxTpr_Usuarioseriefavorita ;
         }

         set {
            sdt.gxTpr_Usuarioseriefavorita = value;
         }

      }

      public SdtUsuarioSerie sdt
      {
         get {
            return (SdtUsuarioSerie)Sdt ;
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
            sdt = new SdtUsuarioSerie() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 10 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

   [DataContract(Name = @"UsuarioSerie", Namespace = "SeriesColaborativas")]
   public class SdtUsuarioSerie_RESTLInterface : GxGenericCollectionItem<SdtUsuarioSerie>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioSerie_RESTLInterface( ) : base()
      {
      }

      public SdtUsuarioSerie_RESTLInterface( SdtUsuarioSerie psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioSerieNota" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Usuarioserienota
      {
         get {
            return sdt.gxTpr_Usuarioserienota ;
         }

         set {
            sdt.gxTpr_Usuarioserienota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtUsuarioSerie sdt
      {
         get {
            return (SdtUsuarioSerie)Sdt ;
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
            sdt = new SdtUsuarioSerie() ;
         }
      }

   }

}
