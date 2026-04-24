namespace NexPlugin;

public static class Subscriber
{
	public const uint MAX_TOPIC_CONTENT_SIZE = 100; //Field offset: 0x0
	public const uint MAX_TIMELINE_CONTENT_SIZE = 100; //Field offset: 0x0
	public const uint MAX_FOLLOWING_SIZE = 20; //Field offset: 0x0
	public const uint NUM_RESERVED_TOPICS = 128; //Field offset: 0x0
	public const uint INVALID_RESERVED_TOPIC_NUM = 4294967295; //Field offset: 0x0
	public const uint MAX_GET_FOLLOWER_SIZE = 1000; //Field offset: 0x0
	public const uint MAX_CONTENT_MESSAGE_LEN = 140; //Field offset: 0x0
	public const uint MAX_CONTENT_BINARY_SIZE = 256; //Field offset: 0x0
	public const uint MAX_POST_CONTENT_TOPIC_SIZE = 10; //Field offset: 0x0
	public const uint MAX_GET_CONTENT_PARAMS_SIZE = 3; //Field offset: 0x0
	public const byte STATUS_KEY_SIZE = 8; //Field offset: 0x0
	public const uint MAX_STATUS_BINARY_SIZE = 128; //Field offset: 0x0
	public const uint MAX_GET_STATUS_USER_SIZE = 100; //Field offset: 0x0
	public const uint DEFAULT_RMC_INTERVAL = 5000; //Field offset: 0x0

}

