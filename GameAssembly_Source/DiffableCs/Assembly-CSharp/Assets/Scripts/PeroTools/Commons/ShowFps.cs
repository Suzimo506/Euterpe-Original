namespace Assets.Scripts.PeroTools.Commons;

public class ShowFps : SingletonMonoBehaviour<ShowFps>
{
	public float updateInterval; //Field offset: 0x18
	private double m_LastInterval; //Field offset: 0x20
	private int m_Frames; //Field offset: 0x28
	private float m_CurrFps; //Field offset: 0x2C
	private GUIStyle m_Style; //Field offset: 0x30

	public ShowFps() { }

	private void OnGUI() { }

	private void Start() { }

	private void Update() { }

}

