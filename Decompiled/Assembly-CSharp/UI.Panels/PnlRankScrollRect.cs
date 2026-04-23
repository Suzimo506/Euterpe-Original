using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace UI.Panels;

[Token(Token = "0x20001C5")]
public class PnlRankScrollRect : ReuseScorllRect
{
	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x70")]
	private JToken m_Token;

	[Token(Token = "0x4000B2C")]
	[FieldOffset(Offset = "0x78")]
	public float axisSpeed;

	[Token(Token = "0x4000B2D")]
	[FieldOffset(Offset = "0x80")]
	public string axisName;

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x4DBA60", Offset = "0x4DA260", Length = "0x16B")]
	public void SetToken(JToken t)
	{
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x4DB870", Offset = "0x4DA070", Length = "0x1E2")]
	public override void SetCell(GameObject obj, int index)
	{
	}

	[Address(RVA = "0x4DB790", Offset = "0x4D9F90", Length = "0xD0")]
	[Token(Token = "0x6000CC4")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x4DBBD0", Offset = "0x4DA3D0", Length = "0x7")]
	public PnlRankScrollRect()
	{
	}
}
