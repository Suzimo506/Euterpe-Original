namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class LightProbes : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action tetrahedralizationCompleted; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action needsRetetrahedralization; //Field offset: 0x8

	public static event Action needsRetetrahedralization
	{
		[CompilerGenerated]
		 add { } //Length: 168
		[CompilerGenerated]
		 remove { } //Length: 168
	}

	public static event Action tetrahedralizationCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public SphericalHarmonicsL2[] bakedProbes
	{
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 66
	}

	public int cellCount
	{
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public Single[] coefficients
	{
		 get { } //Length: 49
		 set { } //Length: 3
	}

	public int count
	{
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public Vector3[] positions
	{
		[FreeFunction]
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	private LightProbes() { }

	[CompilerGenerated]
	public static void add_needsRetetrahedralization(Action value) { }

	[CompilerGenerated]
	public static void add_tetrahedralizationCompleted(Action value) { }

	[FreeFunction]
	internal static bool AreLightProbesAllowed(Renderer renderer) { }

	public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes) { }

	public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static void CalculateInterpolatedLightAndOcclusionProbes_Internal(Vector3[] positions, int positionsCount, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes) { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public SphericalHarmonicsL2[] get_bakedProbes() { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_cellCount() { }

	public Single[] get_coefficients() { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_count() { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Vector3[] get_positions() { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal static int GetCount() { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Single[] coefficients) { }

	[FreeFunction]
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	private static void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	[RequiredByNativeCode]
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[RequiredByNativeCode]
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[CompilerGenerated]
	public static void remove_needsRetetrahedralization(Action value) { }

	[CompilerGenerated]
	public static void remove_tetrahedralizationCompleted(Action value) { }

	[FreeFunction]
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_bakedProbes(SphericalHarmonicsL2[] value) { }

	public void set_coefficients(Single[] value) { }

	[FreeFunction]
	public static void Tetrahedralize() { }

	[FreeFunction]
	public static void TetrahedralizeAsync() { }

}

