/*
               File: type_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt
        Description: WorkWithDevicesNotificacao_Notificacao_ListSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:46:0.75
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
   [XmlRoot(ElementName = "WorkWithDevicesNotificacao_Notificacao_ListSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesNotificacao_Notificacao_ListSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesNotificacao_Notificacao_ListSdt : GxUserType
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesNotificacao_Notificacao_ListSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesNotificacao_Notificacao_ListSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt_RESTInterface( SdtWorkWithDevicesNotificacao_Notificacao_ListSdt psdt ) : base(psdt)
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

      public SdtWorkWithDevicesNotificacao_Notificacao_ListSdt sdt
      {
         get {
            return (SdtWorkWithDevicesNotificacao_Notificacao_ListSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesNotificacao_Notificacao_ListSdt() ;
         }
      }

   }

}
