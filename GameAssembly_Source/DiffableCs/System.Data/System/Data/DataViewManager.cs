namespace System.Data;

public class DataViewManager : MarshalByValueComponent
{
	private static NotSupportedException s_notSupported; //Field offset: 0x0
	private DataViewSettingCollection _dataViewSettingsCollection; //Field offset: 0x20
	internal int _nViews; //Field offset: 0x28

	[DesignerSerializationVisibility(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public DataViewSettingCollection DataViewSettings
	{
		 get { } //Length: 5
	}

	private static DataViewManager() { }

	public DataViewSettingCollection get_DataViewSettings() { }

}

