using Cpp2ILInjected;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006BA")]
public class IAPPipelineCode
{
	[Token(Token = "0x4002437")]
	public const uint purchase_success = 0u;

	[Token(Token = "0x4002438")]
	public const uint purchase_failed = 1u;

	[Token(Token = "0x4002439")]
	public const uint restore_success = 2u;

	[Token(Token = "0x400243A")]
	public const uint restore_failed = 3u;

	[Token(Token = "0x400243B")]
	public const uint end_with_no_notify = 4u;

	[Token(Token = "0x400243C")]
	public const uint product_already_purchased = 105u;

	[Token(Token = "0x400243D")]
	public const uint get_product_from_pero_server_failed = 100u;

	[Token(Token = "0x400243E")]
	public const uint need_to_logout = 101u;

	[Token(Token = "0x400243F")]
	public const uint no_package_need_purchase = 102u;

	[Token(Token = "0x4002440")]
	public const uint pero_apple_login_disable = 103u;

	[Token(Token = "0x4002441")]
	public const uint user_jobj_info_is_null = 104u;

	[Token(Token = "0x4002442")]
	public const uint age_is_underage = 105u;

	[Token(Token = "0x4002443")]
	public const uint purchase_state_failed = 106u;

	[Token(Token = "0x4002444")]
	public const uint user_no_real_name_info = 107u;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003F0E")]
	public IAPPipelineCode()
	{
	}
}
