namespace GameLogic;

public class OnGainEnergyBottle : DoNothing
{
	private static GameObject recoveryEffect; //Field offset: 0x16E570

	private static OnGainEnergyBottle() { }

	public OnGainEnergyBottle() { }

	public virtual void Do(TrackEntry entry) { }

	private void PlayRecoveryEffect() { }

	private void Start() { }

}

