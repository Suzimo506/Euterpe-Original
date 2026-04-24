namespace Google.Protobuf;

public interface IMessage
{

	public MessageDescriptor Descriptor
	{
		 get { } //Length: 0
	}

	public int CalculateSize() { }

	public MessageDescriptor get_Descriptor() { }

	public void MergeFrom(CodedInputStream input) { }

	public void WriteTo(CodedOutputStream output) { }

}

