namespace Assets.Scripts.PeroTools.Commons.Google;

public static class GoogleTranslation
{
	[CompilerGenerated]
	private sealed class <WaitForTranslation>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public WWW www; //Field offset: 0x20
		public Action<String> onTranslationReady; //Field offset: 0x28
		public string originalText; //Field offset: 0x30

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
		public <WaitForTranslation>d__2(int <>1__state) { }

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


	public static string ForceTranslate(string text, string languageCodeTo, string languageCodeFrom = "auto") { }

	private static string GetMd5WithString(string input) { }

	public static WWW GetTranslationWWW(string text, string languageCodeFrom, string languageCodeTo) { }

	public static string ParseTranslationResult(string html, string originalText) { }

	public static string TitleCase(string s) { }

	public static void Translate(string text, string languageCodeTo, Action<String> onTranslationReady, string languageCodeFrom = "auto") { }

	public static void Translate(String[] texts, string languageCodeTo, Action<String>[] onTranslationReadys, string languageCodeFrom = "auto") { }

	public static string UppercaseFirst(string s) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static IEnumerator WaitForTranslation(WWW www, Action<String> onTranslationReady, string originalText) { }

}

