/*
               File: type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.20
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
   [XmlRoot(ElementName = "WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome = "";
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora = (DateTime)(DateTime.MinValue);
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt( IGxContext context )
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
         AddObjectProperty("UsuarioConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistaid), 18, 0)), false);
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistaid), 18, 0)), false);
         AddObjectProperty("ConquistaNome", gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome, false);
         AddObjectProperty("ConquistaPontos", gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistapontos, false);
         datetime_STZ = gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora;
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
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioConquistaId" )]
      [  XmlElement( ElementName = "UsuarioConquistaId"   )]
      public long gxTpr_Usuarioconquistaid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistaid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistaid = value;
            SetDirty("Usuarioconquistaid");
         }

      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "ConquistaId" )]
      [  XmlElement( ElementName = "ConquistaId"   )]
      public long gxTpr_Conquistaid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistaid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistaid = value;
            SetDirty("Conquistaid");
         }

      }

      [  SoapElement( ElementName = "ConquistaNome" )]
      [  XmlElement( ElementName = "ConquistaNome"   )]
      public String gxTpr_Conquistanome
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome = value;
            SetDirty("Conquistanome");
         }

      }

      [  SoapElement( ElementName = "ConquistaPontos" )]
      [  XmlElement( ElementName = "ConquistaPontos"   )]
      public short gxTpr_Conquistapontos
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistapontos ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistapontos = value;
            SetDirty("Conquistapontos");
         }

      }

      [  SoapElement( ElementName = "UsuarioConquistaDataHora" )]
      [  XmlElement( ElementName = "UsuarioConquistaDataHora"  , IsNullable=true )]
      public string gxTpr_Usuarioconquistadatahora_Nullable
      {
         get {
            if ( gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora = DateTime.MinValue;
            else
               gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Usuarioconquistadatahora
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora = value;
            SetDirty("Usuarioconquistadatahora");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome = "";
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora = (DateTime)(DateTime.MinValue);
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistapontos ;
      protected long gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistaid ;
      protected long gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioid ;
      protected long gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistaid ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Usuarioconquistadatahora ;
      protected DateTime datetime_STZ ;
      protected String gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_Conquistanome ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioConquistaId" , Order = 0 )]
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
      public String gxTpr_Usuarioconquistadatahora
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Usuarioconquistadatahora) ;
         }

         set {
            sdt.gxTpr_Usuarioconquistadatahora = DateTimeUtil.CToT2( value);
         }

      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt() ;
         }
      }

   }

}
