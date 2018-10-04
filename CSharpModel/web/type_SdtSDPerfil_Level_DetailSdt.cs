/*
               File: type_SdtSDPerfil_Level_DetailSdt
        Description: SDPerfil_Level_DetailSdt
             Author: GeneXus C# Generator version 15_0_9-121631
       Generated on: 8/23/2018 19:30:10.77
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
   [XmlRoot(ElementName = "SDPerfil_Level_DetailSdt" )]
   [XmlType(TypeName =  "SDPerfil_Level_DetailSdt" , Namespace = "http://tempuri.org/" )]
   [Serializable]
   public class SdtSDPerfil_Level_DetailSdt : GxUserType
   {
      public SdtSDPerfil_Level_DetailSdt( )
      {
         /* Constructor for serialization */
         gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome = "";
      }

      public SdtSDPerfil_Level_DetailSdt( IGxContext context )
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
         AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtSDPerfil_Level_DetailSdt_Usuarioid), 18, 0)), false);
         AddObjectProperty("UsuarioNome", gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome, false);
         return  ;
      }

      [  SoapElement( ElementName = "UsuarioId" )]
      [  XmlElement( ElementName = "UsuarioId"   )]
      public long gxTpr_Usuarioid
      {
         get {
            return gxTv_SdtSDPerfil_Level_DetailSdt_Usuarioid ;
         }

         set {
            gxTv_SdtSDPerfil_Level_DetailSdt_Usuarioid = value;
            SetDirty("Usuarioid");
         }

      }

      [  SoapElement( ElementName = "UsuarioNome" )]
      [  XmlElement( ElementName = "UsuarioNome"   )]
      public String gxTpr_Usuarionome
      {
         get {
            return gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome ;
         }

         set {
            gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome = value;
            SetDirty("Usuarionome");
         }

      }

      public void initialize( )
      {
         gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome = "";
         return  ;
      }

      protected long gxTv_SdtSDPerfil_Level_DetailSdt_Usuarioid ;
      protected String gxTv_SdtSDPerfil_Level_DetailSdt_Usuarionome ;
   }

   [DataContract(Name = @"SDPerfil_Level_DetailSdt", Namespace = "http://tempuri.org/")]
   public class SdtSDPerfil_Level_DetailSdt_RESTInterface : GxGenericCollectionItem<SdtSDPerfil_Level_DetailSdt>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSDPerfil_Level_DetailSdt_RESTInterface( ) : base()
      {
      }

      public SdtSDPerfil_Level_DetailSdt_RESTInterface( SdtSDPerfil_Level_DetailSdt psdt ) : base(psdt)
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

      [DataMember( Name = "UsuarioNome" , Order = 1 )]
      public String gxTpr_Usuarionome
      {
         get {
            return sdt.gxTpr_Usuarionome ;
         }

         set {
            sdt.gxTpr_Usuarionome = value;
         }

      }

      public SdtSDPerfil_Level_DetailSdt sdt
      {
         get {
            return (SdtSDPerfil_Level_DetailSdt)Sdt ;
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
            sdt = new SdtSDPerfil_Level_DetailSdt() ;
         }
      }

   }

}
