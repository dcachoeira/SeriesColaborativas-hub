/*
               File: SerieWWGetFilterData
        Description: Serie WWGet Filter Data
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/25/2018 19:6:8.6
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
   public class seriewwgetfilterdata : GXProcedure
   {
      public seriewwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public seriewwgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV17DDOName = aP0_DDOName;
         this.AV15SearchTxt = aP1_SearchTxt;
         this.AV16SearchTxtTo = aP2_SearchTxtTo;
         this.AV21OptionsJson = "" ;
         this.AV24OptionsDescJson = "" ;
         this.AV26OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV17DDOName = aP0_DDOName;
         this.AV15SearchTxt = aP1_SearchTxt;
         this.AV16SearchTxtTo = aP2_SearchTxtTo;
         this.AV21OptionsJson = "" ;
         this.AV24OptionsDescJson = "" ;
         this.AV26OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
         return AV26OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         seriewwgetfilterdata objseriewwgetfilterdata;
         objseriewwgetfilterdata = new seriewwgetfilterdata();
         objseriewwgetfilterdata.AV17DDOName = aP0_DDOName;
         objseriewwgetfilterdata.AV15SearchTxt = aP1_SearchTxt;
         objseriewwgetfilterdata.AV16SearchTxtTo = aP2_SearchTxtTo;
         objseriewwgetfilterdata.AV21OptionsJson = "" ;
         objseriewwgetfilterdata.AV24OptionsDescJson = "" ;
         objseriewwgetfilterdata.AV26OptionIndexesJson = "" ;
         objseriewwgetfilterdata.context.SetSubmitInitialConfig(context);
         objseriewwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objseriewwgetfilterdata);
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((seriewwgetfilterdata)stateInfo).executePrivate();
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
         AV20Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV25OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV17DDOName), "DDO_SERIENOME") == 0 )
         {
            /* Execute user subroutine: 'LOADSERIENOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV21OptionsJson = AV20Options.ToJSonString(false);
         AV24OptionsDescJson = AV23OptionsDesc.ToJSonString(false);
         AV26OptionIndexesJson = AV25OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV28Session.Get("SerieWWGridState"), "") == 0 )
         {
            AV30GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "SerieWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV30GridState.FromXml(AV28Session.Get("SerieWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV35GXV1 = 1;
         while ( AV35GXV1 <= AV30GridState.gxTpr_Filtervalues.Count )
         {
            AV31GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV30GridState.gxTpr_Filtervalues.Item(AV35GXV1));
            if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFSERIENOME") == 0 )
            {
               AV11TFSerieNome = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFSERIENOME_SEL") == 0 )
            {
               AV12TFSerieNome_Sel = AV31GridStateFilterValue.gxTpr_Value;
            }
            AV35GXV1 = (int)(AV35GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSERIENOMEOPTIONS' Routine */
         AV11TFSerieNome = AV15SearchTxt;
         AV12TFSerieNome_Sel = "";
         AV37SerieWWDS_1_Tfserienome = AV11TFSerieNome;
         AV38SerieWWDS_2_Tfserienome_sel = AV12TFSerieNome_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV38SerieWWDS_2_Tfserienome_sel ,
                                              AV37SerieWWDS_1_Tfserienome ,
                                              A2SerieNome } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV37SerieWWDS_1_Tfserienome = StringUtil.Concat( StringUtil.RTrim( AV37SerieWWDS_1_Tfserienome), "%", "");
         /* Using cursor P000X2 */
         pr_default.execute(0, new Object[] {lV37SerieWWDS_1_Tfserienome, AV38SerieWWDS_2_Tfserienome_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0X2 = false;
            A2SerieNome = P000X2_A2SerieNome[0];
            A1SerieId = P000X2_A1SerieId[0];
            AV27count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000X2_A2SerieNome[0], A2SerieNome) == 0 ) )
            {
               BRK0X2 = false;
               A1SerieId = P000X2_A1SerieId[0];
               AV27count = (long)(AV27count+1);
               BRK0X2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A2SerieNome)) )
            {
               AV19Option = A2SerieNome;
               AV20Options.Add(AV19Option, 0);
               AV25OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV27count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV20Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0X2 )
            {
               BRK0X2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
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
         AV20Options = new GxSimpleCollection<String>();
         AV23OptionsDesc = new GxSimpleCollection<String>();
         AV25OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV28Session = context.GetSession();
         AV30GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV31GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV11TFSerieNome = "";
         AV12TFSerieNome_Sel = "";
         AV37SerieWWDS_1_Tfserienome = "";
         AV38SerieWWDS_2_Tfserienome_sel = "";
         scmdbuf = "";
         lV37SerieWWDS_1_Tfserienome = "";
         A2SerieNome = "";
         P000X2_A2SerieNome = new String[] {""} ;
         P000X2_A1SerieId = new long[1] ;
         AV19Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seriewwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000X2_A2SerieNome, P000X2_A1SerieId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV35GXV1 ;
      private long A1SerieId ;
      private long AV27count ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool BRK0X2 ;
      private String AV26OptionIndexesJson ;
      private String AV21OptionsJson ;
      private String AV24OptionsDescJson ;
      private String AV17DDOName ;
      private String AV15SearchTxt ;
      private String AV16SearchTxtTo ;
      private String AV11TFSerieNome ;
      private String AV12TFSerieNome_Sel ;
      private String AV37SerieWWDS_1_Tfserienome ;
      private String AV38SerieWWDS_2_Tfserienome_sel ;
      private String lV37SerieWWDS_1_Tfserienome ;
      private String A2SerieNome ;
      private String AV19Option ;
      private IGxSession AV28Session ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000X2_A2SerieNome ;
      private long[] P000X2_A1SerieId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV20Options ;
      private GxSimpleCollection<String> AV23OptionsDesc ;
      private GxSimpleCollection<String> AV25OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV30GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV31GridStateFilterValue ;
   }

   public class seriewwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000X2( IGxContext context ,
                                             String AV38SerieWWDS_2_Tfserienome_sel ,
                                             String AV37SerieWWDS_1_Tfserienome ,
                                             String A2SerieNome )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [2] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [SerieNome], [SerieId] FROM [Serie] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV38SerieWWDS_2_Tfserienome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV37SerieWWDS_1_Tfserienome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] like @lV37SerieWWDS_1_Tfserienome)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] like @lV37SerieWWDS_1_Tfserienome)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38SerieWWDS_2_Tfserienome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SerieNome] = @AV38SerieWWDS_2_Tfserienome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SerieNome] = @AV38SerieWWDS_2_Tfserienome_sel)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [SerieNome]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000X2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP000X2 ;
          prmP000X2 = new Object[] {
          new Object[] {"@lV37SerieWWDS_1_Tfserienome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV38SerieWWDS_2_Tfserienome_sel",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000X2,100,0,true,false )
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
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.seriewwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class seriewwgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("seriewwgetfilterdata") )
          {
             return  ;
          }
          seriewwgetfilterdata worker = new seriewwgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
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
