using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000739")]
[Obsolete]
public class FeverManager
{
	[Token(Token = "0x4002621")]
	private static FeverManager m_Instance;

	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0x14")]
	private float m_FeverValue;

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsActivateFever;

	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0x19")]
	public bool isAutoFever;

	[Token(Token = "0x17000647")]
	public static FeverManager Instance
	{
		[Token(Token = "0x6004324")]
		[Address(RVA = "0x78E950", Offset = "0x78D150", Length = "0xFD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000648")]
	public int feverCount
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004326")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004325")]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000649")]
	public bool isManualFeverEnable
	{
		[CompilerGenerated]
		[Token(Token = "0x6004328")]
		[Address(RVA = "0x5754A0", Offset = "0x573CA0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004327")]
		[Address(RVA = "0x575870", Offset = "0x574070", Length = "0x4")]
		private set
		{
		}
	}

	[Address(RVA = "0x78E8E0", Offset = "0x78D0E0", Length = "0x61")]
	[Token(Token = "0x6004323")]
	public FeverManager()
	{
	}

	[Token(Token = "0x6004329")]
	[Address(RVA = "0x78E640", Offset = "0x78CE40", Length = "0x5A")]
	public void InitGameKernel()
	{
	}

	[Token(Token = "0x600432A")]
	[Address(RVA = "0x78E5D0", Offset = "0x78CDD0", Length = "0x61")]
	public float GetFeverRate()
	{
		return default(float);
	}

	[Token(Token = "0x600432B")]
	[Address(RVA = "0x474E90", Offset = "0x473690", Length = "0x6")]
	public float GetWholeFever()
	{
		return default(float);
	}

	[Address(RVA = "0x78E8B0", Offset = "0x78D0B0", Length = "0x2C")]
	[Token(Token = "0x600432C")]
	public void ResetFever()
	{
	}

	[Token(Token = "0x600432D")]
	[Address(RVA = "0x78E3B0", Offset = "0x78CBB0", Length = "0x21D")]
	public void AddFever(float value)
	{
	}

	[Token(Token = "0x600432E")]
	[Address(RVA = "0x78E6A0", Offset = "0x78CEA0", Length = "0x1A2")]
	public void InvokeFever()
	{
	}

	[Token(Token = "0x600432F")]
	[Address(RVA = "0x470810", Offset = "0x46F010", Length = "0x5")]
	public bool IsOnFeverState()
	{
		return default(bool);
	}

	[Address(RVA = "0x78E850", Offset = "0x78D050", Length = "0x55")]
	[Token(Token = "0x6004330")]
	public bool IsGod()
	{
		return default(bool);
	}

	[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
	[Token(Token = "0x6004331")]
	public bool GetIsAutoFever()
	{
		return default(bool);
	}
}
