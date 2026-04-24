using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000098")]
public class ExButton : Button
{
	[Address(RVA = "0x449870", Offset = "0x448070", Length = "0x1A7")]
	[Token(Token = "0x60004CB")]
	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	[Address(RVA = "0x449350", Offset = "0x447B50", Length = "0x1A2")]
	[Token(Token = "0x60004CC")]
	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x449500", Offset = "0x447D00", Length = "0x1A7")]
	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Address(RVA = "0x4496B0", Offset = "0x447EB0", Length = "0x1BE")]
	[Token(Token = "0x60004CE")]
	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Address(RVA = "0x448D00", Offset = "0x447500", Length = "0x646")]
	[Token(Token = "0x60004CF")]
	private Selectable FindSelectableObjectInCustomRange(Vector2 dir)
	{
		return null;
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x449A20", Offset = "0x448220", Length = "0x2A0")]
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
	{
		return default(Vector3);
	}

	[Address(RVA = "0x449CD0", Offset = "0x4484D0", Length = "0x7")]
	[Token(Token = "0x60004D1")]
	public ExButton()
	{
	}
}
