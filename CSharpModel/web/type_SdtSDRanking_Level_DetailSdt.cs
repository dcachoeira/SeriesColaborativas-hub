/*
               File: type_SdtSDRanking_Level_DetailSdt
        Description: SDRanking_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 17:42:23.50
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
   [XmlRoot(ElementName = "SDRanking_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDRanking_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDRanking_Level_DetailSdt : GxUserType
   {
      public SdtSDRanking_Level_DetailSdt( )
      {
         /* Constructor for serialization */
      }

      public SdtSDRanking_Level_DetailSdt( IGxContext context )
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

   [DataContract(Name = @"SDRanking_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDRanking_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDRanking_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDRanking_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDRanking_Level_DetailSdt_RESTInterface( SdtSDRanking_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      public SdtSDRanking_Level_DetailSdt sdt
      {
         get {
            return (SdtSDRanking_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSDRanking_Level_DetailSdt() ;
         }
      }

   }

}
