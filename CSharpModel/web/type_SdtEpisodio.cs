/*
               File: type_SdtEpisodio
        Description: Episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:29.6
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
   [XmlRoot(ElementName = "Episodio" )]
   [XmlType(TypeName =  "Episodio" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtEpisodio : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtEpisodio( )
      {
      }

      public SdtEpisodio( IGxContext context )
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

      public void Load( long AV7EpisodioId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV7EpisodioId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"EpisodioId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Episodio");
         metadata.Set("BT", "Episodio");
         metadata.Set("PK", "[ \"EpisodioId\" ]");
         metadata.Set("PKAssigned", "[ \"EpisodioId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SerieId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Episodioid_Z");
         state.Add("gxTpr_Serieid_Z");
         state.Add("gxTpr_Serienome_Z");
         state.Add("gxTpr_Episodionome_Z");
         state.Add("gxTpr_Episodioduracao_Z");
         state.Add("gxTpr_Episodiotemporada_Z");
         state.Add("gxTpr_Episodioinativo_Z");
         state.Add("gxTpr_Episodionumero_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtEpisodio sdt ;
         sdt = (SdtEpisodio)(source);
         gxTv_SdtEpisodio_Episodioid = sdt.gxTv_SdtEpisodio_Episodioid ;
         gxTv_SdtEpisodio_Serieid = sdt.gxTv_SdtEpisodio_Serieid ;
         gxTv_SdtEpisodio_Serienome = sdt.gxTv_SdtEpisodio_Serienome ;
         gxTv_SdtEpisodio_Episodionome = sdt.gxTv_SdtEpisodio_Episodionome ;
         gxTv_SdtEpisodio_Episodioduracao = sdt.gxTv_SdtEpisodio_Episodioduracao ;
         gxTv_SdtEpisodio_Episodiosinopse = sdt.gxTv_SdtEpisodio_Episodiosinopse ;
         gxTv_SdtEpisodio_Episodiotemporada = sdt.gxTv_SdtEpisodio_Episodiotemporada ;
         gxTv_SdtEpisodio_Episodioinativo = sdt.gxTv_SdtEpisodio_Episodioinativo ;
         gxTv_SdtEpisodio_Episodionumero = sdt.gxTv_SdtEpisodio_Episodionumero ;
         gxTv_SdtEpisodio_Mode = sdt.gxTv_SdtEpisodio_Mode ;
         gxTv_SdtEpisodio_Initialized = sdt.gxTv_SdtEpisodio_Initialized ;
         gxTv_SdtEpisodio_Episodioid_Z = sdt.gxTv_SdtEpisodio_Episodioid_Z ;
         gxTv_SdtEpisodio_Serieid_Z = sdt.gxTv_SdtEpisodio_Serieid_Z ;
         gxTv_SdtEpisodio_Serienome_Z = sdt.gxTv_SdtEpisodio_Serienome_Z ;
         gxTv_SdtEpisodio_Episodionome_Z = sdt.gxTv_SdtEpisodio_Episodionome_Z ;
         gxTv_SdtEpisodio_Episodioduracao_Z = sdt.gxTv_SdtEpisodio_Episodioduracao_Z ;
         gxTv_SdtEpisodio_Episodiotemporada_Z = sdt.gxTv_SdtEpisodio_Episodiotemporada_Z ;
         gxTv_SdtEpisodio_Episodioinativo_Z = sdt.gxTv_SdtEpisodio_Episodioinativo_Z ;
         gxTv_SdtEpisodio_Episodionumero_Z = sdt.gxTv_SdtEpisodio_Episodionumero_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtEpisodio_Episodioid), 18, 0)), false);
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtEpisodio_Serieid), 18, 0)), false);
         AddObjectProperty("SerieNome", gxTv_SdtEpisodio_Serienome, false);
         AddObjectProperty("EpisodioNome", gxTv_SdtEpisodio_Episodionome, false);
         AddObjectProperty("EpisodioDuracao", gxTv_SdtEpisodio_Episodioduracao, false);
         AddObjectProperty("EpisodioSinopse", gxTv_SdtEpisodio_Episodiosinopse, false);
         AddObjectProperty("EpisodioTemporada", gxTv_SdtEpisodio_Episodiotemporada, false);
         AddObjectProperty("EpisodioInativo", gxTv_SdtEpisodio_Episodioinativo, false);
         AddObjectProperty("EpisodioNumero", gxTv_SdtEpisodio_Episodionumero, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtEpisodio_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtEpisodio_Initialized, false);
            AddObjectProperty("EpisodioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtEpisodio_Episodioid_Z), 18, 0)), false);
            AddObjectProperty("SerieId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtEpisodio_Serieid_Z), 18, 0)), false);
            AddObjectProperty("SerieNome_Z", gxTv_SdtEpisodio_Serienome_Z, false);
            AddObjectProperty("EpisodioNome_Z", gxTv_SdtEpisodio_Episodionome_Z, false);
            AddObjectProperty("EpisodioDuracao_Z", gxTv_SdtEpisodio_Episodioduracao_Z, false);
            AddObjectProperty("EpisodioTemporada_Z", gxTv_SdtEpisodio_Episodiotemporada_Z, false);
            AddObjectProperty("EpisodioInativo_Z", gxTv_SdtEpisodio_Episodioinativo_Z, false);
            AddObjectProperty("EpisodioNumero_Z", gxTv_SdtEpisodio_Episodionumero_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtEpisodio sdt )
      {
         if ( sdt.IsDirty("EpisodioId") )
         {
            gxTv_SdtEpisodio_Episodioid = sdt.gxTv_SdtEpisodio_Episodioid ;
         }
         if ( sdt.IsDirty("SerieId") )
         {
            gxTv_SdtEpisodio_Serieid = sdt.gxTv_SdtEpisodio_Serieid ;
         }
         if ( sdt.IsDirty("SerieNome") )
         {
            gxTv_SdtEpisodio_Serienome = sdt.gxTv_SdtEpisodio_Serienome ;
         }
         if ( sdt.IsDirty("EpisodioNome") )
         {
            gxTv_SdtEpisodio_Episodionome = sdt.gxTv_SdtEpisodio_Episodionome ;
         }
         if ( sdt.IsDirty("EpisodioDuracao") )
         {
            gxTv_SdtEpisodio_Episodioduracao = sdt.gxTv_SdtEpisodio_Episodioduracao ;
         }
         if ( sdt.IsDirty("EpisodioSinopse") )
         {
            gxTv_SdtEpisodio_Episodiosinopse = sdt.gxTv_SdtEpisodio_Episodiosinopse ;
         }
         if ( sdt.IsDirty("EpisodioTemporada") )
         {
            gxTv_SdtEpisodio_Episodiotemporada = sdt.gxTv_SdtEpisodio_Episodiotemporada ;
         }
         if ( sdt.IsDirty("EpisodioInativo") )
         {
            gxTv_SdtEpisodio_Episodioinativo = sdt.gxTv_SdtEpisodio_Episodioinativo ;
         }
         if ( sdt.IsDirty("EpisodioNumero") )
         {
            gxTv_SdtEpisodio_Episodionumero = sdt.gxTv_SdtEpisodio_Episodionumero ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtEpisodio_Episodioid ;
         }

         set {
            if ( gxTv_SdtEpisodio_Episodioid != value )
            {
               gxTv_SdtEpisodio_Mode = "INS";
               this.gxTv_SdtEpisodio_Episodioid_Z_SetNull( );
               this.gxTv_SdtEpisodio_Serieid_Z_SetNull( );
               this.gxTv_SdtEpisodio_Serienome_Z_SetNull( );
               this.gxTv_SdtEpisodio_Episodionome_Z_SetNull( );
               this.gxTv_SdtEpisodio_Episodioduracao_Z_SetNull( );
               this.gxTv_SdtEpisodio_Episodiotemporada_Z_SetNull( );
               this.gxTv_SdtEpisodio_Episodioinativo_Z_SetNull( );
               this.gxTv_SdtEpisodio_Episodionumero_Z_SetNull( );
            }
            gxTv_SdtEpisodio_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtEpisodio_Serieid ;
         }

         set {
            gxTv_SdtEpisodio_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtEpisodio_Serienome ;
         }

         set {
            gxTv_SdtEpisodio_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "EpisodioNome" )]
      [  XmlElement( ElementName = "EpisodioNome"   )]
      public String gxTpr_Episodionome
      {
         get {
            return gxTv_SdtEpisodio_Episodionome ;
         }

         set {
            gxTv_SdtEpisodio_Episodionome = value;
            SetDirty("Episodionome");
         }

      }

      [  SoapElement( ElementName = "EpisodioDuracao" )]
      [  XmlElement( ElementName = "EpisodioDuracao"   )]
      public short gxTpr_Episodioduracao
      {
         get {
            return gxTv_SdtEpisodio_Episodioduracao ;
         }

         set {
            gxTv_SdtEpisodio_Episodioduracao = value;
            SetDirty("Episodioduracao");
         }

      }

      [  SoapElement( ElementName = "EpisodioSinopse" )]
      [  XmlElement( ElementName = "EpisodioSinopse"   )]
      public String gxTpr_Episodiosinopse
      {
         get {
            return gxTv_SdtEpisodio_Episodiosinopse ;
         }

         set {
            gxTv_SdtEpisodio_Episodiosinopse = value;
            SetDirty("Episodiosinopse");
         }

      }

      [  SoapElement( ElementName = "EpisodioTemporada" )]
      [  XmlElement( ElementName = "EpisodioTemporada"   )]
      public short gxTpr_Episodiotemporada
      {
         get {
            return gxTv_SdtEpisodio_Episodiotemporada ;
         }

         set {
            gxTv_SdtEpisodio_Episodiotemporada = value;
            SetDirty("Episodiotemporada");
         }

      }

      [  SoapElement( ElementName = "EpisodioInativo" )]
      [  XmlElement( ElementName = "EpisodioInativo"   )]
      public bool gxTpr_Episodioinativo
      {
         get {
            return gxTv_SdtEpisodio_Episodioinativo ;
         }

         set {
            gxTv_SdtEpisodio_Episodioinativo = value;
            SetDirty("Episodioinativo");
         }

      }

      [  SoapElement( ElementName = "EpisodioNumero" )]
      [  XmlElement( ElementName = "EpisodioNumero"   )]
      public short gxTpr_Episodionumero
      {
         get {
            return gxTv_SdtEpisodio_Episodionumero ;
         }

         set {
            gxTv_SdtEpisodio_Episodionumero = value;
            SetDirty("Episodionumero");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtEpisodio_Mode ;
         }

         set {
            gxTv_SdtEpisodio_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtEpisodio_Mode_SetNull( )
      {
         gxTv_SdtEpisodio_Mode = "";
         return  ;
      }

      public bool gxTv_SdtEpisodio_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtEpisodio_Initialized ;
         }

         set {
            gxTv_SdtEpisodio_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtEpisodio_Initialized_SetNull( )
      {
         gxTv_SdtEpisodio_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioId_Z" )]
      [  XmlElement( ElementName = "EpisodioId_Z"   )]
      public long gxTpr_Episodioid_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodioid_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodioid_Z = value;
            SetDirty("Episodioid_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodioid_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieId_Z" )]
      [  XmlElement( ElementName = "SerieId_Z"   )]
      public long gxTpr_Serieid_Z
      {
         get {
            return gxTv_SdtEpisodio_Serieid_Z ;
         }

         set {
            gxTv_SdtEpisodio_Serieid_Z = value;
            SetDirty("Serieid_Z");
         }

      }

      public void gxTv_SdtEpisodio_Serieid_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Serieid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Serieid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieNome_Z" )]
      [  XmlElement( ElementName = "SerieNome_Z"   )]
      public String gxTpr_Serienome_Z
      {
         get {
            return gxTv_SdtEpisodio_Serienome_Z ;
         }

         set {
            gxTv_SdtEpisodio_Serienome_Z = value;
            SetDirty("Serienome_Z");
         }

      }

      public void gxTv_SdtEpisodio_Serienome_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Serienome_Z = "";
         return  ;
      }

      public bool gxTv_SdtEpisodio_Serienome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioNome_Z" )]
      [  XmlElement( ElementName = "EpisodioNome_Z"   )]
      public String gxTpr_Episodionome_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodionome_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodionome_Z = value;
            SetDirty("Episodionome_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodionome_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodionome_Z = "";
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodionome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioDuracao_Z" )]
      [  XmlElement( ElementName = "EpisodioDuracao_Z"   )]
      public short gxTpr_Episodioduracao_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodioduracao_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodioduracao_Z = value;
            SetDirty("Episodioduracao_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodioduracao_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodioduracao_Z = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodioduracao_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioTemporada_Z" )]
      [  XmlElement( ElementName = "EpisodioTemporada_Z"   )]
      public short gxTpr_Episodiotemporada_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodiotemporada_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodiotemporada_Z = value;
            SetDirty("Episodiotemporada_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodiotemporada_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodiotemporada_Z = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodiotemporada_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioInativo_Z" )]
      [  XmlElement( ElementName = "EpisodioInativo_Z"   )]
      public bool gxTpr_Episodioinativo_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodioinativo_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodioinativo_Z = value;
            SetDirty("Episodioinativo_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodioinativo_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodioinativo_Z = false;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodioinativo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EpisodioNumero_Z" )]
      [  XmlElement( ElementName = "EpisodioNumero_Z"   )]
      public short gxTpr_Episodionumero_Z
      {
         get {
            return gxTv_SdtEpisodio_Episodionumero_Z ;
         }

         set {
            gxTv_SdtEpisodio_Episodionumero_Z = value;
            SetDirty("Episodionumero_Z");
         }

      }

      public void gxTv_SdtEpisodio_Episodionumero_Z_SetNull( )
      {
         gxTv_SdtEpisodio_Episodionumero_Z = 0;
         return  ;
      }

      public bool gxTv_SdtEpisodio_Episodionumero_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtEpisodio_Serienome = "";
         gxTv_SdtEpisodio_Episodionome = "";
         gxTv_SdtEpisodio_Episodiosinopse = "";
         gxTv_SdtEpisodio_Mode = "";
         gxTv_SdtEpisodio_Serienome_Z = "";
         gxTv_SdtEpisodio_Episodionome_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "episodio", "GeneXus.Programs.episodio_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtEpisodio_Episodioduracao ;
      private short gxTv_SdtEpisodio_Episodiotemporada ;
      private short gxTv_SdtEpisodio_Episodionumero ;
      private short gxTv_SdtEpisodio_Initialized ;
      private short gxTv_SdtEpisodio_Episodioduracao_Z ;
      private short gxTv_SdtEpisodio_Episodiotemporada_Z ;
      private short gxTv_SdtEpisodio_Episodionumero_Z ;
      private long gxTv_SdtEpisodio_Episodioid ;
      private long gxTv_SdtEpisodio_Serieid ;
      private long gxTv_SdtEpisodio_Episodioid_Z ;
      private long gxTv_SdtEpisodio_Serieid_Z ;
      private String gxTv_SdtEpisodio_Mode ;
      private bool gxTv_SdtEpisodio_Episodioinativo ;
      private bool gxTv_SdtEpisodio_Episodioinativo_Z ;
      private String gxTv_SdtEpisodio_Episodiosinopse ;
      private String gxTv_SdtEpisodio_Serienome ;
      private String gxTv_SdtEpisodio_Episodionome ;
      private String gxTv_SdtEpisodio_Serienome_Z ;
      private String gxTv_SdtEpisodio_Episodionome_Z ;
   }

   [DataContract(Name = @"Episodio", Namespace = "SeriesColaborativas")]
   public class SdtEpisodio_RESTInterface : GxGenericCollectionItem<SdtEpisodio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtEpisodio_RESTInterface( ) : base()
      {
      }

      public SdtEpisodio_RESTInterface( SdtEpisodio psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "EpisodioId" , Order = 0 )]
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

      [DataMember( Name = "SerieId" , Order = 1 )]
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

      [DataMember( Name = "SerieNome" , Order = 2 )]
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

      [DataMember( Name = "EpisodioNome" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Episodionome
      {
         get {
            return sdt.gxTpr_Episodionome ;
         }

         set {
            sdt.gxTpr_Episodionome = value;
         }

      }

      [DataMember( Name = "EpisodioDuracao" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Episodioduracao
      {
         get {
            return sdt.gxTpr_Episodioduracao ;
         }

         set {
            sdt.gxTpr_Episodioduracao = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "EpisodioSinopse" , Order = 5 )]
      public String gxTpr_Episodiosinopse
      {
         get {
            return sdt.gxTpr_Episodiosinopse ;
         }

         set {
            sdt.gxTpr_Episodiosinopse = value;
         }

      }

      [DataMember( Name = "EpisodioTemporada" , Order = 6 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Episodiotemporada
      {
         get {
            return sdt.gxTpr_Episodiotemporada ;
         }

         set {
            sdt.gxTpr_Episodiotemporada = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "EpisodioInativo" , Order = 7 )]
      [GxSeudo()]
      public bool gxTpr_Episodioinativo
      {
         get {
            return sdt.gxTpr_Episodioinativo ;
         }

         set {
            sdt.gxTpr_Episodioinativo = value;
         }

      }

      [DataMember( Name = "EpisodioNumero" , Order = 8 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Episodionumero
      {
         get {
            return sdt.gxTpr_Episodionumero ;
         }

         set {
            sdt.gxTpr_Episodionumero = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtEpisodio sdt
      {
         get {
            return (SdtEpisodio)Sdt ;
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
            sdt = new SdtEpisodio() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 9 )]
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

   [DataContract(Name = @"Episodio", Namespace = "SeriesColaborativas")]
   public class SdtEpisodio_RESTLInterface : GxGenericCollectionItem<SdtEpisodio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtEpisodio_RESTLInterface( ) : base()
      {
      }

      public SdtEpisodio_RESTLInterface( SdtEpisodio psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "EpisodioNome" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Episodionome
      {
         get {
            return sdt.gxTpr_Episodionome ;
         }

         set {
            sdt.gxTpr_Episodionome = value;
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

      public SdtEpisodio sdt
      {
         get {
            return (SdtEpisodio)Sdt ;
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
            sdt = new SdtEpisodio() ;
         }
      }

   }

}
