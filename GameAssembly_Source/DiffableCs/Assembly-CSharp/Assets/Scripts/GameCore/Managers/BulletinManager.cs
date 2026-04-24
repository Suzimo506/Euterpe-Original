namespace Assets.Scripts.GameCore.Managers;

public class BulletinManager : Singleton<BulletinManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string key; //Field offset: 0x10
		public BulletinManager <>4__this; //Field offset: 0x18
		public Action<Dictionary`2<String, List`1<Bulletin>>> callback; //Field offset: 0x20

		public <>c__DisplayClass4_0() { }

		internal void <RefreshBulletin>b__0(JObject r) { }

	}

	internal class Bulletin
	{
		[CompilerGenerated]
		private sealed class <LoadTexture>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private object <>2__current; //Field offset: 0x18
			public Bulletin <>4__this; //Field offset: 0x20
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
			public <LoadTexture>d__7(int <>1__state) { }

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

		public string uid; //Field offset: 0x10
		public string title; //Field offset: 0x18
		public string content; //Field offset: 0x20
		public string imageUrl; //Field offset: 0x28
		public bool force; //Field offset: 0x30
		public Texture2D texture; //Field offset: 0x38

		public bool isNew
		{
			 get { } //Length: 149
			 set { } //Length: 276
		}

		public Bulletin() { }

		public bool get_isNew() { }

		public void GetTexture(Action<Texture2D> callback) { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private IEnumerator LoadTexture(Action<Texture2D> callback) { }

		public void set_isNew(bool value) { }

	}

	[CompilerGenerated]
	private Dictionary<String, List`1<Bulletin>> <bulletins>k__BackingField; //Field offset: 0x10

	public private Dictionary<String, List`1<Bulletin>> bulletins
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public BulletinManager() { }

	private void BulletinAdd(JToken announce, Dictionary<String, List`1<Bulletin>> dic) { }

	[CompilerGenerated]
	public Dictionary<String, List`1<Bulletin>> get_bulletins() { }

	public void RefreshBulletin(Action<Dictionary`2<String, List`1<Bulletin>>> callback = null) { }

	[CompilerGenerated]
	private void set_bulletins(Dictionary<String, List`1<Bulletin>> value) { }

}

