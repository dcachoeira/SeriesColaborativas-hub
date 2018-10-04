/*
               File: type_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item
        Description: WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.77
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
   public class SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto = "";
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("NotificacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoid), 18, 0)), false);
         AddObjectProperty("NotificacaoTexto", gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto, false);
         AddObjectProperty("NotificacaoTipo", gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotipo, false);
         AddObjectProperty("NotificacaoLigacaoId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoligacaoid), 18, 0)), false);
         return  ;
      }

      [  SoapElement( ElementName = "NotificacaoId" )]
      [  XmlElement( ElementName = "NotificacaoId"   )]
      public long gxTpr_Notificacaoid
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoid = value;
            SetDirty("Notificacaoid");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTexto" )]
      [  XmlElement( ElementName = "NotificacaoTexto"   )]
      public String gxTpr_Notificacaotexto
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto = value;
            SetDirty("Notificacaotexto");
         }

      }

      [  SoapElement( ElementName = "NotificacaoTipo" )]
      [  XmlElement( ElementName = "NotificacaoTipo"   )]
      public short gxTpr_Notificacaotipo
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotipo ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotipo = value;
            SetDirty("Notificacaotipo");
         }

      }

      [  SoapElement( ElementName = "NotificacaoLigacaoId" )]
      [  XmlElement( ElementName = "NotificacaoLigacaoId"   )]
      public long gxTpr_Notificacaoligacaoid
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoligacaoid ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoligacaoid = value;
            SetDirty("Notificacaoligacaoid");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotipo ;
      protected long gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoid ;
      protected long gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaoligacaoid ;
      protected String gxTv_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_Notificacaotexto ;
   }

   [DataContract(Name = @"WorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "NotificacaoId" , Order = 0 )]
      public String gxTpr_Notificacaoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Notificacaoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Notificacaoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "NotificacaoTexto" , Order = 1 )]
      public String gxTpr_Notificacaotexto
      {
         get {
            return sdt.gxTpr_Notificacaotexto ;
         }

         set {
            sdt.gxTpr_Notificacaotexto = value;
         }

      }

      [DataMember( Name = "NotificacaoTipo" , Order = 2 )]
      public Nullable<short> gxTpr_Notificacaotipo
      {
         get {
            return sdt.gxTpr_Notificacaotipo ;
         }

         set {
            sdt.gxTpr_Notificacaotipo = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "NotificacaoLigacaoId" , Order = 3 )]
      public String gxTpr_Notificacaoligacaoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Notificacaoligacaoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Notificacaoligacaoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      public SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item() ;
         }
      }

   }

}
