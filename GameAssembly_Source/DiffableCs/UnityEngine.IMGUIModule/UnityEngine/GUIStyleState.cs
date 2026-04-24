namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class GUIStyleState
{
	internal IntPtr m_Ptr; //Field offset: 0x10
	private readonly GUIStyle m_SourceStyle; //Field offset: 0x18

	[NativeProperty]
	public Texture2D background
	{
		 set { } //Length: 66
	}

	[NativeProperty]
	public Color textColor
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public GUIStyleState() { }

	private GUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[FreeFunction]
	private void Cleanup() { }

	protected virtual void Finalize() { }

	public Color get_textColor() { }

	private void get_textColor_Injected(out Color ret) { }

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[FreeFunction]
	private static IntPtr Init() { }

	public void set_background(Texture2D value) { }

	public void set_textColor(Color value) { }

	private void set_textColor_Injected(ref Color value) { }

}

