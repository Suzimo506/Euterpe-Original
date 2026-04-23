using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using GameLogic;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200073A")]
public abstract class AbstractFeverManager : BaseManager, IPause
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002627")]
	protected decimal m_InvokeTime;

	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0x20")]
	protected decimal m_InvokeEndTime;

	[Token(Token = "0x4002629")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_IsPause;

	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0x38")]
	protected UnityGameManager.Looper m_FeverLooper;

	[Token(Token = "0x400262B")]
	[FieldOffset(Offset = "0x40")]
	protected bool m_InvokeFever;

	[Token(Token = "0x400262C")]
	[FieldOffset(Offset = "0x44")]
	protected int m_FeverValue;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400262F")]
	protected int m_MaxFaverValue;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002630")]
	protected string m_FeverAudio;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002631")]
	private bool m_IgnoreFeverAdd;

	[Token(Token = "0x1700064A")]
	public bool IgnoreFeverAdd
	{
		[Address(RVA = "0x5B52F0", Offset = "0x5B3AF0", Length = "0x4")]
		[Token(Token = "0x6004333")]
		set
		{
		}
	}

	[Token(Token = "0x1700064B")]
	public int InvokeFeverCount
	{
		[CompilerGenerated]
		[Token(Token = "0x6004334")]
		[Address(RVA = "0x6F3B00", Offset = "0x6F2300", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x7044C0", Offset = "0x702CC0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004335")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700064C")]
	public bool IsAutoFever
	{
		[Token(Token = "0x6004336")]
		[CompilerGenerated]
		[Address(RVA = "0x782C70", Offset = "0x781470", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x629080", Offset = "0x627880", Length = "0x4")]
		[Token(Token = "0x6004337")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700064D")]
	public virtual bool IsActivateFever
	{
		[Address(RVA = "0x782BF0", Offset = "0x7813F0", Length = "0x7E")]
		[Token(Token = "0x6004338")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700064E")]
	public bool IsTouhouConvert
	{
		[Address(RVA = "0x782CF0", Offset = "0x7814F0", Length = "0x11")]
		[Token(Token = "0x6004339")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700064F")]
	public virtual int feverValue
	{
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x782D10", Offset = "0x781510", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000650")]
	public decimal feverStartTime
	{
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x674C60", Offset = "0x673460", Length = "0xB")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x17000651")]
	public decimal feverEndTime
	{
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x7322C0", Offset = "0x730AC0", Length = "0xB")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x17000652")]
	public bool IsFeverGod
	{
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x782C80", Offset = "0x781480", Length = "0x64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000653")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x600434B")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x7824C0", Offset = "0x780CC0", Length = "0xD7")]
	[Token(Token = "0x600433D")]
	protected virtual void FeverEnd()
	{
	}

	[Token(Token = "0x600433E")]
	[Address(RVA = "0x782A70", Offset = "0x781270", Length = "0xE7")]
	protected virtual void PlayFeverAudio()
	{
	}

	[Token(Token = "0x600433F")]
	[Address(RVA = "0x782160", Offset = "0x780960", Length = "0xBA")]
	public virtual void AddFever(ref MusicData md, int result)
	{
	}

	[Token(Token = "0x6004340")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void AddFever(int value, bool forTest = false)
	{
	}

	[Token(Token = "0x6004341")]
	[Address(RVA = "0x782220", Offset = "0x780A20", Length = "0x11D")]
	protected virtual void AddFever(int value)
	{
	}

	[Token(Token = "0x6004342")]
	[Address(RVA = "0x7826D0", Offset = "0x780ED0", Length = "0x236")]
	public virtual bool InvokeFever()
	{
		return default(bool);
	}

	[Token(Token = "0x6004344")]
	[Address(RVA = "0x7825A0", Offset = "0x780DA0", Length = "0x12C")]
	public virtual float GetFeverNormalize()
	{
		return default(float);
	}

	[Token(Token = "0x6004345")]
	[Address(RVA = "0x782340", Offset = "0x780B40", Length = "0xE7")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004346")]
	[Address(RVA = "0x782430", Offset = "0x780C30", Length = "0x8D")]
	private void Clean()
	{
	}

	[Token(Token = "0x6004347")]
	[Address(RVA = "0x782910", Offset = "0x781110", Length = "0x14E")]
	protected virtual void OnUpdate(float _)
	{
	}

	[Token(Token = "0x6004348")]
	[Address(RVA = "0x782B60", Offset = "0x781360", Length = "0x7A")]
	public override void Release()
	{
	}

	[Address(RVA = "0x782A60", Offset = "0x781260", Length = "0x5")]
	[Token(Token = "0x6004349")]
	public virtual void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x782BE0", Offset = "0x7813E0", Length = "0x5")]
	[Token(Token = "0x600434A")]
	public virtual void Resume()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600434C")]
	protected AbstractFeverManager()
	{
	}
}
