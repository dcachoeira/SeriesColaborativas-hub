/*
               File: type_SdtSDRanking_Level_Detail_Grid1Sdt_Item
        Description: SDRanking_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:32.60
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
   public class SdtSDRanking_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtSDRanking_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome = "";
      }

      public SdtSDRanking_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioid), 18, 0)), false);
         AddObjectProperty("UsuarioNome", gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome, false);
         AddObjectProperty("UsuarioQuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioquantidadepontos), 18, 0)), false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioid ;
         }

         set {
            gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioNome" )]
      [  XmlElement( ElementName = "UsuarioNome"   )]
      public String gxTpr_Usuarionome
      {
         get {
            return gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome ;
         }

         set {
            gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome = value;
            SetDirty("Usuarionome");
         }

      }

      [  SoapElement( ElementName = "UsuarioQuantidadePontos" )]
      [  XmlElement( ElementName = "UsuarioQuantidadePontos"   )]
      public long gxTpr_Usuarioquantidadepontos
      {
         get {
            return gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioquantidadepontos ;
         }

         set {
            gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioquantidadepontos = value;
            SetDirty("Usuarioquantidadepontos");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome = "";
         return  ;
      }

      protected long gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioid ;
      protected long gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarioquantidadepontos ;
      protected String gxTv_SdtSDRanking_Level_Detail_Grid1Sdt_Item_Usuarionome ;
   }

   [DataContract(Name = @"SDRanking_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDRanking_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDRanking_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtSDRanking_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioId" , Order = 0 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioNome" , Order = 1 )]
      public String gxTpr_Usuarionome
      {
         get {
            return sdt.gxTpr_Usuarionome ;
         }

         set {
            sdt.gxTpr_Usuarionome = value;
         }

      }

      [DataMember( Name = "UsuarioQuantidadePontos" , Order = 2 )]
      public String gxTpr_Usuarioquantidadepontos
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioquantidadepontos), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioquantidadepontos = (long)(NumberUtil.Val( value, "."));
         }

      }

      public SdtSDRanking_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtSDRanking_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtSDRanking_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
