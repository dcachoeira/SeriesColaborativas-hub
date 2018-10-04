/*
               File: Genero
        Description: Genero
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:1.49
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
   public class gxdomaingenero
   {
      private static Hashtable domain = new Hashtable();
      private static Hashtable domainMap;
      static gxdomaingenero ()
      {
         domain[(short)0] = "Selecione";
         domain[(short)1] = "Ação";
         domain[(short)2] = "Animação";
         domain[(short)3] = "Aventura";
         domain[(short)4] = "Arte";
         domain[(short)5] = "Chanchada";
         domain[(short)6] = "Catástrofe";
         domain[(short)7] = "Comédia";
         domain[(short)8] = "Comédia romântica";
         domain[(short)9] = "Comédia de ação";
         domain[(short)10] = "Cult";
         domain[(short)11] = "Dança";
         domain[(short)12] = "Documentário";
         domain[(short)13] = "Docuficção";
         domain[(short)14] = "Drama";
         domain[(short)15] = "Espionagem";
         domain[(short)16] = "Erótico";
         domain[(short)17] = "Fantasia";
         domain[(short)18] = "Faroeste";
         domain[(short)20] = "Ficção científica";
         domain[(short)21] = "Guerra";
         domain[(short)22] = "Musical";
         domain[(short)23] = "Policial";
         domain[(short)24] = "Romance";
         domain[(short)25] = "Suspense";
         domain[(short)26] = "Terror";
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
            domainMap["Selecione"] = (short)0;
            domainMap["Acao"] = (short)1;
            domainMap["Animacao"] = (short)2;
            domainMap["Aventura"] = (short)3;
            domainMap["CinemaArte"] = (short)4;
            domainMap["Chanchada"] = (short)5;
            domainMap["CinemaCatastrofe"] = (short)6;
            domainMap["Comedia"] = (short)7;
            domainMap["ComediaRomantica"] = (short)8;
            domainMap["ComediaAcao"] = (short)9;
            domainMap["Cult"] = (short)10;
            domainMap["Danca"] = (short)11;
            domainMap["Documentario"] = (short)12;
            domainMap["Docuficcao"] = (short)13;
            domainMap["Drama"] = (short)14;
            domainMap["Espionagem"] = (short)15;
            domainMap["Erotico"] = (short)16;
            domainMap["Fantasia"] = (short)17;
            domainMap["Faroeste"] = (short)18;
            domainMap["FiccaoCientifica"] = (short)20;
            domainMap["Guerra"] = (short)21;
            domainMap["Musical"] = (short)22;
            domainMap["Policial"] = (short)23;
            domainMap["Romance"] = (short)24;
            domainMap["Suspense"] = (short)25;
            domainMap["Terror"] = (short)26;
         }
         return (short)domainMap[key] ;
      }

   }

}
