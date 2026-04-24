//Type is in global namespace

public class STMTextInfo
{
	public CharacterInfo ch; //Field offset: 0x10
	public Vector3 pos; //Field offset: 0x44
	public float readTime; //Field offset: 0x50
	public float unreadTime; //Field offset: 0x54
	public int line; //Field offset: 0x58
	public float indent; //Field offset: 0x5C
	public STMDrawAnimData drawAnimData; //Field offset: 0x60
	public float size; //Field offset: 0x68
	public Alignment alignment; //Field offset: 0x6C
	public DrawOrder drawOrder; //Field offset: 0x70
	public List<String> ev; //Field offset: 0x78
	public List<String> ev2; //Field offset: 0x80
	public STMColorData colorData; //Field offset: 0x88
	public STMGradientData gradientData; //Field offset: 0x90
	public STMTextureData textureData; //Field offset: 0x98
	public STMDelayData delayData; //Field offset: 0xA0
	public STMWaveData waveData; //Field offset: 0xA8
	public STMJitterData jitterData; //Field offset: 0xB0
	public float readDelay; //Field offset: 0xB8
	public STMAudioClipData audioClipData; //Field offset: 0xC0
	public bool stopPreviousSound; //Field offset: 0xC8
	public PitchMode pitchMode; //Field offset: 0xCC
	public float overridePitch; //Field offset: 0xD0
	public float minPitch; //Field offset: 0xD4
	public float maxPitch; //Field offset: 0xD8
	public float speedReadPitch; //Field offset: 0xDC
	public STMFontData fontData; //Field offset: 0xE0
	public STMQuadData quadData; //Field offset: 0xE8
	public STMMaterialData materialData; //Field offset: 0xF0
	public STMSoundClipData soundClipData; //Field offset: 0xF8

	public Vector3 BottomLeftVert
	{
		 get { } //Length: 356
	}

	public Vector3 BottomRightVert
	{
		 get { } //Length: 356
	}

	public Vector3 Middle
	{
		 get { } //Length: 235
	}

	public Vector3 TopLeftVert
	{
		 get { } //Length: 356
	}

	public Vector3 TopRightVert
	{
		 get { } //Length: 356
	}

	public STMTextInfo() { }

	public STMTextInfo(SuperTextMesh stm) { }

	public STMTextInfo(STMTextInfo clone, CharacterInfo ch) { }

	public STMTextInfo(STMTextInfo clone) { }

	public Vector3 Advance(float extraSpacing, float myQuality) { }

	public Vector3 get_BottomLeftVert() { }

	public Vector3 get_BottomRightVert() { }

	public Vector3 get_Middle() { }

	public Vector3 get_TopLeftVert() { }

	public Vector3 get_TopRightVert() { }

	public Vector3 RelativePos(Vector3 yeah) { }

	public Vector3 RelativePos2(Vector3 yeah) { }

}

