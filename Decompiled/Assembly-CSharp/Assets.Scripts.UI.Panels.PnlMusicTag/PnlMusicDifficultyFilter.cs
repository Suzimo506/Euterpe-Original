using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x20008FA")]
public class PnlMusicDifficultyFilter : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400300B")]
	private ToggleGroup m_TglGroup;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400300C")]
	[SerializeField]
	private ToggleDifficultySongFilter[] m_TglFilters;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400300D")]
	private Toggle m_TglAdditionalFilter;

	[Token(Token = "0x400300E")]
	[FieldOffset(Offset = "0x30")]
	private PnlMusicTag m_ParentComp;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400300F")]
	private PnlMusicDifficultyItem m_ParentTabItem;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4003010")]
	private GameObject m_LastDiffSelectedObj;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003011")]
	private List<Selectable> m_LinkedMusicElements;

	[Token(Token = "0x4003012")]
	[FieldOffset(Offset = "0x50")]
	private bool isPnlEnabled;

	[Address(RVA = "0x67B660", Offset = "0x679E60", Length = "0x4CD")]
	[Token(Token = "0x6005177")]
	public void AwakeInit(PnlMusicTag parentComp)
	{
	}

	[Address(RVA = "0x67BEA0", Offset = "0x67A6A0", Length = "0x1CD")]
	[Token(Token = "0x6005178")]
	private void LinkDifficultySelectionNavigations(bool isTglOn = true)
	{
	}

	[Address(RVA = "0x67C070", Offset = "0x67A870", Length = "0x538")]
	[Token(Token = "0x6005179")]
	public void LinkMusicElementsNavigation(bool isTglOn = true)
	{
	}

	[Token(Token = "0x600517A")]
	[Address(RVA = "0x67C8C0", Offset = "0x67B0C0", Length = "0x1BC")]
	private void ResetSelectedObject(bool isTglOn)
	{
	}

	[Token(Token = "0x600517B")]
	[Address(RVA = "0x67BB30", Offset = "0x67A330", Length = "0x14B")]
	private void InitSelectableObjs()
	{
	}

	[Token(Token = "0x600517C")]
	[Address(RVA = "0x67BC80", Offset = "0x67A480", Length = "0x21F")]
	private void LinkConditionTglNavigations(bool isTglOn)
	{
	}

	[Address(RVA = "0x67C620", Offset = "0x67AE20", Length = "0x299")]
	[Token(Token = "0x600517D")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x67C5B0", Offset = "0x67ADB0", Length = "0x6F")]
	[Token(Token = "0x600517E")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x67CF70", Offset = "0x67B770", Length = "0xF3")]
	[Token(Token = "0x600517F")]
	private void UpdateSongList()
	{
	}

	[Address(RVA = "0x67CBB0", Offset = "0x67B3B0", Length = "0x119")]
	[Token(Token = "0x6005180")]
	private void SetSavedFilter()
	{
	}

	[Address(RVA = "0x67CA80", Offset = "0x67B280", Length = "0x12C")]
	[Token(Token = "0x6005181")]
	private void SetConditionLabels()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005182")]
	public PnlMusicDifficultyFilter()
	{
	}
}
