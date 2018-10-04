/*
               File: type_SdtSDLogin_Level_DetailSdt
        Description: SDLogin_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/23/2018 19:59:55.12
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
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SDLogin_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDLogin_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDLogin_Level_DetailSdt : GxUserType
   {
      public SdtSDLogin_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail = "";
         gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha = "";
      }

      public SdtSDLogin_Level_DetailSdt( IGxContext context )
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

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDLogin_Level_DetailSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("UsuarioEmail", gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail, false);
         AddObjectProperty("UsuarioSenha", gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtSDLogin_Level_DetailSdt_Usuarioid ;
         }

         set {
            gxTv_SdtSDLogin_Level_DetailSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioEmail" )]
      [  XmlElement( ElementName = "UsuarioEmail"   )]
      public String gxTpr_Usuarioemail
      {
         get {
            return gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail ;
         }

         set {
            gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail = value;
            SetDirty("Usuarioemail");
         }

      }

      [  SoapElement( ElementName = "UsuarioSenha" )]
      [  XmlElement( ElementName = "UsuarioSenha"   )]
      public String gxTpr_Usuariosenha
      {
         get {
            return gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha ;
         }

         set {
            gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha = value;
            SetDirty("Usuariosenha");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail = "";
         gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha = "";
         return  ;
      }

      protected long gxTv_SdtSDLogin_Level_DetailSdt_Usuarioid ;
      protected String gxTv_SdtSDLogin_Level_DetailSdt_Usuarioemail ;
      protected String gxTv_SdtSDLogin_Level_DetailSdt_Usuariosenha ;
   }

   [DataContract(Name = @"SDLogin_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDLogin_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDLogin_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDLogin_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDLogin_Level_DetailSdt_RESTInterface( SdtSDLogin_Level_DetailSdt psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UsuarioId" , Order = 0 )]
      public String gxTpr_Usuarioid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Usuarioid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Usuarioid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "UsuarioEmail" , Order = 1 )]
      public String gxTpr_Usuarioemail
      {
         get {
            return sdt.gxTpr_Usuarioemail ;
         }

         set {
            sdt.gxTpr_Usuarioemail = value;
         }

      }

      [DataMember( Name = "UsuarioSenha" , Order = 2 )]
      public String gxTpr_Usuariosenha
      {
         get {
            return sdt.gxTpr_Usuariosenha ;
         }

         set {
            sdt.gxTpr_Usuariosenha = value;
         }

      }

      public SdtSDLogin_Level_DetailSdt sdt
      {
         get {
            return (SdtSDLogin_Level_DetailSdt)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtSDLogin_Level_DetailSdt() ;
         }
      }

   }

}
