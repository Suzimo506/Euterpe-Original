using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000200")]
public class InputFieldInfo : UIElementInfo
{
	[Token(Token = "0x17000399")]
	public int actionId
	{
		[CompilerGenerated]
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x597050", Offset = "0x595850", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600129F")]
		set
		{
		}
	}

	[Token(Token = "0x1700039A")]
	public AxisRange axisRange
	{
		[CompilerGenerated]
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
		get
		{
			return default(AxisRange);
		}
		[CompilerGenerated]
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x45AB50", Offset = "0x459350", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700039B")]
	public int actionElementMapId
	{
		[CompilerGenerated]
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x597030", Offset = "0x595830", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x597070", Offset = "0x595870", Length = "0x4")]
		[Token(Token = "0x60012A3")]
		set
		{
		}
	}

	[Token(Token = "0x1700039C")]
	public ControllerType controllerType
	{
		[CompilerGenerated]
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x782D10", Offset = "0x781510", Length = "0x4")]
		get
		{
			return default(ControllerType);
		}
		[CompilerGenerated]
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x78DEB0", Offset = "0x78C6B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700039D")]
	public int controllerId
	{
		[CompilerGenerated]
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x7044C0", Offset = "0x702CC0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public InputFieldInfo()
	{
	}
}
