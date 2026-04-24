//Type is in global namespace

public class MusicStageScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[CompilerGenerated]
	private Action<Boolean> DragHandler; //Field offset: 0x18
	public bool isDraging; //Field offset: 0x20

	public event Action<Boolean> DragHandler
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public MusicStageScrollView() { }

	[CompilerGenerated]
	public void add_DragHandler(Action<Boolean> value) { }

	public override void OnBeginDrag(PointerEventData data) { }

	public override void OnEndDrag(PointerEventData data) { }

	[CompilerGenerated]
	public void remove_DragHandler(Action<Boolean> value) { }

}

