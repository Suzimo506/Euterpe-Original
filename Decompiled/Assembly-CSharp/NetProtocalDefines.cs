using System.Runtime.InteropServices;
using Cpp2ILInjected;

[Token(Token = "0x2000029")]
public class NetProtocalDefines
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x20009A0")]
	public struct GameBackedProtocols
	{
		[Token(Token = "0x4003493")]
		public const string game_backend_get_server_time = "musedash/v1/time";
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x20009A1")]
	public struct LoginNetProtocols
	{
		[Token(Token = "0x4003494")]
		public const string pero_login_send_code_for_mobile_phone = "api/v1/auth/phone_login_code";

		[Token(Token = "0x4003495")]
		public const string pero_login_send_code_for_email = "api/v1/auth/phone_email_code";
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x20009A2")]
	public struct LoginErrorCode
	{
		[Token(Token = "0x4003496")]
		public const int code_over_login = 429;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public NetProtocalDefines()
	{
	}
}
