/*
               File: WWPBaseObjects.ListWWPPrograms
        Description: List Work With Plus Programs
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/9/2018 19:41:23.1
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
   public class listwwpprograms : GXProcedure
   {
      public listwwpprograms( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public listwwpprograms( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> aP0_ProgramNames )
      {
         this.AV10ProgramNames = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> executeUdp( )
      {
         this.AV10ProgramNames = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "SeriesColaborativas") ;
         initialize();
         executePrivate();
         aP0_ProgramNames=this.AV10ProgramNames;
         return AV10ProgramNames ;
      }

      public void executeSubmit( out GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> aP0_ProgramNames )
      {
         listwwpprograms objlistwwpprograms;
         objlistwwpprograms = new listwwpprograms();
         objlistwwpprograms.AV10ProgramNames = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "SeriesColaborativas") ;
         objlistwwpprograms.context.SetSubmitInitialConfig(context);
         objlistwwpprograms.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objlistwwpprograms);
         aP0_ProgramNames=this.AV10ProgramNames;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((listwwpprograms)stateInfo).executePrivate();
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
         AV10ProgramNames = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName>( context, "ProgramName", "SeriesColaborativas");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         AV14name = "SerieWW";
         AV15description = " Série";
         AV16link = "serieww.aspx";
         /* Execute user subroutine: 'ADDPROGRAM' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'ADDPROGRAM' Routine */
         AV8IsAuthorized = true;
         if ( AV8IsAuthorized )
         {
            AV11ProgramName = new GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName(context);
            AV11ProgramName.gxTpr_Name = AV14name;
            AV11ProgramName.gxTpr_Description = AV15description;
            AV11ProgramName.gxTpr_Link = AV16link;
            AV10ProgramNames.Add(AV11ProgramName, 0);
         }
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
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV14name = "";
         AV15description = "";
         AV16link = "";
         AV11ProgramName = new GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool returnInSub ;
      private bool AV8IsAuthorized ;
      private String AV14name ;
      private String AV15description ;
      private String AV16link ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> aP0_ProgramNames ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName> AV10ProgramNames ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtProgramNames_ProgramName AV11ProgramName ;
   }

}
