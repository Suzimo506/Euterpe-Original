using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Attribute(Name = "RequireComponent", RVA = "0x9FC70", Offset = "0x9F070")]
[Token(Token = "0x200076B")]
public class ComboVisibleController : MonoBehaviour
{
	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x18")]
	private CanvasGroup m_CanvasGroup;

	[Address(RVA = "0x49C3E0", Offset = "0x49ABE0", Length = "0xC7")]
	[Token(Token = "0x600459D")]
	private void Awake()
	{
	}

	[Address(RVA = "0x49C4B0", Offset = "0x49ACB0", Length = "0x28")]
	[Token(Token = "0x600459E")]
	private void OnComboShowOrHide(bool isShow)
	{
	}

	[Address(RVA = "0x49C4E0", Offset = "0x49ACE0", Length = "0xA9")]
	[Token(Token = "0x600459F")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60045A0")]
	public ComboVisibleController()
	{
	}
}
