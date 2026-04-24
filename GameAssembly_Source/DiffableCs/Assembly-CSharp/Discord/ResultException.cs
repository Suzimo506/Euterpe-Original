namespace Discord;

public class ResultException : Exception
{
	public readonly Result Result; //Field offset: 0x88

	public ResultException(Result result) { }

}

