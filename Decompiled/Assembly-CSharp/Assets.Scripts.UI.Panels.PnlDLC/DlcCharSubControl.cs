using System;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000926")]
public class DlcCharSubControl : MonoBehaviour
{
	[Token(Token = "0x4003151")]
	private const string dlc_char_skin_name = "reverse";

	[Token(Token = "0x4003152")]
	private const int char_offset = 625;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4003153")]
	private Animator m_DlcCharMoveAnimator;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003154")]
	private PnlDlcCharacterExpression m_CharacterExpression;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003155")]
	[SerializeField]
	private RectTransform m_Rect;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4003156")]
	private RectTransform m_CharLocation;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003157")]
	private string m_SortingLayer;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4003158")]
	private int m_OrderInLayer;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003159")]
	private CharacterApply m_CharacterApply;

	[Token(Token = "0x400315A")]
	[FieldOffset(Offset = "0x50")]
	private PnlDlc m_Parent;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400315B")]
	private int m_JsonIndex;

	[SerializeField]
	[Token(Token = "0x400315C")]
	[FieldOffset(Offset = "0x60")]
	private DlcCharLayoutPair m_DlcCharLayout;

	[Address(RVA = "0x42D5A0", Offset = "0x42BDA0", Length = "0x1AB")]
	[Token(Token = "0x6005303")]
	public void Init(PnlDlc parent)
	{
	}

	[Token(Token = "0x6005304")]
	[Address(RVA = "0x42DA30", Offset = "0x42C230", Length = "0xE")]
	public void RefreshCharDisplayByAlbumJsonIndex(int jsonIndex)
	{
	}

	[Token(Token = "0x6005305")]
	[Address(RVA = "0x42D820", Offset = "0x42C020", Length = "0xC2")]
	private void OnFsvItemIndexChange(int i)
	{
	}

	[Token(Token = "0x6005306")]
	[Address(RVA = "0x42D260", Offset = "0x42BA60", Length = "0xEB")]
	private void FancyScrollViewOnOnStateChange(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView.State state)
	{
	}

	[Address(RVA = "0x42D8F0", Offset = "0x42C0F0", Length = "0x37")]
	[Token(Token = "0x6005307")]
	public void PlayCharacterApply(string animName, string voiceName, Action endCallback = null, bool autoAddSuffix = true)
	{
	}

	[Address(RVA = "0x42D350", Offset = "0x42BB50", Length = "0x18E")]
	[Token(Token = "0x6005308")]
	private void FastDestroy()
	{
	}

	[Token(Token = "0x6005309")]
	[Address(RVA = "0x42D750", Offset = "0x42BF50", Length = "0xC5")]
	private void OnFsvFinalChanged(int index)
	{
	}

	[Token(Token = "0x600530A")]
	[Address(RVA = "0x42DF30", Offset = "0x42C730", Length = "0x9F")]
	private void SetSkMeshRenderOrder()
	{
	}

	[Token(Token = "0x600530B")]
	[Address(RVA = "0x42DA40", Offset = "0x42C240", Length = "0x4E9")]
	private void RefreshChar(int jsonIndex)
	{
	}

	[Address(RVA = "0x42DA30", Offset = "0x42C230", Length = "0xE")]
	[Token(Token = "0x600530C")]
	private void Show(int jsonIndex)
	{
	}

	[Address(RVA = "0x42D4E0", Offset = "0x42BCE0", Length = "0xB7")]
	[Token(Token = "0x600530D")]
	public void Hide()
	{
	}

	[Address(RVA = "0x42D980", Offset = "0x42C180", Length = "0xA2")]
	[Token(Token = "0x600530E")]
	private void ReflushPosition()
	{
	}

	[Token(Token = "0x600530F")]
	[Address(RVA = "0x42D930", Offset = "0x42C130", Length = "0x40")]
	private void Play(int animHash, bool normalPlay = true, float normalize = 0f)
	{
	}

	[Token(Token = "0x6005310")]
	[Address(RVA = "0x42DFD0", Offset = "0x42C7D0", Length = "0x9E")]
	public DlcCharSubControl()
	{
	}
}
