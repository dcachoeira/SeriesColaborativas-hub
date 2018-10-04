/*
               File: UsuarioConquista_BC
        Description: Usuário conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:31.98
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
   public class usuarioconquista_bc : GXHttpHandler, IGxSilentTrn
   {
      public usuarioconquista_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usuarioconquista_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtUsuarioConquista> GetAll( int Start ,
                                                         int Count )
      {
         GXPagingFrom8 = Start;
         GXPagingTo8 = Count;
         /* Using cursor BC00086 */
         pr_default.execute(4, new Object[] {GXPagingFrom8, GXPagingTo8});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound8 = 1;
            A30UsuarioConquistaId = BC00086_A30UsuarioConquistaId[0];
            A29ConquistaNome = BC00086_A29ConquistaNome[0];
            A28ConquistaPontos = BC00086_A28ConquistaPontos[0];
            A31UsuarioConquistaDataHora = BC00086_A31UsuarioConquistaDataHora[0];
            A11UsuarioId = BC00086_A11UsuarioId[0];
            A27ConquistaId = BC00086_A27ConquistaId[0];
         }
         bcUsuarioConquista = new SdtUsuarioConquista(context);
         gx_restcollection.Clear();
         while ( RcdFound8 != 0 )
         {
            OnLoadActions088( ) ;
            AddRow088( ) ;
            gx_sdt_item = (SdtUsuarioConquista)(bcUsuarioConquista.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(4);
            RcdFound8 = 0;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(4) != 101) )
            {
               RcdFound8 = 1;
               A30UsuarioConquistaId = BC00086_A30UsuarioConquistaId[0];
               A29ConquistaNome = BC00086_A29ConquistaNome[0];
               A28ConquistaPontos = BC00086_A28ConquistaPontos[0];
               A31UsuarioConquistaDataHora = BC00086_A31UsuarioConquistaDataHora[0];
               A11UsuarioId = BC00086_A11UsuarioId[0];
               A27ConquistaId = BC00086_A27ConquistaId[0];
            }
            Gx_mode = sMode8;
         }
         pr_default.close(4);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM088( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow088( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey088( ) ;
         standaloneModal( ) ;
         AddRow088( ) ;
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
               Z30UsuarioConquistaId = A30UsuarioConquistaId;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls088( ) ;
            }
            else
            {
               CheckExtendedTable088( ) ;
               if ( AnyError == 0 )
               {
                  ZM088( 3) ;
                  ZM088( 4) ;
               }
               CloseExtendedTableCursors088( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM088( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z31UsuarioConquistaDataHora = A31UsuarioConquistaDataHora;
            Z11UsuarioId = A11UsuarioId;
            Z27ConquistaId = A27ConquistaId;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z29ConquistaNome = A29ConquistaNome;
            Z28ConquistaPontos = A28ConquistaPontos;
         }
         if ( GX_JID == -2 )
         {
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
            Z31UsuarioConquistaDataHora = A31UsuarioConquistaDataHora;
            Z11UsuarioId = A11UsuarioId;
            Z27ConquistaId = A27ConquistaId;
            Z29ConquistaNome = A29ConquistaNome;
            Z28ConquistaPontos = A28ConquistaPontos;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load088( )
      {
         /* Using cursor BC00087 */
         pr_default.execute(5, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound8 = 1;
            A29ConquistaNome = BC00087_A29ConquistaNome[0];
            A28ConquistaPontos = BC00087_A28ConquistaPontos[0];
            A31UsuarioConquistaDataHora = BC00087_A31UsuarioConquistaDataHora[0];
            A11UsuarioId = BC00087_A11UsuarioId[0];
            A27ConquistaId = BC00087_A27ConquistaId[0];
            ZM088( -2) ;
         }
         pr_default.close(5);
         OnLoadActions088( ) ;
      }

      protected void OnLoadActions088( )
      {
      }

      protected void CheckExtendedTable088( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00084 */
         pr_default.execute(2, new Object[] {A11UsuarioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("Não existe 'Usuário'.", "ForeignKeyNotFound", 1, "USUARIOID");
            AnyError = 1;
         }
         pr_default.close(2);
         /* Using cursor BC00085 */
         pr_default.execute(3, new Object[] {A27ConquistaId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("Não existe 'Conquista'.", "ForeignKeyNotFound", 1, "CONQUISTAID");
            AnyError = 1;
         }
         A29ConquistaNome = BC00085_A29ConquistaNome[0];
         A28ConquistaPontos = BC00085_A28ConquistaPontos[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A31UsuarioConquistaDataHora) || ( A31UsuarioConquistaDataHora >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Data e hora da conquista fora do intervalo", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors088( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey088( )
      {
         /* Using cursor BC00088 */
         pr_default.execute(6, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00083 */
         pr_default.execute(1, new Object[] {A30UsuarioConquistaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM088( 2) ;
            RcdFound8 = 1;
            A30UsuarioConquistaId = BC00083_A30UsuarioConquistaId[0];
            A31UsuarioConquistaDataHora = BC00083_A31UsuarioConquistaDataHora[0];
            A11UsuarioId = BC00083_A11UsuarioId[0];
            A27ConquistaId = BC00083_A27ConquistaId[0];
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load088( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey088( ) ;
            }
            Gx_mode = sMode8;
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey088( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode8;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey088( ) ;
         if ( RcdFound8 == 0 )
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
         CONFIRM_080( ) ;
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

      protected void CheckOptimisticConcurrency088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00082 */
            pr_default.execute(0, new Object[] {A30UsuarioConquistaId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioConquista"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z31UsuarioConquistaDataHora != BC00082_A31UsuarioConquistaDataHora[0] ) || ( Z11UsuarioId != BC00082_A11UsuarioId[0] ) || ( Z27ConquistaId != BC00082_A27ConquistaId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioConquista"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM088( 0) ;
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00089 */
                     pr_default.execute(7, new Object[] {A31UsuarioConquistaDataHora, A11UsuarioId, A27ConquistaId});
                     A30UsuarioConquistaId = BC00089_A30UsuarioConquistaId[0];
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
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
               Load088( ) ;
            }
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void Update088( )
      {
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable088( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm088( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate088( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000810 */
                     pr_default.execute(8, new Object[] {A31UsuarioConquistaDataHora, A11UsuarioId, A27ConquistaId, A30UsuarioConquistaId});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UsuarioConquista"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate088( ) ;
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
            EndLevel088( ) ;
         }
         CloseExtendedTableCursors088( ) ;
      }

      protected void DeferredUpdate088( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate088( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency088( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls088( ) ;
            AfterConfirm088( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete088( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000811 */
                  pr_default.execute(9, new Object[] {A30UsuarioConquistaId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("UsuarioConquista") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel088( ) ;
         Gx_mode = sMode8;
      }

      protected void OnDeleteControls088( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000812 */
            pr_default.execute(10, new Object[] {A27ConquistaId});
            A29ConquistaNome = BC000812_A29ConquistaNome[0];
            A28ConquistaPontos = BC000812_A28ConquistaPontos[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel088( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete088( ) ;
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

      public void ScanKeyStart088( )
      {
         /* Using cursor BC000813 */
         pr_default.execute(11, new Object[] {A30UsuarioConquistaId});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound8 = 1;
            A30UsuarioConquistaId = BC000813_A30UsuarioConquistaId[0];
            A29ConquistaNome = BC000813_A29ConquistaNome[0];
            A28ConquistaPontos = BC000813_A28ConquistaPontos[0];
            A31UsuarioConquistaDataHora = BC000813_A31UsuarioConquistaDataHora[0];
            A11UsuarioId = BC000813_A11UsuarioId[0];
            A27ConquistaId = BC000813_A27ConquistaId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext088( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound8 = 0;
         ScanKeyLoad088( ) ;
      }

      protected void ScanKeyLoad088( )
      {
         sMode8 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound8 = 1;
            A30UsuarioConquistaId = BC000813_A30UsuarioConquistaId[0];
            A29ConquistaNome = BC000813_A29ConquistaNome[0];
            A28ConquistaPontos = BC000813_A28ConquistaPontos[0];
            A31UsuarioConquistaDataHora = BC000813_A31UsuarioConquistaDataHora[0];
            A11UsuarioId = BC000813_A11UsuarioId[0];
            A27ConquistaId = BC000813_A27ConquistaId[0];
         }
         Gx_mode = sMode8;
      }

      protected void ScanKeyEnd088( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm088( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert088( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate088( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete088( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete088( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate088( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes088( )
      {
      }

      protected void send_integrity_lvl_hashes088( )
      {
      }

      protected void AddRow088( )
      {
         VarsToRow8( bcUsuarioConquista) ;
      }

      protected void ReadRow088( )
      {
         RowToVars8( bcUsuarioConquista, 1) ;
      }

      protected void InitializeNonKey088( )
      {
         A11UsuarioId = 0;
         A27ConquistaId = 0;
         A29ConquistaNome = "";
         A28ConquistaPontos = 0;
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         Z31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         Z11UsuarioId = 0;
         Z27ConquistaId = 0;
      }

      protected void InitAll088( )
      {
         A30UsuarioConquistaId = 0;
         InitializeNonKey088( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow8( SdtUsuarioConquista obj8 )
      {
         obj8.gxTpr_Mode = Gx_mode;
         obj8.gxTpr_Usuarioid = A11UsuarioId;
         obj8.gxTpr_Conquistaid = A27ConquistaId;
         obj8.gxTpr_Conquistanome = A29ConquistaNome;
         obj8.gxTpr_Conquistapontos = A28ConquistaPontos;
         obj8.gxTpr_Usuarioconquistadatahora = A31UsuarioConquistaDataHora;
         obj8.gxTpr_Usuarioconquistaid = A30UsuarioConquistaId;
         obj8.gxTpr_Usuarioconquistaid_Z = Z30UsuarioConquistaId;
         obj8.gxTpr_Usuarioid_Z = Z11UsuarioId;
         obj8.gxTpr_Conquistaid_Z = Z27ConquistaId;
         obj8.gxTpr_Conquistanome_Z = Z29ConquistaNome;
         obj8.gxTpr_Conquistapontos_Z = Z28ConquistaPontos;
         obj8.gxTpr_Usuarioconquistadatahora_Z = Z31UsuarioConquistaDataHora;
         obj8.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow8( SdtUsuarioConquista obj8 )
      {
         obj8.gxTpr_Usuarioconquistaid = A30UsuarioConquistaId;
         return  ;
      }

      public void RowToVars8( SdtUsuarioConquista obj8 ,
                              int forceLoad )
      {
         Gx_mode = obj8.gxTpr_Mode;
         A11UsuarioId = obj8.gxTpr_Usuarioid;
         A27ConquistaId = obj8.gxTpr_Conquistaid;
         A29ConquistaNome = obj8.gxTpr_Conquistanome;
         A28ConquistaPontos = obj8.gxTpr_Conquistapontos;
         A31UsuarioConquistaDataHora = obj8.gxTpr_Usuarioconquistadatahora;
         A30UsuarioConquistaId = obj8.gxTpr_Usuarioconquistaid;
         Z30UsuarioConquistaId = obj8.gxTpr_Usuarioconquistaid_Z;
         Z11UsuarioId = obj8.gxTpr_Usuarioid_Z;
         Z27ConquistaId = obj8.gxTpr_Conquistaid_Z;
         Z29ConquistaNome = obj8.gxTpr_Conquistanome_Z;
         Z28ConquistaPontos = obj8.gxTpr_Conquistapontos_Z;
         Z31UsuarioConquistaDataHora = obj8.gxTpr_Usuarioconquistadatahora_Z;
         Gx_mode = obj8.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A30UsuarioConquistaId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey088( ) ;
         ScanKeyStart088( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
         }
         ZM088( -2) ;
         OnLoadActions088( ) ;
         AddRow088( ) ;
         ScanKeyEnd088( ) ;
         if ( RcdFound8 == 0 )
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
         RowToVars8( bcUsuarioConquista, 0) ;
         ScanKeyStart088( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z30UsuarioConquistaId = A30UsuarioConquistaId;
         }
         ZM088( -2) ;
         OnLoadActions088( ) ;
         AddRow088( ) ;
         ScanKeyEnd088( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey088( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert088( ) ;
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
               {
                  A30UsuarioConquistaId = Z30UsuarioConquistaId;
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
                  Update088( ) ;
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
                  if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
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
                        Insert088( ) ;
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
                        Insert088( ) ;
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
         RowToVars8( bcUsuarioConquista, 0) ;
         SaveImpl( ) ;
         VarsToRow8( bcUsuarioConquista) ;
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
         RowToVars8( bcUsuarioConquista, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert088( ) ;
         AfterTrn( ) ;
         VarsToRow8( bcUsuarioConquista) ;
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
            SdtUsuarioConquista auxBC = new SdtUsuarioConquista(context) ;
            auxBC.Load(A30UsuarioConquistaId);
            auxBC.UpdateDirties(bcUsuarioConquista);
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
         RowToVars8( bcUsuarioConquista, 0) ;
         UpdateImpl( ) ;
         VarsToRow8( bcUsuarioConquista) ;
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
         RowToVars8( bcUsuarioConquista, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert088( ) ;
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
         VarsToRow8( bcUsuarioConquista) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars8( bcUsuarioConquista, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey088( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
            {
               A30UsuarioConquistaId = Z30UsuarioConquistaId;
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
            if ( A30UsuarioConquistaId != Z30UsuarioConquistaId )
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
         pr_gam.rollback( "UsuarioConquista_BC");
         pr_default.rollback( "UsuarioConquista_BC");
         VarsToRow8( bcUsuarioConquista) ;
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
         Gx_mode = bcUsuarioConquista.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcUsuarioConquista.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcUsuarioConquista )
         {
            bcUsuarioConquista = (SdtUsuarioConquista)(sdt);
            if ( StringUtil.StrCmp(bcUsuarioConquista.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioConquista.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow8( bcUsuarioConquista) ;
            }
            else
            {
               RowToVars8( bcUsuarioConquista, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcUsuarioConquista.gxTpr_Mode, "") == 0 )
            {
               bcUsuarioConquista.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars8( bcUsuarioConquista, 1) ;
         return  ;
      }

      public SdtUsuarioConquista UsuarioConquista_BC
      {
         get {
            return bcUsuarioConquista ;
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
         BC00086_A30UsuarioConquistaId = new long[1] ;
         BC00086_A29ConquistaNome = new String[] {""} ;
         BC00086_A28ConquistaPontos = new short[1] ;
         BC00086_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         BC00086_A11UsuarioId = new long[1] ;
         BC00086_A27ConquistaId = new long[1] ;
         A29ConquistaNome = "";
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         gx_restcollection = new GXBCCollection<SdtUsuarioConquista>( context, "UsuarioConquista", "SeriesColaborativas");
         sMode8 = "";
         Gx_mode = "";
         Z31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         Z29ConquistaNome = "";
         BC00087_A30UsuarioConquistaId = new long[1] ;
         BC00087_A29ConquistaNome = new String[] {""} ;
         BC00087_A28ConquistaPontos = new short[1] ;
         BC00087_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         BC00087_A11UsuarioId = new long[1] ;
         BC00087_A27ConquistaId = new long[1] ;
         BC00084_A11UsuarioId = new long[1] ;
         BC00085_A29ConquistaNome = new String[] {""} ;
         BC00085_A28ConquistaPontos = new short[1] ;
         BC00088_A30UsuarioConquistaId = new long[1] ;
         BC00083_A30UsuarioConquistaId = new long[1] ;
         BC00083_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         BC00083_A11UsuarioId = new long[1] ;
         BC00083_A27ConquistaId = new long[1] ;
         BC00082_A30UsuarioConquistaId = new long[1] ;
         BC00082_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         BC00082_A11UsuarioId = new long[1] ;
         BC00082_A27ConquistaId = new long[1] ;
         BC00089_A30UsuarioConquistaId = new long[1] ;
         BC000812_A29ConquistaNome = new String[] {""} ;
         BC000812_A28ConquistaPontos = new short[1] ;
         BC000813_A30UsuarioConquistaId = new long[1] ;
         BC000813_A29ConquistaNome = new String[] {""} ;
         BC000813_A28ConquistaPontos = new short[1] ;
         BC000813_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         BC000813_A11UsuarioId = new long[1] ;
         BC000813_A27ConquistaId = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.usuarioconquista_bc__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.usuarioconquista_bc__default(),
            new Object[][] {
                new Object[] {
               BC00082_A30UsuarioConquistaId, BC00082_A31UsuarioConquistaDataHora, BC00082_A11UsuarioId, BC00082_A27ConquistaId
               }
               , new Object[] {
               BC00083_A30UsuarioConquistaId, BC00083_A31UsuarioConquistaDataHora, BC00083_A11UsuarioId, BC00083_A27ConquistaId
               }
               , new Object[] {
               BC00084_A11UsuarioId
               }
               , new Object[] {
               BC00085_A29ConquistaNome, BC00085_A28ConquistaPontos
               }
               , new Object[] {
               BC00086_A30UsuarioConquistaId, BC00086_A29ConquistaNome, BC00086_A28ConquistaPontos, BC00086_A31UsuarioConquistaDataHora, BC00086_A11UsuarioId, BC00086_A27ConquistaId
               }
               , new Object[] {
               BC00087_A30UsuarioConquistaId, BC00087_A29ConquistaNome, BC00087_A28ConquistaPontos, BC00087_A31UsuarioConquistaDataHora, BC00087_A11UsuarioId, BC00087_A27ConquistaId
               }
               , new Object[] {
               BC00088_A30UsuarioConquistaId
               }
               , new Object[] {
               BC00089_A30UsuarioConquistaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000812_A29ConquistaNome, BC000812_A28ConquistaPontos
               }
               , new Object[] {
               BC000813_A30UsuarioConquistaId, BC000813_A29ConquistaNome, BC000813_A28ConquistaPontos, BC000813_A31UsuarioConquistaDataHora, BC000813_A11UsuarioId, BC000813_A27ConquistaId
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
      private short RcdFound8 ;
      private short A28ConquistaPontos ;
      private short GX_JID ;
      private short Z28ConquistaPontos ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom8 ;
      private int GXPagingTo8 ;
      private long A30UsuarioConquistaId ;
      private long A11UsuarioId ;
      private long A27ConquistaId ;
      private long Z30UsuarioConquistaId ;
      private long Z11UsuarioId ;
      private long Z27ConquistaId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode8 ;
      private String Gx_mode ;
      private DateTime A31UsuarioConquistaDataHora ;
      private DateTime Z31UsuarioConquistaDataHora ;
      private String A29ConquistaNome ;
      private String Z29ConquistaNome ;
      private GXBCCollection<SdtUsuarioConquista> gx_restcollection ;
      private SdtUsuarioConquista bcUsuarioConquista ;
      private SdtUsuarioConquista gx_sdt_item ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00086_A30UsuarioConquistaId ;
      private String[] BC00086_A29ConquistaNome ;
      private short[] BC00086_A28ConquistaPontos ;
      private DateTime[] BC00086_A31UsuarioConquistaDataHora ;
      private long[] BC00086_A11UsuarioId ;
      private long[] BC00086_A27ConquistaId ;
      private long[] BC00087_A30UsuarioConquistaId ;
      private String[] BC00087_A29ConquistaNome ;
      private short[] BC00087_A28ConquistaPontos ;
      private DateTime[] BC00087_A31UsuarioConquistaDataHora ;
      private long[] BC00087_A11UsuarioId ;
      private long[] BC00087_A27ConquistaId ;
      private long[] BC00084_A11UsuarioId ;
      private String[] BC00085_A29ConquistaNome ;
      private short[] BC00085_A28ConquistaPontos ;
      private long[] BC00088_A30UsuarioConquistaId ;
      private long[] BC00083_A30UsuarioConquistaId ;
      private DateTime[] BC00083_A31UsuarioConquistaDataHora ;
      private long[] BC00083_A11UsuarioId ;
      private long[] BC00083_A27ConquistaId ;
      private long[] BC00082_A30UsuarioConquistaId ;
      private DateTime[] BC00082_A31UsuarioConquistaDataHora ;
      private long[] BC00082_A11UsuarioId ;
      private long[] BC00082_A27ConquistaId ;
      private long[] BC00089_A30UsuarioConquistaId ;
      private String[] BC000812_A29ConquistaNome ;
      private short[] BC000812_A28ConquistaPontos ;
      private long[] BC000813_A30UsuarioConquistaId ;
      private String[] BC000813_A29ConquistaNome ;
      private short[] BC000813_A28ConquistaPontos ;
      private DateTime[] BC000813_A31UsuarioConquistaDataHora ;
      private long[] BC000813_A11UsuarioId ;
      private long[] BC000813_A27ConquistaId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_gam ;
   }

   public class usuarioconquista_bc__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class usuarioconquista_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00086 ;
        prmBC00086 = new Object[] {
        new Object[] {"@GXPagingFrom8",SqlDbType.Int,9,0} ,
        new Object[] {"@GXPagingTo8",SqlDbType.Int,9,0}
        } ;
        Object[] prmBC00087 ;
        prmBC00087 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00084 ;
        prmBC00084 = new Object[] {
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00085 ;
        prmBC00085 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00088 ;
        prmBC00088 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00083 ;
        prmBC00083 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00082 ;
        prmBC00082 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00089 ;
        prmBC00089 = new Object[] {
        new Object[] {"@UsuarioConquistaDataHora",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000810 ;
        prmBC000810 = new Object[] {
        new Object[] {"@UsuarioConquistaDataHora",SqlDbType.DateTime,8,5} ,
        new Object[] {"@UsuarioId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000811 ;
        prmBC000811 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000812 ;
        prmBC000812 = new Object[] {
        new Object[] {"@ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000813 ;
        prmBC000813 = new Object[] {
        new Object[] {"@UsuarioConquistaId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00082", "SELECT [UsuarioConquistaId], [UsuarioConquistaDataHora], [UsuarioId], [ConquistaId] FROM [UsuarioConquista] WITH (UPDLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00082,1,0,true,false )
           ,new CursorDef("BC00083", "SELECT [UsuarioConquistaId], [UsuarioConquistaDataHora], [UsuarioId], [ConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00083,1,0,true,false )
           ,new CursorDef("BC00084", "SELECT [UsuarioId] FROM [Usuario] WITH (NOLOCK) WHERE [UsuarioId] = @UsuarioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00084,1,0,true,false )
           ,new CursorDef("BC00085", "SELECT [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00085,1,0,true,false )
           ,new CursorDef("BC00086", "SELECT TM1.[UsuarioConquistaId], T2.[ConquistaNome], T2.[ConquistaPontos], TM1.[UsuarioConquistaDataHora], TM1.[UsuarioId], TM1.[ConquistaId] FROM ([UsuarioConquista] TM1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = TM1.[ConquistaId]) ORDER BY TM1.[UsuarioConquistaId]  OFFSET @GXPagingFrom8 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo8 > 0 THEN @GXPagingTo8 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00086,100,0,true,false )
           ,new CursorDef("BC00087", "SELECT TM1.[UsuarioConquistaId], T2.[ConquistaNome], T2.[ConquistaPontos], TM1.[UsuarioConquistaDataHora], TM1.[UsuarioId], TM1.[ConquistaId] FROM ([UsuarioConquista] TM1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = TM1.[ConquistaId]) WHERE TM1.[UsuarioConquistaId] = @UsuarioConquistaId ORDER BY TM1.[UsuarioConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00087,100,0,true,false )
           ,new CursorDef("BC00088", "SELECT [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE [UsuarioConquistaId] = @UsuarioConquistaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00088,1,0,true,false )
           ,new CursorDef("BC00089", "INSERT INTO [UsuarioConquista]([UsuarioConquistaDataHora], [UsuarioId], [ConquistaId]) VALUES(@UsuarioConquistaDataHora, @UsuarioId, @ConquistaId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00089)
           ,new CursorDef("BC000810", "UPDATE [UsuarioConquista] SET [UsuarioConquistaDataHora]=@UsuarioConquistaDataHora, [UsuarioId]=@UsuarioId, [ConquistaId]=@ConquistaId  WHERE [UsuarioConquistaId] = @UsuarioConquistaId", GxErrorMask.GX_NOMASK,prmBC000810)
           ,new CursorDef("BC000811", "DELETE FROM [UsuarioConquista]  WHERE [UsuarioConquistaId] = @UsuarioConquistaId", GxErrorMask.GX_NOMASK,prmBC000811)
           ,new CursorDef("BC000812", "SELECT [ConquistaNome], [ConquistaPontos] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @ConquistaId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000812,1,0,true,false )
           ,new CursorDef("BC000813", "SELECT TM1.[UsuarioConquistaId], T2.[ConquistaNome], T2.[ConquistaPontos], TM1.[UsuarioConquistaDataHora], TM1.[UsuarioId], TM1.[ConquistaId] FROM ([UsuarioConquista] TM1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = TM1.[ConquistaId]) WHERE TM1.[UsuarioConquistaId] = @UsuarioConquistaId ORDER BY TM1.[UsuarioConquistaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000813,100,0,true,false )
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
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
              ((long[]) buf[4])[0] = rslt.getLong(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
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
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (int)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              return;
           case 8 :
              stmt.SetParameterDatetime(1, (DateTime)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              stmt.SetParameter(3, (long)parms[2]);
              stmt.SetParameter(4, (long)parms[3]);
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
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.usuarioconquista_bc_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class usuarioconquista_bc_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "GET" ,
   	BodyStyle =  WebMessageBodyStyle.Bare  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/{sA30UsuarioConquistaId}")]
   public SdtUsuarioConquista_RESTInterface Load( string sA30UsuarioConquistaId )
   {
      try
      {
         long A30UsuarioConquistaId ;
         A30UsuarioConquistaId = (long)(NumberUtil.Val( (String)(sA30UsuarioConquistaId), "."));
         SdtUsuarioConquista worker = new SdtUsuarioConquista(context) ;
         SdtUsuarioConquista_RESTInterface worker_interface = new SdtUsuarioConquista_RESTInterface (worker);
         if ( StringUtil.StrCmp(sA30UsuarioConquistaId, "_default") == 0 )
         {
            IGxSilentTrn workertrn = worker.getTransaction() ;
            workertrn.GetInsDefault();
         }
         else
         {
            worker.Load(A30UsuarioConquistaId);
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
   	UriTemplate = "/{sA30UsuarioConquistaId}")]
   public SdtUsuarioConquista_RESTInterface Delete( string sA30UsuarioConquistaId )
   {
      try
      {
         long A30UsuarioConquistaId ;
         A30UsuarioConquistaId = (long)(NumberUtil.Val( (String)(sA30UsuarioConquistaId), "."));
         SdtUsuarioConquista worker = new SdtUsuarioConquista(context) ;
         SdtUsuarioConquista_RESTInterface worker_interface = new SdtUsuarioConquista_RESTInterface (worker);
         worker.Load(A30UsuarioConquistaId);
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
   	UriTemplate = "/{sA30UsuarioConquistaId}")]
   public SdtUsuarioConquista_RESTInterface Insert( string sA30UsuarioConquistaId ,
                                                    SdtUsuarioConquista_RESTInterface entity )
   {
      try
      {
         long A30UsuarioConquistaId ;
         A30UsuarioConquistaId = (long)(NumberUtil.Val( (String)(sA30UsuarioConquistaId), "."));
         SdtUsuarioConquista worker = new SdtUsuarioConquista(context) ;
         bool gxcheck = RestParameter("check", "true") ;
         bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
         SdtUsuarioConquista_RESTInterface worker_interface = new SdtUsuarioConquista_RESTInterface (worker);
         worker_interface.CopyFrom(entity);
         worker.gxTpr_Usuarioconquistaid = A30UsuarioConquistaId;
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
   	UriTemplate = "/{sA30UsuarioConquistaId}")]
   public SdtUsuarioConquista_RESTInterface Update( string sA30UsuarioConquistaId ,
                                                    SdtUsuarioConquista_RESTInterface entity )
   {
      try
      {
         long A30UsuarioConquistaId ;
         A30UsuarioConquistaId = (long)(NumberUtil.Val( (String)(sA30UsuarioConquistaId), "."));
         SdtUsuarioConquista worker = new SdtUsuarioConquista(context) ;
         SdtUsuarioConquista_RESTInterface worker_interface = new SdtUsuarioConquista_RESTInterface (worker);
         bool gxcheck = RestParameter("check", "true") ;
         worker.Load(A30UsuarioConquistaId);
         if (entity.Hash == worker_interface.Hash) {
            worker_interface.CopyFrom(entity);
            worker.gxTpr_Usuarioconquistaid = A30UsuarioConquistaId;
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
            SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"UsuarioConquista"}) );
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
