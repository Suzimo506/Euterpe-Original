namespace Assets.Scripts.PeroTools.UI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ContentSizeFitter : MonoBehaviour
{
	public int minSize; //Field offset: 0x18
	public int childSize; //Field offset: 0x1C
	public int gap; //Field offset: 0x20
	private RectTransform m_RectTransform; //Field offset: 0x28
	private ContentSizeFitter m_ContentSizeFitter; //Field offset: 0x30

	public ContentSizeFitter() { }

	[CompilerGenerated]
	private void <Awake>b__5_0(Event obj) { }

	private void Awake() { }

	private void Update() { }

}

