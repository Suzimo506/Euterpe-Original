namespace Newtonsoft.Json.Serialization;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class NamingStrategy
{
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; //Field offset: 0x12

	public bool OverrideSpecifiedNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ProcessDictionaryKeys
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool ProcessExtensionDataNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected NamingStrategy() { }

	public virtual bool Equals(object obj) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected bool Equals(NamingStrategy other) { }

	[CompilerGenerated]
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	public bool get_ProcessExtensionDataNames() { }

	public override string GetDictionaryKey(string key) { }

	public override string GetExtensionDataName(string name) { }

	public virtual int GetHashCode() { }

	public override string GetPropertyName(string name, bool hasSpecifiedName) { }

	protected abstract string ResolvePropertyName(string name) { }

}

