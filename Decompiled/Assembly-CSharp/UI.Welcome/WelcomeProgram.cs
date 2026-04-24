using System.Collections;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Welcome;

[Token(Token = "0x20001B3")]
public class WelcomeProgram : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A85")]
	public GameObject pnlWelcome;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A86")]
	public GameObject pnlHeadsetTip;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A87")]
	public GameObject pnlPeroPeroGames;

	[Token(Token = "0x4000A88")]
	[FieldOffset(Offset = "0x30")]
	public GameObject pnlLaunch;

	[Token(Token = "0x4000A89")]
	[FieldOffset(Offset = "0x38")]
	public GameObject hasuHasuAnimLogo;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A8A")]
	public GameObject pnlWarning;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A8B")]
	public GameObject imgXDLogo;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A8C")]
	public Image imgBlackBoard;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A8D")]
	public GameObject agreementCanvas;

	[Token(Token = "0x4000A8E")]
	[FieldOffset(Offset = "0x60")]
	public GameObject mainMgr;

	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x68")]
	private bool m_ShowXD;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x70")]
	private VoiceSetting.Voice hasuLogoVoices;

	[Address(RVA = "0x4EDEB0", Offset = "0x4EC6B0", Length = "0x139")]
	[Token(Token = "0x6000C27")]
	private void Start()
	{
	}

	[Address(RVA = "0x4EDFF0", Offset = "0x4EC7F0", Length = "0x65")]
	[Token(Token = "0x6000C28")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x49550", Offset = "0x48950")]
	private IEnumerator Welcome()
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000C29")]
	public WelcomeProgram()
	{
	}
}
