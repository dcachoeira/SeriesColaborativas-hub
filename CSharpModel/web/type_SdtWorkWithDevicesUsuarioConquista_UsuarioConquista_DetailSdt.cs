/*
               File: type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt
        Description: WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.13
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
   [XmlRoot(ElementName = "WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt : GxUserType
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt_RESTInterface( SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt psdt ) : base(psdt)
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

      public SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt sdt
      {
         get {
            return (SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt() ;
         }
      }

   }

}