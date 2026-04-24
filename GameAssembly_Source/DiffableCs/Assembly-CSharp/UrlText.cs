//Type is in global namespace

public class UrlText : Text, IPointerClickHandler, IEventSystemHandler
{
	private class HrefInfo
	{
		public int startIndex; //Field offset: 0x10
		public int endIndex; //Field offset: 0x14
		public string name; //Field offset: 0x18
		public readonly List<Rect> boxes; //Field offset: 0x20

		public HrefInfo() { }

	}

	internal sealed class VoidOnHrefClick : MulticastDelegate
	{

		public VoidOnHrefClick(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string hefName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string hefName) { }

	}

	public static readonly Regex s_HrefRegex; //Field offset: 0x0
	protected static readonly StringBuilder s_TextBuilder; //Field offset: 0x8
	public float lineW; //Field offset: 0xF8
	public float num; //Field offset: 0xFC
	private string m_OutputText; //Field offset: 0x100
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x108
	private readonly List<HrefInfo> m_HrefInfos; //Field offset: 0x110
	public VoidOnHrefClick onHrefClick; //Field offset: 0x118

	private static UrlText() { }

	public UrlText() { }

	protected override string GetOutputText(string outputText) { }

	private void HrefInfosIndexAdjust(int imgIndex) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	public virtual void SetVerticesDirty() { }

}

