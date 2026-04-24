//Type is in global namespace

[ExecuteInEditMode]
public class particleHoming : MonoBehaviour
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Transform target; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float speed; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float maxSpeed; //Field offset: 0x24
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float homingDelay; //Field offset: 0x28
	private ParticleSystem m_System; //Field offset: 0x30
	private Particle[] m_Particles; //Field offset: 0x38

	public particleHoming() { }

	private void InitializeIfNeeded() { }

	private void LateUpdate() { }

	private void Start() { }

}

