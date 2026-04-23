using System.Collections;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

[Token(Token = "0x200013F")]
public class PnlPMDPhoneLoginState : Singleton<PnlPMDPhoneLoginState>
{
	[Token(Token = "0x2000A28")]
	public enum BindType
	{
		[Token(Token = "0x4003631")]
		NoBind,
		[Token(Token = "0x4003632")]
		ChangeBind
	}

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x10")]
	public bool isBind;

	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40007C9")]
	public bool isBindGlobal;

	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40007CA")]
	public bool isBindUser;

	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x13")]
	public bool isOversea;

	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0x14")]
	public bool isNoYet;

	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x15")]
	public bool isRunOnce;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0x16")]
	public bool isCloseBulletin;

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x7B1F50", Offset = "0x7B0750", Length = "0x2DE")]
	public void CheckBind()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x22660", Offset = "0x21A60")]
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x7B22E0", Offset = "0x7B0AE0", Length = "0x65")]
	private IEnumerator Choose()
	{
		return null;
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x7B2360", Offset = "0x7B0B60", Length = "0x18C")]
	public void IsBind()
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x7B24F0", Offset = "0x7B0CF0", Length = "0x7F")]
	public void IsUserBind()
	{
	}

	[Address(RVA = "0x7B2230", Offset = "0x7B0A30", Length = "0xAE")]
	[Token(Token = "0x6000902")]
	public bool CheckFirstOpenAfterBindUpdate()
	{
		return default(bool);
	}

	[Address(RVA = "0x7B2350", Offset = "0x7B0B50", Length = "0x7")]
	[Token(Token = "0x6000903")]
	public void Init()
	{
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x7B2900", Offset = "0x7B1100", Length = "0x3C")]
	public PnlPMDPhoneLoginState()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
