/*
               File: Notificacao_BC
        Description: Notificação
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:41:29.81
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
   public class notificacao_bc : GXHttpHandler, IGxSilentTrn
   {
      public notificacao_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public notificacao_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtNotificacao> GetAll( int Start ,
                                                    int Count )
      {
         GXPagingFrom6 = Start;
         GXPagingTo6 = Count;
         /* Using cursor BC00065 */
         pr_default.execute(3, new Object[] {GXPagingFrom6, GXPagingTo6});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
            A23NotificacaoId = BC00065_A23NotificacaoId[0];
            A24NotificacaoTipo = BC00065_A24NotificacaoTipo[0];
            A25NotificacaoTexto = BC00065_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = BC00065_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = BC00065_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = BC00065_A26NotificacaoDataHoraEnvio[0];
            A11UsuarioId = BC00065_A11UsuarioId[0];
         }
         bcNotificacao = new SdtNotificacao(context);
         gx_restcollection.Clear();
         while ( RcdFound6 != 0 )
         {
            OnLoadActions066( ) ;
            AddRow066( ) ;
            gx_sdt_item = (SdtNotificacao)(bcNotificacao.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound6 = 0;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound6 = 1;
               A23NotificacaoId = BC00065_A23NotificacaoId[0];
               A24NotificacaoTipo = BC00065_A24NotificacaoTipo[0];
               A25NotificacaoTexto = BC00065_A25NotificacaoTexto[0];
               A61NotificacaoLigacaoId = BC00065_A61NotificacaoLigacaoId[0];
               n61NotificacaoLigacaoId = BC00065_n61NotificacaoLigacaoId[0];
               A26NotificacaoDataHoraEnvio = BC00065_A26NotificacaoDataHoraEnvio[0];
               A11UsuarioId = BC00065_A11UsuarioId[0];
            }
            Gx_mode = sMode6;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM066( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow066( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey066( ) ;
         standaloneModal( ) ;
         AddRow066( ) ;
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
               Z23NotificacaoId = A23NotificacaoId;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls066( ) ;
            }
            else
            {
               CheckExtendedTable066( ) ;
               if ( AnyError == 0 )
               {
                  ZM066( 5) ;
               }
               CloseExtendedTableCursors066( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM066( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z24NotificacaoTipo = A24NotificacaoTipo;
            Z25NotificacaoTexto = A25NotificacaoTexto;
            Z61NotificacaoLigacaoId = A61NotificacaoLigacaoId;
            Z26NotificacaoDataHoraEnvio = A26NotificacaoDataHoraEnvio;
            Z11UsuarioId = A11UsuarioId;
         }
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -4 )
         {
            Z23NotificacaoId = A23NotificacaoId;
            Z24NotificacaoTipo = A24NotificacaoTipo;
            Z25NotificacaoTexto = A25NotificacaoTexto;
            Z61NotificacaoLigacaoId = A61NotificacaoLigacaoId;
            Z26NotificacaoDataHoraEnvio = A26NotificacaoDataHoraEnvio;
            Z11UsuarioId = A11UsuarioId;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load066( )
      {
         /* Using cursor BC00066 */
         pr_default.execute(4, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound6 = 1;
            A24NotificacaoTipo = BC00066_A24NotificacaoTipo[0];
            A25NotificacaoTexto = BC00066_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = BC00066_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = BC00066_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = BC00066_A26NotificacaoDataHoraEnvio[0];
            A11UsuarioId = BC00066_A11UsuarioId[0];
            ZM066( -4) ;
         }
         pr_default.close(4);
         OnLoadActions066( ) ;
      }

      protected void OnLoadActions066( )
      {
         if ( (0==A61NotificacaoLigacaoId) )
         {
            A61NotificacaoLigacaoId = 0;
            n61NotificacaoLigacaoId = false;
            n61NotificacaoLigacaoId = true;
         }
      }

      protected void CheckExtendedTable066( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00064 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
         }
         pr_default.close(2);
         if ( ! ( ( A24NotificacaoTipo == 1 ) ) )
         {
            GX_msglist.addItem("Campo Tipo de notificação fora do intervalo", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (0==A61NotificacaoLigacaoId) )
         {
            A61NotificacaoLigacaoId = 0;
            n61NotificacaoLigacaoId = false;
            n61NotificacaoLigacaoId = true;
         }
         if ( ! ( (DateTime.MinValue==A26NotificacaoDataHoraEnvio) || ( A26NotificacaoDataHoraEnvio >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora de envio fora do intervalo", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors066( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey066( )
      {
         /* Using cursor BC00067 */
         pr_default.execute(5, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00063 */
         pr_default.execute(1, new Object[] {A23NotificacaoId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM066( 4) ;
            RcdFound6 = 1;
            A23NotificacaoId = BC00063_A23NotificacaoId[0];
            A24NotificacaoTipo = BC00063_A24NotificacaoTipo[0];
            A25NotificacaoTexto = BC00063_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = BC00063_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = BC00063_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = BC00063_A26NotificacaoDataHoraEnvio[0];
            A11UsuarioId = BC00063_A11UsuarioId[0];
            Z23NotificacaoId = A23NotificacaoId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load066( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey066( ) ;
            }
            Gx_mode = sMode6;
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey066( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode6;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey066( ) ;
         if ( RcdFound6 == 0 )
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
         CONFIRM_060( ) ;
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

      protected void CheckOptimisticConcurrency066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00062 */
            pr_default.execute(0, new Object[] {A23NotificacaoId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Notificacao"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z24NotificacaoTipo != BC00062_A24NotificacaoTipo[0] ) || ( StringUtil.StrCmp(Z25NotificacaoTexto, BC00062_A25NotificacaoTexto[0]) != 0 ) || ( Z61NotificacaoLigacaoId != BC00062_A61NotificacaoLigacaoId[0] ) || ( Z26NotificacaoDataHoraEnvio != BC00062_A26NotificacaoDataHoraEnvio[0] ) || ( Z11UsuarioId != BC00062_A11UsuarioId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Notificacao"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM066( 0) ;
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00068 */
                     pr_default.execute(6, new Object[] {A24NotificacaoTipo, A25NotificacaoTexto, n61NotificacaoLigacaoId, A61NotificacaoLigacaoId, A26NotificacaoDataHoraEnvio, A11UsuarioId});
                     A23NotificacaoId = BC00068_A23NotificacaoId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
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
               Load066( ) ;
            }
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void Update066( )
      {
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable066( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm066( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate066( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00069 */
                     pr_default.execute(7, new Object[] {A24NotificacaoTipo, A25NotificacaoTexto, n61NotificacaoLigacaoId, A61NotificacaoLigacaoId, A26NotificacaoDataHoraEnvio, A11UsuarioId, A23NotificacaoId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Notificacao"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate066( ) ;
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
            EndLevel066( ) ;
         }
         CloseExtendedTableCursors066( ) ;
      }

      protected void DeferredUpdate066( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate066( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency066( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls066( ) ;
            AfterConfirm066( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete066( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000610 */
                  pr_default.execute(8, new Object[] {A23NotificacaoId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Notificacao") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel066( ) ;
         Gx_mode = sMode6;
      }

      protected void OnDeleteControls066( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel066( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete066( ) ;
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

      public void ScanKeyStart066( )
      {
         /* Using cursor BC000611 */
         pr_default.execute(9, new Object[] {A23NotificacaoId});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A23NotificacaoId = BC000611_A23NotificacaoId[0];
            A24NotificacaoTipo = BC000611_A24NotificacaoTipo[0];
            A25NotificacaoTexto = BC000611_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = BC000611_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = BC000611_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = BC000611_A26NotificacaoDataHoraEnvio[0];
            A11UsuarioId = BC000611_A11UsuarioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext066( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound6 = 0;
         ScanKeyLoad066( ) ;
      }

      protected void ScanKeyLoad066( )
      {
         sMode6 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A23NotificacaoId = BC000611_A23NotificacaoId[0];
            A24NotificacaoTipo = BC000611_A24NotificacaoTipo[0];
            A25NotificacaoTexto = BC000611_A25NotificacaoTexto[0];
            A61NotificacaoLigacaoId = BC000611_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = BC000611_n61NotificacaoLigacaoId[0];
            A26NotificacaoDataHoraEnvio = BC000611_A26NotificacaoDataHoraEnvio[0];
            A11UsuarioId = BC000611_A11UsuarioId[0];
         }
         Gx_mode = sMode6;
      }

      protected void ScanKeyEnd066( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm066( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert066( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate066( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete066( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete066( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate066( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes066( )
      {
      }

      protected void send_integrity_lvl_hashes066( )
      {
      }

      protected void AddRow066( )
      {
         VarsToRow6( bcNotificacao) ;
      }

      protected void ReadRow066( )
      {
         RowToVars6( bcNotificacao, 1) ;
      }

      protected void InitializeNonKey066( )
      {
         A11UsuarioId = 0;
         A24NotificacaoTipo = 0;
         A25NotificacaoTexto = "";
         A61NotificacaoLigacaoId = 0;
         n61NotificacaoLigacaoId = false;
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         Z24NotificacaoTipo = 0;
         Z25NotificacaoTexto = "";
         Z61NotificacaoLigacaoId = 0;
         Z26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         Z11UsuarioId = 0;
      }

      protected void InitAll066( )
      {
         A23NotificacaoId = 0;
         InitializeNonKey066( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow6( SdtNotificacao obj6 )
      {
         obj6.gxTpr_Mode = Gx_mode;
         obj6.gxTpr_Usuarioid = A11UsuarioId;
         obj6.gxTpr_Notificacaotipo = A24NotificacaoTipo;
         obj6.gxTpr_Notificacaotexto = A25NotificacaoTexto;
         obj6.gxTpr_Notificacaoligacaoid = A61NotificacaoLigacaoId;
         obj6.gxTpr_Notificacaodatahoraenvio = A26NotificacaoDataHoraEnvio;
         obj6.gxTpr_Notificacaoid = A23NotificacaoId;
         obj6.gxTpr_Notificacaoid_Z = Z23NotificacaoId;
         obj6.gxTpr_Usuarioid_Z = Z11UsuarioId;
         obj6.gxTpr_Notificacaotipo_Z = Z24NotificacaoTipo;
         obj6.gxTpr_Notificacaotexto_Z = Z25NotificacaoTexto;
         obj6.gxTpr_Notificacaoligacaoid_Z = Z61NotificacaoLigacaoId;
         obj6.gxTpr_Notificacaodatahoraenvio_Z = Z26NotificacaoDataHoraEnvio;
         obj6.gxTpr_Notificacaoligacaoid_N = (short)(Convert.ToInt16(n61NotificacaoLigacaoId));
         obj6.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow6( SdtNotificacao obj6 )
      {
         obj6.gxTpr_Notificacaoid = A23NotificacaoId;
         return  ;
      }

      public void RowToVars6( SdtNotificacao obj6 ,
                              int forceLoad )
      {
         Gx_mode = obj6.gxTpr_Mode;
         A11UsuarioId = obj6.gxTpr_Usuarioid;
         A24NotificacaoTipo = obj6.gxTpr_Notificacaotipo;
         A25NotificacaoTexto = obj6.gxTpr_Notificacaotexto;
         A61NotificacaoLigacaoId = obj6.gxTpr_Notificacaoligacaoid;
         n61NotificacaoLigacaoId = false;
         A26NotificacaoDataHoraEnvio = obj6.gxTpr_Notificacaodatahoraenvio;
         A23NotificacaoId = obj6.gxTpr_Notificacaoid;
         Z23NotificacaoId = obj6.gxTpr_Notificacaoid_Z;
         Z11UsuarioId = obj6.gxTpr_Usuarioid_Z;
         Z24NotificacaoTipo = obj6.gxTpr_Notificacaotipo_Z;
         Z25NotificacaoTexto = obj6.gxTpr_Notificacaotexto_Z;
         Z61NotificacaoLigacaoId = obj6.gxTpr_Notificacaoligacaoid_Z;
         Z26NotificacaoDataHoraEnvio = obj6.gxTpr_Notificacaodatahoraenvio_Z;
         n61NotificacaoLigacaoId = (bool)(Convert.ToBoolean(obj6.gxTpr_Notificacaoligacaoid_N));
         Gx_mode = obj6.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A23NotificacaoId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey066( ) ;
         ScanKeyStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z23NotificacaoId = A23NotificacaoId;
         }
         ZM066( -4) ;
         OnLoadActions066( ) ;
         AddRow066( ) ;
         ScanKeyEnd066( ) ;
         if ( RcdFound6 == 0 )
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
         RowToVars6( bcNotificacao, 0) ;
         ScanKeyStart066( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z23NotificacaoId = A23NotificacaoId;
         }
         ZM066( -4) ;
         OnLoadActions066( ) ;
         AddRow066( ) ;
         ScanKeyEnd066( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey066( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert066( ) ;
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A23NotificacaoId != Z23NotificacaoId )
               {
                  A23NotificacaoId = Z23NotificacaoId;
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
                  Update066( ) ;
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
                  if ( A23NotificacaoId != Z23NotificacaoId )
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
                        Insert066( ) ;
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
                        Insert066( ) ;
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
         RowToVars6( bcNotificacao, 0) ;
         SaveImpl( ) ;
         VarsToRow6( bcNotificacao) ;
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
         RowToVars6( bcNotificacao, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert066( ) ;
         AfterTrn( ) ;
         VarsToRow6( bcNotificacao) ;
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
            SdtNotificacao auxBC = new SdtNotificacao(context) ;
            auxBC.Load(A23NotificacaoId);
            auxBC.UpdateDirties(bcNotificacao);
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
         RowToVars6( bcNotificacao, 0) ;
         UpdateImpl( ) ;
         VarsToRow6( bcNotificacao) ;
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
         RowToVars6( bcNotificacao, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert066( ) ;
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
         VarsToRow6( bcNotificacao) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars6( bcNotificacao, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey066( ) ;
         if ( RcdFound6 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A23NotificacaoId != Z23NotificacaoId )
            {
               A23NotificacaoId = Z23NotificacaoId;
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
            if ( A23NotificacaoId != Z23NotificacaoId )
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
         pr_gam.rollback( "Notificacao_BC");
         pr_default.rollback( "Notificacao_BC");
         VarsToRow6( bcNotificacao) ;
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
         Gx_mode = bcNotificacao.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcNotificacao.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcNotificacao )
         {
            bcNotificacao = (SdtNotificacao)(sdt);
            if ( StringUtil.StrCmp(bcNotificacao.gxTpr_Mode, "") == 0 )
            {
               bcNotificacao.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow6( bcNotificacao) ;
            }
            else
            {
               RowToVars6( bcNotificacao, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcNotificacao.gxTpr_Mode, "") == 0 )
            {
               bcNotificacao.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars6( bcNotificacao, 1) ;
         return  ;
      }

      public SdtNotificacao Notificacao_BC
      {
         get {
            return bcNotificacao ;
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
         BC00065_A23NotificacaoId = new long[1] ;
         BC00065_A24NotificacaoTipo = new short[1] ;
         BC00065_A25NotificacaoTexto = new String[] {""} ;
         BC00065_A61NotificacaoLigacaoId = new long[1] ;
         BC00065_n61NotificacaoLigacaoId = new bool[] {false} ;
         BC00065_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         BC00065_A11UsuarioId = new long[1] ;
         A25NotificacaoTexto = "";
         A26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         gx_restcollection = new GXBCCollection<SdtNotificacao>( context, "Notificacao", "SeriesColaborativas");
         sMode6 = "";
         Gx_mode = "";
         Z25NotificacaoTexto = "";
         Z26NotificacaoDataHoraEnvio = (DateTime)(DateTime.MinValue);
         BC00066_A23NotificacaoId = new long[1] ;
         BC00066_A24NotificacaoTipo = new short[1] ;
         BC00066_A25NotificacaoTexto = new String[] {""} ;
         BC00066_A61NotificacaoLigacaoId = new long[1] ;
         BC00066_n61NotificacaoLigacaoId = new bool[] {false} ;
         BC00066_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         BC00066_A11UsuarioId = new long[1] ;
         BC00064_A11UsuarioId = new long[1] ;
         BC00067_A23NotificacaoId = new long[1] ;
         BC00063_A23NotificacaoId = new long[1] ;
         BC00063_A24NotificacaoTipo = new short[1] ;
         BC00063_A25NotificacaoTexto = new String[] {""} ;
         BC00063_A61NotificacaoLigacaoId = new long[1] ;
         BC00063_n61NotificacaoLigacaoId = new bool[] {false} ;
         BC00063_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         BC00063_A11UsuarioId = new long[1] ;
         BC00062_A23NotificacaoId = new long[1] ;
         BC00062_A24NotificacaoTipo = new short[1] ;
         BC00062_A25NotificacaoTexto = new String[] {""} ;
         BC00062_A61NotificacaoLigacaoId = new long[1] ;
         BC00062_n61NotificacaoLigacaoId = new bool[] {false} ;
         BC00062_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         BC00062_A11UsuarioId = new long[1] ;
         BC00068_A23NotificacaoId = new long[1] ;
         BC000611_A23NotificacaoId = new long[1] ;
         BC000611_A24NotificacaoTipo = new short[1] ;
         BC000611_A25NotificacaoTexto = new String[] {""} ;
         BC000611_A61NotificacaoLigacaoId = new long[1] ;
         BC000611_n61NotificacaoLigacaoId = new bool[] {false} ;
         BC000611_A26NotificacaoDataHoraEnvio = new DateTime[] {DateTime.MinValue} ;
         BC000611_A11UsuarioId = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.notificacao_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.notificacao_bc__default(),
            new Object[][] {
                new Object[] {
               BC00062_A23NotificacaoId, BC00062_A24NotificacaoTipo, BC00062_A25NotificacaoTexto, BC00062_A61NotificacaoLigacaoId, BC00062_n61NotificacaoLigacaoId, BC00062_A26NotificacaoDataHoraEnvio, BC00062_A11UsuarioId
               }
               , new Object[] {
               BC00063_A23NotificacaoId, BC00063_A24NotificacaoTipo, BC00063_A25NotificacaoTexto, BC00063_A61NotificacaoLigacaoId, BC00063_n61NotificacaoLigacaoId, BC00063_A26NotificacaoDataHoraEnvio, BC00063_A11UsuarioId
               }
               , new Object[] {
               BC00064_A11UsuarioId
               }
               , new Object[] {
               BC00065_A23NotificacaoId, BC00065_A24NotificacaoTipo, BC00065_A25NotificacaoTexto, BC00065_A61NotificacaoLigacaoId, BC00065_n61NotificacaoLigacaoId, BC00065_A26NotificacaoDataHoraEnvio, BC00065_A11UsuarioId
               }
               , new Object[] {
               BC00066_A23NotificacaoId, BC00066_A24NotificacaoTipo, BC00066_A25NotificacaoTexto, BC00066_A61NotificacaoLigacaoId, BC00066_n61NotificacaoLigacaoId, BC00066_A26NotificacaoDataHoraEnvio, BC00066_A11UsuarioId
               }
               , new Object[] {
               BC00067_A23NotificacaoId
               }
               , new Object[] {
               BC00068_A23NotificacaoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000611_A23NotificacaoId, BC000611_A24NotificacaoTipo, BC000611_A25NotificacaoTexto, BC000611_A61NotificacaoLigacaoId, BC000611_n61NotificacaoLigacaoId, BC000611_A26NotificacaoDataHoraEnvio, BC000611_A11UsuarioId
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
      private short RcdFound6 ;
      private short A24NotificacaoTipo ;
      private short GX_JID ;
      private short Z24NotificacaoTipo ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom6 ;
      private int GXPagingTo6 ;
      private long A23NotificacaoId ;
      private long A61NotificacaoLigacaoId ;
      private long A11UsuarioId ;
      private long Z23NotificacaoId ;
      private long Z61NotificacaoLigacaoId ;
      private long Z11UsuarioId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode6 ;
      private String Gx_mode ;
      private DateTime A26NotificacaoDataHoraEnvio ;
      private DateTime Z26NotificacaoDataHoraEnvio ;
      private bool n61NotificacaoLigacaoId ;
      private String A25NotificacaoTexto ;
      private String Z25NotificacaoTexto ;
      private GXBCCollection<SdtNotificacao> gx_restcollection ;
      private SdtNotificacao bcNotificacao ;
      private SdtNotificacao gx_sdt_item ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00065_A23NotificacaoId ;
      private short[] BC00065_A24NotificacaoTipo ;
      private String[] BC00065_A25NotificacaoTexto ;
      private long[] BC00065_A61NotificacaoLigacaoId ;
      private bool[] BC00065_n61NotificacaoLigacaoId ;
      private DateTime[] BC00065_A26NotificacaoDataHoraEnvio ;
      private long[] BC00065_A11UsuarioId ;
      private long[] BC00066_A23NotificacaoId ;
      private short[] BC00066_A24NotificacaoTipo ;
      private String[] BC00066_A25NotificacaoTexto ;
      private long[] BC00066_A61NotificacaoLigacaoId ;
      private bool[] BC00066_n61NotificacaoLigacaoId ;
      private DateTime[] BC00066_A26NotificacaoDataHoraEnvio ;
      private long[] BC00066_A11UsuarioId ;
      private long[] BC00064_A11UsuarioId ;
      private long[] BC00067_A23NotificacaoId ;
      private long[] BC00063_A23NotificacaoId ;
      private short[] BC00063_A24NotificacaoTipo ;
      private String[] BC00063_A25NotificacaoTexto ;
      private long[] BC00063_A61NotificacaoLigacaoId ;
      private bool[] BC00063_n61NotificacaoLigacaoId ;
      private DateTime[] BC00063_A26NotificacaoDataHoraEnvio ;
      private long[] BC00063_A11UsuarioId ;
      private long[] BC00062_A23NotificacaoId ;
      private short[] BC00062_A24NotificacaoTipo ;
      private String[] BC00062_A25NotificacaoTexto ;
      private long[] BC00062_A61NotificacaoLigacaoId ;
      private bool[] BC00062_n61NotificacaoLigacaoId ;
      private DateTime[] BC00062_A26NotificacaoDataHoraEnvio ;
      private long[] BC00062_A11UsuarioId ;
      private long[] BC00068_A23NotificacaoId ;
      private long[] BC000611_A23NotificacaoId ;
      private short[] BC000611_A24NotificacaoTipo ;
      private String[] BC000611_A25NotificacaoTexto ;
      private long[] BC000611_A61NotificacaoLigacaoId ;
      private bool[] BC000611_n61NotificacaoLigacaoId ;
      private DateTime[] BC000611_A26NotificacaoDataHoraEnvio ;
      private long[] BC000611_A11UsuarioId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
   }

   public class notificacao_bc__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class notificacao_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00065 ;
        prmBC00065 = new Object[] {
        new Object[] {"@GXPagingFrom6",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo6",SqlDbType.Int,9,0}
        } ;
        Object[] prmBC00066 ;
        prmBC00066 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00064 ;
        prmBC00064 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00067 ;
        prmBC00067 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00063 ;
        prmBC00063 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00062 ;
        prmBC00062 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00068 ;
        prmBC00068 = new Object[] {
        new Object[] {"@NotificacaoTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@NotificacaoTexto",SqlDbType.VarChar,300,0} ,
        new Object[] {"@NotificacaoLigacaoId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00069 ;
        prmBC00069 = new Object[] {
        new Object[] {"@NotificacaoTipo",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@NotificacaoTexto",SqlDbType.VarChar,300,0} ,
        new Object[] {"@NotificacaoLigacaoId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoDataHoraEnvio",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000610 ;
        prmBC000610 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000611 ;
        prmBC000611 = new Object[] {
        new Object[] {"@NotificacaoId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00062", "SELECT [NotificacaoId], [NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId] FROM [Notificacao] WITH (UPDLOCK) WHERE [NotificacaoId] = @NotificacaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00062,1,0,true,false )
           ,new CursorDef("BC00063", "SELECT [NotificacaoId], [NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00063,1,0,true,false )
           ,new CursorDef("BC00064", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00064,1,0,true,false )
           ,new CursorDef("BC00065", "SELECT TM1.[NotificacaoId], TM1.[NotificacaoTipo], TM1.[NotificacaoTexto], TM1.[NotificacaoLigacaoId], TM1.[NotificacaoDataHoraEnvio], TM1.[UsuarioId] FROM [Notificacao] TM1 WITH (NOLOCK) ORDER BY TM1.[NotificacaoId]  OFFSET @GXPagingFrom6 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo6 > 0 THEN @GXPagingTo6 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00065,100,0,true,false )
           ,new CursorDef("BC00066", "SELECT TM1.[NotificacaoId], TM1.[NotificacaoTipo], TM1.[NotificacaoTexto], TM1.[NotificacaoLigacaoId], TM1.[NotificacaoDataHoraEnvio], TM1.[UsuarioId] FROM [Notificacao] TM1 WITH (NOLOCK) WHERE TM1.[NotificacaoId] = @NotificacaoId ORDER BY TM1.[NotificacaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00066,100,0,true,false )
           ,new CursorDef("BC00067", "SELECT [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE [NotificacaoId] = @NotificacaoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00067,1,0,true,false )
           ,new CursorDef("BC00068", "INSERT INTO [Notificacao]([NotificacaoTipo], [NotificacaoTexto], [NotificacaoLigacaoId], [NotificacaoDataHoraEnvio], [UsuarioId]) VALUES(@NotificacaoTipo, @NotificacaoTexto, @NotificacaoLigacaoId, @NotificacaoDataHoraEnvio, @UsuarioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00068)
           ,new CursorDef("BC00069", "UPDATE [Notificacao] SET [NotificacaoTipo]=@NotificacaoTipo, [NotificacaoTexto]=@NotificacaoTexto, [NotificacaoLigacaoId]=@NotificacaoLigacaoId, [NotificacaoDataHoraEnvio]=@NotificacaoDataHoraEnvio, [UsuarioId]=@UsuarioId  WHERE [NotificacaoId] = @NotificacaoId", GxErrorMask.GX_NOMASK,prmBC00069)
           ,new CursorDef("BC000610", "DELETE FROM [Notificacao]  WHERE [NotificacaoId] = @NotificacaoId", GxErrorMask.GX_NOMASK,prmBC000610)
           ,new CursorDef("BC000611", "SELECT TM1.[NotificacaoId], TM1.[NotificacaoTipo], TM1.[NotificacaoTexto], TM1.[NotificacaoLigacaoId], TM1.[NotificacaoDataHoraEnvio], TM1.[UsuarioId] FROM [Notificacao] TM1 WITH (NOLOCK) WHERE TM1.[NotificacaoId] = @NotificacaoId ORDER BY TM1.[NotificacaoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000611,100,0,true,false )
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
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
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
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(5) ;
              ((long[]) buf[6])[0] = rslt.getLong(6) ;
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
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[3]);
              }
              stmt.SetParameterDatetime(4, (DateTime)parms[4]);
              stmt.SetParameter(5, (long)parms[5]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[3]);
              }
              stmt.SetParameterDatetime(4, (DateTime)parms[4]);
              stmt.SetParameter(5, (long)parms[5]);
              stmt.SetParameter(6, (long)parms[6]);
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

[ServiceContract(Namespace = "GeneXus.Programs.notificacao_bc_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class notificacao_bc_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "GET" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA23NotificacaoId}")]
   public SdtNotificacao_RESTInterface Load( string sA23NotificacaoId )
   {
      try
      {
         long A23NotificacaoId ;
         A23NotificacaoId = (long)(NumberUtil.Val( (String)(sA23NotificacaoId), "."));
         SdtNotificacao worker = new SdtNotificacao(context) ;
         SdtNotificacao_RESTInterface worker_interface = new SdtNotificacao_RESTInterface (worker);
         if ( StringUtil.StrCmp(sA23NotificacaoId, "_default") == 0 )
         {
            IGxSilentTrn workertrn = worker.getTransaction() ;
            workertrn.GetInsDefault();
         }
         else
         {
            worker.Load(A23NotificacaoId);
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
   	UriTemplate = "/{sA23NotificacaoId}")]
   public SdtNotificacao_RESTInterface Delete( string sA23NotificacaoId )
   {
      try
      {
         long A23NotificacaoId ;
         A23NotificacaoId = (long)(NumberUtil.Val( (String)(sA23NotificacaoId), "."));
         SdtNotificacao worker = new SdtNotificacao(context) ;
         SdtNotificacao_RESTInterface worker_interface = new SdtNotificacao_RESTInterface (worker);
         worker.Load(A23NotificacaoId);
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
   	UriTemplate = "/{sA23NotificacaoId}")]
   public SdtNotificacao_RESTInterface Insert( string sA23NotificacaoId ,
                                               SdtNotificacao_RESTInterface entity )
   {
      try
      {
         long A23NotificacaoId ;
         A23NotificacaoId = (long)(NumberUtil.Val( (String)(sA23NotificacaoId), "."));
         SdtNotificacao worker = new SdtNotificacao(context) ;
         bool gxcheck = RestParameter("check", "true") ;
         bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
         SdtNotificacao_RESTInterface worker_interface = new SdtNotificacao_RESTInterface (worker);
         worker_interface.CopyFrom(entity);
         worker.gxTpr_Notificacaoid = A23NotificacaoId;
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
   	UriTemplate = "/{sA23NotificacaoId}")]
   public SdtNotificacao_RESTInterface Update( string sA23NotificacaoId ,
                                               SdtNotificacao_RESTInterface entity )
   {
      try
      {
         long A23NotificacaoId ;
         A23NotificacaoId = (long)(NumberUtil.Val( (String)(sA23NotificacaoId), "."));
         SdtNotificacao worker = new SdtNotificacao(context) ;
         SdtNotificacao_RESTInterface worker_interface = new SdtNotificacao_RESTInterface (worker);
         bool gxcheck = RestParameter("check", "true") ;
         worker.Load(A23NotificacaoId);
         if (entity.Hash == worker_interface.Hash) {
            worker_interface.CopyFrom(entity);
            worker.gxTpr_Notificacaoid = A23NotificacaoId;
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
            SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Notificacao"}) );
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
