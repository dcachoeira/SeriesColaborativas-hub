/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item
        Description: WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:23:58.29
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
   public class SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop = "";
      }

      public SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item( IGxContext context )
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
         AddObjectProperty("Temporada", gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Temporada, false);
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Temporada" )]
      [  XmlElement( ElementName = "Temporada"   )]
      public short gxTpr_Temporada
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Temporada ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Temporada = value;
            SetDirty("Temporada");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop = "";
         return  ;
      }

      protected short gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Temporada ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Temporada" , Order = 0 )]
      public Nullable<short> gxTpr_Temporada
      {
         get {
            return sdt.gxTpr_Temporada ;
         }

         set {
            sdt.gxTpr_Temporada = (short)(value.HasValue ? value.Value : 0);
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

      public SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodios_Grid2Sdt_Item() ;
         }
      }

   }

}