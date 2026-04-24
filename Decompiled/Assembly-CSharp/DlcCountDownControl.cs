using Assets.Scripts.Database;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000107")]
public class DlcCountDownControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067D")]
	public Color arkKnightColor;

	[SerializeField]
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_CountDownBaseTransform;

	[Token(Token = "0x400067F")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private DlcType m_CountDlcType;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Text m_CountDownTitleText;

	[SerializeField]
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x40")]
	private Image m_BgImage;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image m_CountDownTitleImage;

	[Token(Token = "0x4000683")]
	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	private Text m_CountDownText;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000684")]
	private DLCInfoActiveTime m_ActiveTime;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000685")]
	private int m_JsonIndex;

	[Address(RVA = "0x442350", Offset = "0x440B50", Length = "0x4D2")]
	[Token(Token = "0x60007B4")]
	public void Init(DlcUIExtensionInfo dlcUIExtensionInfo)
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x442830", Offset = "0x441030", Length = "0xF4")]
	private void ResetCountDown()
	{
	}

	[Address(RVA = "0x442320", Offset = "0x440B20", Length = "0x2F")]
	[Token(Token = "0x60007B6")]
	private void DisableCountDown()
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x442930", Offset = "0x441130", Length = "0xC4")]
	private void SetCountDownPadding(Vector2 padding)
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x4421F0", Offset = "0x4409F0", Length = "0x121")]
	private DLCInfoActiveTime CreateDlcCountdown(int jsonIndex, GameObject parent)
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60007B9")]
	public DlcCountDownControl()
	{
	}
}
