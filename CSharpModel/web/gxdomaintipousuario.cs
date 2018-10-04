/*
               File: TipoUsuario
        Description: TipoUsuario
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:2.5
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
   public class gxdomaintipousuario
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaintipousuario ()
      {
         domain[(short)1] = "Mobile";
         domain[(short)2] = "Administrador";
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
            domainMap["Mobile"] = (short)1;
            domainMap["Administrador"] = (short)2;
         }
         return (short)domainMap[key] ;
      }

   }

}
