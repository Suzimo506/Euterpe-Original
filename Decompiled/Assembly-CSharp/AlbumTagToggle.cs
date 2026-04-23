using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database.DataClass;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000151")]
public class AlbumTagToggle : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000822")]
	public Toggle m_Toggle;

	[SerializeField]
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x20")]
	private Image m_Background;

	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RawImage m_IconImg;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000825")]
	private Text m_Txt;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000826")]
	[SerializeField]
	private GameObject m_WeekFreeIcon;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000827")]
	private GameObject m_NewIcon;

	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Image m_SelectedImg;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000829")]
	public AlbumTagInfo tagInfo;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400082B")]
	public Color allBgColor;

	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x70")]
	public Color baseBgColor;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400082D")]
	public Color collectionBgColor;

	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x90")]
	public Color otherBgColor;

	[Token(Token = "0x400082F")]
	[FieldOffset(Offset = "0xA0")]
	public Color allTxtColor;

	[Token(Token = "0x4000830")]
	[FieldOffset(Offset = "0xB0")]
	public Color collectionTxtColor;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000831")]
	public Color groupTxtColor1;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000832")]
	public Color groupTxtColor2;

	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000833")]
	private AudioClip m_ClickSfx;

	[SerializeField]
	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0xE8")]
	private Animator m_Animator;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0xF0")]
	private int m_OnHash;

	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0xF4")]
	private int m_OffHash;

	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_HashInit;

	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0xF9")]
	private bool m_PrevTglValue;

	[Token(Token = "0x14000004")]
	public event Action<int> toggleChangedHandler
	{
		[Address(RVA = "0x5952B0", Offset = "0x593AB0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600097B")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x595350", Offset = "0x593B50", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x594860", Offset = "0x593060", Length = "0xD2")]
	public void Init()
	{
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x594860", Offset = "0x593060", Length = "0xD2")]
	private void InitHash()
	{
	}

	[Address(RVA = "0x594760", Offset = "0x592F60", Length = "0x59")]
	[Token(Token = "0x600097F")]
	public void ForcePlayToggleAnimator(bool isOn)
	{
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0x594F20", Offset = "0x593720", Length = "0x61")]
	private void PlayToggleAnimator(bool isOn)
	{
	}

	[Address(RVA = "0x594940", Offset = "0x593140", Length = "0x2B2")]
	[Token(Token = "0x6000981")]
	public void InitTag(int groupIndex)
	{
	}

	[Address(RVA = "0x5947C0", Offset = "0x592FC0", Length = "0x91")]
	[Token(Token = "0x6000982")]
	public void InitHandler()
	{
	}

	[Token(Token = "0x6000983")]
	[Address(RVA = "0x594F90", Offset = "0x593790", Length = "0x7E")]
	private void SetIconAsync(Texture2D tex)
	{
	}

	[Address(RVA = "0x595010", Offset = "0x593810", Length = "0x78")]
	[Token(Token = "0x6000984")]
	private void SetStateIcon(bool weekFree, bool newAlbum)
	{
	}

	[Address(RVA = "0x594C00", Offset = "0x593400", Length = "0x68")]
	[Token(Token = "0x6000985")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x594C70", Offset = "0x593470", Length = "0x2A4")]
	[Token(Token = "0x6000986")]
	private void OnSelectToggle(bool isOn)
	{
	}

	[Token(Token = "0x6000987")]
	[Address(RVA = "0x595090", Offset = "0x593890", Length = "0x215")]
	public AlbumTagToggle()
	{
	}
}
