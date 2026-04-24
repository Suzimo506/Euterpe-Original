namespace Assets.Scripts.Graphics;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DynamicGradient : MonoBehaviour
{
	public Gradient[] keyGradient; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float timeStep; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public AnimationCurve timeStepCurve; //Field offset: 0x28
	private Gradient m_Origin; //Field offset: 0x30
	private float m_PassTime; //Field offset: 0x38
	private GradientFog m_target; //Field offset: 0x40

	public DynamicGradient() { }

	private void Start() { }

	private void Update() { }

}

