namespace Sirenix.Serialization;

public class LayerMaskFormatter : MinimalBaseFormatter<LayerMask>
{
	private static readonly Serializer<Int32> IntSerializer; //Field offset: 0x68340

	private static LayerMaskFormatter() { }

	public LayerMaskFormatter() { }

	protected virtual void Read(ref LayerMask value, IDataReader reader) { }

	protected virtual void Write(ref LayerMask value, IDataWriter writer) { }

}

