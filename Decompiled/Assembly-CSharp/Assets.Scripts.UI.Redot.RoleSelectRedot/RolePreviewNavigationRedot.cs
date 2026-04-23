using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot.RoleSelectRedot;

[Token(Token = "0x2000855")]
public class RolePreviewNavigationRedot : AbstractRedotComponent
{
	[Token(Token = "0x4002B5B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image m_Redot;

	[Token(Token = "0x6004C5A")]
	[Address(RVA = "0x61A540", Offset = "0x618D40", Length = "0x10F")]
	public override void UpdateRedotState()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004C5B")]
	public RolePreviewNavigationRedot()
	{
	}
}
