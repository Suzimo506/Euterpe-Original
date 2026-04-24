namespace Google.Protobuf;

public interface ICustomDiagnosticMessage : IMessage
{

	public string ToDiagnosticString() { }

}

