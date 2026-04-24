using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006F5")]
public class NoDrawingRayCast : Graphic
{
	[Token(Token = "0x6004199")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void SetMaterialDirty()
	{
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void SetVerticesDirty()
	{
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0xC86F80", Offset = "0xC85780", Length = "0x1F")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600419C")]
	[Address(RVA = "0xC86FA0", Offset = "0xC857A0", Length = "0x51")]
	public NoDrawingRayCast()
	{
	}
}
