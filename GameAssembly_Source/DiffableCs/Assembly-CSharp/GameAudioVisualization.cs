//Type is in global namespace

public class GameAudioVisualization : MonoBehaviour
{
	public const int LENGTH = 32; //Field offset: 0x0
	public static Single[] _samples; //Field offset: 0x0
	public static Single[] _freqBand; //Field offset: 0x8
	public static Single[] _bandBuffer; //Field offset: 0x10
	public static Single[] _audioBand; //Field offset: 0x18
	public static Single[] _audioBandBuffer; //Field offset: 0x20
	public float power; //Field offset: 0x18
	public float upSpeed; //Field offset: 0x1C
	public float downSpeed; //Field offset: 0x20
	public float baseN; //Field offset: 0x24
	private Single[] _bufferDecrease; //Field offset: 0x28
	private Single[] _freqBandHighrst; //Field offset: 0x30
	private DBOther m_DbOther; //Field offset: 0x38

	private static GameAudioVisualization() { }

	public GameAudioVisualization() { }

	private void Awake() { }

	private void BandBuffer() { }

	private void CreateAudioBands() { }

	private void FixedUpdate() { }

	private void GetSpectrumAudiosource() { }

	private void MakeFrequencyBands() { }

}

