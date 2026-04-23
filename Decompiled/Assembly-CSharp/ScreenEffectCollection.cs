using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.Graphics;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200005D")]
public class ScreenEffectCollection : PostEffectsBase, IUpdate
{
	[Token(Token = "0x20009BA")]
	private struct FlashData
	{
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40034DE")]
		public float start;

		[Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40034DF")]
		public float end;

		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40034E0")]
		public float duration;

		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40034E1")]
		public uint type;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x20009BB")]
	private struct FlashType
	{
		[Token(Token = "0x40034E2")]
		public const uint flash_in = 0u;

		[Token(Token = "0x40034E3")]
		public const uint flash_hold = 1u;

		[Token(Token = "0x40034E4")]
		public const uint flash_out = 2u;
	}

	[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000238")]
	public Shader screenEffectShader;

	[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000239")]
	private Material m_ScreenEffectMaterial;

	[Token(Token = "0x400023A")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x64F90", Offset = "0x64390")]
	[Attribute(Name = "RangeAttribute", RVA = "0x64F90", Offset = "0x64390")]
	public float verticalRollIntensity;

	[Token(Token = "0x400023B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public bool changeVerticalDir;

	[Token(Token = "0x400023C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float m_VerticalSpeed;

	[Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400023D")]
	private float m_VerticalRollTime;

	[Attribute(Name = "RangeAttribute", RVA = "0x65130", Offset = "0x64530")]
	[Token(Token = "0x400023E")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x65130", Offset = "0x64530")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float sinScale;

	[Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400023F")]
	[Attribute(Name = "RangeAttribute", RVA = "0x65380", Offset = "0x64780")]
	public float sinCycle;

	[Attribute(Name = "RangeAttribute", RVA = "0x65810", Offset = "0x64C10")]
	[Token(Token = "0x4000240")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float strength;

	[Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	[Attribute(Name = "RangeAttribute", RVA = "0x65B40", Offset = "0x64F40")]
	[Token(Token = "0x4000241")]
	public int lineBlockPart;

	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	[Attribute(Name = "RangeAttribute", RVA = "0x42490", Offset = "0x41890")]
	[Token(Token = "0x4000242")]
	public float lineBlockBlanking;

	[Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000243")]
	private float m_LineBlockTime;

	[Token(Token = "0x4000244")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private float m_TimeLB;

	[Token(Token = "0x4000245")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float m_SinScale;

	[Attribute(Name = "HeaderAttribute", RVA = "0x65F10", Offset = "0x65310")]
	[Attribute(Name = "RangeAttribute", RVA = "0x65F10", Offset = "0x65310")]
	[Token(Token = "0x4000246")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float colorOffset;

	[Token(Token = "0x4000247")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float m_ColorOffset;

	[Attribute(Name = "HeaderAttribute", RVA = "0x66450", Offset = "0x65850")]
	[Attribute(Name = "RangeAttribute", RVA = "0x66450", Offset = "0x65850")]
	[Token(Token = "0x4000248")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float vignetteSize;

	[Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x4000249")]
	public float blackDegree;

	[Attribute(Name = "HeaderAttribute", RVA = "0x2C630", Offset = "0x2BA30")]
	[Attribute(Name = "RangeAttribute", RVA = "0x2C630", Offset = "0x2BA30")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400024A")]
	public float whiteAlpha;

	[Token(Token = "0x400024B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public Color flashColor;

	[Attribute(Name = "RangeAttribute", RVA = "0x66C20", Offset = "0x66020")]
	[Token(Token = "0x400024C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x66C20", Offset = "0x66020")]
	public float rollTransitionTime;

	[Attribute(Name = "RangeAttribute", RVA = "0x67210", Offset = "0x66610")]
	[Token(Token = "0x400024D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float rgbTransitionTime;

	[Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400024E")]
	[Attribute(Name = "RangeAttribute", RVA = "0x67210", Offset = "0x66610")]
	public float blackTransitionTime;

	[Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400024F")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x68A20", Offset = "0x67E20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x68A20", Offset = "0x67E20")]
	public int pixelSize;

	[Token(Token = "0x4000250")]
	[Attribute(Name = "RangeAttribute", RVA = "0x68D50", Offset = "0x68150")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x68D50", Offset = "0x68150")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public float grayScaleAlpha;

	[Token(Token = "0x4000251")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float grayScale;

	[Attribute(Name = "RangeAttribute", RVA = "0x67210", Offset = "0x66610")]
	[Token(Token = "0x4000252")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public float grayScaleTransitionTime;

	[Token(Token = "0x4000253")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x69390", Offset = "0x68790")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Vector2 lineCenter;

	[Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x695B0", Offset = "0x689B0")]
	[Token(Token = "0x4000254")]
	public int lineCount;

	[Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x4000255")]
	public float lineDensity;

	[Token(Token = "0x4000256")]
	[Attribute(Name = "RangeAttribute", RVA = "0x69A40", Offset = "0x68E40")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float lineCenterMaskSize;

	[Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x4000257")]
	public float lineFalloff;

	[Attribute(Name = "RangeAttribute", RVA = "0x2A6E0", Offset = "0x29AE0")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000258")]
	public float lineSpeed;

	[Token(Token = "0x4000259")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	[Attribute(Name = "RangeAttribute", RVA = "0x2A6E0", Offset = "0x29AE0")]
	public float lineFrames;

	[Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400025A")]
	public Color lineColorWhite;

	[Token(Token = "0x400025B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color lineColorBlack;

	[Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400025C")]
	public bool lineIsComicLineBlack;

	[Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x400025D")]
	private float m_LineSpeed;

	[Attribute(Name = "HeaderAttribute", RVA = "0x6A0A0", Offset = "0x694A0")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6A0A0", Offset = "0x694A0")]
	[Token(Token = "0x400025E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public float oldFilmAmount;

	[Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400025F")]
	public Texture scratchesTex;

	[Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000260")]
	public Texture dustTex;

	[Attribute(Name = "RangeAttribute", RVA = "0x6A3D0", Offset = "0x697D0")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000261")]
	public float scratchesXSpeed;

	[Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000262")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6A3D0", Offset = "0x697D0")]
	public float scratchesYSpeed;

	[Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	[Attribute(Name = "RangeAttribute", RVA = "0x6A6E0", Offset = "0x69AE0")]
	[Token(Token = "0x4000263")]
	public float dustXSpeed;

	[Attribute(Name = "RangeAttribute", RVA = "0x6A6E0", Offset = "0x69AE0")]
	[Token(Token = "0x4000264")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public float dustYSpeed;

	[Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x4000265")]
	public float colorAmount;

	[Token(Token = "0x4000266")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	public Color additionalColor;

	[Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000267")]
	private float m_RandomValue;

	[Token(Token = "0x4000268")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private bool m_IsRoll;

	[Token(Token = "0x4000269")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x131")]
	private bool m_IsTwist;

	[Cpp2ILInjected.FieldOffset(Offset = "0x132")]
	[Token(Token = "0x400026A")]
	private bool m_IsRGB;

	[Token(Token = "0x400026B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x133")]
	private bool m_IsBlackSide;

	[Token(Token = "0x400026C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	private bool m_IsValueNoise;

	[Cpp2ILInjected.FieldOffset(Offset = "0x135")]
	[Token(Token = "0x400026D")]
	private bool m_IsPixelation;

	[Token(Token = "0x400026E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x136")]
	private bool m_IsGrayScale;

	[Cpp2ILInjected.FieldOffset(Offset = "0x137")]
	[Token(Token = "0x400026F")]
	private bool m_IsComicLine;

	[Token(Token = "0x4000270")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private bool m_IsOldFilm;

	[Token(Token = "0x4000271")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x139")]
	private bool isPlay;

	[Token(Token = "0x4000272")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
	private int m_VerticalRollIntensityID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000273")]
	private int m_VerticalRollTimeID;

	[Token(Token = "0x4000274")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x144")]
	private int m_SinCycleID;

	[Token(Token = "0x4000275")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private int m_SinScaleID;

	[Token(Token = "0x4000276")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
	private int m_TimeLBID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000277")]
	private int m_LineBlockPartID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000278")]
	private int m_LineBlockBlankingID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000279")]
	private int m_ColorOffsetID;

	[Token(Token = "0x400027A")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
	private int m_VignetteSizeID;

	[Token(Token = "0x400027B")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	private int m_BlackDegreeID;

	[Token(Token = "0x400027C")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	private int m_WhiteAlphaID;

	[Token(Token = "0x400027D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	private int m_PixelSizeID;

	[Token(Token = "0x400027E")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
	private int m_GrayScaleEffectID;

	[Token(Token = "0x400027F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	private int m_ComicLineCenterID;

	[Token(Token = "0x4000280")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x174")]
	private int m_ComicLineCountID;

	[Token(Token = "0x4000281")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	private int m_ComicLineDensityID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x4000282")]
	private int m_ComicLineCenterMaskSizeID;

	[Token(Token = "0x4000283")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	private int m_ComicLineFalloffID;

	[Token(Token = "0x4000284")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x184")]
	private int m_ComicLineSpeedID;

	[Token(Token = "0x4000285")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	private int m_ComicLineFramesID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x4000286")]
	private int m_ComicLineColorID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000287")]
	private int m_ScratchesTexID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000288")]
	private int m_DustTexID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000289")]
	private int m_ScratchesXSpeedID;

	[Token(Token = "0x400028A")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
	private int m_ScratchesYSpeedID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x400028B")]
	private int m_DustXSpeedID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x400028C")]
	private int m_DustYSpeedID;

	[Token(Token = "0x400028D")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	private int m_OldFilmAmountID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x400028E")]
	private int m_ColorAmountID;

	[Token(Token = "0x400028F")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private int m_AdditionalColorID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	[Token(Token = "0x4000290")]
	private int m_RandomValueID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000291")]
	private int m_FlashAlphaID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000292")]
	private int m_FlashColorID;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000293")]
	private FlashData[] m_FlashArray;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000294")]
	private float m_CurrentTime;

	[Token(Token = "0x4000295")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
	private float timer;

	[Token(Token = "0x4000296")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	private int m_StartIndex;

	[Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000297")]
	private int m_ArrayLength;

	[Token(Token = "0x4000298")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	private UnityGameManager.LoopType m_UpdateType;

	[Token(Token = "0x17000051")]
	public Material material
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x51DC10", Offset = "0x51C410", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000052")]
	public UnityGameManager.LoopType LoopType
	{
		[Address(RVA = "0x62B410", Offset = "0x629C10", Length = "0x7")]
		[Token(Token = "0x60002DF")]
		get
		{
			return default(UnityGameManager.LoopType);
		}
	}

	[Address(RVA = "0x629670", Offset = "0x627E70", Length = "0x15D")]
	[Token(Token = "0x60002D0")]
	public void Init()
	{
	}

	[Address(RVA = "0x62AF90", Offset = "0x629790", Length = "0x2AA")]
	[Token(Token = "0x60002D1")]
	private void SetShaderProperty()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x6297D0", Offset = "0x627FD0", Length = "0x1483")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Address(RVA = "0x62AEE0", Offset = "0x6296E0", Length = "0x14")]
	[Token(Token = "0x60002D3")]
	public void Play()
	{
	}

	[Address(RVA = "0x62AEC0", Offset = "0x6296C0", Length = "0x12")]
	[Token(Token = "0x60002D4")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x62AF60", Offset = "0x629760", Length = "0xB")]
	public void ScreenScroll(bool isOn, bool isUp = false)
	{
	}

	[Address(RVA = "0x62AF80", Offset = "0x629780", Length = "0x7")]
	[Token(Token = "0x60002D6")]
	public void ScreenTwist(bool isOn)
	{
	}

	[Address(RVA = "0x62AF10", Offset = "0x629710", Length = "0x7")]
	[Token(Token = "0x60002D7")]
	public void ScreenDispresion(bool isOn)
	{
	}

	[Address(RVA = "0x62AF40", Offset = "0x629740", Length = "0x7")]
	[Token(Token = "0x60002D8")]
	public void ScreenOldTV(bool isOn)
	{
	}

	[Address(RVA = "0x62AF70", Offset = "0x629770", Length = "0x7")]
	[Token(Token = "0x60002D9")]
	public void ScreenSnowflake(bool isOn)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x62AF50", Offset = "0x629750", Length = "0x7")]
	public void ScreenPixelation(bool isOn)
	{
	}

	[Address(RVA = "0x62AF20", Offset = "0x629720", Length = "0x7")]
	[Token(Token = "0x60002DB")]
	public void ScreenGrayScale(bool isOn)
	{
	}

	[Address(RVA = "0x62AF00", Offset = "0x629700", Length = "0xE")]
	[Token(Token = "0x60002DC")]
	public void ScreenComics(bool isOn, bool isBlack = false)
	{
	}

	[Address(RVA = "0x62AF30", Offset = "0x629730", Length = "0xD")]
	[Token(Token = "0x60002DD")]
	public void ScreenOldFilm(bool isOn)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x629420", Offset = "0x627C20", Length = "0x24C")]
	public void InitFlash(List<uint> uintList, List<float> decimalList)
	{
	}

	[Address(RVA = "0x62AC60", Offset = "0x629460", Length = "0x25D")]
	[Token(Token = "0x60002E0")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x62B240", Offset = "0x629A40", Length = "0x1CD")]
	public ScreenEffectCollection()
	{
	}
}
