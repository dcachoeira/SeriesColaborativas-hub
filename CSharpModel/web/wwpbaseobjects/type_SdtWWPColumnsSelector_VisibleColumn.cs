/*
				   File: type_SdtWWPColumnsSelector_VisibleColumn
			Description: VisibleColumns
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
	[XmlRoot(ElementName="WWPColumnsSelector.VisibleColumn")]
	[XmlType(TypeName="WWPColumnsSelector.VisibleColumn" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPColumnsSelector_VisibleColumn : GxUserType
	{
		public SdtWWPColumnsSelector_VisibleColumn( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPColumnsSelector_VisibleColumn_Columnname = "";

		}

		public SdtWWPColumnsSelector_VisibleColumn(IGxContext context)
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
			AddObjectProperty("ColumnName", gxTpr_Columnname, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="ColumnName")]
		[XmlElement(ElementName="ColumnName")]
		public String gxTpr_Columnname
		{
			get { 
				return gxTv_SdtWWPColumnsSelector_VisibleColumn_Columnname; 
			}
			set { 
				gxTv_SdtWWPColumnsSelector_VisibleColumn_Columnname = value;
				SetDirty("Columnname");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPColumnsSelector_VisibleColumn_Columnname = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtWWPColumnsSelector_VisibleColumn_Columnname;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPColumnsSelector.VisibleColumn", Namespace="SeriesColaborativas")]
	public class SdtWWPColumnsSelector_VisibleColumn_RESTInterface : GxGenericCollectionItem<SdtWWPColumnsSelector_VisibleColumn>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPColumnsSelector_VisibleColumn_RESTInterface( ) : base()
		{
		}

		public SdtWWPColumnsSelector_VisibleColumn_RESTInterface( SdtWWPColumnsSelector_VisibleColumn psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="ColumnName", Order=0)]
		public String gxTpr_Columnname
		{
			get { 
				return sdt.gxTpr_Columnname;
			}
			set { 
				sdt.gxTpr_Columnname = value;
			}
		}


		#endregion

		public SdtWWPColumnsSelector_VisibleColumn sdt
		{
			get { 
				return (SdtWWPColumnsSelector_VisibleColumn)Sdt;
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
				sdt = new SdtWWPColumnsSelector_VisibleColumn() ;
			}
		}
	}
	#endregion
}