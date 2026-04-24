using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectControl.MutiGirlController;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000731")]
public class MultiGirlData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40025D0")]
	public GameObject girlObj;

	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x18")]
	public SpineActionController spineActionCtrl;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40025D2")]
	public Animator charAnimator;

	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x28")]
	public RoleBattleSubControl roleSubCtrl;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40025D4")]
	public MultiGirlActionController charaSpineCtrl;

	[Token(Token = "0x60042E4")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MultiGirlData()
	{
	}
}
