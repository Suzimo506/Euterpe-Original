using Cpp2ILInjected;

namespace Account;

[Token(Token = "0x2000565")]
public class UserBindInfo
{
	[Token(Token = "0x2000B88")]
	public struct BindData
	{
		[Token(Token = "0x4003A86")]
		[FieldOffset(Offset = "0x0")]
		public string phone;

		[Token(Token = "0x4003A87")]
		[FieldOffset(Offset = "0x8")]
		public string email;

		[Token(Token = "0x4003A88")]
		[FieldOffset(Offset = "0x10")]
		public bool is_auth;

		[Token(Token = "0x4003A89")]
		[FieldOffset(Offset = "0x11")]
		public bool real_name_verify;

		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4003A8A")]
		public bool auth_phone;

		[Token(Token = "0x4003A8B")]
		[FieldOffset(Offset = "0x13")]
		public bool is_adult;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4003A8C")]
		public int adult_type;
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001FD9")]
	public int code;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001FDA")]
	public BindData data;

	[Token(Token = "0x17000515")]
	public bool isBind
	{
		[Address(RVA = "0x780230", Offset = "0x77EA30", Length = "0x33")]
		[Token(Token = "0x60037FD")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60037FE")]
	public UserBindInfo()
	{
	}
}
