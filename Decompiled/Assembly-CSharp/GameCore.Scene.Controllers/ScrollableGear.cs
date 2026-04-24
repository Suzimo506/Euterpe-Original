using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.Scene.Controllers;

[Token(Token = "0x2000468")]
public class ScrollableGear : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001808")]
	private Scrollable[] m_Scrollables;

	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x90CF10", Offset = "0x90B710", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003300")]
	[Address(RVA = "0x90CF60", Offset = "0x90B760", Length = "0x1BE")]
	public void SetProgressByMileage(float mile)
	{
	}

	[Token(Token = "0x6003301")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ScrollableGear()
	{
	}
}
