/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt
        Description: WorkWithDevicesSerie_Serie_Section_GeneralSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:33.7
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
   [XmlRoot(ElementName = "WorkWithDevicesSerie_Serie_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesSerie_Serie_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro = (DateTime)(DateTime.MinValue);
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi = "";
      }

      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt( IGxContext context )
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
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieid), 18, 0)), false);
         AddObjectProperty("SerieImagem", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem, false);
         AddObjectProperty("SerieImagem_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi, false);
         AddObjectProperty("SerieNome", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome, false);
         AddObjectProperty("GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generoid), 18, 0)), false);
         AddObjectProperty("GeneroNome", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome, false);
         AddObjectProperty("SerieResumo", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo, false);
         AddObjectProperty("SerieQuantidadeTemporadas", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriequantidadetemporadas, false);
         AddObjectProperty("SerieInativo", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieinativo, false);
         datetime_STZ = gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro;
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
         AddObjectProperty("Favorita", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Favorita, false);
         AddObjectProperty("Assistido", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Assistido, false);
         AddObjectProperty("Notaimage", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage, false);
         AddObjectProperty("Notaimage_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "SerieImagem" )]
      [  XmlElement( ElementName = "SerieImagem"   )]
      [GxUpload()]
      public String gxTpr_Serieimagem
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem = value;
            SetDirty("Serieimagem");
         }

      }

      [  SoapElement( ElementName = "SerieImagem_GXI" )]
      [  XmlElement( ElementName = "SerieImagem_GXI"   )]
      public String gxTpr_Serieimagem_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi = value;
            SetDirty("Serieimagem_gxi");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "GeneroId" )]
      [  XmlElement( ElementName = "GeneroId"   )]
      public long gxTpr_Generoid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generoid = value;
            SetDirty("Generoid");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome = value;
            SetDirty("Generonome");
         }

      }

      [  SoapElement( ElementName = "SerieResumo" )]
      [  XmlElement( ElementName = "SerieResumo"   )]
      public String gxTpr_Serieresumo
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo = value;
            SetDirty("Serieresumo");
         }

      }

      [  SoapElement( ElementName = "SerieQuantidadeTemporadas" )]
      [  XmlElement( ElementName = "SerieQuantidadeTemporadas"   )]
      public short gxTpr_Seriequantidadetemporadas
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriequantidadetemporadas ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriequantidadetemporadas = value;
            SetDirty("Seriequantidadetemporadas");
         }

      }

      [  SoapElement( ElementName = "SerieInativo" )]
      [  XmlElement( ElementName = "SerieInativo"   )]
      public bool gxTpr_Serieinativo
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieinativo ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieinativo = value;
            SetDirty("Serieinativo");
         }

      }

      [  SoapElement( ElementName = "SerieDataHoraCadastro" )]
      [  XmlElement( ElementName = "SerieDataHoraCadastro"  , IsNullable=true )]
      public string gxTpr_Seriedatahoracadastro_Nullable
      {
         get {
            if ( gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro = DateTime.MinValue;
            else
               gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Seriedatahoracadastro
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro = value;
            SetDirty("Seriedatahoracadastro");
         }

      }

      [  SoapElement( ElementName = "Favorita" )]
      [  XmlElement( ElementName = "Favorita"   )]
      public bool gxTpr_Favorita
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Favorita ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Favorita = value;
            SetDirty("Favorita");
         }

      }

      [  SoapElement( ElementName = "Assistido" )]
      [  XmlElement( ElementName = "Assistido"   )]
      public bool gxTpr_Assistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Assistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Assistido = value;
            SetDirty("Assistido");
         }

      }

      [  SoapElement( ElementName = "Notaimage" )]
      [  XmlElement( ElementName = "Notaimage"   )]
      [GxUpload()]
      public String gxTpr_Notaimage
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage = value;
            SetDirty("Notaimage");
         }

      }

      [  SoapElement( ElementName = "Notaimage_GXI" )]
      [  XmlElement( ElementName = "Notaimage_GXI"   )]
      public String gxTpr_Notaimage_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi = value;
            SetDirty("Notaimage_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro = (DateTime)(DateTime.MinValue);
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriequantidadetemporadas ;
      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieid ;
      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generoid ;
      protected String sDateCnv ;
      protected String sNumToPad ;
      protected DateTime gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Seriedatahoracadastro ;
      protected DateTime datetime_STZ ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieinativo ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Favorita ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Assistido ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieresumo ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serienome ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Generonome ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Serieimagem ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_Notaimage ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt psdt ) : base(psdt)
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

      [DataMember( Name = "SerieImagem" , Order = 1 )]
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

      [DataMember( Name = "SerieNome" , Order = 2 )]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "GeneroId" , Order = 3 )]
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

      [DataMember( Name = "SerieQuantidadeTemporadas" , Order = 6 )]
      public Nullable<short> gxTpr_Seriequantidadetemporadas
      {
         get {
            return sdt.gxTpr_Seriequantidadetemporadas ;
         }

         set {
            sdt.gxTpr_Seriequantidadetemporadas = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SerieInativo" , Order = 7 )]
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
      public String gxTpr_Seriedatahoracadastro
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Seriedatahoracadastro) ;
         }

         set {
            sdt.gxTpr_Seriedatahoracadastro = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "Favorita" , Order = 9 )]
      public bool gxTpr_Favorita
      {
         get {
            return sdt.gxTpr_Favorita ;
         }

         set {
            sdt.gxTpr_Favorita = value;
         }

      }

      [DataMember( Name = "Assistido" , Order = 10 )]
      public bool gxTpr_Assistido
      {
         get {
            return sdt.gxTpr_Assistido ;
         }

         set {
            sdt.gxTpr_Assistido = value;
         }

      }

      [DataMember( Name = "Notaimage" , Order = 11 )]
      [GxUpload()]
      public String gxTpr_Notaimage
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Notaimage)) ? PathUtil.RelativeURL( sdt.gxTpr_Notaimage) : StringUtil.RTrim( sdt.gxTpr_Notaimage_gxi)) ;
         }

         set {
            sdt.gxTpr_Notaimage = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt() ;
         }
      }

   }

}
