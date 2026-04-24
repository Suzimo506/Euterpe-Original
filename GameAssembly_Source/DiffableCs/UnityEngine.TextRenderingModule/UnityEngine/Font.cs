namespace UnityEngine;

[NativeClass(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Font : object
{
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		public FontTextureRebuildCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	private event FontTextureRebuildCallback m_FontTextureRebuildCallback
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public static event Action<Font> textureRebuilt
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public int ascent
	{
		 get { } //Length: 51
	}

	public CharacterInfo[] characterInfo
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public bool dynamic
	{
		 get { } //Length: 51
	}

	public String[] fontNames
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int fontSize
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public int lineHeight
	{
		 get { } //Length: 51
	}

	public Material material
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[Obsolete]
	public FontTextureRebuildCallback textureRebuildCallback
	{
		 get { } //Length: 7
		 set { } //Length: 12
	}

	private Font(String[] names, int size) { }

	public Font(string name) { }

	public Font() { }

	[CompilerGenerated]
	private void add_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	public static void add_textureRebuilt(Action<Font> value) { }

	public static Font CreateDynamicFontFromOSFont(String[] fontnames, int size) { }

	public static Font CreateDynamicFontFromOSFont(string fontname, int size) { }

	public int get_ascent() { }

	[FreeFunction]
	public CharacterInfo[] get_characterInfo() { }

	public bool get_dynamic() { }

	public String[] get_fontNames() { }

	public int get_fontSize() { }

	public int get_lineHeight() { }

	public Material get_material() { }

	public FontTextureRebuildCallback get_textureRebuildCallback() { }

	[ExcludeFromDocs]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[FreeFunction]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[ExcludeFromDocs]
	public bool GetCharacterInfo(char ch, out CharacterInfo info) { }

	internal static Font GetDefault() { }

	public static int GetMaxVertsForString(string str) { }

	public static String[] GetOSInstalledFontNames() { }

	public static String[] GetPathsToOSFonts() { }

	private bool HasCharacter(int c) { }

	public bool HasCharacter(char c) { }

	private static void Internal_CreateDynamicFont(Font self, String[] _names, int size) { }

	private static void Internal_CreateFont(Font self, string name) { }

	private static void Internal_CreateFontFromPath(Font self, string fontPath) { }

	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[CompilerGenerated]
	private void remove_m_FontTextureRebuildCallback(FontTextureRebuildCallback value) { }

	[CompilerGenerated]
	public static void remove_textureRebuilt(Action<Font> value) { }

	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[ExcludeFromDocs]
	public void RequestCharactersInTexture(string characters) { }

	[ExcludeFromDocs]
	public void RequestCharactersInTexture(string characters, int size) { }

	[FreeFunction]
	public void set_characterInfo(CharacterInfo[] value) { }

	public void set_fontNames(String[] value) { }

	public void set_material(Material value) { }

	public void set_textureRebuildCallback(FontTextureRebuildCallback value) { }

}

