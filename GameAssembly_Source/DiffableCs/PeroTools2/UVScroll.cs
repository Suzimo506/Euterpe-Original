//Type is in global namespace

public class UVScroll : MonoBehaviour
{
	public float ScrollSpeedX; //Field offset: 0x18
	public float ScrollSpeedY; //Field offset: 0x1C
	public float ExistenceTime; //Field offset: 0x20
	private MaterialPropertyBlock m_MaterialPropertyBlock; //Field offset: 0x28
	private Vector4 m_MainTex_ST; //Field offset: 0x30
	private int m_MainTex_STID; //Field offset: 0x40
	private Vector3 m_Position; //Field offset: 0x44
	private bool m_Visible; //Field offset: 0x50

	public UVScroll() { }

	private void Awake() { }

	private void OnBecameInvisible() { }

	private void OnBecameVisible() { }

	private void ShaderInteraction() { }

	private void Timer() { }

	private void Update() { }

}

