/*
               File: WWPBaseObjects.GetWWPTitleSettingsIcons
        Description: Get WWPTitle Settings Icons
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:33.52
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
   public class getwwptitlesettingsicons : GXProcedure
   {
      public getwwptitlesettingsicons( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public getwwptitlesettingsicons( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons aP0_TitleSettingsIcons )
      {
         this.AV8TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context) ;
         initialize();
         executePrivate();
         aP0_TitleSettingsIcons=this.AV8TitleSettingsIcons;
      }

      public GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons executeUdp( )
      {
         this.AV8TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context) ;
         initialize();
         executePrivate();
         aP0_TitleSettingsIcons=this.AV8TitleSettingsIcons;
         return AV8TitleSettingsIcons ;
      }

      public void executeSubmit( out GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons aP0_TitleSettingsIcons )
      {
         getwwptitlesettingsicons objgetwwptitlesettingsicons;
         objgetwwptitlesettingsicons = new getwwptitlesettingsicons();
         objgetwwptitlesettingsicons.AV8TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context) ;
         objgetwwptitlesettingsicons.context.SetSubmitInitialConfig(context);
         objgetwwptitlesettingsicons.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgetwwptitlesettingsicons);
         aP0_TitleSettingsIcons=this.AV8TitleSettingsIcons;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((getwwptitlesettingsicons)stateInfo).executePrivate();
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
         AV8TitleSettingsIcons.gxTpr_Default = context.GetImagePath( "f0ea40a6-46fe-4550-8d22-c8725d56ffa1", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Default_gxi = GXDbFile.PathToUrl( context.GetImagePath( "f0ea40a6-46fe-4550-8d22-c8725d56ffa1", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Filtered = context.GetImagePath( "ce341a0a-0f31-4a25-9eef-42f5efaa6079", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Filtered_gxi = GXDbFile.PathToUrl( context.GetImagePath( "ce341a0a-0f31-4a25-9eef-42f5efaa6079", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Sortedasc = context.GetImagePath( "b9f89e2f-f9e1-4533-b84e-c591709915f9", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Sortedasc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "b9f89e2f-f9e1-4533-b84e-c591709915f9", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Sorteddsc = context.GetImagePath( "c9603047-0d43-4b43-98f8-9206148120d4", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Sorteddsc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "c9603047-0d43-4b43-98f8-9206148120d4", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Filteredsortedasc = context.GetImagePath( "7b3284fc-09e7-4c35-96bd-8fccfd2b522d", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Filteredsortedasc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "7b3284fc-09e7-4c35-96bd-8fccfd2b522d", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Filteredsorteddsc = context.GetImagePath( "19f029d8-5fce-4990-9535-7c32f49223c6", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Filteredsorteddsc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "19f029d8-5fce-4990-9535-7c32f49223c6", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Optionsortasc = context.GetImagePath( "b920b64e-9041-4c94-974e-ad70cf42c1da", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Optionsortasc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "b920b64e-9041-4c94-974e-ad70cf42c1da", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Optionsortdsc = context.GetImagePath( "27f019e7-1f73-4773-b022-0eb1e5e9a385", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Optionsortdsc_gxi = GXDbFile.PathToUrl( context.GetImagePath( "27f019e7-1f73-4773-b022-0eb1e5e9a385", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Optionapplyfilter = context.GetImagePath( "2a5ebedb-95a8-4fbf-87e7-fc52aa72bcc3", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Optionapplyfilter_gxi = GXDbFile.PathToUrl( context.GetImagePath( "2a5ebedb-95a8-4fbf-87e7-fc52aa72bcc3", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Optionfilteringdata = context.GetImagePath( "d868f625-eb2f-4cc0-b58e-9552f1c1e328", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Optionfilteringdata_gxi = GXDbFile.PathToUrl( context.GetImagePath( "d868f625-eb2f-4cc0-b58e-9552f1c1e328", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Optioncleanfilters = context.GetImagePath( "d2b56e65-7d48-43f5-a171-32b75f312b3d", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Optioncleanfilters_gxi = GXDbFile.PathToUrl( context.GetImagePath( "d2b56e65-7d48-43f5-a171-32b75f312b3d", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Selectedoption = context.GetImagePath( "922743b5-f093-4e77-b66c-6cd883017bf6", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Selectedoption_gxi = GXDbFile.PathToUrl( context.GetImagePath( "922743b5-f093-4e77-b66c-6cd883017bf6", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Multiseloption = context.GetImagePath( "57e1409a-dafd-45c5-b823-eac09df3c4ba", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Multiseloption_gxi = GXDbFile.PathToUrl( context.GetImagePath( "57e1409a-dafd-45c5-b823-eac09df3c4ba", "", context.GetTheme( )));
         AV8TitleSettingsIcons.gxTpr_Multiselseloption = context.GetImagePath( "00c94341-3cc8-4323-9500-fd340ead11b8", "", context.GetTheme( ));
         AV8TitleSettingsIcons.gxTpr_Multiselseloption_gxi = GXDbFile.PathToUrl( context.GetImagePath( "00c94341-3cc8-4323-9500-fd340ead11b8", "", context.GetTheme( )));
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

      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons aP0_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV8TitleSettingsIcons ;
   }

}
