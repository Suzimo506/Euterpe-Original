namespace Sirenix.Serialization.Utilities;

internal sealed class MemberAliasFieldInfo : FieldInfo
{
	private const string FAKE_NAME_SEPARATOR_STRING = "+"; //Field offset: 0x0
	private FieldInfo aliasedField; //Field offset: 0x10
	private string mangledName; //Field offset: 0x18

	public FieldInfo AliasedField
	{
		 get { } //Length: 5
	}

	public virtual FieldAttributes Attributes
	{
		 get { } //Length: 39
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 39
	}

	public virtual RuntimeFieldHandle FieldHandle
	{
		 get { } //Length: 39
	}

	public virtual Type FieldType
	{
		 get { } //Length: 39
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 39
	}

	public virtual Module Module
	{
		 get { } //Length: 39
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 39
	}

	public MemberAliasFieldInfo(FieldInfo field, string namePrefix) { }

	public MemberAliasFieldInfo(FieldInfo field, string namePrefix, string separatorString) { }

	public FieldInfo get_AliasedField() { }

	public virtual FieldAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeFieldHandle get_FieldHandle() { }

	public virtual Type get_FieldType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual object GetValue(object obj) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

