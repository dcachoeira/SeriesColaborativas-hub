/*
               File: UsuarioEpisodio_BC
        Description: Usuário episódio
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:39:18.29
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class usuarioepisodio_bc : GXHttpHandler, IGxSilentTrn
   {
      public usuarioepisodio_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioepisodio_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow055( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey055( ) ;
         standaloneModal( ) ;
         AddRow055( ) ;
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
               Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls055( ) ;
            }
            else
            {
               CheckExtendedTable055( ) ;
               if ( AnyError == 0 )
               {
                  ZM055( 2) ;
                  ZM055( 3) ;
               }
               CloseExtendedTableCursors055( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM055( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z19UsuarioEpisodioNota = A19UsuarioEpisodioNota;
            Z20UsuarioEpisodioAssistido = A20UsuarioEpisodioAssistido;
            Z21UsuarioEpisodioComentario = A21UsuarioEpisodioComentario;
            Z22UsuarioEpisodioFavorito = A22UsuarioEpisodioFavorito;
            Z11UsuarioId = A11UsuarioId;
            Z7EpisodioId = A7EpisodioId;
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
            Z19UsuarioEpisodioNota = A19UsuarioEpisodioNota;
            Z20UsuarioEpisodioAssistido = A20UsuarioEpisodioAssistido;
            Z21UsuarioEpisodioComentario = A21UsuarioEpisodioComentario;
            Z22UsuarioEpisodioFavorito = A22UsuarioEpisodioFavorito;
            Z11UsuarioId = A11UsuarioId;
            Z7EpisodioId = A7EpisodioId;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load055( )
      {
         /* Using cursor BC00056 */
         pr_default.execute(4, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound5 = 1;
            A19UsuarioEpisodioNota = BC00056_A19UsuarioEpisodioNota[0];
            A20UsuarioEpisodioAssistido = BC00056_A20UsuarioEpisodioAssistido[0];
            A21UsuarioEpisodioComentario = BC00056_A21UsuarioEpisodioComentario[0];
            A22UsuarioEpisodioFavorito = BC00056_A22UsuarioEpisodioFavorito[0];
            A11UsuarioId = BC00056_A11UsuarioId[0];
            A7EpisodioId = BC00056_A7EpisodioId[0];
            ZM055( -1) ;
         }
         pr_default.close(4);
         OnLoadActions055( ) ;
      }

      protected void OnLoadActions055( )
      {
      }

      protected void CheckExtendedTable055( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00054 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
         }
         pr_default.close(2);
         /* Using cursor BC00055 */
         pr_default.execute(3, new Object[] {A7EpisodioId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Episódio'.", "ForeignKeyNotFound", 1, "EPISODIOID");
            AnyError = 1;
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors055( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey055( )
      {
         /* Using cursor BC00057 */
         pr_default.execute(5, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00053 */
         pr_default.execute(1, new Object[] {A18UsuarioEpisodioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM055( 1) ;
            RcdFound5 = 1;
            A18UsuarioEpisodioId = BC00053_A18UsuarioEpisodioId[0];
            A19UsuarioEpisodioNota = BC00053_A19UsuarioEpisodioNota[0];
            A20UsuarioEpisodioAssistido = BC00053_A20UsuarioEpisodioAssistido[0];
            A21UsuarioEpisodioComentario = BC00053_A21UsuarioEpisodioComentario[0];
            A22UsuarioEpisodioFavorito = BC00053_A22UsuarioEpisodioFavorito[0];
            A11UsuarioId = BC00053_A11UsuarioId[0];
            A7EpisodioId = BC00053_A7EpisodioId[0];
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load055( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey055( ) ;
            }
            Gx_mode = sMode5;
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey055( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode5;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey055( ) ;
         if ( RcdFound5 == 0 )
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
         CONFIRM_050( ) ;
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

      protected void CheckOptimisticConcurrency055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00052 */
            pr_default.execute(0, new Object[] {A18UsuarioEpisodioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioEpisodio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z19UsuarioEpisodioNota != BC00052_A19UsuarioEpisodioNota[0] ) || ( Z20UsuarioEpisodioAssistido != BC00052_A20UsuarioEpisodioAssistido[0] ) || ( StringUtil.StrCmp(Z21UsuarioEpisodioComentario, BC00052_A21UsuarioEpisodioComentario[0]) != 0 ) || ( Z22UsuarioEpisodioFavorito != BC00052_A22UsuarioEpisodioFavorito[0] ) || ( Z11UsuarioId != BC00052_A11UsuarioId[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z7EpisodioId != BC00052_A7EpisodioId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioEpisodio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM055( 0) ;
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00058 */
                     pr_default.execute(6, new Object[] {A19UsuarioEpisodioNota, A20UsuarioEpisodioAssistido, A21UsuarioEpisodioComentario, A22UsuarioEpisodioFavorito, A11UsuarioId, A7EpisodioId});
                     A18UsuarioEpisodioId = BC00058_A18UsuarioEpisodioId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
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
               Load055( ) ;
            }
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void Update055( )
      {
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable055( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm055( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate055( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00059 */
                     pr_default.execute(7, new Object[] {A19UsuarioEpisodioNota, A20UsuarioEpisodioAssistido, A21UsuarioEpisodioComentario, A22UsuarioEpisodioFavorito, A11UsuarioId, A7EpisodioId, A18UsuarioEpisodioId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioEpisodio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate055( ) ;
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
            EndLevel055( ) ;
         }
         CloseExtendedTableCursors055( ) ;
      }

      protected void DeferredUpdate055( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate055( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency055( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls055( ) ;
            AfterConfirm055( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete055( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000510 */
                  pr_default.execute(8, new Object[] {A18UsuarioEpisodioId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioEpisodio") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel055( ) ;
         Gx_mode = sMode5;
      }

      protected void OnDeleteControls055( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel055( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete055( ) ;
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

      public void ScanKeyStart055( )
      {
         /* Using cursor BC000511 */
         pr_default.execute(9, new Object[] {A18UsuarioEpisodioId});
         RcdFound5 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A18UsuarioEpisodioId = BC000511_A18UsuarioEpisodioId[0];
            A19UsuarioEpisodioNota = BC000511_A19UsuarioEpisodioNota[0];
            A20UsuarioEpisodioAssistido = BC000511_A20UsuarioEpisodioAssistido[0];
            A21UsuarioEpisodioComentario = BC000511_A21UsuarioEpisodioComentario[0];
            A22UsuarioEpisodioFavorito = BC000511_A22UsuarioEpisodioFavorito[0];
            A11UsuarioId = BC000511_A11UsuarioId[0];
            A7EpisodioId = BC000511_A7EpisodioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext055( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound5 = 0;
         ScanKeyLoad055( ) ;
      }

      protected void ScanKeyLoad055( )
      {
         sMode5 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A18UsuarioEpisodioId = BC000511_A18UsuarioEpisodioId[0];
            A19UsuarioEpisodioNota = BC000511_A19UsuarioEpisodioNota[0];
            A20UsuarioEpisodioAssistido = BC000511_A20UsuarioEpisodioAssistido[0];
            A21UsuarioEpisodioComentario = BC000511_A21UsuarioEpisodioComentario[0];
            A22UsuarioEpisodioFavorito = BC000511_A22UsuarioEpisodioFavorito[0];
            A11UsuarioId = BC000511_A11UsuarioId[0];
            A7EpisodioId = BC000511_A7EpisodioId[0];
         }
         Gx_mode = sMode5;
      }

      protected void ScanKeyEnd055( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm055( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert055( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate055( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete055( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete055( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate055( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes055( )
      {
      }

      protected void send_integrity_lvl_hashes055( )
      {
      }

      protected void AddRow055( )
      {
         VarsToRow5( bcUsuarioEpisodio) ;
      }

      protected void ReadRow055( )
      {
         RowToVars5( bcUsuarioEpisodio, 1) ;
      }

      protected void InitializeNonKey055( )
      {
         A11UsuarioId = 0;
         A7EpisodioId = 0;
         A19UsuarioEpisodioNota = 0;
         A20UsuarioEpisodioAssistido = false;
         A21UsuarioEpisodioComentario = "";
         A22UsuarioEpisodioFavorito = false;
         Z19UsuarioEpisodioNota = 0;
         Z20UsuarioEpisodioAssistido = false;
         Z21UsuarioEpisodioComentario = "";
         Z22UsuarioEpisodioFavorito = false;
         Z11UsuarioId = 0;
         Z7EpisodioId = 0;
      }

      protected void InitAll055( )
      {
         A18UsuarioEpisodioId = 0;
         InitializeNonKey055( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow5( SdtUsuarioEpisodio obj5 )
      {
         obj5.gxTpr_Mode = Gx_mode;
         obj5.gxTpr_Usuarioid = A11UsuarioId;
         obj5.gxTpr_Episodioid = A7EpisodioId;
         obj5.gxTpr_Usuarioepisodionota = A19UsuarioEpisodioNota;
         obj5.gxTpr_Usuarioepisodioassistido = A20UsuarioEpisodioAssistido;
         obj5.gxTpr_Usuarioepisodiocomentario = A21UsuarioEpisodioComentario;
         obj5.gxTpr_Usuarioepisodiofavorito = A22UsuarioEpisodioFavorito;
         obj5.gxTpr_Usuarioepisodioid = A18UsuarioEpisodioId;
         obj5.gxTpr_Usuarioepisodioid_Z = Z18UsuarioEpisodioId;
         obj5.gxTpr_Usuarioid_Z = Z11UsuarioId;
         obj5.gxTpr_Episodioid_Z = Z7EpisodioId;
         obj5.gxTpr_Usuarioepisodionota_Z = Z19UsuarioEpisodioNota;
         obj5.gxTpr_Usuarioepisodioassistido_Z = Z20UsuarioEpisodioAssistido;
         obj5.gxTpr_Usuarioepisodiocomentario_Z = Z21UsuarioEpisodioComentario;
         obj5.gxTpr_Usuarioepisodiofavorito_Z = Z22UsuarioEpisodioFavorito;
         obj5.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow5( SdtUsuarioEpisodio obj5 )
      {
         obj5.gxTpr_Usuarioepisodioid = A18UsuarioEpisodioId;
         return  ;
      }

      public void RowToVars5( SdtUsuarioEpisodio obj5 ,
                              int forceLoad )
      {
         Gx_mode = obj5.gxTpr_Mode;
         A11UsuarioId = obj5.gxTpr_Usuarioid;
         A7EpisodioId = obj5.gxTpr_Episodioid;
         A19UsuarioEpisodioNota = obj5.gxTpr_Usuarioepisodionota;
         A20UsuarioEpisodioAssistido = obj5.gxTpr_Usuarioepisodioassistido;
         A21UsuarioEpisodioComentario = obj5.gxTpr_Usuarioepisodiocomentario;
         A22UsuarioEpisodioFavorito = obj5.gxTpr_Usuarioepisodiofavorito;
         A18UsuarioEpisodioId = obj5.gxTpr_Usuarioepisodioid;
         Z18UsuarioEpisodioId = obj5.gxTpr_Usuarioepisodioid_Z;
         Z11UsuarioId = obj5.gxTpr_Usuarioid_Z;
         Z7EpisodioId = obj5.gxTpr_Episodioid_Z;
         Z19UsuarioEpisodioNota = obj5.gxTpr_Usuarioepisodionota_Z;
         Z20UsuarioEpisodioAssistido = obj5.gxTpr_Usuarioepisodioassistido_Z;
         Z21UsuarioEpisodioComentario = obj5.gxTpr_Usuarioepisodiocomentario_Z;
         Z22UsuarioEpisodioFavorito = obj5.gxTpr_Usuarioepisodiofavorito_Z;
         Gx_mode = obj5.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A18UsuarioEpisodioId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey055( ) ;
         ScanKeyStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
         }
         ZM055( -1) ;
         OnLoadActions055( ) ;
         AddRow055( ) ;
         ScanKeyEnd055( ) ;
         if ( RcdFound5 == 0 )
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
         RowToVars5( bcUsuarioEpisodio, 0) ;
         ScanKeyStart055( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z18UsuarioEpisodioId = A18UsuarioEpisodioId;
         }
         ZM055( -1) ;
         OnLoadActions055( ) ;
         AddRow055( ) ;
         ScanKeyEnd055( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey055( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert055( ) ;
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
               {
                  A18UsuarioEpisodioId = Z18UsuarioEpisodioId;
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
                  Update055( ) ;
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
                  if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
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
                        Insert055( ) ;
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
                        Insert055( ) ;
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
         RowToVars5( bcUsuarioEpisodio, 0) ;
         SaveImpl( ) ;
         VarsToRow5( bcUsuarioEpisodio) ;
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
         RowToVars5( bcUsuarioEpisodio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert055( ) ;
         AfterTrn( ) ;
         VarsToRow5( bcUsuarioEpisodio) ;
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
            SdtUsuarioEpisodio auxBC = new SdtUsuarioEpisodio(context) ;
            auxBC.Load(A18UsuarioEpisodioId);
            auxBC.UpdateDirties(bcUsuarioEpisodio);
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
         RowToVars5( bcUsuarioEpisodio, 0) ;
         UpdateImpl( ) ;
         VarsToRow5( bcUsuarioEpisodio) ;
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
         RowToVars5( bcUsuarioEpisodio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert055( ) ;
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
         VarsToRow5( bcUsuarioEpisodio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars5( bcUsuarioEpisodio, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey055( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
            {
               A18UsuarioEpisodioId = Z18UsuarioEpisodioId;
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
            if ( A18UsuarioEpisodioId != Z18UsuarioEpisodioId )
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
         pr_gam.rollback( "UsuarioEpisodio_BC");
         pr_default.rollback( "UsuarioEpisodio_BC");
         VarsToRow5( bcUsuarioEpisodio) ;
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
         Gx_mode = bcUsuarioEpisodio.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcUsuarioEpisodio.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcUsuarioEpisodio )
         {
            bcUsuarioEpisodio = (SdtUsuarioEpisodio)(sdt);
            if ( StringUtil.StrCmp(bcUsuarioEpisodio.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioEpisodio.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow5( bcUsuarioEpisodio) ;
            }
            else
            {
               RowToVars5( bcUsuarioEpisodio, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcUsuarioEpisodio.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioEpisodio.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars5( bcUsuarioEpisodio, 1) ;
         return  ;
      }

      public SdtUsuarioEpisodio UsuarioEpisodio_BC
      {
         get {
            return bcUsuarioEpisodio ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z21UsuarioEpisodioComentario = "";
         A21UsuarioEpisodioComentario = "";
         BC00056_A18UsuarioEpisodioId = new long[1] ;
         BC00056_A19UsuarioEpisodioNota = new short[1] ;
         BC00056_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         BC00056_A21UsuarioEpisodioComentario = new String[] {""} ;
         BC00056_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         BC00056_A11UsuarioId = new long[1] ;
         BC00056_A7EpisodioId = new long[1] ;
         BC00054_A11UsuarioId = new long[1] ;
         BC00055_A7EpisodioId = new long[1] ;
         BC00057_A18UsuarioEpisodioId = new long[1] ;
         BC00053_A18UsuarioEpisodioId = new long[1] ;
         BC00053_A19UsuarioEpisodioNota = new short[1] ;
         BC00053_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         BC00053_A21UsuarioEpisodioComentario = new String[] {""} ;
         BC00053_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         BC00053_A11UsuarioId = new long[1] ;
         BC00053_A7EpisodioId = new long[1] ;
         sMode5 = "";
         BC00052_A18UsuarioEpisodioId = new long[1] ;
         BC00052_A19UsuarioEpisodioNota = new short[1] ;
         BC00052_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         BC00052_A21UsuarioEpisodioComentario = new String[] {""} ;
         BC00052_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         BC00052_A11UsuarioId = new long[1] ;
         BC00052_A7EpisodioId = new long[1] ;
         BC00058_A18UsuarioEpisodioId = new long[1] ;
         BC000511_A18UsuarioEpisodioId = new long[1] ;
         BC000511_A19UsuarioEpisodioNota = new short[1] ;
         BC000511_A20UsuarioEpisodioAssistido = new bool[] {false} ;
         BC000511_A21UsuarioEpisodioComentario = new String[] {""} ;
         BC000511_A22UsuarioEpisodioFavorito = new bool[] {false} ;
         BC000511_A11UsuarioId = new long[1] ;
         BC000511_A7EpisodioId = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioepisodio_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioepisodio_bc__default(),
            new Object[][] {
                new Object[] {
               BC00052_A18UsuarioEpisodioId, BC00052_A19UsuarioEpisodioNota, BC00052_A20UsuarioEpisodioAssistido, BC00052_A21UsuarioEpisodioComentario, BC00052_A22UsuarioEpisodioFavorito, BC00052_A11UsuarioId, BC00052_A7EpisodioId
               }
               , new Object[] {
               BC00053_A18UsuarioEpisodioId, BC00053_A19UsuarioEpisodioNota, BC00053_A20UsuarioEpisodioAssistido, BC00053_A21UsuarioEpisodioComentario, BC00053_A22UsuarioEpisodioFavorito, BC00053_A11UsuarioId, BC00053_A7EpisodioId
               }
               , new Object[] {
               BC00054_A11UsuarioId
               }
               , new Object[] {
               BC00055_A7EpisodioId
               }
               , new Object[] {
               BC00056_A18UsuarioEpisodioId, BC00056_A19UsuarioEpisodioNota, BC00056_A20UsuarioEpisodioAssistido, BC00056_A21UsuarioEpisodioComentario, BC00056_A22UsuarioEpisodioFavorito, BC00056_A11UsuarioId, BC00056_A7EpisodioId
               }
               , new Object[] {
               BC00057_A18UsuarioEpisodioId
               }
               , new Object[] {
               BC00058_A18UsuarioEpisodioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000511_A18UsuarioEpisodioId, BC000511_A19UsuarioEpisodioNota, BC000511_A20UsuarioEpisodioAssistido, BC000511_A21UsuarioEpisodioComentario, BC000511_A22UsuarioEpisodioFavorito, BC000511_A11UsuarioId, BC000511_A7EpisodioId
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
      private short GX_JID ;
      private short Z19UsuarioEpisodioNota ;
      private short A19UsuarioEpisodioNota ;
      private short RcdFound5 ;
      private int trnEnded ;
      private long Z18UsuarioEpisodioId ;
      private long A18UsuarioEpisodioId ;
      private long Z11UsuarioId ;
      private long A11UsuarioId ;
      private long Z7EpisodioId ;
      private long A7EpisodioId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode5 ;
      private bool Z20UsuarioEpisodioAssistido ;
      private bool A20UsuarioEpisodioAssistido ;
      private bool Z22UsuarioEpisodioFavorito ;
      private bool A22UsuarioEpisodioFavorito ;
      private bool Gx_longc ;
      private String Z21UsuarioEpisodioComentario ;
      private String A21UsuarioEpisodioComentario ;
      private SdtUsuarioEpisodio bcUsuarioEpisodio ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00056_A18UsuarioEpisodioId ;
      private short[] BC00056_A19UsuarioEpisodioNota ;
      private bool[] BC00056_A20UsuarioEpisodioAssistido ;
      private String[] BC00056_A21UsuarioEpisodioComentario ;
      private bool[] BC00056_A22UsuarioEpisodioFavorito ;
      private long[] BC00056_A11UsuarioId ;
      private long[] BC00056_A7EpisodioId ;
      private long[] BC00054_A11UsuarioId ;
      private long[] BC00055_A7EpisodioId ;
      private long[] BC00057_A18UsuarioEpisodioId ;
      private long[] BC00053_A18UsuarioEpisodioId ;
      private short[] BC00053_A19UsuarioEpisodioNota ;
      private bool[] BC00053_A20UsuarioEpisodioAssistido ;
      private String[] BC00053_A21UsuarioEpisodioComentario ;
      private bool[] BC00053_A22UsuarioEpisodioFavorito ;
      private long[] BC00053_A11UsuarioId ;
      private long[] BC00053_A7EpisodioId ;
      private long[] BC00052_A18UsuarioEpisodioId ;
      private short[] BC00052_A19UsuarioEpisodioNota ;
      private bool[] BC00052_A20UsuarioEpisodioAssistido ;
      private String[] BC00052_A21UsuarioEpisodioComentario ;
      private bool[] BC00052_A22UsuarioEpisodioFavorito ;
      private long[] BC00052_A11UsuarioId ;
      private long[] BC00052_A7EpisodioId ;
      private long[] BC00058_A18UsuarioEpisodioId ;
      private long[] BC000511_A18UsuarioEpisodioId ;
      private short[] BC000511_A19UsuarioEpisodioNota ;
      private bool[] BC000511_A20UsuarioEpisodioAssistido ;
      private String[] BC000511_A21UsuarioEpisodioComentario ;
      private bool[] BC000511_A22UsuarioEpisodioFavorito ;
      private long[] BC000511_A11UsuarioId ;
      private long[] BC000511_A7EpisodioId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
   }

   public class usuarioepisodio_bc__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioepisodio_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00056 ;
        prmBC00056 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00054 ;
        prmBC00054 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00055 ;
        prmBC00055 = new Object[] {
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00057 ;
        prmBC00057 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00053 ;
        prmBC00053 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00052 ;
        prmBC00052 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00058 ;
        prmBC00058 = new Object[] {
        new Object[] {"@UsuarioEpisodioNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioEpisodioAssistido",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEpisodioComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioEpisodioFavorito",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00059 ;
        prmBC00059 = new Object[] {
        new Object[] {"@UsuarioEpisodioNota",SqlDbType.SmallInt,1,0} ,
        new Object[] {"@UsuarioEpisodioAssistido",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioEpisodioComentario",SqlDbType.VarChar,300,0} ,
        new Object[] {"@UsuarioEpisodioFavorito",SqlDbType.Bit,4,0} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000510 ;
        prmBC000510 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000511 ;
        prmBC000511 = new Object[] {
        new Object[] {"@UsuarioEpisodioId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00052", "SELECT [UsuarioEpisodioId], [UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId] FROM [UsuarioEpisodio] WITH (UPDLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00052,1,0,true,false )
           ,new CursorDef("BC00053", "SELECT [UsuarioEpisodioId], [UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00053,1,0,true,false )
           ,new CursorDef("BC00054", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00054,1,0,true,false )
           ,new CursorDef("BC00055", "SELECT [EpisodioId] FROM [Episodio] WITH (NOLOCK) WHERE [EpisodioId] = @EpisodioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00055,1,0,true,false )
           ,new CursorDef("BC00056", "SELECT TM1.[UsuarioEpisodioId], TM1.[UsuarioEpisodioNota], TM1.[UsuarioEpisodioAssistido], TM1.[UsuarioEpisodioComentario], TM1.[UsuarioEpisodioFavorito], TM1.[UsuarioId], TM1.[EpisodioId] FROM [UsuarioEpisodio] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioEpisodioId] = @UsuarioEpisodioId ORDER BY TM1.[UsuarioEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00056,100,0,true,false )
           ,new CursorDef("BC00057", "SELECT [UsuarioEpisodioId] FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00057,1,0,true,false )
           ,new CursorDef("BC00058", "INSERT INTO [UsuarioEpisodio]([UsuarioEpisodioNota], [UsuarioEpisodioAssistido], [UsuarioEpisodioComentario], [UsuarioEpisodioFavorito], [UsuarioId], [EpisodioId]) VALUES(@UsuarioEpisodioNota, @UsuarioEpisodioAssistido, @UsuarioEpisodioComentario, @UsuarioEpisodioFavorito, @UsuarioId, @EpisodioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00058)
           ,new CursorDef("BC00059", "UPDATE [UsuarioEpisodio] SET [UsuarioEpisodioNota]=@UsuarioEpisodioNota, [UsuarioEpisodioAssistido]=@UsuarioEpisodioAssistido, [UsuarioEpisodioComentario]=@UsuarioEpisodioComentario, [UsuarioEpisodioFavorito]=@UsuarioEpisodioFavorito, [UsuarioId]=@UsuarioId, [EpisodioId]=@EpisodioId  WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId", GxErrorMask.GX_NOMASK,prmBC00059)
           ,new CursorDef("BC000510", "DELETE FROM [UsuarioEpisodio]  WHERE [UsuarioEpisodioId] = @UsuarioEpisodioId", GxErrorMask.GX_NOMASK,prmBC000510)
           ,new CursorDef("BC000511", "SELECT TM1.[UsuarioEpisodioId], TM1.[UsuarioEpisodioNota], TM1.[UsuarioEpisodioAssistido], TM1.[UsuarioEpisodioComentario], TM1.[UsuarioEpisodioFavorito], TM1.[UsuarioId], TM1.[EpisodioId] FROM [UsuarioEpisodio] TM1 WITH (NOLOCK) WHERE TM1.[UsuarioEpisodioId] = @UsuarioEpisodioId ORDER BY TM1.[UsuarioEpisodioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000511,100,0,true,false )
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
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((bool[]) buf[2])[0] = rslt.getBool(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (bool)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              stmt.SetParameter(5, (long)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              stmt.SetParameter(7, (long)parms[6]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
