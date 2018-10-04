/*
               File: type_SdtSerie
        Description: Série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:13.90
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
   [XmlRoot(ElementName = "Serie" )]
   [XmlType(TypeName =  "Serie" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtSerie : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSerie( )
      {
      }

      public SdtSerie( IGxContext context )
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

      public void Load( long AV1SerieId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV1SerieId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SerieId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Serie");
         metadata.Set("BT", "Serie");
         metadata.Set("PK", "[ \"SerieId\" ]");
         metadata.Set("PKAssigned", "[ \"SerieId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"GeneroId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Serieid_Z");
         state.Add("gxTpr_Serienome_Z");
         state.Add("gxTpr_Seriequantidadetemporadas_Z");
         state.Add("gxTpr_Generoid_Z");
         state.Add("gxTpr_Generonome_Z");
         state.Add("gxTpr_Serieinativo_Z");
         state.Add("gxTpr_Seriedatahoracadastro_Z_Nullable");
         state.Add("gxTpr_Serieimagem_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSerie sdt ;
         sdt = (SdtSerie)(source);
         gxTv_SdtSerie_Serieid = sdt.gxTv_SdtSerie_Serieid ;
         gxTv_SdtSerie_Serienome = sdt.gxTv_SdtSerie_Serienome ;
         gxTv_SdtSerie_Seriequantidadetemporadas = sdt.gxTv_SdtSerie_Seriequantidadetemporadas ;
         gxTv_SdtSerie_Generoid = sdt.gxTv_SdtSerie_Generoid ;
         gxTv_SdtSerie_Generonome = sdt.gxTv_SdtSerie_Generonome ;
         gxTv_SdtSerie_Serieresumo = sdt.gxTv_SdtSerie_Serieresumo ;
         gxTv_SdtSerie_Serieimagem = sdt.gxTv_SdtSerie_Serieimagem ;
         gxTv_SdtSerie_Serieimagem_gxi = sdt.gxTv_SdtSerie_Serieimagem_gxi ;
         gxTv_SdtSerie_Serieinativo = sdt.gxTv_SdtSerie_Serieinativo ;
         gxTv_SdtSerie_Seriedatahoracadastro = sdt.gxTv_SdtSerie_Seriedatahoracadastro ;
         gxTv_SdtSerie_Mode = sdt.gxTv_SdtSerie_Mode ;
         gxTv_SdtSerie_Initialized = sdt.gxTv_SdtSerie_Initialized ;
         gxTv_SdtSerie_Serieid_Z = sdt.gxTv_SdtSerie_Serieid_Z ;
         gxTv_SdtSerie_Serienome_Z = sdt.gxTv_SdtSerie_Serienome_Z ;
         gxTv_SdtSerie_Seriequantidadetemporadas_Z = sdt.gxTv_SdtSerie_Seriequantidadetemporadas_Z ;
         gxTv_SdtSerie_Generoid_Z = sdt.gxTv_SdtSerie_Generoid_Z ;
         gxTv_SdtSerie_Generonome_Z = sdt.gxTv_SdtSerie_Generonome_Z ;
         gxTv_SdtSerie_Serieinativo_Z = sdt.gxTv_SdtSerie_Serieinativo_Z ;
         gxTv_SdtSerie_Seriedatahoracadastro_Z = sdt.gxTv_SdtSerie_Seriedatahoracadastro_Z ;
         gxTv_SdtSerie_Serieimagem_gxi_Z = sdt.gxTv_SdtSerie_Serieimagem_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSerie_Serieid), 18, 0)), false);
         AddObjectProperty("SerieNome", gxTv_SdtSerie_Serienome, false);
         AddObjectProperty("SerieQuantidadeTemporadas", gxTv_SdtSerie_Seriequantidadetemporadas, false);
         AddObjectProperty("GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSerie_Generoid), 18, 0)), false);
         AddObjectProperty("GeneroNome", gxTv_SdtSerie_Generonome, false);
         AddObjectProperty("SerieResumo", gxTv_SdtSerie_Serieresumo, false);
         AddObjectProperty("SerieImagem", gxTv_SdtSerie_Serieimagem, false);
         AddObjectProperty("SerieInativo", gxTv_SdtSerie_Serieinativo, false);
         datetime_STZ = gxTv_SdtSerie_Seriedatahoracadastro;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("SerieDataHoraCadastro", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("SerieImagem_GXI", gxTv_SdtSerie_Serieimagem_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtSerie_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSerie_Initialized, false);
            AddObjectProperty("SerieId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSerie_Serieid_Z), 18, 0)), false);
            AddObjectProperty("SerieNome_Z", gxTv_SdtSerie_Serienome_Z, false);
            AddObjectProperty("SerieQuantidadeTemporadas_Z", gxTv_SdtSerie_Seriequantidadetemporadas_Z, false);
            AddObjectProperty("GeneroId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSerie_Generoid_Z), 18, 0)), false);
            AddObjectProperty("GeneroNome_Z", gxTv_SdtSerie_Generonome_Z, false);
            AddObjectProperty("SerieInativo_Z", gxTv_SdtSerie_Serieinativo_Z, false);
            datetime_STZ = gxTv_SdtSerie_Seriedatahoracadastro_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("SerieDataHoraCadastro_Z", sDateCnv, false);
            AddObjectProperty("SerieImagem_GXI_Z", gxTv_SdtSerie_Serieimagem_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSerie sdt )
      {
         if ( sdt.IsDirty("SerieId") )
         {
            gxTv_SdtSerie_Serieid = sdt.gxTv_SdtSerie_Serieid ;
         }
         if ( sdt.IsDirty("SerieNome") )
         {
            gxTv_SdtSerie_Serienome = sdt.gxTv_SdtSerie_Serienome ;
         }
         if ( sdt.IsDirty("SerieQuantidadeTemporadas") )
         {
            gxTv_SdtSerie_Seriequantidadetemporadas = sdt.gxTv_SdtSerie_Seriequantidadetemporadas ;
         }
         if ( sdt.IsDirty("GeneroId") )
         {
            gxTv_SdtSerie_Generoid = sdt.gxTv_SdtSerie_Generoid ;
         }
         if ( sdt.IsDirty("GeneroNome") )
         {
            gxTv_SdtSerie_Generonome = sdt.gxTv_SdtSerie_Generonome ;
         }
         if ( sdt.IsDirty("SerieResumo") )
         {
            gxTv_SdtSerie_Serieresumo = sdt.gxTv_SdtSerie_Serieresumo ;
         }
         if ( sdt.IsDirty("SerieImagem") )
         {
            gxTv_SdtSerie_Serieimagem = sdt.gxTv_SdtSerie_Serieimagem ;
         }
         if ( sdt.IsDirty("SerieImagem") )
         {
            gxTv_SdtSerie_Serieimagem_gxi = sdt.gxTv_SdtSerie_Serieimagem_gxi ;
         }
         if ( sdt.IsDirty("SerieInativo") )
         {
            gxTv_SdtSerie_Serieinativo = sdt.gxTv_SdtSerie_Serieinativo ;
         }
         if ( sdt.IsDirty("SerieDataHoraCadastro") )
         {
            gxTv_SdtSerie_Seriedatahoracadastro = sdt.gxTv_SdtSerie_Seriedatahoracadastro ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtSerie_Serieid ;
         }

         set {
            if ( gxTv_SdtSerie_Serieid != value )
            {
               gxTv_SdtSerie_Mode = "INS";
               this.gxTv_SdtSerie_Serieid_Z_SetNull( );
               this.gxTv_SdtSerie_Serienome_Z_SetNull( );
               this.gxTv_SdtSerie_Seriequantidadetemporadas_Z_SetNull( );
               this.gxTv_SdtSerie_Generoid_Z_SetNull( );
               this.gxTv_SdtSerie_Generonome_Z_SetNull( );
               this.gxTv_SdtSerie_Serieinativo_Z_SetNull( );
               this.gxTv_SdtSerie_Seriedatahoracadastro_Z_SetNull( );
               this.gxTv_SdtSerie_Serieimagem_gxi_Z_SetNull( );
            }
            gxTv_SdtSerie_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtSerie_Serienome ;
         }

         set {
            gxTv_SdtSerie_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "SerieQuantidadeTemporadas" )]
      [  XmlElement( ElementName = "SerieQuantidadeTemporadas"   )]
      public short gxTpr_Seriequantidadetemporadas
      {
         get {
            return gxTv_SdtSerie_Seriequantidadetemporadas ;
         }

         set {
            gxTv_SdtSerie_Seriequantidadetemporadas = value;
            SetDirty("Seriequantidadetemporadas");
         }

      }

      [  SoapElement( ElementName = "GeneroId" )]
      [  XmlElement( ElementName = "GeneroId"   )]
      public long gxTpr_Generoid
      {
         get {
            return gxTv_SdtSerie_Generoid ;
         }

         set {
            gxTv_SdtSerie_Generoid = value;
            SetDirty("Generoid");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtSerie_Generonome ;
         }

         set {
            gxTv_SdtSerie_Generonome = value;
            SetDirty("Generonome");
         }

      }

      [  SoapElement( ElementName = "SerieResumo" )]
      [  XmlElement( ElementName = "SerieResumo"   )]
      public String gxTpr_Serieresumo
      {
         get {
            return gxTv_SdtSerie_Serieresumo ;
         }

         set {
            gxTv_SdtSerie_Serieresumo = value;
            SetDirty("Serieresumo");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtSerie_Serieimagem ;
         }

         set {
            gxTv_SdtSerie_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtSerie_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtSerie_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "SerieInativo" )]
      [  XmlElement( ElementName = "SerieInativo"   )]
      public bool gxTpr_Serieinativo
      {
         get {
            return gxTv_SdtSerie_Serieinativo ;
         }

         set {
            gxTv_SdtSerie_Serieinativo = value;
            SetDirty("Serieinativo");
         }

      }

      [  SoapElement( ElementName = "SerieDataHoraCadastro" )]
      [  XmlElement( ElementName = "SerieDataHoraCadastro"  , IsNullable=true )]
      public string gxTpr_Seriedatahoracadastro_Nullable
      {
         get {
            if ( gxTv_SdtSerie_Seriedatahoracadastro == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSerie_Seriedatahoracadastro).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSerie_Seriedatahoracadastro = DateTime.MinValue;
            else
               gxTv_SdtSerie_Seriedatahoracadastro = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Seriedatahoracadastro
      {
         get {
            return gxTv_SdtSerie_Seriedatahoracadastro ;
         }

         set {
            gxTv_SdtSerie_Seriedatahoracadastro = value;
            SetDirty("Seriedatahoracadastro");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSerie_Mode ;
         }

         set {
            gxTv_SdtSerie_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSerie_Mode_SetNull( )
      {
         gxTv_SdtSerie_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSerie_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSerie_Initialized ;
         }

         set {
            gxTv_SdtSerie_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSerie_Initialized_SetNull( )
      {
         gxTv_SdtSerie_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSerie_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieId_Z" )]
      [  XmlElement( ElementName = "SerieId_Z"   )]
      public long gxTpr_Serieid_Z
      {
         get {
            return gxTv_SdtSerie_Serieid_Z ;
         }

         set {
            gxTv_SdtSerie_Serieid_Z = value;
            SetDirty("Serieid_Z");
         }

      }

      public void gxTv_SdtSerie_Serieid_Z_SetNull( )
      {
         gxTv_SdtSerie_Serieid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSerie_Serieid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieNome_Z" )]
      [  XmlElement( ElementName = "SerieNome_Z"   )]
      public String gxTpr_Serienome_Z
      {
         get {
            return gxTv_SdtSerie_Serienome_Z ;
         }

         set {
            gxTv_SdtSerie_Serienome_Z = value;
            SetDirty("Serienome_Z");
         }

      }

      public void gxTv_SdtSerie_Serienome_Z_SetNull( )
      {
         gxTv_SdtSerie_Serienome_Z = "";
         return  ;
      }

      public bool gxTv_SdtSerie_Serienome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieQuantidadeTemporadas_Z" )]
      [  XmlElement( ElementName = "SerieQuantidadeTemporadas_Z"   )]
      public short gxTpr_Seriequantidadetemporadas_Z
      {
         get {
            return gxTv_SdtSerie_Seriequantidadetemporadas_Z ;
         }

         set {
            gxTv_SdtSerie_Seriequantidadetemporadas_Z = value;
            SetDirty("Seriequantidadetemporadas_Z");
         }

      }

      public void gxTv_SdtSerie_Seriequantidadetemporadas_Z_SetNull( )
      {
         gxTv_SdtSerie_Seriequantidadetemporadas_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSerie_Seriequantidadetemporadas_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GeneroId_Z" )]
      [  XmlElement( ElementName = "GeneroId_Z"   )]
      public long gxTpr_Generoid_Z
      {
         get {
            return gxTv_SdtSerie_Generoid_Z ;
         }

         set {
            gxTv_SdtSerie_Generoid_Z = value;
            SetDirty("Generoid_Z");
         }

      }

      public void gxTv_SdtSerie_Generoid_Z_SetNull( )
      {
         gxTv_SdtSerie_Generoid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSerie_Generoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "GeneroNome_Z" )]
      [  XmlElement( ElementName = "GeneroNome_Z"   )]
      public String gxTpr_Generonome_Z
      {
         get {
            return gxTv_SdtSerie_Generonome_Z ;
         }

         set {
            gxTv_SdtSerie_Generonome_Z = value;
            SetDirty("Generonome_Z");
         }

      }

      public void gxTv_SdtSerie_Generonome_Z_SetNull( )
      {
         gxTv_SdtSerie_Generonome_Z = "";
         return  ;
      }

      public bool gxTv_SdtSerie_Generonome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieInativo_Z" )]
      [  XmlElement( ElementName = "SerieInativo_Z"   )]
      public bool gxTpr_Serieinativo_Z
      {
         get {
            return gxTv_SdtSerie_Serieinativo_Z ;
         }

         set {
            gxTv_SdtSerie_Serieinativo_Z = value;
            SetDirty("Serieinativo_Z");
         }

      }

      public void gxTv_SdtSerie_Serieinativo_Z_SetNull( )
      {
         gxTv_SdtSerie_Serieinativo_Z = false;
         return  ;
      }

      public bool gxTv_SdtSerie_Serieinativo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieDataHoraCadastro_Z" )]
      [  XmlElement( ElementName = "SerieDataHoraCadastro_Z"  , IsNullable=true )]
      public string gxTpr_Seriedatahoracadastro_Z_Nullable
      {
         get {
            if ( gxTv_SdtSerie_Seriedatahoracadastro_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtSerie_Seriedatahoracadastro_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtSerie_Seriedatahoracadastro_Z = DateTime.MinValue;
            else
               gxTv_SdtSerie_Seriedatahoracadastro_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Seriedatahoracadastro_Z
      {
         get {
            return gxTv_SdtSerie_Seriedatahoracadastro_Z ;
         }

         set {
            gxTv_SdtSerie_Seriedatahoracadastro_Z = value;
            SetDirty("Seriedatahoracadastro_Z");
         }

      }

      public void gxTv_SdtSerie_Seriedatahoracadastro_Z_SetNull( )
      {
         gxTv_SdtSerie_Seriedatahoracadastro_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSerie_Seriedatahoracadastro_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SerieImagem_GXI_Z" )]
      [  XmlElement( ElementName = "SerieImagem_GXI_Z"   )]
      public String gxTpr_Serieimagem_gxi_Z
      {
         get {
            return gxTv_SdtSerie_Serieimagem_gxi_Z ;
         }

         set {
            gxTv_SdtSerie_Serieimagem_gxi_Z = value;
            SetDirty("Serieimagem_gxi_Z");
         }

      }

      public void gxTv_SdtSerie_Serieimagem_gxi_Z_SetNull( )
      {
         gxTv_SdtSerie_Serieimagem_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtSerie_Serieimagem_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSerie_Serienome = "";
         gxTv_SdtSerie_Generonome = "";
         gxTv_SdtSerie_Serieresumo = "";
         gxTv_SdtSerie_Serieimagem = "";
         gxTv_SdtSerie_Serieimagem_gxi = "";
         gxTv_SdtSerie_Seriedatahoracadastro = (DateTime)(DateTime.MinValue);
         gxTv_SdtSerie_Mode = "";
         gxTv_SdtSerie_Serienome_Z = "";
         gxTv_SdtSerie_Generonome_Z = "";
         gxTv_SdtSerie_Seriedatahoracadastro_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtSerie_Serieimagem_gxi_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "serie", "GeneXus.Programs.serie_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSerie_Seriequantidadetemporadas ;
      private short gxTv_SdtSerie_Initialized ;
      private short gxTv_SdtSerie_Seriequantidadetemporadas_Z ;
      private long gxTv_SdtSerie_Serieid ;
      private long gxTv_SdtSerie_Generoid ;
      private long gxTv_SdtSerie_Serieid_Z ;
      private long gxTv_SdtSerie_Generoid_Z ;
      private String gxTv_SdtSerie_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSerie_Seriedatahoracadastro ;
      private DateTime gxTv_SdtSerie_Seriedatahoracadastro_Z ;
      private DateTime datetime_STZ ;
      private bool gxTv_SdtSerie_Serieinativo ;
      private bool gxTv_SdtSerie_Serieinativo_Z ;
      private String gxTv_SdtSerie_Serieresumo ;
      private String gxTv_SdtSerie_Serienome ;
      private String gxTv_SdtSerie_Generonome ;
      private String gxTv_SdtSerie_Serieimagem_gxi ;
      private String gxTv_SdtSerie_Serienome_Z ;
      private String gxTv_SdtSerie_Generonome_Z ;
      private String gxTv_SdtSerie_Serieimagem_gxi_Z ;
      private String gxTv_SdtSerie_Serieimagem ;
   }

   [DataContract(Name = @"Serie", Namespace = "SeriesColaborativas")]
   public class SdtSerie_RESTInterface : GxGenericCollectionItem<SdtSerie>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSerie_RESTInterface( ) : base()
      {
      }

      public SdtSerie_RESTInterface( SdtSerie psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SerieId" , Order = 0 )]
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

      [DataMember( Name = "SerieNome" , Order = 1 )]
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

      [DataMember( Name = "SerieQuantidadeTemporadas" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Seriequantidadetemporadas
      {
         get {
            return sdt.gxTpr_Seriequantidadetemporadas ;
         }

         set {
            sdt.gxTpr_Seriequantidadetemporadas = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "GeneroId" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Generoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Generoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Generoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "GeneroNome" , Order = 4 )]
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

      [DataMember( Name = "SerieResumo" , Order = 5 )]
      public String gxTpr_Serieresumo
      {
         get {
            return sdt.gxTpr_Serieresumo ;
         }

         set {
            sdt.gxTpr_Serieresumo = value;
         }

      }

      [DataMember( Name = "SerieImagem" , Order = 6 )]
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

      [DataMember( Name = "SerieInativo" , Order = 7 )]
      [GxSeudo()]
      public bool gxTpr_Serieinativo
      {
         get {
            return sdt.gxTpr_Serieinativo ;
         }

         set {
            sdt.gxTpr_Serieinativo = value;
         }

      }

      [DataMember( Name = "SerieDataHoraCadastro" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Seriedatahoracadastro
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Seriedatahoracadastro) ;
         }

         set {
            sdt.gxTpr_Seriedatahoracadastro = DateTimeUtil.CToT2( value);
         }

      }

      public SdtSerie sdt
      {
         get {
            return (SdtSerie)Sdt ;
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
            sdt = new SdtSerie() ;
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

   [DataContract(Name = @"Serie", Namespace = "SeriesColaborativas")]
   public class SdtSerie_RESTLInterface : GxGenericCollectionItem<SdtSerie>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSerie_RESTLInterface( ) : base()
      {
      }

      public SdtSerie_RESTLInterface( SdtSerie psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SerieNome" , Order = 0 )]
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

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtSerie sdt
      {
         get {
            return (SdtSerie)Sdt ;
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
            sdt = new SdtSerie() ;
         }
      }

   }

}
