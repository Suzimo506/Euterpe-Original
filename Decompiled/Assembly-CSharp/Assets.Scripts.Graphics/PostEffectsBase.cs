using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006F6")]
[Attribute(Name = "RequireComponent", RVA = "0x73B10", Offset = "0x72F10")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x4002579")]
	[FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x400257A")]
	[FieldOffset(Offset = "0x19")]
	protected bool supportDX11;

	[Token(Token = "0x400257B")]
	[FieldOffset(Offset = "0x1A")]
	protected bool isSupported;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400257C")]
	private List<Material> createdMaterials;

	[Token(Token = "0x600419D")]
	[Address(RVA = "0xC870E0", Offset = "0xC858E0", Length = "0x455")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Address(RVA = "0xC879E0", Offset = "0xC861E0", Length = "0x1DF")]
	[Token(Token = "0x600419E")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Address(RVA = "0xC88040", Offset = "0xC86840", Length = "0x5")]
	[Token(Token = "0x600419F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60041A0")]
	[Address(RVA = "0xC87F80", Offset = "0xC86780", Length = "0xB2")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60041A1")]
	[Address(RVA = "0xC87F80", Offset = "0xC86780", Length = "0xB2")]
	private void RemoveCreatedMaterials()
	{
	}

	[Address(RVA = "0xC87880", Offset = "0xC86080", Length = "0x7B")]
	[Token(Token = "0x60041A2")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60041A3")]
	[Address(RVA = "0xC87050", Offset = "0xC85850", Length = "0x8E")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60041A4")]
	[Address(RVA = "0x463800", Offset = "0x462000", Length = "0x11")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60041A5")]
	[Address(RVA = "0xC87900", Offset = "0xC86100", Length = "0xD4")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x60041A6")]
	[Address(RVA = "0xC87820", Offset = "0xC86020", Length = "0x53")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x60041A7")]
	[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x60041A8")]
	[Address(RVA = "0xC88050", Offset = "0xC86850", Length = "0x80")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x60041A9")]
	[Address(RVA = "0xC87540", Offset = "0xC85D40", Length = "0x2D2")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Address(RVA = "0xC87F60", Offset = "0xC86760", Length = "0x1D")]
	[Token(Token = "0x60041AA")]
	protected void NotSupported()
	{
	}

	[Address(RVA = "0xC87BC0", Offset = "0xC863C0", Length = "0x397")]
	[Token(Token = "0x60041AB")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Address(RVA = "0xC880D0", Offset = "0xC868D0", Length = "0x71")]
	[Token(Token = "0x60041AC")]
	public PostEffectsBase()
	{
	}
}
