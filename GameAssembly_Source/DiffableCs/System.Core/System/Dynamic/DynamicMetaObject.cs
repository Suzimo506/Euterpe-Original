namespace System.Dynamic;

public class DynamicMetaObject
{
	public static readonly DynamicMetaObject[] EmptyMetaObjects; //Field offset: 0x0
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <HasValue>k__BackingField; //Field offset: 0x28

	public Expression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool HasValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type LimitType
	{
		 get { } //Length: 137
	}

	public BindingRestrictions Restrictions
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type RuntimeType
	{
		 get { } //Length: 133
	}

	public object Value
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static DynamicMetaObject() { }

	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions) { }

	public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) { }

	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	public static DynamicMetaObject Create(object value, Expression expression) { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	[CompilerGenerated]
	public bool get_HasValue() { }

	public Type get_LimitType() { }

	[CompilerGenerated]
	public BindingRestrictions get_Restrictions() { }

	public Type get_RuntimeType() { }

	[CompilerGenerated]
	public object get_Value() { }

	public override IEnumerable<String> GetDynamicMemberNames() { }

}

