using Cpp2ILInjected;
using Spine.Unity;

[Token(Token = "0x2000038")]
public class AutoPlayController : BaseEnemyObjectController
{
	[Token(Token = "0x4000163")]
	private static SkeletonDataAsset m_Rock;

	[Token(Token = "0x4000164")]
	private static SkeletonDataAsset m_Sleepy;

	[Token(Token = "0x4000165")]
	private static bool m_IsInstance;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5F3260", Offset = "0x5F1A60", Length = "0x166")]
	[Token(Token = "0x600014F")]
	public override void OnControllerStart()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x5F33D0", Offset = "0x5F1BD0", Length = "0xA9")]
	public AutoPlayController()
	{
	}
}
