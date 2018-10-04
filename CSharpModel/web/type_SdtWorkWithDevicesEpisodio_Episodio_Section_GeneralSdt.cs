/*
               File: type_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt
        Description: WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:19.42
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
   [XmlRoot(ElementName = "WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt : GxUserType
   {
      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada = "";
      }

      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt( IGxContext context )
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
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodioid), 18, 0)), false);
         AddObjectProperty("SerieNome", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome, false);
         AddObjectProperty("EpisodioNome", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome, false);
         AddObjectProperty("EpisodioSinopse", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse, false);
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serieid), 18, 0)), false);
         AddObjectProperty("Notaimage", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage, false);
         AddObjectProperty("Notaimage_GXI", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi, false);
         AddObjectProperty("Duracao", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao, false);
         AddObjectProperty("Temporada", gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada, false);
         return  ;
      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "SerieNome" )]
      [  XmlElement( ElementName = "SerieNome"   )]
      public String gxTpr_Serienome
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome = value;
            SetDirty("Serienome");
         }

      }

      [  SoapElement( ElementName = "EpisodioNome" )]
      [  XmlElement( ElementName = "EpisodioNome"   )]
      public String gxTpr_Episodionome
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome = value;
            SetDirty("Episodionome");
         }

      }

      [  SoapElement( ElementName = "EpisodioSinopse" )]
      [  XmlElement( ElementName = "EpisodioSinopse"   )]
      public String gxTpr_Episodiosinopse
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse = value;
            SetDirty("Episodiosinopse");
         }

      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "Notaimage" )]
      [  XmlElement( ElementName = "Notaimage"   )]
      [GxUpload()]
      public String gxTpr_Notaimage
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage = value;
            SetDirty("Notaimage");
         }

      }

      [  SoapElement( ElementName = "Notaimage_GXI" )]
      [  XmlElement( ElementName = "Notaimage_GXI"   )]
      public String gxTpr_Notaimage_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi = value;
            SetDirty("Notaimage_gxi");
         }

      }

      [  SoapElement( ElementName = "Duracao" )]
      [  XmlElement( ElementName = "Duracao"   )]
      public String gxTpr_Duracao
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao = value;
            SetDirty("Duracao");
         }

      }

      [  SoapElement( ElementName = "Temporada" )]
      [  XmlElement( ElementName = "Temporada"   )]
      public String gxTpr_Temporada
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada = value;
            SetDirty("Temporada");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodioid ;
      protected long gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serieid ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodiosinopse ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Serienome ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Episodionome ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage_gxi ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Duracao ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Temporada ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_Notaimage ;
   }

   [DataContract(Name = @"WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface( SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "EpisodioId" , Order = 0 )]
      public String gxTpr_Episodioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Episodioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Episodioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "SerieNome" , Order = 1 )]
      public String gxTpr_Serienome
      {
         get {
            return sdt.gxTpr_Serienome ;
         }

         set {
            sdt.gxTpr_Serienome = value;
         }

      }

      [DataMember( Name = "EpisodioNome" , Order = 2 )]
      public String gxTpr_Episodionome
      {
         get {
            return sdt.gxTpr_Episodionome ;
         }

         set {
            sdt.gxTpr_Episodionome = value;
         }

      }

      [DataMember( Name = "EpisodioSinopse" , Order = 3 )]
      public String gxTpr_Episodiosinopse
      {
         get {
            return sdt.gxTpr_Episodiosinopse ;
         }

         set {
            sdt.gxTpr_Episodiosinopse = value;
         }

      }

      [DataMember( Name = "SerieId" , Order = 4 )]
      public String gxTpr_Serieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Serieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Serieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Notaimage" , Order = 5 )]
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

      [DataMember( Name = "Duracao" , Order = 6 )]
      public String gxTpr_Duracao
      {
         get {
            return sdt.gxTpr_Duracao ;
         }

         set {
            sdt.gxTpr_Duracao = value;
         }

      }

      [DataMember( Name = "Temporada" , Order = 7 )]
      public String gxTpr_Temporada
      {
         get {
            return sdt.gxTpr_Temporada ;
         }

         set {
            sdt.gxTpr_Temporada = value;
         }

      }

      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt sdt
      {
         get {
            return (SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt() ;
         }
      }

   }

}
