using Cpp2ILInjected;
using Discord;
using PeroTools2.Commons;

[Token(Token = "0x200006E")]
public class DiscordManager : Singleton<DiscordManager>
{
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x10")]
	private global::Discord.Discord m_Discord;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000303")]
	private ActivityManager m_ActivityManager;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x20")]
	private ApplicationManager m_ApplicationManager;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000305")]
	private bool m_Inited;

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x441080", Offset = "0x43F880", Length = "0x19A")]
	public void InitDiscord()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x440F30", Offset = "0x43F730", Length = "0x8B")]
	private void Destroy()
	{
	}

	[Address(RVA = "0x440FC0", Offset = "0x43F7C0", Length = "0xBE")]
	[Token(Token = "0x6000347")]
	private void DiscordRunCallbacks(float time)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x441220", Offset = "0x43FA20", Length = "0x447")]
	public void SetUpdateActivity(bool isPlaying, string levelInfo)
	{
	}

	[Address(RVA = "0x441670", Offset = "0x43FE70", Length = "0x38")]
	[Token(Token = "0x6000349")]
	public DiscordManager()
	{
		((Singleton<T>)(object)this)._002Ector();
	}
}
