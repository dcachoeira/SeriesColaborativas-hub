/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:5:35.60
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public reorg( IGxContext context )
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

      void executePrivate( )
      {
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void ReorganizeSerie( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Serie */
         cmdBuffer=" ALTER TABLE [Serie] ADD [SerieDataHoraCadastro]  datetime NOT NULL CONSTRAINT SerieDataHoraCadastroSerie_DEFAULT DEFAULT convert( DATETIME, '17530101', 112 ) "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         cmdBuffer=" ALTER TABLE [Serie] DROP CONSTRAINT SerieDataHoraCadastroSerie_DEFAULT "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      public void ReorganizeNotificacao( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Notificacao */
         cmdBuffer=" ALTER TABLE [Notificacao] ADD [NotificacaoLigacaoId]  decimal( 18) NULL  "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
      }

      private void TablesCount( )
      {
         if ( ! IsResumeMode( ) )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            SerieCount = P00012_ASerieCount[0];
            pr_default.close(0);
            PrintRecordCount ( "Serie" ,  SerieCount );
            /* Using cursor P00023 */
            pr_default.execute(1);
            NotificacaoCount = P00023_ANotificacaoCount[0];
            pr_default.close(1);
            PrintRecordCount ( "Notificacao" ,  NotificacaoCount );
         }
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00034 */
            pr_default.execute(2);
            while ( (pr_default.getStatus(2) != 101) )
            {
               sSchemaVar = P00034_AsSchemaVar[0];
               nsSchemaVar = P00034_nsSchemaVar[0];
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         else
         {
            /* Using cursor P00045 */
            pr_default.execute(3);
            while ( (pr_default.getStatus(3) != 101) )
            {
               sSchemaVar = P00045_AsSchemaVar[0];
               nsSchemaVar = P00045_nsSchemaVar[0];
               pr_default.readNext(3);
            }
            pr_default.close(3);
         }
         if ( ColumnExist("Serie",sSchemaVar,"SerieDataHoraCadastro") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"SerieDataHoraCadastro", "Serie"}) ) ;
            return false ;
         }
         if ( ColumnExist("Notificacao",sSchemaVar,"NotificacaoLigacaoId") )
         {
            SetCheckError ( GXResourceManager.GetMessage("GXM_column_exist", new   object[]  {"NotificacaoLigacaoId", "Notificacao"}) ) ;
            return false ;
         }
         return true ;
      }

      private bool ColumnExist( String sTableName ,
                                String sMySchemaName ,
                                String sMyColumnName )
      {
         bool result ;
         result = false;
         /* Using cursor P00056 */
         pr_default.execute(4, new Object[] {sTableName, sMySchemaName, sMyColumnName});
         while ( (pr_default.getStatus(4) != 101) )
         {
            tablename = P00056_Atablename[0];
            ntablename = P00056_ntablename[0];
            schemaname = P00056_Aschemaname[0];
            nschemaname = P00056_nschemaname[0];
            columnname = P00056_Acolumnname[0];
            ncolumnname = P00056_ncolumnname[0];
            result = true;
            pr_default.readNext(4);
         }
         pr_default.close(4);
         return result ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "ReorganizeSerie" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "ReorganizeNotificacao" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Serie", ""}) );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_fileupdate", new   object[]  {"Notificacao", ""}) );
      }

      private void SetPrecedenceris( )
      {
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00012_ASerieCount = new int[1] ;
         P00023_ANotificacaoCount = new int[1] ;
         sSchemaVar = "";
         nsSchemaVar = false;
         P00034_AsSchemaVar = new String[] {""} ;
         P00034_nsSchemaVar = new bool[] {false} ;
         P00045_AsSchemaVar = new String[] {""} ;
         P00045_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         sMySchemaName = "";
         sMyColumnName = "";
         tablename = "";
         ntablename = false;
         schemaname = "";
         nschemaname = false;
         columnname = "";
         ncolumnname = false;
         P00056_Atablename = new String[] {""} ;
         P00056_ntablename = new bool[] {false} ;
         P00056_Aschemaname = new String[] {""} ;
         P00056_nschemaname = new bool[] {false} ;
         P00056_Acolumnname = new String[] {""} ;
         P00056_ncolumnname = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_ASerieCount
               }
               , new Object[] {
               P00023_ANotificacaoCount
               }
               , new Object[] {
               P00034_AsSchemaVar
               }
               , new Object[] {
               P00045_AsSchemaVar
               }
               , new Object[] {
               P00056_Atablename, P00056_Aschemaname, P00056_Acolumnname
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected int SerieCount ;
      protected int NotificacaoCount ;
      protected String scmdbuf ;
      protected String sSchemaVar ;
      protected String sTableName ;
      protected String sMySchemaName ;
      protected String sMyColumnName ;
      protected bool nsSchemaVar ;
      protected bool ntablename ;
      protected bool nschemaname ;
      protected bool ncolumnname ;
      protected String tablename ;
      protected String schemaname ;
      protected String columnname ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected int[] P00012_ASerieCount ;
      protected int[] P00023_ANotificacaoCount ;
      protected String[] P00034_AsSchemaVar ;
      protected bool[] P00034_nsSchemaVar ;
      protected String[] P00045_AsSchemaVar ;
      protected bool[] P00045_nsSchemaVar ;
      protected String[] P00056_Atablename ;
      protected bool[] P00056_ntablename ;
      protected String[] P00056_Aschemaname ;
      protected bool[] P00056_nschemaname ;
      protected String[] P00056_Acolumnname ;
      protected bool[] P00056_ncolumnname ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          } ;
          Object[] prmP00045 ;
          prmP00045 = new Object[] {
          } ;
          Object[] prmP00056 ;
          prmP00056 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMySchemaName",SqlDbType.Char,255,0} ,
          new Object[] {"@sMyColumnName",SqlDbType.Char,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT COUNT(*) FROM [Serie] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00023", "SELECT COUNT(*) FROM [Notificacao] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100,0,true,false )
             ,new CursorDef("P00034", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100,0,true,false )
             ,new CursorDef("P00045", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00045,100,0,true,false )
             ,new CursorDef("P00056", "SELECT TABLE_NAME, TABLE_SCHEMA, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE (TABLE_NAME = @sTableName) AND (TABLE_SCHEMA = @sMySchemaName) AND (COLUMN_NAME = @sMyColumnName) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00056,100,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
       }
    }

 }

}
