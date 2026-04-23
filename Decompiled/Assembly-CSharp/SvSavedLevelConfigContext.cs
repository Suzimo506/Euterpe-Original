using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;

[Token(Token = "0x200014F")]
public class SvSavedLevelConfigContext : BaseScrollViewContext<SavedLevelConfigData>
{
	[Token(Token = "0x170000C1")]
	public SavedRoleElfinConfigModel SavedRoleElfinConfigModel
	{
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x46EF80", Offset = "0x46D780", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x51B9F0", Offset = "0x51A1F0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	public Action<SavedLevelConfigData> OnItemClicked
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6000970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x51B9E0", Offset = "0x51A1E0", Length = "0xC")]
		[Token(Token = "0x6000971")]
		set
		{
		}
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x51B960", Offset = "0x51A160", Length = "0x71")]
	public SvSavedLevelConfigContext()
	{
		((BaseScrollViewContext<>)(object)this)._002Ector();
	}
}
