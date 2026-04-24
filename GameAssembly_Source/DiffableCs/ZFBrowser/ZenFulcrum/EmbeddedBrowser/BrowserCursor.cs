namespace ZenFulcrum.EmbeddedBrowser;

public class BrowserCursor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__23_0() { }

	}

	internal class CursorInfo
	{
		public int atlasOffset; //Field offset: 0x10
		public Vector2 hotspot; //Field offset: 0x14

		public CursorInfo() { }

	}

	private static Dictionary<CursorType, CursorInfo> mapping; //Field offset: 0x0
	private static bool loaded; //Field offset: 0x8
	private static int size; //Field offset: 0xC
	private static Texture2D allCursors; //Field offset: 0x10
	[CompilerGenerated]
	private Action cursorChange; //Field offset: 0x10
	[CompilerGenerated]
	private Texture2D <Texture>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Vector2 <Hotspot>k__BackingField; //Field offset: 0x20
	private bool _hasMouse; //Field offset: 0x28
	protected Texture2D normalTexture; //Field offset: 0x30
	protected Texture2D customTexture; //Field offset: 0x38

	public event Action cursorChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool HasMouse
	{
		 get { } //Length: 5
		 set { } //Length: 32
	}

	public override Vector2 Hotspot
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Texture2D Texture
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	private static BrowserCursor() { }

	public BrowserCursor() { }

	[CompilerGenerated]
	public void add_cursorChange(Action value) { }

	private Texture2D CreateTexture(int w, int h) { }

	public bool get_HasMouse() { }

	[CompilerGenerated]
	public override Vector2 get_Hotspot() { }

	[CompilerGenerated]
	public override Texture2D get_Texture() { }

	private static void Load() { }

	[CompilerGenerated]
	public void remove_cursorChange(Action value) { }

	public void set_HasMouse(bool value) { }

	[CompilerGenerated]
	protected override void set_Hotspot(Vector2 value) { }

	[CompilerGenerated]
	protected override void set_Texture(Texture2D value) { }

	public override void SetActiveCursor(CursorType type) { }

	public override void SetCustomCursor(Texture2D cursor, Vector2 hotspot) { }

}

