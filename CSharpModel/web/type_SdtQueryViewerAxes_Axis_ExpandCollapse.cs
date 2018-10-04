/*
				   File: type_SdtQueryViewerAxes_Axis_ExpandCollapse
			Description: ExpandCollapse
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
	[XmlRoot(ElementName="QueryViewerAxes.Axis.ExpandCollapse")]
	[XmlType(TypeName="QueryViewerAxes.Axis.ExpandCollapse" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerAxes_Axis_ExpandCollapse : GxUserType
	{
		public SdtQueryViewerAxes_Axis_ExpandCollapse( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Type = "";

		}

		public SdtQueryViewerAxes_Axis_ExpandCollapse(IGxContext context)
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
			AddObjectProperty("Type", gxTpr_Type, false);
			AddObjectProperty("Values", gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Type")]
		[XmlElement(ElementName="Type")]
		public String gxTpr_Type
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Type; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Type = value;
				SetDirty("Type");
			}
		}


		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Value" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values;
			}
			set {
				if ( gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = new GxSimpleCollection<String>( );
				}
				gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Values
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = new GxSimpleCollection<String>();
				}
				return gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values ;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Type = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Type;
		protected GxSimpleCollection<String> gxTv_SdtQueryViewerAxes_Axis_ExpandCollapse_Values = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerAxes.Axis.ExpandCollapse", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerAxes_Axis_ExpandCollapse_RESTInterface : GxGenericCollectionItem<SdtQueryViewerAxes_Axis_ExpandCollapse>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerAxes_Axis_ExpandCollapse_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerAxes_Axis_ExpandCollapse_RESTInterface( SdtQueryViewerAxes_Axis_ExpandCollapse psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Type", Order=0)]
		public String gxTpr_Type
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Type);
			}
			set { 
				sdt.gxTpr_Type = value;
			}
		}

		[DataMember(Name="Values", Order=1)]
		public  GxSimpleCollection<String> gxTpr_Values
		{
			get { 
				return sdt.gxTpr_Values;
			}
			set { 
				sdt.gxTpr_Values = value;
			}
		}


		#endregion

		public SdtQueryViewerAxes_Axis_ExpandCollapse sdt
		{
			get { 
				return (SdtQueryViewerAxes_Axis_ExpandCollapse)Sdt;
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
				sdt = new SdtQueryViewerAxes_Axis_ExpandCollapse() ;
			}
		}
	}
	#endregion
}