namespace UnityEngine.ResourceManagement.Util;

public struct SerializedType
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_AssemblyName; //Field offset: 0x0
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private string m_ClassName; //Field offset: 0x8
	private Type m_CachedType; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ValueChanged>k__BackingField; //Field offset: 0x18

	public string AssemblyName
	{
		 get { } //Length: 4
	}

	public string ClassName
	{
		 get { } //Length: 5
	}

	public Type Value
	{
		 get { } //Length: 408
		 set { } //Length: 241
	}

	public bool ValueChanged
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string get_AssemblyName() { }

	public string get_ClassName() { }

	public Type get_Value() { }

	[CompilerGenerated]
	public bool get_ValueChanged() { }

	public void set_Value(Type value) { }

	[CompilerGenerated]
	public void set_ValueChanged(bool value) { }

	public virtual string ToString() { }

}

