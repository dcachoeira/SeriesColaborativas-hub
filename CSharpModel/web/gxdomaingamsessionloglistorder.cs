/*
               File: GAMSessionLogListOrder
        Description: GAMSessionLogListOrder
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:1.26
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
   public class gxdomaingamsessionloglistorder
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingamsessionloglistorder ()
      {
         domain[(short)0] = "None";
         domain[(short)1] = "Token_Asc";
         domain[(short)2] = "Token_Desc";
         domain[(short)3] = "Date_Asc";
         domain[(short)4] = "Date_Desc";
         domain[(short)5] = "User_Asc";
         domain[(short)6] = "User_Desc";
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
            domainMap["None"] = (short)0;
            domainMap["Token_Asc"] = (short)1;
            domainMap["Token_Desc"] = (short)2;
            domainMap["Date_Asc"] = (short)3;
            domainMap["Date_Desc"] = (short)4;
            domainMap["User_Asc"] = (short)5;
            domainMap["User_Desc"] = (short)6;
         }
         return (short)domainMap[key] ;
      }

   }

}
