namespace Assets.Scripts.Structs;

public class UISetColor
{
	private static int s_OnHash; //Field offset: 0x0
	private static int s_OffHash; //Field offset: 0x4
	public List<GameObject> m_GameObjects; //Field offset: 0x10
	public List<Graphic> m_Graphics; //Field offset: 0x18
	public List<InputKeyBinding> m_InputBinding; //Field offset: 0x20
	public List<Animator> m_Animator; //Field offset: 0x28

	private static UISetColor() { }

	public UISetColor() { }

	public bool Contains(GameObject go) { }

	public void SetColor(Color c, float fadeTime = 0.1) { }

	public void SetEnable(bool enable) { }

}

