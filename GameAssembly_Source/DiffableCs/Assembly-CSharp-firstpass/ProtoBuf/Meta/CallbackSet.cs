namespace ProtoBuf.Meta;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CallbackSet
{
	private readonly MetaType metaType; //Field offset: 0x10
	private MethodInfo beforeSerialize; //Field offset: 0x18
	private MethodInfo afterSerialize; //Field offset: 0x20
	private MethodInfo beforeDeserialize; //Field offset: 0x28
	private MethodInfo afterDeserialize; //Field offset: 0x30

	public MethodInfo AfterDeserialize
	{
		 get { } //Length: 5
		 set { } //Length: 58
	}

	public MethodInfo AfterSerialize
	{
		 get { } //Length: 5
		 set { } //Length: 58
	}

	public MethodInfo BeforeDeserialize
	{
		 get { } //Length: 5
		 set { } //Length: 58
	}

	public MethodInfo BeforeSerialize
	{
		 get { } //Length: 5
		 set { } //Length: 58
	}

	internal MethodInfo Item
	{
		internal get { } //Length: 242
	}

	public bool NonTrivial
	{
		 get { } //Length: 90
	}

	internal CallbackSet(MetaType metaType) { }

	internal static bool CheckCallbackParameters(TypeModel model, MethodInfo method) { }

	internal static Exception CreateInvalidCallbackSignature(MethodInfo method) { }

	public MethodInfo get_AfterDeserialize() { }

	public MethodInfo get_AfterSerialize() { }

	public MethodInfo get_BeforeDeserialize() { }

	public MethodInfo get_BeforeSerialize() { }

	internal MethodInfo get_Item(CallbackType callbackType) { }

	public bool get_NonTrivial() { }

	private MethodInfo SanityCheckCallback(TypeModel model, MethodInfo callback) { }

	public void set_AfterDeserialize(MethodInfo value) { }

	public void set_AfterSerialize(MethodInfo value) { }

	public void set_BeforeDeserialize(MethodInfo value) { }

	public void set_BeforeSerialize(MethodInfo value) { }

}

