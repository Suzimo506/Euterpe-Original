using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200005B")]
public class OutlineEx : BaseMeshEffect
{
	[Token(Token = "0x400022B")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Color OutlineColor;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400022C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xCF40", Offset = "0xC340")]
	[SerializeField]
	private int OutlineWidth;

	[Token(Token = "0x400022D")]
	private static List<UIVertex> m_VetexList;

	[Token(Token = "0x400022E")]
	private static readonly string STR_OUTLINESHADER;

	[Token(Token = "0x400022F")]
	private static Shader shader;

	[Token(Token = "0x1700004E")]
	public Color _OutlineColor
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x7322C0", Offset = "0x730AC0", Length = "0xB")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0x8726A0", Offset = "0x870EA0", Length = "0xE")]
		[Token(Token = "0x60002BA")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public int _OutlineWidth
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8726B0", Offset = "0x870EB0", Length = "0xA")]
		set
		{
		}
	}

	[Address(RVA = "0x871160", Offset = "0x86F960", Length = "0x338")]
	[Token(Token = "0x60002BD")]
	protected override void Start()
	{
	}

	[Address(RVA = "0x871010", Offset = "0x86F810", Length = "0x148")]
	[Token(Token = "0x60002BE")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x8721C0", Offset = "0x8709C0", Length = "0xDF")]
	private void _Refresh()
	{
	}

	[Address(RVA = "0x870F60", Offset = "0x86F760", Length = "0xAC")]
	[Token(Token = "0x60002C0")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x871740", Offset = "0x86FF40", Length = "0xA79")]
	private void _ProcessVertices()
	{
	}

	[Address(RVA = "0x8722A0", Offset = "0x870AA0", Length = "0x345")]
	[Token(Token = "0x60002C2")]
	private static UIVertex _SetNewPosAndUV(UIVertex pVertex, int pOutLineWidth, Vector2 pPosCenter, Vector2 pTriangleX, Vector2 pTriangleY, Vector2 pUVX, Vector2 pUVY, Vector4 pUVOrigin)
	{
		return default(UIVertex);
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x8715F0", Offset = "0x86FDF0", Length = "0x85")]
	private static float _Min(float pA, float pB, float pC)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x871560", Offset = "0x86FD60", Length = "0x85")]
	private static float _Max(float pA, float pB, float pC)
	{
		return default(float);
	}

	[Address(RVA = "0x871680", Offset = "0x86FE80", Length = "0xB1")]
	[Token(Token = "0x60002C5")]
	private static Vector2 _Min(Vector2 pA, Vector2 pB, Vector2 pC)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x8714A0", Offset = "0x86FCA0", Length = "0xB1")]
	private static Vector2 _Max(Vector2 pA, Vector2 pB, Vector2 pC)
	{
		return default(Vector2);
	}

	[Address(RVA = "0x872670", Offset = "0x870E70", Length = "0x2B")]
	[Token(Token = "0x60002C7")]
	public OutlineEx()
	{
	}
}
