//Type is in global namespace

[CreateAssetMenu]
public class STMFontData : ScriptableObject
{
	public Font font; //Field offset: 0x18
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int quality; //Field offset: 0x20
	public FilterMode filterMode; //Field offset: 0x24

	public STMFontData() { }

}

