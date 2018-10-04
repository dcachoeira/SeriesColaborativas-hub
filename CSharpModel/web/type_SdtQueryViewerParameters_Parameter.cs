/*
				   File: type_SdtQueryViewerParameters_Parameter
			Description: QueryViewerParameters
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
	[XmlRoot(ElementName="Parameter")]
	[XmlType(TypeName="Parameter" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerParameters_Parameter : GxUserType
	{
		public SdtQueryViewerParameters_Parameter( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerParameters_Parameter_Name = "";

			gxTv_SdtQueryViewerParameters_Parameter_Value = "";

		}

		public SdtQueryViewerParameters_Parameter(IGxContext context)
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
			AddObjectProperty("Name", gxTpr_Name, false);
			AddObjectProperty("Value", gxTpr_Value, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerParameters_Parameter_Name; 
			}
			set { 
				gxTv_SdtQueryViewerParameters_Parameter_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtQueryViewerParameters_Parameter_Value; 
			}
			set { 
				gxTv_SdtQueryViewerParameters_Parameter_Value = value;
				SetDirty("Value");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerParameters_Parameter_Name = "";
			gxTv_SdtQueryViewerParameters_Parameter_Value = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerParameters_Parameter_Name;
		protected String gxTv_SdtQueryViewerParameters_Parameter_Value;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"Parameter", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerParameters_Parameter_RESTInterface : GxGenericCollectionItem<SdtQueryViewerParameters_Parameter>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerParameters_Parameter_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerParameters_Parameter_RESTInterface( SdtQueryViewerParameters_Parameter psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Name);
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Value", Order=1)]
		public String gxTpr_Value
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Value);
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}


		#endregion

		public SdtQueryViewerParameters_Parameter sdt
		{
			get { 
				return (SdtQueryViewerParameters_Parameter)Sdt;
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
				sdt = new SdtQueryViewerParameters_Parameter() ;
			}
		}
	}
	#endregion
}