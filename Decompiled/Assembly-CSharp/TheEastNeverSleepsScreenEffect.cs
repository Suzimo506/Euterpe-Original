using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.Graphics;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200005E")]
public class TheEastNeverSleepsScreenEffect : PostEffectsBase, IUpdate
{
	[Token(Token = "0x20009BC")]
	private struct FlashData
	{
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40034E5")]
		public float start;

		[Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40034E6")]
		public float end;

		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40034E7")]
		public float duration;

		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40034E8")]
		public uint type;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x20009BD")]
	private struct FlashType
	{
		[Token(Token = "0x40034E9")]
		public const uint flash_in = 0u;

		[Token(Token = "0x40034EA")]
		public const uint flash_hold = 1u;

		[Token(Token = "0x40034EB")]
		public const uint flash_out = 2u;
	}

	[Token(Token = "0x4000299")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Shader screenEffectShader;

	[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400029A")]
	private Material m_ScreenEffectMaterial;

	[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x64F90", Offset = "0x64390")]
	[Token(Token = "0x400029B")]
	[Attribute(Name = "RangeAttribute", RVA = "0x64F90", Offset = "0x64390")]
	public float verticalRollIntensity;

	[Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400029C")]
	public bool changeVerticalDir;

	[Token(Token = "0x400029D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float m_VerticalSpeed;

	[Token(Token = "0x400029E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float m_VerticalRollTime;

	[Attribute(Name = "RangeAttribute", RVA = "0x65130", Offset = "0x64530")]
	[Token(Token = "0x400029F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x65130", Offset = "0x64530")]
	public float sinScale;

	[Attribute(Name = "RangeAttribute", RVA = "0x65380", Offset = "0x64780")]
	[Token(Token = "0x40002A0")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float sinCycle;

	[Token(Token = "0x40002A1")]
	[Attribute(Name = "RangeAttribute", RVA = "0x65810", Offset = "0x64C10")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float strength;

	[Attribute(Name = "RangeAttribute", RVA = "0x65B40", Offset = "0x64F40")]
	[Token(Token = "0x40002A2")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public int lineBlockPart;

	[Token(Token = "0x40002A3")]
	[Attribute(Name = "RangeAttribute", RVA = "0x42490", Offset = "0x41890")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float lineBlockBlanking;

	[Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002A4")]
	private float m_LineBlockTime;

	[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002A5")]
	private float m_TimeLB;

	[Token(Token = "0x40002A6")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float m_SinScale;

	[Attribute(Name = "RangeAttribute", RVA = "0x65F10", Offset = "0x65310")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002A7")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x65F10", Offset = "0x65310")]
	public float colorOffset;

	[Token(Token = "0x40002A8")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float m_ColorOffset;

	[Attribute(Name = "HeaderAttribute", RVA = "0x66450", Offset = "0x65850")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002A9")]
	[Attribute(Name = "RangeAttribute", RVA = "0x66450", Offset = "0x65850")]
	public float vignetteSize;

	[Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40002AA")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	public float blackDegree;

	[Token(Token = "0x40002AB")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	[Attribute(Name = "RangeAttribute", RVA = "0x2C630", Offset = "0x2BA30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x2C630", Offset = "0x2BA30")]
	public float whiteAlpha;

	[Attribute(Name = "RangeAttribute", RVA = "0x66C20", Offset = "0x66020")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x66C20", Offset = "0x66020")]
	[Token(Token = "0x40002AC")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float rollTransitionTime;

	[Token(Token = "0x40002AD")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	[Attribute(Name = "RangeAttribute", RVA = "0x67210", Offset = "0x66610")]
	public float rgbTransitionTime;

	[Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	[Attribute(Name = "RangeAttribute", RVA = "0x67210", Offset = "0x66610")]
	[Token(Token = "0x40002AE")]
	public float blackTransitionTime;

	[Token(Token = "0x40002AF")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private bool m_IsRoll;

	[Cpp2ILInjected.FieldOffset(Offset = "0x89")]
	[Token(Token = "0x40002B0")]
	private bool m_IsTwist;

	[Token(Token = "0x40002B1")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
	private bool m_IsRGB;

	[Cpp2ILInjected.FieldOffset(Offset = "0x8B")]
	[Token(Token = "0x40002B2")]
	private bool m_IsBlackSide;

	[Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40002B3")]
	private bool m_IsValueNoise;

	[Cpp2ILInjected.FieldOffset(Offset = "0x8D")]
	[Token(Token = "0x40002B4")]
	private bool isPlay;

	[Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002B5")]
	private int m_VerticalRollIntensityID;

	[Token(Token = "0x40002B6")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private int m_VerticalRollTimeID;

	[Token(Token = "0x40002B7")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private int m_SinCycleID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40002B8")]
	private int m_SinScaleID;

	[Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002B9")]
	private int m_TimeLBID;

	[Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40002BA")]
	private int m_LineBlockPartID;

	[Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40002BB")]
	private int m_LineBlockBlankingID;

	[Token(Token = "0x40002BC")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private int m_ColorOffsetID;

	[Token(Token = "0x40002BD")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private int m_VignetteSizeID;

	[Token(Token = "0x40002BE")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private int m_BlackDegreeID;

	[Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40002BF")]
	private int m_WhiteAlphaID;

	[Token(Token = "0x40002C0")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private FlashData[] m_FlashArray;

	[Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40002C1")]
	private float m_CurrentTime;

	[Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40002C2")]
	private float timer;

	[Token(Token = "0x40002C3")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private int m_StartIndex;

	[Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40002C4")]
	private int m_ArrayLength;

	[Token(Token = "0x40002C5")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private UnityGameManager.LoopType m_UpdateType;

	[Token(Token = "0x17000053")]
	public Material material
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x51DC10", Offset = "0x51C410", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000054")]
	public UnityGameManager.LoopType LoopType
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x51DC00", Offset = "0x51C400", Length = "0x7")]
		get
		{
			return default(UnityGameManager.LoopType);
		}
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x51CBC0", Offset = "0x51B3C0", Length = "0x227")]
	public void Init()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x51CDF0", Offset = "0x51B5F0", Length = "0xB05")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Address(RVA = "0x51DB30", Offset = "0x51C330", Length = "0x8")]
	[Token(Token = "0x60002E5")]
	public void Play()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x51DB20", Offset = "0x51C320", Length = "0x8")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x51DB60", Offset = "0x51C360", Length = "0xB")]
	public void ScreenScroll(bool isOn, bool isUp)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x51DB80", Offset = "0x51C380", Length = "0x7")]
	public void ScreenTwist(bool isOn)
	{
	}

	[Address(RVA = "0x51DB40", Offset = "0x51C340", Length = "0x7")]
	[Token(Token = "0x60002E9")]
	public void ScreenDispresion(bool isOn)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x51DB50", Offset = "0x51C350", Length = "0x7")]
	public void ScreenOldTV(bool isOn)
	{
	}

	[Address(RVA = "0x51DB70", Offset = "0x51C370", Length = "0x7")]
	[Token(Token = "0x60002EB")]
	public void ScreenSnowflake(bool isOn)
	{
	}

	[Address(RVA = "0x51C970", Offset = "0x51B170", Length = "0x24C")]
	[Token(Token = "0x60002EC")]
	public void InitFlash(List<uint> uintList, List<float> decimalList)
	{
	}

	[Address(RVA = "0x51D900", Offset = "0x51C100", Length = "0x219")]
	[Token(Token = "0x60002EE")]
	public void OnUpdate()
	{
	}

	[Address(RVA = "0x51DB90", Offset = "0x51C390", Length = "0x68")]
	[Token(Token = "0x60002EF")]
	public TheEastNeverSleepsScreenEffect()
	{
	}
}
