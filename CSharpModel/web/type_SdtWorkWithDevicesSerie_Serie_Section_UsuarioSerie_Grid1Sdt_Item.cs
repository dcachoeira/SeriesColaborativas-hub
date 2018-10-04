/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item
        Description: WorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:37:7.1
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
   public class SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("UsuarioSerieId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserieid), 18, 0)), false);
         AddObjectProperty("UsuarioSerieNota", gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserienota, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioSerieId" )]
      [  XmlElement( ElementName = "UsuarioSerieId"   )]
      public long gxTpr_Usuarioserieid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserieid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserieid = value;
            SetDirty("Usuarioserieid");
         }

      }

      [  SoapElement( ElementName = "UsuarioSerieNota" )]
      [  XmlElement( ElementName = "UsuarioSerieNota"   )]
      public short gxTpr_Usuarioserienota
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserienota ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserienota = value;
            SetDirty("Usuarioserienota");
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserienota ;
      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_Usuarioserieid ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioSerieId" , Order = 0 )]
      public String gxTpr_Usuarioserieid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioserieid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioserieid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioSerieNota" , Order = 1 )]
      public Nullable<short> gxTpr_Usuarioserienota
      {
         get {
            return sdt.gxTpr_Usuarioserienota ;
         }

         set {
            sdt.gxTpr_Usuarioserienota = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_UsuarioSerie_Grid1Sdt_Item() ;
         }
      }

   }

}
