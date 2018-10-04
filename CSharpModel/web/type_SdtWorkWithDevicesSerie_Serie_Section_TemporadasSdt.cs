/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt
        Description: WorkWithDevicesSerie_Serie_Section_TemporadasSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:33.18
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
   [XmlRoot(ElementName = "WorkWithDevicesSerie_Serie_Section_TemporadasSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesSerie_Serie_Section_TemporadasSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt( IGxContext context )
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
         return  ;
      }

      public void initialize( )
      {
         return  ;
      }

   }

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_TemporadasSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt psdt ) : base(psdt)
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt() ;
         }
      }

   }

}
