/*
               File: WWPBaseObjects.LoadColumnsSelectorState
        Description: Load Columns Selector State
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:31.99
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
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class loadcolumnsselectorstate : GXProcedure
   {
      public loadcolumnsselectorstate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public loadcolumnsselectorstate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserCustomKey ,
                           out String aP1_UserCustomValue )
      {
         this.AV8UserCustomKey = aP0_UserCustomKey;
         this.AV9UserCustomValue = "" ;
         initialize();
         executePrivate();
         aP1_UserCustomValue=this.AV9UserCustomValue;
      }

      public String executeUdp( String aP0_UserCustomKey )
      {
         this.AV8UserCustomKey = aP0_UserCustomKey;
         this.AV9UserCustomValue = "" ;
         initialize();
         executePrivate();
         aP1_UserCustomValue=this.AV9UserCustomValue;
         return AV9UserCustomValue ;
      }

      public void executeSubmit( String aP0_UserCustomKey ,
                                 out String aP1_UserCustomValue )
      {
         loadcolumnsselectorstate objloadcolumnsselectorstate;
         objloadcolumnsselectorstate = new loadcolumnsselectorstate();
         objloadcolumnsselectorstate.AV8UserCustomKey = aP0_UserCustomKey;
         objloadcolumnsselectorstate.AV9UserCustomValue = "" ;
         objloadcolumnsselectorstate.context.SetSubmitInitialConfig(context);
         objloadcolumnsselectorstate.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objloadcolumnsselectorstate);
         aP1_UserCustomValue=this.AV9UserCustomValue;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadcolumnsselectorstate)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loaduserkeyvalue(context ).execute(  AV8UserCustomKey, out  AV9UserCustomValue) ;
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
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV8UserCustomKey ;
      private String AV9UserCustomValue ;
      private String aP1_UserCustomValue ;
   }

}
