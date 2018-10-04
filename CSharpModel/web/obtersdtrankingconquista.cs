/*
               File: ObterSDTRankingConquista
        Description: Obter SDTRanking Conquista
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/13/2018 17:36:55.27
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
   public class obtersdtrankingconquista : GXProcedure
   {
      public obtersdtrankingconquista( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public obtersdtrankingconquista( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<SdtSDTRanking_Item> aP0_SDTRanking )
      {
         this.AV10SDTRanking = new GXBaseCollection<SdtSDTRanking_Item>( context, "Item", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_SDTRanking=this.AV10SDTRanking;
      }

      public GXBaseCollection<SdtSDTRanking_Item> executeUdp( )
      {
         this.AV10SDTRanking = new GXBaseCollection<SdtSDTRanking_Item>( context, "Item", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_SDTRanking=this.AV10SDTRanking;
         return AV10SDTRanking ;
      }

      public void executeSubmit( out GXBaseCollection<SdtSDTRanking_Item> aP0_SDTRanking )
      {
         obtersdtrankingconquista objobtersdtrankingconquista;
         objobtersdtrankingconquista = new obtersdtrankingconquista();
         objobtersdtrankingconquista.AV10SDTRanking = new GXBaseCollection<SdtSDTRanking_Item>( context, "Item", "SeriesColaborativas") ;
         objobtersdtrankingconquista.context.SetSubmitInitialConfig(context);
         objobtersdtrankingconquista.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objobtersdtrankingconquista);
         aP0_SDTRanking=this.AV10SDTRanking;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((obtersdtrankingconquista)stateInfo).executePrivate();
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
         /* Using cursor P001E2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A11UsuarioId = P001E2_A11UsuarioId[0];
            AV8UsuariosId.Add(A11UsuarioId, 0);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV10SDTRanking = new GXBaseCollection<SdtSDTRanking_Item>( context, "Item", "SeriesColaborativas");
         AV9i = 1;
         while ( AV9i <= AV8UsuariosId.Count )
         {
            AV12QuantidadePontos = 0;
            AV11SDTRankingItem = new SdtSDTRanking_Item(context);
            /* Using cursor P001E3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               A27ConquistaId = P001E3_A27ConquistaId[0];
               A11UsuarioId = P001E3_A11UsuarioId[0];
               A12UsuarioNome = P001E3_A12UsuarioNome[0];
               A28ConquistaPontos = P001E3_A28ConquistaPontos[0];
               A30UsuarioConquistaId = P001E3_A30UsuarioConquistaId[0];
               A28ConquistaPontos = P001E3_A28ConquistaPontos[0];
               A12UsuarioNome = P001E3_A12UsuarioNome[0];
               if ( A11UsuarioId == AV8UsuariosId.GetNumeric(AV9i) )
               {
                  AV11SDTRankingItem.gxTpr_Usuarionome = A12UsuarioNome;
                  AV12QuantidadePontos = (long)(AV12QuantidadePontos+A28ConquistaPontos);
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            AV11SDTRankingItem.gxTpr_Quantidadepontos = AV12QuantidadePontos;
            AV10SDTRanking.Add(AV11SDTRankingItem, 0);
            AV9i = (short)(AV9i+1);
         }
         AV10SDTRanking.Sort("QuantidadePontos");
         this.cleanup();
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
         scmdbuf = "";
         P001E2_A11UsuarioId = new long[1] ;
         AV8UsuariosId = new GxSimpleCollection<long>();
         AV11SDTRankingItem = new SdtSDTRanking_Item(context);
         P001E3_A27ConquistaId = new long[1] ;
         P001E3_A11UsuarioId = new long[1] ;
         P001E3_A12UsuarioNome = new String[] {""} ;
         P001E3_A28ConquistaPontos = new short[1] ;
         P001E3_A30UsuarioConquistaId = new long[1] ;
         A12UsuarioNome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.obtersdtrankingconquista__default(),
            new Object[][] {
                new Object[] {
               P001E2_A11UsuarioId
               }
               , new Object[] {
               P001E3_A27ConquistaId, P001E3_A11UsuarioId, P001E3_A12UsuarioNome, P001E3_A28ConquistaPontos, P001E3_A30UsuarioConquistaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9i ;
      private short A28ConquistaPontos ;
      private long A11UsuarioId ;
      private long AV12QuantidadePontos ;
      private long A27ConquistaId ;
      private long A30UsuarioConquistaId ;
      private String scmdbuf ;
      private String A12UsuarioNome ;
      private GxSimpleCollection<long> AV8UsuariosId ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001E2_A11UsuarioId ;
      private long[] P001E3_A27ConquistaId ;
      private long[] P001E3_A11UsuarioId ;
      private String[] P001E3_A12UsuarioNome ;
      private short[] P001E3_A28ConquistaPontos ;
      private long[] P001E3_A30UsuarioConquistaId ;
      private GXBaseCollection<SdtSDTRanking_Item> aP0_SDTRanking ;
      private GXBaseCollection<SdtSDTRanking_Item> AV10SDTRanking ;
      private SdtSDTRanking_Item AV11SDTRankingItem ;
   }

   public class obtersdtrankingconquista__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001E2 ;
          prmP001E2 = new Object[] {
          } ;
          Object[] prmP001E3 ;
          prmP001E3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P001E2", "SELECT DISTINCT [UsuarioId] FROM [UsuarioConquista] WITH (NOLOCK) ORDER BY [UsuarioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E2,100,0,false,false )
             ,new CursorDef("P001E3", "SELECT T1.[ConquistaId], T1.[UsuarioId], T3.[UsuarioNome], T2.[ConquistaPontos], T1.[UsuarioConquistaId] FROM (([UsuarioConquista] T1 WITH (NOLOCK) INNER JOIN [Conquista] T2 WITH (NOLOCK) ON T2.[ConquistaId] = T1.[ConquistaId]) INNER JOIN [Usuario] T3 WITH (NOLOCK) ON T3.[UsuarioId] = T1.[UsuarioId]) ORDER BY T1.[UsuarioConquistaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001E3,100,0,false,false )
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
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                return;
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

 }

 [ServiceContract(Namespace = "GeneXus.Programs.obtersdtrankingconquista_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class obtersdtrankingconquista_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( out GxGenericCollection<SdtSDTRanking_Item_RESTInterface> SDTRanking )
    {
       SDTRanking = new GxGenericCollection<SdtSDTRanking_Item_RESTInterface>() ;
       try
       {
          if ( ! ProcessHeaders("obtersdtrankingconquista") )
          {
             return  ;
          }
          obtersdtrankingconquista worker = new obtersdtrankingconquista(context) ;
          worker.IsMain = RunAsMain ;
          GXBaseCollection<SdtSDTRanking_Item> gxrSDTRanking = new GXBaseCollection<SdtSDTRanking_Item>() ;
          worker.execute(out gxrSDTRanking );
          worker.cleanup( );
          SDTRanking = new GxGenericCollection<SdtSDTRanking_Item_RESTInterface>(gxrSDTRanking) ;
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
