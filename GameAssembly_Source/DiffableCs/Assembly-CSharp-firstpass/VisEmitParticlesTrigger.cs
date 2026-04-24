//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisEmitParticlesTrigger : VisBaseTrigger
{
	internal static class Defaults
	{

	}

	public int emitCount; //Field offset: 0x50
	public int emitCountVariance; //Field offset: 0x54

	public VisEmitParticlesTrigger() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public virtual void Start() { }

}

