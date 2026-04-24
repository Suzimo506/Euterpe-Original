using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000655")]
public class UnityGameManager : SingletonMonoBehaviour<UnityGameManager>
{
	[Token(Token = "0x2000C07")]
	public class Looper
	{
		[Token(Token = "0x4003C0F")]
		public const float infinite = float.MaxValue;

		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003C12")]
		public bool isPause;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003C13")]
		private readonly UnityAction<float> m_Action;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003C14")]
		private readonly float m_LoopTime;

		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4003C15")]
		private float m_RunTime;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003C16")]
		private readonly float m_DeltaTime;

		[Token(Token = "0x17000AAF")]
		public string uid
		{
			[CompilerGenerated]
			[Token(Token = "0x600602C")]
			[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600602B")]
			[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000AB0")]
		public LoopType type
		{
			[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600602E")]
			get
			{
				return default(LoopType);
			}
			[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
			[Token(Token = "0x600602D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000AB1")]
		public bool isActive
		{
			[Token(Token = "0x600602F")]
			[Address(RVA = "0x745940", Offset = "0x744140", Length = "0xD")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x7458C0", Offset = "0x7440C0", Length = "0x7F")]
		[Token(Token = "0x6006030")]
		public Looper(string u, UnityAction<float> a, LoopType t, float time = float.MaxValue)
		{
		}

		[Token(Token = "0x6006031")]
		[Address(RVA = "0x745860", Offset = "0x744060", Length = "0x5E")]
		public void Loop()
		{
		}
	}

	[Token(Token = "0x2000C08")]
	public enum LoopType
	{
		[Token(Token = "0x4003C18")]
		Update,
		[Token(Token = "0x4003C19")]
		FixedUpdate,
		[Token(Token = "0x4003C1A")]
		LateUpdate
	}

	[Token(Token = "0x40023A4")]
	public const string touches = "Touches";

	[Token(Token = "0x40023A5")]
	public const string keys = "Keys";

	[Token(Token = "0x40023A6")]
	public const string showFps = "ShowFps";

	[Token(Token = "0x40023A7")]
	public const string updateTimers = "UpdateTimers";

	[Token(Token = "0x40023A8")]
	public const string fixedTimer = "FixedTimers";

	[Token(Token = "0x40023A9")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<Looper> m_UpdateLoops;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40023AA")]
	private readonly List<Looper> m_FixedLoops;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40023AB")]
	private readonly List<Looper> m_LateLoops;

	[Token(Token = "0x40023AC")]
	[FieldOffset(Offset = "0x40")]
	private Looper m_LoopFixedUpdate;

	[Token(Token = "0x40023AD")]
	[FieldOffset(Offset = "0x48")]
	private Looper m_LoopUpdate;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40023AE")]
	private Looper m_UnregLooper;

	[Token(Token = "0x170005C1")]
	public Transform persistenceRoot
	{
		[Token(Token = "0x6003D14")]
		[Address(RVA = "0x768740", Offset = "0x766F40", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000060")]
	public event Action onApplicationQuit
	{
		[Token(Token = "0x6003D10")]
		[Address(RVA = "0x7686A0", Offset = "0x766EA0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003D11")]
		[Address(RVA = "0x7687F0", Offset = "0x766FF0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000061")]
	public event Action<bool> onApplicationFocusChange
	{
		[CompilerGenerated]
		[Token(Token = "0x6003D12")]
		[Address(RVA = "0x768600", Offset = "0x766E00", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x768750", Offset = "0x766F50", Length = "0x9E")]
		[Token(Token = "0x6003D13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003D15")]
	[Address(RVA = "0x7682C0", Offset = "0x766AC0", Length = "0xB6")]
	public Looper RegLoop(UnityAction<float> action, LoopType type = LoopType.FixedUpdate, float loopTime = float.MaxValue)
	{
		return null;
	}

	[Token(Token = "0x6003D16")]
	[Address(RVA = "0x768120", Offset = "0x766920", Length = "0x19C")]
	public Looper RegLoop(string uid, UnityAction<float> action, LoopType type = LoopType.FixedUpdate, float loopTime = float.MaxValue)
	{
		return null;
	}

	[Address(RVA = "0x768380", Offset = "0x766B80", Length = "0x1A3")]
	[Token(Token = "0x6003D17")]
	public void UnregLoop(string uid)
	{
	}

	[Token(Token = "0x6003D18")]
	[Address(RVA = "0x767D10", Offset = "0x766510", Length = "0xE9")]
	public void LoopFixedUpdate()
	{
	}

	[Address(RVA = "0x767EA0", Offset = "0x7666A0", Length = "0x111")]
	[Token(Token = "0x6003D19")]
	public void LoopLateUpdate()
	{
	}

	[Address(RVA = "0x767FC0", Offset = "0x7667C0", Length = "0xE9")]
	[Token(Token = "0x6003D1A")]
	public void LoopUpdate()
	{
	}

	[Address(RVA = "0x768100", Offset = "0x766900", Length = "0x11")]
	[Token(Token = "0x6003D1B")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6003D1C")]
	[Address(RVA = "0x767FC0", Offset = "0x7667C0", Length = "0xE9")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D1D")]
	[Address(RVA = "0x767D10", Offset = "0x766510", Length = "0xE9")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003D1E")]
	[Address(RVA = "0x767E90", Offset = "0x766690", Length = "0x7")]
	private void LateUpdate()
	{
	}

	[Address(RVA = "0x767E00", Offset = "0x766600", Length = "0x8A")]
	[Token(Token = "0x6003D1F")]
	private void Init()
	{
	}

	[Address(RVA = "0x7680B0", Offset = "0x7668B0", Length = "0x4F")]
	[Token(Token = "0x6003D20")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Address(RVA = "0x768530", Offset = "0x766D30", Length = "0xC8")]
	[Token(Token = "0x6003D21")]
	public UnityGameManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
