using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x2000849")]
public class AnnounceOptionRedot : AbstractRedotComponent
{
	[SerializeField]
	[Token(Token = "0x4002B45")]
	[FieldOffset(Offset = "0x38")]
	private Image m_ImgRedot;

	[Token(Token = "0x6004C29")]
	[Address(RVA = "0x6091C0", Offset = "0x6079C0", Length = "0x54")]
	protected override void AfterInitOnAwakeCallback()
	{
	}

	[Token(Token = "0x6004C2A")]
	[Address(RVA = "0x609220", Offset = "0x607A20", Length = "0x37")]
	public override void UpdateRedotState()
	{
	}

	[Token(Token = "0x6004C2B")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AnnounceOptionRedot()
	{
	}
}
