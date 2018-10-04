/*
               File: type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.84
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
   [XmlRoot(ElementName = "WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt : GxUserType
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall = "";
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt( IGxContext context )
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
         AddObjectProperty("Usuarioid", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop, false);
         AddObjectProperty("Gxdyncall", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall, false);
         return  ;
      }

      [  SoapElement( ElementName = "Usuarioid" )]
      [  XmlElement( ElementName = "Usuarioid"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Usuarioid ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      [  SoapElement( ElementName = "Gxdyncall" )]
      [  XmlElement( ElementName = "Gxdyncall"   )]
      public String gxTpr_Gxdyncall
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall = value;
            SetDirty("Gxdyncall");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop = "";
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall = "";
         return  ;
      }

      protected long gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Usuarioid ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdynprop ;
      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_Gxdyncall ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt_RESTInterface( SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "Usuarioid" , Order = 0 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "Gxdyncall" , Order = 2 )]
      public String gxTpr_Gxdyncall
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Gxdyncall) ;
         }

         set {
            sdt.gxTpr_Gxdyncall = value;
         }

      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt() ;
         }
      }

   }

}
