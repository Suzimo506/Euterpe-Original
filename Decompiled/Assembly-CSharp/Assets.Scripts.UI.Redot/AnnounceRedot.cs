using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x200084A")]
public class AnnounceRedot : AbstractRedotComponent
{
	[Token(Token = "0x4002B46")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_ImgRedot;

	[Token(Token = "0x6004C2C")]
	[Address(RVA = "0x609220", Offset = "0x607A20", Length = "0x37")]
	public override void UpdateRedotState()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004C2D")]
	public AnnounceRedot()
	{
	}
}
