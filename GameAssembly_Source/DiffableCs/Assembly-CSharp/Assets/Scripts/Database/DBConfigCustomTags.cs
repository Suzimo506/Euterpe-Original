namespace Assets.Scripts.Database;

public class DBConfigCustomTags : BaseDBConfigObject
{
	internal class CustomTagInfo : BaseDataObject
	{
		[CompilerGenerated]
		private sealed class <LoadImg>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public CustomTagInfo <>4__this; //Field offset: 0x20
			private string <cachePath>5__2; //Field offset: 0x28
			private string <cacheFileName>5__3; //Field offset: 0x30
			private bool <isLoadLocal>5__4; //Field offset: 0x38
			private UnityWebRequest <uwr>5__5; //Field offset: 0x40
			private DownloadHandlerTexture <texHandler>5__6; //Field offset: 0x48

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

		public string object_id; //Field offset: 0x20
		public DateTime created_at; //Field offset: 0x28
		public DateTime updated_at; //Field offset: 0x30
		public Dictionary<String, String> tag_name; //Field offset: 0x38
		public string tag_picture; //Field offset: 0x40
		public string icon_name; //Field offset: 0x48
		public List<String> music_list; //Field offset: 0x50
		public bool anchor_pattern; //Field offset: 0x58
		public int sort_key; //Field offset: 0x5C
		protected Texture2D m_Image; //Field offset: 0x60
		private Coroutine m_ImgCoroutine; //Field offset: 0x68
		private Action<Texture2D> m_Callback; //Field offset: 0x70

		public CustomTagInfo() { }

		public void GetIconAsync(Action<Texture2D> callback) { }

		public void InitCustomTag() { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private IEnumerator LoadImg() { }

	}

	private List<CustomTagInfo> m_Items; //Field offset: 0x38

	protected private List<CustomTagInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigCustomTags() { }

	public virtual void Deserialize(string str) { }

	protected List<CustomTagInfo> get_list() { }

	public CustomTagInfo GetCustomTagInfoByIndex(int index) { }

	public CustomTagInfo GetCustomTagInfoBySortKey(int sortIndex) { }

	private void set_list(List<CustomTagInfo> value) { }

}

