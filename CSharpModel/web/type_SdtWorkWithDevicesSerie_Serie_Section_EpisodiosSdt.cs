/*
               File: type_SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt
        Description: WorkWithDevicesSerie_Serie_Section_EpisodiosSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 16:23:58.27
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
   [XmlRoot(ElementName = "WorkWithDevicesSerie_Serie_Section_EpisodiosSdt" )]
   [XmlType(TypeName =  "WorkWithDevicesSerie_Serie_Section_EpisodiosSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt : GxUserType
   {
      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt( IGxContext context )
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

   [DataContract(Name = @"WorkWithDevicesSerie_Serie_Section_EpisodiosSdt", Namespace = "http://tempuri.org/")]
   public class SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface : GxGenericCollectionItem<SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface( ) : base()
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt_RESTInterface( SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt psdt ) : base(psdt)
      {
      }

      public SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt sdt
      {
         get {
            return (SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt)Sdt ;
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
            sdt = new SdtWorkWithDevicesSerie_Serie_Section_EpisodiosSdt() ;
         }
      }

   }

}
