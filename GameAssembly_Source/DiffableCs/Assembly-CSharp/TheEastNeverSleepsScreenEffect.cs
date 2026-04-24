//Type is in global namespace

public class TheEastNeverSleepsScreenEffect : PostEffectsBase, IUpdate
{
	private struct FlashData
	{
		public float start; //Field offset: 0x0
		public float end; //Field offset: 0x4
		public float duration; //Field offset: 0x8
		public uint type; //Field offset: 0xC

	}

	private struct FlashType
	{
		public const uint flash_in = 0; //Field offset: 0x0
		public const uint flash_hold = 1; //Field offset: 0x0
		public const uint flash_out = 2; //Field offset: 0x0

	}

	public Shader screenEffectShader; //Field offset: 0x28
	private Material m_ScreenEffectMaterial; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float verticalRollIntensity; //Field offset: 0x38
	public bool changeVerticalDir; //Field offset: 0x3C
	private float m_VerticalSpeed; //Field offset: 0x40
	private float m_VerticalRollTime; //Field offset: 0x44
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float sinScale; //Field offset: 0x48
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float sinCycle; //Field offset: 0x4C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float strength; //Field offset: 0x50
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int lineBlockPart; //Field offset: 0x54
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float lineBlockBlanking; //Field offset: 0x58
	private float m_LineBlockTime; //Field offset: 0x5C
	private float m_TimeLB; //Field offset: 0x60
	private float m_SinScale; //Field offset: 0x64
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float colorOffset; //Field offset: 0x68
	private float m_ColorOffset; //Field offset: 0x6C
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float vignetteSize; //Field offset: 0x70
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blackDegree; //Field offset: 0x74
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float whiteAlpha; //Field offset: 0x78
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float rollTransitionTime; //Field offset: 0x7C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float rgbTransitionTime; //Field offset: 0x80
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blackTransitionTime; //Field offset: 0x84
	private bool m_IsRoll; //Field offset: 0x88
	private bool m_IsTwist; //Field offset: 0x89
	private bool m_IsRGB; //Field offset: 0x8A
	private bool m_IsBlackSide; //Field offset: 0x8B
	private bool m_IsValueNoise; //Field offset: 0x8C
	private bool isPlay; //Field offset: 0x8D
	private int m_VerticalRollIntensityID; //Field offset: 0x90
	private int m_VerticalRollTimeID; //Field offset: 0x94
	private int m_SinCycleID; //Field offset: 0x98
	private int m_SinScaleID; //Field offset: 0x9C
	private int m_TimeLBID; //Field offset: 0xA0
	private int m_LineBlockPartID; //Field offset: 0xA4
	private int m_LineBlockBlankingID; //Field offset: 0xA8
	private int m_ColorOffsetID; //Field offset: 0xAC
	private int m_VignetteSizeID; //Field offset: 0xB0
	private int m_BlackDegreeID; //Field offset: 0xB4
	private int m_WhiteAlphaID; //Field offset: 0xB8
	private FlashData[] m_FlashArray; //Field offset: 0xC0
	private float m_CurrentTime; //Field offset: 0xC8
	private float timer; //Field offset: 0xCC
	private int m_StartIndex; //Field offset: 0xD0
	private int m_ArrayLength; //Field offset: 0xD4
	private LoopType m_UpdateType; //Field offset: 0xD8

	public override LoopType LoopType
	{
		 get { } //Length: 7
	}

	public Material material
	{
		 get { } //Length: 49
	}

	public TheEastNeverSleepsScreenEffect() { }

	public override LoopType get_LoopType() { }

	public Material get_material() { }

	public void Init() { }

	public void InitFlash(List<UInt32> uintList, List<Single> decimalList) { }

	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

	public override void OnUpdate() { }

	public void Pause() { }

	public void Play() { }

	public void ScreenDispresion(bool isOn) { }

	public void ScreenOldTV(bool isOn) { }

	public void ScreenScroll(bool isOn, bool isUp) { }

	public void ScreenSnowflake(bool isOn) { }

	public void ScreenTwist(bool isOn) { }

}

