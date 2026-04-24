namespace UnityEngine.Experimental.GlobalIllumination;

[UsedByNativeCode]
public struct LightDataGI
{
	public int instanceID; //Field offset: 0x0
	public LinearColor color; //Field offset: 0x4
	public LinearColor indirectColor; //Field offset: 0x14
	public Quaternion orientation; //Field offset: 0x24
	public Vector3 position; //Field offset: 0x34
	public float range; //Field offset: 0x40
	public float coneAngle; //Field offset: 0x44
	public float innerConeAngle; //Field offset: 0x48
	public float shape0; //Field offset: 0x4C
	public float shape1; //Field offset: 0x50
	public LightType type; //Field offset: 0x54
	public LightMode mode; //Field offset: 0x55
	public byte shadow; //Field offset: 0x56
	public FalloffType falloff; //Field offset: 0x57

	public void Init(ref DirectionalLight light) { }

	public void Init(ref PointLight light) { }

	public void Init(ref SpotLight light) { }

	public void Init(ref RectangleLight light) { }

	public void Init(ref DiscLight light) { }

	public void InitNoBake(int lightInstanceID) { }

}

