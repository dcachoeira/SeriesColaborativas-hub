/*
               File: WorkWithDevicesEpisodio_Episodio_Section_General
        Description: WorkWithDevicesEpisodio_Episodio_Section_General
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 19:40:19.15
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
   public class workwithdevicesepisodio_episodio_section_general : GXProcedure
   {
      public workwithdevicesepisodio_episodio_section_general( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public workwithdevicesepisodio_episodio_section_general( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_EpisodioId ,
                           int aP1_gxid ,
                           out SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt )
      {
         this.A7EpisodioId = aP0_EpisodioId;
         this.AV15gxid = aP1_gxid;
         this.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt=this.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt;
      }

      public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt executeUdp( long aP0_EpisodioId ,
                                                                                int aP1_gxid )
      {
         this.A7EpisodioId = aP0_EpisodioId;
         this.AV15gxid = aP1_gxid;
         this.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt(context) ;
         initialize();
         executePrivate();
         aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt=this.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt;
         return AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt ;
      }

      public void executeSubmit( long aP0_EpisodioId ,
                                 int aP1_gxid ,
                                 out SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt )
      {
         workwithdevicesepisodio_episodio_section_general objworkwithdevicesepisodio_episodio_section_general;
         objworkwithdevicesepisodio_episodio_section_general = new workwithdevicesepisodio_episodio_section_general();
         objworkwithdevicesepisodio_episodio_section_general.A7EpisodioId = aP0_EpisodioId;
         objworkwithdevicesepisodio_episodio_section_general.AV15gxid = aP1_gxid;
         objworkwithdevicesepisodio_episodio_section_general.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt(context) ;
         objworkwithdevicesepisodio_episodio_section_general.context.SetSubmitInitialConfig(context);
         objworkwithdevicesepisodio_episodio_section_general.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objworkwithdevicesepisodio_episodio_section_general);
         aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt=this.AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((workwithdevicesepisodio_episodio_section_general)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV15gxid), 8, 0);
         if ( StringUtil.StrCmp(Gxwebsession.Get(Gxids), "") == 0 )
         {
            Gxwebsession.Set(Gxids+"gxvar_Notaimage", AV21Notaimage_GXI);
            Gxwebsession.Set(Gxids+"gxvar_Duracao", AV11Duracao);
            Gxwebsession.Set(Gxids+"gxvar_Temporada", AV10temporada);
            Gxwebsession.Set(Gxids, "true");
         }
         else
         {
            AV10temporada = Gxwebsession.Get(Gxids+"gxvar_Temporada");
            AV11Duracao = Gxwebsession.Get(Gxids+"gxvar_Duracao");
            AV21Notaimage_GXI = Gxwebsession.Get(Gxids+"gxvar_Notaimage");
            AV13notaImage = "";
         }
         /* Using cursor P00002 */
         pr_default.execute(0, new Object[] {A7EpisodioId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A42EpisodioTemporada = P00002_A42EpisodioTemporada[0];
            A9EpisodioDuracao = P00002_A9EpisodioDuracao[0];
            A2SerieNome = P00002_A2SerieNome[0];
            A8EpisodioNome = P00002_A8EpisodioNome[0];
            A10EpisodioSinopse = P00002_A10EpisodioSinopse[0];
            A1SerieId = P00002_A1SerieId[0];
            A2SerieNome = P00002_A2SerieNome[0];
            while ( (pr_default.getStatus(0) != 101) && ( P00002_A7EpisodioId[0] == A7EpisodioId ) )
            {
               A42EpisodioTemporada = P00002_A42EpisodioTemporada[0];
               A9EpisodioDuracao = P00002_A9EpisodioDuracao[0];
               AV10temporada = StringUtil.Trim( StringUtil.Str( (decimal)(A42EpisodioTemporada), 4, 0)) + "ª temporada";
               AV11Duracao = StringUtil.Trim( StringUtil.Str( (decimal)(A9EpisodioDuracao), 3, 0)) + " minutos";
               new obternotaepisodio(context ).execute(  A7EpisodioId, out  AV14Nota) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            if ( AV14Nota == 1 )
            {
               AV13notaImage = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
               AV21Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
            }
            else if ( AV14Nota == 2 )
            {
               AV13notaImage = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
               AV21Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
            }
            else if ( AV14Nota == 3 )
            {
               AV13notaImage = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
               AV21Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
            }
            else if ( AV14Nota == 4 )
            {
               AV13notaImage = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
               AV21Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
            }
            else if ( AV14Nota == 5 )
            {
               AV13notaImage = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
               AV21Notaimage_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
            }
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Episodioid = A7EpisodioId;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Serienome = A2SerieNome;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Episodionome = A8EpisodioNome;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Episodiosinopse = A10EpisodioSinopse;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Serieid = A1SerieId;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Notaimage = AV13notaImage;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Notaimage_gxi = AV21Notaimage_GXI;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Duracao = AV11Duracao;
            AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.gxTpr_Temporada = AV10temporada;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         Gxwebsession.Set(Gxids+"gxvar_Temporada", AV10temporada);
         Gxwebsession.Set(Gxids+"gxvar_Duracao", AV11Duracao);
         Gxwebsession.Set(Gxids+"gxvar_Notaimage", AV21Notaimage_GXI);
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
         Gxids = "";
         Gxwebsession = context.GetSession();
         AV21Notaimage_GXI = "";
         AV11Duracao = "";
         AV10temporada = "";
         AV13notaImage = "";
         scmdbuf = "";
         P00002_A7EpisodioId = new long[1] ;
         P00002_A42EpisodioTemporada = new short[1] ;
         P00002_A9EpisodioDuracao = new short[1] ;
         P00002_A2SerieNome = new String[] {""} ;
         P00002_A8EpisodioNome = new String[] {""} ;
         P00002_A10EpisodioSinopse = new String[] {""} ;
         P00002_A1SerieId = new long[1] ;
         A2SerieNome = "";
         A8EpisodioNome = "";
         A10EpisodioSinopse = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.workwithdevicesepisodio_episodio_section_general__default(),
            new Object[][] {
                new Object[] {
               P00002_A7EpisodioId, P00002_A42EpisodioTemporada, P00002_A9EpisodioDuracao, P00002_A2SerieNome, P00002_A8EpisodioNome, P00002_A10EpisodioSinopse, P00002_A1SerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A42EpisodioTemporada ;
      private short A9EpisodioDuracao ;
      private short AV14Nota ;
      private int AV15gxid ;
      private long A7EpisodioId ;
      private long A1SerieId ;
      private String Gxids ;
      private String scmdbuf ;
      private String A10EpisodioSinopse ;
      private String AV21Notaimage_GXI ;
      private String AV11Duracao ;
      private String AV10temporada ;
      private String A2SerieNome ;
      private String A8EpisodioNome ;
      private String AV13notaImage ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00002_A7EpisodioId ;
      private short[] P00002_A42EpisodioTemporada ;
      private short[] P00002_A9EpisodioDuracao ;
      private String[] P00002_A2SerieNome ;
      private String[] P00002_A8EpisodioNome ;
      private String[] P00002_A10EpisodioSinopse ;
      private long[] P00002_A1SerieId ;
      private SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt aP2_GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt ;
      private IGxSession Gxwebsession ;
      private SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt AV18GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt ;
   }

   public class workwithdevicesepisodio_episodio_section_general__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00002 ;
          prmP00002 = new Object[] {
          new Object[] {"@EpisodioId",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00002", "SELECT T1.[EpisodioId], T1.[EpisodioTemporada], T1.[EpisodioDuracao], T2.[SerieNome], T1.[EpisodioNome], T1.[EpisodioSinopse], T1.[SerieId] FROM ([Episodio] T1 WITH (NOLOCK) INNER JOIN [Serie] T2 WITH (NOLOCK) ON T2.[SerieId] = T1.[SerieId]) WHERE T1.[EpisodioId] = @EpisodioId ORDER BY T1.[EpisodioId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00002,1,0,true,true )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
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
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.workwithdevicesepisodio_episodio_section_general_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class workwithdevicesepisodio_episodio_section_general_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/?EpisodioId={EpisodioId}&gxid={gxid}")]
    public SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface execute( String EpisodioId ,
                                                                                         String gxid )
    {
       SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface() ;
       try
       {
          if ( ! ProcessHeaders("workwithdevicesepisodio_episodio_section_general") )
          {
             return null ;
          }
          workwithdevicesepisodio_episodio_section_general worker = new workwithdevicesepisodio_episodio_section_general(context) ;
          worker.IsMain = RunAsMain ;
          long gxrEpisodioId ;
          gxrEpisodioId = (long)(NumberUtil.Val( (String)(EpisodioId), "."));
          int gxrgxid ;
          gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
          SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt gxrGXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.sdt ;
          worker.execute(gxrEpisodioId,gxrgxid,out gxrGXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt );
          worker.cleanup( );
          GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt = new SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt_RESTInterface(gxrGXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt) ;
          return GXM1WorkWithDevicesEpisodio_Episodio_Section_GeneralSdt ;
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
