using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot.RoleSelectRedot;

[Token(Token = "0x2000857")]
public class RolePreviewsEntryRedot : AbstractRedotComponent
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002B5D")]
	[SerializeField]
	private Image m_ImgRedot;

	[Token(Token = "0x6004C5E")]
	[Address(RVA = "0x61A750", Offset = "0x618F50", Length = "0xC4")]
	public override void UpdateRedotState()
	{
	}

	[Token(Token = "0x6004C5F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RolePreviewsEntryRedot()
	{
	}
}
