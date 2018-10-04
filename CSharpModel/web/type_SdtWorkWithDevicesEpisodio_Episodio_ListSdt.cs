/*
               File: type_SdtWorkWithDevicesEpisodio_Episodio_ListSdt
        Description: WorkWithDevicesEpisodio_Episodio_ListSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:19.37
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
   [XmlRoot(ElementName = "WorkWithDevicesEpisodio_Episodio_ListSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesEpisodio_Episodio_ListSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesEpisodio_Episodio_ListSdt : GxUserType
   {
      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop = "";
      }

      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt( IGxContext context )
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
         AddObjectProperty("Gxdynprop", gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop, false);
         return  ;
      }

      [  SoapElement( ElementName = "Gxdynprop" )]
      [  XmlElement( ElementName = "Gxdynprop"   )]
      public String gxTpr_Gxdynprop
      {
         get {
            return gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop ;
         }

         set {
            gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop = value;
            SetDirty("Gxdynprop");
         }

      }

      public void initialize( )
      {
         gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop = "";
         return  ;
      }

      protected String gxTv_SdtWorkWithDevicesEpisodio_Episodio_ListSdt_Gxdynprop ;
   }

   [DataContract(Name = @"WorkWithDevicesEpisodio_Episodio_ListSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesEpisodio_Episodio_ListSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt_RESTInterface( SdtWorkWithDevicesEpisodio_Episodio_ListSdt psdt ) : base(psdt)
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

      public SdtWorkWithDevicesEpisodio_Episodio_ListSdt sdt
      {
         get {
            return (SdtWorkWithDevicesEpisodio_Episodio_ListSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesEpisodio_Episodio_ListSdt() ;
         }
      }

   }

}
