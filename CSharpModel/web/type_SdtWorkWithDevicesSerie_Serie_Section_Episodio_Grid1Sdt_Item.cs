/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item
        Description: WorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:37:6.94
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
   public class SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome = "";
      }

      public SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodioid), 18, 0)), false);
         AddObjectProperty("EpisodioNome", gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome, false);
         return  ;
      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "EpisodioNome" )]
      [  XmlElement( ElementName = "EpisodioNome"   )]
      public String gxTpr_Episodionome
      {
         get {
            return gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome ;
         }

         set {
            gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome = value;
            SetDirty("Episodionome");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodioid ;
      protected String gxTv_SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_Episodionome ;
   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "EpisodioId" , Order = 0 )]
      public String gxTpr_Episodioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Episodioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Episodioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "EpisodioNome" , Order = 1 )]
      public String gxTpr_Episodionome
      {
         get {
            return sdt.gxTpr_Episodionome ;
         }

         set {
            sdt.gxTpr_Episodionome = value;
         }

      }

      public SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_Episodio_Grid1Sdt_Item() ;
         }
      }

   }

}
