/*
				   File: type_SdtQueryViewerItemClickData
			Description: QueryViewerItemClickData
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
	[XmlRoot(ElementName="QueryViewerItemClickData")]
	[XmlType(TypeName="QueryViewerItemClickData" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerItemClickData : GxUserType
	{
		public SdtQueryViewerItemClickData( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerItemClickData_Name = "";

			gxTv_SdtQueryViewerItemClickData_Axis = "";

			gxTv_SdtQueryViewerItemClickData_Value = "";

		}

		public SdtQueryViewerItemClickData(IGxContext context)
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
			AddObjectProperty("Axis", gxTpr_Axis, false);
			AddObjectProperty("Value", gxTpr_Value, false);
			AddObjectProperty("Context", gxTv_SdtQueryViewerItemClickData_Context, false);  
			AddObjectProperty("Filters", gxTv_SdtQueryViewerItemClickData_Filters, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerItemClickData_Name; 
			}
			set { 
				gxTv_SdtQueryViewerItemClickData_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Axis")]
		[XmlElement(ElementName="Axis")]
		public String gxTpr_Axis
		{
			get { 
				return gxTv_SdtQueryViewerItemClickData_Axis; 
			}
			set { 
				gxTv_SdtQueryViewerItemClickData_Axis = value;
				SetDirty("Axis");
			}
		}


		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtQueryViewerItemClickData_Value; 
			}
			set { 
				gxTv_SdtQueryViewerItemClickData_Value = value;
				SetDirty("Value");
			}
		}


		[SoapElement(ElementName="Context" )]
		[XmlArray(ElementName="Context"  )]
		[XmlArrayItemAttribute(ElementName="Element" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerItemClickData_Element> gxTpr_Context
		{
			get {
				if ( gxTv_SdtQueryViewerItemClickData_Context == null )
				{
					gxTv_SdtQueryViewerItemClickData_Context = new GXBaseCollection<SdtQueryViewerItemClickData_Element>( context, "QueryViewerItemClickData.Element", "");
				}
				return gxTv_SdtQueryViewerItemClickData_Context;
			}
			set {
				if ( gxTv_SdtQueryViewerItemClickData_Context == null )
				{
					gxTv_SdtQueryViewerItemClickData_Context = new GXBaseCollection<SdtQueryViewerItemClickData_Element>( context, "QueryViewerItemClickData.Element", "");
				}
				gxTv_SdtQueryViewerItemClickData_Context = value;
				SetDirty("Context");
			}
		}public void gxTv_SdtQueryViewerItemClickData_Context_SetNull()
		{
			gxTv_SdtQueryViewerItemClickData_Context = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemClickData_Context_IsNull()
		{
			if (gxTv_SdtQueryViewerItemClickData_Context == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="Filters" )]
		[XmlArray(ElementName="Filters"  )]
		[XmlArrayItemAttribute(ElementName="Filter" , IsNullable=false )]
		public GXBaseCollection<SdtQueryViewerItemClickData_Filter> gxTpr_Filters
		{
			get {
				if ( gxTv_SdtQueryViewerItemClickData_Filters == null )
				{
					gxTv_SdtQueryViewerItemClickData_Filters = new GXBaseCollection<SdtQueryViewerItemClickData_Filter>( context, "QueryViewerItemClickData.Filter", "");
				}
				return gxTv_SdtQueryViewerItemClickData_Filters;
			}
			set {
				if ( gxTv_SdtQueryViewerItemClickData_Filters == null )
				{
					gxTv_SdtQueryViewerItemClickData_Filters = new GXBaseCollection<SdtQueryViewerItemClickData_Filter>( context, "QueryViewerItemClickData.Filter", "");
				}
				gxTv_SdtQueryViewerItemClickData_Filters = value;
				SetDirty("Filters");
			}
		}public void gxTv_SdtQueryViewerItemClickData_Filters_SetNull()
		{
			gxTv_SdtQueryViewerItemClickData_Filters = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerItemClickData_Filters_IsNull()
		{
			if (gxTv_SdtQueryViewerItemClickData_Filters == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerItemClickData_Name = "";
			gxTv_SdtQueryViewerItemClickData_Axis = "";
			gxTv_SdtQueryViewerItemClickData_Value = "";


			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerItemClickData_Name;
		protected String gxTv_SdtQueryViewerItemClickData_Axis;
		protected String gxTv_SdtQueryViewerItemClickData_Value;
		protected GXBaseCollection<SdtQueryViewerItemClickData_Element> gxTv_SdtQueryViewerItemClickData_Context = null; protected GXBaseCollection<SdtQueryViewerItemClickData_Filter> gxTv_SdtQueryViewerItemClickData_Filters = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerItemClickData", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerItemClickData_RESTInterface : GxGenericCollectionItem<SdtQueryViewerItemClickData>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerItemClickData_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerItemClickData_RESTInterface( SdtQueryViewerItemClickData psdt ) : base(psdt)
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

		[DataMember(Name="Axis", Order=1)]
		public String gxTpr_Axis
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Axis);
			}
			set { 
				sdt.gxTpr_Axis = value;
			}
		}

		[DataMember(Name="Value", Order=2)]
		public String gxTpr_Value
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Value);
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}

		[DataMember(Name="Context", Order=3)]
		public GxGenericCollection<SdtQueryViewerItemClickData_Element_RESTInterface> gxTpr_Context
		{
			get {
				return new GxGenericCollection<SdtQueryViewerItemClickData_Element_RESTInterface>(sdt.gxTpr_Context) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Context);
			}

		}

		[DataMember(Name="Filters", Order=4)]
		public GxGenericCollection<SdtQueryViewerItemClickData_Filter_RESTInterface> gxTpr_Filters
		{
			get {
				return new GxGenericCollection<SdtQueryViewerItemClickData_Filter_RESTInterface>(sdt.gxTpr_Filters) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Filters);
			}

		}


		#endregion

		public SdtQueryViewerItemClickData sdt
		{
			get { 
				return (SdtQueryViewerItemClickData)Sdt;
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
				sdt = new SdtQueryViewerItemClickData() ;
			}
		}
	}
	#endregion
}