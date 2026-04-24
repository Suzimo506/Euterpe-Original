namespace UnityEngine;

[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TouchScreenKeyboard
{
	internal enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static bool <disableInPlaceEditing>k__BackingField; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10

	public bool active
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 66
	}

	public bool canGetSelection
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public bool canSetSelection
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public int characterLimit
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 64
	}

	internal static bool disableInPlaceEditing
	{
		[CompilerGenerated]
		internal get { } //Length: 53
	}

	public static bool hideInput
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 51
	}

	public static bool isInPlaceEditingAllowed
	{
		 get { } //Length: 38
	}

	public static bool isSupported
	{
		 get { } //Length: 76
	}

	public RangeInt selection
	{
		 get { } //Length: 66
		 set { } //Length: 226
	}

	public Status status
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public string text
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 66
	}

	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	private void Destroy() { }

	protected virtual void Finalize() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_active() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_canGetSelection() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_canSetSelection() { }

	[CompilerGenerated]
	internal static bool get_disableInPlaceEditing() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static bool get_isSupported() { }

	public RangeInt get_selection() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Status get_status() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string get_text() { }

	private static void GetSelection(out int start, out int length) { }

	[FreeFunction]
	private static void Internal_Destroy(IntPtr ptr) { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[ExcludeFromDocs]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_active(bool value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_characterLimit(int value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void set_hideInput(bool value) { }

	public void set_selection(RangeInt value) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_text(string value) { }

	private static void SetSelection(int start, int length) { }

	[FreeFunction]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

}

