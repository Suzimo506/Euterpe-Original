using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000297")]
public enum EnumRailGameRefundState
{
	[Token(Token = "0x4001058")]
	kRailGameRefundStateUnknown = 0,
	[Token(Token = "0x4001059")]
	kRailGameRefundStateApplyReceived = 1000,
	[Token(Token = "0x400105A")]
	kRailGameRefundStateUserCancelApply = 1100,
	[Token(Token = "0x400105B")]
	kRailGameRefundStateAdminCancelApply = 1101,
	[Token(Token = "0x400105C")]
	kRailGameRefundStateRefundApproved = 1150,
	[Token(Token = "0x400105D")]
	kRailGameRefundStateRefundSuccess = 1200,
	[Token(Token = "0x400105E")]
	kRailGameRefundStateRefundFailed = 1201
}
