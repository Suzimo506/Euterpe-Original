using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Datas;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000752")]
public class TaskManager : Singleton<TaskManager>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40026B7")]
	private SingletonDataObject m_Task;

	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0x20")]
	private DateTime m_RefreshTime;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40026B9")]
	private readonly TimeSpan m_RefreshGap;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40026BA")]
	private int m_MusicLevel;

	[Token(Token = "0x17000675")]
	public List<string> tasks
	{
		[CompilerGenerated]
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000676")]
	public TimeSpan refreshGap
	{
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x7D8210", Offset = "0x7D6A10", Length = "0x7D")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Token(Token = "0x17000677")]
	private int m_State
	{
		[Address(RVA = "0x7D8130", Offset = "0x7D6930", Length = "0xDF")]
		[Token(Token = "0x60044DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60044DD")]
	[Address(RVA = "0x7D74B0", Offset = "0x7D5CB0", Length = "0x183")]
	private void Init()
	{
	}

	[Token(Token = "0x60044DE")]
	[Address(RVA = "0x7D4350", Offset = "0x7D2B50", Length = "0x8B")]
	private void Destroy()
	{
	}

	[Token(Token = "0x60044DF")]
	[Address(RVA = "0x7D7640", Offset = "0x7D5E40", Length = "0xD5")]
	private void OnTimeChanged(DateTime time)
	{
	}

	[Token(Token = "0x60044E0")]
	[Address(RVA = "0x7D77F0", Offset = "0x7D5FF0", Length = "0x72C")]
	public void RefreshTasks()
	{
	}

	[Token(Token = "0x60044E1")]
	[Address(RVA = "0x7D7F20", Offset = "0x7D6720", Length = "0x19C")]
	private void Reward(string uid)
	{
	}

	[Token(Token = "0x60044E2")]
	[Address(RVA = "0x7D7720", Offset = "0x7D5F20", Length = "0xCA")]
	public void RefreshTaskTime()
	{
	}

	[Token(Token = "0x60044E3")]
	[Address(RVA = "0x7D71F0", Offset = "0x7D59F0", Length = "0x2BF")]
	public void Do(bool isSucceed, bool isExit = false)
	{
	}

	[Token(Token = "0x60044E4")]
	[Address(RVA = "0x7D43E0", Offset = "0x7D2BE0", Length = "0xF30")]
	private void Do1(string musicUid, bool isSucceed, bool isExit)
	{
	}

	[Address(RVA = "0x7D5320", Offset = "0x7D3B20", Length = "0xFF3")]
	[Token(Token = "0x60044E5")]
	private void Do2(string musicUid, bool isSucceed, bool isExit)
	{
	}

	[Token(Token = "0x60044E6")]
	[Address(RVA = "0x7D6320", Offset = "0x7D4B20", Length = "0xA69")]
	private void Do3(string musicUid, bool isSucceed, bool isExit)
	{
	}

	[Token(Token = "0x60044E7")]
	[Address(RVA = "0x7D6D90", Offset = "0x7D5590", Length = "0x45E")]
	private void Do(string passKey, Func<int, bool> targetFunc, string musicUid, bool isSucceed, int targetValue = -1, int passTarget = 2, int level = -1, string uid = "", bool isExit = false)
	{
	}

	[Token(Token = "0x60044E8")]
	[Address(RVA = "0x7D80C0", Offset = "0x7D68C0", Length = "0x61")]
	public TaskManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
