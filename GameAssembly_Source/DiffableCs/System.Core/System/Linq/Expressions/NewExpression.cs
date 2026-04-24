namespace System.Linq.Expressions;

[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NewExpression : Expression
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberInfo> <Members>k__BackingField; //Field offset: 0x20

	public ReadOnlyCollection<Expression> Arguments
	{
		 get { } //Length: 57
	}

	public ConstructorInfo Constructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ReadOnlyCollection<MemberInfo> Members
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ReadOnlyCollection<Expression> get_Arguments() { }

	[CompilerGenerated]
	public ConstructorInfo get_Constructor() { }

	[CompilerGenerated]
	public ReadOnlyCollection<MemberInfo> get_Members() { }

	public override Expression GetArgument(int index) { }

}

