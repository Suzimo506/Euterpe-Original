//Type is in global namespace

public class SpectrumSize : MonoBehaviour
{
	public GameObject theObject; //Field offset: 0x18
	public int audioChannel; //Field offset: 0x20
	public float audioSensibility; //Field offset: 0x24
	public float scaleFactorX; //Field offset: 0x28
	public float scaleFactorY; //Field offset: 0x2C
	public float scaleFactorZ; //Field offset: 0x30
	public float lerpTime; //Field offset: 0x34
	private Vector3 oldLocalScale; //Field offset: 0x38

	public SpectrumSize() { }

	private void Start() { }

	private void Update() { }

}

