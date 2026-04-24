namespace System.ComponentModel;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class PropertyDescriptor : MemberDescriptor
{
	private TypeConverter converter; //Field offset: 0x60
	private Hashtable valueChangedHandlers; //Field offset: 0x68
	private Object[] editors; //Field offset: 0x70
	private Type[] editorTypes; //Field offset: 0x78
	private int editorCount; //Field offset: 0x80

	public abstract Type ComponentType
	{
		 get { } //Length: 0
	}

	public override TypeConverter Converter
	{
		 get { } //Length: 612
	}

	public abstract bool IsReadOnly
	{
		 get { } //Length: 0
	}

	public abstract Type PropertyType
	{
		 get { } //Length: 0
	}

	protected PropertyDescriptor(string name, Attribute[] attrs) { }

	protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) { }

	protected object CreateInstance(Type type) { }

	public virtual bool Equals(object obj) { }

	protected virtual void FillAttributes(IList attributeList) { }

	public abstract Type get_ComponentType() { }

	public override TypeConverter get_Converter() { }

	public abstract bool get_IsReadOnly() { }

	public abstract Type get_PropertyType() { }

	public virtual int GetHashCode() { }

	protected virtual object GetInvocationTarget(Type type, object instance) { }

	protected Type GetTypeFromName(string typeName) { }

	public abstract object GetValue(object component) { }

	protected override void OnValueChanged(object component, EventArgs e) { }

	public abstract void SetValue(object component, object value) { }

	public abstract bool ShouldSerializeValue(object component) { }

}

