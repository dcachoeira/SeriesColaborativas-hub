using System;
using GeneXus.Builder;
using System.IO;
public class bldanotificationsregistrationhandler : GxBaseBuilder
{
   string cs_path = "." ;
   public bldanotificationsregistrationhandler( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldanotificationsregistrationhandler x = new bldanotificationsregistrationhandler() ;
      x.SetMainSourceFile( "anotificationsregistrationhandler.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"anotificationsregistrationhandler", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.por.dll", cs_path + @"\messages.por.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtGx0010sd_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGx0030sd_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDCometarios_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDCometarios_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDRanking_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_Section_GeneralSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_Section_Temporadas_Grid2Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesSerie_Serie_Section_TemporadasSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioSerie_UsuarioSerie_Section_GeneralSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSerie.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtEpisodio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtUsuarioSerie.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtUsuarioEpisodio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMDescription.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMProperty.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMError.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeSimple.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMCountry.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMCountryLanguages.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepository.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUpdateRepositoryConfiguration.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUpdateRepositoryConfigurationApplicationsToImport.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMLoginAdditionalParameters.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSecurityPolicy.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUserFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUserAttribute.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUserAttributeMultiValues.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRoleFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplication.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationEnvironment.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationDelegateAuthorization.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationPermissionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationPermission.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationToken.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationTokenElement.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationMenuFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationMenu.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationMenuOptionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationMenuOption.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMMenuAdditionalParameters.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMMenuOptionList.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMPermissionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMPermission.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUserRepositoryFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUserRepository.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionLogFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionLog.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionLogLoginRetry.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionFullLog.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSecurityPolicyFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryConnectionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryConnection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryConnectionAddressList.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMApplicationFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSession.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionLoginRetry.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionRole.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMEventSubscriptionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMEventSubscription.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMUsersCountFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMSessionsCountFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationFacebook.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeFacebook.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeLocal.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeWebService.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationWebService.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationWebServiceServer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTwitter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeTwitter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAM.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryCreate.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMImportRepositoryConfiguration.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMRepositoryConnectionFileFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMConnectionInfo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMConnectionInfoProperties.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMCleanSessionLogFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationGoogle.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeGoogle.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationCustom.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeCustom.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationGAMRemote.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGAMAuthenticationTypeGAMRemote.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAuthenticationTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMBrowser.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMErrorMessages.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMGenerateAuditory.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMGenerateSessionStatistics.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMIdentificatorKey.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMMenuOptionType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMPermissionAccessType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRecoveryPasswordTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRememberUserTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRepositoryConnectionTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMSessionStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMSessionType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAPiMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRepositoryUserIdentifications.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMApplicationAuthorizarionRequestType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMApplicationType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAutExtOAuthVersions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAutExtOpenIdVersions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAutExtWebServiceVersions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMExternalAuthentication.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMVersion.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMUserListOrder.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAllowMultipleConcurrentSessions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMPermissionAccessTypeDefault.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMPermissionTypeFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMBooleanFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMExternalAuthorizationVersions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMSessionLogListOrder.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMTracing.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMInternalGUIDs.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAPIModes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRemoteLogoutBehaviors.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMEvents.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMEventSubscriptionStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMSessionLogType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMOptionFilter.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINActionTexts.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGenero.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTipoConquista.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTipoUsuario.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTipoComentario.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINWWPDomains.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINExportType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINHomeSampleDataStatus.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerChartType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerOutputType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerPlotSeries.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerShowDataAs.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerOrientation.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerTrendPeriod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerXAxisLabels.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAggregationType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAxisOrderType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerAxisType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerConditionOperator.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerExpandCollapse.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerFilterType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerObjectType.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerSubtotals.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINQueryViewerShowDataLabelsIn.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMUserActivationMethod.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMUserGender.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMRepositoryRememberUserTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGAMAuthenticationFunctions.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.por.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.por.txt" ))
            return true;
      }
      return false ;
   }

}

