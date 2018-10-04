/*
               File: type_SdtSDCometarios_Level_Detail_Grid1Sdt_Item
        Description: SDCometarios_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.8
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
   public class SdtSDCometarios_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtSDCometarios_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = "";
      }

      public SdtSDCometarios_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("Avaliacao", gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao, false);
         AddObjectProperty("Avaliacao_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Avaliacao" )]
      [  XmlElement( ElementName = "Avaliacao"   )]
      [GxUpload()]
      public String gxTpr_Avaliacao
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao = value;
            SetDirty("Avaliacao");
         }

      }

      [  SoapElement( ElementName = "Avaliacao_GXI" )]
      [  XmlElement( ElementName = "Avaliacao_GXI"   )]
      public String gxTpr_Avaliacao_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = value;
            SetDirty("Avaliacao_gxi");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Gxdynprop ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid1Sdt_Item_Avaliacao ;
   }

   [DataContract(Name = @"SDCometarios_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDCometarios_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDCometarios_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDCometarios_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDCometarios_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtSDCometarios_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
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

      public SdtSDCometarios_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtSDCometarios_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtSDCometarios_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
