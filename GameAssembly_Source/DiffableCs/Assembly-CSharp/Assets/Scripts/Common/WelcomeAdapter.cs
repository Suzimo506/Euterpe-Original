namespace Assets.Scripts.Common;

public class WelcomeAdapter : MonoBehaviour
{
	public Vector2 fourToThree; //Field offset: 0x18
	public Vector2 standard; //Field offset: 0x20
	public Vector2 extraStandard; //Field offset: 0x28
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int m_Index; //Field offset: 0x30

	public WelcomeAdapter() { }

	public void OnEnable() { }

}

