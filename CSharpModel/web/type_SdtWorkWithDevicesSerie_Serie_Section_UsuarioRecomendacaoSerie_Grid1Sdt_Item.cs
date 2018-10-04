/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item
        Description: WorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:37:6.99
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
   [XmlRoot(ElementName = "Item" )]
   [XmlType(TypeName =  "Item" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario = "";
      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("UsuarioRecomendacaoSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoserieid), 18, 0)), false);
         AddObjectProperty("UsuarioRecomendacaoSerieComentario", gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioRecomendacaoSerieId" )]
      [  XmlElement( ElementName = "UsuarioRecomendacaoSerieId"   )]
      public long gxTpr_Usuariorecomendacaoserieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoserieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoserieid = value;
            SetDirty("Usuariorecomendacaoserieid");
         }

      }

      [  SoapElement( ElementName = "UsuarioRecomendacaoSerieComentario" )]
      [  XmlElement( ElementName = "UsuarioRecomendacaoSerieComentario"   )]
      public String gxTpr_Usuariorecomendacaoseriecomentario
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario = value;
            SetDirty("Usuariorecomendacaoseriecomentario");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoserieid ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_Usuariorecomendacaoseriecomentario ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioRecomendacaoSerieId" , Order = 0 )]
      public String gxTpr_Usuariorecomendacaoserieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuariorecomendacaoserieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuariorecomendacaoserieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioRecomendacaoSerieComentario" , Order = 1 )]
      public String gxTpr_Usuariorecomendacaoseriecomentario
      {
         get {
            return sdt.gxTpr_Usuariorecomendacaoseriecomentario ;
         }

         set {
            sdt.gxTpr_Usuariorecomendacaoseriecomentario = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_UsuarioRecomendacaoSerie_Grid1Sdt_Item() ;
         }
      }

   }

}
