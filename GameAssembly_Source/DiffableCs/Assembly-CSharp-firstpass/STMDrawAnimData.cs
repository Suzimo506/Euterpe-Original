//Type is in global namespace

[CreateAssetMenu]
public class STMDrawAnimData : ScriptableObject
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float animTime; //Field offset: 0x18
	public AnimationCurve animCurve; //Field offset: 0x20
	public Vector3 startScale; //Field offset: 0x28
	public Vector3 startOffset; //Field offset: 0x34
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float fadeTime; //Field offset: 0x40
	public AnimationCurve fadeCurve; //Field offset: 0x48
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Color32 startColor; //Field offset: 0x50

	public STMDrawAnimData() { }

}

