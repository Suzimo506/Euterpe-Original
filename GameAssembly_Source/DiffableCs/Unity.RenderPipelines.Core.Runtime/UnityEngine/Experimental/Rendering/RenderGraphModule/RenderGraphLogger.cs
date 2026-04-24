namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphLogger
{
	private StringBuilder m_Builder; //Field offset: 0x10
	private int m_CurrentIndentation; //Field offset: 0x18

	public RenderGraphLogger() { }

	public void DecrementIndentation(int value) { }

	public string GetLog() { }

	public void IncrementIndentation(int value) { }

	public void Initialize() { }

	public void LogLine(string format, Object[] args) { }

}

