/*
               File: type_SdtWorkWithDevicesSerie_Serie_DetailSdt
        Description: WorkWithDevicesSerie_Serie_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.88
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
   [XmlRoot(ElementName = "WorkWithDevicesSerie_Serie_DetailSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesSerie_Serie_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_DetailSdt : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesSerie_Serie_DetailSdt( IGxContext context )
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
         AddObjectProperty("SerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Serieid), 18, 0)), false);
         AddObjectProperty("Favoritar", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar, false);
         AddObjectProperty("Favoritar_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi, false);
         AddObjectProperty("Assistido", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Assistido, false);
         AddObjectProperty("Favorita", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favorita, false);
         AddObjectProperty("Marcarassistido", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido, false);
         AddObjectProperty("Marcarassistido_GXI", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "SerieId" )]
      [  XmlElement( ElementName = "SerieId"   )]
      public long gxTpr_Serieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Serieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Serieid = value;
            SetDirty("Serieid");
         }

      }

      [  SoapElement( ElementName = "Favoritar" )]
      [  XmlElement( ElementName = "Favoritar"   )]
      [GxUpload()]
      public String gxTpr_Favoritar
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar = value;
            SetDirty("Favoritar");
         }

      }

      [  SoapElement( ElementName = "Favoritar_GXI" )]
      [  XmlElement( ElementName = "Favoritar_GXI"   )]
      public String gxTpr_Favoritar_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi = value;
            SetDirty("Favoritar_gxi");
         }

      }

      [  SoapElement( ElementName = "Assistido" )]
      [  XmlElement( ElementName = "Assistido"   )]
      public bool gxTpr_Assistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Assistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Assistido = value;
            SetDirty("Assistido");
         }

      }

      [  SoapElement( ElementName = "Favorita" )]
      [  XmlElement( ElementName = "Favorita"   )]
      public bool gxTpr_Favorita
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favorita ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favorita = value;
            SetDirty("Favorita");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido" )]
      [  XmlElement( ElementName = "Marcarassistido"   )]
      [GxUpload()]
      public String gxTpr_Marcarassistido
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido = value;
            SetDirty("Marcarassistido");
         }

      }

      [  SoapElement( ElementName = "Marcarassistido_GXI" )]
      [  XmlElement( ElementName = "Marcarassistido_GXI"   )]
      public String gxTpr_Marcarassistido_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi = value;
            SetDirty("Marcarassistido_gxi");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi = "";
         gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Serieid ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Gxdynprop ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Assistido ;
      protected bool gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favorita ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido_gxi ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Favoritar ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_DetailSdt_Marcarassistido ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_DetailSdt_RESTInterface( SdtWorkWithDevicesSerie_Serie_DetailSdt psdt ) : base(psdt)
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

      [DataMember( Name = "Assistido" , Order = 2 )]
      public bool gxTpr_Assistido
      {
         get {
            return sdt.gxTpr_Assistido ;
         }

         set {
            sdt.gxTpr_Assistido = value;
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

      [DataMember( Name = "Marcarassistido" , Order = 4 )]
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

      [DataMember( Name = "Gxdynprop" , Order = 5 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_DetailSdt sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_DetailSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_DetailSdt() ;
         }
      }

   }

}
