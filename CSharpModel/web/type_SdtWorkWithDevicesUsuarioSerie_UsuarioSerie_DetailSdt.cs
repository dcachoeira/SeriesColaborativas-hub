/*
               File: type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt
        Description: WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.83
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
   [XmlRoot(ElementName = "WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt : GxUserType
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt_RESTInterface( SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt psdt ) : base(psdt)
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

      public SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt() ;
         }
      }

   }

}