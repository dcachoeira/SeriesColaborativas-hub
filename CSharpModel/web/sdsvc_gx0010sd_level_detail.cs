/*
               File: sdsvc_Gx0010sd_Level_Detail
        Description: sdsvc_Gx0010sd_Level_Detail
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:7:2.44
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.Http;
using GeneXus.Procedure;
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
   public class sdsvc_gx0010sd_level_detail : GXProcedure
   {
      public sdsvc_gx0010sd_level_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public sdsvc_gx0010sd_level_detail( IGxContext context )
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
         executePrivate();
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         this.cleanup();
      }

      protected void S111( )
      {
         /* AfterFilterGeneroId Routine */
         /* Using cursor SDSVC_GX002 */
         pr_default.execute(0, new Object[] {AV1Pmpt_generoid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A48GeneroId = SDSVC_GX002_A48GeneroId[0];
            A49GeneroNome = SDSVC_GX002_A49GeneroNome[0];
            AV2Pmpt_generonome = A49GeneroNome;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      public GxUnknownObjectCollection AfterFilterGeneroId( long A48GeneroId )
      {
         initialize();
         AV1Pmpt_generoid = A48GeneroId;
         /* Execute user subroutine: AfterFilterGeneroId */
         S111 ();
         GxUnknownObjectCollection gxjsonarray = new GxUnknownObjectCollection() ;
         gxjsonarray.Add(AV2Pmpt_generonome);
         /* End function AfterFilterGeneroId */
         return gxjsonarray ;
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
         SDSVC_GX002_A48GeneroId = new long[1] ;
         SDSVC_GX002_A49GeneroNome = new String[] {""} ;
         A49GeneroNome = "";
         AV2Pmpt_generonome = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sdsvc_gx0010sd_level_detail__default(),
            new Object[][] {
                new Object[] {
               SDSVC_GX002_A48GeneroId, SDSVC_GX002_A49GeneroNome
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected long AV1Pmpt_generoid ;
      protected long A48GeneroId ;
      protected String scmdbuf ;
      protected String A49GeneroNome ;
      protected String AV2Pmpt_generonome ;
      protected IGxDataStore dsGAM ;
      protected IGxDataStore dsDefault ;
      protected IDataStoreProvider pr_default ;
      protected long[] SDSVC_GX002_A48GeneroId ;
      protected String[] SDSVC_GX002_A49GeneroNome ;
   }

   public class sdsvc_gx0010sd_level_detail__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmSDSVC_GX002 ;
          prmSDSVC_GX002 = new Object[] {
          new Object[] {"@AV1Pmpt_generoid",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SDSVC_GX002", "SELECT [GeneroId], [GeneroNome] FROM [Genero] WITH (NOLOCK) WHERE [GeneroId] = @AV1Pmpt_generoid ORDER BY [GeneroId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSDSVC_GX002,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.sdsvc_gx0010sd_level_detail_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class sdsvc_gx0010sd_level_detail_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/AfterFilterGeneroId?GeneroId={GeneroId}")]
    public GxUnknownObjectCollection AfterFilterGeneroId( String GeneroId )
    {
       try
       {
          if ( ! ProcessHeaders("sdsvc_gx0010sd_level_detail") )
          {
             return null ;
          }
          sdsvc_gx0010sd_level_detail worker = new sdsvc_gx0010sd_level_detail(context) ;
          long gxrGeneroId ;
          gxrGeneroId = (long)(NumberUtil.Val( (String)(GeneroId), "."));
          return  worker.AfterFilterGeneroId(gxrGeneroId );
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
