//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisSineWaveController : VisBaseController
{
	internal static class Defaults
	{
		public const float speedScalar = 1; //Field offset: 0x0

	}

	public float speedScalar; //Field offset: 0x58

	public VisSineWaveController() { }

	public virtual float GetCustomControllerValue() { }

	public virtual void Reset() { }

	public virtual void Start() { }

}

