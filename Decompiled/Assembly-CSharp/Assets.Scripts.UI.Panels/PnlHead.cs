using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008EF")]
public class PnlHead : BaseMessageBox
{
	[Token(Token = "0x2000D83")]
	private enum Direction
	{
		[Token(Token = "0x4003FFC")]
		Up,
		[Token(Token = "0x4003FFD")]
		Down,
		[Token(Token = "0x4003FFE")]
		Left,
		[Token(Token = "0x4003FFF")]
		Right
	}

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002FA5")]
	private string lastSelectedHeadName;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002FA6")]
	public HeadGridView headGridView;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002FA7")]
	private List<HeadItemData> m_HeadItemDatas;

	[Token(Token = "0x4002FA8")]
	[FieldOffset(Offset = "0x108")]
	private List<HeadInfo> m_AllHeadInfos;

	[Token(Token = "0x4002FA9")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x6005116")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x6005117")]
	[Address(RVA = "0x82E470", Offset = "0x82CC70", Length = "0x176")]
	private void GenerateCell()
	{
	}

	[Address(RVA = "0x82F280", Offset = "0x82DA80", Length = "0x1F1")]
	[Token(Token = "0x6005118")]
	private void SortCell()
	{
	}

	[Address(RVA = "0x82E460", Offset = "0x82CC60", Length = "0x7")]
	[Token(Token = "0x6005119")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x82EFF0", Offset = "0x82D7F0", Length = "0x28C")]
	[Token(Token = "0x600511A")]
	public override void Show()
	{
	}

	[Address(RVA = "0x82ED90", Offset = "0x82D590", Length = "0x259")]
	[Token(Token = "0x600511B")]
	private void SetupNavigation(List<RectTransform> listemp)
	{
	}

	[Address(RVA = "0x82E5F0", Offset = "0x82CDF0", Length = "0x3C3")]
	[Token(Token = "0x600511C")]
	private Selectable GetNearestInDirection(RectTransform currentRect, List<RectTransform> list, Direction direction)
	{
		return null;
	}

	[Token(Token = "0x600511D")]
	[Address(RVA = "0x82ECA0", Offset = "0x82D4A0", Length = "0xE3")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600511E")]
	[Address(RVA = "0x82E9C0", Offset = "0x82D1C0", Length = "0x123")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Address(RVA = "0x82EAF0", Offset = "0x82D2F0", Length = "0x1A0")]
	[Token(Token = "0x600511F")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x82F5C0", Offset = "0x82DDC0", Length = "0x9C")]
	[Token(Token = "0x6005120")]
	public PnlHead()
	{
	}
}
