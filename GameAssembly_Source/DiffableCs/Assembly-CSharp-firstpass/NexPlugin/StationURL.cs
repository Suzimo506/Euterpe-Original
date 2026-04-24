namespace NexPlugin;

public class StationURL
{
	internal enum Flags
	{
		BehindNAT = 1,
		Public = 2,
		DetectedByNatCheck = 4,
		DetectedByNgs = 8,
	}

	internal enum URLType
	{
		unknown = 0,
		prudp = 1,
		prudps = 2,
		udp = 3,
	}


	public StationURL() { }

}

