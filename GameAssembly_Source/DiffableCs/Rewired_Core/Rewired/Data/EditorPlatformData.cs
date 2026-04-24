namespace Rewired.Data;

public class EditorPlatformData : ScriptableObject
{
	internal class Platform
	{
		public TextAsset[] libraries; //Field offset: 0x10

		public Platform() { }

	}

	[CustomObfuscation]
	public Platform windowsStandalone; //Field offset: 0x18
	[CustomObfuscation]
	public Platform windowsStore; //Field offset: 0x20
	[CustomObfuscation]
	public Platform osxStandalone; //Field offset: 0x28
	[CustomObfuscation]
	public Platform linuxStandalone; //Field offset: 0x30
	[CustomObfuscation]
	public Platform webplayer; //Field offset: 0x38
	[CustomObfuscation]
	public Platform fallback; //Field offset: 0x40

	public EditorPlatformData() { }

	public TextAsset[] GetLibraries(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

	public Platform GetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform) { }

}

