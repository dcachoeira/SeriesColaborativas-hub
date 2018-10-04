/*
               File: type_SdtGx0030sd_Level_Detail_Grid1Sdt_Item
        Description: Gx0030sd_Level_Detail_Grid1Sdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:47:27.50
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
   public class SdtGx0030sd_Level_Detail_Grid1Sdt_Item : GxUserType
   {
      public SdtGx0030sd_Level_Detail_Grid1Sdt_Item( )
      {
         /* Constructor for serialization */
         gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome = "";
      }

      public SdtGx0030sd_Level_Detail_Grid1Sdt_Item( IGxContext context )
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
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarioid), 18, 0)), false);
         AddObjectProperty("UsuarioNome", gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome, false);
         AddObjectProperty("UsuarioTipo", gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuariotipo, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarioid ;
         }

         set {
            gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioNome" )]
      [  XmlElement( ElementName = "UsuarioNome"   )]
      public String gxTpr_Usuarionome
      {
         get {
            return gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome ;
         }

         set {
            gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome = value;
            SetDirty("Usuarionome");
         }

      }

      [  SoapElement( ElementName = "UsuarioTipo" )]
      [  XmlElement( ElementName = "UsuarioTipo"   )]
      public short gxTpr_Usuariotipo
      {
         get {
            return gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuariotipo ;
         }

         set {
            gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuariotipo = value;
            SetDirty("Usuariotipo");
         }

      }

      public void initialize( )
      {
         gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome = "";
         return  ;
      }

      protected short gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuariotipo ;
      protected long gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarioid ;
      protected String gxTv_SdtGx0030sd_Level_Detail_Grid1Sdt_Item_Usuarionome ;
   }

   [DataContract(Name = @"Gx0030sd_Level_Detail_Grid1Sdt.Item", Namespace = "http://tempuri.org/")]
   public class SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface : GxGenericCollectionItem<SdtGx0030sd_Level_Detail_Grid1Sdt_Item>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface( ) : base()
      {
      }

      public SdtGx0030sd_Level_Detail_Grid1Sdt_Item_RESTInterface( SdtGx0030sd_Level_Detail_Grid1Sdt_Item psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioId" , Order = 0 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioNome" , Order = 1 )]
      public String gxTpr_Usuarionome
      {
         get {
            return sdt.gxTpr_Usuarionome ;
         }

         set {
            sdt.gxTpr_Usuarionome = value;
         }

      }

      [DataMember( Name = "UsuarioTipo" , Order = 2 )]
      public Nullable<short> gxTpr_Usuariotipo
      {
         get {
            return sdt.gxTpr_Usuariotipo ;
         }

         set {
            sdt.gxTpr_Usuariotipo = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtGx0030sd_Level_Detail_Grid1Sdt_Item sdt
      {
         get {
            return (SdtGx0030sd_Level_Detail_Grid1Sdt_Item)Sdt ;
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
            sdt = new SdtGx0030sd_Level_Detail_Grid1Sdt_Item() ;
         }
      }

   }

}
