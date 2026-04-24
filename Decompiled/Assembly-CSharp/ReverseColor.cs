using Assets.Scripts.Graphics;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200005C")]
public class ReverseColor : PostEffectsBase
{
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x28")]
	public Shader screenEffectShader;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x30")]
	private Material m_ScreenEffectMaterial;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	public float reverseValue;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000233")]
	[Attribute(Name = "RangeAttribute", RVA = "0x64C80", Offset = "0x64080")]
	public float gradualWidth;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000234")]
	private bool m_IsInverse;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x41")]
	public bool pass;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x44")]
	private int m_ReverseValueID;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000237")]
	private int m_GradualWidthID;

	[Token(Token = "0x17000050")]
	public Material material
	{
		[Address(RVA = "0x56C6F0", Offset = "0x56AEF0", Length = "0x97")]
		[Token(Token = "0x60002C9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x56C490", Offset = "0x56AC90", Length = "0x4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x56C640", Offset = "0x56AE40", Length = "0x85")]
	public void SetInverse(bool inverse)
	{
	}

	[Address(RVA = "0x56C490", Offset = "0x56AC90", Length = "0x4C")]
	[Token(Token = "0x60002CC")]
	private void SetShaderPropertyID()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x56C4E0", Offset = "0x56ACE0", Length = "0x15E")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x56C6D0", Offset = "0x56AED0", Length = "0x15")]
	public ReverseColor()
	{
	}
}
