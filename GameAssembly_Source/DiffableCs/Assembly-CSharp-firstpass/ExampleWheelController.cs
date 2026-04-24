//Type is in global namespace

public class ExampleWheelController : MonoBehaviour
{
	private static class Uniforms
	{
		internal static readonly int _MotionAmount; //Field offset: 0x64CD0

		private static Uniforms() { }

	}

	public float acceleration; //Field offset: 0x18
	public Renderer motionVectorRenderer; //Field offset: 0x20
	private Rigidbody m_Rigidbody; //Field offset: 0x28

	public ExampleWheelController() { }

	private void Start() { }

	private void Update() { }

}

