namespace Rewired.Data;

public class RuntimeData : ScriptableObject
{
	[CustomObfuscation]
	public Platform platform; //Field offset: 0x18
	[CustomObfuscation]
	public WebplayerPlatform webplayerPlatform; //Field offset: 0x1C
	[CustomObfuscation]
	public EditorPlatform editorPlatform; //Field offset: 0x20
	[CustomObfuscation]
	public List<TextAsset> libraries; //Field offset: 0x28

	public RuntimeData() { }

	public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries) { }

}

