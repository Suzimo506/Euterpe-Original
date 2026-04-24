using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000173")]
public class ChangeFeverValue : MonoBehaviour
{
	[Token(Token = "0x4000936")]
	[FieldOffset(Offset = "0x18")]
	protected Text m_Text;

	[Token(Token = "0x4000937")]
	[FieldOffset(Offset = "0x20")]
	protected Slider m_Slider;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000938")]
	public Animator feverAnim;

	[Address(RVA = "0x463360", Offset = "0x461B60", Length = "0x24D")]
	[Token(Token = "0x6000AA9")]
	protected virtual void EventsRegister()
	{
	}

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x4635B0", Offset = "0x461DB0", Length = "0x24D")]
	protected virtual void EventsUnregister()
	{
	}

	[Address(RVA = "0x4639A0", Offset = "0x4621A0", Length = "0xC6")]
	[Token(Token = "0x6000AAB")]
	protected virtual void OnFeverRateChange()
	{
	}

	[Address(RVA = "0x463B20", Offset = "0x462320", Length = "0xDC")]
	[Token(Token = "0x6000AAC")]
	protected virtual void OnFever()
	{
	}

	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x4638E0", Offset = "0x4620E0", Length = "0xB5")]
	protected virtual void OnFeverMax()
	{
	}

	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x463820", Offset = "0x462020", Length = "0xB5")]
	protected virtual void OnFeverFail()
	{
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x463A70", Offset = "0x462270", Length = "0xAD")]
	protected virtual void OnFeverReduce(int reduceValue)
	{
	}

	[Address(RVA = "0x4632E0", Offset = "0x461AE0", Length = "0x78")]
	[Token(Token = "0x6000AB0")]
	private void Awake()
	{
	}

	[Address(RVA = "0x463800", Offset = "0x462000", Length = "0x11")]
	[Token(Token = "0x6000AB1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x463C00", Offset = "0x462400", Length = "0x19A")]
	private void RefreshFeverEnergy(float feverNormalize = 0f)
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ChangeFeverValue()
	{
	}
}
