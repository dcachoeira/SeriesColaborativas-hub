/*
               File: type_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item
        Description: WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:19.39
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
   public class SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item : GxUserType
   {
      public SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi = "";
      }

      public SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("EpisodioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodioid), 18, 0)), false);
         AddObjectProperty("EpisodioNome", gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome, false);
         AddObjectProperty("Favorito", gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito, false);
         AddObjectProperty("Favorito_GXI", gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi, false);
         AddObjectProperty("Assistido", gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido, false);
         AddObjectProperty("Assistido_GXI", gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "EpisodioId" )]
      [  XmlElement( ElementName = "EpisodioId"   )]
      public long gxTpr_Episodioid
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodioid = value;
            SetDirty("Episodioid");
         }

      }

      [  SoapElement( ElementName = "EpisodioNome" )]
      [  XmlElement( ElementName = "EpisodioNome"   )]
      public String gxTpr_Episodionome
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome = value;
            SetDirty("Episodionome");
         }

      }

      [  SoapElement( ElementName = "Favorito" )]
      [  XmlElement( ElementName = "Favorito"   )]
      [GxUpload()]
      public String gxTpr_Favorito
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito = value;
            SetDirty("Favorito");
         }

      }

      [  SoapElement( ElementName = "Favorito_GXI" )]
      [  XmlElement( ElementName = "Favorito_GXI"   )]
      public String gxTpr_Favorito_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi = value;
            SetDirty("Favorito_gxi");
         }

      }

      [  SoapElement( ElementName = "Assistido" )]
      [  XmlElement( ElementName = "Assistido"   )]
      [GxUpload()]
      public String gxTpr_Assistido
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido = value;
            SetDirty("Assistido");
         }

      }

      [  SoapElement( ElementName = "Assistido_GXI" )]
      [  XmlElement( ElementName = "Assistido_GXI"   )]
      public String gxTpr_Assistido_gxi
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi = value;
            SetDirty("Assistido_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido = "";
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodioid ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Episodionome ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito_gxi ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido_gxi ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Favorito ;
      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_Assistido ;
   }

   [DataContract(Name = @"WorkWithDevicesEpisodio_Episodio_List_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item_RESTInterface( SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item psdt ) : base(psdt)
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

      [DataMember( Name = "Favorito" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Favorito
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Favorito)) ? PathUtil.RelativeURL( sdt.gxTpr_Favorito) : StringUtil.RTrim( sdt.gxTpr_Favorito_gxi)) ;
         }

         set {
            sdt.gxTpr_Favorito = value;
         }

      }

      [DataMember( Name = "Assistido" , Order = 3 )]
      [GxUpload()]
      public String gxTpr_Assistido
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Assistido)) ? PathUtil.RelativeURL( sdt.gxTpr_Assistido) : StringUtil.RTrim( sdt.gxTpr_Assistido_gxi)) ;
         }

         set {
            sdt.gxTpr_Assistido = value;
         }

      }

      public SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item sdt
      {
         get {
            return (SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item() ;
         }
      }

   }

}
