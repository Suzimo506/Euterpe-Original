//Type is in global namespace

public class AdditionPostProcessSettings
{
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float verticalRollIntensity; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool changeVerticalDir; //Field offset: 0x14
	[HideInInspector]
	public float verticalSpeed; //Field offset: 0x18
	[HideInInspector]
	public float verticalRollTime; //Field offset: 0x1C
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float sinScale; //Field offset: 0x20
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float sinCycle; //Field offset: 0x24
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float strength; //Field offset: 0x28
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int lineBlockPart; //Field offset: 0x2C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float lineBlockBlanking; //Field offset: 0x30
	[HideInInspector]
	public float lineBlockTime; //Field offset: 0x34
	[HideInInspector]
	public float timeLB; //Field offset: 0x38
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float colorOffset; //Field offset: 0x3C
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float vignetteSize; //Field offset: 0x40
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blackDegree; //Field offset: 0x44
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float whiteAlpha; //Field offset: 0x48
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float rollTransitionTime; //Field offset: 0x4C
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float rgbTransitionTime; //Field offset: 0x50
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float blackTransitionTime; //Field offset: 0x54
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool isRoll; //Field offset: 0x58
	public bool isTwist; //Field offset: 0x59
	public bool isRGB; //Field offset: 0x5A
	public bool isBlackSide; //Field offset: 0x5B
	public bool isValueNoise; //Field offset: 0x5C
	[HideInInspector]
	public bool isPlay; //Field offset: 0x5D

	public AdditionPostProcessSettings() { }

	public void Init() { }

	public void Pause() { }

	public void Play() { }

	public void ScreenDispresion(bool isOn) { }

	public void ScreenOldTV(bool isOn) { }

	public void ScreenScroll(bool isOn, bool isUp) { }

	public void ScreenSnowflake(bool isOn) { }

	public void ScreenTwist(bool isOn) { }

}

