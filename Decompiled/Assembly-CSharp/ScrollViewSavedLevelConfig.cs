using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;

[Token(Token = "0x2000150")]
public class ScrollViewSavedLevelConfig : ScrollViewEx<SavedLevelConfigData, SvSavedLevelConfigContext>
{
	[Token(Token = "0x170000C3")]
	public List<BaseScrollItem<SavedLevelConfigData, SvSavedLevelConfigContext>> Items
	{
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x62C440", Offset = "0x62AC40", Length = "0x8F")]
	protected override void UpdateContent()
	{
	}

	[Address(RVA = "0x62C220", Offset = "0x62AA20", Length = "0x199")]
	[Token(Token = "0x6000975")]
	public override void ScrollToItem(SavedLevelConfigData item)
	{
	}

	[Address(RVA = "0x62C4D0", Offset = "0x62ACD0", Length = "0x38")]
	[Token(Token = "0x6000976")]
	public ScrollViewSavedLevelConfig()
	{
		((ScrollViewEx<, >)(object)this)._002Ector();
	}
}
