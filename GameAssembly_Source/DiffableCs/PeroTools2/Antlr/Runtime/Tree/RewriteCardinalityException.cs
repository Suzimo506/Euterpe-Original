namespace Antlr.Runtime.Tree;

public class RewriteCardinalityException : Exception
{
	private readonly string _elementDescription; //Field offset: 0x88

	public RewriteCardinalityException() { }

	public RewriteCardinalityException(string elementDescription) { }

	public RewriteCardinalityException(string elementDescription, Exception innerException) { }

	public RewriteCardinalityException(string message, string elementDescription) { }

	public RewriteCardinalityException(string message, string elementDescription, Exception innerException) { }

}

