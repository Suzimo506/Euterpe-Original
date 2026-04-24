//Type is in global namespace

public class AirMusicNodeController : BaseEnemyObjectController
{
	protected GameObject m_Fx; //Field offset: 0x1F0
	protected ParticleSystem[] m_ParticleSystems; //Field offset: 0x1F8

	public AirMusicNodeController() { }

	public static void AddExtraScore(ref MusicData md, bool isAir) { }

	public virtual void Init(int scene) { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int idx) { }

	public virtual void Pause(bool pauseCorountine) { }

	public virtual void Resume() { }

	public virtual void SetVisible(bool enable) { }

}

