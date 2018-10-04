/*
               File: type_SdtSDComentarios_Level_DetailSdt
        Description: SDComentarios_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 10/1/2018 14:37:14.58
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
   [XmlRoot(ElementName = "SDComentarios_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDComentarios_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDComentarios_Level_DetailSdt : GxUserType
   {
      public SdtSDComentarios_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDComentarios_Level_DetailSdt_Comentario = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Um = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Dois = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Tres = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Quatro = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Cinco = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop = "";
      }

      public SdtSDComentarios_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Comentario", gxTv_SdtSDComentarios_Level_DetailSdt_Comentario, false);
         AddObjectProperty("Nota", gxTv_SdtSDComentarios_Level_DetailSdt_Nota, false);
         AddObjectProperty("Um", gxTv_SdtSDComentarios_Level_DetailSdt_Um, false);
         AddObjectProperty("Um_GXI", gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi, false);
         AddObjectProperty("Dois", gxTv_SdtSDComentarios_Level_DetailSdt_Dois, false);
         AddObjectProperty("Dois_GXI", gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi, false);
         AddObjectProperty("Tres", gxTv_SdtSDComentarios_Level_DetailSdt_Tres, false);
         AddObjectProperty("Tres_GXI", gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi, false);
         AddObjectProperty("Quatro", gxTv_SdtSDComentarios_Level_DetailSdt_Quatro, false);
         AddObjectProperty("Quatro_GXI", gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi, false);
         AddObjectProperty("Cinco", gxTv_SdtSDComentarios_Level_DetailSdt_Cinco, false);
         AddObjectProperty("Cinco_GXI", gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi, false);
         AddObjectProperty("Tipocomentario", gxTv_SdtSDComentarios_Level_DetailSdt_Tipocomentario, false);
         AddObjectProperty("Id", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDComentarios_Level_DetailSdt_Id), 18, 0)), false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Comentario" )]
      [  XmlElement( ElementName = "Comentario"   )]
      public String gxTpr_Comentario
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Comentario ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Comentario = value;
            SetDirty("Comentario");
         }

      }

      [  SoapElement( ElementName = "Nota" )]
      [  XmlElement( ElementName = "Nota"   )]
      public short gxTpr_Nota
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Nota ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Nota = value;
            SetDirty("Nota");
         }

      }

      [  SoapElement( ElementName = "Um" )]
      [  XmlElement( ElementName = "Um"   )]
      [GxUpload()]
      public String gxTpr_Um
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Um ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Um = value;
            SetDirty("Um");
         }

      }

      [  SoapElement( ElementName = "Um_GXI" )]
      [  XmlElement( ElementName = "Um_GXI"   )]
      public String gxTpr_Um_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi = value;
            SetDirty("Um_gxi");
         }

      }

      [  SoapElement( ElementName = "Dois" )]
      [  XmlElement( ElementName = "Dois"   )]
      [GxUpload()]
      public String gxTpr_Dois
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Dois ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Dois = value;
            SetDirty("Dois");
         }

      }

      [  SoapElement( ElementName = "Dois_GXI" )]
      [  XmlElement( ElementName = "Dois_GXI"   )]
      public String gxTpr_Dois_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi = value;
            SetDirty("Dois_gxi");
         }

      }

      [  SoapElement( ElementName = "Tres" )]
      [  XmlElement( ElementName = "Tres"   )]
      [GxUpload()]
      public String gxTpr_Tres
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Tres ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Tres = value;
            SetDirty("Tres");
         }

      }

      [  SoapElement( ElementName = "Tres_GXI" )]
      [  XmlElement( ElementName = "Tres_GXI"   )]
      public String gxTpr_Tres_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi = value;
            SetDirty("Tres_gxi");
         }

      }

      [  SoapElement( ElementName = "Quatro" )]
      [  XmlElement( ElementName = "Quatro"   )]
      [GxUpload()]
      public String gxTpr_Quatro
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Quatro ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Quatro = value;
            SetDirty("Quatro");
         }

      }

      [  SoapElement( ElementName = "Quatro_GXI" )]
      [  XmlElement( ElementName = "Quatro_GXI"   )]
      public String gxTpr_Quatro_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi = value;
            SetDirty("Quatro_gxi");
         }

      }

      [  SoapElement( ElementName = "Cinco" )]
      [  XmlElement( ElementName = "Cinco"   )]
      [GxUpload()]
      public String gxTpr_Cinco
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Cinco ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Cinco = value;
            SetDirty("Cinco");
         }

      }

      [  SoapElement( ElementName = "Cinco_GXI" )]
      [  XmlElement( ElementName = "Cinco_GXI"   )]
      public String gxTpr_Cinco_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi = value;
            SetDirty("Cinco_gxi");
         }

      }

      [  SoapElement( ElementName = "Tipocomentario" )]
      [  XmlElement( ElementName = "Tipocomentario"   )]
      public short gxTpr_Tipocomentario
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Tipocomentario ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Tipocomentario = value;
            SetDirty("Tipocomentario");
         }

      }

      [  SoapElement( ElementName = "Id" )]
      [  XmlElement( ElementName = "Id"   )]
      public long gxTpr_Id
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Id ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Id = value;
            SetDirty("Id");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDComentarios_Level_DetailSdt_Comentario = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Um = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Dois = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Tres = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Quatro = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Cinco = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi = "";
         gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected short gxTv_SdtSDComentarios_Level_DetailSdt_Nota ;
      protected short gxTv_SdtSDComentarios_Level_DetailSdt_Tipocomentario ;
      protected long gxTv_SdtSDComentarios_Level_DetailSdt_Id ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Gxdynprop ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Comentario ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Um_gxi ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Dois_gxi ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Tres_gxi ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Quatro_gxi ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Cinco_gxi ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Um ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Dois ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Tres ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Quatro ;
      protected String gxTv_SdtSDComentarios_Level_DetailSdt_Cinco ;
   }

   [DataContract(Name = @"SDComentarios_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDComentarios_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDComentarios_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDComentarios_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDComentarios_Level_DetailSdt_RESTInterface( SdtSDComentarios_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Comentario" , Order = 0 )]
      public String gxTpr_Comentario
      {
         get {
            return sdt.gxTpr_Comentario ;
         }

         set {
            sdt.gxTpr_Comentario = value;
         }

      }

      [DataMember( Name = "Nota" , Order = 1 )]
      public Nullable<short> gxTpr_Nota
      {
         get {
            return sdt.gxTpr_Nota ;
         }

         set {
            sdt.gxTpr_Nota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Um" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Um
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Um)) ? PathUtil.RelativeURL( sdt.gxTpr_Um) : StringUtil.RTrim( sdt.gxTpr_Um_gxi)) ;
         }

         set {
            sdt.gxTpr_Um = value;
         }

      }

      [DataMember( Name = "Dois" , Order = 3 )]
      [GxUpload()]
      public String gxTpr_Dois
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Dois)) ? PathUtil.RelativeURL( sdt.gxTpr_Dois) : StringUtil.RTrim( sdt.gxTpr_Dois_gxi)) ;
         }

         set {
            sdt.gxTpr_Dois = value;
         }

      }

      [DataMember( Name = "Tres" , Order = 4 )]
      [GxUpload()]
      public String gxTpr_Tres
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Tres)) ? PathUtil.RelativeURL( sdt.gxTpr_Tres) : StringUtil.RTrim( sdt.gxTpr_Tres_gxi)) ;
         }

         set {
            sdt.gxTpr_Tres = value;
         }

      }

      [DataMember( Name = "Quatro" , Order = 5 )]
      [GxUpload()]
      public String gxTpr_Quatro
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Quatro)) ? PathUtil.RelativeURL( sdt.gxTpr_Quatro) : StringUtil.RTrim( sdt.gxTpr_Quatro_gxi)) ;
         }

         set {
            sdt.gxTpr_Quatro = value;
         }

      }

      [DataMember( Name = "Cinco" , Order = 6 )]
      [GxUpload()]
      public String gxTpr_Cinco
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Cinco)) ? PathUtil.RelativeURL( sdt.gxTpr_Cinco) : StringUtil.RTrim( sdt.gxTpr_Cinco_gxi)) ;
         }

         set {
            sdt.gxTpr_Cinco = value;
         }

      }

      [DataMember( Name = "Tipocomentario" , Order = 7 )]
      public Nullable<short> gxTpr_Tipocomentario
      {
         get {
            return sdt.gxTpr_Tipocomentario ;
         }

         set {
            sdt.gxTpr_Tipocomentario = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Id" , Order = 8 )]
      public String gxTpr_Id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 9 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSDComentarios_Level_DetailSdt sdt
      {
         get {
            return (SdtSDComentarios_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSDComentarios_Level_DetailSdt() ;
         }
      }

   }

}
