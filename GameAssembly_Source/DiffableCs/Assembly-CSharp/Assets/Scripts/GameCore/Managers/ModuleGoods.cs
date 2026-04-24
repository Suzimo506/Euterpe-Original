namespace Assets.Scripts.GameCore.Managers;

public class ModuleGoods
{
	[CompilerGenerated]
	private sealed class <LoadImg>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ModuleGoods <>4__this; //Field offset: 0x20
		public Action<Texture2D> callback; //Field offset: 0x28
		private string <cachePath>5__2; //Field offset: 0x30
		private string <cacheFileName>5__3; //Field offset: 0x38
		private bool <isLoadLocal>5__4; //Field offset: 0x40
		private UnityWebRequest <uwr>5__5; //Field offset: 0x48
		private DownloadHandlerTexture <texHandler>5__6; //Field offset: 0x50

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <LoadImg>d__14(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public string name; //Field offset: 0x10
	public string pic_url; //Field offset: 0x18
	private Texture2D m_Image; //Field offset: 0x20
	private bool m_IsLocal; //Field offset: 0x28
	public List<ShopInfo> languages; //Field offset: 0x30
	[CompilerGenerated]
	private string <picFileName>k__BackingField; //Field offset: 0x38

	public Texture2D image
	{
		 get { } //Length: 5
	}

	public private string picFileName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public ModuleGoods() { }

	public void AsyncGetImg(Action<Texture2D> callback = null) { }

	public Texture2D get_image() { }

	[CompilerGenerated]
	public string get_picFileName() { }

	public ShopInfo GetShopImgInfoByLanguage(string language, bool failGetFirst = false) { }

	public void Init() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator LoadImg(Action<Texture2D> callback = null) { }

	[CompilerGenerated]
	private void set_picFileName(string value) { }

}

