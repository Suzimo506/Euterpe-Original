namespace PaperPlaneTools;

public class RateBoxPrefabScript : MonoBehaviour
{
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int minSessionCount; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int minCustomEventsCount; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float delayAfterInstallInHours; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float delayAfterLaunchInHours; //Field offset: 0x24
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float postponeCooldownInHours; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool requireInternetConnection; //Field offset: 0x2C
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string title; //Field offset: 0x30
	[Multiline]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string message; //Field offset: 0x38
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string rateButton; //Field offset: 0x40
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string postponeButton; //Field offset: 0x48
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string rejectButton; //Field offset: 0x50
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string appStoreAppId; //Field offset: 0x58
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string playMarketAppBundleId; //Field offset: 0x60
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool useIOSReview; //Field offset: 0x68
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject customUIWindow; //Field offset: 0x70
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool clearOnStart; //Field offset: 0x78
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool logDebugMessages; //Field offset: 0x79

	public RateBoxPrefabScript() { }

	private void Start() { }

}

