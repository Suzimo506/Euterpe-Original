namespace ThinkingSDK.PC.Storage;

public class ThinkingSDKFileJson
{

	internal static int DeleteAllTrackingData(string prefix) { }

	internal static int DeleteBatchTrackingData(int batchSize, string prefix) { }

	internal static List<Dictionary`2<String, Object>> DequeueBatchTrackingData(int batchSize, string prefix) { }

	internal static int EnqueueTrackingData(Dictionary<String, Object> data, string prefix) { }

	internal static int EventAutoIncrementingID(string prefix) { }

	internal static int EventIndexID(string prefix) { }

	private static void IncreaseTrackingDataID(string prefix) { }

	private static void SaveEventIndexID(int indexID, string prefix) { }

}

