namespace UnityEngine.Rendering;

internal class DebugActionDesc
{
	public List<String[]> buttonTriggerList; //Field offset: 0x10
	public string axisTrigger; //Field offset: 0x18
	public List<KeyCode[]> keyTriggerList; //Field offset: 0x20
	public DebugActionRepeatMode repeatMode; //Field offset: 0x28
	public float repeatDelay; //Field offset: 0x2C

	public DebugActionDesc() { }

}

