namespace UnityEngine.Rendering;

[ExecuteAlways]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FreeCamera : MonoBehaviour
{
	private static string kMouseX; //Field offset: 0x0
	private static string kMouseY; //Field offset: 0x8
	private static string kRightStickX; //Field offset: 0x10
	private static string kRightStickY; //Field offset: 0x18
	private static string kVertical; //Field offset: 0x20
	private static string kHorizontal; //Field offset: 0x28
	private static string kYAxis; //Field offset: 0x30
	private static string kSpeedAxis; //Field offset: 0x38
	public float m_LookSpeedController; //Field offset: 0x18
	public float m_LookSpeedMouse; //Field offset: 0x1C
	public float m_MoveSpeed; //Field offset: 0x20
	public float m_MoveSpeedIncrement; //Field offset: 0x24
	public float m_Turbo; //Field offset: 0x28

	private static FreeCamera() { }

	public FreeCamera() { }

	private void OnEnable() { }

	private void RegisterInputs() { }

	private void Update() { }

}

