/*
               File: type_SdtUsuarioConquista
        Description: Usuário conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:32.83
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
   [XmlRoot(ElementName = "UsuarioConquista" )]
   [XmlType(TypeName =  "UsuarioConquista" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtUsuarioConquista : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioConquista( )
      {
      }

      public SdtUsuarioConquista( IGxContext context )
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

      public void Load( long AV30UsuarioConquistaId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV30UsuarioConquistaId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UsuarioConquistaId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "UsuarioConquista");
         metadata.Set("BT", "UsuarioConquista");
         metadata.Set("PK", "[ \"UsuarioConquistaId\" ]");
         metadata.Set("PKAssigned", "[ \"UsuarioConquistaId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ConquistaId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UsuarioId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Usuarioconquistaid_Z");
         state.Add("gxTpr_Usuarioid_Z");
         state.Add("gxTpr_Conquistaid_Z");
         state.Add("gxTpr_Conquistanome_Z");
         state.Add("gxTpr_Conquistapontos_Z");
         state.Add("gxTpr_Usuarioconquistadatahora_Z_Nullable");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtUsuarioConquista sdt ;
         sdt = (SdtUsuarioConquista)(source);
         gxTv_SdtUsuarioConquista_Usuarioconquistaid = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistaid ;
         gxTv_SdtUsuarioConquista_Usuarioid = sdt.gxTv_SdtUsuarioConquista_Usuarioid ;
         gxTv_SdtUsuarioConquista_Conquistaid = sdt.gxTv_SdtUsuarioConquista_Conquistaid ;
         gxTv_SdtUsuarioConquista_Conquistanome = sdt.gxTv_SdtUsuarioConquista_Conquistanome ;
         gxTv_SdtUsuarioConquista_Conquistapontos = sdt.gxTv_SdtUsuarioConquista_Conquistapontos ;
         gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistadatahora ;
         gxTv_SdtUsuarioConquista_Mode = sdt.gxTv_SdtUsuarioConquista_Mode ;
         gxTv_SdtUsuarioConquista_Initialized = sdt.gxTv_SdtUsuarioConquista_Initialized ;
         gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z ;
         gxTv_SdtUsuarioConquista_Usuarioid_Z = sdt.gxTv_SdtUsuarioConquista_Usuarioid_Z ;
         gxTv_SdtUsuarioConquista_Conquistaid_Z = sdt.gxTv_SdtUsuarioConquista_Conquistaid_Z ;
         gxTv_SdtUsuarioConquista_Conquistanome_Z = sdt.gxTv_SdtUsuarioConquista_Conquistanome_Z ;
         gxTv_SdtUsuarioConquista_Conquistapontos_Z = sdt.gxTv_SdtUsuarioConquista_Conquistapontos_Z ;
         gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Usuarioconquistaid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Usuarioid), 18, 0)), false);
         AddObjectProperty("ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Conquistaid), 18, 0)), false);
         AddObjectProperty("ConquistaNome", gxTv_SdtUsuarioConquista_Conquistanome, false);
         AddObjectProperty("ConquistaPontos", gxTv_SdtUsuarioConquista_Conquistapontos, false);
         datetime_STZ = gxTv_SdtUsuarioConquista_Usuarioconquistadatahora;
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
         AddObjectProperty("UsuarioConquistaDataHora", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtUsuarioConquista_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtUsuarioConquista_Initialized, false);
            AddObjectProperty("UsuarioConquistaId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z), 18, 0)), false);
            AddObjectProperty("UsuarioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Usuarioid_Z), 18, 0)), false);
            AddObjectProperty("ConquistaId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtUsuarioConquista_Conquistaid_Z), 18, 0)), false);
            AddObjectProperty("ConquistaNome_Z", gxTv_SdtUsuarioConquista_Conquistanome_Z, false);
            AddObjectProperty("ConquistaPontos_Z", gxTv_SdtUsuarioConquista_Conquistapontos_Z, false);
            datetime_STZ = gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z;
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
            AddObjectProperty("UsuarioConquistaDataHora_Z", sDateCnv, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtUsuarioConquista sdt )
      {
         if ( sdt.IsDirty("UsuarioConquistaId") )
         {
            gxTv_SdtUsuarioConquista_Usuarioconquistaid = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistaid ;
         }
         if ( sdt.IsDirty("UsuarioId") )
         {
            gxTv_SdtUsuarioConquista_Usuarioid = sdt.gxTv_SdtUsuarioConquista_Usuarioid ;
         }
         if ( sdt.IsDirty("ConquistaId") )
         {
            gxTv_SdtUsuarioConquista_Conquistaid = sdt.gxTv_SdtUsuarioConquista_Conquistaid ;
         }
         if ( sdt.IsDirty("ConquistaNome") )
         {
            gxTv_SdtUsuarioConquista_Conquistanome = sdt.gxTv_SdtUsuarioConquista_Conquistanome ;
         }
         if ( sdt.IsDirty("ConquistaPontos") )
         {
            gxTv_SdtUsuarioConquista_Conquistapontos = sdt.gxTv_SdtUsuarioConquista_Conquistapontos ;
         }
         if ( sdt.IsDirty("UsuarioConquistaDataHora") )
         {
            gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = sdt.gxTv_SdtUsuarioConquista_Usuarioconquistadatahora ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioConquistaId" )]
      [  XmlElement( ElementName = "UsuarioConquistaId"   )]
      public long gxTpr_Usuarioconquistaid
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioconquistaid ;
         }

         set {
            if ( gxTv_SdtUsuarioConquista_Usuarioconquistaid != value )
            {
               gxTv_SdtUsuarioConquista_Mode = "INS";
               this.gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z_SetNull( );
               this.gxTv_SdtUsuarioConquista_Usuarioid_Z_SetNull( );
               this.gxTv_SdtUsuarioConquista_Conquistaid_Z_SetNull( );
               this.gxTv_SdtUsuarioConquista_Conquistanome_Z_SetNull( );
               this.gxTv_SdtUsuarioConquista_Conquistapontos_Z_SetNull( );
               this.gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z_SetNull( );
            }
            gxTv_SdtUsuarioConquista_Usuarioconquistaid = value;
            SetDirty("Usuarioconquistaid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioid ;
         }

         set {
            gxTv_SdtUsuarioConquista_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "ConquistaId" )]
      [  XmlElement( ElementName = "ConquistaId"   )]
      public long gxTpr_Conquistaid
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistaid ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistaid = value;
            SetDirty("Conquistaid");
         }

      }

      [  SoapElement( ElementName = "ConquistaNome" )]
      [  XmlElement( ElementName = "ConquistaNome"   )]
      public String gxTpr_Conquistanome
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistanome ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistanome = value;
            SetDirty("Conquistanome");
         }

      }

      [  SoapElement( ElementName = "ConquistaPontos" )]
      [  XmlElement( ElementName = "ConquistaPontos"   )]
      public short gxTpr_Conquistapontos
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistapontos ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistapontos = value;
            SetDirty("Conquistapontos");
         }

      }

      [  SoapElement( ElementName = "UsuarioConquistaDataHora" )]
      [  XmlElement( ElementName = "UsuarioConquistaDataHora"  , IsNullable=true )]
      public string gxTpr_Usuarioconquistadatahora_Nullable
      {
         get {
            if ( gxTv_SdtUsuarioConquista_Usuarioconquistadatahora == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtUsuarioConquista_Usuarioconquistadatahora).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = DateTime.MinValue;
            else
               gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Usuarioconquistadatahora
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioconquistadatahora ;
         }

         set {
            gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = value;
            SetDirty("Usuarioconquistadatahora");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtUsuarioConquista_Mode ;
         }

         set {
            gxTv_SdtUsuarioConquista_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtUsuarioConquista_Mode_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Mode = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtUsuarioConquista_Initialized ;
         }

         set {
            gxTv_SdtUsuarioConquista_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtUsuarioConquista_Initialized_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioConquistaId_Z" )]
      [  XmlElement( ElementName = "UsuarioConquistaId_Z"   )]
      public long gxTpr_Usuarioconquistaid_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z = value;
            SetDirty("Usuarioconquistaid_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioId_Z" )]
      [  XmlElement( ElementName = "UsuarioId_Z"   )]
      public long gxTpr_Usuarioid_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioid_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Usuarioid_Z = value;
            SetDirty("Usuarioid_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Usuarioid_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Usuarioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Usuarioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ConquistaId_Z" )]
      [  XmlElement( ElementName = "ConquistaId_Z"   )]
      public long gxTpr_Conquistaid_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistaid_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistaid_Z = value;
            SetDirty("Conquistaid_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Conquistaid_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Conquistaid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Conquistaid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ConquistaNome_Z" )]
      [  XmlElement( ElementName = "ConquistaNome_Z"   )]
      public String gxTpr_Conquistanome_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistanome_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistanome_Z = value;
            SetDirty("Conquistanome_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Conquistanome_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Conquistanome_Z = "";
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Conquistanome_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ConquistaPontos_Z" )]
      [  XmlElement( ElementName = "ConquistaPontos_Z"   )]
      public short gxTpr_Conquistapontos_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Conquistapontos_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Conquistapontos_Z = value;
            SetDirty("Conquistapontos_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Conquistapontos_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Conquistapontos_Z = 0;
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Conquistapontos_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioConquistaDataHora_Z" )]
      [  XmlElement( ElementName = "UsuarioConquistaDataHora_Z"  , IsNullable=true )]
      public string gxTpr_Usuarioconquistadatahora_Z_Nullable
      {
         get {
            if ( gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = DateTime.MinValue;
            else
               gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Usuarioconquistadatahora_Z
      {
         get {
            return gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z ;
         }

         set {
            gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = value;
            SetDirty("Usuarioconquistadatahora_Z");
         }

      }

      public void gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z_SetNull( )
      {
         gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtUsuarioConquista_Conquistanome = "";
         gxTv_SdtUsuarioConquista_Usuarioconquistadatahora = (DateTime)(DateTime.MinValue);
         gxTv_SdtUsuarioConquista_Mode = "";
         gxTv_SdtUsuarioConquista_Conquistanome_Z = "";
         gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "usuarioconquista", "GeneXus.Programs.usuarioconquista_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtUsuarioConquista_Conquistapontos ;
      private short gxTv_SdtUsuarioConquista_Initialized ;
      private short gxTv_SdtUsuarioConquista_Conquistapontos_Z ;
      private long gxTv_SdtUsuarioConquista_Usuarioconquistaid ;
      private long gxTv_SdtUsuarioConquista_Usuarioid ;
      private long gxTv_SdtUsuarioConquista_Conquistaid ;
      private long gxTv_SdtUsuarioConquista_Usuarioconquistaid_Z ;
      private long gxTv_SdtUsuarioConquista_Usuarioid_Z ;
      private long gxTv_SdtUsuarioConquista_Conquistaid_Z ;
      private String gxTv_SdtUsuarioConquista_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtUsuarioConquista_Usuarioconquistadatahora ;
      private DateTime gxTv_SdtUsuarioConquista_Usuarioconquistadatahora_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtUsuarioConquista_Conquistanome ;
      private String gxTv_SdtUsuarioConquista_Conquistanome_Z ;
   }

   [DataContract(Name = @"UsuarioConquista", Namespace = "SeriesColaborativas")]
   public class SdtUsuarioConquista_RESTInterface : GxGenericCollectionItem<SdtUsuarioConquista>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioConquista_RESTInterface( ) : base()
      {
      }

      public SdtUsuarioConquista_RESTInterface( SdtUsuarioConquista psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioConquistaId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Usuarioconquistaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioconquistaid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioconquistaid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "ConquistaId" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Conquistaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Conquistaid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Conquistaid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "ConquistaNome" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Conquistanome
      {
         get {
            return sdt.gxTpr_Conquistanome ;
         }

         set {
            sdt.gxTpr_Conquistanome = value;
         }

      }

      [DataMember( Name = "ConquistaPontos" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Conquistapontos
      {
         get {
            return sdt.gxTpr_Conquistapontos ;
         }

         set {
            sdt.gxTpr_Conquistapontos = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "UsuarioConquistaDataHora" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Usuarioconquistadatahora
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Usuarioconquistadatahora) ;
         }

         set {
            sdt.gxTpr_Usuarioconquistadatahora = DateTimeUtil.CToT2( value);
         }

      }

      public SdtUsuarioConquista sdt
      {
         get {
            return (SdtUsuarioConquista)Sdt ;
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
            sdt = new SdtUsuarioConquista() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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

   [DataContract(Name = @"UsuarioConquista", Namespace = "SeriesColaborativas")]
   public class SdtUsuarioConquista_RESTLInterface : GxGenericCollectionItem<SdtUsuarioConquista>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtUsuarioConquista_RESTLInterface( ) : base()
      {
      }

      public SdtUsuarioConquista_RESTLInterface( SdtUsuarioConquista psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioConquistaDataHora" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Usuarioconquistadatahora
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Usuarioconquistadatahora) ;
         }

         set {
            sdt.gxTpr_Usuarioconquistadatahora = DateTimeUtil.CToT2( value);
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

      public SdtUsuarioConquista sdt
      {
         get {
            return (SdtUsuarioConquista)Sdt ;
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
            sdt = new SdtUsuarioConquista() ;
         }
      }

   }

}
