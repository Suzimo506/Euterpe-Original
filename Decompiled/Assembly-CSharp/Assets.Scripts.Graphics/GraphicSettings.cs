using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006F4")]
public class GraphicSettings
{
	[Token(Token = "0x4002564")]
	private static int m_IdPeroTime;

	[Token(Token = "0x4002565")]
	private static float m_StartTime;

	[Token(Token = "0x4002566")]
	public static int originScreenWidth;

	[Token(Token = "0x4002567")]
	public static int originScreenHeight;

	[Token(Token = "0x4002568")]
	public static int curScreenWidth;

	[Token(Token = "0x4002569")]
	public static int curScreenHeight;

	[Token(Token = "0x400256A")]
	private static int m_PassFrame;

	[Token(Token = "0x400256B")]
	private static float m_PassTime;

	[Token(Token = "0x400256C")]
	private static int m_FrameCount;

	[Token(Token = "0x400256D")]
	public static readonly Vector2Int default_resolution;

	[Token(Token = "0x400256E")]
	public static List<Vector2Int> pc_window_dpis;

	[Token(Token = "0x400256F")]
	public static List<Vector2Int> pc_fullmode_dpis;

	[Token(Token = "0x4002570")]
	private const uint SWP_SHOWWINDOW = 64u;

	[Token(Token = "0x4002571")]
	private const int GWL_STYLE = -16;

	[Token(Token = "0x4002572")]
	private const int WS_BORDER = 1;

	[Token(Token = "0x4002573")]
	private const int WS_POPUP = 8388608;

	[Token(Token = "0x4002574")]
	private const int WS_CAPTION = 12582912;

	[Token(Token = "0x4002575")]
	public const int standard = 1;

	[Token(Token = "0x4002576")]
	public const int extra_standard = 2;

	[Token(Token = "0x4002577")]
	public const int four_to_three = 0;

	[Token(Token = "0x4002578")]
	private const float standard_scale = 1.7777778f;

	[Token(Token = "0x17000603")]
	public static bool isFrameOverOneHundred
	{
		[Address(RVA = "0xC71D50", Offset = "0xC70550", Length = "0x5A")]
		[Token(Token = "0x6004186")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000604")]
	public static bool isOverOneHundred
	{
		[Address(RVA = "0xC71E50", Offset = "0xC70650", Length = "0x29")]
		[Token(Token = "0x6004187")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000605")]
	public static bool is43
	{
		[Address(RVA = "0xC71CB0", Offset = "0xC704B0", Length = "0x99")]
		[Token(Token = "0x6004188")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000606")]
	public static bool isLongWidth
	{
		[Token(Token = "0x6004189")]
		[Address(RVA = "0xC71DB0", Offset = "0xC705B0", Length = "0x95")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000607")]
	public static Vector2 GameResolution
	{
		[Token(Token = "0x600418A")]
		[Address(RVA = "0xC71C60", Offset = "0xC70460", Length = "0x43")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000608")]
	public static int screenAdapter
	{
		[Address(RVA = "0xC71E80", Offset = "0xC70680", Length = "0x9E")]
		[Token(Token = "0x600418B")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0xC70B90", Offset = "0xC6F390", Length = "0x13A")]
	[Token(Token = "0x6004185")]
	private static void GetCurrentFrame(float t)
	{
	}

	[Address(RVA = "0xC70DD0", Offset = "0xC6F5D0", Length = "0x518")]
	[Token(Token = "0x600418C")]
	public static void Init()
	{
	}

	[Address(RVA = "0xC71420", Offset = "0xC6FC20", Length = "0x2C7")]
	[Token(Token = "0x600418D")]
	public static void SetResolution(int w, int h, bool fullScreen)
	{
	}

	[Address(RVA = "0xC716F0", Offset = "0xC6FEF0", Length = "0x10F")]
	[Token(Token = "0x600418E")]
	public static void SetWindow(int width, int height, bool fullScreen, bool displayBorder)
	{
	}

	[Token(Token = "0x600418F")]
	[Address(RVA = "0x492780", Offset = "0x490F80", Length = "0x6")]
	public static int GetRecommandEffectCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004190")]
	[Address(RVA = "0xC70CD0", Offset = "0xC6F4D0", Length = "0xF0")]
	public static int GetRecommandQualityCode()
	{
		return default(int);
	}

	[Address(RVA = "0xC712F0", Offset = "0xC6FAF0", Length = "0x20")]
	[Token(Token = "0x6004191")]
	public static void SetFps(int fps, bool vsnyc)
	{
	}

	[Address(RVA = "0xC709D0", Offset = "0xC6F1D0", Length = "0x1BE")]
	[Token(Token = "0x6004192")]
	public static Vector2Int FindClosestResolution()
	{
		return default(Vector2Int);
	}

	[Address(RVA = "0xC70960", Offset = "0xC6F160", Length = "0x6C")]
	[Token(Token = "0x6004193")]
	public static int CalculateDistance(Vector2Int resolution1, Vector2Int resolution2)
	{
		return default(int);
	}

	[Address(RVA = "0xC71310", Offset = "0xC6FB10", Length = "0x10E")]
	[Token(Token = "0x6004194")]
	public static void SetResolutionFitSteamDeck()
	{
	}

	[Address(RVA = "0xC71800", Offset = "0xC70000", Length = "0xD3")]
	[Token(Token = "0x6004195")]
	private static void Update(float arg0)
	{
	}

	[Token(Token = "0x6004196")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004197")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GraphicSettings()
	{
	}
}
