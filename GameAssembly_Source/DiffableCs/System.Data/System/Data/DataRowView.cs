namespace System.Data;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DataRowView : ICustomTypeDescriptor
{
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; //Field offset: 0x0
	private readonly DataView _dataView; //Field offset: 0x10
	private readonly DataRow _row; //Field offset: 0x18
	private bool _delayBeginEdit; //Field offset: 0x20
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; //Field offset: 0x28

	public DataView DataView
	{
		 get { } //Length: 5
	}

	public bool IsNew
	{
		 get { } //Length: 34
	}

	public DataRow Row
	{
		 get { } //Length: 5
	}

	private DataRowVersion RowVersionDefault
	{
		private get { } //Length: 42
	}

	private static DataRowView() { }

	internal DataRowView(DataView dataView, DataRow row) { }

	public DataView CreateChildView(DataRelation relation) { }

	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	public override void EndEdit() { }

	public virtual bool Equals(object other) { }

	public DataView get_DataView() { }

	public bool get_IsNew() { }

	public DataRow get_Row() { }

	private DataRowVersion get_RowVersionDefault() { }

	internal object GetColumnValue(DataColumn column) { }

	public virtual int GetHashCode() { }

	internal int GetRecord() { }

	internal bool HasRecord() { }

	internal void RaisePropertyChangedEvent(string propName) { }

	internal void SetColumnValue(DataColumn column, object value) { }

	private override AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private override TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private override PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private override object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

