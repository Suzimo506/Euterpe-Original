namespace Assets.Scripts.Database;

public abstract class BaseDatabase
{
	protected static readonly bool m_SafeMode; //Field offset: 0x16ED57

	private static BaseDatabase() { }

	protected BaseDatabase() { }

	public abstract void AwakeInit() { }

	public override void Flush() { }

	public abstract void Release() { }

	public override void SceneChangedRelease(Scene preScene, Scene curScene) { }

	public override void StartInit() { }

}

