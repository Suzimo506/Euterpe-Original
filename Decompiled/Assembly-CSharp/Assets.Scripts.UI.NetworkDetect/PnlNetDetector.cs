using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.NetworkDetect;

[Token(Token = "0x200087C")]
public class PnlNetDetector : MonoBehaviour
{
	[Token(Token = "0x4002C46")]
	[FieldOffset(Offset = "0x18")]
	private Popup m_Popup;

	[Token(Token = "0x4002C47")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsPoping;

	[Token(Token = "0x4002C48")]
	[FieldOffset(Offset = "0x28")]
	private string m_CurrSceneName;

	[Token(Token = "0x4002C49")]
	private const string m_SceneName = "GameMain";

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002C4A")]
	private int m_DelayFrame;

	[Token(Token = "0x1700086E")]
	private bool isAdult
	{
		[Address(RVA = "0x6CDAB0", Offset = "0x6CC2B0", Length = "0xAA")]
		[Token(Token = "0x6004D50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004D51")]
	[Address(RVA = "0x6CD870", Offset = "0x6CC070", Length = "0xF9")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D52")]
	[Address(RVA = "0x6CD970", Offset = "0x6CC170", Length = "0x122")]
	private void Update()
	{
	}

	[Token(Token = "0x6004D53")]
	[Address(RVA = "0x6CDAA0", Offset = "0x6CC2A0", Length = "0xE")]
	public PnlNetDetector()
	{
	}
}
