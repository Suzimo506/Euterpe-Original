namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
public sealed class TouchRegion : TouchInteractable
{
	private class FRXFXHqokRPtCdguiRPfHeTonBZN : UnityEvent<PointerEventData>
	{

		public FRXFXHqokRPtCdguiRPfHeTonBZN() { }

	}

	private class FxVzGsizoVHedFhxqSrwsrRLJxJb : UnityEvent<PointerEventData>
	{

		public FxVzGsizoVHedFhxqSrwsrRLJxJb() { }

	}

	private class ilMgVGfcSqACFFfWBfNCmErMyPpkA : UnityEvent<PointerEventData>
	{

		public ilMgVGfcSqACFFfWBfNCmErMyPpkA() { }

	}

	private class kvfemmkiHjeNSLKPVHFHHeAkxrGQB : UnityEvent<PointerEventData>
	{

		public kvfemmkiHjeNSLKPVHFHHeAkxrGQB() { }

	}

	private class OYrqBeKpQRXMShJIgUYoMcarGsbr : UnityEvent<PointerEventData>
	{

		public OYrqBeKpQRXMShJIgUYoMcarGsbr() { }

	}

	private class poDuegGsVYWVyRGXLgceZCidAORF : UnityEvent<PointerEventData>
	{

		public poDuegGsVYWVyRGXLgceZCidAORF() { }

	}

	private class zGxCFwEJhwwaOJotbtKykkfeeVwIA : UnityEvent<PointerEventData>
	{

		public zGxCFwEJhwwaOJotbtKykkfeeVwIA() { }

	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _hideAtRuntime; //Field offset: 0x128
	private poDuegGsVYWVyRGXLgceZCidAORF _onPointerDown; //Field offset: 0x130
	private ilMgVGfcSqACFFfWBfNCmErMyPpkA _onPointerUp; //Field offset: 0x138
	private FRXFXHqokRPtCdguiRPfHeTonBZN _onPointerEnter; //Field offset: 0x140
	private zGxCFwEJhwwaOJotbtKykkfeeVwIA _onPointerExit; //Field offset: 0x148
	private kvfemmkiHjeNSLKPVHFHHeAkxrGQB _onBeginDrag; //Field offset: 0x150
	private OYrqBeKpQRXMShJIgUYoMcarGsbr _onDrag; //Field offset: 0x158
	private FxVzGsizoVHedFhxqSrwsrRLJxJb _onEndDrag; //Field offset: 0x160

	public event UnityAction<PointerEventData> BeginDragEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> DragEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> EndDragEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> PointerDownEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> PointerEnterEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> PointerExitEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<PointerEventData> PointerUpEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public bool hideAtRuntime
	{
		 get { } //Length: 8
		 set { } //Length: 35
	}

	[CustomObfuscation]
	private TouchRegion() { }

	public void add_BeginDragEvent(UnityAction<PointerEventData> value) { }

	public void add_DragEvent(UnityAction<PointerEventData> value) { }

	public void add_EndDragEvent(UnityAction<PointerEventData> value) { }

	public void add_PointerDownEvent(UnityAction<PointerEventData> value) { }

	public void add_PointerEnterEvent(UnityAction<PointerEventData> value) { }

	public void add_PointerExitEvent(UnityAction<PointerEventData> value) { }

	public void add_PointerUpEvent(UnityAction<PointerEventData> value) { }

	[CustomObfuscation]
	internal virtual void Awake() { }

	public virtual void ClearValue() { }

	public bool get_hideAtRuntime() { }

	internal virtual void gINqkFDkYjaogQuxYMEmrDDhBrwQ(PointerEventData unnamed_param_0) { }

	internal virtual void gqXZxvvVhElvIzeezXrWFzPcCqCs() { }

	internal virtual void HiAkVMufLZrQVcmoSGyqihigMplu(PointerEventData unnamed_param_0) { }

	internal virtual void KOfVOAtKECGHVHofLlQTmOHNOSzpA(PointerEventData unnamed_param_0) { }

	internal virtual void MABaiLEfkRPRRoAmMkpEROzjULCo(PointerEventData unnamed_param_0) { }

	public void remove_BeginDragEvent(UnityAction<PointerEventData> value) { }

	public void remove_DragEvent(UnityAction<PointerEventData> value) { }

	public void remove_EndDragEvent(UnityAction<PointerEventData> value) { }

	public void remove_PointerDownEvent(UnityAction<PointerEventData> value) { }

	public void remove_PointerEnterEvent(UnityAction<PointerEventData> value) { }

	public void remove_PointerExitEvent(UnityAction<PointerEventData> value) { }

	public void remove_PointerUpEvent(UnityAction<PointerEventData> value) { }

	internal virtual void RxsbAbTtXxxXboMpepmVbsWbTMJF(PointerEventData unnamed_param_0) { }

	public void set_hideAtRuntime(bool value) { }

	internal virtual void TGXRTGfcXmefyaQRAmuPLICoabcTA(PointerEventData unnamed_param_0) { }

	internal virtual void wJGxodcvVBhPFcvjcosmWPUYkShF(PointerEventData unnamed_param_0) { }

}

