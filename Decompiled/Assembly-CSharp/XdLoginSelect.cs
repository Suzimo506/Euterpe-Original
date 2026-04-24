using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x200013C")]
public class XdLoginSelect : UISelectManage
{
	[Token(Token = "0x2000A27")]
	public enum XdWindowType
	{
		[Token(Token = "0x400362E")]
		Main,
		[Token(Token = "0x400362F")]
		Web
	}

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x118")]
	public XdWindowType type;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x120")]
	private InputKeyBinding account;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40007C6")]
	public Button WebCloseButton;

	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x130")]
	private bool m_IsWebClose;

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0xD34290", Offset = "0xD32A90", Length = "0xB")]
	private bool m_IsWeb()
	{
		return default(bool);
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0xD340A0", Offset = "0xD328A0", Length = "0x1DF")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0xD33EE0", Offset = "0xD326E0", Length = "0x1B7")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x60008F7")]
	public XdLoginSelect()
	{
	}
}
