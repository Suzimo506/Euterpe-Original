using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;

[Token(Token = "0x2000489")]
public class FoolActivityUIManager
{
	[Token(Token = "0x400188A")]
	private const string texture_root = "Below/ImgFoolAct";

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400188B")]
	private Image m_ImgBarRole;

	[Address(RVA = "0x8F7180", Offset = "0x8F5980", Length = "0x28B")]
	[Token(Token = "0x60033E5")]
	public void InitCharacterTex()
	{
	}

	[Address(RVA = "0x8F7040", Offset = "0x8F5840", Length = "0x13B")]
	[Token(Token = "0x60033E6")]
	public bool GetFoolActCharacterTex(out Sprite charTex)
	{
		charTex = null;
		return default(bool);
	}

	[Address(RVA = "0x8F7410", Offset = "0x8F5C10", Length = "0x54")]
	[Token(Token = "0x60033E7")]
	public void ShowCharacterOnStateBar(PnlBattleComps comps)
	{
	}

	[Token(Token = "0x60033E8")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FoolActivityUIManager()
	{
	}
}
