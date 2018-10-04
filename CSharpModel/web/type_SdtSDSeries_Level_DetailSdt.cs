/*
               File: type_SdtSDSeries_Level_DetailSdt
        Description: SDSeries_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 20:57:32.12
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
   [XmlRoot(ElementName = "SDSeries_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDSeries_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDSeries_Level_DetailSdt : GxUserType
   {
      public SdtSDSeries_Level_DetailSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtSDSeries_Level_DetailSdt( IGxContext context )
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

   [DataContract(Name = @"SDSeries_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDSeries_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDSeries_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDSeries_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDSeries_Level_DetailSdt_RESTInterface( SdtSDSeries_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      public SdtSDSeries_Level_DetailSdt sdt
      {
         get {
            return (SdtSDSeries_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSDSeries_Level_DetailSdt() ;
         }
      }

   }

}
