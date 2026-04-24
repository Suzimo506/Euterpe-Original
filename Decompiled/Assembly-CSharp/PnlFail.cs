using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000B5")]
public class PnlFail : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40004AB")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_FailBg;

	[Token(Token = "0x40004AC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioClip m_FailMusic;

	[Token(Token = "0x40004AD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button m_Return;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004AE")]
	[SerializeField]
	private Button m_Restart;

	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x38")]
	private float m_PrevVolume;

	[Address(RVA = "0x503C70", Offset = "0x502470", Length = "0xD4")]
	[Token(Token = "0x6000552")]
	private void Awake()
	{
	}

	[Address(RVA = "0x504670", Offset = "0x502E70", Length = "0x4F")]
	[Token(Token = "0x6000553")]
	private void OnReturnClicked()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x504620", Offset = "0x502E20", Length = "0x4F")]
	private void OnRestartClicked()
	{
	}

	[Address(RVA = "0x504050", Offset = "0x502850", Length = "0x359")]
	[Token(Token = "0x6000555")]
	public void Fail()
	{
	}

	[Address(RVA = "0x503D50", Offset = "0x502550", Length = "0xE8")]
	[Token(Token = "0x6000556")]
	private void CheckForceUpdateAction()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x503E40", Offset = "0x502640", Length = "0x19F")]
	private void CheckMusicIsTimeout()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x5045B0", Offset = "0x502DB0", Length = "0x6B")]
	public void OnlyShowFailPanel()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x5045B0", Offset = "0x502DB0", Length = "0x6B")]
	private void OnFadeOutComplete()
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x5043B0", Offset = "0x502BB0", Length = "0x1F2")]
	private void OnEnable()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x9B300", Offset = "0x9A700")]
	[Address(RVA = "0x503FE0", Offset = "0x5027E0", Length = "0x6B")]
	[Token(Token = "0x600055B")]
	private IEnumerator DelaySetRestartBtnInteractable()
	{
		return null;
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlFail()
	{
	}
}
