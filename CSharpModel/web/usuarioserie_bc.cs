/*
               File: UsuarioSerie_BC
        Description: Usuário série
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:20.43
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
   public class usuarioserie_bc : GXHttpHandler, IGxSilentTrn
   {
      public usuarioserie_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioserie_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtUsuarioSerie> GetAll( int Start ,
                                                     int Count )
      {
         GXPagingFrom4 = Start;
         GXPagingTo4 = Count;
         /* Using cursor BC00047 */
         pr_default.execute(5, new Object[] {GXPagingFrom4, GXPagingTo4});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
            A48GeneroId = BC00047_A48GeneroId[0];
            A13UsuarioSerieId = BC00047_A13UsuarioSerieId[0];
            A2SerieNome = BC00047_A2SerieNome[0];
            A40000SerieImagem_GXI = BC00047_A40000SerieImagem_GXI[0];
            A49GeneroNome = BC00047_A49GeneroNome[0];
            A14UsuarioSerieNota = BC00047_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = BC00047_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = BC00047_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = BC00047_A17UsuarioSerieFavorita[0];
            A11UsuarioId = BC00047_A11UsuarioId[0];
            A1SerieId = BC00047_A1SerieId[0];
            A43SerieImagem = BC00047_A43SerieImagem[0];
         }
         bcUsuarioSerie = new SdtUsuarioSerie(context);
         gx_restcollection.Clear();
         while ( RcdFound4 != 0 )
         {
            OnLoadActions044( ) ;
            AddRow044( ) ;
            gx_sdt_item = (SdtUsuarioSerie)(bcUsuarioSerie.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(5);
            RcdFound4 = 0;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(5) != 101) )
            {
               RcdFound4 = 1;
               A48GeneroId = BC00047_A48GeneroId[0];
               A13UsuarioSerieId = BC00047_A13UsuarioSerieId[0];
               A2SerieNome = BC00047_A2SerieNome[0];
               A40000SerieImagem_GXI = BC00047_A40000SerieImagem_GXI[0];
               A49GeneroNome = BC00047_A49GeneroNome[0];
               A14UsuarioSerieNota = BC00047_A14UsuarioSerieNota[0];
               A15UsuarioSerieAssistida = BC00047_A15UsuarioSerieAssistida[0];
               A16UsuarioSerieComentario = BC00047_A16UsuarioSerieComentario[0];
               A17UsuarioSerieFavorita = BC00047_A17UsuarioSerieFavorita[0];
               A11UsuarioId = BC00047_A11UsuarioId[0];
               A1SerieId = BC00047_A1SerieId[0];
               A43SerieImagem = BC00047_A43SerieImagem[0];
            }
            Gx_mode = sMode4;
         }
         pr_default.close(5);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM044( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow044( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey044( ) ;
         standaloneModal( ) ;
         AddRow044( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z13UsuarioSerieId = A13UsuarioSerieId;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls044( ) ;
            }
            else
            {
               CheckExtendedTable044( ) ;
               if ( AnyError == 0 )
               {
                  ZM044( 2) ;
                  ZM044( 3) ;
                  ZM044( 4) ;
               }
               CloseExtendedTableCursors044( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM044( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z14UsuarioSerieNota = A14UsuarioSerieNota;
            Z15UsuarioSerieAssistida = A15UsuarioSerieAssistida;
            Z16UsuarioSerieComentario = A16UsuarioSerieComentario;
            Z17UsuarioSerieFavorita = A17UsuarioSerieFavorita;
            Z11UsuarioId = A11UsuarioId;
            Z1SerieId = A1SerieId;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z48GeneroId = A48GeneroId;
            Z2SerieNome = A2SerieNome;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z49GeneroNome = A49GeneroNome;
         }
         if ( GX_JID == -1 )
         {
            Z13UsuarioSerieId = A13UsuarioSerieId;
            Z14UsuarioSerieNota = A14UsuarioSerieNota;
            Z15UsuarioSerieAssistida = A15UsuarioSerieAssistida;
            Z16UsuarioSerieComentario = A16UsuarioSerieComentario;
            Z17UsuarioSerieFavorita = A17UsuarioSerieFavorita;
            Z11UsuarioId = A11UsuarioId;
            Z1SerieId = A1SerieId;
            Z48GeneroId = A48GeneroId;
            Z2SerieNome = A2SerieNome;
            Z43SerieImagem = A43SerieImagem;
            Z40000SerieImagem_GXI = A40000SerieImagem_GXI;
            Z49GeneroNome = A49GeneroNome;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load044( )
      {
         /* Using cursor BC00048 */
         pr_default.execute(6, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound4 = 1;
            A48GeneroId = BC00048_A48GeneroId[0];
            A2SerieNome = BC00048_A2SerieNome[0];
            A40000SerieImagem_GXI = BC00048_A40000SerieImagem_GXI[0];
            A49GeneroNome = BC00048_A49GeneroNome[0];
            A14UsuarioSerieNota = BC00048_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = BC00048_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = BC00048_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = BC00048_A17UsuarioSerieFavorita[0];
            A11UsuarioId = BC00048_A11UsuarioId[0];
            A1SerieId = BC00048_A1SerieId[0];
            A43SerieImagem = BC00048_A43SerieImagem[0];
            ZM044( -1) ;
         }
         pr_default.close(6);
         OnLoadActions044( ) ;
      }

      protected void OnLoadActions044( )
      {
      }

      protected void CheckExtendedTable044( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00044 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
         }
         pr_default.close(2);
         /* Using cursor BC00045 */
         pr_default.execute(3, new Object[] {A1SerieId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Série'.", "ForeignKeyNotFound", 1, "SERIEID");
            AnyError = 1;
         }
         A48GeneroId = BC00045_A48GeneroId[0];
         A2SerieNome = BC00045_A2SerieNome[0];
         A40000SerieImagem_GXI = BC00045_A40000SerieImagem_GXI[0];
         A43SerieImagem = BC00045_A43SerieImagem[0];
         pr_default.close(3);
         /* Using cursor BC00046 */
         pr_default.execute(4, new Object[] {A48GeneroId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("Não existe 'Gênero'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A49GeneroNome = BC00046_A49GeneroNome[0];
         pr_default.close(4);
      }

      protected void CloseExtendedTableCursors044( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey044( )
      {
         /* Using cursor BC00049 */
         pr_default.execute(7, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00043 */
         pr_default.execute(1, new Object[] {A13UsuarioSerieId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM044( 1) ;
            RcdFound4 = 1;
            A13UsuarioSerieId = BC00043_A13UsuarioSerieId[0];
            A14UsuarioSerieNota = BC00043_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = BC00043_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = BC00043_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = BC00043_A17UsuarioSerieFavorita[0];
            A11UsuarioId = BC00043_A11UsuarioId[0];
            A1SerieId = BC00043_A1SerieId[0];
            Z13UsuarioSerieId = A13UsuarioSerieId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load044( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey044( ) ;
            }
            Gx_mode = sMode4;
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey044( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode4;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey044( ) ;
         if ( RcdFound4 == 0 )
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
         CONFIRM_040( ) ;
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

      protected void CheckOptimisticConcurrency044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00042 */
            pr_default.execute(0, new Object[] {A13UsuarioSerieId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioSerie"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z14UsuarioSerieNota != BC00042_A14UsuarioSerieNota[0] ) || ( Z15UsuarioSerieAssistida != BC00042_A15UsuarioSerieAssistida[0] ) || ( StringUtil.StrCmp(Z16UsuarioSerieComentario, BC00042_A16UsuarioSerieComentario[0]) != 0 ) || ( Z17UsuarioSerieFavorita != BC00042_A17UsuarioSerieFavorita[0] ) || ( Z11UsuarioId != BC00042_A11UsuarioId[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z1SerieId != BC00042_A1SerieId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioSerie"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM044( 0) ;
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000410 */
                     pr_default.execute(8, new Object[] {A14UsuarioSerieNota, A15UsuarioSerieAssistida, A16UsuarioSerieComentario, A17UsuarioSerieFavorita, A11UsuarioId, A1SerieId});
                     A13UsuarioSerieId = BC000410_A13UsuarioSerieId[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
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
               Load044( ) ;
            }
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void Update044( )
      {
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable044( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm044( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate044( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000411 */
                     pr_default.execute(9, new Object[] {A14UsuarioSerieNota, A15UsuarioSerieAssistida, A16UsuarioSerieComentario, A17UsuarioSerieFavorita, A11UsuarioId, A1SerieId, A13UsuarioSerieId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioSerie"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate044( ) ;
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
            EndLevel044( ) ;
         }
         CloseExtendedTableCursors044( ) ;
      }

      protected void DeferredUpdate044( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate044( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency044( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls044( ) ;
            AfterConfirm044( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete044( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000412 */
                  pr_default.execute(10, new Object[] {A13UsuarioSerieId});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioSerie") ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel044( ) ;
         Gx_mode = sMode4;
      }

      protected void OnDeleteControls044( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000413 */
            pr_default.execute(11, new Object[] {A1SerieId});
            A48GeneroId = BC000413_A48GeneroId[0];
            A2SerieNome = BC000413_A2SerieNome[0];
            A40000SerieImagem_GXI = BC000413_A40000SerieImagem_GXI[0];
            A43SerieImagem = BC000413_A43SerieImagem[0];
            pr_default.close(11);
            /* Using cursor BC000414 */
            pr_default.execute(12, new Object[] {A48GeneroId});
            A49GeneroNome = BC000414_A49GeneroNome[0];
            pr_default.close(12);
         }
      }

      protected void EndLevel044( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete044( ) ;
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

      public void ScanKeyStart044( )
      {
         /* Using cursor BC000415 */
         pr_default.execute(13, new Object[] {A13UsuarioSerieId});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound4 = 1;
            A48GeneroId = BC000415_A48GeneroId[0];
            A13UsuarioSerieId = BC000415_A13UsuarioSerieId[0];
            A2SerieNome = BC000415_A2SerieNome[0];
            A40000SerieImagem_GXI = BC000415_A40000SerieImagem_GXI[0];
            A49GeneroNome = BC000415_A49GeneroNome[0];
            A14UsuarioSerieNota = BC000415_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = BC000415_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = BC000415_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = BC000415_A17UsuarioSerieFavorita[0];
            A11UsuarioId = BC000415_A11UsuarioId[0];
            A1SerieId = BC000415_A1SerieId[0];
            A43SerieImagem = BC000415_A43SerieImagem[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext044( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound4 = 0;
         ScanKeyLoad044( ) ;
      }

      protected void ScanKeyLoad044( )
      {
         sMode4 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound4 = 1;
            A48GeneroId = BC000415_A48GeneroId[0];
            A13UsuarioSerieId = BC000415_A13UsuarioSerieId[0];
            A2SerieNome = BC000415_A2SerieNome[0];
            A40000SerieImagem_GXI = BC000415_A40000SerieImagem_GXI[0];
            A49GeneroNome = BC000415_A49GeneroNome[0];
            A14UsuarioSerieNota = BC000415_A14UsuarioSerieNota[0];
            A15UsuarioSerieAssistida = BC000415_A15UsuarioSerieAssistida[0];
            A16UsuarioSerieComentario = BC000415_A16UsuarioSerieComentario[0];
            A17UsuarioSerieFavorita = BC000415_A17UsuarioSerieFavorita[0];
            A11UsuarioId = BC000415_A11UsuarioId[0];
            A1SerieId = BC000415_A1SerieId[0];
            A43SerieImagem = BC000415_A43SerieImagem[0];
         }
         Gx_mode = sMode4;
      }

      protected void ScanKeyEnd044( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm044( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert044( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate044( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete044( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete044( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate044( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes044( )
      {
      }

      protected void send_integrity_lvl_hashes044( )
      {
      }

      protected void AddRow044( )
      {
         VarsToRow4( bcUsuarioSerie) ;
      }

      protected void ReadRow044( )
      {
         RowToVars4( bcUsuarioSerie, 1) ;
      }

      protected void InitializeNonKey044( )
      {
         A48GeneroId = 0;
         A11UsuarioId = 0;
         A1SerieId = 0;
         A2SerieNome = "";
         A43SerieImagem = "";
         A40000SerieImagem_GXI = "";
         A49GeneroNome = "";
         A14UsuarioSerieNota = 0;
         A15UsuarioSerieAssistida = false;
         A16UsuarioSerieComentario = "";
         A17UsuarioSerieFavorita = false;
         Z14UsuarioSerieNota = 0;
         Z15UsuarioSerieAssistida = false;
         Z16UsuarioSerieComentario = "";
         Z17UsuarioSerieFavorita = false;
         Z11UsuarioId = 0;
         Z1SerieId = 0;
      }

      protected void InitAll044( )
      {
         A13UsuarioSerieId = 0;
         InitializeNonKey044( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow4( SdtUsuarioSerie obj4 )
      {
         obj4.gxTpr_Mode = Gx_mode;
         obj4.gxTpr_Usuarioid = A11UsuarioId;
         obj4.gxTpr_Serieid = A1SerieId;
         obj4.gxTpr_Serienome = A2SerieNome;
         obj4.gxTpr_Serieimagem = A43SerieImagem;
         obj4.gxTpr_Serieimagem_gxi = A40000SerieImagem_GXI;
         obj4.gxTpr_Generonome = A49GeneroNome;
         obj4.gxTpr_Usuarioserienota = A14UsuarioSerieNota;
         obj4.gxTpr_Usuarioserieassistida = A15UsuarioSerieAssistida;
         obj4.gxTpr_Usuarioseriecomentario = A16UsuarioSerieComentario;
         obj4.gxTpr_Usuarioseriefavorita = A17UsuarioSerieFavorita;
         obj4.gxTpr_Usuarioserieid = A13UsuarioSerieId;
         obj4.gxTpr_Usuarioserieid_Z = Z13UsuarioSerieId;
         obj4.gxTpr_Usuarioid_Z = Z11UsuarioId;
         obj4.gxTpr_Serieid_Z = Z1SerieId;
         obj4.gxTpr_Serienome_Z = Z2SerieNome;
         obj4.gxTpr_Generonome_Z = Z49GeneroNome;
         obj4.gxTpr_Usuarioserienota_Z = Z14UsuarioSerieNota;
         obj4.gxTpr_Usuarioserieassistida_Z = Z15UsuarioSerieAssistida;
         obj4.gxTpr_Usuarioseriecomentario_Z = Z16UsuarioSerieComentario;
         obj4.gxTpr_Usuarioseriefavorita_Z = Z17UsuarioSerieFavorita;
         obj4.gxTpr_Serieimagem_gxi_Z = Z40000SerieImagem_GXI;
         obj4.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow4( SdtUsuarioSerie obj4 )
      {
         obj4.gxTpr_Usuarioserieid = A13UsuarioSerieId;
         return  ;
      }

      public void RowToVars4( SdtUsuarioSerie obj4 ,
                              int forceLoad )
      {
         Gx_mode = obj4.gxTpr_Mode;
         A11UsuarioId = obj4.gxTpr_Usuarioid;
         A1SerieId = obj4.gxTpr_Serieid;
         A2SerieNome = obj4.gxTpr_Serienome;
         A43SerieImagem = obj4.gxTpr_Serieimagem;
         A40000SerieImagem_GXI = obj4.gxTpr_Serieimagem_gxi;
         A49GeneroNome = obj4.gxTpr_Generonome;
         A14UsuarioSerieNota = obj4.gxTpr_Usuarioserienota;
         A15UsuarioSerieAssistida = obj4.gxTpr_Usuarioserieassistida;
         A16UsuarioSerieComentario = obj4.gxTpr_Usuarioseriecomentario;
         A17UsuarioSerieFavorita = obj4.gxTpr_Usuarioseriefavorita;
         A13UsuarioSerieId = obj4.gxTpr_Usuarioserieid;
         Z13UsuarioSerieId = obj4.gxTpr_Usuarioserieid_Z;
         Z11UsuarioId = obj4.gxTpr_Usuarioid_Z;
         Z1SerieId = obj4.gxTpr_Serieid_Z;
         Z2SerieNome = obj4.gxTpr_Serienome_Z;
         Z49GeneroNome = obj4.gxTpr_Generonome_Z;
         Z14UsuarioSerieNota = obj4.gxTpr_Usuarioserienota_Z;
         Z15UsuarioSerieAssistida = obj4.gxTpr_Usuarioserieassistida_Z;
         Z16UsuarioSerieComentario = obj4.gxTpr_Usuarioseriecomentario_Z;
         Z17UsuarioSerieFavorita = obj4.gxTpr_Usuarioseriefavorita_Z;
         Z40000SerieImagem_GXI = obj4.gxTpr_Serieimagem_gxi_Z;
         Gx_mode = obj4.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A13UsuarioSerieId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey044( ) ;
         ScanKeyStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z13UsuarioSerieId = A13UsuarioSerieId;
         }
         ZM044( -1) ;
         OnLoadActions044( ) ;
         AddRow044( ) ;
         ScanKeyEnd044( ) ;
         if ( RcdFound4 == 0 )
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
         RowToVars4( bcUsuarioSerie, 0) ;
         ScanKeyStart044( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z13UsuarioSerieId = A13UsuarioSerieId;
         }
         ZM044( -1) ;
         OnLoadActions044( ) ;
         AddRow044( ) ;
         ScanKeyEnd044( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey044( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert044( ) ;
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A13UsuarioSerieId != Z13UsuarioSerieId )
               {
                  A13UsuarioSerieId = Z13UsuarioSerieId;
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
                  Update044( ) ;
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
                  if ( A13UsuarioSerieId != Z13UsuarioSerieId )
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
                        Insert044( ) ;
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
                        Insert044( ) ;
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
         RowToVars4( bcUsuarioSerie, 0) ;
         SaveImpl( ) ;
         VarsToRow4( bcUsuarioSerie) ;
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
         RowToVars4( bcUsuarioSerie, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert044( ) ;
         AfterTrn( ) ;
         VarsToRow4( bcUsuarioSerie) ;
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
            SdtUsuarioSerie auxBC = new SdtUsuarioSerie(context) ;
            auxBC.Load(A13UsuarioSerieId);
            auxBC.UpdateDirties(bcUsuarioSerie);
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
         RowToVars4( bcUsuarioSerie, 0) ;
         UpdateImpl( ) ;
         VarsToRow4( bcUsuarioSerie) ;
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
         RowToVars4( bcUsuarioSerie, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert044( ) ;
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
         VarsToRow4( bcUsuarioSerie) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars4( bcUsuarioSerie, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey044( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A13UsuarioSerieId != Z13UsuarioSerieId )
            {
               A13UsuarioSerieId = Z13UsuarioSerieId;
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
            if ( A13UsuarioSerieId != Z13UsuarioSerieId )
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
         pr_default.close(11);
         pr_default.close(12);
         pr_gam.rollback( "UsuarioSerie_BC");
         pr_default.rollback( "UsuarioSerie_BC");
         VarsToRow4( bcUsuarioSerie) ;
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
         Gx_mode = bcUsuarioSerie.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcUsuarioSerie.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcUsuarioSerie )
         {
            bcUsuarioSerie = (SdtUsuarioSerie)(sdt);
            if ( StringUtil.StrCmp(bcUsuarioSerie.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioSerie.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow4( bcUsuarioSerie) ;
            }
            else
            {
               RowToVars4( bcUsuarioSerie, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcUsuarioSerie.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioSerie.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars4( bcUsuarioSerie, 1) ;
         return  ;
      }

      public SdtUsuarioSerie UsuarioSerie_BC
      {
         get {
            return bcUsuarioSerie ;
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
         pr_default.close(11);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00047_A48GeneroId = new long[1] ;
         BC00047_A13UsuarioSerieId = new long[1] ;
         BC00047_A2SerieNome = new String[] {""} ;
         BC00047_A40000SerieImagem_GXI = new String[] {""} ;
         BC00047_A49GeneroNome = new String[] {""} ;
         BC00047_A14UsuarioSerieNota = new short[1] ;
         BC00047_A15UsuarioSerieAssistida = new bool[] {false} ;
         BC00047_A16UsuarioSerieComentario = new String[] {""} ;
         BC00047_A17UsuarioSerieFavorita = new bool[] {false} ;
         BC00047_A11UsuarioId = new long[1] ;
         BC00047_A1SerieId = new long[1] ;
         BC00047_A43SerieImagem = new String[] {""} ;
         A2SerieNome = "";
         A40000SerieImagem_GXI = "";
         A49GeneroNome = "";
         A16UsuarioSerieComentario = "";
         A43SerieImagem = "";
         gx_restcollection = new GXBCCollection<SdtUsuarioSerie>( context, "UsuarioSerie", "SeriesColaborativas");
         sMode4 = "";
         Gx_mode = "";
         Z16UsuarioSerieComentario = "";
         Z2SerieNome = "";
         Z49GeneroNome = "";
         Z43SerieImagem = "";
         Z40000SerieImagem_GXI = "";
         BC00048_A48GeneroId = new long[1] ;
         BC00048_A13UsuarioSerieId = new long[1] ;
         BC00048_A2SerieNome = new String[] {""} ;
         BC00048_A40000SerieImagem_GXI = new String[] {""} ;
         BC00048_A49GeneroNome = new String[] {""} ;
         BC00048_A14UsuarioSerieNota = new short[1] ;
         BC00048_A15UsuarioSerieAssistida = new bool[] {false} ;
         BC00048_A16UsuarioSerieComentario = new String[] {""} ;
         BC00048_A17UsuarioSerieFavorita = new bool[] {false} ;
         BC00048_A11UsuarioId = new long[1] ;
         BC00048_A1SerieId = new long[1] ;
         BC00048_A43SerieImagem = new String[] {""} ;
         BC00044_A11UsuarioId = new long[1] ;
         BC00045_A48GeneroId = new long[1] ;
         BC00045_A2SerieNome = new String[] {""} ;
         BC00045_A40000SerieImagem_GXI = new String[] {""} ;
         BC00045_A43SerieImagem = new String[] {""} ;
         BC00046_A49GeneroNome = new String[] {""} ;
         BC00049_A13UsuarioSerieId = new long[1] ;
         BC00043_A13UsuarioSerieId = new long[1] ;
         BC00043_A14UsuarioSerieNota = new short[1] ;
         BC00043_A15UsuarioSerieAssistida = new bool[] {false} ;
         BC00043_A16UsuarioSerieComentario = new String[] {""} ;
         BC00043_A17UsuarioSerieFavorita = new bool[] {false} ;
         BC00043_A11UsuarioId = new long[1] ;
         BC00043_A1SerieId = new long[1] ;
         BC00042_A13UsuarioSerieId = new long[1] ;
         BC00042_A14UsuarioSerieNota = new short[1] ;
         BC00042_A15UsuarioSerieAssistida = new bool[] {false} ;
         BC00042_A16UsuarioSerieComentario = new String[] {""} ;
         BC00042_A17UsuarioSerieFavorita = new bool[] {false} ;
         BC00042_A11UsuarioId = new long[1] ;
         BC00042_A1SerieId = new long[1] ;
         BC000410_A13UsuarioSerieId = new long[1] ;
         BC000413_A48GeneroId = new long[1] ;
         BC000413_A2SerieNome = new String[] {""} ;
         BC000413_A40000SerieImagem_GXI = new String[] {""} ;
         BC000413_A43SerieImagem = new String[] {""} ;
         BC000414_A49GeneroNome = new String[] {""} ;
         BC000415_A48GeneroId = new long[1] ;
         BC000415_A13UsuarioSerieId = new long[1] ;
         BC000415_A2SerieNome = new String[] {""} ;
         BC000415_A40000SerieImagem_GXI = new String[] {""} ;
         BC000415_A49GeneroNome = new String[] {""} ;
         BC000415_A14UsuarioSerieNota = new short[1] ;
         BC000415_A15UsuarioSerieAssistida = new bool[] {false} ;
         BC000415_A16UsuarioSerieComentario = new String[] {""} ;
         BC000415_A17UsuarioSerieFavorita = new bool[] {false} ;
         BC000415_A11UsuarioId = new long[1] ;
         BC000415_A1SerieId = new long[1] ;
         BC000415_A43SerieImagem = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioserie_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioserie_bc__default(),
            new Object[][] {
                new Object[] {
               BC00042_A13UsuarioSerieId, BC00042_A14UsuarioSerieNota, BC00042_A15UsuarioSerieAssistida, BC00042_A16UsuarioSerieComentario, BC00042_A17UsuarioSerieFavorita, BC00042_A11UsuarioId, BC00042_A1SerieId
               }
               , new Object[] {
               BC00043_A13UsuarioSerieId, BC00043_A14UsuarioSerieNota, BC00043_A15UsuarioSerieAssistida, BC00043_A16UsuarioSerieComentario, BC00043_A17UsuarioSerieFavorita, BC00043_A11UsuarioId, BC00043_A1SerieId
               }
               , new Object[] {
               BC00044_A11UsuarioId
               }
               , new Object[] {
               BC00045_A48GeneroId, BC00045_A2SerieNome, BC00045_A40000SerieImagem_GXI, BC00045_A43SerieImagem
               }
               , new Object[] {
               BC00046_A49GeneroNome
               }
               , new Object[] {
               BC00047_A48GeneroId, BC00047_A13UsuarioSerieId, BC00047_A2SerieNome, BC00047_A40000SerieImagem_GXI, BC00047_A49GeneroNome, BC00047_A14UsuarioSerieNota, BC00047_A15UsuarioSerieAssistida, BC00047_A16UsuarioSerieComentario, BC00047_A17UsuarioSerieFavorita, BC00047_A11UsuarioId,
               BC00047_A1SerieId, BC00047_A43SerieImagem
               }
               , new Object[] {
               BC00048_A48GeneroId, BC00048_A13UsuarioSerieId, BC00048_A2SerieNome, BC00048_A40000SerieImagem_GXI, BC00048_A49GeneroNome, BC00048_A14UsuarioSerieNota, BC00048_A15UsuarioSerieAssistida, BC00048_A16UsuarioSerieComentario, BC00048_A17UsuarioSerieFavorita, BC00048_A11UsuarioId,
               BC00048_A1SerieId, BC00048_A43SerieImagem
               }
               , new Object[] {
               BC00049_A13UsuarioSerieId
               }
               , new Object[] {
               BC000410_A13UsuarioSerieId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000413_A48GeneroId, BC000413_A2SerieNome, BC000413_A40000SerieImagem_GXI, BC000413_A43SerieImagem
               }
               , new Object[] {
               BC000414_A49GeneroNome
               }
               , new Object[] {
               BC000415_A48GeneroId, BC000415_A13UsuarioSerieId, BC000415_A2SerieNome, BC000415_A40000SerieImagem_GXI, BC000415_A49GeneroNome, BC000415_A14UsuarioSerieNota, BC000415_A15UsuarioSerieAssistida, BC000415_A16UsuarioSerieComentario, BC000415_A17UsuarioSerieFavorita, BC000415_A11UsuarioId,
               BC000415_A1SerieId, BC000415_A43SerieImagem
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound4 ;
      private short A14UsuarioSerieNota ;
      private short GX_JID ;
      private short Z14UsuarioSerieNota ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom4 ;
      private int GXPagingTo4 ;
      private long A48GeneroId ;
      private long A13UsuarioSerieId ;
      private long A11UsuarioId ;
      private long A1SerieId ;
      private long Z13UsuarioSerieId ;
      private long Z11UsuarioId ;
      private long Z1SerieId ;
      private long Z48GeneroId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode4 ;
      private String Gx_mode ;
      private bool A15UsuarioSerieAssistida ;
      private bool A17UsuarioSerieFavorita ;
      private bool Z15UsuarioSerieAssistida ;
      private bool Z17UsuarioSerieFavorita ;
      private bool Gx_longc ;
      private String A2SerieNome ;
      private String A40000SerieImagem_GXI ;
      private String A49GeneroNome ;
      private String A16UsuarioSerieComentario ;
      private String Z16UsuarioSerieComentario ;
      private String Z2SerieNome ;
      private String Z49GeneroNome ;
      private String Z40000SerieImagem_GXI ;
      private String A43SerieImagem ;
      private String Z43SerieImagem ;
      private GXBCCollection<SdtUsuarioSerie> gx_restcollection ;
      private SdtUsuarioSerie bcUsuarioSerie ;
      private SdtUsuarioSerie gx_sdt_item ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00047_A48GeneroId ;
      private long[] BC00047_A13UsuarioSerieId ;
      private String[] BC00047_A2SerieNome ;
      private String[] BC00047_A40000SerieImagem_GXI ;
      private String[] BC00047_A49GeneroNome ;
      private short[] BC00047_A14UsuarioSerieNota ;
      private bool[] BC00047_A15UsuarioSerieAssistida ;
      private String[] BC00047_A16UsuarioSerieComentario ;
      private bool[] BC00047_A17UsuarioSerieFavorita ;
      private long[] BC00047_A11UsuarioId ;
      private long[] BC00047_A1SerieId ;
      private String[] BC00047_A43SerieImagem ;
      private long[] BC00048_A48GeneroId ;
      private long[] BC00048_A13UsuarioSerieId ;
      private String[] BC00048_A2SerieNome ;
      private String[] BC00048_A40000SerieImagem_GXI ;
      private String[] BC00048_A49GeneroNome ;
      private short[] BC00048_A14UsuarioSerieNota ;
      private bool[] BC00048_A15UsuarioSerieAssistida ;
      private String[] BC00048_A16UsuarioSerieComentario ;
      private bool[] BC00048_A17UsuarioSerieFavorita ;
      private long[] BC00048_A11UsuarioId ;
      private long[] BC00048_A1SerieId ;
      private String[] BC00048_A43SerieImagem ;
      private long[] BC00044_A11UsuarioId ;
      private long[] BC00045_A48GeneroId ;
      private String[] BC00045_A2SerieNome ;
      private String[] BC00045_A40000SerieImagem_GXI ;
      private String[] BC00045_A43SerieImagem ;
      private String[] BC00046_A49GeneroNome ;
      private long[] BC00049_A13UsuarioSerieId ;
      private long[] BC00043_A13UsuarioSerieId ;
      private short[] BC00043_A14UsuarioSerieNota ;
      private bool[] BC00043_A15UsuarioSerieAssistida ;
      private String[] BC00043_A16UsuarioSerieComentario ;
      private bool[] BC00043_A17UsuarioSerieFavorita ;
      private long[] BC00043_A11UsuarioId ;
      private long[] BC00043_A1SerieId ;
      private long[] BC00042_A13UsuarioSerieId ;
      private short[] BC00042_A14UsuarioSerieNota ;
      private bool[] BC00042_A15UsuarioSerieAssistida ;
      private String[] BC00042_A16UsuarioSerieComentario ;
      private bool[] BC00042_A17UsuarioSerieFavorita ;
      private long[] BC00042_A11UsuarioId ;
      private long[] BC00042_A1SerieId ;
      private long[] BC000410_A13UsuarioSerieId ;
      private long[] BC000413_A48GeneroId ;
      private String[] BC000413_A2SerieNome ;
      private String[] BC000413_A40000SerieImagem_GXI ;
      private String[] BC000413_A43SerieImagem ;
      private String[] BC000414_A49GeneroNome ;
      private long[] BC000415_A48GeneroId ;
      private long[] BC000415_A13UsuarioSerieId ;
      private String[] BC000415_A2SerieNome ;
      private String[] BC000415_A40000SerieImagem_GXI ;
      private String[] BC000415_A49GeneroNome ;
      private short[] BC000415_A14UsuarioSerieNota ;
      private bool[] BC000415_A15UsuarioSerieAssistida ;
      private String[] BC000415_A16UsuarioSerieComentario ;
      private bool[] BC000415_A17UsuarioSerieFavorita ;
      private long[] BC000415_A11UsuarioId ;
      private long[] BC000415_A1SerieId ;
      private String[] BC000415_A43SerieImagem ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
   }

   public class usuarioserie_bc__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioserie_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00047 ;
        prmBC00047 = new Object[] {
        new Object[] {"@GXPagingFrom4",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo4",SqlDbType.Int,9,0}
        } ;
        Object[] prmBC00048 ;
        prmBC00048 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00044 ;
        prmBC00044 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00045 ;
        prmBC00045 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00046 ;
        prmBC00046 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00049 ;
        prmBC00049 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00043 ;
        prmBC00043 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00042 ;
        prmBC00042 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000410 ;
        prmBC000410 = new Object[] {
        new Object[] {"@UsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioSerieComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioSerieFavorita",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000411 ;
        prmBC000411 = new Object[] {
        new Object[] {"@UsuarioSerieNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioSerieAssistida",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioSerieComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioSerieFavorita",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000412 ;
        prmBC000412 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000413 ;
        prmBC000413 = new Object[] {
        new Object[] {"@SerieId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000414 ;
        prmBC000414 = new Object[] {
        new Object[] {"@GeneroId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000415 ;
        prmBC000415 = new Object[] {
        new Object[] {"@UsuarioSerieId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00042", "SELECT [UsuarioSerieId], [UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId] FROM [UsuarioSerie] WITH (UPDLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00042,1,0,true,false )
           ,new CursorDef("BC00043", "SELECT [UsuarioSerieId], [UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00043,1,0,true,false )
           ,new CursorDef("BC00044", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00044,1,0,true,false )
           ,new CursorDef("BC00045", "SELECT [GeneroId], [SerieNome], [SerieImagem_GXI], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00045,1,0,true,false )
           ,new CursorDef("BC00046", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00046,1,0,true,false )
           ,new CursorDef("BC00047", "SELECT T2.[GeneroId], TM1.[UsuarioSerieId], T2.[SerieNome], T2.[SerieImagem_GXI], T3.[GeneroNome], TM1.[UsuarioSerieNota], TM1.[UsuarioSerieAssistida], TM1.[UsuarioSerieComentario], TM1.[UsuarioSerieFavorita], TM1.[UsuarioId], TM1.[SerieId], T2.[SerieImagem] FROM (([UsuarioSerie] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) ORDER BY TM1.[UsuarioSerieId]  OFFSET @GXPagingFrom4 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo4 > 0 THEN @GXPagingTo4 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00047,100,0,true,false )
           ,new CursorDef("BC00048", "SELECT T2.[GeneroId], TM1.[UsuarioSerieId], T2.[SerieNome], T2.[SerieImagem_GXI], T3.[GeneroNome], TM1.[UsuarioSerieNota], TM1.[UsuarioSerieAssistida], TM1.[UsuarioSerieComentario], TM1.[UsuarioSerieFavorita], TM1.[UsuarioId], TM1.[SerieId], T2.[SerieImagem] FROM (([UsuarioSerie] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) WHERE TM1.[UsuarioSerieId] = @UsuarioSerieId ORDER BY TM1.[UsuarioSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00048,100,0,true,false )
           ,new CursorDef("BC00049", "SELECT [UsuarioSerieId] FROM [UsuarioSerie] WITH (NOLOCK) WHERE [UsuarioSerieId] = @UsuarioSerieId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00049,1,0,true,false )
           ,new CursorDef("BC000410", "INSERT INTO [UsuarioSerie]([UsuarioSerieNota], [UsuarioSerieAssistida], [UsuarioSerieComentario], [UsuarioSerieFavorita], [UsuarioId], [SerieId]) VALUES(@UsuarioSerieNota, @UsuarioSerieAssistida, @UsuarioSerieComentario, @UsuarioSerieFavorita, @UsuarioId, @SerieId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000410)
           ,new CursorDef("BC000411", "UPDATE [UsuarioSerie] SET [UsuarioSerieNota]=@UsuarioSerieNota, [UsuarioSerieAssistida]=@UsuarioSerieAssistida, [UsuarioSerieComentario]=@UsuarioSerieComentario, [UsuarioSerieFavorita]=@UsuarioSerieFavorita, [UsuarioId]=@UsuarioId, [SerieId]=@SerieId  WHERE [UsuarioSerieId] = @UsuarioSerieId", GxErrorMask.GX_NOMASK,prmBC000411)
           ,new CursorDef("BC000412", "DELETE FROM [UsuarioSerie]  WHERE [UsuarioSerieId] = @UsuarioSerieId", GxErrorMask.GX_NOMASK,prmBC000412)
           ,new CursorDef("BC000413", "SELECT [GeneroId], [SerieNome], [SerieImagem_GXI], [SerieImagem] FROM [Serie] WITH (NOLOCK) WHERE [SerieId] = @SerieId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000413,1,0,true,false )
           ,new CursorDef("BC000414", "SELECT [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @GeneroId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000414,1,0,true,false )
           ,new CursorDef("BC000415", "SELECT T2.[GeneroId], TM1.[UsuarioSerieId], T2.[SerieNome], T2.[SerieImagem_GXI], T3.[GeneroNome], TM1.[UsuarioSerieNota], TM1.[UsuarioSerieAssistida], TM1.[UsuarioSerieComentario], TM1.[UsuarioSerieFavorita], TM1.[UsuarioId], TM1.[SerieId], T2.[SerieImagem] FROM (([UsuarioSerie] TM1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = TM1.[SerieId]) INNER JOIN [Genero] T3 WITH (NOLOCK) ON T3.[GeneroId] = T2.[GeneroId]) WHERE TM1.[UsuarioSerieId] = @UsuarioSerieId ORDER BY TM1.[UsuarioSerieId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000415,100,0,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((long[]) buf[9])[0] = rslt.getLong(10) ;
              ((long[]) buf[10])[0] = rslt.getLong(11) ;
              ((String[]) buf[11])[0] = rslt.getMultimediaFile(12, rslt.getVarchar(4)) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((long[]) buf[9])[0] = rslt.getLong(10) ;
              ((long[]) buf[10])[0] = rslt.getLong(11) ;
              ((String[]) buf[11])[0] = rslt.getMultimediaFile(12, rslt.getVarchar(4)) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((short[]) buf[5])[0] = rslt.getShort(6) ;
              ((bool[]) buf[6])[0] = rslt.getBool(7) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[8])[0] = rslt.getBool(9) ;
              ((long[]) buf[9])[0] = rslt.getLong(10) ;
              ((long[]) buf[10])[0] = rslt.getLong(11) ;
              ((String[]) buf[11])[0] = rslt.getMultimediaFile(12, rslt.getVarchar(4)) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (int)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
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
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.usuarioserie_bc_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class usuarioserie_bc_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "GET" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA13UsuarioSerieId}")]
   public SdtUsuarioSerie_RESTInterface Load( string sA13UsuarioSerieId )
   {
      try
      {
         long A13UsuarioSerieId ;
         A13UsuarioSerieId = (long)(NumberUtil.Val( (String)(sA13UsuarioSerieId), "."));
         SdtUsuarioSerie worker = new SdtUsuarioSerie(context) ;
         SdtUsuarioSerie_RESTInterface worker_interface = new SdtUsuarioSerie_RESTInterface (worker);
         if ( StringUtil.StrCmp(sA13UsuarioSerieId, "_default") == 0 )
         {
            IGxSilentTrn workertrn = worker.getTransaction() ;
            workertrn.GetInsDefault();
         }
         else
         {
            worker.Load(A13UsuarioSerieId);
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
   	UriTemplate = "/{sA13UsuarioSerieId}")]
   public SdtUsuarioSerie_RESTInterface Delete( string sA13UsuarioSerieId )
   {
      try
      {
         long A13UsuarioSerieId ;
         A13UsuarioSerieId = (long)(NumberUtil.Val( (String)(sA13UsuarioSerieId), "."));
         SdtUsuarioSerie worker = new SdtUsuarioSerie(context) ;
         SdtUsuarioSerie_RESTInterface worker_interface = new SdtUsuarioSerie_RESTInterface (worker);
         worker.Load(A13UsuarioSerieId);
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
   	UriTemplate = "/{sA13UsuarioSerieId}")]
   public SdtUsuarioSerie_RESTInterface Insert( string sA13UsuarioSerieId ,
                                                SdtUsuarioSerie_RESTInterface entity )
   {
      try
      {
         long A13UsuarioSerieId ;
         A13UsuarioSerieId = (long)(NumberUtil.Val( (String)(sA13UsuarioSerieId), "."));
         SdtUsuarioSerie worker = new SdtUsuarioSerie(context) ;
         bool gxcheck = RestParameter("check", "true") ;
         bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
         SdtUsuarioSerie_RESTInterface worker_interface = new SdtUsuarioSerie_RESTInterface (worker);
         worker_interface.CopyFrom(entity);
         worker.gxTpr_Usuarioserieid = A13UsuarioSerieId;
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
   	UriTemplate = "/{sA13UsuarioSerieId}")]
   public SdtUsuarioSerie_RESTInterface Update( string sA13UsuarioSerieId ,
                                                SdtUsuarioSerie_RESTInterface entity )
   {
      try
      {
         long A13UsuarioSerieId ;
         A13UsuarioSerieId = (long)(NumberUtil.Val( (String)(sA13UsuarioSerieId), "."));
         SdtUsuarioSerie worker = new SdtUsuarioSerie(context) ;
         SdtUsuarioSerie_RESTInterface worker_interface = new SdtUsuarioSerie_RESTInterface (worker);
         bool gxcheck = RestParameter("check", "true") ;
         worker.Load(A13UsuarioSerieId);
         if (entity.Hash == worker_interface.Hash) {
            worker_interface.CopyFrom(entity);
            worker.gxTpr_Usuarioserieid = A13UsuarioSerieId;
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
            SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioSerie"}) );
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
