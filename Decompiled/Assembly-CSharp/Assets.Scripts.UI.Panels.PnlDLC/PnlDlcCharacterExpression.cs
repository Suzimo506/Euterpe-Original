using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200093B")]
public class PnlDlcCharacterExpression : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40031E2")]
	[SerializeField]
	private Button m_Btn;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40031E3")]
	[SerializeField]
	private Text m_Text;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40031E4")]
	private Animator m_BubbleAnimator;

	[Token(Token = "0x40031E5")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsFinishAnim;

	[Token(Token = "0x40031E6")]
	[FieldOffset(Offset = "0x34")]
	private float m_BubbleOutTime;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40031E7")]
	private Coroutine m_EndCoroutine;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40031E8")]
	private CoroutineManager m_CoroutineManager;

	[Token(Token = "0x40031E9")]
	[FieldOffset(Offset = "0x48")]
	private DlcCharSubControl m_Parent;

	[Token(Token = "0x40031EA")]
	[FieldOffset(Offset = "0x50")]
	private int m_JsonIndex;

	[Token(Token = "0x40031EB")]
	[FieldOffset(Offset = "0x58")]
	private ExpressionContainer m_Expressions;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40031EC")]
	private bool m_LanguageDirty;

	[Address(RVA = "0x824440", Offset = "0x822C40", Length = "0xBA")]
	[Token(Token = "0x60053D2")]
	public void Init(DlcCharSubControl parent)
	{
	}

	[Token(Token = "0x60053D3")]
	[Address(RVA = "0x6572A0", Offset = "0x655AA0", Length = "0x5")]
	private void SetDirty(int languageIndex)
	{
	}

	[Address(RVA = "0x824140", Offset = "0x822940", Length = "0xC1")]
	[Token(Token = "0x60053D4")]
	private void Awake()
	{
	}

	[Address(RVA = "0x8245B0", Offset = "0x822DB0", Length = "0x35")]
	[Token(Token = "0x60053D5")]
	private void OnMuseShowClicked()
	{
	}

	[Address(RVA = "0x8245B0", Offset = "0x822DB0", Length = "0x35")]
	[Token(Token = "0x60053D6")]
	private void RandomExpress()
	{
	}

	[Token(Token = "0x60053D7")]
	[Address(RVA = "0x824210", Offset = "0x822A10", Length = "0x190")]
	private void Express(Expression expression, int soundIndex = -1)
	{
	}

	[Address(RVA = "0x8247E0", Offset = "0x822FE0", Length = "0x10")]
	[Token(Token = "0x60053D8")]
	public void Refresh(int jsonIndex)
	{
	}

	[Token(Token = "0x60053D9")]
	[Address(RVA = "0x8246C0", Offset = "0x822EC0", Length = "0x118")]
	private void RefreshExpressions()
	{
	}

	[Address(RVA = "0x824580", Offset = "0x822D80", Length = "0x2F")]
	[Token(Token = "0x60053DA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60053DB")]
	[Address(RVA = "0x8243B0", Offset = "0x822BB0", Length = "0x8E")]
	private void ForceFinishAnim()
	{
	}

	[Address(RVA = "0x824500", Offset = "0x822D00", Length = "0x7D")]
	[Token(Token = "0x60053DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60053DD")]
	[Address(RVA = "0x8245F0", Offset = "0x822DF0", Length = "0xC2")]
	private void PlayEndCallback()
	{
	}

	[Token(Token = "0x60053DE")]
	[Address(RVA = "0x8247F0", Offset = "0x822FF0", Length = "0x64")]
	public PnlDlcCharacterExpression()
	{
	}
}
