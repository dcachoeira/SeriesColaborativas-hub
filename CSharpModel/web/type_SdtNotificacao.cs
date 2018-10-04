/*
               File: type_SdtNotificacao
        Description: Notificação
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:30.72
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
   [XmlRoot(ElementName = "Notificacao" )]
   [XmlType(TypeName =  "Notificacao" , Namespace = "SeriesColaborativas" )]
   [Serializable]
   public class SdtNotificacao : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtNotificacao( )
      {
      }

      public SdtNotificacao( IGxContext context )
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

      public void Load( long AV23NotificacaoId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV23NotificacaoId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"NotificacaoId", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Notificacao");
         metadata.Set("BT", "Notificacao");
         metadata.Set("PK", "[ \"NotificacaoId\" ]");
         metadata.Set("PKAssigned", "[ \"NotificacaoId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"UsuarioId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Notificacaoid_Z");
         state.Add("gxTpr_Usuarioid_Z");
         state.Add("gxTpr_Notificacaotipo_Z");
         state.Add("gxTpr_Notificacaotexto_Z");
         state.Add("gxTpr_Notificacaoligacaoid_Z");
         state.Add("gxTpr_Notificacaodatahoraenvio_Z_Nullable");
         state.Add("gxTpr_Notificacaoligacaoid_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtNotificacao sdt ;
         sdt = (SdtNotificacao)(source);
         gxTv_SdtNotificacao_Notificacaoid = sdt.gxTv_SdtNotificacao_Notificacaoid ;
         gxTv_SdtNotificacao_Usuarioid = sdt.gxTv_SdtNotificacao_Usuarioid ;
         gxTv_SdtNotificacao_Notificacaotipo = sdt.gxTv_SdtNotificacao_Notificacaotipo ;
         gxTv_SdtNotificacao_Notificacaotexto = sdt.gxTv_SdtNotificacao_Notificacaotexto ;
         gxTv_SdtNotificacao_Notificacaoligacaoid = sdt.gxTv_SdtNotificacao_Notificacaoligacaoid ;
         gxTv_SdtNotificacao_Notificacaodatahoraenvio = sdt.gxTv_SdtNotificacao_Notificacaodatahoraenvio ;
         gxTv_SdtNotificacao_Mode = sdt.gxTv_SdtNotificacao_Mode ;
         gxTv_SdtNotificacao_Initialized = sdt.gxTv_SdtNotificacao_Initialized ;
         gxTv_SdtNotificacao_Notificacaoid_Z = sdt.gxTv_SdtNotificacao_Notificacaoid_Z ;
         gxTv_SdtNotificacao_Usuarioid_Z = sdt.gxTv_SdtNotificacao_Usuarioid_Z ;
         gxTv_SdtNotificacao_Notificacaotipo_Z = sdt.gxTv_SdtNotificacao_Notificacaotipo_Z ;
         gxTv_SdtNotificacao_Notificacaotexto_Z = sdt.gxTv_SdtNotificacao_Notificacaotexto_Z ;
         gxTv_SdtNotificacao_Notificacaoligacaoid_Z = sdt.gxTv_SdtNotificacao_Notificacaoligacaoid_Z ;
         gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = sdt.gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z ;
         gxTv_SdtNotificacao_Notificacaoligacaoid_N = sdt.gxTv_SdtNotificacao_Notificacaoligacaoid_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Notificacaoid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Usuarioid), 18, 0)), false);
         AddObjectProperty("NotificacaoTipo", gxTv_SdtNotificacao_Notificacaotipo, false);
         AddObjectProperty("NotificacaoTexto", gxTv_SdtNotificacao_Notificacaotexto, false);
         AddObjectProperty("NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Notificacaoligacaoid), 18, 0)), false);
         AddObjectProperty("NotificacaoLigacaoId_N", gxTv_SdtNotificacao_Notificacaoligacaoid_N, false);
         datetime_STZ = gxTv_SdtNotificacao_Notificacaodatahoraenvio;
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
         AddObjectProperty("NotificacaoDataHoraEnvio", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtNotificacao_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtNotificacao_Initialized, false);
            AddObjectProperty("NotificacaoId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Notificacaoid_Z), 18, 0)), false);
            AddObjectProperty("UsuarioId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Usuarioid_Z), 18, 0)), false);
            AddObjectProperty("NotificacaoTipo_Z", gxTv_SdtNotificacao_Notificacaotipo_Z, false);
            AddObjectProperty("NotificacaoTexto_Z", gxTv_SdtNotificacao_Notificacaotexto_Z, false);
            AddObjectProperty("NotificacaoLigacaoId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtNotificacao_Notificacaoligacaoid_Z), 18, 0)), false);
            datetime_STZ = gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z;
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
            AddObjectProperty("NotificacaoDataHoraEnvio_Z", sDateCnv, false);
            AddObjectProperty("NotificacaoLigacaoId_N", gxTv_SdtNotificacao_Notificacaoligacaoid_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtNotificacao sdt )
      {
         if ( sdt.IsDirty("NotificacaoId") )
         {
            gxTv_SdtNotificacao_Notificacaoid = sdt.gxTv_SdtNotificacao_Notificacaoid ;
         }
         if ( sdt.IsDirty("UsuarioId") )
         {
            gxTv_SdtNotificacao_Usuarioid = sdt.gxTv_SdtNotificacao_Usuarioid ;
         }
         if ( sdt.IsDirty("NotificacaoTipo") )
         {
            gxTv_SdtNotificacao_Notificacaotipo = sdt.gxTv_SdtNotificacao_Notificacaotipo ;
         }
         if ( sdt.IsDirty("NotificacaoTexto") )
         {
            gxTv_SdtNotificacao_Notificacaotexto = sdt.gxTv_SdtNotificacao_Notificacaotexto ;
         }
         if ( sdt.IsDirty("NotificacaoLigacaoId") )
         {
            gxTv_SdtNotificacao_Notificacaoligacaoid = sdt.gxTv_SdtNotificacao_Notificacaoligacaoid ;
         }
         if ( sdt.IsDirty("NotificacaoDataHoraEnvio") )
         {
            gxTv_SdtNotificacao_Notificacaodatahoraenvio = sdt.gxTv_SdtNotificacao_Notificacaodatahoraenvio ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "NotificacaoId" )]
      [  XmlElement( ElementName = "NotificacaoId"   )]
      public long gxTpr_Notificacaoid
      {
         get {
            return gxTv_SdtNotificacao_Notificacaoid ;
         }

         set {
            if ( gxTv_SdtNotificacao_Notificacaoid != value )
            {
               gxTv_SdtNotificacao_Mode = "INS";
               this.gxTv_SdtNotificacao_Notificacaoid_Z_SetNull( );
               this.gxTv_SdtNotificacao_Usuarioid_Z_SetNull( );
               this.gxTv_SdtNotificacao_Notificacaotipo_Z_SetNull( );
               this.gxTv_SdtNotificacao_Notificacaotexto_Z_SetNull( );
               this.gxTv_SdtNotificacao_Notificacaoligacaoid_Z_SetNull( );
               this.gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z_SetNull( );
            }
            gxTv_SdtNotificacao_Notificacaoid = value;
            SetDirty("Notificacaoid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtNotificacao_Usuarioid ;
         }

         set {
            gxTv_SdtNotificacao_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTipo" )]
      [  XmlElement( ElementName = "NotificacaoTipo"   )]
      public short gxTpr_Notificacaotipo
      {
         get {
            return gxTv_SdtNotificacao_Notificacaotipo ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaotipo = value;
            SetDirty("Notificacaotipo");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTexto" )]
      [  XmlElement( ElementName = "NotificacaoTexto"   )]
      public String gxTpr_Notificacaotexto
      {
         get {
            return gxTv_SdtNotificacao_Notificacaotexto ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaotexto = value;
            SetDirty("Notificacaotexto");
         }

      }

      [  SoapElement( ElementName = "NotificacaoLigacaoId" )]
      [  XmlElement( ElementName = "NotificacaoLigacaoId"   )]
      public long gxTpr_Notificacaoligacaoid
      {
         get {
            return gxTv_SdtNotificacao_Notificacaoligacaoid ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaoligacaoid_N = 0;
            gxTv_SdtNotificacao_Notificacaoligacaoid = value;
            SetDirty("Notificacaoligacaoid");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaoligacaoid_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaoligacaoid_N = 1;
         gxTv_SdtNotificacao_Notificacaoligacaoid = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaoligacaoid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoDataHoraEnvio" )]
      [  XmlElement( ElementName = "NotificacaoDataHoraEnvio"  , IsNullable=true )]
      public string gxTpr_Notificacaodatahoraenvio_Nullable
      {
         get {
            if ( gxTv_SdtNotificacao_Notificacaodatahoraenvio == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtNotificacao_Notificacaodatahoraenvio).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtNotificacao_Notificacaodatahoraenvio = DateTime.MinValue;
            else
               gxTv_SdtNotificacao_Notificacaodatahoraenvio = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Notificacaodatahoraenvio
      {
         get {
            return gxTv_SdtNotificacao_Notificacaodatahoraenvio ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaodatahoraenvio = value;
            SetDirty("Notificacaodatahoraenvio");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtNotificacao_Mode ;
         }

         set {
            gxTv_SdtNotificacao_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtNotificacao_Mode_SetNull( )
      {
         gxTv_SdtNotificacao_Mode = "";
         return  ;
      }

      public bool gxTv_SdtNotificacao_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtNotificacao_Initialized ;
         }

         set {
            gxTv_SdtNotificacao_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtNotificacao_Initialized_SetNull( )
      {
         gxTv_SdtNotificacao_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoId_Z" )]
      [  XmlElement( ElementName = "NotificacaoId_Z"   )]
      public long gxTpr_Notificacaoid_Z
      {
         get {
            return gxTv_SdtNotificacao_Notificacaoid_Z ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaoid_Z = value;
            SetDirty("Notificacaoid_Z");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaoid_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaoid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UsuarioId_Z" )]
      [  XmlElement( ElementName = "UsuarioId_Z"   )]
      public long gxTpr_Usuarioid_Z
      {
         get {
            return gxTv_SdtNotificacao_Usuarioid_Z ;
         }

         set {
            gxTv_SdtNotificacao_Usuarioid_Z = value;
            SetDirty("Usuarioid_Z");
         }

      }

      public void gxTv_SdtNotificacao_Usuarioid_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Usuarioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Usuarioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoTipo_Z" )]
      [  XmlElement( ElementName = "NotificacaoTipo_Z"   )]
      public short gxTpr_Notificacaotipo_Z
      {
         get {
            return gxTv_SdtNotificacao_Notificacaotipo_Z ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaotipo_Z = value;
            SetDirty("Notificacaotipo_Z");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaotipo_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaotipo_Z = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaotipo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoTexto_Z" )]
      [  XmlElement( ElementName = "NotificacaoTexto_Z"   )]
      public String gxTpr_Notificacaotexto_Z
      {
         get {
            return gxTv_SdtNotificacao_Notificacaotexto_Z ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaotexto_Z = value;
            SetDirty("Notificacaotexto_Z");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaotexto_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaotexto_Z = "";
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaotexto_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoLigacaoId_Z" )]
      [  XmlElement( ElementName = "NotificacaoLigacaoId_Z"   )]
      public long gxTpr_Notificacaoligacaoid_Z
      {
         get {
            return gxTv_SdtNotificacao_Notificacaoligacaoid_Z ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaoligacaoid_Z = value;
            SetDirty("Notificacaoligacaoid_Z");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaoligacaoid_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaoligacaoid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaoligacaoid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoDataHoraEnvio_Z" )]
      [  XmlElement( ElementName = "NotificacaoDataHoraEnvio_Z"  , IsNullable=true )]
      public string gxTpr_Notificacaodatahoraenvio_Z_Nullable
      {
         get {
            if ( gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = DateTime.MinValue;
            else
               gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Notificacaodatahoraenvio_Z
      {
         get {
            return gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = value;
            SetDirty("Notificacaodatahoraenvio_Z");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "NotificacaoLigacaoId_N" )]
      [  XmlElement( ElementName = "NotificacaoLigacaoId_N"   )]
      public short gxTpr_Notificacaoligacaoid_N
      {
         get {
            return gxTv_SdtNotificacao_Notificacaoligacaoid_N ;
         }

         set {
            gxTv_SdtNotificacao_Notificacaoligacaoid_N = value;
            SetDirty("Notificacaoligacaoid_N");
         }

      }

      public void gxTv_SdtNotificacao_Notificacaoligacaoid_N_SetNull( )
      {
         gxTv_SdtNotificacao_Notificacaoligacaoid_N = 0;
         return  ;
      }

      public bool gxTv_SdtNotificacao_Notificacaoligacaoid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtNotificacao_Notificacaotexto = "";
         gxTv_SdtNotificacao_Notificacaodatahoraenvio = (DateTime)(DateTime.MinValue);
         gxTv_SdtNotificacao_Mode = "";
         gxTv_SdtNotificacao_Notificacaotexto_Z = "";
         gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "notificacao", "GeneXus.Programs.notificacao_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtNotificacao_Notificacaotipo ;
      private short gxTv_SdtNotificacao_Initialized ;
      private short gxTv_SdtNotificacao_Notificacaotipo_Z ;
      private short gxTv_SdtNotificacao_Notificacaoligacaoid_N ;
      private long gxTv_SdtNotificacao_Notificacaoid ;
      private long gxTv_SdtNotificacao_Usuarioid ;
      private long gxTv_SdtNotificacao_Notificacaoligacaoid ;
      private long gxTv_SdtNotificacao_Notificacaoid_Z ;
      private long gxTv_SdtNotificacao_Usuarioid_Z ;
      private long gxTv_SdtNotificacao_Notificacaoligacaoid_Z ;
      private String gxTv_SdtNotificacao_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtNotificacao_Notificacaodatahoraenvio ;
      private DateTime gxTv_SdtNotificacao_Notificacaodatahoraenvio_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtNotificacao_Notificacaotexto ;
      private String gxTv_SdtNotificacao_Notificacaotexto_Z ;
   }

   [DataContract(Name = @"Notificacao", Namespace = "SeriesColaborativas")]
   public class SdtNotificacao_RESTInterface : GxGenericCollectionItem<SdtNotificacao>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtNotificacao_RESTInterface( ) : base()
      {
      }

      public SdtNotificacao_RESTInterface( SdtNotificacao psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "NotificacaoId" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Notificacaoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Notificacaoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Notificacaoid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "NotificacaoTipo" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Notificacaotipo
      {
         get {
            return sdt.gxTpr_Notificacaotipo ;
         }

         set {
            sdt.gxTpr_Notificacaotipo = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "NotificacaoTexto" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Notificacaotexto
      {
         get {
            return sdt.gxTpr_Notificacaotexto ;
         }

         set {
            sdt.gxTpr_Notificacaotexto = value;
         }

      }

      [DataMember( Name = "NotificacaoLigacaoId" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Notificacaoligacaoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Notificacaoligacaoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Notificacaoligacaoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "NotificacaoDataHoraEnvio" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Notificacaodatahoraenvio
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Notificacaodatahoraenvio) ;
         }

         set {
            sdt.gxTpr_Notificacaodatahoraenvio = DateTimeUtil.CToT2( value);
         }

      }

      public SdtNotificacao sdt
      {
         get {
            return (SdtNotificacao)Sdt ;
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
            sdt = new SdtNotificacao() ;
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

   [DataContract(Name = @"Notificacao", Namespace = "SeriesColaborativas")]
   public class SdtNotificacao_RESTLInterface : GxGenericCollectionItem<SdtNotificacao>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtNotificacao_RESTLInterface( ) : base()
      {
      }

      public SdtNotificacao_RESTLInterface( SdtNotificacao psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "NotificacaoTipo" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Notificacaotipo
      {
         get {
            return sdt.gxTpr_Notificacaotipo ;
         }

         set {
            sdt.gxTpr_Notificacaotipo = (short)(value.HasValue ? value.Value : 0);
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

      public SdtNotificacao sdt
      {
         get {
            return (SdtNotificacao)Sdt ;
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
            sdt = new SdtNotificacao() ;
         }
      }

   }

}
