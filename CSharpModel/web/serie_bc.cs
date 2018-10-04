/*
               File: Serie_BC
        Description: Série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:12.30
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
   public class serie_bc : GXHttpHandler, IGxSilentTrn
   {
      public serie_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public serie_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtSerie> GetAll( int Start ,
                                              int Count )
      {
         GXPagingFrom1 = Start;
         GXPagingTo1 = Count;
         /* Using cursor BC00015 */
         pr_default.execute(3, new Object[] {GXPagingFrom1, GXPagingTo1});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A1SerieId = BC00015_A1SerieId[0];
            A60SerieDataHoraCadastro = BC00015_A60SerieDataHoraCadastro[0];
            A2SerieNome = BC00015_A2SerieNome[0];
            A3SerieQuantidadeTemporadas = BC00015_A3SerieQuantidadeTemporadas[0];
            A49GeneroNome = BC00015_A49GeneroNome[0];
            A6SerieResumo = BC00015_A6SerieResumo[0];
            A40000SerieImagem_GXI = BC00015_A40000SerieImagem_GXI[0];
            A47SerieInativo = BC00015_A47SerieInativo[0];
            A48GeneroId = BC00015_A48GeneroId[0];
            A43SerieImagem = BC00015_A43SerieImagem[0];
         }
         bcSerie = new SdtSerie(context);
         gx_restcollection.Clear();
         while ( RcdFound1 != 0 )
         {
            OnLoadActions011( ) ;
            AddRow011( ) ;
            gx_sdt_item = (SdtSerie)(bcSerie.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound1 = 0;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound1 = 1;
               A1SerieId = BC00015_A1SerieId[0];
               A60SerieDataHoraCadastro = BC00015_A60SerieDataHoraCadastro[0];
               A2SerieNome = BC00015_A2SerieNome[0];
               A3SerieQuantidadeTemporadas = BC00015_A3SerieQuantidadeTemporadas[0];
               A49GeneroNome = BC00015_A49GeneroNome[0];
               A6SerieResumo = BC00015_A6SerieResumo[0];
               A40000SerieImagem_GXI = BC00015_A40000SerieImagem_GXI[0];
               A47SerieInativo = BC00015_A47SerieInativo[0];
               A48GeneroId = BC00015_A48GeneroId[0];
               A43SerieImagem = BC00015_A43SerieImagem[0];
            }
            Gx_mode = sMode1;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM011( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z1SerieId = A1SerieId;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
                  ZM011( 10) ;
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12012( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "SeriesColaborativas");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            while ( AV16GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "GeneroId") == 0 )
               {
                  AV13Insert_GeneroId = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
            }
         }
      }

      protected void E11012( )
      {
         /* After Trn Routine */
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            Z60SerieDataHoraCadastro = A60SerieDataHoraCadastro;
            Z2SerieNome = A2SerieNome;
            Z3SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
            Z47SerieInativo = A47SerieInativo;
            Z48GeneroId = A48GeneroId;
         }
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            Z49GeneroNome = A49GeneroNome;
         }
         if ( GX_JID == -9 )
         {
            Z1SerieId = A1SerieId;
            Z60SerieDataHoraCadastro = A60SerieDataHoraCadastro;
            Z2SerieNome = A2SerieNome;
            Z3SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
            Z6SerieResumo = A6SerieResumo;
            Z43SerieImagem = A43SerieImagem;
            Z40000SerieImagem_GXI = A40000SerieImagem_GXI;
            Z47SerieInativo = A47SerieInativo;
            Z48GeneroId = A48GeneroId;
            Z49GeneroNome = A49GeneroNome;
         }
      }

      protected void standaloneNotModal( )
      {
         AV15Pgmname = "Serie_BC";
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
         {
            A60SerieDataHoraCadastro = DateTimeUtil.Now( context);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load011( )
      {
         /* Using cursor BC00016 */
         pr_default.execute(4, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1;
            A60SerieDataHoraCadastro = BC00016_A60SerieDataHoraCadastro[0];
            A2SerieNome = BC00016_A2SerieNome[0];
            A3SerieQuantidadeTemporadas = BC00016_A3SerieQuantidadeTemporadas[0];
            A49GeneroNome = BC00016_A49GeneroNome[0];
            A6SerieResumo = BC00016_A6SerieResumo[0];
            A40000SerieImagem_GXI = BC00016_A40000SerieImagem_GXI[0];
            A47SerieInativo = BC00016_A47SerieInativo[0];
            A48GeneroId = BC00016_A48GeneroId[0];
            A43SerieImagem = BC00016_A43SerieImagem[0];
            ZM011( -9) ;
         }
         pr_default.close(4);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         standaloneModal( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A2SerieNome)) )
         {
            GX_msglist.addItem("Nome é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( (0==A3SerieQuantidadeTemporadas) )
         {
            GX_msglist.addItem("Quantidade de temporadas é obrigatório.", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC00014 */
         pr_default.execute(2, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "GENEROID");
            AnyError = 1;
         }
         A49GeneroNome = BC00014_A49GeneroNome[0];
         pr_default.close(2);
         if ( (0==A48GeneroId) )
         {
            GX_msglist.addItem("Gênero é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A6SerieResumo)) )
         {
            GX_msglist.addItem("Resumo é obrigatório.", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A60SerieDataHoraCadastro) || ( A60SerieDataHoraCadastro >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora de cadastro fora do intervalo", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00017 */
         pr_default.execute(5, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 9) ;
            RcdFound1 = 1;
            A1SerieId = BC00013_A1SerieId[0];
            A60SerieDataHoraCadastro = BC00013_A60SerieDataHoraCadastro[0];
            A2SerieNome = BC00013_A2SerieNome[0];
            A3SerieQuantidadeTemporadas = BC00013_A3SerieQuantidadeTemporadas[0];
            A6SerieResumo = BC00013_A6SerieResumo[0];
            A40000SerieImagem_GXI = BC00013_A40000SerieImagem_GXI[0];
            A47SerieInativo = BC00013_A47SerieInativo[0];
            A48GeneroId = BC00013_A48GeneroId[0];
            A43SerieImagem = BC00013_A43SerieImagem[0];
            Z1SerieId = A1SerieId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         CONFIRM_010( ) ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Serie"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z60SerieDataHoraCadastro != BC00012_A60SerieDataHoraCadastro[0] ) || ( StringUtil.StrCmp(Z2SerieNome, BC00012_A2SerieNome[0]) != 0 ) || ( Z3SerieQuantidadeTemporadas != BC00012_A3SerieQuantidadeTemporadas[0] ) || ( Z47SerieInativo != BC00012_A47SerieInativo[0] ) || ( Z48GeneroId != BC00012_A48GeneroId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Serie"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00018 */
                     pr_default.execute(6, new Object[] {A60SerieDataHoraCadastro, A2SerieNome, A3SerieQuantidadeTemporadas, A6SerieResumo, A43SerieImagem, A40000SerieImagem_GXI, A47SerieInativo, A48GeneroId});
                     A1SerieId = BC00018_A1SerieId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00019 */
                     pr_default.execute(7, new Object[] {A60SerieDataHoraCadastro, A2SerieNome, A3SerieQuantidadeTemporadas, A6SerieResumo, A47SerieInativo, A48GeneroId, A1SerieId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Serie"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC000110 */
            pr_default.execute(8, new Object[] {A43SerieImagem, A40000SerieImagem_GXI, A1SerieId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000111 */
                  pr_default.execute(9, new Object[] {A1SerieId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Serie") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000112 */
            pr_default.execute(10, new Object[] {A48GeneroId});
            A49GeneroNome = BC000112_A49GeneroNome[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000113 */
            pr_default.execute(11, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário recomendação série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000114 */
            pr_default.execute(12, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Usuário série"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor BC000115 */
            pr_default.execute(13, new Object[] {A1SerieId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Episódio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
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

      public void ScanKeyStart011( )
      {
         /* Scan By routine */
         /* Using cursor BC000116 */
         pr_default.execute(14, new Object[] {A1SerieId});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1SerieId = BC000116_A1SerieId[0];
            A60SerieDataHoraCadastro = BC000116_A60SerieDataHoraCadastro[0];
            A2SerieNome = BC000116_A2SerieNome[0];
            A3SerieQuantidadeTemporadas = BC000116_A3SerieQuantidadeTemporadas[0];
            A49GeneroNome = BC000116_A49GeneroNome[0];
            A6SerieResumo = BC000116_A6SerieResumo[0];
            A40000SerieImagem_GXI = BC000116_A40000SerieImagem_GXI[0];
            A47SerieInativo = BC000116_A47SerieInativo[0];
            A48GeneroId = BC000116_A48GeneroId[0];
            A43SerieImagem = BC000116_A43SerieImagem[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound1 = 1;
            A1SerieId = BC000116_A1SerieId[0];
            A60SerieDataHoraCadastro = BC000116_A60SerieDataHoraCadastro[0];
            A2SerieNome = BC000116_A2SerieNome[0];
            A3SerieQuantidadeTemporadas = BC000116_A3SerieQuantidadeTemporadas[0];
            A49GeneroNome = BC000116_A49GeneroNome[0];
            A6SerieResumo = BC000116_A6SerieResumo[0];
            A40000SerieImagem_GXI = BC000116_A40000SerieImagem_GXI[0];
            A47SerieInativo = BC000116_A47SerieInativo[0];
            A48GeneroId = BC000116_A48GeneroId[0];
            A43SerieImagem = BC000116_A43SerieImagem[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bcSerie) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bcSerie, 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         A2SerieNome = "";
         A3SerieQuantidadeTemporadas = 0;
         A48GeneroId = 0;
         A49GeneroNome = "";
         A6SerieResumo = "";
         A43SerieImagem = "";
         A40000SerieImagem_GXI = "";
         A47SerieInativo = false;
         Z60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         Z2SerieNome = "";
         Z3SerieQuantidadeTemporadas = 0;
         Z47SerieInativo = false;
         Z48GeneroId = 0;
      }

      protected void InitAll011( )
      {
         A1SerieId = 0;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A60SerieDataHoraCadastro = i60SerieDataHoraCadastro;
      }

      public void VarsToRow1( SdtSerie obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Seriedatahoracadastro = A60SerieDataHoraCadastro;
         obj1.gxTpr_Serienome = A2SerieNome;
         obj1.gxTpr_Seriequantidadetemporadas = A3SerieQuantidadeTemporadas;
         obj1.gxTpr_Generoid = A48GeneroId;
         obj1.gxTpr_Generonome = A49GeneroNome;
         obj1.gxTpr_Serieresumo = A6SerieResumo;
         obj1.gxTpr_Serieimagem = A43SerieImagem;
         obj1.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
         obj1.gxTpr_Serieinativo = A47SerieInativo;
         obj1.gxTpr_Serieid = A1SerieId;
         obj1.gxTpr_Serieid_Z = Z1SerieId;
         obj1.gxTpr_Serienome_Z = Z2SerieNome;
         obj1.gxTpr_Seriequantidadetemporadas_Z = Z3SerieQuantidadeTemporadas;
         obj1.gxTpr_Generoid_Z = Z48GeneroId;
         obj1.gxTpr_Generonome_Z = Z49GeneroNome;
         obj1.gxTpr_Serieinativo_Z = Z47SerieInativo;
         obj1.gxTpr_Seriedatahoracadastro_Z = Z60SerieDataHoraCadastro;
         obj1.gxTpr_Serieimagem_gxi_Z = Z40000SerieImagem_GXI;
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( SdtSerie obj1 )
      {
         obj1.gxTpr_Serieid = A1SerieId;
         return  ;
      }

      public void RowToVars1( SdtSerie obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         A60SerieDataHoraCadastro = obj1.gxTpr_Seriedatahoracadastro;
         A2SerieNome = obj1.gxTpr_Serienome;
         A3SerieQuantidadeTemporadas = obj1.gxTpr_Seriequantidadetemporadas;
         A48GeneroId = obj1.gxTpr_Generoid;
         A49GeneroNome = obj1.gxTpr_Generonome;
         A6SerieResumo = obj1.gxTpr_Serieresumo;
         A43SerieImagem = obj1.gxTpr_Serieimagem;
         A40000SerieImagem_GXI = obj1.gxTpr_Serieimagem_gxi;
         A47SerieInativo = obj1.gxTpr_Serieinativo;
         A1SerieId = obj1.gxTpr_Serieid;
         Z1SerieId = obj1.gxTpr_Serieid_Z;
         Z2SerieNome = obj1.gxTpr_Serienome_Z;
         Z3SerieQuantidadeTemporadas = obj1.gxTpr_Seriequantidadetemporadas_Z;
         Z48GeneroId = obj1.gxTpr_Generoid_Z;
         Z49GeneroNome = obj1.gxTpr_Generonome_Z;
         Z47SerieInativo = obj1.gxTpr_Serieinativo_Z;
         Z60SerieDataHoraCadastro = obj1.gxTpr_Seriedatahoracadastro_Z;
         Z40000SerieImagem_GXI = obj1.gxTpr_Serieimagem_gxi_Z;
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1SerieId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1SerieId = A1SerieId;
         }
         ZM011( -9) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bcSerie, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1SerieId = A1SerieId;
         }
         ZM011( -9) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1SerieId != Z1SerieId )
               {
                  A1SerieId = Z1SerieId;
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
                  Update011( ) ;
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
                  if ( A1SerieId != Z1SerieId )
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
                        Insert011( ) ;
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
                        Insert011( ) ;
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
         RowToVars1( bcSerie, 0) ;
         SaveImpl( ) ;
         VarsToRow1( bcSerie) ;
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
         RowToVars1( bcSerie, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         AfterTrn( ) ;
         VarsToRow1( bcSerie) ;
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
            SdtSerie auxBC = new SdtSerie(context) ;
            auxBC.Load(A1SerieId);
            auxBC.UpdateDirties(bcSerie);
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
         RowToVars1( bcSerie, 0) ;
         UpdateImpl( ) ;
         VarsToRow1( bcSerie) ;
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
         RowToVars1( bcSerie, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
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
         VarsToRow1( bcSerie) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bcSerie, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A1SerieId != Z1SerieId )
            {
               A1SerieId = Z1SerieId;
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
            if ( A1SerieId != Z1SerieId )
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
         pr_default.close(10);
         pr_gam.rollback( "Serie_BC");
         pr_default.rollback( "Serie_BC");
         VarsToRow1( bcSerie) ;
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
         Gx_mode = bcSerie.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSerie.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSerie )
         {
            bcSerie = (SdtSerie)(sdt);
            if ( StringUtil.StrCmp(bcSerie.gxTpr_Mode, "") == 0 )
            {
               bcSerie.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bcSerie) ;
            }
            else
            {
               RowToVars1( bcSerie, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSerie.gxTpr_Mode, "") == 0 )
            {
               bcSerie.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bcSerie, 1) ;
         return  ;
      }

      public SdtSerie Serie_BC
      {
         get {
            return bcSerie ;
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
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00015_A1SerieId = new long[1] ;
         BC00015_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         BC00015_A2SerieNome = new String[] {""} ;
         BC00015_A3SerieQuantidadeTemporadas = new short[1] ;
         BC00015_A49GeneroNome = new String[] {""} ;
         BC00015_A6SerieResumo = new String[] {""} ;
         BC00015_A40000SerieImagem_GXI = new String[] {""} ;
         BC00015_A47SerieInativo = new bool[] {false} ;
         BC00015_A48GeneroId = new long[1] ;
         BC00015_A43SerieImagem = new String[] {""} ;
         A60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         A2SerieNome = "";
         A49GeneroNome = "";
         A6SerieResumo = "";
         A40000SerieImagem_GXI = "";
         A43SerieImagem = "";
         gx_restcollection = new GXBCCollection<SdtSerie>( context, "Serie", "SeriesColaborativas");
         sMode1 = "";
         Gx_mode = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV15Pgmname = "";
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         Z2SerieNome = "";
         Z49GeneroNome = "";
         Z6SerieResumo = "";
         Z43SerieImagem = "";
         Z40000SerieImagem_GXI = "";
         BC00016_A1SerieId = new long[1] ;
         BC00016_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         BC00016_A2SerieNome = new String[] {""} ;
         BC00016_A3SerieQuantidadeTemporadas = new short[1] ;
         BC00016_A49GeneroNome = new String[] {""} ;
         BC00016_A6SerieResumo = new String[] {""} ;
         BC00016_A40000SerieImagem_GXI = new String[] {""} ;
         BC00016_A47SerieInativo = new bool[] {false} ;
         BC00016_A48GeneroId = new long[1] ;
         BC00016_A43SerieImagem = new String[] {""} ;
         BC00014_A49GeneroNome = new String[] {""} ;
         BC00017_A1SerieId = new long[1] ;
         BC00013_A1SerieId = new long[1] ;
         BC00013_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         BC00013_A2SerieNome = new String[] {""} ;
         BC00013_A3SerieQuantidadeTemporadas = new short[1] ;
         BC00013_A6SerieResumo = new String[] {""} ;
         BC00013_A40000SerieImagem_GXI = new String[] {""} ;
         BC00013_A47SerieInativo = new bool[] {false} ;
         BC00013_A48GeneroId = new long[1] ;
         BC00013_A43SerieImagem = new String[] {""} ;
         BC00012_A1SerieId = new long[1] ;
         BC00012_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         BC00012_A2SerieNome = new String[] {""} ;
         BC00012_A3SerieQuantidadeTemporadas = new short[1] ;
         BC00012_A6SerieResumo = new String[] {""} ;
         BC00012_A40000SerieImagem_GXI = new String[] {""} ;
         BC00012_A47SerieInativo = new bool[] {false} ;
         BC00012_A48GeneroId = new long[1] ;
         BC00012_A43SerieImagem = new String[] {""} ;
         BC00018_A1SerieId = new long[1] ;
         BC000112_A49GeneroNome = new String[] {""} ;
         BC000113_A32UsuarioRecomendacaoSerieId = new long[1] ;
         BC000114_A13UsuarioSerieId = new long[1] ;
         BC000115_A7EpisodioId = new long[1] ;
         BC000116_A1SerieId = new long[1] ;
         BC000116_A60SerieDataHoraCadastro = new DateTime[] {DateTime.MinValue} ;
         BC000116_A2SerieNome = new String[] {""} ;
         BC000116_A3SerieQuantidadeTemporadas = new short[1] ;
         BC000116_A49GeneroNome = new String[] {""} ;
         BC000116_A6SerieResumo = new String[] {""} ;
         BC000116_A40000SerieImagem_GXI = new String[] {""} ;
         BC000116_A47SerieInativo = new bool[] {false} ;
         BC000116_A48GeneroId = new long[1] ;
         BC000116_A43SerieImagem = new String[] {""} ;
         i60SerieDataHoraCadastro = (DateTime)(DateTime.MinValue);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.serie_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.serie_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A1SerieId, BC00012_A60SerieDataHoraCadastro, BC00012_A2SerieNome, BC00012_A3SerieQuantidadeTemporadas, BC00012_A6SerieResumo, BC00012_A40000SerieImagem_GXI, BC00012_A47SerieInativo, BC00012_A48GeneroId, BC00012_A43SerieImagem
               }
               , new Object[] {
               BC00013_A1SerieId, BC00013_A60SerieDataHoraCadastro, BC00013_A2SerieNome, BC00013_A3SerieQuantidadeTemporadas, BC00013_A6SerieResumo, BC00013_A40000SerieImagem_GXI, BC00013_A47SerieInativo, BC00013_A48GeneroId, BC00013_A43SerieImagem
               }
               , new Object[] {
               BC00014_A49GeneroNome
               }
               , new Object[] {
               BC00015_A1SerieId, BC00015_A60SerieDataHoraCadastro, BC00015_A2SerieNome, BC00015_A3SerieQuantidadeTemporadas, BC00015_A49GeneroNome, BC00015_A6SerieResumo, BC00015_A40000SerieImagem_GXI, BC00015_A47SerieInativo, BC00015_A48GeneroId, BC00015_A43SerieImagem
               }
               , new Object[] {
               BC00016_A1SerieId, BC00016_A60SerieDataHoraCadastro, BC00016_A2SerieNome, BC00016_A3SerieQuantidadeTemporadas, BC00016_A49GeneroNome, BC00016_A6SerieResumo, BC00016_A40000SerieImagem_GXI, BC00016_A47SerieInativo, BC00016_A48GeneroId, BC00016_A43SerieImagem
               }
               , new Object[] {
               BC00017_A1SerieId
               }
               , new Object[] {
               BC00018_A1SerieId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000112_A49GeneroNome
               }
               , new Object[] {
               BC000113_A32UsuarioRecomendacaoSerieId
               }
               , new Object[] {
               BC000114_A13UsuarioSerieId
               }
               , new Object[] {
               BC000115_A7EpisodioId
               }
               , new Object[] {
               BC000116_A1SerieId, BC000116_A60SerieDataHoraCadastro, BC000116_A2SerieNome, BC000116_A3SerieQuantidadeTemporadas, BC000116_A49GeneroNome, BC000116_A6SerieResumo, BC000116_A40000SerieImagem_GXI, BC000116_A47SerieInativo, BC000116_A48GeneroId, BC000116_A43SerieImagem
               }
            }
         );
         AV15Pgmname = "Serie_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12012 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound1 ;
      private short A3SerieQuantidadeTemporadas ;
      private short GX_JID ;
      private short Z3SerieQuantidadeTemporadas ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom1 ;
      private int GXPagingTo1 ;
      private int AV16GXV1 ;
      private long A1SerieId ;
      private long A48GeneroId ;
      private long Z1SerieId ;
      private long AV13Insert_GeneroId ;
      private long Z48GeneroId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode1 ;
      private String Gx_mode ;
      private String AV15Pgmname ;
      private DateTime A60SerieDataHoraCadastro ;
      private DateTime Z60SerieDataHoraCadastro ;
      private DateTime i60SerieDataHoraCadastro ;
      private bool A47SerieInativo ;
      private bool Z47SerieInativo ;
      private String A6SerieResumo ;
      private String Z6SerieResumo ;
      private String A2SerieNome ;
      private String A49GeneroNome ;
      private String A40000SerieImagem_GXI ;
      private String Z2SerieNome ;
      private String Z49GeneroNome ;
      private String Z40000SerieImagem_GXI ;
      private String A43SerieImagem ;
      private String Z43SerieImagem ;
      private IGxSession AV12WebSession ;
      private GXBCCollection<SdtSerie> gx_restcollection ;
      private SdtSerie bcSerie ;
      private SdtSerie gx_sdt_item ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00015_A1SerieId ;
      private DateTime[] BC00015_A60SerieDataHoraCadastro ;
      private String[] BC00015_A2SerieNome ;
      private short[] BC00015_A3SerieQuantidadeTemporadas ;
      private String[] BC00015_A49GeneroNome ;
      private String[] BC00015_A6SerieResumo ;
      private String[] BC00015_A40000SerieImagem_GXI ;
      private bool[] BC00015_A47SerieInativo ;
      private long[] BC00015_A48GeneroId ;
      private String[] BC00015_A43SerieImagem ;
      private long[] BC00016_A1SerieId ;
      private DateTime[] BC00016_A60SerieDataHoraCadastro ;
      private String[] BC00016_A2SerieNome ;
      private short[] BC00016_A3SerieQuantidadeTemporadas ;
      private String[] BC00016_A49GeneroNome ;
      private String[] BC00016_A6SerieResumo ;
      private String[] BC00016_A40000SerieImagem_GXI ;
      private bool[] BC00016_A47SerieInativo ;
      private long[] BC00016_A48GeneroId ;
      private String[] BC00016_A43SerieImagem ;
      private String[] BC00014_A49GeneroNome ;
      private long[] BC00017_A1SerieId ;
      private long[] BC00013_A1SerieId ;
      private DateTime[] BC00013_A60SerieDataHoraCadastro ;
      private String[] BC00013_A2SerieNome ;
      private short[] BC00013_A3SerieQuantidadeTemporadas ;
      private String[] BC00013_A6SerieResumo ;
      private String[] BC00013_A40000SerieImagem_GXI ;
      private bool[] BC00013_A47SerieInativo ;
      private long[] BC00013_A48GeneroId ;
      private String[] BC00013_A43SerieImagem ;
      private long[] BC00012_A1SerieId ;
      private DateTime[] BC00012_A60SerieDataHoraCadastro ;
      private String[] BC00012_A2SerieNome ;
      private short[] BC00012_A3SerieQuantidadeTemporadas ;
      private String[] BC00012_A6SerieResumo ;
      private String[] BC00012_A40000SerieImagem_GXI ;
      private bool[] BC00012_A47SerieInativo ;
      private long[] BC00012_A48GeneroId ;
      private String[] BC00012_A43SerieImagem ;
      private long[] BC00018_A1SerieId ;
      private String[] BC000112_A49GeneroNome ;
      private long[] BC000113_A32UsuarioRecomendacaoSerieId ;
      private long[] BC000114_A13UsuarioSerieId ;
      private long[] BC000115_A7EpisodioId ;
      private long[] BC000116_A1SerieId ;
      private DateTime[] BC000116_A60SerieDataHoraCadastro ;
      private String[] BC000116_A2SerieNome ;
      private short[] BC000116_A3SerieQuantidadeTemporadas ;
      private String[] BC000116_A49GeneroNome ;
      private String[] BC000116_A6SerieResumo ;
      private String[] BC000116_A40000SerieImagem_GXI ;
      private bool[] BC000116_A47SerieInativo ;
      private long[] BC000116_A48GeneroId ;
      private String[] BC000116_A43SerieImagem ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class serie_bc__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class serie_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00015 ;
        prmBC00015 = new Object[] {
        new Object[] {"@GXPagingFrom1",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo1",SqlDbType.Int,9,0}
        } ;
        Object[] prmBC00016 ;
        prmBC00016 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00014 ;
        prmBC00014 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00017 ;
        prmBC00017 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00013 ;
        prmBC00013 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00012 ;
        prmBC00012 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00018 ;
        prmBC00018 = new Object[] {
        new Object[] {"@SerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@SerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SerieResumo",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@SerieImagem",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@SerieImagem_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@SerieInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00019 ;
        prmBC00019 = new Object[] {
        new Object[] {"@SerieDataHoraCadastro",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SerieNome",SqlDbType.VarChar,40,0} ,
        new Object[] {"@SerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SerieResumo",SqlDbType.VarChar,2097152,0} ,
        new Object[] {"@SerieInativo",SqlDbType.Bit,4,0} ,
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000110 ;
        prmBC000110 = new Object[] {
        new Object[] {"@SerieImagem",SqlDbType.VarBinary,1024,0} ,
        new Object[] {"@SerieImagem_GXI",SqlDbType.VarChar,2048,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000111 ;
        prmBC000111 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000112 ;
        prmBC000112 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000113 ;
        prmBC000113 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000114 ;
        prmBC000114 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000115 ;
        prmBC000115 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000116 ;
        prmBC000116 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00012", "SELECT [SerieId], [SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem_GXI], [SerieInativo], [GeneroId], [SerieImagem] FROM [Serie] WITH (UPDLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1,0,true,false )
           ,new CursorDef("BC00013", "SELECT [SerieId], [SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem_GXI], [SerieInativo], [GeneroId], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1,0,true,false )
           ,new CursorDef("BC00014", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,1,0,true,false )
           ,new CursorDef("BC00015", "SELECT TM1.[SerieId], TM1.[SerieDataHoraCadastro], TM1.[SerieNome], TM1.[SerieQuantidadeTemporadas], T2.[GeneroNome], TM1.[SerieResumo], TM1.[SerieImagem_GXI], TM1.[SerieInativo], TM1.[GeneroId], TM1.[SerieImagem] FROM ([Serie] TM1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = TM1.[GeneroId]) ORDER BY TM1.[SerieId]  OFFSET @GXPagingFrom1 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo1 > 0 THEN @GXPagingTo1 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,100,0,true,false )
           ,new CursorDef("BC00016", "SELECT TM1.[SerieId], TM1.[SerieDataHoraCadastro], TM1.[SerieNome], TM1.[SerieQuantidadeTemporadas], T2.[GeneroNome], TM1.[SerieResumo], TM1.[SerieImagem_GXI], TM1.[SerieInativo], TM1.[GeneroId], TM1.[SerieImagem] FROM ([Serie] TM1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = TM1.[GeneroId]) WHERE TM1.[SerieId] = @SerieId ORDER BY TM1.[SerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00016,100,0,true,false )
           ,new CursorDef("BC00017", "SELECT [SerieId] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00017,1,0,true,false )
           ,new CursorDef("BC00018", "INSERT INTO [Serie]([SerieDataHoraCadastro], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem], [SerieImagem_GXI], [SerieInativo], [GeneroId]) VALUES(@SerieDataHoraCadastro, @SerieNome, @SerieQuantidadeTemporadas, @SerieResumo, @SerieImagem, @SerieImagem_GXI, @SerieInativo, @GeneroId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00018)
           ,new CursorDef("BC00019", "UPDATE [Serie] SET [SerieDataHoraCadastro]=@SerieDataHoraCadastro, [SerieNome]=@SerieNome, [SerieQuantidadeTemporadas]=@SerieQuantidadeTemporadas, [SerieResumo]=@SerieResumo, [SerieInativo]=@SerieInativo, [GeneroId]=@GeneroId  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmBC00019)
           ,new CursorDef("BC000110", "UPDATE [Serie] SET [SerieImagem]=@SerieImagem, [SerieImagem_GXI]=@SerieImagem_GXI  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmBC000110)
           ,new CursorDef("BC000111", "DELETE FROM [Serie]  WHERE [SerieId] = @SerieId", GxErrorMask.GX_NOMASK,prmBC000111)
           ,new CursorDef("BC000112", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000112,1,0,true,false )
           ,new CursorDef("BC000113", "SELECT TOP 1 [UsuarioRecomendacaoSerieId] FROM [UsuarioRecomendacaoSerie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000113,1,0,true,true )
           ,new CursorDef("BC000114", "SELECT TOP 1 [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000114,1,0,true,true )
           ,new CursorDef("BC000115", "SELECT TOP 1 [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000115,1,0,true,true )
           ,new CursorDef("BC000116", "SELECT TM1.[SerieId], TM1.[SerieDataHoraCadastro], TM1.[SerieNome], TM1.[SerieQuantidadeTemporadas], T2.[GeneroNome], TM1.[SerieResumo], TM1.[SerieImagem_GXI], TM1.[SerieInativo], TM1.[GeneroId], TM1.[SerieImagem] FROM ([Serie] TM1 WITH (NOLOCK) INNER JOIN [Genero] T2 WITH (NOLOCK) ON T2.[GeneroId] = TM1.[GeneroId]) WHERE TM1.[SerieId] = @SerieId ORDER BY TM1.[SerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000116,100,0,true,false )
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
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(6)) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((long[]) buf[7])[0] = rslt.getLong(8) ;
              ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(6)) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 14 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
              ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
              ((bool[]) buf[7])[0] = rslt.getBool(8) ;
              ((long[]) buf[8])[0] = rslt.getLong(9) ;
              ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
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
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameterBlob(5, (String)parms[4], false);
              stmt.SetParameterMultimedia(6, (String)parms[5], (String)parms[4], "Serie", "SerieImagem");
              stmt.SetParameter(7, (bool)parms[6]);
              stmt.SetParameter(8, (long)parms[7]);
              return;
           case 7 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (bool)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 8 :
              stmt.SetParameterBlob(1, (String)parms[0], false);
              stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Serie", "SerieImagem");
              stmt.SetParameter(3, (long)parms[2]);
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
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.serie_bc_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class serie_bc_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "GET" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA1SerieId}")]
   public SdtSerie_RESTInterface Load( string sA1SerieId )
   {
      try
      {
         long A1SerieId ;
         A1SerieId = (long)(NumberUtil.Val( (String)(sA1SerieId), "."));
         SdtSerie worker = new SdtSerie(context) ;
         SdtSerie_RESTInterface worker_interface = new SdtSerie_RESTInterface (worker);
         if ( StringUtil.StrCmp(sA1SerieId, "_default") == 0 )
         {
            IGxSilentTrn workertrn = worker.getTransaction() ;
            workertrn.GetInsDefault();
         }
         else
         {
            worker.Load(A1SerieId);
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
   	UriTemplate = "/{sA1SerieId}")]
   public SdtSerie_RESTInterface Delete( string sA1SerieId )
   {
      try
      {
         long A1SerieId ;
         A1SerieId = (long)(NumberUtil.Val( (String)(sA1SerieId), "."));
         SdtSerie worker = new SdtSerie(context) ;
         SdtSerie_RESTInterface worker_interface = new SdtSerie_RESTInterface (worker);
         worker.Load(A1SerieId);
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
   	UriTemplate = "/{sA1SerieId}")]
   public SdtSerie_RESTInterface Insert( string sA1SerieId ,
                                         SdtSerie_RESTInterface entity )
   {
      try
      {
         long A1SerieId ;
         A1SerieId = (long)(NumberUtil.Val( (String)(sA1SerieId), "."));
         SdtSerie worker = new SdtSerie(context) ;
         bool gxcheck = RestParameter("check", "true") ;
         bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
         SdtSerie_RESTInterface worker_interface = new SdtSerie_RESTInterface (worker);
         worker_interface.CopyFrom(entity);
         worker.gxTpr_Serieid = A1SerieId;
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
   	UriTemplate = "/{sA1SerieId}")]
   public SdtSerie_RESTInterface Update( string sA1SerieId ,
                                         SdtSerie_RESTInterface entity )
   {
      try
      {
         long A1SerieId ;
         A1SerieId = (long)(NumberUtil.Val( (String)(sA1SerieId), "."));
         SdtSerie worker = new SdtSerie(context) ;
         SdtSerie_RESTInterface worker_interface = new SdtSerie_RESTInterface (worker);
         bool gxcheck = RestParameter("check", "true") ;
         worker.Load(A1SerieId);
         if (entity.Hash == worker_interface.Hash) {
            worker_interface.CopyFrom(entity);
            worker.gxTpr_Serieid = A1SerieId;
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
            SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Serie"}) );
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
