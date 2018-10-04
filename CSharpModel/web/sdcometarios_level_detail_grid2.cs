/*
               File: SDCometarios_Level_Detail_Grid2
        Description: SDCometarios_Level_Detail_Grid2
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/27/2018 20:14:31.56
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
   public class sdcometarios_level_detail_grid2 : GXProcedure
   {
      public sdcometarios_level_detail_grid2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public sdcometarios_level_detail_grid2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_TipoComentario ,
                           long aP1_Id ,
                           long aP2_start ,
                           long aP3_count ,
                           int aP4_gxid ,
                           out GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> aP5_GXM3RootCol )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV24start = aP2_start;
         this.AV25count = aP3_count;
         this.AV21gxid = aP4_gxid;
         this.AV27GXM3RootCol = new GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM3RootCol=this.AV27GXM3RootCol;
      }

      public GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> executeUdp( short aP0_TipoComentario ,
                                                                                      long aP1_Id ,
                                                                                      long aP2_start ,
                                                                                      long aP3_count ,
                                                                                      int aP4_gxid )
      {
         this.AV5TipoComentario = aP0_TipoComentario;
         this.AV6Id = aP1_Id;
         this.AV24start = aP2_start;
         this.AV25count = aP3_count;
         this.AV21gxid = aP4_gxid;
         this.AV27GXM3RootCol = new GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item>( context, "Item", "") ;
         initialize();
         executePrivate();
         aP5_GXM3RootCol=this.AV27GXM3RootCol;
         return AV27GXM3RootCol ;
      }

      public void executeSubmit( short aP0_TipoComentario ,
                                 long aP1_Id ,
                                 long aP2_start ,
                                 long aP3_count ,
                                 int aP4_gxid ,
                                 out GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> aP5_GXM3RootCol )
      {
         sdcometarios_level_detail_grid2 objsdcometarios_level_detail_grid2;
         objsdcometarios_level_detail_grid2 = new sdcometarios_level_detail_grid2();
         objsdcometarios_level_detail_grid2.AV5TipoComentario = aP0_TipoComentario;
         objsdcometarios_level_detail_grid2.AV6Id = aP1_Id;
         objsdcometarios_level_detail_grid2.AV24start = aP2_start;
         objsdcometarios_level_detail_grid2.AV25count = aP3_count;
         objsdcometarios_level_detail_grid2.AV21gxid = aP4_gxid;
         objsdcometarios_level_detail_grid2.AV27GXM3RootCol = new GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item>( context, "Item", "") ;
         objsdcometarios_level_detail_grid2.context.SetSubmitInitialConfig(context);
         objsdcometarios_level_detail_grid2.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsdcometarios_level_detail_grid2);
         aP5_GXM3RootCol=this.AV27GXM3RootCol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((sdcometarios_level_detail_grid2)stateInfo).executePrivate();
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
         Gxids = "gxid_" + StringUtil.Str( (decimal)(AV21gxid), 8, 0);
         AV11nota = (short)(NumberUtil.Val( Gxwebsession.Get(Gxids+"gxvar_Nota"), "."));
         AV31Um_GXI = Gxwebsession.Get(Gxids+"gxvar_Um");
         AV15Um = "";
         AV32Dois_GXI = Gxwebsession.Get(Gxids+"gxvar_Dois");
         AV16Dois = "";
         AV33Tres_GXI = Gxwebsession.Get(Gxids+"gxvar_Tres");
         AV17Tres = "";
         AV34Quatro_GXI = Gxwebsession.Get(Gxids+"gxvar_Quatro");
         AV18Quatro = "";
         AV35Cinco_GXI = Gxwebsession.Get(Gxids+"gxvar_Cinco");
         AV19Cinco = "";
         AV26GXV1SkipCount = (int)(-(AV24start));
         AV26GXV1SkipCount = (int)(AV26GXV1SkipCount+1);
         if ( AV26GXV1SkipCount > 0 )
         {
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt = new SdtSDCometarios_Level_Detail_Grid2Sdt_Item(context);
            AV15Um = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV31Um_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV16Dois = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV32Dois_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV17Tres = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV33Tres_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV18Quatro = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV34Quatro_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            AV19Cinco = context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( ));
            AV35Cinco_GXI = GXDbFile.PathToUrl( context.GetImagePath( "78937a91-2c51-4be9-92b2-23180713b984", "", context.GetTheme( )));
            new log(context ).execute(  "Evento load grid2"+StringUtil.Str( (decimal)(AV11nota), 1, 0)) ;
            if ( AV11nota == 1 )
            {
               AV15Um = context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( ));
               AV31Um_GXI = GXDbFile.PathToUrl( context.GetImagePath( "5a027831-0433-44a2-82ab-8d53ec2e4730", "", context.GetTheme( )));
            }
            else if ( AV11nota == 2 )
            {
               AV16Dois = context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( ));
               AV32Dois_GXI = GXDbFile.PathToUrl( context.GetImagePath( "9c2a164a-b79b-43f6-93f8-505ed5fdba7a", "", context.GetTheme( )));
            }
            else if ( AV11nota == 3 )
            {
               AV17Tres = context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( ));
               AV33Tres_GXI = GXDbFile.PathToUrl( context.GetImagePath( "52d99c2e-f27d-4bd0-9752-be241920135e", "", context.GetTheme( )));
            }
            else if ( AV11nota == 4 )
            {
               AV18Quatro = context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( ));
               AV34Quatro_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1f424a33-0d54-4e16-bc9f-0647b5704ad0", "", context.GetTheme( )));
            }
            else if ( AV11nota == 5 )
            {
               AV19Cinco = context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( ));
               AV35Cinco_GXI = GXDbFile.PathToUrl( context.GetImagePath( "1613f2f4-b97d-45f1-aa37-de76245910c5", "", context.GetTheme( )));
            }
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Um = AV15Um;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Um_gxi = AV31Um_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Dois = AV16Dois;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Dois_gxi = AV32Dois_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Tres = AV17Tres;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Tres_gxi = AV33Tres_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Quatro = AV18Quatro;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Quatro_gxi = AV34Quatro_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Cinco = AV19Cinco;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Cinco_gxi = AV35Cinco_GXI;
            AV27GXM3RootCol.Add(AV28GXM2SDCometarios_Level_Detail_Grid2Sdt, 0);
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt = new SdtSDCometarios_Level_Detail_Grid2Sdt_Item(context);
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Um = AV15Um;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Um_gxi = AV31Um_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Dois = AV16Dois;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Dois_gxi = AV32Dois_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Tres = AV17Tres;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Tres_gxi = AV33Tres_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Quatro = AV18Quatro;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Quatro_gxi = AV34Quatro_GXI;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Cinco = AV19Cinco;
            AV28GXM2SDCometarios_Level_Detail_Grid2Sdt.gxTpr_Cinco_gxi = AV35Cinco_GXI;
         }
         Gxwebsession.Set(Gxids+"gxvar_Nota", StringUtil.Str( (decimal)(AV11nota), 1, 0));
         Gxwebsession.Set(Gxids+"gxvar_Um", AV31Um_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Dois", AV32Dois_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Tres", AV33Tres_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Quatro", AV34Quatro_GXI);
         Gxwebsession.Set(Gxids+"gxvar_Cinco", AV35Cinco_GXI);
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
         AV31Um_GXI = "";
         AV15Um = "";
         AV32Dois_GXI = "";
         AV16Dois = "";
         AV33Tres_GXI = "";
         AV17Tres = "";
         AV34Quatro_GXI = "";
         AV18Quatro = "";
         AV35Cinco_GXI = "";
         AV19Cinco = "";
         AV28GXM2SDCometarios_Level_Detail_Grid2Sdt = new SdtSDCometarios_Level_Detail_Grid2Sdt_Item(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV5TipoComentario ;
      private short AV11nota ;
      private int AV21gxid ;
      private int AV26GXV1SkipCount ;
      private long AV6Id ;
      private long AV24start ;
      private long AV25count ;
      private String Gxids ;
      private String AV31Um_GXI ;
      private String AV32Dois_GXI ;
      private String AV33Tres_GXI ;
      private String AV34Quatro_GXI ;
      private String AV35Cinco_GXI ;
      private String AV15Um ;
      private String AV16Dois ;
      private String AV17Tres ;
      private String AV18Quatro ;
      private String AV19Cinco ;
      private GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> aP5_GXM3RootCol ;
      private IGxSession Gxwebsession ;
      private GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> AV27GXM3RootCol ;
      private SdtSDCometarios_Level_Detail_Grid2Sdt_Item AV28GXM2SDCometarios_Level_Detail_Grid2Sdt ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.sdcometarios_level_detail_grid2_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class sdcometarios_level_detail_grid2_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "GET" ,
      	BodyStyle =  WebMessageBodyStyle.Bare  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/?TipoComentario={TipoComentario}&Id={Id}&start={start}&count={count}&gxid={gxid}")]
      public GxGenericCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface> execute( short TipoComentario ,
                                                                                                    String Id ,
                                                                                                    String start ,
                                                                                                    String count ,
                                                                                                    String gxid )
      {
         GxGenericCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface> GXM3RootCol = new GxGenericCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface>() ;
         try
         {
            if ( ! ProcessHeaders("sdcometarios_level_detail_grid2") )
            {
               return null ;
            }
            sdcometarios_level_detail_grid2 worker = new sdcometarios_level_detail_grid2(context) ;
            worker.IsMain = RunAsMain ;
            long gxrId ;
            gxrId = (long)(NumberUtil.Val( (String)(Id), "."));
            long gxrstart ;
            gxrstart = (long)(NumberUtil.Val( (String)(start), "."));
            long gxrcount ;
            gxrcount = (long)(NumberUtil.Val( (String)(count), "."));
            int gxrgxid ;
            gxrgxid = (int)(NumberUtil.Val( (String)(gxid), "."));
            GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item> gxrGXM3RootCol = new GXBaseCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item>() ;
            worker.execute(TipoComentario,gxrId,gxrstart,gxrcount,gxrgxid,out gxrGXM3RootCol );
            worker.cleanup( );
            GXM3RootCol = new GxGenericCollection<SdtSDCometarios_Level_Detail_Grid2Sdt_Item_RESTInterface>(gxrGXM3RootCol) ;
            return GXM3RootCol ;
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
