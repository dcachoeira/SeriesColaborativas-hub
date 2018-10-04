/*
               File: GeneroWWGetFilterData
        Description: Genero WWGet Filter Data
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:50.55
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
   public class generowwgetfilterdata : GXProcedure
   {
      public generowwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public generowwgetfilterdata( IGxContext context )
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
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
         return AV24OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         generowwgetfilterdata objgenerowwgetfilterdata;
         objgenerowwgetfilterdata = new generowwgetfilterdata();
         objgenerowwgetfilterdata.AV15DDOName = aP0_DDOName;
         objgenerowwgetfilterdata.AV13SearchTxt = aP1_SearchTxt;
         objgenerowwgetfilterdata.AV14SearchTxtTo = aP2_SearchTxtTo;
         objgenerowwgetfilterdata.AV19OptionsJson = "" ;
         objgenerowwgetfilterdata.AV22OptionsDescJson = "" ;
         objgenerowwgetfilterdata.AV24OptionIndexesJson = "" ;
         objgenerowwgetfilterdata.context.SetSubmitInitialConfig(context);
         objgenerowwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgenerowwgetfilterdata);
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((generowwgetfilterdata)stateInfo).executePrivate();
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
         AV18Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV21OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV15DDOName), "DDO_GENERONOME") == 0 )
         {
            /* Execute user subroutine: 'LOADGENERONOMEOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV19OptionsJson = AV18Options.ToJSonString(false);
         AV22OptionsDescJson = AV21OptionsDesc.ToJSonString(false);
         AV24OptionIndexesJson = AV23OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV26Session.Get("GeneroWWGridState"), "") == 0 )
         {
            AV28GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "GeneroWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         else
         {
            AV28GridState.FromXml(AV26Session.Get("GeneroWWGridState"), null, "WWPGridState", "SeriesColaborativas");
         }
         AV33GXV1 = 1;
         while ( AV33GXV1 <= AV28GridState.gxTpr_Filtervalues.Count )
         {
            AV29GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV28GridState.gxTpr_Filtervalues.Item(AV33GXV1));
            if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFGENERONOME") == 0 )
            {
               AV11TFGeneroNome = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFGENERONOME_SEL") == 0 )
            {
               AV12TFGeneroNome_Sel = AV29GridStateFilterValue.gxTpr_Value;
            }
            AV33GXV1 = (int)(AV33GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADGENERONOMEOPTIONS' Routine */
         AV11TFGeneroNome = AV13SearchTxt;
         AV12TFGeneroNome_Sel = "";
         AV35GeneroWWDS_1_Tfgeneronome = AV11TFGeneroNome;
         AV36GeneroWWDS_2_Tfgeneronome_sel = AV12TFGeneroNome_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV36GeneroWWDS_2_Tfgeneronome_sel ,
                                              AV35GeneroWWDS_1_Tfgeneronome ,
                                              A49GeneroNome } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV35GeneroWWDS_1_Tfgeneronome = StringUtil.Concat( StringUtil.RTrim( AV35GeneroWWDS_1_Tfgeneronome), "%", "");
         /* Using cursor P000Z2 */
         pr_default.execute(0, new Object[] {lV35GeneroWWDS_1_Tfgeneronome, AV36GeneroWWDS_2_Tfgeneronome_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0Z2 = false;
            A49GeneroNome = P000Z2_A49GeneroNome[0];
            A48GeneroId = P000Z2_A48GeneroId[0];
            AV25count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000Z2_A49GeneroNome[0], A49GeneroNome) == 0 ) )
            {
               BRK0Z2 = false;
               A48GeneroId = P000Z2_A48GeneroId[0];
               AV25count = (long)(AV25count+1);
               BRK0Z2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A49GeneroNome)) )
            {
               AV17Option = A49GeneroNome;
               AV18Options.Add(AV17Option, 0);
               AV23OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV25count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV18Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0Z2 )
            {
               BRK0Z2 = true;
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
         AV18Options = new GxSimpleCollection<String>();
         AV21OptionsDesc = new GxSimpleCollection<String>();
         AV23OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV26Session = context.GetSession();
         AV28GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV29GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV11TFGeneroNome = "";
         AV12TFGeneroNome_Sel = "";
         AV35GeneroWWDS_1_Tfgeneronome = "";
         AV36GeneroWWDS_2_Tfgeneronome_sel = "";
         scmdbuf = "";
         lV35GeneroWWDS_1_Tfgeneronome = "";
         A49GeneroNome = "";
         P000Z2_A49GeneroNome = new String[] {""} ;
         P000Z2_A48GeneroId = new long[1] ;
         AV17Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.generowwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000Z2_A49GeneroNome, P000Z2_A48GeneroId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV33GXV1 ;
      private long A48GeneroId ;
      private long AV25count ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool BRK0Z2 ;
      private String AV24OptionIndexesJson ;
      private String AV19OptionsJson ;
      private String AV22OptionsDescJson ;
      private String AV15DDOName ;
      private String AV13SearchTxt ;
      private String AV14SearchTxtTo ;
      private String AV11TFGeneroNome ;
      private String AV12TFGeneroNome_Sel ;
      private String AV35GeneroWWDS_1_Tfgeneronome ;
      private String AV36GeneroWWDS_2_Tfgeneronome_sel ;
      private String lV35GeneroWWDS_1_Tfgeneronome ;
      private String A49GeneroNome ;
      private String AV17Option ;
      private IGxSession AV26Session ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000Z2_A49GeneroNome ;
      private long[] P000Z2_A48GeneroId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV18Options ;
      private GxSimpleCollection<String> AV21OptionsDesc ;
      private GxSimpleCollection<String> AV23OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV28GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV29GridStateFilterValue ;
   }

   public class generowwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000Z2( IGxContext context ,
                                             String AV36GeneroWWDS_2_Tfgeneronome_sel ,
                                             String AV35GeneroWWDS_1_Tfgeneronome ,
                                             String A49GeneroNome )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [2] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [GeneroNome], [GeneroId] FROM [Genero] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV36GeneroWWDS_2_Tfgeneronome_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV35GeneroWWDS_1_Tfgeneronome)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] like @lV35GeneroWWDS_1_Tfgeneronome)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] like @lV35GeneroWWDS_1_Tfgeneronome)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV36GeneroWWDS_2_Tfgeneronome_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([GeneroNome] = @AV36GeneroWWDS_2_Tfgeneronome_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([GeneroNome] = @AV36GeneroWWDS_2_Tfgeneronome_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [GeneroNome]";
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
                     return conditional_P000Z2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
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
          Object[] prmP000Z2 ;
          prmP000Z2 = new Object[] {
          new Object[] {"@lV35GeneroWWDS_1_Tfgeneronome",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV36GeneroWWDS_2_Tfgeneronome_sel",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z2,100,0,true,false )
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

 [ServiceContract(Namespace = "GeneXus.Programs.generowwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class generowwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("generowwgetfilterdata") )
          {
             return  ;
          }
          generowwgetfilterdata worker = new generowwgetfilterdata(context) ;
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
