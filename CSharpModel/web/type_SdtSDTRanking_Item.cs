/*
				   File: type_SdtSDTRanking_Item
			Description: SDTRanking
				 Author: Nemo for C# version 15.0.9.121631
		   Generated on: 20/09/2018 19:47:44
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

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="Item")]
	[XmlType(TypeName="Item" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtSDTRanking_Item : GxUserType
	{
		public SdtSDTRanking_Item( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDTRanking_Item_Usuarionome = "";

		}

		public SdtSDTRanking_Item(IGxContext context)
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
			AddObjectProperty("UsuarioNome", gxTpr_Usuarionome, false);
			AddObjectProperty("QuantidadePontos", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Quantidadepontos, 18, 0)), false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="UsuarioNome")]
		[XmlElement(ElementName="UsuarioNome")]
		public String gxTpr_Usuarionome
		{
			get { 
				return gxTv_SdtSDTRanking_Item_Usuarionome; 
			}
			set { 
				gxTv_SdtSDTRanking_Item_Usuarionome = value;
				SetDirty("Usuarionome");
			}
		}


		[SoapElement(ElementName="QuantidadePontos")]
		[XmlElement(ElementName="QuantidadePontos")]
		public long gxTpr_Quantidadepontos
		{
			get { 
				return gxTv_SdtSDTRanking_Item_Quantidadepontos; 
			}
			set { 
				gxTv_SdtSDTRanking_Item_Quantidadepontos = value;
				SetDirty("Quantidadepontos");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDTRanking_Item_Usuarionome = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDTRanking_Item_Usuarionome;
		protected long gxTv_SdtSDTRanking_Item_Quantidadepontos;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"Item", Namespace="SeriesColaborativas")]
	public class SdtSDTRanking_Item_RESTInterface : GxGenericCollectionItem<SdtSDTRanking_Item>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDTRanking_Item_RESTInterface( ) : base()
		{
		}

		public SdtSDTRanking_Item_RESTInterface( SdtSDTRanking_Item psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="UsuarioNome", Order=0)]
		public String gxTpr_Usuarionome
		{
			get { 
				return sdt.gxTpr_Usuarionome;
			}
			set { 
				sdt.gxTpr_Usuarionome = value;
			}
		}

		[DataMember(Name="QuantidadePontos", Order=1)]
		public String gxTpr_Quantidadepontos
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str( (decimal) sdt.gxTpr_Quantidadepontos, 18, 0));
			}
			set { 
				sdt.gxTpr_Quantidadepontos = (long) NumberUtil.Val( value, ".");
			}
		}


		#endregion

		public SdtSDTRanking_Item sdt
		{
			get { 
				return (SdtSDTRanking_Item)Sdt;
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
				sdt = new SdtSDTRanking_Item() ;
			}
		}
	}
	#endregion
}