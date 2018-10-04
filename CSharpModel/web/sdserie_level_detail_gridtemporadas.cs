/*
               File: SDSerie_Level_Detail_GridTemporadas
        Description: SDSerie_Level_Detail_GridTemporadas
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/30/2018 21:3:35.68
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
   public class sdserie_level_detail_gridtemporadas : GXProcedure
   {
      public sdserie_level_detail_gridtemporadas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public sdserie_level_detail_gridtemporadas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( long aP0_SerieId ,
                           long aP1_start ,
                           long aP2_count ,
                           int aP3_gxid ,
                           out GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> aP4_GXM4RootCol )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV18start = aP1_start;
         this.AV19count = aP2_count;
         this.AV15gxid = aP3_gxid;
         this.AV23GXM4RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM4RootCol=this.AV23GXM4RootCol;
      }

      public GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> executeUdp( long aP0_SerieId ,
                                                                                          long aP1_start ,
                                                                                          long aP2_count ,
                                                                                          int aP3_gxid )
      {
         this.AV5SerieId = aP0_SerieId;
         this.AV18start = aP1_start;
         this.AV19count = aP2_count;
         this.AV15gxid = aP3_gxid;
         this.AV23GXM4RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP4_GXM4RootCol=this.AV23GXM4RootCol;
         return AV23GXM4RootCol ;
      }

      public void executeSubmit( long aP0_SerieId ,
                                 long aP1_start ,
                                 long aP2_count ,
                                 int aP3_gxid ,
                                 out GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> aP4_GXM4RootCol )
      {
         sdserie_level_detail_gridtemporadas objsdserie_level_detail_gridtemporadas;
         objsdserie_level_detail_gridtemporadas = new sdserie_level_detail_gridtemporadas();
         objsdserie_level_detail_gridtemporadas.AV5SerieId = aP0_SerieId;
         objsdserie_level_detail_gridtemporadas.AV18start = aP1_start;
         objsdserie_level_detail_gridtemporadas.AV19count = aP2_count;
         objsdserie_level_detail_gridtemporadas.AV15gxid = aP3_gxid;
         objsdserie_level_detail_gridtemporadas.AV23GXM4RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item>( context, "Item", "") ;
         objsdserie_level_detail_gridtemporadas.context.SetSubmitInitialConfig(context);
         objsdserie_level_detail_gridtemporadas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdserie_level_detail_gridtemporadas);
         aP4_GXM4RootCol=this.AV23GXM4RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdserie_level_detail_gridtemporadas)stateInfo).executePrivate();
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
         AV9QuantidadeTemporadas = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Quantidadetemporadas"), "."));
         AV10Temporada = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Temporada"), "."));
         AV22GXV2SkipCount = (int)(-(AV18start));
         AV22GXV2SkipCount = (int)(AV22GXV2SkipCount+1);
         if ( AV22GXV2SkipCount > 0 )
         {
            AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt = new SdtSDSerie_Level_Detail_GridTemporadasSdt_Item(context);
            AV11i = 1;
            while ( AV11i <= AV9QuantidadeTemporadas )
            {
               AV10Temporada = AV11i;
               Gxdynprop1 = "Temporada " + StringUtil.Str( (decimal)(AV11i), 4, 0);
               Gxdynprop = Gxdynprop + ((StringUtil.StrCmp(Gxdynprop, "")==0) ? "" : ", ") + "[\"Txbtemporada\",\"Caption\",\"" + StringUtil.JSONEncode( Gxdynprop1) + "\"]";
               AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt.gxTpr_Temporada = AV10Temporada;
               AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
               Gxdynprop = "";
               AV23GXM4RootCol.Add(AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt, 0);
               AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt = new SdtSDSerie_Level_Detail_GridTemporadasSdt_Item(context);
               AV11i = (short)(AV11i+1);
            }
            AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt.gxTpr_Temporada = AV10Temporada;
            AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt.gxTpr_Gxdynprop = "[ "+Gxdynprop+" ]";
            Gxdynprop = "";
         }
         Gxwebsession.Set(Gxids+"gxvar_Quantidadetemporadas", StringUtil.Str( (decimal)(AV9QuantidadeTemporadas), 4, 0));
         Gxwebsession.Set(Gxids+"gxvar_Temporada", StringUtil.Str( (decimal)(AV10Temporada), 4, 0));
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
         AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt = new SdtSDSerie_Level_Detail_GridTemporadasSdt_Item(context);
         Gxdynprop1 = "";
         Gxdynprop = "";
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9QuantidadeTemporadas ;
      private short AV10Temporada ;
      private short AV11i ;
      private int AV15gxid ;
      private int AV22GXV2SkipCount ;
      private long AV5SerieId ;
      private long AV18start ;
      private long AV19count ;
      private String Gxids ;
      private String Gxdynprop1 ;
      private String Gxdynprop ;
      private GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> aP4_GXM4RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> AV23GXM4RootCol ;
      private SdtSDSerie_Level_Detail_GridTemporadasSdt_Item AV24GXM3SDSerie_Level_Detail_GridTemporadasSdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.sdserie_level_detail_gridtemporadas_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class sdserie_level_detail_gridtemporadas_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?SerieId={SerieId}&start={start}&count={count}&gxid={gxid}")]
      public GxGenericCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item_RESTInterface> execute( String SerieId ,
                                                                                                        String start ,
                                                                                                        String count ,
                                                                                                        String gxid )
      {
         GxGenericCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item_RESTInterface> GXM4RootCol = new GxGenericCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item_RESTInterface>() ;
         try
         {
            if ( ! ProcessHeaders("sdserie_level_detail_gridtemporadas") )
            {
               return null ;
            }
            sdserie_level_detail_gridtemporadas worker = new sdserie_level_detail_gridtemporadas(context) ;
            worker.IsMain = RunAsMain ;
            long gxrSerieId ;
            gxrSerieId = (long)(NumberUtil.Val( (String)(SerieId), "."));
            long gxrstart ;
            gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
            long gxrcount ;
            gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item> gxrGXM4RootCol = new GXBaseCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item>() ;
            worker.execute(gxrSerieId,gxrstart,gxrcount,gxrgxid,out gxrGXM4RootCol );
            worker.cleanup( );
            GXM4RootCol = new GxGenericCollection<SdtSDSerie_Level_Detail_GridTemporadasSdt_Item_RESTInterface>(gxrGXM4RootCol) ;
            return GXM4RootCol ;
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
