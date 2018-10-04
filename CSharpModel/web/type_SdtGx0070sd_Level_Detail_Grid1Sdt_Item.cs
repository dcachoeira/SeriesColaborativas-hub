/*
               File: type_SdtGx0070sd_Level_Detail_Grid1Sdt_Item
        Description: Gx0070sd_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:2.10
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
   public class SdtGx0070sd_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtGx0070sd_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome = "";
      }

      public SdtGx0070sd_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("ConquistaId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistaid), 18, 0)), false);
         AddObjectProperty("ConquistaPontos", gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistapontos, false);
         AddObjectProperty("ConquistaNome", gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome, false);
         return  ;
      }

      [  SoapElement( ElementName = "ConquistaId" )]
      [  XmlElement( ElementName = "ConquistaId"   )]
      public long gxTpr_Conquistaid
      {
         get {
            return gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistaid ;
         }

         set {
            gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistaid = value;
            SetDirty("Conquistaid");
         }

      }

      [  SoapElement( ElementName = "ConquistaPontos" )]
      [  XmlElement( ElementName = "ConquistaPontos"   )]
      public short gxTpr_Conquistapontos
      {
         get {
            return gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistapontos ;
         }

         set {
            gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistapontos = value;
            SetDirty("Conquistapontos");
         }

      }

      [  SoapElement( ElementName = "ConquistaNome" )]
      [  XmlElement( ElementName = "ConquistaNome"   )]
      public String gxTpr_Conquistanome
      {
         get {
            return gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome ;
         }

         set {
            gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome = value;
            SetDirty("Conquistanome");
         }

      }

      public void initialize( )
      {
         gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome = "";
         return  ;
      }

      protected short gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistapontos ;
      protected long gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistaid ;
      protected String gxTv_SdtGx0070sd_Level_Detail_Grid1Sdt_Item_Conquistanome ;
   }

   [DataContract(Name = @"Gx0070sd_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtGx0070sd_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtGx0070sd_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtGx0070sd_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
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

      [DataMember( Name = "ConquistaPontos" , Order = 1 )]
      public Nullable<short> gxTpr_Conquistapontos
      {
         get {
            return sdt.gxTpr_Conquistapontos ;
         }

         set {
            sdt.gxTpr_Conquistapontos = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ConquistaNome" , Order = 2 )]
      public String gxTpr_Conquistanome
      {
         get {
            return sdt.gxTpr_Conquistanome ;
         }

         set {
            sdt.gxTpr_Conquistanome = value;
         }

      }

      public SdtGx0070sd_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtGx0070sd_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtGx0070sd_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
