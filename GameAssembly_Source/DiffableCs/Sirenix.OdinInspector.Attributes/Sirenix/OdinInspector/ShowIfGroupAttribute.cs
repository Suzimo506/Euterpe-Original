namespace Sirenix.OdinInspector;

[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ShowIfGroupAttribute : PropertyGroupAttribute
{
	public object Value; //Field offset: 0x38

	public bool Animate
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string Condition
	{
		 get { } //Length: 44
		 set { } //Length: 12
	}

	[Obsolete]
	public string MemberName
	{
		 get { } //Length: 44
		 set { } //Length: 12
	}

	public ShowIfGroupAttribute(string path, bool animate = true) { }

	public ShowIfGroupAttribute(string path, object value, bool animate = true) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

	public bool get_Animate() { }

	public string get_Condition() { }

	public string get_MemberName() { }

	public void set_Animate(bool value) { }

	public void set_Condition(string value) { }

	public void set_MemberName(string value) { }

}

