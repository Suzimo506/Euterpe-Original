using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200015B")]
public class SelectToChangeState : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400088B")]
	private bool m_DisableSelectShowOnMobile;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400088C")]
	[SerializeField]
	private Graphic[] m_Graphics;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400088D")]
	private InputKeyBinding[] m_KeyBindings;

	[Token(Token = "0x400088E")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_ObjsSelectedShow;

	[SerializeField]
	[Token(Token = "0x400088F")]
	[FieldOffset(Offset = "0x38")]
	private SelectToChangeState[] m_SelectStatesChildren;

	[Token(Token = "0x4000890")]
	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	private Color m_ColorSelected;

	[SerializeField]
	[Token(Token = "0x4000891")]
	[FieldOffset(Offset = "0x50")]
	private Color m_ColorNotSelected;

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x62C640", Offset = "0x62AE40", Length = "0x1AB")]
	public void SetSelected(bool isSelected)
	{
	}

	[Address(RVA = "0x62C510", Offset = "0x62AD10", Length = "0x125")]
	[Token(Token = "0x60009F3")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60009F4")]
	public SelectToChangeState()
	{
	}
}
