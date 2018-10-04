using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
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
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
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
      sc.Add( @"sdsvc_Gx0010sd_Level_Detail", "dll");
      sc.Add( @"sdsvc_WorkWithDevicesUsuarioSerie_UsuarioSerie_Section_General", "dll");
      sc.Add( @"sdsvc_WorkWithDevicesSerie_Serie_Section_General", "dll");
      sc.Add( @"sdsvc_WorkWithDevicesUsuarioConquista_UsuarioConquista_Section_General", "dll");
      sc.Add( @"sdcomentarios_level_detail_grid1", "dll");
      sc.Add( @"sdcomentarios_level_detail", "dll");
      sc.Add( @"sdcometarios_level_detail_grid1", "dll");
      sc.Add( @"sdcometarios_level_detail_grid2", "dll");
      sc.Add( @"sdcometarios_level_detail", "dll");
      sc.Add( @"sdranking_level_detail_grid1", "dll");
      sc.Add( @"gx0070sd_level_detail_grid1", "dll");
      sc.Add( @"gx0010sd_level_detail_grid1", "dll");
      sc.Add( @"gx0030sd_level_detail_grid1", "dll");
      sc.Add( @"gx00b0sd_level_detail_grid1", "dll");
      sc.Add( @"workwithdevicesnotificacao_notificacao_list_grid1", "dll");
      sc.Add( @"workwithdevicesnotificacao_notificacao_list", "dll");
      sc.Add( @"workwithdevicesnotificacao_notificacao_detail", "dll");
      sc.Add( @"workwithdevicesnotificacao_notificacao_section_general", "dll");
      sc.Add( @"workwithdevicesusuarioserie_usuarioserie_list_grid1", "dll");
      sc.Add( @"workwithdevicesusuarioserie_usuarioserie_list", "dll");
      sc.Add( @"workwithdevicesusuarioserie_usuarioserie_detail", "dll");
      sc.Add( @"workwithdevicesusuarioserie_usuarioserie_section_general", "dll");
      sc.Add( @"workwithdevicesserie_serie_list_grid1", "dll");
      sc.Add( @"workwithdevicesserie_serie_list", "dll");
      sc.Add( @"workwithdevicesserie_serie_detail", "dll");
      sc.Add( @"workwithdevicesserie_serie_section_general", "dll");
      sc.Add( @"workwithdevicesserie_serie_section_temporadas_grid2", "dll");
      sc.Add( @"workwithdevicesserie_serie_section_temporadas", "dll");
      sc.Add( @"sdseries_sdseries_list_grid1", "dll");
      sc.Add( @"sdseries_sdseries_list", "dll");
      sc.Add( @"workwithdevicesepisodio_episodio_list_grid1", "dll");
      sc.Add( @"workwithdevicesepisodio_episodio_list", "dll");
      sc.Add( @"workwithdevicesepisodio_episodio_detail", "dll");
      sc.Add( @"workwithdevicesepisodio_episodio_section_general", "dll");
      sc.Add( @"workwithdevicesusuarioconquista_usuarioconquista_list_grid1", "dll");
      sc.Add( @"workwithdevicesusuarioconquista_usuarioconquista_list_grid2", "dll");
      sc.Add( @"workwithdevicesusuarioconquista_usuarioconquista_list", "dll");
      sc.Add( @"workwithdevicesusuarioconquista_usuarioconquista_detail", "dll");
      sc.Add( @"workwithdevicesusuarioconquista_usuarioconquista_section_general", "dll");
      sc.Add( @"wwpbaseobjects\gethomesampledata", "dll");
      sc.Add( @"wwpbaseobjects\gethomesamplenamevaluedata", "dll");
      sc.Add( @"asecgamupdatepermissions", "exe");
      sc.Add( @"seriewwgetfilterdata", "dll");
      sc.Add( @"conquistawwgetfilterdata", "dll");
      sc.Add( @"generowwgetfilterdata", "dll");
      sc.Add( @"usuariowwgetfilterdata", "dll");
      sc.Add( @"log", "dll");
      sc.Add( @"anotificationsregistrationhandler", "dll");
      sc.Add( @"gxaftereventreplicator", "dll");
      sc.Add( @"gxonpendingeventfailed", "dll");
      sc.Add( @"gravarseriefavoritausuario", "dll");
      sc.Add( @"gravarserieassistidausuario", "dll");
      sc.Add( @"verificarpossuiseriefavorita", "dll");
      sc.Add( @"buscardadosusuario", "dll");
      sc.Add( @"gravarserieassistidausuariointerno", "dll");
      sc.Add( @"gravarepisodioassistido", "dll");
      sc.Add( @"gravarepisodiofavorito", "dll");
      sc.Add( @"gravardadosavaliacaousuario", "dll");
      sc.Add( @"verificarconquistasusuario", "dll");
      sc.Add( @"setarimagem", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"wwpbaseobjects\addressdisplay", "dll");
      sc.Add( @"wwpbaseobjects\exportoptions", "dll");
      sc.Add( @"wwpbaseobjects\home", "dll");
      sc.Add( @"wwpbaseobjects\managefilters", "dll");
      sc.Add( @"wwpbaseobjects\promptgeolocation", "dll");
      sc.Add( @"wwpbaseobjects\savefilteras", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsarrowwc", "dll");
      sc.Add( @"wwpbaseobjects\wizardstepsbulletwc", "dll");
      sc.Add( @"wwpbaseobjects\wwptabbedview", "dll");
      sc.Add( @"wwpbaseobjects\notauthorized", "dll");
      sc.Add( @"gamlogout", "dll");
      sc.Add( @"login", "dll");
      sc.Add( @"gamuserentry", "dll");
      sc.Add( @"gammasterpage", "dll");
      sc.Add( @"gamchangeyourpassword", "dll");
      sc.Add( @"gamhome", "dll");
      sc.Add( @"gamwwroles", "dll");
      sc.Add( @"gamroleentry", "dll");
      sc.Add( @"gamwwusers", "dll");
      sc.Add( @"gamwwsecuritypolicy", "dll");
      sc.Add( @"gamsecuritypolicyentry", "dll");
      sc.Add( @"gamwwrolepermissions", "dll");
      sc.Add( @"gamwwroleroles", "dll");
      sc.Add( @"gamwwuserroles", "dll");
      sc.Add( @"gamsetpassword", "dll");
      sc.Add( @"gamwwrepositories", "dll");
      sc.Add( @"gamrepositoryentry", "dll");
      sc.Add( @"gamrepositoryconfiguration", "dll");
      sc.Add( @"gamwwauthtypes", "dll");
      sc.Add( @"gamauthenticationtypeentry", "dll");
      sc.Add( @"gamtestexternallogin", "dll");
      sc.Add( @"gamwwconnections", "dll");
      sc.Add( @"gamconnectionentry", "dll");
      sc.Add( @"gamchangepassword", "dll");
      sc.Add( @"gamupdateregisteruser", "dll");
      sc.Add( @"gamrecoverpasswordstep1", "dll");
      sc.Add( @"gamregisteruser", "dll");
      sc.Add( @"gamheader", "dll");
      sc.Add( @"gamexamplenotauthorized", "dll");
      sc.Add( @"gamrecoverpasswordstep2", "dll");
      sc.Add( @"gamwwapplications", "dll");
      sc.Add( @"gamapplicationentry", "dll");
      sc.Add( @"gamuserroleselect", "dll");
      sc.Add( @"gamwwapppermissions", "dll");
      sc.Add( @"gamwwappmenus", "dll");
      sc.Add( @"gamrolepermissionselect", "dll");
      sc.Add( @"gamapppermissionentry", "dll");
      sc.Add( @"gamapppermissionchildren", "dll");
      sc.Add( @"gamapppermissionselect", "dll");
      sc.Add( @"gamchangerepository", "dll");
      sc.Add( @"gamroleselect", "dll");
      sc.Add( @"gamremotelogin", "dll");
      sc.Add( @"gamssologin", "dll");
      sc.Add( @"gamwweventsubscriptions", "dll");
      sc.Add( @"gameventsubscriptionentry", "dll");
      sc.Add( @"gamappmenuentry", "dll");
      sc.Add( @"gamwwappmenuoptions", "dll");
      sc.Add( @"gamappmenuoptionentry", "dll");
      sc.Add( @"gammenu", "dll");
      sc.Add( @"wwpbaseobjects\workwithplusmasterpage", "dll");
      sc.Add( @"gx0010", "dll");
      sc.Add( @"gx0020", "dll");
      sc.Add( @"gx0030", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx0050", "dll");
      sc.Add( @"gx0060", "dll");
      sc.Add( @"gx0070", "dll");
      sc.Add( @"gx0080", "dll");
      sc.Add( @"gx0090", "dll");
      sc.Add( @"gx00a0", "dll");
      sc.Add( @"serieww", "dll");
      sc.Add( @"cadastrotemporadas", "dll");
      sc.Add( @"conquistaww", "dll");
      sc.Add( @"generoww", "dll");
      sc.Add( @"usuarioww", "dll");
      sc.Add( @"homenew", "dll");
      sc.Add( @"serie", "dll");
      sc.Add( @"serie_bc", "dll");
      sc.Add( @"episodio", "dll");
      sc.Add( @"episodio_bc", "dll");
      sc.Add( @"usuario", "dll");
      sc.Add( @"usuarioserie", "dll");
      sc.Add( @"usuarioserie_bc", "dll");
      sc.Add( @"usuarioepisodio", "dll");
      sc.Add( @"notificacao", "dll");
      sc.Add( @"notificacao_bc", "dll");
      sc.Add( @"conquista", "dll");
      sc.Add( @"usuarioconquista", "dll");
      sc.Add( @"usuarioconquista_bc", "dll");
      sc.Add( @"usuariorecomendacaoserie", "dll");
      sc.Add( @"usuariorecomendacaoepisodio", "dll");
      sc.Add( @"genero", "dll");
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
         if (checkTime(obj, cs_path + @"\type_SdtGx0070sd_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtGx00B0sd_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDComentarios_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDComentarios_Level_Detail_Grid2Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDComentarios_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDCometarios_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDCometarios_Level_Detail_Grid2Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDCometarios_Level_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSDRanking_Level_Detail_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSdSeries_SdSeries_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSdSeries_SdSeries_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesEpisodio_Episodio_Section_GeneralSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesNotificacao_Notificacao_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesNotificacao_Notificacao_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesNotificacao_Notificacao_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesNotificacao_Notificacao_Section_GeneralSdt.cs" ))
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
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_DetailSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid1Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_List_Grid2Sdt_Item.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_ListSdt.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtWorkWithDevicesUsuarioConquista_UsuarioConquista_Section_GeneralSdt.cs" ))
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
         if (checkTime(obj, cs_path + @"\type_SdtUsuarioEpisodio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtEpisodio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtUsuarioConquista.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSerie.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtUsuarioSerie.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtNotificacao.cs" ))
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
         if (checkTime(obj, cs_path + @"\GXDOMAINTipoNotificacao.cs" ))
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

