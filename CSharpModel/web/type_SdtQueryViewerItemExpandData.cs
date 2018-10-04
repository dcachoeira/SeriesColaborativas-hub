/*
				   File: type_SdtQueryViewerItemExpandData
			Description: QueryViewerItemExpandData
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
	[XmlRoot(ElementName="QueryViewerItemExpandData")]
	[XmlType(TypeName="QueryViewerItemExpandData" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerItemExpandData : GxUserType
	{
		public SdtQueryViewerItemExpandData( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerItemExpandData_Name = "";

			gxTv_SdtQueryViewerItemExpandData_Value = "";

		}

		public SdtQueryViewerItemExpandData(IGxContext context)
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
			AddObjectProperty("ExpandedValues", gxTv_SdtQueryViewerItemExpandData_Expandedvalues, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerItemExpandData_Name; 
			}
			set { 
				gxTv_SdtQueryViewerItemExpandData_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtQueryViewerItemExpandData_Value; 
			}
			set { 
				gxTv_SdtQueryViewerItemExpandData_Value = value;
				SetDirty("Value");
			}
		}


		[SoapElement(ElementName="ExpandedValues" )]
		[XmlArray(ElementName="ExpandedValues"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Expandedvalues_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerItemExpandData_Expandedvalues == null )
				{
					gxTv_SdtQueryViewerItemExpandData_Expandedvalues = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtQueryViewerItemExpandData_Expandedvalues;
			}
			set {
				if ( gxTv_SdtQueryViewerItemExpandData_Expandedvalues == null )
				{
					gxTv_SdtQueryViewerItemExpandData_Expandedvalues = new GxSimpleCollection<String>( );
				}
				gxTv_SdtQueryViewerItemExpandData_Expandedvalues = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Expandedvalues
		{
			get {
				if ( gxTv_SdtQueryViewerItemExpandData_Expandedvalues == null )
				{
					gxTv_SdtQueryViewerItemExpandData_Expandedvalues = new GxSimpleCollection<String>();
				}
				return gxTv_SdtQueryViewerItemExpandData_Expandedvalues ;
			}
			set {
				gxTv_SdtQueryViewerItemExpandData_Expandedvalues = value;
				SetDirty("Expandedvalues");
			}
		}

		public void gxTv_SdtQueryViewerItemExpandData_Expandedvalues_SetNull()
		{
			gxTv_SdtQueryViewerItemExpandData_Expandedvalues = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemExpandData_Expandedvalues_IsNull()
		{
			if (gxTv_SdtQueryViewerItemExpandData_Expandedvalues == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerItemExpandData_Name = "";
			gxTv_SdtQueryViewerItemExpandData_Value = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerItemExpandData_Name;
		protected String gxTv_SdtQueryViewerItemExpandData_Value;
		protected GxSimpleCollection<String> gxTv_SdtQueryViewerItemExpandData_Expandedvalues = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerItemExpandData", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerItemExpandData_RESTInterface : GxGenericCollectionItem<SdtQueryViewerItemExpandData>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerItemExpandData_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerItemExpandData_RESTInterface( SdtQueryViewerItemExpandData psdt ) : base(psdt)
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

		[DataMember(Name="ExpandedValues", Order=2)]
		public  GxSimpleCollection<String> gxTpr_Expandedvalues
		{
			get { 
				return sdt.gxTpr_Expandedvalues;
			}
			set { 
				sdt.gxTpr_Expandedvalues = value;
			}
		}


		#endregion

		public SdtQueryViewerItemExpandData sdt
		{
			get { 
				return (SdtQueryViewerItemExpandData)Sdt;
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
				sdt = new SdtQueryViewerItemExpandData() ;
			}
		}
	}
	#endregion
}