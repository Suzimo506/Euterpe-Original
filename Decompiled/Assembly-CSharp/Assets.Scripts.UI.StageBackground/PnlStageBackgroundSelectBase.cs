using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000830")]
public abstract class PnlStageBackgroundSelectBase : MonoBehaviour
{
	[Token(Token = "0x4002AA3")]
	[FieldOffset(Offset = "0x18")]
	protected StageBackgroundSelectCell m_CurrentSelectCell;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002AA4")]
	protected StageBackgroundSelectCell m_CurrentPreviewCell;

	[Token(Token = "0x4002AA5")]
	[FieldOffset(Offset = "0x28")]
	protected PnlStageBackgroundView m_RootView;

	[Token(Token = "0x1700083E")]
	public StageBackgroundSelectCell CurrentPreviewCell
	{
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x615970", Offset = "0x614170", Length = "0x47")]
	[Token(Token = "0x6004B59")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6004B5A")]
	[Address(RVA = "0x6159C0", Offset = "0x6141C0", Length = "0x49")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x6004B5B")]
	[Address(RVA = "0x615A60", Offset = "0x614260", Length = "0x48")]
	public virtual void ScrollToCell(int cellIndex)
	{
	}

	[Token(Token = "0x6004B5C")]
	[Address(RVA = "0x615A10", Offset = "0x614210", Length = "0x48")]
	public virtual void ScrollToCell(string cellPos)
	{
	}

	[Token(Token = "0x6004B5D")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void ScrollAndSelectCell(StageBackgroundSelectCell selectCell);

	[Token(Token = "0x6004B5E")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void RefreshCellState(List<StageBackgroundData> bgDataList);

	[Token(Token = "0x6004B5F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected PnlStageBackgroundSelectBase()
	{
	}
}
