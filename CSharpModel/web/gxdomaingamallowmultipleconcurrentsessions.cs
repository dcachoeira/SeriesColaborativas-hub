/*
               File: GAMAllowMultipleConcurrentSessions
        Description: GAMAllowMultipleConcurrentSessions
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.46
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
   public class gxdomaingamallowmultipleconcurrentsessions
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamallowmultipleconcurrentsessions ()
      {
         domain[(short)1] = "Yes, from different IP address";
         domain[(short)2] = "Yes, from same IP address";
         domain[(short)3] = "No";
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
            domainMap["Diferent_IP"] = (short)1;
            domainMap["N_Same_IP"] = (short)2;
            domainMap["Unique"] = (short)3;
         }
         return (short)domainMap[key] ;
      }

   }

}
