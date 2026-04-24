//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisRandomController : VisBaseController
{
	internal static class Defaults
	{
		public const float delayTime = 1; //Field offset: 0x0

	}

	public float delayTime; //Field offset: 0x58
	private float m_fCurrentRandomValue; //Field offset: 0x5C
	private float m_fNewValueTimer; //Field offset: 0x60

	public VisRandomController() { }

	public virtual float GetCustomControllerValue() { }

	public virtual void Reset() { }

	public virtual void Start() { }

}

