/*
				   File: type_SdtWWPColumnsSelector
			Description: WWPColumnsSelector
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
	[XmlRoot(ElementName="WWPColumnsSelector")]
	[XmlType(TypeName="WWPColumnsSelector" , Namespace="SeriesColaborativas" )]
	[Serializable]
	public class SdtWWPColumnsSelector : GxUserType
	{
		public SdtWWPColumnsSelector( )
		{
			/* Constructor for serialization */
		}

		public SdtWWPColumnsSelector(IGxContext context)
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
			AddObjectProperty("VisibleColumns", gxTv_SdtWWPColumnsSelector_Visiblecolumns, false);  
			AddObjectProperty("InvisibleColumns", gxTv_SdtWWPColumnsSelector_Invisiblecolumns, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="VisibleColumns" )]
		[XmlArray(ElementName="VisibleColumns"  )]
		[XmlArrayItemAttribute(ElementName="VisibleColumn" , IsNullable=false )]
		public GXBaseCollection<SdtWWPColumnsSelector_VisibleColumn> gxTpr_Visiblecolumns
		{
			get {
				if ( gxTv_SdtWWPColumnsSelector_Visiblecolumns == null )
				{
					gxTv_SdtWWPColumnsSelector_Visiblecolumns = new GXBaseCollection<SdtWWPColumnsSelector_VisibleColumn>( context, "WWPColumnsSelector.VisibleColumn", "");
				}
				return gxTv_SdtWWPColumnsSelector_Visiblecolumns;
			}
			set {
				if ( gxTv_SdtWWPColumnsSelector_Visiblecolumns == null )
				{
					gxTv_SdtWWPColumnsSelector_Visiblecolumns = new GXBaseCollection<SdtWWPColumnsSelector_VisibleColumn>( context, "WWPColumnsSelector.VisibleColumn", "");
				}
				gxTv_SdtWWPColumnsSelector_Visiblecolumns = value;
				SetDirty("Visiblecolumns");
			}
		}public void gxTv_SdtWWPColumnsSelector_Visiblecolumns_SetNull()
		{
			gxTv_SdtWWPColumnsSelector_Visiblecolumns = null;
			return  ;
		}

		public bool gxTv_SdtWWPColumnsSelector_Visiblecolumns_IsNull()
		{
			if (gxTv_SdtWWPColumnsSelector_Visiblecolumns == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="InvisibleColumns" )]
		[XmlArray(ElementName="InvisibleColumns"  )]
		[XmlArrayItemAttribute(ElementName="InvisibleColumn" , IsNullable=false )]
		public GXBaseCollection<SdtWWPColumnsSelector_InvisibleColumn> gxTpr_Invisiblecolumns
		{
			get {
				if ( gxTv_SdtWWPColumnsSelector_Invisiblecolumns == null )
				{
					gxTv_SdtWWPColumnsSelector_Invisiblecolumns = new GXBaseCollection<SdtWWPColumnsSelector_InvisibleColumn>( context, "WWPColumnsSelector.InvisibleColumn", "");
				}
				return gxTv_SdtWWPColumnsSelector_Invisiblecolumns;
			}
			set {
				if ( gxTv_SdtWWPColumnsSelector_Invisiblecolumns == null )
				{
					gxTv_SdtWWPColumnsSelector_Invisiblecolumns = new GXBaseCollection<SdtWWPColumnsSelector_InvisibleColumn>( context, "WWPColumnsSelector.InvisibleColumn", "");
				}
				gxTv_SdtWWPColumnsSelector_Invisiblecolumns = value;
				SetDirty("Invisiblecolumns");
			}
		}public void gxTv_SdtWWPColumnsSelector_Invisiblecolumns_SetNull()
		{
			gxTv_SdtWWPColumnsSelector_Invisiblecolumns = null;
			return  ;
		}

		public bool gxTv_SdtWWPColumnsSelector_Invisiblecolumns_IsNull()
		{
			if (gxTv_SdtWWPColumnsSelector_Invisiblecolumns == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			return  ;
		}



		#endregion

		#region Declaration

		protected GXBaseCollection<SdtWWPColumnsSelector_VisibleColumn> gxTv_SdtWWPColumnsSelector_Visiblecolumns = null; protected GXBaseCollection<SdtWWPColumnsSelector_InvisibleColumn> gxTv_SdtWWPColumnsSelector_Invisiblecolumns = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPColumnsSelector", Namespace="SeriesColaborativas")]
	public class SdtWWPColumnsSelector_RESTInterface : GxGenericCollectionItem<SdtWWPColumnsSelector>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPColumnsSelector_RESTInterface( ) : base()
		{
		}

		public SdtWWPColumnsSelector_RESTInterface( SdtWWPColumnsSelector psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="VisibleColumns", Order=0)]
		public GxGenericCollection<SdtWWPColumnsSelector_VisibleColumn_RESTInterface> gxTpr_Visiblecolumns
		{
			get {
				return new GxGenericCollection<SdtWWPColumnsSelector_VisibleColumn_RESTInterface>(sdt.gxTpr_Visiblecolumns) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Visiblecolumns);
			}

		}

		[DataMember(Name="InvisibleColumns", Order=1)]
		public GxGenericCollection<SdtWWPColumnsSelector_InvisibleColumn_RESTInterface> gxTpr_Invisiblecolumns
		{
			get {
				return new GxGenericCollection<SdtWWPColumnsSelector_InvisibleColumn_RESTInterface>(sdt.gxTpr_Invisiblecolumns) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Invisiblecolumns);
			}

		}


		#endregion

		public SdtWWPColumnsSelector sdt
		{
			get { 
				return (SdtWWPColumnsSelector)Sdt;
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
				sdt = new SdtWWPColumnsSelector() ;
			}
		}
	}
	#endregion
}