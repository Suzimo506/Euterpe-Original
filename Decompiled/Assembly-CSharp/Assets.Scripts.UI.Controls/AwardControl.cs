using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B8")]
public class AwardControl : DirtyNode
{
	[Token(Token = "0x4002D83")]
	[FieldOffset(Offset = "0x20")]
	public PnlLevelUpAward pnlLevelUpAward;

	[Token(Token = "0x4002D84")]
	[FieldOffset(Offset = "0x28")]
	private List<AwardInfo> m_Rewards;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D85")]
	private Transform m_TargetTrans;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002D86")]
	private List<AwardItem> listAwardItem;

	[Token(Token = "0x6004ED0")]
	[Address(RVA = "0x5A6CB0", Offset = "0x5A54B0", Length = "0x14A")]
	public override void Show(params object[] param)
	{
	}

	[Token(Token = "0x6004ED1")]
	[Address(RVA = "0x5A6A20", Offset = "0x5A5220", Length = "0x28A")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6004ED2")]
	[Address(RVA = "0x5A6770", Offset = "0x5A4F70", Length = "0x2AD")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004ED3")]
	[Address(RVA = "0x5A6E00", Offset = "0x5A5600", Length = "0x96")]
	public AwardControl()
	{
	}
}
