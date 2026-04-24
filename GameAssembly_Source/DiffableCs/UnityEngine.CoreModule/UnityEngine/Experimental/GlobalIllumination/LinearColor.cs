namespace UnityEngine.Experimental.GlobalIllumination;

public struct LinearColor
{
	private float m_red; //Field offset: 0x0
	private float m_green; //Field offset: 0x4
	private float m_blue; //Field offset: 0x8
	private float m_intensity; //Field offset: 0xC

	public static LinearColor Black() { }

	public static LinearColor Convert(Color color, float intensity) { }

}

