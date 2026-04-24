namespace Newtonsoft.Json.Linq;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JPropertyDescriptor : PropertyDescriptor
{

	public virtual Type ComponentType
	{
		 get { } //Length: 85
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	protected virtual int NameHashCode
	{
		 get { } //Length: 4
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 85
	}

	public JPropertyDescriptor(string name) { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	protected virtual int get_NameHashCode() { }

	public virtual Type get_PropertyType() { }

	public virtual object GetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

