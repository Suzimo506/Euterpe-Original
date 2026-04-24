using Cpp2ILInjected;

[Token(Token = "0x200004C")]
public class SceneChangeController : BaseEnemyObjectController
{
	[Token(Token = "0x40001BA")]
	public static int curScene;

	[Address(RVA = "0x626CA0", Offset = "0x6254A0", Length = "0xE9")]
	[Token(Token = "0x6000219")]
	public override void OnControllerStart()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x626D90", Offset = "0x625590", Length = "0x2E4")]
	private void SceneAnimationReset(int sceneInfo)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x626990", Offset = "0x625190", Length = "0x301")]
	private void ChangeScene(int sceneInfo)
	{
	}

	[Address(RVA = "0x626340", Offset = "0x624B40", Length = "0x640")]
	[Token(Token = "0x600021C")]
	private void ChangeNote(int sceneInfo)
	{
	}

	[Address(RVA = "0x627080", Offset = "0x625880", Length = "0x51")]
	[Token(Token = "0x600021D")]
	public SceneChangeController()
	{
	}
}
