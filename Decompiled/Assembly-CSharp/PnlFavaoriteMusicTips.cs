using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200018D")]
public class PnlFavaoriteMusicTips : BaseMessageBox
{
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_TipsFsv;

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0x79F8B0", Offset = "0x79E0B0", Length = "0x32")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0x79F8F0", Offset = "0x79E0F0", Length = "0x71")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlFavaoriteMusicTips()
	{
	}
}
