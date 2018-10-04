/*
               File: type_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt
        Description: WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.79
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
   [XmlRoot(ElementName = "WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto = "";
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio = (DateTime)(DateTime.MinValue);
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt( IGxContext context )
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
         AddObjectProperty("NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("NotificacaoTipo", gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotipo, false);
         AddObjectProperty("NotificacaoTexto", gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto, false);
         AddObjectProperty("NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoligacaoid), 18, 0)), false);
         datetime_STZ = gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio;
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
         return  ;
      }

      [  SoapElement( ElementName = "NotificacaoId" )]
      [  XmlElement( ElementName = "NotificacaoId"   )]
      public long gxTpr_Notificacaoid
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoid = value;
            SetDirty("Notificacaoid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Usuarioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTipo" )]
      [  XmlElement( ElementName = "NotificacaoTipo"   )]
      public short gxTpr_Notificacaotipo
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotipo ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotipo = value;
            SetDirty("Notificacaotipo");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTexto" )]
      [  XmlElement( ElementName = "NotificacaoTexto"   )]
      public String gxTpr_Notificacaotexto
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto = value;
            SetDirty("Notificacaotexto");
         }

      }

      [  SoapElement( ElementName = "NotificacaoLigacaoId" )]
      [  XmlElement( ElementName = "NotificacaoLigacaoId"   )]
      public long gxTpr_Notificacaoligacaoid
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoligacaoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoligacaoid = value;
            SetDirty("Notificacaoligacaoid");
         }

      }

      [  SoapElement( ElementName = "NotificacaoDataHoraEnvio" )]
      [  XmlElement( ElementName = "NotificacaoDataHoraEnvio"  , IsNullable=true )]
      public string gxTpr_Notificacaodatahoraenvio_Nullable
      {
         get {
            if ( gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio = DateTime.MinValue;
            else
               gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Notificacaodatahoraenvio
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio = value;
            SetDirty("Notificacaodatahoraenvio");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto = "";
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotipo ;
      protected long gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoid ;
      protected long gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Usuarioid ;
      protected long gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaoligacaoid ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaodatahoraenvio ;
      protected DateTime datetime_STZ ;
      protected String gxTv_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_Notificacaotexto ;
   }

   [DataContract(Name = @"WorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "NotificacaoId" , Order = 0 )]
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
      public String gxTpr_Notificacaodatahoraenvio
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Notificacaodatahoraenvio) ;
         }

         set {
            sdt.gxTpr_Notificacaodatahoraenvio = DateTimeUtil.CToT2( value);
         }

      }

      public SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt() ;
         }
      }

   }

}
