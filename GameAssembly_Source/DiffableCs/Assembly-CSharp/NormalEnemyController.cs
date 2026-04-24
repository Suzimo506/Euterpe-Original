//Type is in global namespace

public class NormalEnemyController : BaseEnemyObjectController
{
	private ParticleSystem[] m_ParticleSystems; //Field offset: 0x1F0

	public NormalEnemyController() { }

	public virtual void Init(int scene) { }

	public virtual bool OnControllerMiss(int idx) { }

	public virtual void Pause(bool pauseCorountine) { }

	public virtual void Resume() { }

}

