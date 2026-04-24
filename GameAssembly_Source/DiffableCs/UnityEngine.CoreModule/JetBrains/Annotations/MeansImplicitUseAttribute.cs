namespace JetBrains.Annotations;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MeansImplicitUseAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly ImplicitUseKindFlags <UseKindFlags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly ImplicitUseTargetFlags <TargetFlags>k__BackingField; //Field offset: 0x14

	public MeansImplicitUseAttribute() { }

	public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags) { }

}

