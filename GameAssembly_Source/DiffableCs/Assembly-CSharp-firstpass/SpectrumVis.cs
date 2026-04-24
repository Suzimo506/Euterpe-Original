//Type is in global namespace

public class SpectrumVis : MonoBehaviour
{
	internal enum axisStrech
	{
		dx = 0,
		dy = 1,
		dz = 2,
		dyAndDz = 3,
		all = 4,
	}

	internal enum channelColour
	{
		red = 0,
		green = 1,
		blue = 2,
		all = 3,
	}

	public GameObject[] cubes; //Field offset: 0x18
	public Color barColor; //Field offset: 0x20
	public float sizePower; //Field offset: 0x30
	public axisStrech stretchAxis; //Field offset: 0x34
	public channelColour currentChannel; //Field offset: 0x38
	private float currentRed; //Field offset: 0x3C
	private float currentGreen; //Field offset: 0x40
	private float currentBlue; //Field offset: 0x44
	public float colorPower; //Field offset: 0x48

	public SpectrumVis() { }

	private void Start() { }

	private void Update() { }

}

