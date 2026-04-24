namespace E7.Native;

public class NativeAudioPointer
{
	private string soundPath; //Field offset: 0x10
	private int startingIndex; //Field offset: 0x18
	private int amount; //Field offset: 0x1C
	private bool isUnloaded; //Field offset: 0x20
	[CompilerGenerated]
	private float <Length>k__BackingField; //Field offset: 0x24
	private int currentIndex; //Field offset: 0x28

	internal void AssertLoadedAndInitialized() { }

	public void Unload() { }

}

