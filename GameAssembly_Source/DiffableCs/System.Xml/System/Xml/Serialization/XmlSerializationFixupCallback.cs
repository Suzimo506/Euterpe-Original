namespace System.Xml.Serialization;

public sealed class XmlSerializationFixupCallback : MulticastDelegate
{

	public XmlSerializationFixupCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object fixup, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	public override void Invoke(object fixup) { }

}

