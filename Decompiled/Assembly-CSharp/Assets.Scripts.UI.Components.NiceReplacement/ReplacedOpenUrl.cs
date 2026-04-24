using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008BE")]
public class ReplacedOpenUrl : MonoBehaviour, IPlayable
{
	[SerializeField]
	[Token(Token = "0x4002D9A")]
	[FieldOffset(Offset = "0x18")]
	private string m_Url;

	[Token(Token = "0x6004EE1")]
	[Address(RVA = "0x5B2F40", Offset = "0x5B1740", Length = "0xB")]
	public void Execute()
	{
	}

	[Address(RVA = "0x5B2F50", Offset = "0x5B1750", Length = "0x46")]
	[Token(Token = "0x6004EE2")]
	public ReplacedOpenUrl()
	{
	}
}
