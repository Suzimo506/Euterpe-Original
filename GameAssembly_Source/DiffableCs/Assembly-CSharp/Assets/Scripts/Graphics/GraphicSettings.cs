namespace Assets.Scripts.Graphics;

public class GraphicSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public int width; //Field offset: 0x10
		public int height; //Field offset: 0x14

		public <>c__DisplayClass33_0() { }

		internal void <SetWindow>b__0() { }

	}

	private static int m_IdPeroTime; //Field offset: 0x0
	public const int extra_standard = 2; //Field offset: 0x0
	public const int standard = 1; //Field offset: 0x0
	private const int WS_CAPTION = 12582912; //Field offset: 0x0
	private const int WS_POPUP = 8388608; //Field offset: 0x0
	private const int WS_BORDER = 1; //Field offset: 0x0
	private const int GWL_STYLE = -16; //Field offset: 0x0
	private const uint SWP_SHOWWINDOW = 64; //Field offset: 0x0
	private const float standard_scale = 1.7777778; //Field offset: 0x0
	public const int four_to_three = 0; //Field offset: 0x0
	private static float m_StartTime; //Field offset: 0x4
	public static int originScreenWidth; //Field offset: 0x8
	public static int originScreenHeight; //Field offset: 0xC
	public static int curScreenWidth; //Field offset: 0x10
	public static int curScreenHeight; //Field offset: 0x14
	private static int m_PassFrame; //Field offset: 0x18
	private static float m_PassTime; //Field offset: 0x1C
	private static int m_FrameCount; //Field offset: 0x20

	public static Vector2 GameResolution
	{
		 get { } //Length: 69
	}

	public static bool is43
	{
		 get { } //Length: 98
	}

	public static bool isFrameOverOneHundred
	{
		 get { } //Length: 57
	}

	public static bool isLongWidth
	{
		 get { } //Length: 94
	}

	public static bool isOverOneHundred
	{
		 get { } //Length: 41
	}

	public static int screenAdapter
	{
		 get { } //Length: 123
	}

	public GraphicSettings() { }

	public static Vector2 get_GameResolution() { }

	public static bool get_is43() { }

	public static bool get_isFrameOverOneHundred() { }

	public static bool get_isLongWidth() { }

	public static bool get_isOverOneHundred() { }

	public static int get_screenAdapter() { }

	private static void GetCurrentFrame(float t) { }

	public static int GetRecommandEffectCode() { }

	public static int GetRecommandQualityCode() { }

	public static void Init() { }

	public static void Reset() { }

	public static void SetFps(int fps, bool vsnyc) { }

	public static void SetResolution(int w, int h, bool fullScreen) { }

	public static void SetWindow(int width, int height, bool fullScreen, bool displayBorder) { }

	private static void Update(float arg0) { }

}

