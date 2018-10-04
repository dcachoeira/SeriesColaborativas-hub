/*
               File: GxFullTextSearchReindexer
        Description: No description for object
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:34.94
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
namespace GeneXus.Programs {
   public class GxFullTextSearchReindexer
   {
      public static int Reindex( IGxContext context )
      {
         GxSilentTrnSdt obj ;
         IGxSilentTrn trn ;
         bool result ;
         obj = new SdtUsuarioEpisodio(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtUsuarioSerie(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtEpisodio(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtUsuarioConquista(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtNotificacao(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtSerie(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         return 1 ;
      }

   }

}
