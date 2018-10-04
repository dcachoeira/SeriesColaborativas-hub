/*
               File: type_SdtSDComentarios_Level_Detail_Grid1Sdt_Item
        Description: SDComentarios_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 10/1/2018 14:37:14.63
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
   public class SdtSDComentarios_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtSDComentarios_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao = "";
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = "";
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = "";
      }

      public SdtSDComentarios_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("Avaliacao", gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao, false);
         AddObjectProperty("Avaliacao_GXI", gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Avaliacao" )]
      [  XmlElement( ElementName = "Avaliacao"   )]
      [GxUpload()]
      public String gxTpr_Avaliacao
      {
         get {
            return gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao ;
         }

         set {
            gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao = value;
            SetDirty("Avaliacao");
         }

      }

      [  SoapElement( ElementName = "Avaliacao_GXI" )]
      [  XmlElement( ElementName = "Avaliacao_GXI"   )]
      public String gxTpr_Avaliacao_gxi
      {
         get {
            return gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi ;
         }

         set {
            gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = value;
            SetDirty("Avaliacao_gxi");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao = "";
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = "";
         gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Gxdynprop ;
      protected String gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi ;
      protected String gxTv_SdtSDComentarios_Level_Detail_Grid1Sdt_Item_Avaliacao ;
   }

   [DataContract(Name = @"SDComentarios_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDComentarios_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDComentarios_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtSDComentarios_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Avaliacao" , Order = 0 )]
      [GxUpload()]
      public String gxTpr_Avaliacao
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Avaliacao)) ? PathUtil.RelativeURL( sdt.gxTpr_Avaliacao) : StringUtil.RTrim( sdt.gxTpr_Avaliacao_gxi)) ;
         }

         set {
            sdt.gxTpr_Avaliacao = value;
         }

      }

      [DataMember( Name = "Gxdynprop" , Order = 1 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSDComentarios_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtSDComentarios_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtSDComentarios_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
