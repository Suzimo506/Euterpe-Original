//Type is in global namespace

public class AirEnergyBottleController : BaseEnemyObjectController
{
	protected GameObject m_Fx; //Field offset: 0x1F0
	protected ParticleSystem[] m_ParticleSystems; //Field offset: 0x1F8

	public AirEnergyBottleController() { }

	public virtual void Init(int scene) { }

	public virtual void OnControllerAttacked(int result, bool isDeaded) { }

	public virtual bool OnControllerMiss(int idx) { }

	public virtual void Pause(bool pauseCorountine) { }

	public static void RecoveryEffects(ref MusicData md, bool fxIsAir) { }

	public virtual void Resume() { }

	public virtual void SetVisible(bool enable) { }

	public static void TouhouAddRedPoint(ref MusicData md, bool girlIsAir) { }

}

