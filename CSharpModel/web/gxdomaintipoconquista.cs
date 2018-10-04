/*
               File: TipoConquista
        Description: TipoConquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:2.0
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
   public class gxdomaintipoconquista
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaintipoconquista ()
      {
         domain[(short)1] = "Quantidade de s�ries";
         domain[(short)2] = "Quantidade de minutos";
         domain[(short)3] = "Quantidade de epis�dios";
      }

      public static string getDescription( IGxContext context ,
                                           short key )
      {
         return (string)domain[key] ;
      }

      public static GxSimpleCollection<short> getValues( )
      {
         GxSimpleCollection<short> value = new GxSimpleCollection<short>();
         ArrayList aKeys = new ArrayList(domain.Keys);
         aKeys.Sort();
         foreach (short key in aKeys)
         {
            value.Add(key);
         }
         return value;
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public static short getValue( string key )
      {
         if(domainMap == null)
         {
            domainMap = new Hashtable();
            domainMap["QuantidadeSeries"] = (short)1;
            domainMap["QuantidadeMinutos"] = (short)2;
            domainMap["QuantidadeEpisodios"] = (short)3;
         }
         return (short)domainMap[key] ;
      }

   }

}
