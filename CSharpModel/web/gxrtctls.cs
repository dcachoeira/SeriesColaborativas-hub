/*
               File: GXRTCtls
        Description: Run time reorganization controls
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/16/2018 21:10:2.98
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
   public class gxrtctls : GXProcedure
   {
      public gxrtctls( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public gxrtctls( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_Status )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      public short executeUdp( )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
         return AV2Status ;
      }

      public void executeSubmit( out short aP0_Status )
      {
         gxrtctls objgxrtctls;
         objgxrtctls = new gxrtctls();
         objgxrtctls.AV2Status = 0 ;
         objgxrtctls.context.SetSubmitInitialConfig(context);
         objgxrtctls.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgxrtctls);
         aP0_Status=this.AV2Status;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gxrtctls)stateInfo).executePrivate();
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
         AV2Status = 0;
         Console.WriteLine( "=== Starting run time controls" );
         Console.WriteLine( "Searching Usuario for duplicate values on new unique index on UsuarioLogin" );
         /* Using cursor LTCTLS2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRKR012 = false;
            A54UsuarioLogin = LTCTLS2_A54UsuarioLogin[0];
            A11UsuarioId = LTCTLS2_A11UsuarioId[0];
            AV3Count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(LTCTLS2_A54UsuarioLogin[0], A54UsuarioLogin) == 0 ) )
            {
               BRKR012 = false;
               A11UsuarioId = LTCTLS2_A11UsuarioId[0];
               if ( AV3Count != 0 )
               {
                  AV2Status = 1;
                  Console.WriteLine( "Fail: Duplicates found. The first non unique value found follows." );
                  Console.WriteLine( "UsuarioLogin: "+StringUtil.RTrim( A54UsuarioLogin) );
                  Console.WriteLine( "Recovery: See recovery information for reorganization message rgz0020." );
                  /* Exit For each command. Update data (if necessary), close cursors & exit. */
                  if (true) break;
               }
               AV3Count = (int)(AV3Count+1);
               BRKR012 = true;
               pr_default.readNext(0);
            }
            if ( AV2Status != 0 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRKR012 )
            {
               BRKR012 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         if ( AV2Status == 0 )
         {
            Console.WriteLine( "Success: No duplicates found for UsuarioLogin" );
         }
         Console.WriteLine( "====================" );
         Console.WriteLine( "=== End of run time controls" );
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
         LTCTLS2_A54UsuarioLogin = new String[] {""} ;
         LTCTLS2_A11UsuarioId = new long[1] ;
         A54UsuarioLogin = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrtctls__default(),
            new Object[][] {
                new Object[] {
               LTCTLS2_A54UsuarioLogin, LTCTLS2_A11UsuarioId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV2Status ;
      private int AV3Count ;
      private long A11UsuarioId ;
      private String scmdbuf ;
      private bool BRKR012 ;
      private String A54UsuarioLogin ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] LTCTLS2_A54UsuarioLogin ;
      private long[] LTCTLS2_A11UsuarioId ;
      private short aP0_Status ;
   }

   public class gxrtctls__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmLTCTLS2 ;
          prmLTCTLS2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("LTCTLS2", "SELECT [UsuarioLogin], [UsuarioId] FROM [Usuario] ORDER BY [UsuarioLogin] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS2,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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

}
