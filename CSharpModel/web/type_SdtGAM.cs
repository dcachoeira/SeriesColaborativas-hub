/*
               File: type_SdtGAM
        Description: GAM
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:46:45.72
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtGAM : GxUserType, IGxExternalObject
   {
      public SdtGAM( )
      {
         /* Constructor for serialization */
      }

      public SdtGAM( IGxContext context )
      {
         this.context = context;
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public bool createrepository( SdtGAMRepositoryCreate gxTp_Repository ,
                                    bool gxTp_UpdateConnectionFile ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returncreaterepository ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returncreaterepository = false;
         Artech.Security.GAMRepositoryCreate externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRepositoryCreate)(gxTp_Repository.ExternalInstance);
         returncreaterepository = (bool)(GAM_externalReference.CreateRepository(externalParm0, gxTp_UpdateConnectionFile, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returncreaterepository ;
      }

      public GXExternalCollection<SdtGAMRepository> getallrepositories( SdtGAMRepositoryFilter gxTp_RepositoryFilter ,
                                                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         GXExternalCollection<SdtGAMRepository> returngetallrepositories ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returngetallrepositories = new GXExternalCollection<SdtGAMRepository>( context, "SdtGAMRepository", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMRepository> externalParm0 ;
         Artech.Security.GAMRepositoryFilter externalParm1 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm2 ;
         externalParm1 = (Artech.Security.GAMRepositoryFilter)(gxTp_RepositoryFilter.ExternalInstance);
         externalParm0 = GAM_externalReference.GetAllRepositories(externalParm1, out externalParm2);
         returngetallrepositories.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRepository>), externalParm0);
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm2);
         return returngetallrepositories ;
      }

      public bool updaterepository( SdtGAMRepository gxTp_Repository ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnupdaterepository ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returnupdaterepository = false;
         Artech.Security.GAMRepository externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMRepository)(gxTp_Repository.ExternalInstance);
         returnupdaterepository = (bool)(GAM_externalReference.UpdateRepository(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnupdaterepository ;
      }

      public bool deleterepository( String gxTp_GUID ,
                                    out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returndeleterepository ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returndeleterepository = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returndeleterepository = (bool)(GAM_externalReference.DeleteRepository(gxTp_GUID, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returndeleterepository ;
      }

      public bool createrepositoryfrompackage( SdtGAMImportRepositoryConfiguration gxTp_ImportConfiguration ,
                                               out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returncreaterepositoryfrompackage ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returncreaterepositoryfrompackage = false;
         Artech.Security.GAMImportRepositoryConfiguration externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMImportRepositoryConfiguration)(gxTp_ImportConfiguration.ExternalInstance);
         returncreaterepositoryfrompackage = (bool)(GAM_externalReference.CreateRepositoryFromPackage(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returncreaterepositoryfrompackage ;
      }

      public bool repositoryuserenable( int gxTp_RepositoryId ,
                                        SdtGAMUser gxTp_User ,
                                        long gxTp_RoleId ,
                                        out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnrepositoryuserenable ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returnrepositoryuserenable = false;
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUser)(gxTp_User.ExternalInstance);
         returnrepositoryuserenable = (bool)(GAM_externalReference.RepositoryUserEnable(gxTp_RepositoryId, externalParm0, gxTp_RoleId, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnrepositoryuserenable ;
      }

      public bool repositoryuserdisable( int gxTp_RepositoryId ,
                                         SdtGAMUser gxTp_User ,
                                         out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnrepositoryuserdisable ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returnrepositoryuserdisable = false;
         Artech.Security.GAMUser externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMUser)(gxTp_User.ExternalInstance);
         returnrepositoryuserdisable = (bool)(GAM_externalReference.RepositoryUserDisable(gxTp_RepositoryId, externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returnrepositoryuserdisable ;
      }

      public bool getconnectionsfile( String gxTp_UserName ,
                                      String gxTp_Password ,
                                      GXExternalCollection<SdtGAMRepositoryConnectionFileFilter> gxTp_ConnectionsFilters ,
                                      out String gxTp_TextXML ,
                                      out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returngetconnectionsfile ;
         gxTp_TextXML = "";
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returngetconnectionsfile = false;
         System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionFileFilter> externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionFileFilter>)CollectionUtils.ConvertToExternal( typeof(System.Collections.Generic.List<Artech.Security.GAMRepositoryConnectionFileFilter>), gxTp_ConnectionsFilters.ExternalInstance);
         returngetconnectionsfile = (bool)(GAM_externalReference.GetConnectionsFile(gxTp_UserName, gxTp_Password, externalParm0, out gxTp_TextXML, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returngetconnectionsfile ;
      }

      public int getactivesessioncount( out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         int returngetactivesessioncount ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returngetactivesessioncount = 0;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returngetactivesessioncount = (int)(GAM_externalReference.GetActiveSessionCount(out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returngetactivesessioncount ;
      }

      public bool setconnection( String gxTp_ConnectionName ,
                                 out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returnsetconnection ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returnsetconnection = false;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm0 ;
         returnsetconnection = (bool)(GAM_externalReference.SetConnection(gxTp_ConnectionName, out externalParm0));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm0);
         return returnsetconnection ;
      }

      public GXExternalCollection<SdtGAMConnectionInfo> getconnections( )
      {
         GXExternalCollection<SdtGAMConnectionInfo> returngetconnections ;
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returngetconnections = new GXExternalCollection<SdtGAMConnectionInfo>( context, "SdtGAMConnectionInfo", "GeneXus.Programs");
         System.Collections.Generic.List<Artech.Security.GAMConnectionInfo> externalParm0 ;
         externalParm0 = GAM_externalReference.GetConnections();
         returngetconnections.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMConnectionInfo>), externalParm0);
         return returngetconnections ;
      }

      public bool checkconnection( )
      {
         bool returncheckconnection ;
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returncheckconnection = false;
         returncheckconnection = (bool)(GAM_externalReference.CheckConnection());
         return returncheckconnection ;
      }

      public bool cleansessionlog( SdtGAMCleanSessionLogFilter gxTp_CleanSessionLogFilter ,
                                   out GXExternalCollection<SdtGAMError> gxTp_Errors )
      {
         bool returncleansessionlog ;
         gxTp_Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returncleansessionlog = false;
         Artech.Security.GAMCleanSessionLogFilter externalParm0 ;
         System.Collections.Generic.List<Artech.Security.GAMError> externalParm1 ;
         externalParm0 = (Artech.Security.GAMCleanSessionLogFilter)(gxTp_CleanSessionLogFilter.ExternalInstance);
         returncleansessionlog = (bool)(GAM_externalReference.CleanSessionLog(externalParm0, out externalParm1));
         gxTp_Errors.ExternalInstance = (IList)CollectionUtils.ConvertToInternal( typeof(System.Collections.Generic.List<Artech.Security.GAMError>), externalParm1);
         return returncleansessionlog ;
      }

      public String tostring( )
      {
         String returntostring ;
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returntostring = "";
         returntostring = (String)(GAM_externalReference.ToString());
         return returntostring ;
      }

      public String tojsonstring( )
      {
         String returntojsonstring ;
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returntojsonstring = "";
         returntojsonstring = (String)(GAM_externalReference.ToJsonString());
         return returntojsonstring ;
      }

      public bool fromjsonstring( String gxTp_Json )
      {
         bool returnfromjsonstring ;
         if ( GAM_externalReference == null )
         {
            GAM_externalReference = new Artech.Security.GAM(context);
         }
         returnfromjsonstring = false;
         returnfromjsonstring = (bool)(GAM_externalReference.FromJsonString(gxTp_Json));
         return returnfromjsonstring ;
      }

      public short gxTpr_Version
      {
         get {
            if ( GAM_externalReference == null )
            {
               GAM_externalReference = new Artech.Security.GAM(context);
            }
            return GAM_externalReference.Version ;
         }

         set {
            if ( GAM_externalReference == null )
            {
               GAM_externalReference = new Artech.Security.GAM(context);
            }
            GAM_externalReference.Version = value;
            SetDirty("Version");
         }

      }

      public Object ExternalInstance
      {
         get {
            if ( GAM_externalReference == null )
            {
               GAM_externalReference = new Artech.Security.GAM(context);
            }
            return GAM_externalReference ;
         }

         set {
            GAM_externalReference = (Artech.Security.GAM)(value);
         }

      }

      public void initialize( )
      {
         return  ;
      }

      protected Artech.Security.GAM GAM_externalReference=null ;
   }

}
