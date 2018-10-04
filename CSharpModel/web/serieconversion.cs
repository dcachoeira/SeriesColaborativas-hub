/*
               File: SerieConversion
        Description: Conversion for table Serie
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:29:9.3
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
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class serieconversion : GXProcedure
   {
      public serieconversion( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public serieconversion( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         serieconversion objserieconversion;
         objserieconversion = new serieconversion();
         objserieconversion.context.SetSubmitInitialConfig(context);
         objserieconversion.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objserieconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((serieconversion)stateInfo).executePrivate();
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor SERIECONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A48GeneroId = SERIECONVE2_A48GeneroId[0];
            A47SerieInativo = SERIECONVE2_A47SerieInativo[0];
            A6SerieResumo = SERIECONVE2_A6SerieResumo[0];
            A3SerieQuantidadeTemporadas = SERIECONVE2_A3SerieQuantidadeTemporadas[0];
            A2SerieNome = SERIECONVE2_A2SerieNome[0];
            A1SerieId = SERIECONVE2_A1SerieId[0];
            A43SerieImagem = SERIECONVE2_A43SerieImagem[0];
            /*
               INSERT RECORD ON TABLE GXA0001

            */
            AV2SerieId = A1SerieId;
            AV3SerieNome = A2SerieNome;
            AV4SerieQuantidadeTemporadas = A3SerieQuantidadeTemporadas;
            AV5SerieResumo = A6SerieResumo;
            AV6SerieImagem = A43SerieImagem;
            AV7SerieImagem_GXI = GXDbFile.GetUriFromFile( "", "png", A43SerieImagem);
            AV7SerieImagem_GXI = GXDbFile.GetUriFromFile( "", "png", "");
            AV8SerieInativo = A47SerieInativo;
            AV9GeneroId = A48GeneroId;
            /* Using cursor SERIECONVE3 */
            pr_default.execute(1, new Object[] {AV2SerieId, AV3SerieNome, AV4SerieQuantidadeTemporadas, AV5SerieResumo, AV6SerieImagem, AV7SerieImagem_GXI, AV8SerieInativo, AV9GeneroId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("GXA0001") ;
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate"));
            }
            else
            {
               context.Gx_err = 0;
               Gx_emsg = "";
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         cmdBuffer=" SET IDENTITY_INSERT [GXA0001] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
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
         cmdBuffer = "";
         scmdbuf = "";
         SERIECONVE2_A48GeneroId = new long[1] ;
         SERIECONVE2_A47SerieInativo = new bool[] {false} ;
         SERIECONVE2_A6SerieResumo = new String[] {""} ;
         SERIECONVE2_A3SerieQuantidadeTemporadas = new short[1] ;
         SERIECONVE2_A2SerieNome = new String[] {""} ;
         SERIECONVE2_A1SerieId = new long[1] ;
         SERIECONVE2_A43SerieImagem = new String[] {""} ;
         A6SerieResumo = "";
         A2SerieNome = "";
         A43SerieImagem = "";
         AV3SerieNome = "";
         AV5SerieResumo = "";
         AV6SerieImagem = "";
         AV7SerieImagem_GXI = "";
         Gx_emsg = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.serieconversion__default(),
            new Object[][] {
                new Object[] {
               SERIECONVE2_A48GeneroId, SERIECONVE2_A47SerieInativo, SERIECONVE2_A6SerieResumo, SERIECONVE2_A3SerieQuantidadeTemporadas, SERIECONVE2_A2SerieNome, SERIECONVE2_A1SerieId, SERIECONVE2_A43SerieImagem
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A3SerieQuantidadeTemporadas ;
      private short AV4SerieQuantidadeTemporadas ;
      private int GIGXA0001 ;
      private long A48GeneroId ;
      private long A1SerieId ;
      private long AV2SerieId ;
      private long AV9GeneroId ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private bool A47SerieInativo ;
      private bool AV8SerieInativo ;
      private String A6SerieResumo ;
      private String AV5SerieResumo ;
      private String A2SerieNome ;
      private String AV3SerieNome ;
      private String AV7SerieImagem_GXI ;
      private String AV6SerieImagem ;
      private String A43SerieImagem ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private long[] SERIECONVE2_A48GeneroId ;
      private bool[] SERIECONVE2_A47SerieInativo ;
      private String[] SERIECONVE2_A6SerieResumo ;
      private short[] SERIECONVE2_A3SerieQuantidadeTemporadas ;
      private String[] SERIECONVE2_A2SerieNome ;
      private long[] SERIECONVE2_A1SerieId ;
      private String[] SERIECONVE2_A43SerieImagem ;
   }

   public class serieconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmSERIECONVE2 ;
          prmSERIECONVE2 = new Object[] {
          } ;
          Object[] prmSERIECONVE3 ;
          prmSERIECONVE3 = new Object[] {
          new Object[] {"@AV2SerieId",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV3SerieNome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV4SerieQuantidadeTemporadas",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5SerieResumo",SqlDbType.VarChar,2097152,0} ,
          new Object[] {"@AV6SerieImagem",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@AV7SerieImagem_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@AV8SerieInativo",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV9GeneroId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SERIECONVE2", "SELECT [GeneroId], [SerieInativo], [SerieResumo], [SerieQuantidadeTemporadas], [SerieNome], [SerieId], [SerieImagem] FROM [Serie] ORDER BY [SerieId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSERIECONVE2,100,0,true,false )
             ,new CursorDef("SERIECONVE3", "INSERT INTO [GXA0001]([SerieId], [SerieNome], [SerieQuantidadeTemporadas], [SerieResumo], [SerieImagem], [SerieImagem_GXI], [SerieInativo], [GeneroId]) VALUES(@AV2SerieId, @AV3SerieNome, @AV4SerieQuantidadeTemporadas, @AV5SerieResumo, @AV6SerieImagem, @AV7SerieImagem_GXI, @AV8SerieInativo, @AV9GeneroId)", GxErrorMask.GX_NOMASK,prmSERIECONVE3)
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
                ((bool[]) buf[1])[0] = rslt.getBool(2) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((long[]) buf[5])[0] = rslt.getLong(6) ;
                ((String[]) buf[6])[0] = rslt.getBLOBFile(7, "png", "") ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameterBlob(5, (String)parms[4], false);
                stmt.SetParameterMultimedia(6, (String)parms[5], (String)parms[4], "GXA0001", "SerieImagem");
                stmt.SetParameter(7, (bool)parms[6]);
                stmt.SetParameter(8, (long)parms[7]);
                return;
       }
    }

 }

}
