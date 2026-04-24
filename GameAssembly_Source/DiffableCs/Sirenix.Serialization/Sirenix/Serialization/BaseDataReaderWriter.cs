namespace Sirenix.Serialization;

public abstract class BaseDataReaderWriter
{
	private NodeInfo[] nodes; //Field offset: 0x10
	private int nodesLength; //Field offset: 0x18

	[Obsolete]
	public override TwoWaySerializationBinder Binder
	{
		 get { } //Length: 288
		 set { } //Length: 228
	}

	protected NodeInfo CurrentNode
	{
		 get { } //Length: 201
	}

	public override bool IsInArrayNode
	{
		 get { } //Length: 69
	}

	protected int NodeDepth
	{
		 get { } //Length: 4
	}

	protected BaseDataReaderWriter() { }

	protected void ClearNodes() { }

	private void ExpandNodes() { }

	public override TwoWaySerializationBinder get_Binder() { }

	protected NodeInfo get_CurrentNode() { }

	public override bool get_IsInArrayNode() { }

	protected int get_NodeDepth() { }

	protected void PopArray() { }

	protected void PopNode(string name) { }

	protected void PushArray() { }

	protected void PushNode(NodeInfo node) { }

	protected void PushNode(string name, int id, Type type) { }

	public override void set_Binder(TwoWaySerializationBinder value) { }

}

