//Type is in global namespace

public class AutoPlayController : BaseEnemyObjectController
{
	private static SkeletonDataAsset m_Rock; //Field offset: 0x0
	private static SkeletonDataAsset m_Sleepy; //Field offset: 0x8
	private static bool m_IsInstance; //Field offset: 0x10

	private static AutoPlayController() { }

	public AutoPlayController() { }

	private void Awake() { }

	public virtual void OnControllerStart() { }

}

