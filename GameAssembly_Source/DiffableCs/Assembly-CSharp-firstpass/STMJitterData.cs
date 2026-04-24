//Type is in global namespace

[CreateAssetMenu]
public class STMJitterData : ScriptableObject
{
	public float amount; //Field offset: 0x18
	public bool perlin; //Field offset: 0x1C
	public float perlinTimeMulti; //Field offset: 0x20
	public AnimationCurve distance; //Field offset: 0x28
	public AnimationCurve distanceOverTime; //Field offset: 0x30
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float distanceOverTimeMulti; //Field offset: 0x38

	public STMJitterData() { }

}

