using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008CC")]
public class JustAsPlannedDiscountTips : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002DDD")]
	[SerializeField]
	private GameObject m_ImgDiscountTips;

	[Token(Token = "0x6004F49")]
	[Address(RVA = "0x6C1E90", Offset = "0x6C0690", Length = "0x133")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004F4A")]
	[Address(RVA = "0x6C1D20", Offset = "0x6C0520", Length = "0x164")]
	private void CheckJustAsPlannedDiscount(DateTime callBackTime)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004F4B")]
	public JustAsPlannedDiscountTips()
	{
	}
}
