/*
				   File: type_SdtWWPColumnsSelector_InvisibleColumn
			Description: InvisibleColumns
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
	[XmlRoot(ElementName="WWPColumnsSelector.InvisibleColumn")]
	[XmlType(TypeName="WWPColumnsSelector.InvisibleColumn" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPColumnsSelector_InvisibleColumn : GxUserType
	{
		public SdtWWPColumnsSelector_InvisibleColumn( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPColumnsSelector_InvisibleColumn_Columnname = "";

		}

		public SdtWWPColumnsSelector_InvisibleColumn(IGxContext context)
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
				return gxTv_SdtWWPColumnsSelector_InvisibleColumn_Columnname; 
			}
			set { 
				gxTv_SdtWWPColumnsSelector_InvisibleColumn_Columnname = value;
				SetDirty("Columnname");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPColumnsSelector_InvisibleColumn_Columnname = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtWWPColumnsSelector_InvisibleColumn_Columnname;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPColumnsSelector.InvisibleColumn", Namespace="SeriesColaborativas")]
	public class SdtWWPColumnsSelector_InvisibleColumn_RESTInterface : GxGenericCollectionItem<SdtWWPColumnsSelector_InvisibleColumn>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPColumnsSelector_InvisibleColumn_RESTInterface( ) : base()
		{
		}

		public SdtWWPColumnsSelector_InvisibleColumn_RESTInterface( SdtWWPColumnsSelector_InvisibleColumn psdt ) : base(psdt)
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

		public SdtWWPColumnsSelector_InvisibleColumn sdt
		{
			get { 
				return (SdtWWPColumnsSelector_InvisibleColumn)Sdt;
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
				sdt = new SdtWWPColumnsSelector_InvisibleColumn() ;
			}
		}
	}
	#endregion
}