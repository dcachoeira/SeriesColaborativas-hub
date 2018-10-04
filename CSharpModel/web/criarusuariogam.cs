/*
               File: CriarUsuarioGAM
        Description: Criar usuário GAM
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 9/20/2018 19:38:51.93
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class criarusuariogam : GXProcedure
   {
      public criarusuariogam( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public criarusuariogam( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsGAM = context.GetDataStore("GAM");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_UsuarioLogin ,
                           String aP1_UsuarioSenha ,
                           out String aP2_UsuarioGAMGuid )
      {
         this.AV8UsuarioLogin = aP0_UsuarioLogin;
         this.AV9UsuarioSenha = aP1_UsuarioSenha;
         this.AV10UsuarioGAMGuid = "" ;
         initialize();
         executePrivate();
         aP2_UsuarioGAMGuid=this.AV10UsuarioGAMGuid;
      }

      public String executeUdp( String aP0_UsuarioLogin ,
                                String aP1_UsuarioSenha )
      {
         this.AV8UsuarioLogin = aP0_UsuarioLogin;
         this.AV9UsuarioSenha = aP1_UsuarioSenha;
         this.AV10UsuarioGAMGuid = "" ;
         initialize();
         executePrivate();
         aP2_UsuarioGAMGuid=this.AV10UsuarioGAMGuid;
         return AV10UsuarioGAMGuid ;
      }

      public void executeSubmit( String aP0_UsuarioLogin ,
                                 String aP1_UsuarioSenha ,
                                 out String aP2_UsuarioGAMGuid )
      {
         criarusuariogam objcriarusuariogam;
         objcriarusuariogam = new criarusuariogam();
         objcriarusuariogam.AV8UsuarioLogin = aP0_UsuarioLogin;
         objcriarusuariogam.AV9UsuarioSenha = aP1_UsuarioSenha;
         objcriarusuariogam.AV10UsuarioGAMGuid = "" ;
         objcriarusuariogam.context.SetSubmitInitialConfig(context);
         objcriarusuariogam.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objcriarusuariogam);
         aP2_UsuarioGAMGuid=this.AV10UsuarioGAMGuid;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((criarusuariogam)stateInfo).executePrivate();
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
         AV12GAMUser.load( AV10UsuarioGAMGuid);
         if ( AV12GAMUser.fail() )
         {
            AV12GAMUser = new SdtGAMUser(context);
         }
         if ( StringUtil.Len( AV9UsuarioSenha) != 32 )
         {
            GXt_char1 = AV13UsuarioSenhaNova;
            new gerarmd5(context ).execute(  AV9UsuarioSenha, out  GXt_char1) ;
            AV13UsuarioSenhaNova = GXt_char1;
         }
         else
         {
            AV13UsuarioSenhaNova = AV9UsuarioSenha;
         }
         AV12GAMUser.gxTpr_Guid = Guid.NewGuid( ).ToString();
         AV12GAMUser.gxTpr_Password = AV13UsuarioSenhaNova;
         AV12GAMUser.gxTpr_Firstname = AV8UsuarioLogin;
         AV12GAMUser.gxTpr_Email = AV8UsuarioLogin+"@seriescolaborativas.com.br";
         AV12GAMUser.gxTpr_Name = AV8UsuarioLogin;
         AV12GAMUser.save();
         if ( AV12GAMUser.fail() )
         {
         }
         else
         {
            AV10UsuarioGAMGuid = AV12GAMUser.gxTpr_Guid;
            pr_gam.commit( "CriarUsuarioGAM");
            pr_default.commit( "CriarUsuarioGAM");
         }
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
         AV12GAMUser = new SdtGAMUser(context);
         AV13UsuarioSenhaNova = "";
         GXt_char1 = "";
         pr_gam = new DataStoreProvider(context, new GeneXus.Programs.criarusuariogam__gam(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.criarusuariogam__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV10UsuarioGAMGuid ;
      private String GXt_char1 ;
      private String AV8UsuarioLogin ;
      private String AV9UsuarioSenha ;
      private String AV13UsuarioSenhaNova ;
      private IGxDataStore dsGAM ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_gam ;
      private IDataStoreProvider pr_default ;
      private String aP2_UsuarioGAMGuid ;
      private SdtGAMUser AV12GAMUser ;
   }

   public class criarusuariogam__gam : DataStoreHelperBase, IDataStoreHelper
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

 public class criarusuariogam__default : DataStoreHelperBase, IDataStoreHelper
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
