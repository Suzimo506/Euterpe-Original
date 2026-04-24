using System.Collections.Generic;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E6")]
public class WelcomeSelect : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x18")]
	public GameObject welcome;

	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x20")]
	public CanvasScaler uiCanvas;

	[Token(Token = "0x4002F45")]
	[FieldOffset(Offset = "0x28")]
	private int m_WelcomeIndex;

	[Token(Token = "0x4002F46")]
	[FieldOffset(Offset = "0x30")]
	public PnlMandatoryUpdate pnlMandatory;

	[Token(Token = "0x4002F47")]
	[FieldOffset(Offset = "0x38")]
	public Button btnLogin;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002F48")]
	private GameObject m_NewVersionTip;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4002F49")]
	private Text m_TxtWelcomeUI;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002F4A")]
	[SerializeField]
	private Outline m_OutlineWelcomeUI;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002F4B")]
	[SerializeField]
	private List<WelcomeUIForm> m_WelcomeUIFormList;

	[Address(RVA = "0x4D47F0", Offset = "0x4D2FF0", Length = "0x180")]
	[Token(Token = "0x60050A8")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x4D4E50", Offset = "0x4D3650", Length = "0xA8")]
	[Token(Token = "0x60050A9")]
	private void Start()
	{
	}

	[Address(RVA = "0x4D4A60", Offset = "0x4D3260", Length = "0x3EB")]
	[Token(Token = "0x60050AA")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x4D46F0", Offset = "0x4D2EF0", Length = "0xF4")]
	[Token(Token = "0x60050AB")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4D4980", Offset = "0x4D3180", Length = "0xDC")]
	[Token(Token = "0x60050AC")]
	private void OnGetRecommendVersion(bool isRecommendVersionReleased)
	{
	}

	[Address(RVA = "0x4D44C0", Offset = "0x4D2CC0", Length = "0x22A")]
	[Token(Token = "0x60050AD")]
	private void AdjustWelcomeUI()
	{
	}

	[Token(Token = "0x60050AE")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public WelcomeSelect()
	{
	}
}
