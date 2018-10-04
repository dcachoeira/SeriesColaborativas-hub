/*
               File: SecGAMUpdatePermissions
        Description: Sec GAMUpdate Permissions
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:49.48
       Program type: Main program
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class asecgamupdatepermissions : GXProcedure
   {
      public static int Main( String[] args )
      {
         try
         {
            ArrayList args1 =  new ArrayList();
            foreach( string arg in args) {
                if (arg.StartsWith("\\config:"))
                    GeneXus.Configuration.Config.ConfigFileName = arg.Substring( 8) ;
                else
                    args1.Add( arg);
            }
            args = (string[])(args1.ToArray( typeof(string)));
            new asecgamupdatepermissions().execute();
            return 0 ;
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            Console.WriteLine( e .ToString());
            return 1 ;
         }
      }

      public void executeCmdLine( String[] args )
      {
         execute();
      }

      public asecgamupdatepermissions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public asecgamupdatepermissions( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         asecgamupdatepermissions objasecgamupdatepermissions;
         objasecgamupdatepermissions = new asecgamupdatepermissions();
         objasecgamupdatepermissions.context.SetSubmitInitialConfig(context);
         objasecgamupdatepermissions.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objasecgamupdatepermissions);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((asecgamupdatepermissions)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            Console.WriteLine( e .ToString());
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV24RoleName = "";
         AV14GAMApplicationId = "";
         context.StatusMessage( StringUtil.Format( "Administrator role: '%1'", AV24RoleName, "", "", "", "", "", "", "", "") );
         context.StatusMessage( StringUtil.Format( "GAM application id: '%1'", AV14GAMApplicationId, "", "", "", "", "", "", "", "") );
         AV13GAMApplication = new SdtGAMRepository(context).getapplicationbyguid(StringUtil.StrToGuid( AV14GAMApplicationId).ToString(), out  AV11Errors);
         GXt_objcol_SdtSecGAMFunctionalitiesToLoad1 = AV27SecGAMFunctionalitiesToLoadCollection;
         new GeneXus.Programs.wwpbaseobjects.secgamgetadvancedsecuritywwpfunctionalities(context ).execute( out  GXt_objcol_SdtSecGAMFunctionalitiesToLoad1) ;
         AV27SecGAMFunctionalitiesToLoadCollection = GXt_objcol_SdtSecGAMFunctionalitiesToLoad1;
         AV23isOK = true;
         AV18GAMApplicationPermissions = AV13GAMApplication.getpermissions(AV16GAMApplicationPermissionFilter, out  AV11Errors);
         AV21GAMRoleFilter.gxTpr_Name = AV24RoleName;
         AV30GXV1 = 1;
         while ( AV30GXV1 <= AV18GAMApplicationPermissions.Count )
         {
            AV15GAMApplicationPermission = ((SdtGAMApplicationPermission)AV18GAMApplicationPermissions.Item(AV30GXV1));
            if ( ! ( ( StringUtil.StrCmp(StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name), "is_gam_administrator") == 0 ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "%_execute" , 254 , "%"),  ' ' ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "%_insert" , 254 , "%"),  ' ' ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "%_update" , 254 , "%"),  ' ' ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "%_delete" , 254 , "%"),  ' ' ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "%_fullcontrol" , 254 , "%"),  ' ' ) || StringUtil.Like( StringUtil.Lower( AV15GAMApplicationPermission.gxTpr_Name) , StringUtil.PadR( "custom_%" , 254 , "%"),  ' ' ) ) )
            {
               AV17GAMApplicationPermissionName = AV15GAMApplicationPermission.gxTpr_Name;
               /* Execute user subroutine: 'SEARCHPERMISSIONINDATAPROVIDER' */
               S111 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               if ( ! AV12Exists )
               {
                  AV32GXV3 = 1;
                  AV31GXV2 = new SdtGAMRepository(context).getroles(AV21GAMRoleFilter, out  AV11Errors);
                  while ( AV32GXV3 <= AV31GXV2.Count )
                  {
                     AV20GAMRole = ((SdtGAMRole)AV31GXV2.Item(AV32GXV3));
                     AV8GAMPermissionFilter.gxTpr_Applicationid = AV13GAMApplication.gxTpr_Id;
                     AV8GAMPermissionFilter.gxTpr_Name = StringUtil.Trim( AV15GAMApplicationPermission.gxTpr_Name);
                     AV34GXV5 = 1;
                     AV33GXV4 = AV20GAMRole.getpermissions(AV8GAMPermissionFilter, out  AV11Errors);
                     while ( AV34GXV5 <= AV33GXV4.Count )
                     {
                        AV19GAMPermission = ((SdtGAMPermission)AV33GXV4.Item(AV34GXV5));
                        context.StatusMessage( StringUtil.Format( "Deleting permission '%1' from role '%2'...", StringUtil.Trim( AV15GAMApplicationPermission.gxTpr_Name), StringUtil.Trim( AV20GAMRole.gxTpr_Name), "", "", "", "", "", "", "") );
                        AV23isOK = AV20GAMRole.deletepermission(AV19GAMPermission, out  AV11Errors);
                        if ( ! AV23isOK )
                        {
                           context.StatusMessage( StringUtil.Format( "The following errors ocurred while deleting permission '%1' from role '%2':", StringUtil.Trim( AV15GAMApplicationPermission.gxTpr_Name), AV20GAMRole.gxTpr_Name, "", "", "", "", "", "", "") );
                           /* Execute user subroutine: 'SHOWERRORMESSAGES' */
                           S131 ();
                           if ( returnInSub )
                           {
                              this.cleanup();
                              if (true) return;
                           }
                        }
                        AV34GXV5 = (int)(AV34GXV5+1);
                     }
                     AV32GXV3 = (int)(AV32GXV3+1);
                  }
                  context.StatusMessage( StringUtil.Format( "Deleting permission '%1' from GAM repository...", StringUtil.Trim( AV15GAMApplicationPermission.gxTpr_Name), "", "", "", "", "", "", "", "") );
                  AV23isOK = AV13GAMApplication.deletepermission(AV15GAMApplicationPermission, out  AV11Errors);
                  if ( ! AV23isOK )
                  {
                     context.StatusMessage( StringUtil.Format( "The following errors ocurred while deleting permission '%1':", AV15GAMApplicationPermission.gxTpr_Name, "", "", "", "", "", "", "", "") );
                     /* Execute user subroutine: 'SHOWERRORMESSAGES' */
                     S131 ();
                     if ( returnInSub )
                     {
                        this.cleanup();
                        if (true) return;
                     }
                  }
               }
            }
            AV30GXV1 = (int)(AV30GXV1+1);
         }
         if ( AV23isOK )
         {
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV24RoleName))) )
            {
               context.StatusMessage( StringUtil.Format( "Getting role '%1' from GAM repository...", AV24RoleName, "", "", "", "", "", "", "", "") );
               AV13GAMApplication = new SdtGAMRepository(context).getapplicationbyguid(StringUtil.StrToGuid( AV14GAMApplicationId).ToString(), out  AV11Errors);
               AV36GXV7 = 1;
               AV35GXV6 = new SdtGAMRepository(context).getroles(AV21GAMRoleFilter, out  AV11Errors);
               while ( AV36GXV7 <= AV35GXV6.Count )
               {
                  AV20GAMRole = ((SdtGAMRole)AV35GXV6.Item(AV36GXV7));
                  if ( StringUtil.StrCmp(StringUtil.Trim( AV20GAMRole.gxTpr_Name), StringUtil.Trim( AV24RoleName)) == 0 )
                  {
                     AV22Id = AV20GAMRole.gxTpr_Id;
                     if (true) break;
                  }
                  AV36GXV7 = (int)(AV36GXV7+1);
               }
               if ( (0==AV22Id) )
               {
                  context.StatusMessage( StringUtil.Format( "Role '%1' not found", AV24RoleName, "", "", "", "", "", "", "", "") );
                  AV21GAMRoleFilter = new SdtGAMRoleFilter(context);
                  AV25RoleNames = "";
                  AV38GXV9 = 1;
                  AV37GXV8 = new SdtGAMRepository(context).getroles(AV21GAMRoleFilter, out  AV11Errors);
                  while ( AV38GXV9 <= AV37GXV8.Count )
                  {
                     AV20GAMRole = ((SdtGAMRole)AV37GXV8.Item(AV38GXV9));
                     AV25RoleNames = AV25RoleNames + ", " + StringUtil.Trim( AV20GAMRole.gxTpr_Name);
                     AV38GXV9 = (int)(AV38GXV9+1);
                  }
                  if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25RoleNames)) )
                  {
                     context.StatusMessage( StringUtil.Format( "The available roles are: %1", StringUtil.Substring( AV25RoleNames, 3, StringUtil.Len( AV25RoleNames)-2), "", "", "", "", "", "", "", "") );
                  }
               }
            }
            if ( ! (0==AV22Id) )
            {
               AV20GAMRole.load( AV22Id);
            }
            AV39GXV10 = 1;
            while ( AV39GXV10 <= AV27SecGAMFunctionalitiesToLoadCollection.Count )
            {
               AV26SecGAMFunctionalitiesToLoad = ((GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad)AV27SecGAMFunctionalitiesToLoadCollection.Item(AV39GXV10));
               /* Execute user subroutine: 'SEARCHPERMISSIONALREADYCREATED' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               if ( ! AV12Exists )
               {
                  AV9ApplicationPermission = new SdtGAMApplicationPermission(context);
                  AV9ApplicationPermission.gxTpr_Name = AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitykey;
                  if ( StringUtil.StrCmp(AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitydsc, "") != 0 )
                  {
                     AV9ApplicationPermission.gxTpr_Description = AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitydsc;
                  }
                  else
                  {
                     AV9ApplicationPermission.gxTpr_Description = AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitykey;
                  }
                  AV9ApplicationPermission.gxTpr_Accesstype = "R";
                  context.StatusMessage( StringUtil.Format( "Adding permission '%1' to GAM repository...", StringUtil.Trim( AV9ApplicationPermission.gxTpr_Name), "", "", "", "", "", "", "", "") );
                  AV23isOK = AV13GAMApplication.addpermission(AV9ApplicationPermission, out  AV11Errors);
                  if ( AV23isOK )
                  {
                     if ( ! (0==AV22Id) )
                     {
                        AV19GAMPermission = new SdtGAMPermission(context);
                        AV19GAMPermission.gxTpr_Applicationid = AV13GAMApplication.gxTpr_Id;
                        AV19GAMPermission.gxTpr_Description = AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitykey;
                        AV19GAMPermission.gxTpr_Name = AV9ApplicationPermission.gxTpr_Name;
                        AV19GAMPermission.gxTpr_Type = "A";
                        AV19GAMPermission.gxTpr_Guid = AV9ApplicationPermission.gxTpr_Guid;
                        context.StatusMessage( StringUtil.Format( "Adding permission '%1' to role '%2'...", StringUtil.Trim( AV9ApplicationPermission.gxTpr_Name), AV24RoleName, "", "", "", "", "", "", "") );
                        AV23isOK = AV20GAMRole.addpermission(AV19GAMPermission, out  AV11Errors);
                        if ( ! AV23isOK )
                        {
                           context.StatusMessage( StringUtil.Format( "The following errors ocurred while adding permission '%1' to role '%2':", StringUtil.Trim( AV9ApplicationPermission.gxTpr_Name), AV24RoleName, "", "", "", "", "", "", "") );
                           /* Execute user subroutine: 'SHOWERRORMESSAGES' */
                           S131 ();
                           if ( returnInSub )
                           {
                              this.cleanup();
                              if (true) return;
                           }
                        }
                     }
                  }
                  else
                  {
                     context.StatusMessage( StringUtil.Format( "The following errors ocurred while adding permission '%1':", StringUtil.Trim( AV9ApplicationPermission.gxTpr_Name), "", "", "", "", "", "", "", "") );
                     /* Execute user subroutine: 'SHOWERRORMESSAGES' */
                     S131 ();
                     if ( returnInSub )
                     {
                        this.cleanup();
                        if (true) return;
                     }
                  }
               }
               AV39GXV10 = (int)(AV39GXV10+1);
            }
         }
         if ( AV23isOK )
         {
            pr_gam.commit( "SecGAMUpdatePermissions");
            pr_default.commit( "SecGAMUpdatePermissions");
            context.StatusMessage( "The changes were commited" );
         }
         else
         {
            context.StatusMessage( "The changes were not commited" );
         }
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'SEARCHPERMISSIONINDATAPROVIDER' Routine */
         AV12Exists = false;
         AV40GXV11 = 1;
         while ( AV40GXV11 <= AV27SecGAMFunctionalitiesToLoadCollection.Count )
         {
            AV26SecGAMFunctionalitiesToLoad = ((GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad)AV27SecGAMFunctionalitiesToLoadCollection.Item(AV40GXV11));
            if ( StringUtil.StrCmp(AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitykey, AV17GAMApplicationPermissionName) == 0 )
            {
               AV12Exists = true;
               if (true) break;
            }
            AV40GXV11 = (int)(AV40GXV11+1);
         }
      }

      protected void S121( )
      {
         /* 'SEARCHPERMISSIONALREADYCREATED' Routine */
         AV12Exists = false;
         AV41GXV12 = 1;
         while ( AV41GXV12 <= AV18GAMApplicationPermissions.Count )
         {
            AV15GAMApplicationPermission = ((SdtGAMApplicationPermission)AV18GAMApplicationPermissions.Item(AV41GXV12));
            if ( StringUtil.StrCmp(AV15GAMApplicationPermission.gxTpr_Name, AV26SecGAMFunctionalitiesToLoad.gxTpr_Secgamfunctionalitykey) == 0 )
            {
               AV12Exists = true;
               if (true) break;
            }
            AV41GXV12 = (int)(AV41GXV12+1);
         }
      }

      protected void S131( )
      {
         /* 'SHOWERRORMESSAGES' Routine */
         AV42GXV13 = 1;
         while ( AV42GXV13 <= AV11Errors.Count )
         {
            AV10Error = ((SdtGAMError)AV11Errors.Item(AV42GXV13));
            context.StatusMessage( StringUtil.Format( "%1 (GAM%2)", AV10Error.gxTpr_Message, StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Error.gxTpr_Code), 12, 0)), "", "", "", "", "", "", "") );
            AV42GXV13 = (int)(AV42GXV13+1);
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
         AV24RoleName = "";
         AV14GAMApplicationId = "";
         AV13GAMApplication = new SdtGAMApplication(context);
         AV11Errors = new GXExternalCollection<SdtGAMError>( context, "SdtGAMError", "GeneXus.Programs");
         AV27SecGAMFunctionalitiesToLoadCollection = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad>( context, "SecGAMFunctionalitiesToLoad", "SeriesColaborativas");
         GXt_objcol_SdtSecGAMFunctionalitiesToLoad1 = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad>( context, "SecGAMFunctionalitiesToLoad", "SeriesColaborativas");
         AV18GAMApplicationPermissions = new GXExternalCollection<SdtGAMApplicationPermission>( context, "SdtGAMApplicationPermission", "GeneXus.Programs");
         AV16GAMApplicationPermissionFilter = new SdtGAMApplicationPermissionFilter(context);
         AV21GAMRoleFilter = new SdtGAMRoleFilter(context);
         AV15GAMApplicationPermission = new SdtGAMApplicationPermission(context);
         AV17GAMApplicationPermissionName = "";
         AV31GXV2 = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV20GAMRole = new SdtGAMRole(context);
         AV8GAMPermissionFilter = new SdtGAMPermissionFilter(context);
         AV33GXV4 = new GXExternalCollection<SdtGAMPermission>( context, "SdtGAMPermission", "GeneXus.Programs");
         AV19GAMPermission = new SdtGAMPermission(context);
         AV35GXV6 = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV25RoleNames = "";
         AV37GXV8 = new GXExternalCollection<SdtGAMRole>( context, "SdtGAMRole", "GeneXus.Programs");
         AV26SecGAMFunctionalitiesToLoad = new GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad(context);
         AV9ApplicationPermission = new SdtGAMApplicationPermission(context);
         AV10Error = new SdtGAMError(context);
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.asecgamupdatepermissions__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.asecgamupdatepermissions__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV30GXV1 ;
      private int AV32GXV3 ;
      private int AV34GXV5 ;
      private int AV36GXV7 ;
      private int AV38GXV9 ;
      private int AV39GXV10 ;
      private int AV40GXV11 ;
      private int AV41GXV12 ;
      private int AV42GXV13 ;
      private long AV22Id ;
      private String AV14GAMApplicationId ;
      private String AV17GAMApplicationPermissionName ;
      private bool AV23isOK ;
      private bool returnInSub ;
      private bool AV12Exists ;
      private String AV24RoleName ;
      private String AV25RoleNames ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private GXExternalCollection<SdtGAMApplicationPermission> AV18GAMApplicationPermissions ;
      private GXExternalCollection<SdtGAMError> AV11Errors ;
      private GXExternalCollection<SdtGAMRole> AV31GXV2 ;
      private GXExternalCollection<SdtGAMRole> AV35GXV6 ;
      private GXExternalCollection<SdtGAMRole> AV37GXV8 ;
      private GXExternalCollection<SdtGAMPermission> AV33GXV4 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad> AV27SecGAMFunctionalitiesToLoadCollection ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad> GXt_objcol_SdtSecGAMFunctionalitiesToLoad1 ;
      private SdtGAMPermissionFilter AV8GAMPermissionFilter ;
      private SdtGAMApplicationPermission AV15GAMApplicationPermission ;
      private SdtGAMApplicationPermission AV9ApplicationPermission ;
      private SdtGAMError AV10Error ;
      private SdtGAMApplication AV13GAMApplication ;
      private SdtGAMApplicationPermissionFilter AV16GAMApplicationPermissionFilter ;
      private SdtGAMRole AV20GAMRole ;
      private SdtGAMRoleFilter AV21GAMRoleFilter ;
      private SdtGAMPermission AV19GAMPermission ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecGAMFunctionalitiesToLoad AV26SecGAMFunctionalitiesToLoad ;
   }

   public class asecgamupdatepermissions__gam : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "GAM";
    }

 }

 public class asecgamupdatepermissions__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
