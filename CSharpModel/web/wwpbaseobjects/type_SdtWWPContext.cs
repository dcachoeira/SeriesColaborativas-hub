/*
				   File: type_SdtWWPContext
			Description: WWPContext
				 Author: Nemo for C# version 15.0.9.121631
		   Generated on: 20/09/2018 19:47:45
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
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="WWPContext")]
	[XmlType(TypeName="WWPContext" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPContext : GxUserType
	{
		public SdtWWPContext( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPContext_Usuarionome = "";

			gxTv_SdtWWPContext_Usuariologin = "";

		}

		public SdtWWPContext(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("UsuarioId", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Usuarioid, 18, 0)), false);
			AddObjectProperty("UsuarioNome", gxTpr_Usuarionome, false);
			AddObjectProperty("UsuarioLogin", gxTpr_Usuariologin, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="UsuarioId")]
		[XmlElement(ElementName="UsuarioId")]
		public long gxTpr_Usuarioid
		{
			get { 
				return gxTv_SdtWWPContext_Usuarioid; 
			}
			set { 
				gxTv_SdtWWPContext_Usuarioid = value;
				SetDirty("Usuarioid");
			}
		}


		[SoapElement(ElementName="UsuarioNome")]
		[XmlElement(ElementName="UsuarioNome")]
		public String gxTpr_Usuarionome
		{
			get { 
				return gxTv_SdtWWPContext_Usuarionome; 
			}
			set { 
				gxTv_SdtWWPContext_Usuarionome = value;
				SetDirty("Usuarionome");
			}
		}


		[SoapElement(ElementName="UsuarioLogin")]
		[XmlElement(ElementName="UsuarioLogin")]
		public String gxTpr_Usuariologin
		{
			get { 
				return gxTv_SdtWWPContext_Usuariologin; 
			}
			set { 
				gxTv_SdtWWPContext_Usuariologin = value;
				SetDirty("Usuariologin");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPContext_Usuarionome = "";
			gxTv_SdtWWPContext_Usuariologin = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected long gxTv_SdtWWPContext_Usuarioid;
		protected String gxTv_SdtWWPContext_Usuarionome;
		protected String gxTv_SdtWWPContext_Usuariologin;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPContext", Namespace="SeriesColaborativas")]
	public class SdtWWPContext_RESTInterface : GxGenericCollectionItem<SdtWWPContext>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPContext_RESTInterface( ) : base()
		{
		}

		public SdtWWPContext_RESTInterface( SdtWWPContext psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="UsuarioId", Order=0)]
		public String gxTpr_Usuarioid
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str( (decimal) sdt.gxTpr_Usuarioid, 18, 0));
			}
			set { 
				sdt.gxTpr_Usuarioid = (long) NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="UsuarioNome", Order=1)]
		public String gxTpr_Usuarionome
		{
			get { 
				return sdt.gxTpr_Usuarionome;
			}
			set { 
				sdt.gxTpr_Usuarionome = value;
			}
		}

		[DataMember(Name="UsuarioLogin", Order=2)]
		public String gxTpr_Usuariologin
		{
			get { 
				return sdt.gxTpr_Usuariologin;
			}
			set { 
				sdt.gxTpr_Usuariologin = value;
			}
		}


		#endregion

		public SdtWWPContext sdt
		{
			get { 
				return (SdtWWPContext)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtWWPContext() ;
			}
		}
	}
	#endregion
}