namespace Sirenix.Serialization.Utilities;

internal sealed class MemberAliasPropertyInfo : PropertyInfo
{
	private const string FakeNameSeparatorString = "+"; //Field offset: 0x0
	private PropertyInfo aliasedProperty; //Field offset: 0x10
	private string mangledName; //Field offset: 0x18

	public PropertyInfo AliasedProperty
	{
		 get { } //Length: 5
	}

	public virtual PropertyAttributes Attributes
	{
		 get { } //Length: 39
	}

	public virtual bool CanRead
	{
		 get { } //Length: 39
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 39
	}

	public virtual Type DeclaringType
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

	public virtual Type PropertyType
	{
		 get { } //Length: 39
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 39
	}

	public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix) { }

	public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix, string separatorString) { }

	public PropertyInfo get_AliasedProperty() { }

	public virtual PropertyAttributes get_Attributes() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	public virtual Type get_DeclaringType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_PropertyType() { }

	public virtual Type get_ReflectedType() { }

	public virtual MethodInfo[] GetAccessors(bool nonPublic) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual MethodInfo GetGetMethod(bool nonPublic) { }

	public virtual ParameterInfo[] GetIndexParameters() { }

	public virtual MethodInfo GetSetMethod(bool nonPublic) { }

	public virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, Object[] index, CultureInfo culture) { }

}

