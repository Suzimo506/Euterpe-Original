using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000DD")]
public class CheckWelcome : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x18")]
	private Button m_NoButton;

	[SerializeField]
	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x20")]
	private Action m_DoClose;

	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x28")]
	public Image mask;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000589")]
	public GameObject welcome;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400058A")]
	private CanvasScaler uiCanvas;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x40")]
	private List<Tweener> m_Twners;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400058C")]
	private Vector3 m_OriginPos;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_CurrentWelcome;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x60")]
	private float m_MatchWidthOrHeight;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x68")]
	private GameObject[] m_WelcomeGameObjects;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000590")]
	private GameObject m_CurrentWelcomeObj;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x78")]
	private Action m_ShowCallBack;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000592")]
	private PnlGraphicSpWelcomeSetting m_SpWelcomeSetting;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x88")]
	private List<int> m_SpeiciaWelcomeIndex;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000594")]
	private float m_AdaptationScale;

	[Address(RVA = "0x466380", Offset = "0x464B80", Length = "0x37B")]
	[Token(Token = "0x6000658")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x4675E0", Offset = "0x465DE0", Length = "0xF0")]
	private void RefreshCurAdaptationScale()
	{
	}

	[Address(RVA = "0x466700", Offset = "0x464F00", Length = "0xB6")]
	[Token(Token = "0x600065A")]
	public void CloseSelf()
	{
	}

	[Address(RVA = "0x466FB0", Offset = "0x4657B0", Length = "0x34")]
	[Token(Token = "0x600065B")]
	private void OnCytusTrigger()
	{
	}

	[Address(RVA = "0x466E90", Offset = "0x465690", Length = "0x11D")]
	[Token(Token = "0x600065C")]
	private void OnCytusHiddenClose()
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x466FF0", Offset = "0x4657F0", Length = "0x191")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x467C60", Offset = "0x466460", Length = "0xD2")]
	[Token(Token = "0x600065E")]
	public void Show(Action showCallBack = null)
	{
	}

	[Address(RVA = "0x466AD0", Offset = "0x4652D0", Length = "0x285")]
	[Token(Token = "0x600065F")]
	private void InstanceWelcome()
	{
	}

	[Address(RVA = "0x4676D0", Offset = "0x465ED0", Length = "0x58A")]
	[Token(Token = "0x6000660")]
	public void ResetWelcome(bool isShow = false)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x4669E0", Offset = "0x4651E0", Length = "0xE8")]
	private int GetWelcomeIndex()
	{
		return default(int);
	}

	[Address(RVA = "0x467190", Offset = "0x465990", Length = "0x449")]
	[Token(Token = "0x6000662")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x466D60", Offset = "0x465560", Length = "0x121")]
	[Token(Token = "0x6000663")]
	private void KillAllTwns()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x4667C0", Offset = "0x464FC0", Length = "0x163")]
	private void DisableAllWelcome()
	{
	}

	[Address(RVA = "0x466930", Offset = "0x465130", Length = "0xA5")]
	[Token(Token = "0x6000665")]
	private void DisableWelcome()
	{
	}

	[Address(RVA = "0x467F40", Offset = "0x466740", Length = "0x6C")]
	[Token(Token = "0x6000666")]
	public CheckWelcome()
	{
	}
}
