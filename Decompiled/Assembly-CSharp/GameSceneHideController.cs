using Cpp2ILInjected;

[Token(Token = "0x200003F")]
public class GameSceneHideController : BaseEnemyObjectController
{
	[Address(RVA = "0x5BE390", Offset = "0x5BCB90", Length = "0x116")]
	[Token(Token = "0x6000195")]
	public override void OnControllerStart()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x5BE4B0", Offset = "0x5BCCB0", Length = "0xA2")]
	private void SetSceneHide(bool isActive = true)
	{
	}

	[Address(RVA = "0x5BE560", Offset = "0x5BCD60", Length = "0x51")]
	[Token(Token = "0x6000197")]
	public GameSceneHideController()
	{
	}
}
