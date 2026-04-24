//Type is in global namespace

[CreateAssetMenu]
public class STMWaveData : ScriptableObject
{
	public bool animateFromTimeDrawn; //Field offset: 0x18
	public STMWaveControl main; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool individualVertexControl; //Field offset: 0x28
	public STMWaveControl topLeft; //Field offset: 0x30
	public STMWaveControl topRight; //Field offset: 0x38
	public STMWaveControl bottomLeft; //Field offset: 0x40
	public STMWaveControl bottomRight; //Field offset: 0x48

	public STMWaveData() { }

}

