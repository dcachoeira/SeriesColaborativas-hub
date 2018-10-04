/*
				   File: type_SdtDVB_SDTDropDownOptionsTitleSettingsIcons
			Description: DVB_SDTDropDownOptionsTitleSettingsIcons
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
using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="TitleSettingsIcons")]
	[XmlType(TypeName="TitleSettingsIcons" , Namespace="" )]
	[Serializable]
	public class SdtDVB_SDTDropDownOptionsTitleSettingsIcons : GxUserType
	{
		public SdtDVB_SDTDropDownOptionsTitleSettingsIcons( )
		{
			/* Constructor for serialization */
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption = "";
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption_gxi = ""; 
		}

		public SdtDVB_SDTDropDownOptionsTitleSettingsIcons(IGxContext context)
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
			AddObjectProperty("Default", gxTpr_Default, false);
			AddObjectProperty("Default_GXI", gxTpr_Default_gxi, false);

			AddObjectProperty("Filtered", gxTpr_Filtered, false);
			AddObjectProperty("Filtered_GXI", gxTpr_Filtered_gxi, false);

			AddObjectProperty("SortedASC", gxTpr_Sortedasc, false);
			AddObjectProperty("SortedASC_GXI", gxTpr_Sortedasc_gxi, false);

			AddObjectProperty("SortedDSC", gxTpr_Sorteddsc, false);
			AddObjectProperty("SortedDSC_GXI", gxTpr_Sorteddsc_gxi, false);

			AddObjectProperty("FilteredSortedASC", gxTpr_Filteredsortedasc, false);
			AddObjectProperty("FilteredSortedASC_GXI", gxTpr_Filteredsortedasc_gxi, false);

			AddObjectProperty("FilteredSortedDSC", gxTpr_Filteredsorteddsc, false);
			AddObjectProperty("FilteredSortedDSC_GXI", gxTpr_Filteredsorteddsc_gxi, false);

			AddObjectProperty("OptionSortASC", gxTpr_Optionsortasc, false);
			AddObjectProperty("OptionSortASC_GXI", gxTpr_Optionsortasc_gxi, false);

			AddObjectProperty("OptionSortDSC", gxTpr_Optionsortdsc, false);
			AddObjectProperty("OptionSortDSC_GXI", gxTpr_Optionsortdsc_gxi, false);

			AddObjectProperty("OptionApplyFilter", gxTpr_Optionapplyfilter, false);
			AddObjectProperty("OptionApplyFilter_GXI", gxTpr_Optionapplyfilter_gxi, false);

			AddObjectProperty("OptionFilteringData", gxTpr_Optionfilteringdata, false);
			AddObjectProperty("OptionFilteringData_GXI", gxTpr_Optionfilteringdata_gxi, false);

			AddObjectProperty("OptionCleanFilters", gxTpr_Optioncleanfilters, false);
			AddObjectProperty("OptionCleanFilters_GXI", gxTpr_Optioncleanfilters_gxi, false);

			AddObjectProperty("SelectedOption", gxTpr_Selectedoption, false);
			AddObjectProperty("SelectedOption_GXI", gxTpr_Selectedoption_gxi, false);

			AddObjectProperty("MultiselOption", gxTpr_Multiseloption, false);
			AddObjectProperty("MultiselOption_GXI", gxTpr_Multiseloption_gxi, false);

			AddObjectProperty("MultiselSelOption", gxTpr_Multiselseloption, false);
			AddObjectProperty("MultiselSelOption_GXI", gxTpr_Multiselseloption_gxi, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Default")]
		[XmlElement(ElementName="Default")]
		[GxUpload()]

		public String gxTpr_Default
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default = value;
				SetDirty("Default");
			}
		}
		[SoapElement(ElementName="Default_GXI" )]
		[XmlElement(ElementName="Default_GXI" )]
		public String gxTpr_Default_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default_gxi = value;
				SetDirty("Default_gxi");
			}
		}

		[SoapElement(ElementName="Filtered")]
		[XmlElement(ElementName="Filtered")]
		[GxUpload()]

		public String gxTpr_Filtered
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered = value;
				SetDirty("Filtered");
			}
		}
		[SoapElement(ElementName="Filtered_GXI" )]
		[XmlElement(ElementName="Filtered_GXI" )]
		public String gxTpr_Filtered_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered_gxi = value;
				SetDirty("Filtered_gxi");
			}
		}

		[SoapElement(ElementName="SortedASC")]
		[XmlElement(ElementName="SortedASC")]
		[GxUpload()]

		public String gxTpr_Sortedasc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc = value;
				SetDirty("Sortedasc");
			}
		}
		[SoapElement(ElementName="SortedASC_GXI" )]
		[XmlElement(ElementName="SortedASC_GXI" )]
		public String gxTpr_Sortedasc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc_gxi = value;
				SetDirty("Sortedasc_gxi");
			}
		}

		[SoapElement(ElementName="SortedDSC")]
		[XmlElement(ElementName="SortedDSC")]
		[GxUpload()]

		public String gxTpr_Sorteddsc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc = value;
				SetDirty("Sorteddsc");
			}
		}
		[SoapElement(ElementName="SortedDSC_GXI" )]
		[XmlElement(ElementName="SortedDSC_GXI" )]
		public String gxTpr_Sorteddsc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc_gxi = value;
				SetDirty("Sorteddsc_gxi");
			}
		}

		[SoapElement(ElementName="FilteredSortedASC")]
		[XmlElement(ElementName="FilteredSortedASC")]
		[GxUpload()]

		public String gxTpr_Filteredsortedasc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc = value;
				SetDirty("Filteredsortedasc");
			}
		}
		[SoapElement(ElementName="FilteredSortedASC_GXI" )]
		[XmlElement(ElementName="FilteredSortedASC_GXI" )]
		public String gxTpr_Filteredsortedasc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc_gxi = value;
				SetDirty("Filteredsortedasc_gxi");
			}
		}

		[SoapElement(ElementName="FilteredSortedDSC")]
		[XmlElement(ElementName="FilteredSortedDSC")]
		[GxUpload()]

		public String gxTpr_Filteredsorteddsc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc = value;
				SetDirty("Filteredsorteddsc");
			}
		}
		[SoapElement(ElementName="FilteredSortedDSC_GXI" )]
		[XmlElement(ElementName="FilteredSortedDSC_GXI" )]
		public String gxTpr_Filteredsorteddsc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc_gxi = value;
				SetDirty("Filteredsorteddsc_gxi");
			}
		}

		[SoapElement(ElementName="OptionSortASC")]
		[XmlElement(ElementName="OptionSortASC")]
		[GxUpload()]

		public String gxTpr_Optionsortasc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc = value;
				SetDirty("Optionsortasc");
			}
		}
		[SoapElement(ElementName="OptionSortASC_GXI" )]
		[XmlElement(ElementName="OptionSortASC_GXI" )]
		public String gxTpr_Optionsortasc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc_gxi = value;
				SetDirty("Optionsortasc_gxi");
			}
		}

		[SoapElement(ElementName="OptionSortDSC")]
		[XmlElement(ElementName="OptionSortDSC")]
		[GxUpload()]

		public String gxTpr_Optionsortdsc
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc = value;
				SetDirty("Optionsortdsc");
			}
		}
		[SoapElement(ElementName="OptionSortDSC_GXI" )]
		[XmlElement(ElementName="OptionSortDSC_GXI" )]
		public String gxTpr_Optionsortdsc_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc_gxi = value;
				SetDirty("Optionsortdsc_gxi");
			}
		}

		[SoapElement(ElementName="OptionApplyFilter")]
		[XmlElement(ElementName="OptionApplyFilter")]
		[GxUpload()]

		public String gxTpr_Optionapplyfilter
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter = value;
				SetDirty("Optionapplyfilter");
			}
		}
		[SoapElement(ElementName="OptionApplyFilter_GXI" )]
		[XmlElement(ElementName="OptionApplyFilter_GXI" )]
		public String gxTpr_Optionapplyfilter_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter_gxi = value;
				SetDirty("Optionapplyfilter_gxi");
			}
		}

		[SoapElement(ElementName="OptionFilteringData")]
		[XmlElement(ElementName="OptionFilteringData")]
		[GxUpload()]

		public String gxTpr_Optionfilteringdata
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata = value;
				SetDirty("Optionfilteringdata");
			}
		}
		[SoapElement(ElementName="OptionFilteringData_GXI" )]
		[XmlElement(ElementName="OptionFilteringData_GXI" )]
		public String gxTpr_Optionfilteringdata_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata_gxi = value;
				SetDirty("Optionfilteringdata_gxi");
			}
		}

		[SoapElement(ElementName="OptionCleanFilters")]
		[XmlElement(ElementName="OptionCleanFilters")]
		[GxUpload()]

		public String gxTpr_Optioncleanfilters
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters = value;
				SetDirty("Optioncleanfilters");
			}
		}
		[SoapElement(ElementName="OptionCleanFilters_GXI" )]
		[XmlElement(ElementName="OptionCleanFilters_GXI" )]
		public String gxTpr_Optioncleanfilters_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters_gxi = value;
				SetDirty("Optioncleanfilters_gxi");
			}
		}

		[SoapElement(ElementName="SelectedOption")]
		[XmlElement(ElementName="SelectedOption")]
		[GxUpload()]

		public String gxTpr_Selectedoption
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption = value;
				SetDirty("Selectedoption");
			}
		}
		[SoapElement(ElementName="SelectedOption_GXI" )]
		[XmlElement(ElementName="SelectedOption_GXI" )]
		public String gxTpr_Selectedoption_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption_gxi = value;
				SetDirty("Selectedoption_gxi");
			}
		}

		[SoapElement(ElementName="MultiselOption")]
		[XmlElement(ElementName="MultiselOption")]
		[GxUpload()]

		public String gxTpr_Multiseloption
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption = value;
				SetDirty("Multiseloption");
			}
		}
		[SoapElement(ElementName="MultiselOption_GXI" )]
		[XmlElement(ElementName="MultiselOption_GXI" )]
		public String gxTpr_Multiseloption_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption_gxi = value;
				SetDirty("Multiseloption_gxi");
			}
		}

		[SoapElement(ElementName="MultiselSelOption")]
		[XmlElement(ElementName="MultiselSelOption")]
		[GxUpload()]

		public String gxTpr_Multiselseloption
		{
			get { 
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption; 
			}
			set { 
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption = value;
				SetDirty("Multiselseloption");
			}
		}
		[SoapElement(ElementName="MultiselSelOption_GXI" )]
		[XmlElement(ElementName="MultiselSelOption_GXI" )]
		public String gxTpr_Multiselseloption_gxi
		{
			get {
				return gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption_gxi ;
			}
			set {
				gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption_gxi = value;
				SetDirty("Multiselseloption_gxi");
			}
		}

		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption_gxi = ""; 
			gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption = "";gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption_gxi = ""; 
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Default;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filtered;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sortedasc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Sorteddsc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsortedasc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Filteredsorteddsc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortasc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionsortdsc;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionapplyfilter;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optionfilteringdata;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Optioncleanfilters;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Selectedoption;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiseloption;

		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption_gxi;
		protected String gxTv_SdtDVB_SDTDropDownOptionsTitleSettingsIcons_Multiselseloption;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"TitleSettingsIcons", Namespace="")]
	public class SdtDVB_SDTDropDownOptionsTitleSettingsIcons_RESTInterface : GxGenericCollectionItem<SdtDVB_SDTDropDownOptionsTitleSettingsIcons>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtDVB_SDTDropDownOptionsTitleSettingsIcons_RESTInterface( ) : base()
		{
		}

		public SdtDVB_SDTDropDownOptionsTitleSettingsIcons_RESTInterface( SdtDVB_SDTDropDownOptionsTitleSettingsIcons psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Default", Order=0)]
		[GxUpload()]
		public String gxTpr_Default
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Default)) ? PathUtil.RelativePath( sdt.gxTpr_Default) : StringUtil.RTrim( sdt.gxTpr_Default_gxi));
			}
			set { 
				sdt.gxTpr_Default = value;
			}
		}

		[DataMember(Name="Filtered", Order=1)]
		[GxUpload()]
		public String gxTpr_Filtered
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Filtered)) ? PathUtil.RelativePath( sdt.gxTpr_Filtered) : StringUtil.RTrim( sdt.gxTpr_Filtered_gxi));
			}
			set { 
				sdt.gxTpr_Filtered = value;
			}
		}

		[DataMember(Name="SortedASC", Order=2)]
		[GxUpload()]
		public String gxTpr_Sortedasc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Sortedasc)) ? PathUtil.RelativePath( sdt.gxTpr_Sortedasc) : StringUtil.RTrim( sdt.gxTpr_Sortedasc_gxi));
			}
			set { 
				sdt.gxTpr_Sortedasc = value;
			}
		}

		[DataMember(Name="SortedDSC", Order=3)]
		[GxUpload()]
		public String gxTpr_Sorteddsc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Sorteddsc)) ? PathUtil.RelativePath( sdt.gxTpr_Sorteddsc) : StringUtil.RTrim( sdt.gxTpr_Sorteddsc_gxi));
			}
			set { 
				sdt.gxTpr_Sorteddsc = value;
			}
		}

		[DataMember(Name="FilteredSortedASC", Order=4)]
		[GxUpload()]
		public String gxTpr_Filteredsortedasc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Filteredsortedasc)) ? PathUtil.RelativePath( sdt.gxTpr_Filteredsortedasc) : StringUtil.RTrim( sdt.gxTpr_Filteredsortedasc_gxi));
			}
			set { 
				sdt.gxTpr_Filteredsortedasc = value;
			}
		}

		[DataMember(Name="FilteredSortedDSC", Order=5)]
		[GxUpload()]
		public String gxTpr_Filteredsorteddsc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Filteredsorteddsc)) ? PathUtil.RelativePath( sdt.gxTpr_Filteredsorteddsc) : StringUtil.RTrim( sdt.gxTpr_Filteredsorteddsc_gxi));
			}
			set { 
				sdt.gxTpr_Filteredsorteddsc = value;
			}
		}

		[DataMember(Name="OptionSortASC", Order=6)]
		[GxUpload()]
		public String gxTpr_Optionsortasc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Optionsortasc)) ? PathUtil.RelativePath( sdt.gxTpr_Optionsortasc) : StringUtil.RTrim( sdt.gxTpr_Optionsortasc_gxi));
			}
			set { 
				sdt.gxTpr_Optionsortasc = value;
			}
		}

		[DataMember(Name="OptionSortDSC", Order=7)]
		[GxUpload()]
		public String gxTpr_Optionsortdsc
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Optionsortdsc)) ? PathUtil.RelativePath( sdt.gxTpr_Optionsortdsc) : StringUtil.RTrim( sdt.gxTpr_Optionsortdsc_gxi));
			}
			set { 
				sdt.gxTpr_Optionsortdsc = value;
			}
		}

		[DataMember(Name="OptionApplyFilter", Order=8)]
		[GxUpload()]
		public String gxTpr_Optionapplyfilter
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Optionapplyfilter)) ? PathUtil.RelativePath( sdt.gxTpr_Optionapplyfilter) : StringUtil.RTrim( sdt.gxTpr_Optionapplyfilter_gxi));
			}
			set { 
				sdt.gxTpr_Optionapplyfilter = value;
			}
		}

		[DataMember(Name="OptionFilteringData", Order=9)]
		[GxUpload()]
		public String gxTpr_Optionfilteringdata
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Optionfilteringdata)) ? PathUtil.RelativePath( sdt.gxTpr_Optionfilteringdata) : StringUtil.RTrim( sdt.gxTpr_Optionfilteringdata_gxi));
			}
			set { 
				sdt.gxTpr_Optionfilteringdata = value;
			}
		}

		[DataMember(Name="OptionCleanFilters", Order=10)]
		[GxUpload()]
		public String gxTpr_Optioncleanfilters
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Optioncleanfilters)) ? PathUtil.RelativePath( sdt.gxTpr_Optioncleanfilters) : StringUtil.RTrim( sdt.gxTpr_Optioncleanfilters_gxi));
			}
			set { 
				sdt.gxTpr_Optioncleanfilters = value;
			}
		}

		[DataMember(Name="SelectedOption", Order=11)]
		[GxUpload()]
		public String gxTpr_Selectedoption
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Selectedoption)) ? PathUtil.RelativePath( sdt.gxTpr_Selectedoption) : StringUtil.RTrim( sdt.gxTpr_Selectedoption_gxi));
			}
			set { 
				sdt.gxTpr_Selectedoption = value;
			}
		}

		[DataMember(Name="MultiselOption", Order=12)]
		[GxUpload()]
		public String gxTpr_Multiseloption
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Multiseloption)) ? PathUtil.RelativePath( sdt.gxTpr_Multiseloption) : StringUtil.RTrim( sdt.gxTpr_Multiseloption_gxi));
			}
			set { 
				sdt.gxTpr_Multiseloption = value;
			}
		}

		[DataMember(Name="MultiselSelOption", Order=13)]
		[GxUpload()]
		public String gxTpr_Multiselseloption
		{
			get { 
				return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Multiselseloption)) ? PathUtil.RelativePath( sdt.gxTpr_Multiselseloption) : StringUtil.RTrim( sdt.gxTpr_Multiselseloption_gxi));
			}
			set { 
				sdt.gxTpr_Multiselseloption = value;
			}
		}


		#endregion

		public SdtDVB_SDTDropDownOptionsTitleSettingsIcons sdt
		{
			get { 
				return (SdtDVB_SDTDropDownOptionsTitleSettingsIcons)Sdt;
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
				sdt = new SdtDVB_SDTDropDownOptionsTitleSettingsIcons() ;
			}
		}
	}
	#endregion
}