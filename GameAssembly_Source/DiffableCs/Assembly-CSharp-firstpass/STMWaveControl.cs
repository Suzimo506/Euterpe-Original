//Type is in global namespace

public class STMWaveControl
{
	public AnimationCurve curveX; //Field offset: 0x10
	public AnimationCurve curveY; //Field offset: 0x18
	public AnimationCurve curveZ; //Field offset: 0x20
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float offset; //Field offset: 0x28
	public Vector3 speed; //Field offset: 0x2C
	public Vector3 strength; //Field offset: 0x38
	public Vector3 density; //Field offset: 0x44

	public STMWaveControl() { }

}

