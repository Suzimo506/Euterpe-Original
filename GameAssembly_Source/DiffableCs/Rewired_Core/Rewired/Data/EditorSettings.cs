namespace Rewired.Data;

public class EditorSettings : ScriptableObject
{
	[CustomObfuscation]
	public int programVersion1; //Field offset: 0x18
	[CustomObfuscation]
	public int programVersion2; //Field offset: 0x1C
	[CustomObfuscation]
	public int programVersion3; //Field offset: 0x20
	[CustomObfuscation]
	public int programVersion4; //Field offset: 0x24
	[CustomObfuscation]
	public int dataVersion; //Field offset: 0x28

	public EditorSettings() { }

}

