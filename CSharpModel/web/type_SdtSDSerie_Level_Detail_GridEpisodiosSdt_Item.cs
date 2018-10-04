/*
               File: type_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item
        Description: SDSerie_Level_Detail_GridEpisodiosSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 20:57:32.18
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
   public class SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item : GxUserType
   {
      public SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop = "";
      }

      public SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop ;
         }

         set {
            gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_Gxdynprop ;
   }

   [DataContract(Name = @"SDSerie_Level_Detail_GridEpisodiosSdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item_RESTInterface( SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Gxdynprop" , Order = 0 )]
      public String gxTpr_Gxdynprop
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdynprop) ;
         }

         set {
            sdt.gxTpr_Gxdynprop = value;
         }

      }

      public SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item sdt
      {
         get {
            return (SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item)Sdt ;
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
            sdt = new SdtSDSerie_Level_Detail_GridEpisodiosSdt_Item() ;
         }
      }

   }

}
