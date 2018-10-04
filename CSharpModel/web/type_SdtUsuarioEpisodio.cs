/*
               File: type_SdtUsuarioEpisodio
        Description: Usuário episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:19.11
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
   [XmlRoot(ElementName = "UsuarioEpisodio" )]
   [XmlType(TypeName =  "UsuarioEpisodio" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtUsuarioEpisodio : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioEpisodio( )
      {
      }

      public SdtUsuarioEpisodio( IGxContext context )
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

      public void Load( long AV18UsuarioEpisodioId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV18UsuarioEpisodioId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UsuarioEpisodioId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "UsuarioEpisodio");
         metadata.Set("BT", "UsuarioEpisodio");
         metadata.Set("PK", "[ \"UsuarioEpisodioId\" ]");
         metadata.Set("PKAssigned", "[ \"UsuarioEpisodioId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"EpisodioId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UsuarioId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GxStringCollection StateAttributes( )
      {
         GxStringCollection state = new GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Usuarioepisodioid_Z");
         state.Add("gxTpr_Usuarioid_Z");
         state.Add("gxTpr_Episodioid_Z");
         state.Add("gxTpr_Usuarioepisodionota_Z");
         state.Add("gxTpr_Usuarioepisodioassistido_Z");
         state.Add("gxTpr_Usuarioepisodiocomentario_Z");
         state.Add("gxTpr_Usuarioepisodiofavorito_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtUsuarioEpisodio sdt ;
         sdt = (SdtUsuarioEpisodio)(source);
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioid = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioid ;
         gxTv_SdtUsuarioEpisodio_Usuarioid = sdt.gxTv_SdtUsuarioEpisodio_Usuarioid ;
         gxTv_SdtUsuarioEpisodio_Episodioid = sdt.gxTv_SdtUsuarioEpisodio_Episodioid ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodionota = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodionota ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito ;
         gxTv_SdtUsuarioEpisodio_Mode = sdt.gxTv_SdtUsuarioEpisodio_Mode ;
         gxTv_SdtUsuarioEpisodio_Initialized = sdt.gxTv_SdtUsuarioEpisodio_Initialized ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z ;
         gxTv_SdtUsuarioEpisodio_Usuarioid_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioid_Z ;
         gxTv_SdtUsuarioEpisodio_Episodioid_Z = sdt.gxTv_SdtUsuarioEpisodio_Episodioid_Z ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z ;
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UsuarioEpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Usuarioepisodioid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Usuarioid), 18, 0)), false);
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Episodioid), 18, 0)), false);
         AddObjectProperty("UsuarioEpisodioNota", gxTv_SdtUsuarioEpisodio_Usuarioepisodionota, false);
         AddObjectProperty("UsuarioEpisodioAssistido", gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido, false);
         AddObjectProperty("UsuarioEpisodioComentario", gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario, false);
         AddObjectProperty("UsuarioEpisodioFavorito", gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtUsuarioEpisodio_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtUsuarioEpisodio_Initialized, false);
            AddObjectProperty("UsuarioEpisodioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z), 18, 0)), false);
            AddObjectProperty("UsuarioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Usuarioid_Z), 18, 0)), false);
            AddObjectProperty("EpisodioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioEpisodio_Episodioid_Z), 18, 0)), false);
            AddObjectProperty("UsuarioEpisodioNota_Z", gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z, false);
            AddObjectProperty("UsuarioEpisodioAssistido_Z", gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z, false);
            AddObjectProperty("UsuarioEpisodioComentario_Z", gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z, false);
            AddObjectProperty("UsuarioEpisodioFavorito_Z", gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtUsuarioEpisodio sdt )
      {
         if ( sdt.IsDirty("UsuarioEpisodioId") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioid = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioid ;
         }
         if ( sdt.IsDirty("UsuarioId") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioid = sdt.gxTv_SdtUsuarioEpisodio_Usuarioid ;
         }
         if ( sdt.IsDirty("EpisodioId") )
         {
            gxTv_SdtUsuarioEpisodio_Episodioid = sdt.gxTv_SdtUsuarioEpisodio_Episodioid ;
         }
         if ( sdt.IsDirty("UsuarioEpisodioNota") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodionota = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodionota ;
         }
         if ( sdt.IsDirty("UsuarioEpisodioAssistido") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido ;
         }
         if ( sdt.IsDirty("UsuarioEpisodioComentario") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario ;
         }
         if ( sdt.IsDirty("UsuarioEpisodioFavorito") )
         {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito = sdt.gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioId" )]
      [  XmlElement( ElementName = "UsuarioEpisodioId"   )]
      public long gxTpr_Usuarioepisodioid
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodioid ;
         }

         set {
            if ( gxTv_SdtUsuarioEpisodio_Usuarioepisodioid != value )
            {
               gxTv_SdtUsuarioEpisodio_Mode = "INS";
               this.gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Usuarioid_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Episodioid_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z_SetNull( );
               this.gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z_SetNull( );
            }
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioid = value;
            SetDirty("Usuarioepisodioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioid ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Episodioid ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioEpisodioNota" )]
      [  XmlElement( ElementName = "UsuarioEpisodioNota"   )]
      public short gxTpr_Usuarioepisodionota
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodionota ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodionota = value;
            SetDirty("Usuarioepisodionota");
         }

      }

      [  SoapElement( ElementName = "UsuarioEpisodioAssistido" )]
      [  XmlElement( ElementName = "UsuarioEpisodioAssistido"   )]
      public bool gxTpr_Usuarioepisodioassistido
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido = value;
            SetDirty("Usuarioepisodioassistido");
         }

      }

      [  SoapElement( ElementName = "UsuarioEpisodioComentario" )]
      [  XmlElement( ElementName = "UsuarioEpisodioComentario"   )]
      public String gxTpr_Usuarioepisodiocomentario
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario = value;
            SetDirty("Usuarioepisodiocomentario");
         }

      }

      [  SoapElement( ElementName = "UsuarioEpisodioFavorito" )]
      [  XmlElement( ElementName = "UsuarioEpisodioFavorito"   )]
      public bool gxTpr_Usuarioepisodiofavorito
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito = value;
            SetDirty("Usuarioepisodiofavorito");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Mode ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Mode_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Mode = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Initialized ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Initialized_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioId_Z" )]
      [  XmlElement( ElementName = "UsuarioEpisodioId_Z"   )]
      public long gxTpr_Usuarioepisodioid_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z = value;
            SetDirty("Usuarioepisodioid_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioId_Z" )]
      [  XmlElement( ElementName = "UsuarioId_Z"   )]
      public long gxTpr_Usuarioid_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioid_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioid_Z = value;
            SetDirty("Usuarioid_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioid_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioId_Z" )]
      [  XmlElement( ElementName = "EpisodioId_Z"   )]
      public long gxTpr_Episodioid_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Episodioid_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Episodioid_Z = value;
            SetDirty("Episodioid_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Episodioid_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Episodioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Episodioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioNota_Z" )]
      [  XmlElement( ElementName = "UsuarioEpisodioNota_Z"   )]
      public short gxTpr_Usuarioepisodionota_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z = value;
            SetDirty("Usuarioepisodionota_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioAssistido_Z" )]
      [  XmlElement( ElementName = "UsuarioEpisodioAssistido_Z"   )]
      public bool gxTpr_Usuarioepisodioassistido_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z = value;
            SetDirty("Usuarioepisodioassistido_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z = false;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioComentario_Z" )]
      [  XmlElement( ElementName = "UsuarioEpisodioComentario_Z"   )]
      public String gxTpr_Usuarioepisodiocomentario_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z = value;
            SetDirty("Usuarioepisodiocomentario_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioEpisodioFavorito_Z" )]
      [  XmlElement( ElementName = "UsuarioEpisodioFavorito_Z"   )]
      public bool gxTpr_Usuarioepisodiofavorito_Z
      {
         get {
            return gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z ;
         }

         set {
            gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z = value;
            SetDirty("Usuarioepisodiofavorito_Z");
         }

      }

      public void gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z_SetNull( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z = false;
         return  ;
      }

      public bool gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario = "";
         gxTv_SdtUsuarioEpisodio_Mode = "";
         gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "usuarioepisodio", "GeneXus.Programs.usuarioepisodio_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtUsuarioEpisodio_Usuarioepisodionota ;
      private short gxTv_SdtUsuarioEpisodio_Initialized ;
      private short gxTv_SdtUsuarioEpisodio_Usuarioepisodionota_Z ;
      private long gxTv_SdtUsuarioEpisodio_Usuarioepisodioid ;
      private long gxTv_SdtUsuarioEpisodio_Usuarioid ;
      private long gxTv_SdtUsuarioEpisodio_Episodioid ;
      private long gxTv_SdtUsuarioEpisodio_Usuarioepisodioid_Z ;
      private long gxTv_SdtUsuarioEpisodio_Usuarioid_Z ;
      private long gxTv_SdtUsuarioEpisodio_Episodioid_Z ;
      private String gxTv_SdtUsuarioEpisodio_Mode ;
      private bool gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido ;
      private bool gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito ;
      private bool gxTv_SdtUsuarioEpisodio_Usuarioepisodioassistido_Z ;
      private bool gxTv_SdtUsuarioEpisodio_Usuarioepisodiofavorito_Z ;
      private String gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario ;
      private String gxTv_SdtUsuarioEpisodio_Usuarioepisodiocomentario_Z ;
   }

   [DataContract(Name = @"UsuarioEpisodio", Namespace = "SeriesColaborativas")]
   public class SdtUsuarioEpisodio_RESTInterface : GxGenericCollectionItem<SdtUsuarioEpisodio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioEpisodio_RESTInterface( ) : base()
      {
      }

      public SdtUsuarioEpisodio_RESTInterface( SdtUsuarioEpisodio psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioEpisodioId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Usuarioepisodioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioepisodioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioepisodioid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "EpisodioId" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Episodioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Episodioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Episodioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioEpisodioNota" , Order = 3 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Usuarioepisodionota
      {
         get {
            return sdt.gxTpr_Usuarioepisodionota ;
         }

         set {
            sdt.gxTpr_Usuarioepisodionota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UsuarioEpisodioAssistido" , Order = 4 )]
      [GxSeudo()]
      public bool gxTpr_Usuarioepisodioassistido
      {
         get {
            return sdt.gxTpr_Usuarioepisodioassistido ;
         }

         set {
            sdt.gxTpr_Usuarioepisodioassistido = value;
         }

      }

      [DataMember( Name = "UsuarioEpisodioComentario" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Usuarioepisodiocomentario
      {
         get {
            return sdt.gxTpr_Usuarioepisodiocomentario ;
         }

         set {
            sdt.gxTpr_Usuarioepisodiocomentario = value;
         }

      }

      [DataMember( Name = "UsuarioEpisodioFavorito" , Order = 6 )]
      [GxSeudo()]
      public bool gxTpr_Usuarioepisodiofavorito
      {
         get {
            return sdt.gxTpr_Usuarioepisodiofavorito ;
         }

         set {
            sdt.gxTpr_Usuarioepisodiofavorito = value;
         }

      }

      public SdtUsuarioEpisodio sdt
      {
         get {
            return (SdtUsuarioEpisodio)Sdt ;
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
            sdt = new SdtUsuarioEpisodio() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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

}
