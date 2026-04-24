namespace UnityEngine.ResourceManagement.Diagnostics;

public class DiagnosticEventCollector : MonoBehaviour
{
	private static DiagnosticEventCollector s_Collector; //Field offset: 0x2C927B4

	public static Guid PlayerConnectionGuid
	{
		 get { } //Length: 36
	}

	public DiagnosticEventCollector() { }

	public static DiagnosticEventCollector FindOrCreateGlobalInstance() { }

	public static Guid get_PlayerConnectionGuid() { }

	public void PostEvent(DiagnosticEvent diagnosticEvent) { }

	public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create) { }

	public void UnregisterEventHandler(Action<DiagnosticEvent> handler) { }

}

