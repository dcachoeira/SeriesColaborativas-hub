/*
               File: type_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item
        Description: Gx00B0sd_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.52
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
   public class SdtGx00B0sd_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtGx00B0sd_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome = "";
      }

      public SdtGx00B0sd_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("GeneroId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoid), 18, 0)), false);
         AddObjectProperty("GeneroNome", gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome, false);
         AddObjectProperty("GeneroInativo", gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoinativo, false);
         return  ;
      }

      [  SoapElement( ElementName = "GeneroId" )]
      [  XmlElement( ElementName = "GeneroId"   )]
      public long gxTpr_Generoid
      {
         get {
            return gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoid ;
         }

         set {
            gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoid = value;
            SetDirty("Generoid");
         }

      }

      [  SoapElement( ElementName = "GeneroNome" )]
      [  XmlElement( ElementName = "GeneroNome"   )]
      public String gxTpr_Generonome
      {
         get {
            return gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome ;
         }

         set {
            gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome = value;
            SetDirty("Generonome");
         }

      }

      [  SoapElement( ElementName = "GeneroInativo" )]
      [  XmlElement( ElementName = "GeneroInativo"   )]
      public bool gxTpr_Generoinativo
      {
         get {
            return gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoinativo ;
         }

         set {
            gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoinativo = value;
            SetDirty("Generoinativo");
         }

      }

      public void initialize( )
      {
         gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome = "";
         return  ;
      }

      protected long gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoid ;
      protected bool gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generoinativo ;
      protected String gxTv_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_Generonome ;
   }

   [DataContract(Name = @"Gx00B0sd_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtGx00B0sd_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtGx00B0sd_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtGx00B0sd_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "GeneroId" , Order = 0 )]
      public String gxTpr_Generoid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Generoid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Generoid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "GeneroNome" , Order = 1 )]
      public String gxTpr_Generonome
      {
         get {
            return sdt.gxTpr_Generonome ;
         }

         set {
            sdt.gxTpr_Generonome = value;
         }

      }

      [DataMember( Name = "GeneroInativo" , Order = 2 )]
      public bool gxTpr_Generoinativo
      {
         get {
            return sdt.gxTpr_Generoinativo ;
         }

         set {
            sdt.gxTpr_Generoinativo = value;
         }

      }

      public SdtGx00B0sd_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtGx00B0sd_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtGx00B0sd_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
