using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;

[Token(Token = "0x200014C")]
public class SavedLevelConfigData : IScrollItemData
{
	[Token(Token = "0x170000BB")]
	public int RoleId
	{
		[CompilerGenerated]
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[Token(Token = "0x6000952")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	public int ElfinId
	{
		[CompilerGenerated]
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000954")]
		[CompilerGenerated]
		[Address(RVA = "0x494A20", Offset = "0x493220", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x624550", Offset = "0x622D50", Length = "0x93")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Address(RVA = "0x6245F0", Offset = "0x622DF0", Length = "0x7")]
	[Token(Token = "0x6000956")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6000957")]
	public SavedLevelConfigData()
	{
	}
}
