using System.Collections.Generic;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000921")]
public class DiverDlcControl : MonoBehaviour
{
	[Token(Token = "0x400312C")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private List<GameObject> m_ObjList;

	[Token(Token = "0x400312D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SkeletonAnimation m_LogoSpine;

	[SerializeField]
	[Token(Token = "0x400312E")]
	[FieldOffset(Offset = "0x28")]
	private Button m_BtnPhone;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400312F")]
	private bool isSelected;

	[Token(Token = "0x60052D4")]
	[Address(RVA = "0x429FD0", Offset = "0x4287D0", Length = "0x25E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x42A370", Offset = "0x428B70", Length = "0x12D")]
	[Token(Token = "0x60052D5")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60052D6")]
	[Address(RVA = "0x42A230", Offset = "0x428A30", Length = "0x135")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60052D7")]
	[Address(RVA = "0x42A4A0", Offset = "0x428CA0", Length = "0x5F")]
	private void OnPhoneClick()
	{
	}

	[Address(RVA = "0x429E10", Offset = "0x428610", Length = "0xD0")]
	[Token(Token = "0x60052D8")]
	private void ActiveOnFinalSelected(int index)
	{
	}

	[Token(Token = "0x60052D9")]
	[Address(RVA = "0x429EF0", Offset = "0x4286F0", Length = "0xD0")]
	private void ActiveOnSelected(int index)
	{
	}

	[Token(Token = "0x60052DA")]
	[Address(RVA = "0x42A500", Offset = "0x428D00", Length = "0xC5")]
	private void SetObjActive(bool value)
	{
	}

	[Token(Token = "0x60052DB")]
	[Address(RVA = "0x42A5D0", Offset = "0x428DD0", Length = "0xB")]
	public DiverDlcControl()
	{
	}
}
