namespace UnityEngine.AI;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public static class NavMesh
{
	internal sealed class OnNavMeshPreUpdate : MulticastDelegate
	{

		public OnNavMeshPreUpdate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static OnNavMeshPreUpdate onPreUpdate; //Field offset: 0x2C927B4

	[RequiredByNativeCode]
	private static void Internal_CallOnNavMeshPreUpdate() { }

}

