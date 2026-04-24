namespace Sirenix.Serialization;

public struct NodeInfo
{
	public static readonly NodeInfo Empty; //Field offset: 0x0
	public readonly string Name; //Field offset: 0x0
	public readonly int Id; //Field offset: 0x8
	public readonly Type Type; //Field offset: 0x10
	public readonly bool IsArray; //Field offset: 0x18
	public readonly bool IsEmpty; //Field offset: 0x19

	private static NodeInfo() { }

	public NodeInfo(string name, int id, Type type, bool isArray) { }

	private NodeInfo(bool parameter) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(NodeInfo a, NodeInfo b) { }

	public static bool op_Inequality(NodeInfo a, NodeInfo b) { }

}

