/*
				   File: type_SdtQueryViewerFilterChangedData
			Description: QueryViewerFilterChangedData
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
	[XmlRoot(ElementName="QueryViewerFilterChangedData")]
	[XmlType(TypeName="QueryViewerFilterChangedData" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerFilterChangedData : GxUserType
	{
		public SdtQueryViewerFilterChangedData( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerFilterChangedData_Name = "";

		}

		public SdtQueryViewerFilterChangedData(IGxContext context)
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
			AddObjectProperty("SelectedValues", gxTv_SdtQueryViewerFilterChangedData_Selectedvalues, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtQueryViewerFilterChangedData_Name; 
			}
			set { 
				gxTv_SdtQueryViewerFilterChangedData_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="SelectedValues" )]
		[XmlArray(ElementName="SelectedValues"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Selectedvalues_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerFilterChangedData_Selectedvalues == null )
				{
					gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtQueryViewerFilterChangedData_Selectedvalues;
			}
			set {
				if ( gxTv_SdtQueryViewerFilterChangedData_Selectedvalues == null )
				{
					gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = new GxSimpleCollection<String>( );
				}
				gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Selectedvalues
		{
			get {
				if ( gxTv_SdtQueryViewerFilterChangedData_Selectedvalues == null )
				{
					gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = new GxSimpleCollection<String>();
				}
				return gxTv_SdtQueryViewerFilterChangedData_Selectedvalues ;
			}
			set {
				gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = value;
				SetDirty("Selectedvalues");
			}
		}

		public void gxTv_SdtQueryViewerFilterChangedData_Selectedvalues_SetNull()
		{
			gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerFilterChangedData_Selectedvalues_IsNull()
		{
			if (gxTv_SdtQueryViewerFilterChangedData_Selectedvalues == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerFilterChangedData_Name = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerFilterChangedData_Name;
		protected GxSimpleCollection<String> gxTv_SdtQueryViewerFilterChangedData_Selectedvalues = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerFilterChangedData", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerFilterChangedData_RESTInterface : GxGenericCollectionItem<SdtQueryViewerFilterChangedData>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerFilterChangedData_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerFilterChangedData_RESTInterface( SdtQueryViewerFilterChangedData psdt ) : base(psdt)
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

		[DataMember(Name="SelectedValues", Order=1)]
		public  GxSimpleCollection<String> gxTpr_Selectedvalues
		{
			get { 
				return sdt.gxTpr_Selectedvalues;
			}
			set { 
				sdt.gxTpr_Selectedvalues = value;
			}
		}


		#endregion

		public SdtQueryViewerFilterChangedData sdt
		{
			get { 
				return (SdtQueryViewerFilterChangedData)Sdt;
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
				sdt = new SdtQueryViewerFilterChangedData() ;
			}
		}
	}
	#endregion
}