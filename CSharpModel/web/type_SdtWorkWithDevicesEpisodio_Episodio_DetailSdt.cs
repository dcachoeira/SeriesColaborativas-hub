/*
               File: type_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt
        Description: WorkWithDevicesEpisodio_Episodio_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:19.31
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
   [XmlRoot(ElementName = "WorkWithDevicesEpisodio_Episodio_DetailSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesEpisodio_Episodio_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesEpisodio_Episodio_DetailSdt : GxUserType
   {
      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt( IGxContext context )
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
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Episodioid), 18, 0)), false);
         AddObjectProperty("Favoritar", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar, false);
         AddObjectProperty("Favoritar_GXI", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi, false);
         AddObjectProperty("Marcarassistido", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido, false);
         AddObjectProperty("Marcarassistido_GXI", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi, false);
         AddObjectProperty("Favorita", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorita, false);
         AddObjectProperty("Assistido", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Assistido, false);
         AddObjectProperty("Favorito", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorito, false);
         AddObjectProperty("Usuarioid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Episodioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "Favoritar" )]
      [  XmlElement( ElementName = "Favoritar"   )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar = value;
            SetDirty("Favoritar");
         }

      }

      [  SoapElement( ElementName = "Favoritar_GXI" )]
      [  XmlElement( ElementName = "Favoritar_GXI"   )]
      public String gxTpr_Favoritar_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi = value;
            SetDirty("Favoritar_gxi");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido" )]
      [  XmlElement( ElementName = "Marcarassistido"   )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido = value;
            SetDirty("Marcarassistido");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido_GXI" )]
      [  XmlElement( ElementName = "Marcarassistido_GXI"   )]
      public String gxTpr_Marcarassistido_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi = value;
            SetDirty("Marcarassistido_gxi");
         }

      }

      [  SoapElement( ElementName = "Favorita" )]
      [  XmlElement( ElementName = "Favorita"   )]
      public bool gxTpr_Favorita
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorita ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorita = value;
            SetDirty("Favorita");
         }

      }

      [  SoapElement( ElementName = "Assistido" )]
      [  XmlElement( ElementName = "Assistido"   )]
      public bool gxTpr_Assistido
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Assistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Assistido = value;
            SetDirty("Assistido");
         }

      }

      [  SoapElement( ElementName = "Favorito" )]
      [  XmlElement( ElementName = "Favorito"   )]
      public bool gxTpr_Favorito
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorito ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorito = value;
            SetDirty("Favorito");
         }

      }

      [  SoapElement( ElementName = "Usuarioid" )]
      [  XmlElement( ElementName = "Usuarioid"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Usuarioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Episodioid ;
      protected long gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Usuarioid ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Gxdynprop ;
      protected bool gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorita ;
      protected bool gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Assistido ;
      protected bool gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favorito ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar_gxi ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido_gxi ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Favoritar ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_Marcarassistido ;
   }

   [DataContract(Name = @"WorkWithDevicesEpisodio_Episodio_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesEpisodio_Episodio_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt_RESTInterface( SdtWorkWithDevicesEpisodio_Episodio_DetailSdt psdt ) : base(psdt)
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

      [DataMember( Name = "Favoritar" , Order = 1 )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Favoritar)) ? PathUtil.RelativeURL( sdt.gxTpr_Favoritar) : StringUtil.RTrim( sdt.gxTpr_Favoritar_gxi)) ;
         }

         set {
            sdt.gxTpr_Favoritar = value;
         }

      }

      [DataMember( Name = "Marcarassistido" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Marcarassistido)) ? PathUtil.RelativeURL( sdt.gxTpr_Marcarassistido) : StringUtil.RTrim( sdt.gxTpr_Marcarassistido_gxi)) ;
         }

         set {
            sdt.gxTpr_Marcarassistido = value;
         }

      }

      [DataMember( Name = "Favorita" , Order = 3 )]
      public bool gxTpr_Favorita
      {
         get {
            return sdt.gxTpr_Favorita ;
         }

         set {
            sdt.gxTpr_Favorita = value;
         }

      }

      [DataMember( Name = "Assistido" , Order = 4 )]
      public bool gxTpr_Assistido
      {
         get {
            return sdt.gxTpr_Assistido ;
         }

         set {
            sdt.gxTpr_Assistido = value;
         }

      }

      [DataMember( Name = "Favorito" , Order = 5 )]
      public bool gxTpr_Favorito
      {
         get {
            return sdt.gxTpr_Favorito ;
         }

         set {
            sdt.gxTpr_Favorito = value;
         }

      }

      [DataMember( Name = "Usuarioid" , Order = 6 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 7 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtWorkWithDevicesEpisodio_Episodio_DetailSdt sdt
      {
         get {
            return (SdtWorkWithDevicesEpisodio_Episodio_DetailSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesEpisodio_Episodio_DetailSdt() ;
         }
      }

   }

}
