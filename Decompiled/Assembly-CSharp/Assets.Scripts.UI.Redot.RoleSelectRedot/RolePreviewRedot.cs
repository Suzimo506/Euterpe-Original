using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot.RoleSelectRedot;

[Token(Token = "0x2000856")]
public class RolePreviewRedot : AbstractRedotComponent
{
	[SerializeField]
	[Token(Token = "0x4002B5C")]
	[FieldOffset(Offset = "0x38")]
	private Image m_ImgRedot;

	[Token(Token = "0x6004C5C")]
	[Address(RVA = "0x61A650", Offset = "0x618E50", Length = "0xF7")]
	public override void UpdateRedotState()
	{
	}

	[Token(Token = "0x6004C5D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RolePreviewRedot()
	{
	}
}
