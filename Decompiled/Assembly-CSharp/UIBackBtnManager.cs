using System.Collections;
using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001AA")]
public class UIBackBtnManager : SerializedMonoBehaviour
{
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x58")]
	public Button btnBackToQuit;

	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x60")]
	public Button btnBackToWelcome;

	[Token(Token = "0x4000A61")]
	[FieldOffset(Offset = "0x68")]
	public Button btnBackToHome;

	[Token(Token = "0x4000A62")]
	[FieldOffset(Offset = "0x70")]
	public Button btnBackToStage;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A63")]
	public AudioClip clickSfx;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A64")]
	public Popup pnlQuitGameAsk;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A65")]
	public GameObject pnlHome;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A66")]
	public GameObject pnlStage;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A67")]
	public GameObject pnlPreparation;

	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x4E4FD0", Offset = "0x4E37D0", Length = "0x172")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4E5150", Offset = "0x4E3950", Length = "0x1E")]
	[Token(Token = "0x6000BFF")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4E5260", Offset = "0x4E3A60", Length = "0x1E")]
	[Token(Token = "0x6000C00")]
	private void OnQuitClicked()
	{
	}

	[Token(Token = "0x6000C01")]
	[Address(RVA = "0x4E5170", Offset = "0x4E3970", Length = "0xE6")]
	private void OnHomeClicked()
	{
	}

	[Address(RVA = "0x4E5280", Offset = "0x4E3A80", Length = "0x1A0")]
	[Token(Token = "0x6000C02")]
	private void OnStageClicked()
	{
	}

	[Token(Token = "0x6000C03")]
	[Address(RVA = "0x4E5430", Offset = "0x4E3C30", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x47520", Offset = "0x46920")]
	private IEnumerator StageClicked()
	{
		return null;
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6000C04")]
	public UIBackBtnManager()
	{
	}
}
