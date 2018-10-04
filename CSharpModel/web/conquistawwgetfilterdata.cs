/*
               File: ConquistaWWGetFilterData
        Description: Conquista WWGet Filter Data
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:46.21
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
   public class conquistawwgetfilterdata : GXProcedure
   {
      public conquistawwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public conquistawwgetfilterdata( IGxContext context )
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
         this.AV23DDOName = aP0_DDOName;
         this.AV21SearchTxt = aP1_SearchTxt;
         this.AV22SearchTxtTo = aP2_SearchTxtTo;
         this.AV27OptionsJson = "" ;
         this.AV30OptionsDescJson = "" ;
         this.AV32OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV23DDOName = aP0_DDOName;
         this.AV21SearchTxt = aP1_SearchTxt;
         this.AV22SearchTxtTo = aP2_SearchTxtTo;
         this.AV27OptionsJson = "" ;
         this.AV30OptionsDescJson = "" ;
         this.AV32OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
         return AV32OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         conquistawwgetfilterdata objconquistawwgetfilterdata;
         objconquistawwgetfilterdata = new conquistawwgetfilterdata();
         objconquistawwgetfilterdata.AV23DDOName = aP0_DDOName;
         objconquistawwgetfilterdata.AV21SearchTxt = aP1_SearchTxt;
         objconquistawwgetfilterdata.AV22SearchTxtTo = aP2_SearchTxtTo;
         objconquistawwgetfilterdata.AV27OptionsJson = "" ;
         objconquistawwgetfilterdata.AV30OptionsDescJson = "" ;
         objconquistawwgetfilterdata.AV32OptionIndexesJson = "" ;
         objconquistawwgetfilterdata.context.SetSubmitInitialConfig(context);
         objconquistawwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objconquistawwgetfilterdata);
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((conquistawwgetfilterdata)stateInfo).executePrivate();
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
         AV26Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV29OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_CONQUISTANOME") == 0 )
         {
            /* Execute user subroutine: 'LOADCONQUISTANOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV27OptionsJson = AV26Options.ToJSonString(false);
         AV30OptionsDescJson = AV29OptionsDesc.ToJSonString(false);
         AV32OptionIndexesJson = AV31OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV34Session.Get("ConquistaWWGridState"), "") == 0 )
         {
            AV36GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "ConquistaWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV36GridState.FromXml(AV34Session.Get("ConquistaWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV41GXV1 = 1;
         while ( AV41GXV1 <= AV36GridState.gxTpr_Filtervalues.Count )
         {
            AV37GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV36GridState.gxTpr_Filtervalues.Item(AV41GXV1));
            if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFCONQUISTANOME") == 0 )
            {
               AV15TFConquistaNome = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFCONQUISTANOME_SEL") == 0 )
            {
               AV16TFConquistaNome_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFCONQUISTAPONTOS") == 0 )
            {
               AV13TFConquistaPontos = (short)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV14TFConquistaPontos_To = (short)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            AV41GXV1 = (int)(AV41GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADCONQUISTANOMEOPTIONS' Routine */
         AV15TFConquistaNome = AV21SearchTxt;
         AV16TFConquistaNome_Sel = "";
         AV43ConquistaWWDS_1_Tfconquistanome = AV15TFConquistaNome;
         AV44ConquistaWWDS_2_Tfconquistanome_sel = AV16TFConquistaNome_Sel;
         AV45ConquistaWWDS_3_Tfconquistapontos = AV13TFConquistaPontos;
         AV46ConquistaWWDS_4_Tfconquistapontos_to = AV14TFConquistaPontos_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV44ConquistaWWDS_2_Tfconquistanome_sel ,
                                              AV43ConquistaWWDS_1_Tfconquistanome ,
                                              AV45ConquistaWWDS_3_Tfconquistapontos ,
                                              AV46ConquistaWWDS_4_Tfconquistapontos_to ,
                                              A29ConquistaNome ,
                                              A28ConquistaPontos } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT
                                              }
         } ) ;
         lV43ConquistaWWDS_1_Tfconquistanome = StringUtil.Concat( StringUtil.RTrim( AV43ConquistaWWDS_1_Tfconquistanome), "%", "");
         /* Using cursor P000Y2 */
         pr_default.execute(0, new Object[] {lV43ConquistaWWDS_1_Tfconquistanome, AV44ConquistaWWDS_2_Tfconquistanome_sel, AV45ConquistaWWDS_3_Tfconquistapontos, AV46ConquistaWWDS_4_Tfconquistapontos_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0Y2 = false;
            A29ConquistaNome = P000Y2_A29ConquistaNome[0];
            A28ConquistaPontos = P000Y2_A28ConquistaPontos[0];
            A27ConquistaId = P000Y2_A27ConquistaId[0];
            AV33count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000Y2_A29ConquistaNome[0], A29ConquistaNome) == 0 ) )
            {
               BRK0Y2 = false;
               A27ConquistaId = P000Y2_A27ConquistaId[0];
               AV33count = (long)(AV33count+1);
               BRK0Y2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A29ConquistaNome)) )
            {
               AV25Option = A29ConquistaNome;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0Y2 )
            {
               BRK0Y2 = true;
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
         AV26Options = new GxSimpleCollection<String>();
         AV29OptionsDesc = new GxSimpleCollection<String>();
         AV31OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV34Session = context.GetSession();
         AV36GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV37GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFConquistaNome = "";
         AV16TFConquistaNome_Sel = "";
         AV43ConquistaWWDS_1_Tfconquistanome = "";
         AV44ConquistaWWDS_2_Tfconquistanome_sel = "";
         scmdbuf = "";
         lV43ConquistaWWDS_1_Tfconquistanome = "";
         A29ConquistaNome = "";
         P000Y2_A29ConquistaNome = new String[] {""} ;
         P000Y2_A28ConquistaPontos = new short[1] ;
         P000Y2_A27ConquistaId = new long[1] ;
         AV25Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.conquistawwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000Y2_A29ConquistaNome, P000Y2_A28ConquistaPontos, P000Y2_A27ConquistaId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV13TFConquistaPontos ;
      private short AV14TFConquistaPontos_To ;
      private short AV45ConquistaWWDS_3_Tfconquistapontos ;
      private short AV46ConquistaWWDS_4_Tfconquistapontos_to ;
      private short A28ConquistaPontos ;
      private int AV41GXV1 ;
      private long A27ConquistaId ;
      private long AV33count ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool BRK0Y2 ;
      private String AV32OptionIndexesJson ;
      private String AV27OptionsJson ;
      private String AV30OptionsDescJson ;
      private String AV23DDOName ;
      private String AV21SearchTxt ;
      private String AV22SearchTxtTo ;
      private String AV15TFConquistaNome ;
      private String AV16TFConquistaNome_Sel ;
      private String AV43ConquistaWWDS_1_Tfconquistanome ;
      private String AV44ConquistaWWDS_2_Tfconquistanome_sel ;
      private String lV43ConquistaWWDS_1_Tfconquistanome ;
      private String A29ConquistaNome ;
      private String AV25Option ;
      private IGxSession AV34Session ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000Y2_A29ConquistaNome ;
      private short[] P000Y2_A28ConquistaPontos ;
      private long[] P000Y2_A27ConquistaId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV26Options ;
      private GxSimpleCollection<String> AV29OptionsDesc ;
      private GxSimpleCollection<String> AV31OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV36GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV37GridStateFilterValue ;
   }

   public class conquistawwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000Y2( IGxContext context ,
                                             String AV44ConquistaWWDS_2_Tfconquistanome_sel ,
                                             String AV43ConquistaWWDS_1_Tfconquistanome ,
                                             short AV45ConquistaWWDS_3_Tfconquistapontos ,
                                             short AV46ConquistaWWDS_4_Tfconquistapontos_to ,
                                             String A29ConquistaNome ,
                                             short A28ConquistaPontos )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [4] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [ConquistaNome], [ConquistaPontos], [ConquistaId] FROM [Conquista] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV44ConquistaWWDS_2_Tfconquistanome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43ConquistaWWDS_1_Tfconquistanome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] like @lV43ConquistaWWDS_1_Tfconquistanome)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] like @lV43ConquistaWWDS_1_Tfconquistanome)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44ConquistaWWDS_2_Tfconquistanome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaNome] = @AV44ConquistaWWDS_2_Tfconquistanome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaNome] = @AV44ConquistaWWDS_2_Tfconquistanome_sel)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (0==AV45ConquistaWWDS_3_Tfconquistapontos) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] >= @AV45ConquistaWWDS_3_Tfconquistapontos)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] >= @AV45ConquistaWWDS_3_Tfconquistapontos)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV46ConquistaWWDS_4_Tfconquistapontos_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([ConquistaPontos] <= @AV46ConquistaWWDS_4_Tfconquistapontos_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([ConquistaPontos] <= @AV46ConquistaWWDS_4_Tfconquistapontos_to)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [ConquistaNome]";
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
                     return conditional_P000Y2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (short)dynConstraints[5] );
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
          Object[] prmP000Y2 ;
          prmP000Y2 = new Object[] {
          new Object[] {"@lV43ConquistaWWDS_1_Tfconquistanome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV44ConquistaWWDS_2_Tfconquistanome_sel",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV45ConquistaWWDS_3_Tfconquistapontos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV46ConquistaWWDS_4_Tfconquistapontos_to",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Y2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Y2,100,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.conquistawwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class conquistawwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("conquistawwgetfilterdata") )
          {
             return  ;
          }
          conquistawwgetfilterdata worker = new conquistawwgetfilterdata(context) ;
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
