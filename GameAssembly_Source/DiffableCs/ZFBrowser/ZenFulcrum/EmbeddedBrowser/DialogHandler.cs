namespace ZenFulcrum.EmbeddedBrowser;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DialogHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DialogCallback dialogCallback; //Field offset: 0x10
		public DialogHandler handler; //Field offset: 0x18
		public MenuCallback contextCallback; //Field offset: 0x20

		public <>c__DisplayClass3_0() { }

		internal void <Create>b__0(JSONNode args) { }

		internal void <Create>b__1(JSONNode args) { }

	}

	internal sealed class DialogCallback : MulticastDelegate
	{

		public DialogCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool affirm, string text1, string text2, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool affirm, string text1, string text2) { }

	}

	internal sealed class MenuCallback : MulticastDelegate
	{

		public MenuCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int commandId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int commandId) { }

	}

	protected static string dialogPage; //Field offset: 0x0
	protected Browser parentBrowser; //Field offset: 0x18
	protected Browser dialogBrowser; //Field offset: 0x20
	protected DialogCallback dialogCallback; //Field offset: 0x28
	protected MenuCallback contextCallback; //Field offset: 0x30

	public DialogHandler() { }

	public static DialogHandler Create(Browser parent, DialogCallback dialogCallback, MenuCallback contextCallback) { }

	public void HandleContextMenu(string menuJSON, int x, int y) { }

	public void HandleDialog(DialogType type, string text, string promptDefault = null) { }

	public void Hide() { }

	public void Show() { }

}

