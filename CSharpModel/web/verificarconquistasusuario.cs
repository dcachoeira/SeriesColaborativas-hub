/*
               File: VerificarConquistasUsuario
        Description: Verificar conquistas do usuário
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:15:52.35
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class verificarconquistasusuario : GXProcedure
   {
      public verificarconquistasusuario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public verificarconquistasusuario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_UsuarioId ,
                           out bool aP1_NovaConquista )
      {
         this.AV8UsuarioId = aP0_UsuarioId;
         this.AV22NovaConquista = false ;
         initialize();
         executePrivate();
         aP1_NovaConquista=this.AV22NovaConquista;
      }

      public bool executeUdp( long aP0_UsuarioId )
      {
         this.AV8UsuarioId = aP0_UsuarioId;
         this.AV22NovaConquista = false ;
         initialize();
         executePrivate();
         aP1_NovaConquista=this.AV22NovaConquista;
         return AV22NovaConquista ;
      }

      public void executeSubmit( long aP0_UsuarioId ,
                                 out bool aP1_NovaConquista )
      {
         verificarconquistasusuario objverificarconquistasusuario;
         objverificarconquistasusuario = new verificarconquistasusuario();
         objverificarconquistasusuario.AV8UsuarioId = aP0_UsuarioId;
         objverificarconquistasusuario.AV22NovaConquista = false ;
         objverificarconquistasusuario.context.SetSubmitInitialConfig(context);
         objverificarconquistasusuario.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objverificarconquistasusuario);
         aP1_NovaConquista=this.AV22NovaConquista;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((verificarconquistasusuario)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV9TipoConquista = 3;
         /* Execute user subroutine: 'BUSCARCONQUISTAS' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV25I = 1;
         while ( AV25I <= AV11ConquistasId.Count )
         {
            AV12ConquistaId = (long)(AV11ConquistasId.GetNumeric(AV25I));
            /* Execute user subroutine: 'BUSCARQUANTIDADECONQUISTA' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            AV14Count = 0;
            /* Optimized group. */
            /* Using cursor P001O2 */
            pr_default.execute(0, new Object[] {AV8UsuarioId});
            cV14Count = P001O2_AV14Count[0];
            pr_default.close(0);
            AV14Count = (short)(AV14Count+cV14Count*1);
            /* End optimized group. */
            /* Execute user subroutine: 'VERIFICARDIFERENÇA' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'BUSCARCONQUISTAUSUARIO' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( AV15ConquistaOk )
            {
               if ( (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = DateTimeUtil.Now( context);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  /* Execute user subroutine: 'CRIARNOTIFICACAO' */
                  S161 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  AV22NovaConquista = true;
               }
            }
            else
            {
               if ( ! (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
               }
            }
            AV25I = (short)(AV25I+1);
         }
         AV9TipoConquista = 2;
         /* Execute user subroutine: 'BUSCARCONQUISTAS' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV25I = 1;
         while ( AV25I <= AV11ConquistasId.Count )
         {
            AV12ConquistaId = (long)(AV11ConquistasId.GetNumeric(AV25I));
            /* Execute user subroutine: 'BUSCARQUANTIDADECONQUISTA' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            AV14Count = 0;
            /* Optimized group. */
            /* Using cursor P001O3 */
            pr_default.execute(1, new Object[] {AV8UsuarioId});
            c9EpisodioDuracao = P001O3_A9EpisodioDuracao[0];
            pr_default.close(1);
            AV14Count = (short)(AV14Count+c9EpisodioDuracao);
            /* End optimized group. */
            /* Execute user subroutine: 'VERIFICARDIFERENÇA' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'BUSCARCONQUISTAUSUARIO' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( AV15ConquistaOk )
            {
               if ( (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = DateTimeUtil.Now( context);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  /* Execute user subroutine: 'CRIARNOTIFICACAO' */
                  S161 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  AV22NovaConquista = true;
               }
            }
            else
            {
               if ( ! (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
               }
            }
            AV25I = (short)(AV25I+1);
         }
         AV9TipoConquista = 1;
         /* Execute user subroutine: 'BUSCARCONQUISTAS' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         AV25I = 1;
         while ( AV25I <= AV11ConquistasId.Count )
         {
            AV12ConquistaId = (long)(AV11ConquistasId.GetNumeric(AV25I));
            /* Execute user subroutine: 'BUSCARQUANTIDADECONQUISTA' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            AV14Count = 0;
            /* Optimized group. */
            /* Using cursor P001O4 */
            pr_default.execute(2, new Object[] {AV8UsuarioId});
            cV14Count = P001O4_AV14Count[0];
            pr_default.close(2);
            AV14Count = (short)(AV14Count+cV14Count*1);
            /* End optimized group. */
            /* Execute user subroutine: 'VERIFICARDIFERENÇA' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            /* Execute user subroutine: 'BUSCARCONQUISTAUSUARIO' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( AV15ConquistaOk )
            {
               if ( (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = DateTimeUtil.Now( context);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  /* Execute user subroutine: 'CRIARNOTIFICACAO' */
                  S161 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
                  AV22NovaConquista = true;
               }
            }
            else
            {
               if ( ! (DateTime.MinValue==AV18UsuarioConquistaDataHoraAtual) )
               {
                  AV17UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
                  /* Execute user subroutine: 'GRAVARCONQUISTA' */
                  S151 ();
                  if ( returnInSub )
                  {
                     this.cleanup();
                     if (true) return;
                  }
               }
            }
            AV25I = (short)(AV25I+1);
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'BUSCARCONQUISTAS' Routine */
         AV11ConquistasId.Clear();
         /* Using cursor P001O5 */
         pr_default.execute(3, new Object[] {AV9TipoConquista});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A44ConquistaTipo = P001O5_A44ConquistaTipo[0];
            A27ConquistaId = P001O5_A27ConquistaId[0];
            AV11ConquistasId.Add(A27ConquistaId, 0);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void S121( )
      {
         /* 'BUSCARQUANTIDADECONQUISTA' Routine */
         AV13QuantidadeNecessario = 0;
         /* Using cursor P001O6 */
         pr_default.execute(4, new Object[] {AV12ConquistaId});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A27ConquistaId = P001O6_A27ConquistaId[0];
            A45ConquistaQuantidadeNecessaria = P001O6_A45ConquistaQuantidadeNecessaria[0];
            AV13QuantidadeNecessario = A45ConquistaQuantidadeNecessaria;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
      }

      protected void S131( )
      {
         /* 'VERIFICARDIFERENÇA' Routine */
         if ( AV14Count >= AV13QuantidadeNecessario )
         {
            AV15ConquistaOk = true;
         }
         else
         {
            AV15ConquistaOk = false;
         }
      }

      protected void S141( )
      {
         /* 'BUSCARCONQUISTAUSUARIO' Routine */
         AV16UsuarioConquistaId = 0;
         AV18UsuarioConquistaDataHoraAtual = (DateTime)(DateTime.MinValue);
         /* Using cursor P001O7 */
         pr_default.execute(5, new Object[] {AV12ConquistaId, AV8UsuarioId});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A27ConquistaId = P001O7_A27ConquistaId[0];
            A11UsuarioId = P001O7_A11UsuarioId[0];
            A31UsuarioConquistaDataHora = P001O7_A31UsuarioConquistaDataHora[0];
            A30UsuarioConquistaId = P001O7_A30UsuarioConquistaId[0];
            AV18UsuarioConquistaDataHoraAtual = A31UsuarioConquistaDataHora;
            AV16UsuarioConquistaId = A30UsuarioConquistaId;
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      protected void S151( )
      {
         /* 'GRAVARCONQUISTA' Routine */
         AV19UsuarioConquista.Load(AV16UsuarioConquistaId);
         if ( AV19UsuarioConquista.Fail() )
         {
            AV19UsuarioConquista = new SdtUsuarioConquista(context);
         }
         AV19UsuarioConquista.gxTpr_Usuarioid = AV8UsuarioId;
         AV19UsuarioConquista.gxTpr_Conquistaid = AV12ConquistaId;
         AV19UsuarioConquista.gxTpr_Usuarioconquistadatahora = AV17UsuarioConquistaDataHora;
         AV19UsuarioConquista.Save();
         if ( AV19UsuarioConquista.Fail() )
         {
            new log(context ).execute(  "Erro ao gravar conquista usuário: "+((SdtMessages_Message)AV19UsuarioConquista.GetMessages().Item(1)).gxTpr_Description) ;
            returnInSub = true;
            if (true) return;
         }
         else
         {
            pr_gam.commit( "VerificarConquistasUsuario");
            pr_default.commit( "VerificarConquistasUsuario");
         }
      }

      protected void S161( )
      {
         /* 'CRIARNOTIFICACAO' Routine */
         AV20NotificacaoId = 0;
         /* Using cursor P001O8 */
         pr_default.execute(6, new Object[] {AV12ConquistaId});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A61NotificacaoLigacaoId = P001O8_A61NotificacaoLigacaoId[0];
            n61NotificacaoLigacaoId = P001O8_n61NotificacaoLigacaoId[0];
            A24NotificacaoTipo = P001O8_A24NotificacaoTipo[0];
            A23NotificacaoId = P001O8_A23NotificacaoId[0];
            AV20NotificacaoId = A23NotificacaoId;
            pr_default.readNext(6);
         }
         pr_default.close(6);
         if ( (0==AV20NotificacaoId) )
         {
            AV21Notificacao = new SdtNotificacao(context);
            AV21Notificacao.gxTpr_Notificacaoligacaoid = AV12ConquistaId;
            AV21Notificacao.gxTpr_Usuarioid = AV8UsuarioId;
            AV21Notificacao.gxTpr_Notificacaotipo = 1;
            AV21Notificacao.gxTpr_Notificacaotexto = "Nova conquista desbloqueada!!";
            AV21Notificacao.Save();
            if ( AV21Notificacao.Fail() )
            {
               new log(context ).execute(  "Erro ao gravar notificação: "+((SdtMessages_Message)AV21Notificacao.GetMessages().Item(1)).gxTpr_Description) ;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               pr_gam.commit( "VerificarConquistasUsuario");
               pr_default.commit( "VerificarConquistasUsuario");
            }
         }
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV11ConquistasId = new GxSimpleCollection<long>();
         scmdbuf = "";
         P001O2_AV14Count = new short[1] ;
         AV18UsuarioConquistaDataHoraAtual = (DateTime)(DateTime.MinValue);
         AV17UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         P001O3_A9EpisodioDuracao = new short[1] ;
         P001O4_AV14Count = new short[1] ;
         P001O5_A44ConquistaTipo = new short[1] ;
         P001O5_A27ConquistaId = new long[1] ;
         P001O6_A27ConquistaId = new long[1] ;
         P001O6_A45ConquistaQuantidadeNecessaria = new short[1] ;
         P001O7_A27ConquistaId = new long[1] ;
         P001O7_A11UsuarioId = new long[1] ;
         P001O7_A31UsuarioConquistaDataHora = new DateTime[] {DateTime.MinValue} ;
         P001O7_A30UsuarioConquistaId = new long[1] ;
         A31UsuarioConquistaDataHora = (DateTime)(DateTime.MinValue);
         AV19UsuarioConquista = new SdtUsuarioConquista(context);
         P001O8_A61NotificacaoLigacaoId = new long[1] ;
         P001O8_n61NotificacaoLigacaoId = new bool[] {false} ;
         P001O8_A24NotificacaoTipo = new short[1] ;
         P001O8_A23NotificacaoId = new long[1] ;
         AV21Notificacao = new SdtNotificacao(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.verificarconquistasusuario__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.verificarconquistasusuario__default(),
            new Object[][] {
                new Object[] {
               P001O2_AV14Count
               }
               , new Object[] {
               P001O3_A9EpisodioDuracao
               }
               , new Object[] {
               P001O4_AV14Count
               }
               , new Object[] {
               P001O5_A44ConquistaTipo, P001O5_A27ConquistaId
               }
               , new Object[] {
               P001O6_A27ConquistaId, P001O6_A45ConquistaQuantidadeNecessaria
               }
               , new Object[] {
               P001O7_A27ConquistaId, P001O7_A11UsuarioId, P001O7_A31UsuarioConquistaDataHora, P001O7_A30UsuarioConquistaId
               }
               , new Object[] {
               P001O8_A61NotificacaoLigacaoId, P001O8_n61NotificacaoLigacaoId, P001O8_A24NotificacaoTipo, P001O8_A23NotificacaoId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9TipoConquista ;
      private short AV25I ;
      private short AV14Count ;
      private short cV14Count ;
      private short c9EpisodioDuracao ;
      private short A44ConquistaTipo ;
      private short AV13QuantidadeNecessario ;
      private short A45ConquistaQuantidadeNecessaria ;
      private short A24NotificacaoTipo ;
      private long AV8UsuarioId ;
      private long AV12ConquistaId ;
      private long A27ConquistaId ;
      private long AV16UsuarioConquistaId ;
      private long A11UsuarioId ;
      private long A30UsuarioConquistaId ;
      private long AV20NotificacaoId ;
      private long A61NotificacaoLigacaoId ;
      private long A23NotificacaoId ;
      private String scmdbuf ;
      private DateTime AV18UsuarioConquistaDataHoraAtual ;
      private DateTime AV17UsuarioConquistaDataHora ;
      private DateTime A31UsuarioConquistaDataHora ;
      private bool AV22NovaConquista ;
      private bool returnInSub ;
      private bool AV15ConquistaOk ;
      private bool n61NotificacaoLigacaoId ;
      private GxSimpleCollection<long> AV11ConquistasId ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001O2_AV14Count ;
      private short[] P001O3_A9EpisodioDuracao ;
      private short[] P001O4_AV14Count ;
      private short[] P001O5_A44ConquistaTipo ;
      private long[] P001O5_A27ConquistaId ;
      private long[] P001O6_A27ConquistaId ;
      private short[] P001O6_A45ConquistaQuantidadeNecessaria ;
      private long[] P001O7_A27ConquistaId ;
      private long[] P001O7_A11UsuarioId ;
      private DateTime[] P001O7_A31UsuarioConquistaDataHora ;
      private long[] P001O7_A30UsuarioConquistaId ;
      private IDataStoreProvider pr_gam ;
      private long[] P001O8_A61NotificacaoLigacaoId ;
      private bool[] P001O8_n61NotificacaoLigacaoId ;
      private short[] P001O8_A24NotificacaoTipo ;
      private long[] P001O8_A23NotificacaoId ;
      private bool aP1_NovaConquista ;
      private SdtUsuarioConquista AV19UsuarioConquista ;
      private SdtNotificacao AV21Notificacao ;
   }

   public class verificarconquistasusuario__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class verificarconquistasusuario__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmP001O2 ;
        prmP001O2 = new Object[] {
        new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001O3 ;
        prmP001O3 = new Object[] {
        new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001O4 ;
        prmP001O4 = new Object[] {
        new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001O5 ;
        prmP001O5 = new Object[] {
        new Object[] {"@AV9TipoConquista",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmP001O6 ;
        prmP001O6 = new Object[] {
        new Object[] {"@AV12ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001O7 ;
        prmP001O7 = new Object[] {
        new Object[] {"@AV12ConquistaId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@AV8UsuarioId",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmP001O8 ;
        prmP001O8 = new Object[] {
        new Object[] {"@AV12ConquistaId",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("P001O2", "SELECT COUNT(*) FROM [UsuarioEpisodio] WITH (NOLOCK) WHERE ([UsuarioId] = @AV8UsuarioId) AND ([UsuarioEpisodioAssistido] = 1) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O2,1,0,true,false )
           ,new CursorDef("P001O3", "SELECT SUM(T2.[EpisodioDuracao]) FROM ([UsuarioEpisodio] T1 WITH (NOLOCK) INNER JOIN [Episodio] T2 WITH (NOLOCK) ON T2.[EpisodioId] = T1.[EpisodioId]) WHERE (T1.[UsuarioId] = @AV8UsuarioId) AND (T1.[UsuarioEpisodioAssistido] = 1) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O3,1,0,true,false )
           ,new CursorDef("P001O4", "SELECT COUNT(*) FROM [UsuarioSerie] WITH (NOLOCK) WHERE ([UsuarioId] = @AV8UsuarioId) AND ([UsuarioSerieAssistida] = 1) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O4,1,0,true,false )
           ,new CursorDef("P001O5", "SELECT [ConquistaTipo], [ConquistaId] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaTipo] = @AV9TipoConquista ORDER BY [ConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O5,100,0,false,false )
           ,new CursorDef("P001O6", "SELECT [ConquistaId], [ConquistaQuantidadeNecessaria] FROM [Conquista] WITH (NOLOCK) WHERE [ConquistaId] = @AV12ConquistaId ORDER BY [ConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O6,1,0,false,true )
           ,new CursorDef("P001O7", "SELECT [ConquistaId], [UsuarioId], [UsuarioConquistaDataHora], [UsuarioConquistaId] FROM [UsuarioConquista] WITH (NOLOCK) WHERE ([ConquistaId] = @AV12ConquistaId) AND ([UsuarioId] = @AV8UsuarioId) ORDER BY [ConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O7,100,0,false,false )
           ,new CursorDef("P001O8", "SELECT [NotificacaoLigacaoId], [NotificacaoTipo], [NotificacaoId] FROM [Notificacao] WITH (NOLOCK) WHERE ([NotificacaoTipo] = 1) AND ([NotificacaoLigacaoId] = @AV12ConquistaId) ORDER BY [NotificacaoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O8,100,0,false,false )
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
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((long[]) buf[3])[0] = rslt.getLong(4) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((short[]) buf[2])[0] = rslt.getShort(2) ;
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
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
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

[ServiceContract(Namespace = "GeneXus.Programs.verificarconquistasusuario_services")]
[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class verificarconquistasusuario_services : GxRestService
{
   [OperationContract]
   [WebInvoke(Method =  "POST" ,
   	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
   	ResponseFormat = WebMessageFormat.Json,
   	UriTemplate = "/")]
   public void execute( String UsuarioId ,
                        out bool NovaConquista )
   {
      NovaConquista = false ;
      try
      {
         if ( ! ProcessHeaders("verificarconquistasusuario") )
         {
            return  ;
         }
         verificarconquistasusuario worker = new verificarconquistasusuario(context) ;
         worker.IsMain = RunAsMain ;
         long gxrUsuarioId ;
         gxrUsuarioId = (long)(NumberUtil.Val( (String)(UsuarioId), "."));
         worker.execute(gxrUsuarioId,out NovaConquista );
         worker.cleanup( );
      }
      catch ( Exception e )
      {
         WebException(e);
      }
      finally
      {
         Cleanup();
      }
   }

}

}
