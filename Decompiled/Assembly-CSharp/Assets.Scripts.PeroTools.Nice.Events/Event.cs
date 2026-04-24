using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Actions;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[Token(Token = "0x20005EC")]
public abstract class Event : SerializedMonoBehaviour, IPlayable, IPreWarm
{
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40021AD")]
	private Group m_Group;

	[Token(Token = "0x40021AE")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasEnter;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40021AF")]
	protected EventInvoker m_Invoker;

	[Token(Token = "0x1700056B")]
	public List<IPlayable> playables
	{
		[Address(RVA = "0x979E50", Offset = "0x978650", Length = "0x1B")]
		[Token(Token = "0x6003A27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056C")]
	public float duration
	{
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x979E20", Offset = "0x978620", Length = "0x27")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003A28")]
	[Address(RVA = "0x979C30", Offset = "0x978430", Length = "0xCF")]
	public static EventInvoker OnEvent(GameObject gameObject, Type eventType)
	{
		return null;
	}

	[Token(Token = "0x6003A29")]
	[Address(RVA = "0x93B170", Offset = "0x939970", Length = "0x23")]
	public List<T> GetPlayables<T>() where T : IPlayable
	{
		return null;
	}

	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0x979D30", Offset = "0x978530", Length = "0xC")]
	public virtual void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x979A40", Offset = "0x978240", Length = "0x7")]
	[Token(Token = "0x6003A2C")]
	private void Awake()
	{
	}

	[Address(RVA = "0x979C20", Offset = "0x978420", Length = "0x7")]
	[Token(Token = "0x6003A2D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003A2E")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnEnter()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003A2F")]
	protected virtual void OnExecute()
	{
	}

	[Token(Token = "0x6003A30")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnExit()
	{
	}

	[Token(Token = "0x6003A31")]
	[Address(RVA = "0x979A50", Offset = "0x978250", Length = "0x82")]
	public void Enter()
	{
	}

	[Token(Token = "0x6003A32")]
	[Address(RVA = "0x979AE0", Offset = "0x9782E0", Length = "0xBF")]
	public void Execute()
	{
	}

	[Token(Token = "0x6003A33")]
	[Address(RVA = "0x979BA0", Offset = "0x9783A0", Length = "0x78")]
	public void Exit()
	{
	}

	[Address(RVA = "0x979D00", Offset = "0x978500", Length = "0x27")]
	[Token(Token = "0x6003A34")]
	public void Pause()
	{
	}

	[Address(RVA = "0x979D40", Offset = "0x978540", Length = "0x27")]
	[Token(Token = "0x6003A35")]
	public void Resume()
	{
	}

	[Address(RVA = "0x979D70", Offset = "0x978570", Length = "0xAC")]
	[Token(Token = "0x6003A36")]
	protected Event()
	{
	}
}
