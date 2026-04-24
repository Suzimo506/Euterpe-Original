using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E5")]
public class FollowUsSelect : UISelectManage
{
	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x118")]
	public Transform buttons;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005B5")]
	private List<Button> m_Buttons;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40005B6")]
	public AudioClip optionBgmClip;

	[Address(RVA = "0x44E550", Offset = "0x44CD50", Length = "0x9D")]
	[Token(Token = "0x60006A5")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x44E5F0", Offset = "0x44CDF0", Length = "0x110")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x44E770", Offset = "0x44CF70", Length = "0xED")]
	[Token(Token = "0x60006A7")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x44E710", Offset = "0x44CF10", Length = "0x54")]
	[Token(Token = "0x60006A8")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x44E480", Offset = "0x44CC80", Length = "0xCF")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x44E860", Offset = "0x44D060", Length = "0x6C")]
	[Token(Token = "0x60006AA")]
	public FollowUsSelect()
	{
	}
}
