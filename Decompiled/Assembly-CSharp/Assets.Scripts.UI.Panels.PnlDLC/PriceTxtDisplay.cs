using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000946")]
internal class PriceTxtDisplay : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4003260")]
	private int m_JsonIndex;

	[Token(Token = "0x4003261")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_PriceGo;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003262")]
	private Text m_PriceText;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4003263")]
	private GameObject m_PriceDiscountGo;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003264")]
	public GameObject countDown;

	[SerializeField]
	[Token(Token = "0x4003265")]
	[FieldOffset(Offset = "0x40")]
	private Text m_PriceDiscountText;

	[Token(Token = "0x4003266")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private DlcType m_DlcType;

	[SerializeField]
	[Token(Token = "0x4003267")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_DiscountImage20;

	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4003268")]
	private GameObject m_DiscountImage30;

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4003269")]
	private GameObject m_DiscountImage50;

	[SerializeField]
	[Token(Token = "0x400326A")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_DiscountImage100;

	[Token(Token = "0x400326B")]
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	private Text m_DiscountText;

	[SerializeField]
	[Token(Token = "0x400326C")]
	[FieldOffset(Offset = "0x78")]
	private Text m_DiscountCountDownText;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400326D")]
	[SerializeField]
	private GameObject m_ImgDiscountObj;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400326E")]
	[SerializeField]
	private Button m_BtnPurchase;

	[SerializeField]
	[Token(Token = "0x400326F")]
	[FieldOffset(Offset = "0x90")]
	private Button m_BtnRestore;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4003270")]
	[SerializeField]
	private Button m_BtnGroupQuestion;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4003271")]
	[SerializeField]
	private GameObject m_RestoreLayout;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4003272")]
	[SerializeField]
	private bool m_IsNeedHideRestoreItem;

	[Token(Token = "0x4003273")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Text m_TextRestore;

	[SerializeField]
	[Token(Token = "0x4003274")]
	[FieldOffset(Offset = "0xB8")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4003275")]
	private float m_InTime;

	[Token(Token = "0x4003276")]
	[FieldOffset(Offset = "0xC4")]
	private float m_OutTime;

	[Token(Token = "0x4003277")]
	[FieldOffset(Offset = "0xC8")]
	private Coroutine m_Coroutine;

	[Token(Token = "0x4003278")]
	private const string anim_in = "ButtonAreaIn";

	[Token(Token = "0x4003279")]
	private const string anim_out = "ButtonAreaOut";

	[Token(Token = "0x400327A")]
	public static readonly List<int> speacialAlbumIndexs;

	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x16C20", Offset = "0x16020")]
	[SerializeField]
	[Token(Token = "0x400327B")]
	private GameObject[] m_NavTips;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400327C")]
	[SerializeField]
	private bool isSpan;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C410", Offset = "0x9B810")]
	[Token(Token = "0x400327D")]
	[FieldOffset(Offset = "0xD9")]
	public bool isForbidPriceTextFontChange;

	[Token(Token = "0x400327E")]
	[FieldOffset(Offset = "0xE0")]
	private Font numberPriceFont;

	[Token(Token = "0x400327F")]
	[FieldOffset(Offset = "0xE8")]
	private readonly Vector2 timeCountPos;

	[Token(Token = "0x4003280")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_OnDiscount;

	[Token(Token = "0x4003281")]
	[FieldOffset(Offset = "0xF8")]
	private DateTime m_EndTime;

	[Token(Token = "0x4003282")]
	[FieldOffset(Offset = "0x100")]
	private UnityGameManager.Looper m_Looper;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4003283")]
	private Action m_OnCountDownCompleteCallback;

	[Token(Token = "0x4003284")]
	private const string m_PointRegex = "[0]+$";

	[Token(Token = "0x4003285")]
	private const string m_ThousandRegex = "^.?\\d{4,}\\.?";

	[Token(Token = "0x4003286")]
	private const string m_NumberRegex = "[\\d]+";

	[Token(Token = "0x170008D5")]
	public int jsonIndex
	{
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		[Token(Token = "0x6005447")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008D6")]
	public Button btnPurchase
	{
		[Address(RVA = "0x5C1450", Offset = "0x5BFC50", Length = "0x8")]
		[Token(Token = "0x6005448")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008D7")]
	public Button btnRestore
	{
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		[Token(Token = "0x6005449")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x832F60", Offset = "0x831760", Length = "0xDC")]
	[Token(Token = "0x600544A")]
	private void Start()
	{
	}

	[Token(Token = "0x600544B")]
	[Address(RVA = "0x832830", Offset = "0x831030", Length = "0x160")]
	private void Awake()
	{
	}

	[Address(RVA = "0x833040", Offset = "0x831840", Length = "0x6D")]
	[Token(Token = "0x600544C")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x832F60", Offset = "0x831760", Length = "0xDC")]
	[Token(Token = "0x600544D")]
	private void InitNavTips()
	{
	}

	[Address(RVA = "0x8330B0", Offset = "0x8318B0", Length = "0x51")]
	[Token(Token = "0x600544E")]
	private void Stop()
	{
	}

	[Token(Token = "0x600544F")]
	[Address(RVA = "0x833EE0", Offset = "0x8326E0", Length = "0x1BD")]
	public void Show(Action callback = null)
	{
	}

	[Address(RVA = "0x832DA0", Offset = "0x8315A0", Length = "0x1B2")]
	[Token(Token = "0x6005450")]
	public void Hide(Action callback = null)
	{
	}

	[Address(RVA = "0x8340A0", Offset = "0x8328A0", Length = "0x2AF")]
	[Token(Token = "0x6005451")]
	private void SwitchDisplay(bool discount, bool showTimeCount = true)
	{
	}

	[Address(RVA = "0x8329A0", Offset = "0x8311A0", Length = "0x8C")]
	[Token(Token = "0x6005452")]
	public void CheckGroupQuestionButton(string curProductUid)
	{
	}

	[Address(RVA = "0x833CC0", Offset = "0x8324C0", Length = "0x212")]
	[Token(Token = "0x6005453")]
	private void SetPrice(string price, int discount = 0, bool showTimeCount = true)
	{
	}

	[Address(RVA = "0x833660", Offset = "0x831E60", Length = "0x1CF")]
	[Token(Token = "0x6005454")]
	private void SetDiscount(int discount)
	{
	}

	[Token(Token = "0x6005455")]
	[Address(RVA = "0x833830", Offset = "0x832030", Length = "0x108")]
	private void SetImageTypeDiscount(int discount)
	{
	}

	[Token(Token = "0x6005456")]
	[Address(RVA = "0x833350", Offset = "0x831B50", Length = "0x1A7")]
	public void SetCountDown(TimeSpan remain)
	{
	}

	[Token(Token = "0x6005457")]
	[Address(RVA = "0x832A30", Offset = "0x831230", Length = "0x79")]
	public void Clean()
	{
	}

	[Token(Token = "0x6005458")]
	[Address(RVA = "0x834350", Offset = "0x832B50", Length = "0x2AC")]
	private void UpdateDisplay(float _)
	{
	}

	[Token(Token = "0x6005459")]
	[Address(RVA = "0x833940", Offset = "0x832140", Length = "0x33")]
	public void SetNoDiscountPrice(string price)
	{
	}

	[Token(Token = "0x600545A")]
	[Address(RVA = "0x833110", Offset = "0x831910", Length = "0x233")]
	public void RefreshTextRestore(bool isPurchase = false)
	{
	}

	[Address(RVA = "0x833500", Offset = "0x831D00", Length = "0x15E")]
	[Token(Token = "0x600545B")]
	public void SetDiscountPrice(string localizationPrice, int discount, DateTime discountStartTime, DateTime discountEndTime, DateTime utcNow, Action onCountDownComplete = null)
	{
	}

	[Token(Token = "0x600545C")]
	[Address(RVA = "0x833980", Offset = "0x832180", Length = "0x33D")]
	public void SetPrice(Product originProduct, DateTime utcTime, Action onCountDownComplete = null)
	{
	}

	[Token(Token = "0x600545D")]
	[Address(RVA = "0x8330B0", Offset = "0x8318B0", Length = "0x51")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600545E")]
	[Address(RVA = "0x832B20", Offset = "0x831320", Length = "0x273")]
	private string GetPriceFormat(string priceString)
	{
		return null;
	}

	[Address(RVA = "0x832AB0", Offset = "0x8312B0", Length = "0x6F")]
	[Token(Token = "0x600545F")]
	public bool ContainsNumber(string input)
	{
		return default(bool);
	}

	[Address(RVA = "0x8346D0", Offset = "0x832ED0", Length = "0x46")]
	[Token(Token = "0x6005460")]
	public PriceTxtDisplay()
	{
	}
}
