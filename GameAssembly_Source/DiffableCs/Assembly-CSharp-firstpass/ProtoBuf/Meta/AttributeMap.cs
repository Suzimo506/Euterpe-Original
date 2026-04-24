namespace ProtoBuf.Meta;

internal abstract class AttributeMap
{
	private sealed class ReflectionAttributeMap : AttributeMap
	{
		private readonly Attribute attribute; //Field offset: 0x10

		public virtual Type AttributeType
		{
			 get { } //Length: 29
		}

		public virtual object Target
		{
			 get { } //Length: 5
		}

		public ReflectionAttributeMap(Attribute attribute) { }

		public virtual Type get_AttributeType() { }

		public virtual object get_Target() { }

		public virtual bool TryGet(string key, bool publicOnly, out object value) { }

	}


	public abstract Type AttributeType
	{
		 get { } //Length: 0
	}

	public abstract object Target
	{
		 get { } //Length: 0
	}

	protected AttributeMap() { }

	public static AttributeMap[] Create(TypeModel model, Type type, bool inherit) { }

	public static AttributeMap[] Create(TypeModel model, MemberInfo member, bool inherit) { }

	public static AttributeMap[] Create(TypeModel model, Assembly assembly) { }

	public abstract Type get_AttributeType() { }

	public abstract object get_Target() { }

	public abstract bool TryGet(string key, bool publicOnly, out object value) { }

	public bool TryGet(string key, out object value) { }

}

