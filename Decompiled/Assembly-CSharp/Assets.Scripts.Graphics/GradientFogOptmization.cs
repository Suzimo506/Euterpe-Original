using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006F3")]
public class GradientFogOptmization : PostEffectsBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002558")]
	public Shader fogShader;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002559")]
	public Texture fogTexture;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400255A")]
	private Camera m_Cam;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400255B")]
	private Material m_FogMaterial;

	[Token(Token = "0x400255C")]
	[FieldOffset(Offset = "0x48")]
	private int m_FogTexId;

	[Token(Token = "0x400255D")]
	[FieldOffset(Offset = "0x4C")]
	private int m_Height;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400255E")]
	private float m_PassTime;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400255F")]
	private int m_PassTimeId;

	[Token(Token = "0x4002560")]
	[FieldOffset(Offset = "0x58")]
	private RenderTexture m_RenderTexture;

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0x60")]
	private int m_TotalTimeId;

	[Token(Token = "0x4002562")]
	[FieldOffset(Offset = "0x64")]
	private int m_Width;

	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0x68")]
	public float totalTime;

	[Token(Token = "0x600417D")]
	[Address(RVA = "0xC6FE00", Offset = "0xC6E600", Length = "0x59")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Address(RVA = "0xC70140", Offset = "0xC6E940", Length = "0xAD")]
	[Token(Token = "0x600417E")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x600417F")]
	[Address(RVA = "0xC6FFD0", Offset = "0xC6E7D0", Length = "0x16F")]
	private void OnPostRender()
	{
	}

	[Address(RVA = "0xC701F0", Offset = "0xC6E9F0", Length = "0x1F9")]
	[Token(Token = "0x6004180")]
	protected override void Start()
	{
	}

	[Address(RVA = "0xC6FE60", Offset = "0xC6E660", Length = "0x8")]
	[Token(Token = "0x6004181")]
	private void EnableFog(bool enable)
	{
	}

	[Address(RVA = "0xC6FE70", Offset = "0xC6E670", Length = "0x150")]
	[Token(Token = "0x6004182")]
	protected override void OnDestroy()
	{
	}

	[Address(RVA = "0xC703F0", Offset = "0xC6EBF0", Length = "0x2E")]
	[Token(Token = "0x6004183")]
	private void Update()
	{
	}

	[Token(Token = "0x6004184")]
	[Address(RVA = "0xC70420", Offset = "0xC6EC20", Length = "0x7")]
	public GradientFogOptmization()
	{
	}
}
