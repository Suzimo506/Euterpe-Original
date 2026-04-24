namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class ReflectionProbe : Behaviour
{
	internal enum ReflectionProbeEvent
	{
		ReflectionProbeAdded = 0,
		ReflectionProbeRemoved = 1,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<Cubemap> defaultReflectionSet; //Field offset: 0x8

	public ReflectionProbeTimeSlicingMode timeSlicingMode
	{
		 get { } //Length: 51
	}

	[RequiredByNativeCode]
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	private static void CallSetDefaultReflection(Cubemap defaultReflectionCubemap) { }

	public ReflectionProbeTimeSlicingMode get_timeSlicingMode() { }

	public int RenderProbe() { }

	public int RenderProbe(RenderTexture targetTexture) { }

	private int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture) { }

}

