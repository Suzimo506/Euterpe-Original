using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D7")]
public class PnlMenu : MonoBehaviour
{
	[Token(Token = "0x4002E35")]
	[FieldOffset(Offset = "0x18")]
	public Button backBtn;

	[Token(Token = "0x4002E36")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator m_MenuAnimator;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002E37")]
	private Animator m_RoleAnimator;

	[Token(Token = "0x4002E38")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator m_ElfinAnimator;

	[SerializeField]
	[Token(Token = "0x4002E39")]
	[FieldOffset(Offset = "0x38")]
	private Animator m_TroveAnimator;

	[Token(Token = "0x4002E3A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator m_OptionAnimator;

	[SerializeField]
	[Token(Token = "0x4002E3B")]
	[FieldOffset(Offset = "0x48")]
	private Animator m_AchvAnimator;

	[SerializeField]
	[Token(Token = "0x4002E3C")]
	[FieldOffset(Offset = "0x50")]
	private Animator m_Achv43Animator;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002E3D")]
	[SerializeField]
	private MenuSelect m_MenuSelect;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002E3E")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x1700089C")]
	public MenuSelect menuSelect
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6004FB7")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x67AC00", Offset = "0x679400", Length = "0xE8")]
	[Token(Token = "0x6004FB8")]
	private void Awake()
	{
	}

	[Address(RVA = "0x67B000", Offset = "0x679800", Length = "0x9D")]
	[Token(Token = "0x6004FB9")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x67AFD0", Offset = "0x6797D0", Length = "0x2E")]
	[Token(Token = "0x6004FBA")]
	public void OnClick()
	{
	}

	[Token(Token = "0x6004FBB")]
	[Address(RVA = "0x67B0A0", Offset = "0x6798A0", Length = "0x20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004FBC")]
	[Address(RVA = "0x67ACF0", Offset = "0x6794F0", Length = "0x2D0")]
	private void OnBackClicked()
	{
	}

	[Token(Token = "0x6004FBD")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlMenu()
	{
	}
}
