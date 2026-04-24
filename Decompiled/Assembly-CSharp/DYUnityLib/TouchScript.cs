using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine;

namespace DYUnityLib;

[Token(Token = "0x20004E9")]
public class TouchScript
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x2000B62")]
	private struct TouchIndex
	{
		[Token(Token = "0x4003A14")]
		public const int LR_BEGIN = 0;

		[Token(Token = "0x4003A15")]
		public const int LR_MOVED = 1;

		[Token(Token = "0x4003A16")]
		public const int LR_ENDED = 2;

		[Token(Token = "0x4003A17")]
		public const int UD_BEGIN = 3;

		[Token(Token = "0x4003A18")]
		public const int UD_MOVED = 4;

		[Token(Token = "0x4003A19")]
		public const int UD_ENDED = 5;

		[Token(Token = "0x4003A1A")]
		public const int touch_count = 6;

		[Token(Token = "0x4003A1B")]
		public const int Air = 0;

		[Token(Token = "0x4003A1C")]
		public const int Road = 1;
	}

	[Token(Token = "0x4001A87")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float tickTime;

	[Token(Token = "0x4001A88")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private DBTouch dbTouch;

	[Token(Token = "0x4001A89")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private readonly float[][] m_Touchs;

	[Token(Token = "0x4001A8A")]
	private const int length = 20;

	[Token(Token = "0x4001A8B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly List<GEventHandler<uint>> m_CustomEvent;

	[Token(Token = "0x4001A8C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private Rect m_DisableTouchRect;

	[Token(Token = "0x4001A8D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Vector2[] m_Trapezoids;

	[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A8E")]
	private float m_TouchEventPhaseP;

	[Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001A8F")]
	private int m_JumpIndex;

	[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A90")]
	private int m_PunchIndex;

	[Token(Token = "0x4001A91")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float[] m_JumpTouchs;

	[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A92")]
	private float[] m_PunchTouchs;

	[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A93")]
	private int m_FeverActionId;

	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A94")]
	private readonly MDButtonType[] m_ButtonNames;

	[Token(Token = "0x4001A95")]
	private static int m_TouchsBeginIndex;

	[Token(Token = "0x4001A96")]
	private static int m_TouchsMoveIndex;

	[Token(Token = "0x4001A97")]
	private static int m_TouchsEndIndex;

	[Token(Token = "0x600365E")]
	[Address(RVA = "0x473650", Offset = "0x471E50", Length = "0x10F")]
	public static void OnGameTouchPlayInited()
	{
	}

	[Address(RVA = "0x474740", Offset = "0x472F40", Length = "0x203")]
	[Token(Token = "0x600365F")]
	public TouchScript()
	{
	}

	[Address(RVA = "0x473C30", Offset = "0x472430", Length = "0x137")]
	[Token(Token = "0x6003660")]
	private void Reset()
	{
	}

	[Token(Token = "0x6003661")]
	[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
	public float[][] GetTouchs()
	{
		return null;
	}

	[Token(Token = "0x6003662")]
	[Address(RVA = "0x4726A0", Offset = "0x470EA0", Length = "0x263")]
	public bool IsJumpTouch(TouchPhase phase = TouchPhase.Began)
	{
		return default(bool);
	}

	[Address(RVA = "0x472910", Offset = "0x471110", Length = "0x268")]
	[Token(Token = "0x6003663")]
	public bool IsPunchTouch(TouchPhase phase = TouchPhase.Began)
	{
		return default(bool);
	}

	[Address(RVA = "0x4725A0", Offset = "0x470DA0", Length = "0xF1")]
	[Token(Token = "0x6003664")]
	private void IndexChange(int i, TouchPhase phase, bool isPunch)
	{
	}

	[Address(RVA = "0x472B80", Offset = "0x471380", Length = "0x15A")]
	[Token(Token = "0x6003665")]
	private bool IsPunch(float p)
	{
		return default(bool);
	}

	[Address(RVA = "0x4724D0", Offset = "0x470CD0", Length = "0x74")]
	[Token(Token = "0x6003666")]
	public void AddCustomEvent(GEventHandler<uint> e)
	{
	}

	[Token(Token = "0x6003667")]
	[Address(RVA = "0x473BD0", Offset = "0x4723D0", Length = "0x58")]
	public void RemoveCustomEvent(GEventHandler<uint> e)
	{
	}

	[Address(RVA = "0x472550", Offset = "0x470D50", Length = "0x44")]
	[Token(Token = "0x6003668")]
	public void ClearCustomEvent()
	{
	}

	[Token(Token = "0x6003669")]
	[Address(RVA = "0x474620", Offset = "0x472E20", Length = "0x115")]
	public void TouchTrigger(uint triggerId)
	{
	}

	[Address(RVA = "0x473760", Offset = "0x471F60", Length = "0x46D")]
	[Token(Token = "0x600366A")]
	public void OnStart()
	{
	}

	[Address(RVA = "0x473D70", Offset = "0x472570", Length = "0x225")]
	[Token(Token = "0x600366B")]
	public void TouchEventPhase()
	{
	}

	[Token(Token = "0x600366C")]
	[Address(RVA = "0x4735A0", Offset = "0x471DA0", Length = "0xAC")]
	private void ManualHandler(List<int> pressList, bool isAutoFever, bool invokeFever)
	{
	}

	[Token(Token = "0x600366D")]
	[Address(RVA = "0x472CE0", Offset = "0x4714E0", Length = "0x8B5")]
	private void KeyHandler()
	{
	}

	[Token(Token = "0x600366E")]
	[Address(RVA = "0x473FA0", Offset = "0x4727A0", Length = "0x675")]
	private void TouchHandler(ref Touch touch, int arrayIndex)
	{
	}
}
