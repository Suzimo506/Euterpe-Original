using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x2000842")]
public class ScrollViewDaveFish : ScrollViewEx<ScrDaveFishData, ScrDaveFishContext>
{
	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002B29")]
	private List<FishAlignmentType> m_FishAlignmentType;

	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0x78")]
	private GridLayoutGroup m_GridLayoutGroup;

	[Token(Token = "0x1700084F")]
	public GridLayoutGroup GridLayoutGroup
	{
		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0x5C1440", Offset = "0x5BFC40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000850")]
	public List<BaseScrollItem<ScrDaveFishData, ScrDaveFishContext>> ScrDaveFishDataList
	{
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		[Token(Token = "0x6004BF2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BF3")]
	[Address(RVA = "0x61B1E0", Offset = "0x6199E0", Length = "0x74")]
	public override void Init()
	{
	}

	[Address(RVA = "0x61B260", Offset = "0x619A60", Length = "0x10E")]
	[Token(Token = "0x6004BF4")]
	public override void ScrollToItem(ScrDaveFishData item)
	{
	}

	[Address(RVA = "0x61B370", Offset = "0x619B70", Length = "0x38")]
	[Token(Token = "0x6004BF5")]
	public ScrollViewDaveFish()
	{
		((ScrollViewEx<, >)(object)this)._002Ector();
	}
}
