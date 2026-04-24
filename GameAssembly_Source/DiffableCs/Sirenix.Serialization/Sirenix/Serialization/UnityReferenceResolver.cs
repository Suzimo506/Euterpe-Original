namespace Sirenix.Serialization;

public sealed class UnityReferenceResolver : IExternalIndexReferenceResolver, ICacheNotificationReceiver
{
	private Dictionary<Object, Int32> referenceIndexMapping; //Field offset: 0x10
	private List<Object> referencedUnityObjects; //Field offset: 0x18

	public UnityReferenceResolver() { }

	public UnityReferenceResolver(List<Object> referencedUnityObjects) { }

	public override bool CanReference(object value, out int index) { }

	public List<Object> GetReferencedUnityObjects() { }

	public void Reset() { }

	public void SetReferencedUnityObjects(List<Object> referencedUnityObjects) { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnClaimed() { }

	private override void Sirenix.Serialization.Utilities.ICacheNotificationReceiver.OnFreed() { }

	public override bool TryResolveReference(int index, out object value) { }

}

