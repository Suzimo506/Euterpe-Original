namespace System.Runtime.CompilerServices;

public sealed class RuntimeWrappedException : Exception
{
	private object m_wrappedException; //Field offset: 0x88

	public object WrappedException
	{
		 get { } //Length: 8
	}

	private RuntimeWrappedException(object thrownObject) { }

	internal RuntimeWrappedException(SerializationInfo info, StreamingContext context) { }

	internal RuntimeWrappedException() { }

	public object get_WrappedException() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

