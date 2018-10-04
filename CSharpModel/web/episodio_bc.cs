/*
               File: Episodio_BC
        Description: Episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:27.89
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
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class episodio_bc : GXHttpHandler, IGxSilentTrn
   {
      public episodio_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public episodio_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtEpisodio> GetAll( int Start ,
                                                 int Count )
      {
         GXPagingFrom2 = Start;
         GXPagingTo2 = Count;
         /* Using cursor BC00025 */
         pr_default.execute(3, new Object[] {GXPagingFrom2, GXPagingTo2});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound2 = 1;
            A7EpisodioId = BC00025_A7EpisodioId[0];
            A2SerieNome = BC00025_A2SerieNome[0];
            A8EpisodioNome = BC00025_A8EpisodioNome[0];
            A9EpisodioDuracao = BC00025_A9EpisodioDuracao[0];
            A10EpisodioSinopse = BC00025_A10EpisodioSinopse[0];
            A42EpisodioTemporada = BC00025_A42EpisodioTemporada[0];
            A51EpisodioInativo = BC00025_A51EpisodioInativo[0];
            A58EpisodioNumero = BC00025_A58EpisodioNumero[0];
            A1SerieId = BC00025_A1SerieId[0];
         }
         bcEpisodio = new SdtEpisodio(context);
         gx_restcollection.Clear();
         while ( RcdFound2 != 0 )
         {
            OnLoadActions022( ) ;
            AddRow022( ) ;
            gx_sdt_item = (SdtEpisodio)(bcEpisodio.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound2 = 0;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound2 = 1;
               A7EpisodioId = BC00025_A7EpisodioId[0];
               A2SerieNome = BC00025_A2SerieNome[0];
               A8EpisodioNome = BC00025_A8EpisodioNome[0];
               A9EpisodioDuracao = BC00025_A9EpisodioDuracao[0];
               A10EpisodioSinopse = BC00025_A10EpisodioSinopse[0];
               A42EpisodioTemporada = BC00025_A42EpisodioTemporada[0];
               A51EpisodioInativo = BC00025_A51EpisodioInativo[0];
               A58EpisodioNumero = BC00025_A58EpisodioNumero[0];
               A1SerieId = BC00025_A1SerieId[0];
            }
            Gx_mode = sMode2;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM022( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow022( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey022( ) ;
         standaloneModal( ) ;
         AddRow022( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z7EpisodioId = A7EpisodioId;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               if ( AnyError == 0 )
               {
                  ZM022( 8) ;
               }
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12022( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "SerieId") == 0 )
               {
                  AV13Insert_SerieId = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
            }
         }
      }

      protected void E11022( )
      {
         /* After Trn Routine */
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z8EpisodioNome = A8EpisodioNome;
            Z9EpisodioDuracao = A9EpisodioDuracao;
            Z42EpisodioTemporada = A42EpisodioTemporada;
            Z51EpisodioInativo = A51EpisodioInativo;
            Z58EpisodioNumero = A58EpisodioNumero;
            Z1SerieId = A1SerieId;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z2SerieNome = A2SerieNome;
         }
         if ( GX_JID == -7 )
         {
            Z7EpisodioId = A7EpisodioId;
            Z8EpisodioNome = A8EpisodioNome;
            Z9EpisodioDuracao = A9EpisodioDuracao;
            Z10EpisodioSinopse = A10EpisodioSinopse;
            Z42EpisodioTemporada = A42EpisodioTemporada;
            Z51EpisodioInativo = A51EpisodioInativo;
            Z58EpisodioNumero = A58EpisodioNumero;
            Z1SerieId = A1SerieId;
            Z2SerieNome = A2SerieNome;
         }
      }

      protected void standaloneNotModal( )
      {
         AV17Pgmname = "Episodio_BC";
      }

      protected void standaloneModal( )
      {
      }

      protected void Load022( )
      {
         /* Using cursor BC00026 */
         pr_default.execute(4, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound2 = 1;
            A2SerieNome = BC00026_A2SerieNome[0];
            A8EpisodioNome = BC00026_A8EpisodioNome[0];
            A9EpisodioDuracao = BC00026_A9EpisodioDuracao[0];
            A10EpisodioSinopse = BC00026_A10EpisodioSinopse[0];
            A42EpisodioTemporada = BC00026_A42EpisodioTemporada[0];
            A51EpisodioInativo = BC00026_A51EpisodioInativo[0];
            A58EpisodioNumero = BC00026_A58EpisodioNumero[0];
            A1SerieId = BC00026_A1SerieId[0];
            ZM022( -7) ;
         }
         pr_default.close(4);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00024 */
         pr_default.execute(2, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
         }
         A2SerieNome = BC00024_A2SerieNome[0];
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A8EpisodioNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( (0==A9EpisodioDuracao) )
         {
            GX_msglist.addItem("Duração é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A10EpisodioSinopse)) )
         {
            GX_msglist.addItem("Sinopse é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( (0==A58EpisodioNumero) )
         {
            GX_msglist.addItem("Número do episódio é obrigatório.", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey022( )
      {
         /* Using cursor BC00027 */
         pr_default.execute(5, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00023 */
         pr_default.execute(1, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 7) ;
            RcdFound2 = 1;
            A7EpisodioId = BC00023_A7EpisodioId[0];
            A8EpisodioNome = BC00023_A8EpisodioNome[0];
            A9EpisodioDuracao = BC00023_A9EpisodioDuracao[0];
            A10EpisodioSinopse = BC00023_A10EpisodioSinopse[0];
            A42EpisodioTemporada = BC00023_A42EpisodioTemporada[0];
            A51EpisodioInativo = BC00023_A51EpisodioInativo[0];
            A58EpisodioNumero = BC00023_A58EpisodioNumero[0];
            A1SerieId = BC00023_A1SerieId[0];
            Z7EpisodioId = A7EpisodioId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode2;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_020( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00022 */
            pr_default.execute(0, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Episodio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z8EpisodioNome, BC00022_A8EpisodioNome[0]) != 0 ) || ( Z9EpisodioDuracao != BC00022_A9EpisodioDuracao[0] ) || ( Z42EpisodioTemporada != BC00022_A42EpisodioTemporada[0] ) || ( Z51EpisodioInativo != BC00022_A51EpisodioInativo[0] ) || ( Z58EpisodioNumero != BC00022_A58EpisodioNumero[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z1SerieId != BC00022_A1SerieId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Episodio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00028 */
                     pr_default.execute(6, new Object[] {A8EpisodioNome, A9EpisodioDuracao, A10EpisodioSinopse, A42EpisodioTemporada, A51EpisodioInativo, A58EpisodioNumero, A1SerieId});
                     A7EpisodioId = BC00028_A7EpisodioId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00029 */
                     pr_default.execute(7, new Object[] {A8EpisodioNome, A9EpisodioDuracao, A10EpisodioSinopse, A42EpisodioTemporada, A51EpisodioInativo, A58EpisodioNumero, A1SerieId, A7EpisodioId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Episodio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate022( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000210 */
                  pr_default.execute(8, new Object[] {A7EpisodioId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Episodio") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel022( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000211 */
            pr_default.execute(9, new Object[] {A1SerieId});
            A2SerieNome = BC000211_A2SerieNome[0];
            pr_default.close(9);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000212 */
            pr_default.execute(10, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação episódios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor BC000213 */
            pr_default.execute(11, new Object[] {A7EpisodioId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário episódio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart022( )
      {
         /* Scan By routine */
         /* Using cursor BC000214 */
         pr_default.execute(12, new Object[] {A7EpisodioId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound2 = 1;
            A7EpisodioId = BC000214_A7EpisodioId[0];
            A2SerieNome = BC000214_A2SerieNome[0];
            A8EpisodioNome = BC000214_A8EpisodioNome[0];
            A9EpisodioDuracao = BC000214_A9EpisodioDuracao[0];
            A10EpisodioSinopse = BC000214_A10EpisodioSinopse[0];
            A42EpisodioTemporada = BC000214_A42EpisodioTemporada[0];
            A51EpisodioInativo = BC000214_A51EpisodioInativo[0];
            A58EpisodioNumero = BC000214_A58EpisodioNumero[0];
            A1SerieId = BC000214_A1SerieId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound2 = 0;
         ScanKeyLoad022( ) ;
      }

      protected void ScanKeyLoad022( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound2 = 1;
            A7EpisodioId = BC000214_A7EpisodioId[0];
            A2SerieNome = BC000214_A2SerieNome[0];
            A8EpisodioNome = BC000214_A8EpisodioNome[0];
            A9EpisodioDuracao = BC000214_A9EpisodioDuracao[0];
            A10EpisodioSinopse = BC000214_A10EpisodioSinopse[0];
            A42EpisodioTemporada = BC000214_A42EpisodioTemporada[0];
            A51EpisodioInativo = BC000214_A51EpisodioInativo[0];
            A58EpisodioNumero = BC000214_A58EpisodioNumero[0];
            A1SerieId = BC000214_A1SerieId[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd022( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void AddRow022( )
      {
         VarsToRow2( bcEpisodio) ;
      }

      protected void ReadRow022( )
      {
         RowToVars2( bcEpisodio, 1) ;
      }

      protected void InitializeNonKey022( )
      {
         A1SerieId = 0;
         A2SerieNome = "";
         A8EpisodioNome = "";
         A9EpisodioDuracao = 0;
         A10EpisodioSinopse = "";
         A42EpisodioTemporada = 0;
         A51EpisodioInativo = false;
         A58EpisodioNumero = 0;
         Z8EpisodioNome = "";
         Z9EpisodioDuracao = 0;
         Z42EpisodioTemporada = 0;
         Z51EpisodioInativo = false;
         Z58EpisodioNumero = 0;
         Z1SerieId = 0;
      }

      protected void InitAll022( )
      {
         A7EpisodioId = 0;
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow2( SdtEpisodio obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Serieid = A1SerieId;
         obj2.gxTpr_Serienome = A2SerieNome;
         obj2.gxTpr_Episodionome = A8EpisodioNome;
         obj2.gxTpr_Episodioduracao = A9EpisodioDuracao;
         obj2.gxTpr_Episodiosinopse = A10EpisodioSinopse;
         obj2.gxTpr_Episodiotemporada = A42EpisodioTemporada;
         obj2.gxTpr_Episodioinativo = A51EpisodioInativo;
         obj2.gxTpr_Episodionumero = A58EpisodioNumero;
         obj2.gxTpr_Episodioid = A7EpisodioId;
         obj2.gxTpr_Episodioid_Z = Z7EpisodioId;
         obj2.gxTpr_Serieid_Z = Z1SerieId;
         obj2.gxTpr_Serienome_Z = Z2SerieNome;
         obj2.gxTpr_Episodionome_Z = Z8EpisodioNome;
         obj2.gxTpr_Episodioduracao_Z = Z9EpisodioDuracao;
         obj2.gxTpr_Episodiotemporada_Z = Z42EpisodioTemporada;
         obj2.gxTpr_Episodioinativo_Z = Z51EpisodioInativo;
         obj2.gxTpr_Episodionumero_Z = Z58EpisodioNumero;
         obj2.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow2( SdtEpisodio obj2 )
      {
         obj2.gxTpr_Episodioid = A7EpisodioId;
         return  ;
      }

      public void RowToVars2( SdtEpisodio obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A1SerieId = obj2.gxTpr_Serieid;
         A2SerieNome = obj2.gxTpr_Serienome;
         A8EpisodioNome = obj2.gxTpr_Episodionome;
         A9EpisodioDuracao = obj2.gxTpr_Episodioduracao;
         A10EpisodioSinopse = obj2.gxTpr_Episodiosinopse;
         A42EpisodioTemporada = obj2.gxTpr_Episodiotemporada;
         A51EpisodioInativo = obj2.gxTpr_Episodioinativo;
         A58EpisodioNumero = obj2.gxTpr_Episodionumero;
         A7EpisodioId = obj2.gxTpr_Episodioid;
         Z7EpisodioId = obj2.gxTpr_Episodioid_Z;
         Z1SerieId = obj2.gxTpr_Serieid_Z;
         Z2SerieNome = obj2.gxTpr_Serienome_Z;
         Z8EpisodioNome = obj2.gxTpr_Episodionome_Z;
         Z9EpisodioDuracao = obj2.gxTpr_Episodioduracao_Z;
         Z42EpisodioTemporada = obj2.gxTpr_Episodiotemporada_Z;
         Z51EpisodioInativo = obj2.gxTpr_Episodioinativo_Z;
         Z58EpisodioNumero = obj2.gxTpr_Episodionumero_Z;
         Gx_mode = obj2.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A7EpisodioId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey022( ) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z7EpisodioId = A7EpisodioId;
         }
         ZM022( -7) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars2( bcEpisodio, 0) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z7EpisodioId = A7EpisodioId;
         }
         ZM022( -7) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert022( ) ;
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( A7EpisodioId != Z7EpisodioId )
               {
                  A7EpisodioId = Z7EpisodioId;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update022( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A7EpisodioId != Z7EpisodioId )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert022( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcEpisodio, 0) ;
         SaveImpl( ) ;
         VarsToRow2( bcEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcEpisodio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         AfterTrn( ) ;
         VarsToRow2( bcEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtEpisodio auxBC = new SdtEpisodio(context) ;
            auxBC.Load(A7EpisodioId);
            auxBC.UpdateDirties(bcEpisodio);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcEpisodio, 0) ;
         UpdateImpl( ) ;
         VarsToRow2( bcEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars2( bcEpisodio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow2( bcEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars2( bcEpisodio, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A7EpisodioId != Z7EpisodioId )
            {
               A7EpisodioId = Z7EpisodioId;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A7EpisodioId != Z7EpisodioId )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(9);
         pr_gam.rollback( "Episodio_BC");
         pr_default.rollback( "Episodio_BC");
         VarsToRow2( bcEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcEpisodio.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcEpisodio.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcEpisodio )
         {
            bcEpisodio = (SdtEpisodio)(sdt);
            if ( StringUtil.StrCmp(bcEpisodio.gxTpr_Mode, "") == 0 )
            {
               bcEpisodio.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow2( bcEpisodio) ;
            }
            else
            {
               RowToVars2( bcEpisodio, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcEpisodio.gxTpr_Mode, "") == 0 )
            {
               bcEpisodio.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars2( bcEpisodio, 1) ;
         return  ;
      }

      public SdtEpisodio Episodio_BC
      {
         get {
            return bcEpisodio ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00025_A7EpisodioId = new long[1] ;
         BC00025_A2SerieNome = new String[] {""} ;
         BC00025_A8EpisodioNome = new String[] {""} ;
         BC00025_A9EpisodioDuracao = new short[1] ;
         BC00025_A10EpisodioSinopse = new String[] {""} ;
         BC00025_A42EpisodioTemporada = new short[1] ;
         BC00025_A51EpisodioInativo = new bool[] {false} ;
         BC00025_A58EpisodioNumero = new short[1] ;
         BC00025_A1SerieId = new long[1] ;
         A2SerieNome = "";
         A8EpisodioNome = "";
         A10EpisodioSinopse = "";
         gx_restcollection = new GXBCCollection<SdtEpisodio>( context, "Episodio", "SeriesColaborativas");
         sMode2 = "";
         Gx_mode = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV17Pgmname = "";
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z8EpisodioNome = "";
         Z2SerieNome = "";
         Z10EpisodioSinopse = "";
         BC00026_A7EpisodioId = new long[1] ;
         BC00026_A2SerieNome = new String[] {""} ;
         BC00026_A8EpisodioNome = new String[] {""} ;
         BC00026_A9EpisodioDuracao = new short[1] ;
         BC00026_A10EpisodioSinopse = new String[] {""} ;
         BC00026_A42EpisodioTemporada = new short[1] ;
         BC00026_A51EpisodioInativo = new bool[] {false} ;
         BC00026_A58EpisodioNumero = new short[1] ;
         BC00026_A1SerieId = new long[1] ;
         BC00024_A2SerieNome = new String[] {""} ;
         BC00027_A7EpisodioId = new long[1] ;
         BC00023_A7EpisodioId = new long[1] ;
         BC00023_A8EpisodioNome = new String[] {""} ;
         BC00023_A9EpisodioDuracao = new short[1] ;
         BC00023_A10EpisodioSinopse = new String[] {""} ;
         BC00023_A42EpisodioTemporada = new short[1] ;
         BC00023_A51EpisodioInativo = new bool[] {false} ;
         BC00023_A58EpisodioNumero = new short[1] ;
         BC00023_A1SerieId = new long[1] ;
         BC00022_A7EpisodioId = new long[1] ;
         BC00022_A8EpisodioNome = new String[] {""} ;
         BC00022_A9EpisodioDuracao = new short[1] ;
         BC00022_A10EpisodioSinopse = new String[] {""} ;
         BC00022_A42EpisodioTemporada = new short[1] ;
         BC00022_A51EpisodioInativo = new bool[] {false} ;
         BC00022_A58EpisodioNumero = new short[1] ;
         BC00022_A1SerieId = new long[1] ;
         BC00028_A7EpisodioId = new long[1] ;
         BC000211_A2SerieNome = new String[] {""} ;
         BC000212_A37UsuarioRecomendacaoEpisodioId = new long[1] ;
         BC000213_A18UsuarioEpisodioId = new long[1] ;
         BC000214_A7EpisodioId = new long[1] ;
         BC000214_A2SerieNome = new String[] {""} ;
         BC000214_A8EpisodioNome = new String[] {""} ;
         BC000214_A9EpisodioDuracao = new short[1] ;
         BC000214_A10EpisodioSinopse = new String[] {""} ;
         BC000214_A42EpisodioTemporada = new short[1] ;
         BC000214_A51EpisodioInativo = new bool[] {false} ;
         BC000214_A58EpisodioNumero = new short[1] ;
         BC000214_A1SerieId = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.episodio_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.episodio_bc__default(),
            new Object[][] {
                new Object[] {
               BC00022_A7EpisodioId, BC00022_A8EpisodioNome, BC00022_A9EpisodioDuracao, BC00022_A10EpisodioSinopse, BC00022_A42EpisodioTemporada, BC00022_A51EpisodioInativo, BC00022_A58EpisodioNumero, BC00022_A1SerieId
               }
               , new Object[] {
               BC00023_A7EpisodioId, BC00023_A8EpisodioNome, BC00023_A9EpisodioDuracao, BC00023_A10EpisodioSinopse, BC00023_A42EpisodioTemporada, BC00023_A51EpisodioInativo, BC00023_A58EpisodioNumero, BC00023_A1SerieId
               }
               , new Object[] {
               BC00024_A2SerieNome
               }
               , new Object[] {
               BC00025_A7EpisodioId, BC00025_A2SerieNome, BC00025_A8EpisodioNome, BC00025_A9EpisodioDuracao, BC00025_A10EpisodioSinopse, BC00025_A42EpisodioTemporada, BC00025_A51EpisodioInativo, BC00025_A58EpisodioNumero, BC00025_A1SerieId
               }
               , new Object[] {
               BC00026_A7EpisodioId, BC00026_A2SerieNome, BC00026_A8EpisodioNome, BC00026_A9EpisodioDuracao, BC00026_A10EpisodioSinopse, BC00026_A42EpisodioTemporada, BC00026_A51EpisodioInativo, BC00026_A58EpisodioNumero, BC00026_A1SerieId
               }
               , new Object[] {
               BC00027_A7EpisodioId
               }
               , new Object[] {
               BC00028_A7EpisodioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000211_A2SerieNome
               }
               , new Object[] {
               BC000212_A37UsuarioRecomendacaoEpisodioId
               }
               , new Object[] {
               BC000213_A18UsuarioEpisodioId
               }
               , new Object[] {
               BC000214_A7EpisodioId, BC000214_A2SerieNome, BC000214_A8EpisodioNome, BC000214_A9EpisodioDuracao, BC000214_A10EpisodioSinopse, BC000214_A42EpisodioTemporada, BC000214_A51EpisodioInativo, BC000214_A58EpisodioNumero, BC000214_A1SerieId
               }
            }
         );
         AV17Pgmname = "Episodio_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12022 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound2 ;
      private short A9EpisodioDuracao ;
      private short A42EpisodioTemporada ;
      private short A58EpisodioNumero ;
      private short GX_JID ;
      private short Z9EpisodioDuracao ;
      private short Z42EpisodioTemporada ;
      private short Z58EpisodioNumero ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV18GXV1 ;
      private long A7EpisodioId ;
      private long A1SerieId ;
      private long Z7EpisodioId ;
      private long AV13Insert_SerieId ;
      private long Z1SerieId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode2 ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private bool A51EpisodioInativo ;
      private bool Z51EpisodioInativo ;
      private bool Gx_longc ;
      private String A10EpisodioSinopse ;
      private String Z10EpisodioSinopse ;
      private String A2SerieNome ;
      private String A8EpisodioNome ;
      private String Z8EpisodioNome ;
      private String Z2SerieNome ;
      private IGxSession AV12WebSession ;
      private GXBCCollection<SdtEpisodio> gx_restcollection ;
      private SdtEpisodio bcEpisodio ;
      private SdtEpisodio gx_sdt_item ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00025_A7EpisodioId ;
      private String[] BC00025_A2SerieNome ;
      private String[] BC00025_A8EpisodioNome ;
      private short[] BC00025_A9EpisodioDuracao ;
      private String[] BC00025_A10EpisodioSinopse ;
      private short[] BC00025_A42EpisodioTemporada ;
      private bool[] BC00025_A51EpisodioInativo ;
      private short[] BC00025_A58EpisodioNumero ;
      private long[] BC00025_A1SerieId ;
      private long[] BC00026_A7EpisodioId ;
      private String[] BC00026_A2SerieNome ;
      private String[] BC00026_A8EpisodioNome ;
      private short[] BC00026_A9EpisodioDuracao ;
      private String[] BC00026_A10EpisodioSinopse ;
      private short[] BC00026_A42EpisodioTemporada ;
      private bool[] BC00026_A51EpisodioInativo ;
      private short[] BC00026_A58EpisodioNumero ;
      private long[] BC00026_A1SerieId ;
      private String[] BC00024_A2SerieNome ;
      private long[] BC00027_A7EpisodioId ;
      private long[] BC00023_A7EpisodioId ;
      private String[] BC00023_A8EpisodioNome ;
      private short[] BC00023_A9EpisodioDuracao ;
      private String[] BC00023_A10EpisodioSinopse ;
      private short[] BC00023_A42EpisodioTemporada ;
      private bool[] BC00023_A51EpisodioInativo ;
      private short[] BC00023_A58EpisodioNumero ;
      private long[] BC00023_A1SerieId ;
      private long[] BC00022_A7EpisodioId ;
      private String[] BC00022_A8EpisodioNome ;
      private short[] BC00022_A9EpisodioDuracao ;
      private String[] BC00022_A10EpisodioSinopse ;
      private short[] BC00022_A42EpisodioTemporada ;
      private bool[] BC00022_A51EpisodioInativo ;
      private short[] BC00022_A58EpisodioNumero ;
      private long[] BC00022_A1SerieId ;
      private long[] BC00028_A7EpisodioId ;
      private String[] BC000211_A2SerieNome ;
      private long[] BC000212_A37UsuarioRecomendacaoEpisodioId ;
      private long[] BC000213_A18UsuarioEpisodioId ;
      private long[] BC000214_A7EpisodioId ;
      private String[] BC000214_A2SerieNome ;
      private String[] BC000214_A8EpisodioNome ;
      private short[] BC000214_A9EpisodioDuracao ;
      private String[] BC000214_A10EpisodioSinopse ;
      private short[] BC000214_A42EpisodioTemporada ;
      private bool[] BC000214_A51EpisodioInativo ;
      private short[] BC000214_A58EpisodioNumero ;
      private long[] BC000214_A1SerieId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class episodio_bc__gam : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "GAM";
    }

 }

 public class episodio_bc__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00025 ;
        prmBC00025 = new Object[] {
        new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
        } ;
        Object[] prmBC00026 ;
        prmBC00026 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00024 ;
        prmBC00024 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00027 ;
        prmBC00027 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00023 ;
        prmBC00023 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00022 ;
        prmBC00022 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00028 ;
        prmBC00028 = new Object[] {
        new Object[] {"@EpisodioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@EpisodioDuracao",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@EpisodioSinopse",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@EpisodioTemporada",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EpisodioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@EpisodioNumero",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00029 ;
        prmBC00029 = new Object[] {
        new Object[] {"@EpisodioNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@EpisodioDuracao",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@EpisodioSinopse",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@EpisodioTemporada",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EpisodioInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@EpisodioNumero",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000210 ;
        prmBC000210 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000211 ;
        prmBC000211 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000212 ;
        prmBC000212 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000213 ;
        prmBC000213 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000214 ;
        prmBC000214 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00022", "SELECT [EpisodioId], [EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioTemporada], [EpisodioInativo], [EpisodioNumero], [SerieId] FROM [Episodio] WITH (UPDLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00022,1,0,true,false )
           ,new CursorDef("BC00023", "SELECT [EpisodioId], [EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioTemporada], [EpisodioInativo], [EpisodioNumero], [SerieId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00023,1,0,true,false )
           ,new CursorDef("BC00024", "SELECT [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00024,1,0,true,false )
           ,new CursorDef("BC00025", "SELECT TM1.[EpisodioId], T2.[SerieNome], TM1.[EpisodioNome], TM1.[EpisodioDuracao], TM1.[EpisodioSinopse], TM1.[EpisodioTemporada], TM1.[EpisodioInativo], TM1.[EpisodioNumero], TM1.[SerieId] FROM ([Episodio] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) ORDER BY TM1.[EpisodioId]  OFFSET @GXPagingFrom2 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo2 > 0 THEN @GXPagingTo2 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00025,100,0,true,false )
           ,new CursorDef("BC00026", "SELECT TM1.[EpisodioId], T2.[SerieNome], TM1.[EpisodioNome], TM1.[EpisodioDuracao], TM1.[EpisodioSinopse], TM1.[EpisodioTemporada], TM1.[EpisodioInativo], TM1.[EpisodioNumero], TM1.[SerieId] FROM ([Episodio] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) WHERE TM1.[EpisodioId] = @EpisodioId ORDER BY TM1.[EpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00026,100,0,true,false )
           ,new CursorDef("BC00027", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00027,1,0,true,false )
           ,new CursorDef("BC00028", "INSERT INTO [Episodio]([EpisodioNome], [EpisodioDuracao], [EpisodioSinopse], [EpisodioTemporada], [EpisodioInativo], [EpisodioNumero], [SerieId]) VALUES(@EpisodioNome, @EpisodioDuracao, @EpisodioSinopse, @EpisodioTemporada, @EpisodioInativo, @EpisodioNumero, @SerieId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00028)
           ,new CursorDef("BC00029", "UPDATE [Episodio] SET [EpisodioNome]=@EpisodioNome, [EpisodioDuracao]=@EpisodioDuracao, [EpisodioSinopse]=@EpisodioSinopse, [EpisodioTemporada]=@EpisodioTemporada, [EpisodioInativo]=@EpisodioInativo, [EpisodioNumero]=@EpisodioNumero, [SerieId]=@SerieId  WHERE [EpisodioId] = @EpisodioId", GxErrorMask.GX_NOMASK,prmBC00029)
           ,new CursorDef("BC000210", "DELETE FROM [Episodio]  WHERE [EpisodioId] = @EpisodioId", GxErrorMask.GX_NOMASK,prmBC000210)
           ,new CursorDef("BC000211", "SELECT [SerieNome] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000211,1,0,true,false )
           ,new CursorDef("BC000212", "SELECT TOP 1 [UsuarioRecomendacaoEpisodioId] FROM [UsuarioRecomendacaoEpisodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000212,1,0,true,true )
           ,new CursorDef("BC000213", "SELECT TOP 1 [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000213,1,0,true,true )
           ,new CursorDef("BC000214", "SELECT TM1.[EpisodioId], T2.[SerieNome], TM1.[EpisodioNome], TM1.[EpisodioDuracao], TM1.[EpisodioSinopse], TM1.[EpisodioTemporada], TM1.[EpisodioInativo], TM1.[EpisodioNumero], TM1.[SerieId] FROM ([Episodio] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) WHERE TM1.[EpisodioId] = @EpisodioId ORDER BY TM1.[EpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000214,100,0,true,false )
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
           case 0 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((short[]) buf[6])[0] = rslt.getShort(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((short[]) buf[7])[0] = rslt.getShort(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (int)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (short)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (short)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              stmt.SetParameter(8, (long)parms[7]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.episodio_bc_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class episodio_bc_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "GET" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA7EpisodioId}")]
   public SdtEpisodio_RESTInterface Load( string sA7EpisodioId )
   {
      try
      {
         long A7EpisodioId ;
         A7EpisodioId = (long)(NumberUtil.Val( (String)(sA7EpisodioId), "."));
         SdtEpisodio worker = new SdtEpisodio(context) ;
         SdtEpisodio_RESTInterface worker_interface = new SdtEpisodio_RESTInterface (worker);
         if ( StringUtil.StrCmp(sA7EpisodioId, "_default") == 0 )
         {
            IGxSilentTrn workertrn = worker.getTransaction() ;
            workertrn.GetInsDefault();
         }
         else
         {
            worker.Load(A7EpisodioId);
         }
         ((GXHttpHandler)worker.trn).IsMain = true ;
         if ( worker.Success() )
         {
            SetMessages(worker.trn.GetMessages());
            worker.trn.cleanup( );
            return worker_interface ;
         }
         else
         {
            worker.trn.cleanup( );
            ErrorCheck(worker.trn);
            return null ;
         }
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
      return null ;
   }

   [OperationContract]
   [WebInvoke(Method =  "DELETE" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA7EpisodioId}")]
   public SdtEpisodio_RESTInterface Delete( string sA7EpisodioId )
   {
      try
      {
         long A7EpisodioId ;
         A7EpisodioId = (long)(NumberUtil.Val( (String)(sA7EpisodioId), "."));
         SdtEpisodio worker = new SdtEpisodio(context) ;
         SdtEpisodio_RESTInterface worker_interface = new SdtEpisodio_RESTInterface (worker);
         worker.Load(A7EpisodioId);
         worker.Delete();
         ((GXHttpHandler)worker.trn).IsMain = true ;
         if ( worker.Success() )
         {
            (( GXHttpHandler )worker.trn).context.CommitDataStores();
            SetMessages(worker.trn.GetMessages());
            worker.trn.cleanup( );
            return worker_interface ;
         }
         else
         {
            worker.trn.cleanup( );
            ErrorCheck(worker.trn);
            return null ;
         }
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
      return null ;
   }

   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA7EpisodioId}")]
   public SdtEpisodio_RESTInterface Insert( string sA7EpisodioId ,
                                            SdtEpisodio_RESTInterface entity )
   {
      try
      {
         long A7EpisodioId ;
         A7EpisodioId = (long)(NumberUtil.Val( (String)(sA7EpisodioId), "."));
         SdtEpisodio worker = new SdtEpisodio(context) ;
         bool gxcheck = RestParameter("check", "true") ;
         bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
         SdtEpisodio_RESTInterface worker_interface = new SdtEpisodio_RESTInterface (worker);
         worker_interface.CopyFrom(entity);
         worker.gxTpr_Episodioid = A7EpisodioId;
         if ( gxcheck )
         {
            worker.Check();
         }
         else
         {
            if ( gxinsertorupdate )
            {
               worker.InsertOrUpdate();
            }
            else
            {
               worker.Save();
            }
         }
         ((GXHttpHandler)worker.trn).IsMain = true ;
         if ( worker.Success() )
         {
            if ( ! gxcheck )
            {
               (( GXHttpHandler )worker.trn).context.CommitDataStores();
               SetStatusCode(System.Net.HttpStatusCode.Created);
            }
            SetMessages(worker.trn.GetMessages());
            worker.trn.cleanup( );
            return worker_interface ;
         }
         else
         {
            worker.trn.cleanup( );
            ErrorCheck(worker.trn);
            return null ;
         }
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
      return null ;
   }

   [OperationContract]
   [WebInvoke(Method =  "PUT" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA7EpisodioId}")]
   public SdtEpisodio_RESTInterface Update( string sA7EpisodioId ,
                                            SdtEpisodio_RESTInterface entity )
   {
      try
      {
         long A7EpisodioId ;
         A7EpisodioId = (long)(NumberUtil.Val( (String)(sA7EpisodioId), "."));
         SdtEpisodio worker = new SdtEpisodio(context) ;
         SdtEpisodio_RESTInterface worker_interface = new SdtEpisodio_RESTInterface (worker);
         bool gxcheck = RestParameter("check", "true") ;
         worker.Load(A7EpisodioId);
         if (entity.Hash == worker_interface.Hash) {
            worker_interface.CopyFrom(entity);
            worker.gxTpr_Episodioid = A7EpisodioId;
            if ( gxcheck )
            {
               worker.Check();
            }
            else
            {
               worker.Save();
            }
            ((GXHttpHandler)worker.trn).IsMain = true ;
            if ( worker.Success() )
            {
               if ( ! gxcheck )
               {
                  (( GXHttpHandler )worker.trn).context.CommitDataStores();
               }
               SetMessages(worker.trn.GetMessages());
               worker.trn.cleanup( );
               worker_interface.Hash = null;
               return worker_interface ;
            }
            else
            {
               worker.trn.cleanup( );
               ErrorCheck(worker.trn);
               return null ;
            }
         }
         else
         {
            SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Episodio"}) );
         }
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
      return null ;
   }

}

}
