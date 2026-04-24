using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000177")]
public class CytusWelcomeHideBMS : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400094E")]
	public Button btnOnPlayAnim;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094F")]
	private AudioSource m_AudioSource;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000950")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000951")]
	private bool isOnHideSong;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000952")]
	private float m_DelayTime;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x38")]
	private float m_AudioVolume;

	[Address(RVA = "0x46B320", Offset = "0x469B20", Length = "0x15C")]
	[Token(Token = "0x6000ACB")]
	private void Start()
	{
	}

	[Address(RVA = "0x46ADD0", Offset = "0x4695D0", Length = "0xAB")]
	[Token(Token = "0x6000ACC")]
	private void Init()
	{
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x46AEE0", Offset = "0x4696E0", Length = "0x313")]
	private void OnMobileClicked()
	{
	}

	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x46B200", Offset = "0x469A00", Length = "0x11D")]
	private void ShowEgg(float waitTime)
	{
	}

	[Address(RVA = "0x46AD00", Offset = "0x469500", Length = "0xCD")]
	[Token(Token = "0x6000ACF")]
	public void FUCK_START()
	{
	}

	[Address(RVA = "0x46AC60", Offset = "0x469460", Length = "0x97")]
	[Token(Token = "0x6000AD0")]
	public void FUCK_END()
	{
	}

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x46AE80", Offset = "0x469680", Length = "0x55")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x46B480", Offset = "0x469C80", Length = "0xE")]
	[Token(Token = "0x6000AD2")]
	public CytusWelcomeHideBMS()
	{
	}
}
