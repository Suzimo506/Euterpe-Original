namespace Sirenix.Serialization.Utilities;

public interface ICacheNotificationReceiver
{

	public void OnClaimed() { }

	public void OnFreed() { }

}

