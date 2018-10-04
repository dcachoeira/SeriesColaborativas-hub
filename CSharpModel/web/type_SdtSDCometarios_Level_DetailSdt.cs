/*
               File: type_SdtSDCometarios_Level_DetailSdt
        Description: SDCometarios_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.6
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
   [XmlRoot(ElementName = "SDCometarios_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDCometarios_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDCometarios_Level_DetailSdt : GxUserType
   {
      public SdtSDCometarios_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDCometarios_Level_DetailSdt_Comentario = "";
         gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop = "";
      }

      public SdtSDCometarios_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("Comentario", gxTv_SdtSDCometarios_Level_DetailSdt_Comentario, false);
         AddObjectProperty("Nota", gxTv_SdtSDCometarios_Level_DetailSdt_Nota, false);
         AddObjectProperty("Tipocomentario", gxTv_SdtSDCometarios_Level_DetailSdt_Tipocomentario, false);
         AddObjectProperty("Id", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDCometarios_Level_DetailSdt_Id), 18, 0)), false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Comentario" )]
      [  XmlElement( ElementName = "Comentario"   )]
      public String gxTpr_Comentario
      {
         get {
            return gxTv_SdtSDCometarios_Level_DetailSdt_Comentario ;
         }

         set {
            gxTv_SdtSDCometarios_Level_DetailSdt_Comentario = value;
            SetDirty("Comentario");
         }

      }

      [  SoapElement( ElementName = "Nota" )]
      [  XmlElement( ElementName = "Nota"   )]
      public short gxTpr_Nota
      {
         get {
            return gxTv_SdtSDCometarios_Level_DetailSdt_Nota ;
         }

         set {
            gxTv_SdtSDCometarios_Level_DetailSdt_Nota = value;
            SetDirty("Nota");
         }

      }

      [  SoapElement( ElementName = "Tipocomentario" )]
      [  XmlElement( ElementName = "Tipocomentario"   )]
      public short gxTpr_Tipocomentario
      {
         get {
            return gxTv_SdtSDCometarios_Level_DetailSdt_Tipocomentario ;
         }

         set {
            gxTv_SdtSDCometarios_Level_DetailSdt_Tipocomentario = value;
            SetDirty("Tipocomentario");
         }

      }

      [  SoapElement( ElementName = "Id" )]
      [  XmlElement( ElementName = "Id"   )]
      public long gxTpr_Id
      {
         get {
            return gxTv_SdtSDCometarios_Level_DetailSdt_Id ;
         }

         set {
            gxTv_SdtSDCometarios_Level_DetailSdt_Id = value;
            SetDirty("Id");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDCometarios_Level_DetailSdt_Comentario = "";
         gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected short gxTv_SdtSDCometarios_Level_DetailSdt_Nota ;
      protected short gxTv_SdtSDCometarios_Level_DetailSdt_Tipocomentario ;
      protected long gxTv_SdtSDCometarios_Level_DetailSdt_Id ;
      protected String gxTv_SdtSDCometarios_Level_DetailSdt_Gxdynprop ;
      protected String gxTv_SdtSDCometarios_Level_DetailSdt_Comentario ;
   }

   [DataContract(Name = @"SDCometarios_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDCometarios_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDCometarios_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDCometarios_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDCometarios_Level_DetailSdt_RESTInterface( SdtSDCometarios_Level_DetailSdt psdt ) : base(psdt)
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

      [DataMember( Name = "Tipocomentario" , Order = 2 )]
      public Nullable<short> gxTpr_Tipocomentario
      {
         get {
            return sdt.gxTpr_Tipocomentario ;
         }

         set {
            sdt.gxTpr_Tipocomentario = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "Id" , Order = 3 )]
      public String gxTpr_Id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 4 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSDCometarios_Level_DetailSdt sdt
      {
         get {
            return (SdtSDCometarios_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSDCometarios_Level_DetailSdt() ;
         }
      }

   }

}
