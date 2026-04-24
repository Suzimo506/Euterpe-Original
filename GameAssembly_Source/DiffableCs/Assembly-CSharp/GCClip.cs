//Type is in global namespace

public class GCClip : MonoBehaviour
{
	private const float interval = 6.7; //Field offset: 0x0
	public int idx; //Field offset: 0x18
	private float m_ClipValue; //Field offset: 0x1C
	private Material m_Material; //Field offset: 0x20
	private float m_SizePower; //Field offset: 0x28
	private float m_MinSize; //Field offset: 0x2C
	private DBOther m_DbOther; //Field offset: 0x30
	public float updateInterval; //Field offset: 0x38
	private int m_PassFrame; //Field offset: 0x3C
	private float m_PassTime; //Field offset: 0x40

	public GCClip() { }

	private void OnAudioVisualization() { }

	private void Reset() { }

	private void Start() { }

	private void UpAudioVisualization() { }

	private void Update() { }

}

