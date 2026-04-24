namespace Spine.Unity;

[CreateAssetMenu]
public class EventDataReferenceAsset : ScriptableObject
{
	private const bool QuietSkeletonData = True; //Field offset: 0x0
	[SerializeField]
	protected SkeletonDataAsset skeletonDataAsset; //Field offset: 0x18
	[SerializeField]
	[SpineEvent(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected string eventName; //Field offset: 0x20
	private EventData eventData; //Field offset: 0x28

	public EventData EventData
	{
		 get { } //Length: 35
	}

	public EventDataReferenceAsset() { }

	public EventData get_EventData() { }

	public void Initialize() { }

	public static EventData op_Implicit(EventDataReferenceAsset asset) { }

}

