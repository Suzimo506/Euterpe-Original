using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000829")]
public class RecommendVersionController : MonoBehaviour
{
	[Token(Token = "0x4002A8A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button m_BtnRedirect;

	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x28")]
	private Canvas m_TipCanvas;

	[Token(Token = "0x1700083D")]
	public RectTransform Rect
	{
		[CompilerGenerated]
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004B2E")]
		[CompilerGenerated]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x6004B2F")]
	[Address(RVA = "0x618C70", Offset = "0x617470", Length = "0x120")]
	public RecommendVersionController Init()
	{
		return null;
	}

	[Token(Token = "0x6004B30")]
	[Address(RVA = "0x619080", Offset = "0x617880", Length = "0x77")]
	public void OverrideSortingLayer(bool isOverride, string layerName = null, int layerOrder = 0)
	{
	}

	[Token(Token = "0x6004B31")]
	[Address(RVA = "0x618BE0", Offset = "0x6173E0", Length = "0x8D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004B32")]
	[Address(RVA = "0x618F60", Offset = "0x617760", Length = "0x9D")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004B33")]
	[Address(RVA = "0x619000", Offset = "0x617800", Length = "0x71")]
	private void OnNavigationBackBtnClicked()
	{
	}

	[Token(Token = "0x6004B34")]
	[Address(RVA = "0x618DA0", Offset = "0x6175A0", Length = "0xFF")]
	private void OnClickToRedirect()
	{
	}

	[Token(Token = "0x6004B35")]
	[Address(RVA = "0x618EA0", Offset = "0x6176A0", Length = "0xB9")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004B36")]
	[Address(RVA = "0x5A0EF0", Offset = "0x59F6F0", Length = "0x7")]
	private void QuitApp()
	{
	}

	[Token(Token = "0x6004B37")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RecommendVersionController()
	{
	}
}
