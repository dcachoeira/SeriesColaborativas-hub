/*
				   File: type_SdtQueryViewerAxes_Axis_Format_ValueStyle
			Description: ValuesStyles
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
	[XmlRoot(ElementName="QueryViewerAxes.Axis.Format.ValueStyle")]
	[XmlType(TypeName="QueryViewerAxes.Axis.Format.ValueStyle" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtQueryViewerAxes_Axis_Format_ValueStyle : GxUserType
	{
		public SdtQueryViewerAxes_Axis_Format_ValueStyle( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Value = "";

			gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Styleorclass = "";

		}

		public SdtQueryViewerAxes_Axis_Format_ValueStyle(IGxContext context)
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
			AddObjectProperty("Value", gxTpr_Value, false);
			AddObjectProperty("StyleOrClass", gxTpr_Styleorclass, false);
			AddObjectProperty("ApplyToRowOrColumn", gxTpr_Applytoroworcolumn, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Value; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Value = value;
				SetDirty("Value");
			}
		}


		[SoapElement(ElementName="StyleOrClass")]
		[XmlElement(ElementName="StyleOrClass")]
		public String gxTpr_Styleorclass
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Styleorclass; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Styleorclass = value;
				SetDirty("Styleorclass");
			}
		}


		[SoapElement(ElementName="ApplyToRowOrColumn")]
		[XmlElement(ElementName="ApplyToRowOrColumn")]
		public bool gxTpr_Applytoroworcolumn
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Applytoroworcolumn; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Applytoroworcolumn = value;
				SetDirty("Applytoroworcolumn");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Value = "";
			gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Styleorclass = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Value;
		protected String gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Styleorclass;
		protected bool gxTv_SdtQueryViewerAxes_Axis_Format_ValueStyle_Applytoroworcolumn;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerAxes.Axis.Format.ValueStyle", Namespace="SeriesColaborativas")]
	public class SdtQueryViewerAxes_Axis_Format_ValueStyle_RESTInterface : GxGenericCollectionItem<SdtQueryViewerAxes_Axis_Format_ValueStyle>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerAxes_Axis_Format_ValueStyle_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerAxes_Axis_Format_ValueStyle_RESTInterface( SdtQueryViewerAxes_Axis_Format_ValueStyle psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Value", Order=0)]
		public String gxTpr_Value
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Value);
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}

		[DataMember(Name="StyleOrClass", Order=1)]
		public String gxTpr_Styleorclass
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Styleorclass);
			}
			set { 
				sdt.gxTpr_Styleorclass = value;
			}
		}

		[DataMember(Name="ApplyToRowOrColumn", Order=2)]
		public bool gxTpr_Applytoroworcolumn
		{
			get { 
				return sdt.gxTpr_Applytoroworcolumn;
			}
			set { 
				sdt.gxTpr_Applytoroworcolumn = value;
			}
		}


		#endregion

		public SdtQueryViewerAxes_Axis_Format_ValueStyle sdt
		{
			get { 
				return (SdtQueryViewerAxes_Axis_Format_ValueStyle)Sdt;
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
				sdt = new SdtQueryViewerAxes_Axis_Format_ValueStyle() ;
			}
		}
	}
	#endregion
}