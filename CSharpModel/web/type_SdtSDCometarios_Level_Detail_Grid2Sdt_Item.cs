/*
               File: type_SdtSDCometarios_Level_Detail_Grid2Sdt_Item
        Description: SDCometarios_Level_Detail_Grid2Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.11
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
   public class SdtSDCometarios_Level_Detail_Grid2Sdt_Item : GxUserType
   {
      public SdtSDCometarios_Level_Detail_Grid2Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi = "";
      }

      public SdtSDCometarios_Level_Detail_Grid2Sdt_Item( IGxContext context )
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
         AddObjectProperty("Um", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um, false);
         AddObjectProperty("Um_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi, false);
         AddObjectProperty("Dois", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois, false);
         AddObjectProperty("Dois_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi, false);
         AddObjectProperty("Tres", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres, false);
         AddObjectProperty("Tres_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi, false);
         AddObjectProperty("Quatro", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro, false);
         AddObjectProperty("Quatro_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi, false);
         AddObjectProperty("Cinco", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco, false);
         AddObjectProperty("Cinco_GXI", gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi, false);
         return  ;
      }

      [  SoapElement( ElementName = "Um" )]
      [  XmlElement( ElementName = "Um"   )]
      [GxUpload()]
      public String gxTpr_Um
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um = value;
            SetDirty("Um");
         }

      }

      [  SoapElement( ElementName = "Um_GXI" )]
      [  XmlElement( ElementName = "Um_GXI"   )]
      public String gxTpr_Um_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi = value;
            SetDirty("Um_gxi");
         }

      }

      [  SoapElement( ElementName = "Dois" )]
      [  XmlElement( ElementName = "Dois"   )]
      [GxUpload()]
      public String gxTpr_Dois
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois = value;
            SetDirty("Dois");
         }

      }

      [  SoapElement( ElementName = "Dois_GXI" )]
      [  XmlElement( ElementName = "Dois_GXI"   )]
      public String gxTpr_Dois_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi = value;
            SetDirty("Dois_gxi");
         }

      }

      [  SoapElement( ElementName = "Tres" )]
      [  XmlElement( ElementName = "Tres"   )]
      [GxUpload()]
      public String gxTpr_Tres
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres = value;
            SetDirty("Tres");
         }

      }

      [  SoapElement( ElementName = "Tres_GXI" )]
      [  XmlElement( ElementName = "Tres_GXI"   )]
      public String gxTpr_Tres_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi = value;
            SetDirty("Tres_gxi");
         }

      }

      [  SoapElement( ElementName = "Quatro" )]
      [  XmlElement( ElementName = "Quatro"   )]
      [GxUpload()]
      public String gxTpr_Quatro
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro = value;
            SetDirty("Quatro");
         }

      }

      [  SoapElement( ElementName = "Quatro_GXI" )]
      [  XmlElement( ElementName = "Quatro_GXI"   )]
      public String gxTpr_Quatro_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi = value;
            SetDirty("Quatro_gxi");
         }

      }

      [  SoapElement( ElementName = "Cinco" )]
      [  XmlElement( ElementName = "Cinco"   )]
      [GxUpload()]
      public String gxTpr_Cinco
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco = value;
            SetDirty("Cinco");
         }

      }

      [  SoapElement( ElementName = "Cinco_GXI" )]
      [  XmlElement( ElementName = "Cinco_GXI"   )]
      public String gxTpr_Cinco_gxi
      {
         get {
            return gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi ;
         }

         set {
            gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi = value;
            SetDirty("Cinco_gxi");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco = "";
         gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi = "";
         return  ;
      }

      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco_gxi ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Um ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Dois ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Tres ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Quatro ;
      protected String gxTv_SdtSDCometarios_Level_Detail_Grid2Sdt_Item_Cinco ;
   }

   [DataContract(Name = @"SDCometarios_Level_Detail_Grid2Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtSDCometarios_Level_Detail_Grid2Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface( SdtSDCometarios_Level_Detail_Grid2Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Um" , Order = 0 )]
      [GxUpload()]
      public String gxTpr_Um
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Um)) ? PathUtil.RelativeURL( sdt.gxTpr_Um) : StringUtil.RTrim( sdt.gxTpr_Um_gxi)) ;
         }

         set {
            sdt.gxTpr_Um = value;
         }

      }

      [DataMember( Name = "Dois" , Order = 1 )]
      [GxUpload()]
      public String gxTpr_Dois
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Dois)) ? PathUtil.RelativeURL( sdt.gxTpr_Dois) : StringUtil.RTrim( sdt.gxTpr_Dois_gxi)) ;
         }

         set {
            sdt.gxTpr_Dois = value;
         }

      }

      [DataMember( Name = "Tres" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Tres
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Tres)) ? PathUtil.RelativeURL( sdt.gxTpr_Tres) : StringUtil.RTrim( sdt.gxTpr_Tres_gxi)) ;
         }

         set {
            sdt.gxTpr_Tres = value;
         }

      }

      [DataMember( Name = "Quatro" , Order = 3 )]
      [GxUpload()]
      public String gxTpr_Quatro
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Quatro)) ? PathUtil.RelativeURL( sdt.gxTpr_Quatro) : StringUtil.RTrim( sdt.gxTpr_Quatro_gxi)) ;
         }

         set {
            sdt.gxTpr_Quatro = value;
         }

      }

      [DataMember( Name = "Cinco" , Order = 4 )]
      [GxUpload()]
      public String gxTpr_Cinco
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Cinco)) ? PathUtil.RelativeURL( sdt.gxTpr_Cinco) : StringUtil.RTrim( sdt.gxTpr_Cinco_gxi)) ;
         }

         set {
            sdt.gxTpr_Cinco = value;
         }

      }

      public SdtSDCometarios_Level_Detail_Grid2Sdt_Item sdt
      {
         get {
            return (SdtSDCometarios_Level_Detail_Grid2Sdt_Item)Sdt ;
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
            sdt = new SdtSDCometarios_Level_Detail_Grid2Sdt_Item() ;
         }
      }

   }

}
