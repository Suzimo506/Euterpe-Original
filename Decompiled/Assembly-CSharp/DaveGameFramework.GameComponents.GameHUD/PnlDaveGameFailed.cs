using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace DaveGameFramework.GameComponents.GameHUD;

[Token(Token = "0x20004CE")]
public class PnlDaveGameFailed : MonoBehaviour
{
	[Token(Token = "0x4001A26")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private AudioClip m_FailMusic;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A27")]
	[SerializeField]
	private Button m_Return;

	[SerializeField]
	[Token(Token = "0x4001A28")]
	[FieldOffset(Offset = "0x28")]
	private Button m_Restart;

	[Token(Token = "0x4001A29")]
	[FieldOffset(Offset = "0x30")]
	private float m_PrevVolume;

	[Token(Token = "0x4001A2A")]
	[FieldOffset(Offset = "0x38")]
	private DaveGameManager m_DaveGameManager;

	[Address(RVA = "0x9A0FD0", Offset = "0x99F7D0", Length = "0x46")]
	[Token(Token = "0x60035CA")]
	public void Init()
	{
	}

	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x9A1210", Offset = "0x99FA10", Length = "0x327")]
	public void Show()
	{
	}

	[Token(Token = "0x60035CC")]
	[Address(RVA = "0x9A0F60", Offset = "0x99F760", Length = "0x65")]
	private void Hide()
	{
	}

	[Address(RVA = "0x9A0E30", Offset = "0x99F630", Length = "0xD4")]
	[Token(Token = "0x60035CD")]
	private void Awake()
	{
	}

	[Token(Token = "0x60035CE")]
	[Address(RVA = "0x9A1180", Offset = "0x99F980", Length = "0x89")]
	private void OnReturnClicked()
	{
	}

	[Token(Token = "0x60035CF")]
	[Address(RVA = "0x9A1090", Offset = "0x99F890", Length = "0xE5")]
	private void OnRestartClicked()
	{
	}

	[Token(Token = "0x60035D0")]
	[Address(RVA = "0x9A1020", Offset = "0x99F820", Length = "0x6B")]
	private void OnFadeOutComplete()
	{
	}

	[Address(RVA = "0x9A0F10", Offset = "0x99F710", Length = "0x4A")]
	[Token(Token = "0x60035D1")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x5D990", Offset = "0x5CD90")]
	private IEnumerator DelaySetRestartBtnInteractable()
	{
		return null;
	}

	[Token(Token = "0x60035D2")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDaveGameFailed()
	{
	}
}
