/*
				   File: type_SdtWWPGridState_FilterValue
			Description: FilterValues
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
	[XmlRoot(ElementName="WWPGridState.FilterValue")]
	[XmlType(TypeName="WWPGridState.FilterValue" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPGridState_FilterValue : GxUserType
	{
		public SdtWWPGridState_FilterValue( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPGridState_FilterValue_Name = "";

			gxTv_SdtWWPGridState_FilterValue_Value = "";

			gxTv_SdtWWPGridState_FilterValue_Valueto = "";

		}

		public SdtWWPGridState_FilterValue(IGxContext context)
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
			AddObjectProperty("Operator", gxTpr_Operator, false);
			AddObjectProperty("ValueTo", gxTpr_Valueto, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtWWPGridState_FilterValue_Name; 
			}
			set { 
				gxTv_SdtWWPGridState_FilterValue_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtWWPGridState_FilterValue_Value; 
			}
			set { 
				gxTv_SdtWWPGridState_FilterValue_Value = value;
				SetDirty("Value");
			}
		}


		[SoapElement(ElementName="Operator")]
		[XmlElement(ElementName="Operator")]
		public short gxTpr_Operator
		{
			get { 
				return gxTv_SdtWWPGridState_FilterValue_Operator; 
			}
			set { 
				gxTv_SdtWWPGridState_FilterValue_Operator = value;
				SetDirty("Operator");
			}
		}


		[SoapElement(ElementName="ValueTo")]
		[XmlElement(ElementName="ValueTo")]
		public String gxTpr_Valueto
		{
			get { 
				return gxTv_SdtWWPGridState_FilterValue_Valueto; 
			}
			set { 
				gxTv_SdtWWPGridState_FilterValue_Valueto = value;
				SetDirty("Valueto");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPGridState_FilterValue_Name = "";
			gxTv_SdtWWPGridState_FilterValue_Value = "";

			gxTv_SdtWWPGridState_FilterValue_Valueto = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtWWPGridState_FilterValue_Name;
		protected String gxTv_SdtWWPGridState_FilterValue_Value;
		protected short gxTv_SdtWWPGridState_FilterValue_Operator;
		protected String gxTv_SdtWWPGridState_FilterValue_Valueto;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPGridState.FilterValue", Namespace="SeriesColaborativas")]
	public class SdtWWPGridState_FilterValue_RESTInterface : GxGenericCollectionItem<SdtWWPGridState_FilterValue>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPGridState_FilterValue_RESTInterface( ) : base()
		{
		}

		public SdtWWPGridState_FilterValue_RESTInterface( SdtWWPGridState_FilterValue psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return sdt.gxTpr_Name;
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Value", Order=1)]
		public String gxTpr_Value
		{
			get { 
				return sdt.gxTpr_Value;
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}

		[DataMember(Name="Operator", Order=2)]
		public  Nullable<short> gxTpr_Operator
		{
			get { 
				return sdt.gxTpr_Operator;
			}
			set { 
				sdt.gxTpr_Operator = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="ValueTo", Order=3)]
		public String gxTpr_Valueto
		{
			get { 
				return sdt.gxTpr_Valueto;
			}
			set { 
				sdt.gxTpr_Valueto = value;
			}
		}


		#endregion

		public SdtWWPGridState_FilterValue sdt
		{
			get { 
				return (SdtWWPGridState_FilterValue)Sdt;
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
				sdt = new SdtWWPGridState_FilterValue() ;
			}
		}
	}
	#endregion
}