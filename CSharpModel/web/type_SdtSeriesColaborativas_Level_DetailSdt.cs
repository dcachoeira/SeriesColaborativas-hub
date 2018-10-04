/*
               File: type_SdtSeriesColaborativas_Level_DetailSdt
        Description: SeriesColaborativas_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 15:27:19.4
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
   [XmlRoot(ElementName = "SeriesColaborativas_Level_DetailSdt" )]
   [XmlType(TypeName =  "SeriesColaborativas_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSeriesColaborativas_Level_DetailSdt : GxUserType
   {
      public SdtSeriesColaborativas_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop = "";
      }

      public SdtSeriesColaborativas_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Imagemusuario", gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario, false);
         AddObjectProperty("Imagemusuario_GXI", gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi, false);
         AddObjectProperty("Usuarionome", gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome, false);
         AddObjectProperty("Usuariotitulo", gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Imagemusuario" )]
      [  XmlElement( ElementName = "Imagemusuario"   )]
      [GxUpload()]
      public String gxTpr_Imagemusuario
      {
         get {
            return gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario ;
         }

         set {
            gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario = value;
            SetDirty("Imagemusuario");
         }

      }

      [  SoapElement( ElementName = "Imagemusuario_GXI" )]
      [  XmlElement( ElementName = "Imagemusuario_GXI"   )]
      public String gxTpr_Imagemusuario_gxi
      {
         get {
            return gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi ;
         }

         set {
            gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi = value;
            SetDirty("Imagemusuario_gxi");
         }

      }

      [  SoapElement( ElementName = "Usuarionome" )]
      [  XmlElement( ElementName = "Usuarionome"   )]
      public String gxTpr_Usuarionome
      {
         get {
            return gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome ;
         }

         set {
            gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome = value;
            SetDirty("Usuarionome");
         }

      }

      [  SoapElement( ElementName = "Usuariotitulo" )]
      [  XmlElement( ElementName = "Usuariotitulo"   )]
      public String gxTpr_Usuariotitulo
      {
         get {
            return gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo ;
         }

         set {
            gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo = value;
            SetDirty("Usuariotitulo");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo = "";
         gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtSeriesColaborativas_Level_DetailSdt_Gxdynprop ;
      protected String gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario_gxi ;
      protected String gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuarionome ;
      protected String gxTv_SdtSeriesColaborativas_Level_DetailSdt_Usuariotitulo ;
      protected String gxTv_SdtSeriesColaborativas_Level_DetailSdt_Imagemusuario ;
   }

   [DataContract(Name = @"SeriesColaborativas_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSeriesColaborativas_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSeriesColaborativas_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSeriesColaborativas_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSeriesColaborativas_Level_DetailSdt_RESTInterface( SdtSeriesColaborativas_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Imagemusuario" , Order = 0 )]
      [GxUpload()]
      public String gxTpr_Imagemusuario
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Imagemusuario)) ? PathUtil.RelativeURL( sdt.gxTpr_Imagemusuario) : StringUtil.RTrim( sdt.gxTpr_Imagemusuario_gxi)) ;
         }

         set {
            sdt.gxTpr_Imagemusuario = value;
         }

      }

      [DataMember( Name = "Usuarionome" , Order = 1 )]
      public String gxTpr_Usuarionome
      {
         get {
            return sdt.gxTpr_Usuarionome ;
         }

         set {
            sdt.gxTpr_Usuarionome = value;
         }

      }

      [DataMember( Name = "Usuariotitulo" , Order = 2 )]
      public String gxTpr_Usuariotitulo
      {
         get {
            return sdt.gxTpr_Usuariotitulo ;
         }

         set {
            sdt.gxTpr_Usuariotitulo = value;
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 3 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSeriesColaborativas_Level_DetailSdt sdt
      {
         get {
            return (SdtSeriesColaborativas_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSeriesColaborativas_Level_DetailSdt() ;
         }
      }

   }

}
