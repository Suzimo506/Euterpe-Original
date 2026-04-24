namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal class ObjectInstanceTracker : IDisposable
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class Wrapper : IDisposable
	{
		public readonly T instance; //Field offset: 0x0
		public readonly uint instanceId; //Field offset: 0x0
		private readonly ObjectInstanceTracker ghagLAwYFHFxiTZcdHtaobzLXtnS; //Field offset: 0x0
		private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x0

		public Wrapper`1(T unnamed_param_0) { }

		public Wrapper`1(T unnamed_param_0, ObjectInstanceTracker unnamed_param_1) { }

		public override void Dispose() { }

		protected override void Dispose(bool disposing) { }

		protected virtual void Finalize() { }

	}

	private static ObjectInstanceTracker phvDRCYtoXzLLFgPKMuijOiWXkPb; //Field offset: 0x0
	private readonly Dictionary<UInt32, Object> tdJnNxQBlEdKVhmdEdLwyyxwjMSGA; //Field offset: 0x10
	private readonly object kKCFIiwJCHZzwTXmWFucKXUfOglK; //Field offset: 0x18
	private uint tPXUXQpyDqGkiolGiYmsnUSntLzp; //Field offset: 0x20
	private int FXgaaSzYQVIGCXhveEdygcvBNqgtA; //Field offset: 0x24
	private bool UydKsokIZZHxYyQfHCollqECzyyO; //Field offset: 0x28

	public static ObjectInstanceTracker Default
	{
		 get { } //Length: 240
	}

	public ObjectInstanceTracker() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public static ObjectInstanceTracker get_Default() { }

	private void joQVvWWtTvrRWEZzmEEADSrKturu(bool unnamed_param_0) { }

	public uint Register(object instance) { }

	public bool TryGetInstance(uint instanceId, out T instance) { }

	public void Unregister(uint instanceId) { }

}

