namespace System.Collections.Concurrent;

[EventSource]
internal sealed class CDSCollectionETWBCLProvider : EventSource
{
	public static CDSCollectionETWBCLProvider Log; //Field offset: 0x2C927B4

	private static CDSCollectionETWBCLProvider() { }

	private CDSCollectionETWBCLProvider() { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

}

