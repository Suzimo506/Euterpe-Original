using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200019E")]
[ExecuteInEditMode]
public class VerticalTxt : BaseMeshEffect
{
	[Attribute(Name = "TooltipAttribute", RVA = "0x445B0", Offset = "0x439B0")]
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x20")]
	public float spacing;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000A3D")]
	private float lineSpacing;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A3E")]
	private float textSpacing;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A3F")]
	private float xOffset;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A40")]
	private float yOffset;

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x4EC230", Offset = "0x4EAA30", Length = "0x329")]
	public override void ModifyMesh(VertexHelper helper)
	{
	}

	[Address(RVA = "0x4EC580", Offset = "0x4EAD80", Length = "0x6D6")]
	[Token(Token = "0x6000BCB")]
	private void modifyText(VertexHelper helper, int i, int charYPos, int charXPos)
	{
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x4EC560", Offset = "0x4EAD60", Length = "0x1C")]
	public VerticalTxt()
	{
	}
}
