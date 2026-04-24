//Type is in global namespace

public class DiscordManager : Singleton<DiscordManager>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UpdateActivityHandler <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SetUpdateActivity>b__7_0(Result result) { }

	}

	private Discord m_Discord; //Field offset: 0x10
	private ActivityManager m_ActivityManager; //Field offset: 0x18
	private ApplicationManager m_ApplicationManager; //Field offset: 0x20
	private bool m_Inited; //Field offset: 0x28

	public DiscordManager() { }

	private void Destroy() { }

	private void DiscordRunCallbacks(float time) { }

	public void InitDiscord() { }

	public void SetUpdateActivity(bool isPlaying, string levelInfo) { }

}

