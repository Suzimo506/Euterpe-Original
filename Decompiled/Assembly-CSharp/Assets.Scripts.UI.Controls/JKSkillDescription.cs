using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008AB")]
public class JKSkillDescription : MonoBehaviour, IPreWarm
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D5A")]
	private Text m_Text;

	[Address(RVA = "0x5B0AF0", Offset = "0x5AF2F0", Length = "0x3C5")]
	[Token(Token = "0x6004E8E")]
	public void SetText()
	{
	}

	[Address(RVA = "0x5B0AA0", Offset = "0x5AF2A0", Length = "0x47")]
	[Token(Token = "0x6004E8F")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004E90")]
	public JKSkillDescription()
	{
	}
}
