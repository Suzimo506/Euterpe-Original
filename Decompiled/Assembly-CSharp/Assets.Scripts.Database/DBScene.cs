using System.Collections.Generic;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200080E")]
public class DBScene : BaseDatabase
{
	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0x10")]
	private List<IPause> m_Pauses;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40029F7")]
	private List<IRelease> m_Releases;

	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0x20")]
	private List<IUpdate> m_Updates;

	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0x28")]
	private List<IUpdate> m_FixedUpdates;

	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0x30")]
	private UnityGameManager.Looper m_UpdateLooper;

	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x38")]
	private UnityGameManager.Looper m_FixedUpdateLooper;

	[Token(Token = "0x1700075A")]
	public List<IPause> Pauses
	{
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x102DDC0", Offset = "0x102C5C0", Length = "0x1C3")]
	[Token(Token = "0x60048E8")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60048E9")]
	[Address(RVA = "0x102E1A0", Offset = "0x102C9A0", Length = "0x1A9")]
	public void OnUpdate(float tick)
	{
	}

	[Token(Token = "0x60048EA")]
	[Address(RVA = "0x102DF90", Offset = "0x102C790", Length = "0x20A")]
	public void OnFixedUpdate(float tick)
	{
	}

	[Token(Token = "0x60048EB")]
	[Address(RVA = "0x102E350", Offset = "0x102CB50", Length = "0x2FA")]
	public override void Release()
	{
	}

	[Token(Token = "0x60048EC")]
	[Address(RVA = "0x102DCA0", Offset = "0x102C4A0", Length = "0x115")]
	public void AddUpdate(IUpdate update)
	{
	}

	[Token(Token = "0x60048ED")]
	[Address(RVA = "0x102E6B0", Offset = "0x102CEB0", Length = "0x72")]
	public void RemoveUpdate(IUpdate update)
	{
	}

	[Token(Token = "0x60048EE")]
	[Address(RVA = "0x102DAC0", Offset = "0x102C2C0", Length = "0xE7")]
	public void AddPause(IPause pause)
	{
	}

	[Token(Token = "0x60048EF")]
	[Address(RVA = "0x102E650", Offset = "0x102CE50", Length = "0x52")]
	public void RemovePause(IPause pause)
	{
	}

	[Address(RVA = "0x102DBB0", Offset = "0x102C3B0", Length = "0xE7")]
	[Token(Token = "0x60048F0")]
	public void AddRelease(IRelease release)
	{
	}

	[Token(Token = "0x60048F2")]
	[Address(RVA = "0x102E730", Offset = "0x102CF30", Length = "0xBE")]
	public DBScene()
	{
	}
}
