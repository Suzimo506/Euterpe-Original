namespace LitJson;

internal class FsmContext
{
	public bool Return; //Field offset: 0x10
	public int NextState; //Field offset: 0x14
	public Lexer L; //Field offset: 0x18
	public int StateStack; //Field offset: 0x20

	public FsmContext() { }

}

