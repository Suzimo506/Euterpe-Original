namespace ProtoBuf;

public sealed class SerializationContext
{
	private static readonly SerializationContext default; //Field offset: 0x0
	private bool frozen; //Field offset: 0x10
	private object context; //Field offset: 0x18

	public object Context
	{
		 get { } //Length: 5
		 set { } //Length: 140
	}

	internal static SerializationContext Default
	{
		internal get { } //Length: 182
	}

	private static SerializationContext() { }

	public SerializationContext() { }

	internal void Freeze() { }

	public object get_Context() { }

	internal static SerializationContext get_Default() { }

	public void set_Context(object value) { }

	private void ThrowIfFrozen() { }

}

