/*
               File: GAMBrowser
        Description: GAMBrowser
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:0.71
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
   public class gxdomaingambrowser
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingambrowser ()
      {
         domain[(short)0] = "Unknown Agent";
         domain[(short)1] = "Internet Explorer";
         domain[(short)2] = "Netscape";
         domain[(short)3] = "Opera";
         domain[(short)5] = "Pocket IE";
         domain[(short)6] = "Firefox";
         domain[(short)7] = "Chrome";
         domain[(short)8] = "Safari";
         domain[(short)9] = "Edge";
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
            domainMap["Unknown"] = (short)0;
            domainMap["IE"] = (short)1;
            domainMap["Netscape"] = (short)2;
            domainMap["Opera"] = (short)3;
            domainMap["PocketIE"] = (short)5;
            domainMap["Firefox"] = (short)6;
            domainMap["Chrome"] = (short)7;
            domainMap["Safari"] = (short)8;
            domainMap["Edge"] = (short)9;
         }
         return (short)domainMap[key] ;
      }

   }

}
