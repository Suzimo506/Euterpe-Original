using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006F2")]
[Attribute(Name = "RequireComponent", RVA = "0x72ED0", Offset = "0x722D0")]
[Attribute(Name = "AddComponentMenu", RVA = "0x72ED0", Offset = "0x722D0")]
[ExecuteInEditMode]
public class GradientFog : PostEffectsBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002554")]
	public Gradient fogGradient;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002555")]
	public Shader fogShader;

	[Token(Token = "0x4002556")]
	[FieldOffset(Offset = "0x38")]
	private Material m_FogMaterial;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002557")]
	private RenderTexture m_RenderTexture;

	[Token(Token = "0x6004179")]
	[Address(RVA = "0xC70430", Offset = "0xC6EC30", Length = "0x59")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0xC70540", Offset = "0xC6ED40", Length = "0x410")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0xC70490", Offset = "0xC6EC90", Length = "0xAD")]
	private void OnPostRender()
	{
	}

	[Address(RVA = "0xC70420", Offset = "0xC6EC20", Length = "0x7")]
	[Token(Token = "0x600417C")]
	public GradientFog()
	{
	}
}
