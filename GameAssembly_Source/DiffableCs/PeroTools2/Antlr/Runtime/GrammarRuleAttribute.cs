namespace Antlr.Runtime;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class GrammarRuleAttribute : Attribute
{
	private readonly string _name; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 5
	}

	public GrammarRuleAttribute(string name) { }

	public string get_Name() { }

}

