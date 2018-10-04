/*
               File: type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.19
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
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop = "";
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item( IGxContext context )
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
         AddObjectProperty("ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Conquistaid), 18, 0)), false);
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "ConquistaId" )]
      [  XmlElement( ElementName = "ConquistaId"   )]
      public long gxTpr_Conquistaid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Conquistaid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Conquistaid = value;
            SetDirty("Conquistaid");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Conquistaid ;
      protected String gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item_RESTInterface( SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ConquistaId" , Order = 0 )]
      public String gxTpr_Conquistaid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Conquistaid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Conquistaid = (long)(NumberUtil.Val( value, "."));
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

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item() ;
         }
      }

   }

}
