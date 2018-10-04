/*
               File: GAMAuthenticationTypes
        Description: GAMAuthenticationTypes
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.66
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class gxdomaingamauthenticationtypes
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamauthenticationtypes ()
      {
         domain["Custom"] = "Custom";
         domain["ExternalWebService"] = "External Web Service";
         domain["Facebook"] = "Facebook";
         domain["GAMLocal"] = "GAM Local";
         domain["GAMRemote"] = "GAM Remote";
         domain["Google"] = "Google";
         domain["Twitter"] = "Twitter";
      }

      public static string getDescription( IGxContext context ,
                                           String key )
      {
         string rtkey ;
         rtkey = StringUtil.Trim( (String)(key));
         return (string)domain[rtkey] ;
      }

      public static GxSimpleCollection<String> getValues( )
      {
         GxSimpleCollection<String> value = new GxSimpleCollection<String>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (String key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static String getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["Custom"] = "Custom";
            domainMap["ExternalWebService"] = "ExternalWebService";
            domainMap["Facebook"] = "Facebook";
            domainMap["GAMLocal"] = "GAMLocal";
            domainMap["GAMRemote"] = "GAMRemote";
            domainMap["Google"] = "Google";
            domainMap["Twitter"] = "Twitter";
         }
         return (String)domainMap[key] ;
      }

   }

}
