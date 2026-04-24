namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient>
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public GradientAlphaKey[] alphaKeys
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public GradientColorKey[] colorKeys
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public GradientMode mode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[RequiredByNativeCode]
	public Gradient() { }

	[FreeFunction]
	private void Cleanup() { }

	public override bool Equals(Gradient other) { }

	public virtual bool Equals(object o) { }

	[FreeFunction]
	public Color Evaluate(float time) { }

	private void Evaluate_Injected(float time, out Color ret) { }

	protected virtual void Finalize() { }

	[FreeFunction]
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunction]
	public GradientColorKey[] get_colorKeys() { }

	public GradientMode get_mode() { }

	public virtual int GetHashCode() { }

	[FreeFunction]
	private static IntPtr Init() { }

	[FreeFunction]
	private bool Internal_Equals(IntPtr other) { }

	[FreeFunction]
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	[FreeFunction]
	public void set_colorKeys(GradientColorKey[] value) { }

	public void set_mode(GradientMode value) { }

	[FreeFunction]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

}

