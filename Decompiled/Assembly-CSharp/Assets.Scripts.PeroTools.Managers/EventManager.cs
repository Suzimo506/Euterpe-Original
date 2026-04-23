using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000647")]
public class EventManager : Singleton<EventManager>
{
	[Token(Token = "0x2000BFD")]
	public delegate void EventCallFunc(params object[] args);

	[Token(Token = "0x2000BFE")]
	internal class EventParam
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003C00")]
		public List<object> paramList;

		[Address(RVA = "0x75B930", Offset = "0x75A130", Length = "0xAD")]
		[Token(Token = "0x6006013")]
		public EventParam(params object[] objs)
		{
		}
	}

	[Token(Token = "0x2000BFF")]
	public class EventTrigger
	{
		[Token(Token = "0x2000ED3")]
		public delegate void TriggerHandler(object sender, object reciever, params object[] args);

		[Token(Token = "0x4003C01")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003C02")]
		public object receiver;

		[Token(Token = "0x140000A0")]
		public event TriggerHandler trigger
		{
			[CompilerGenerated]
			[Address(RVA = "0x75BA80", Offset = "0x75A280", Length = "0x9E")]
			[Token(Token = "0x6006014")]
			add
			{
			}
			[CompilerGenerated]
			[Address(RVA = "0x75BB20", Offset = "0x75A320", Length = "0xF7")]
			[Token(Token = "0x6006015")]
			remove
			{
			}
		}

		[Token(Token = "0x6006016")]
		[Address(RVA = "0x75BA10", Offset = "0x75A210", Length = "0x2D")]
		internal void Play(params object[] args)
		{
		}

		[Address(RVA = "0x75BA40", Offset = "0x75A240", Length = "0x38")]
		[Token(Token = "0x6006017")]
		internal void Play(object r, params object[] args)
		{
		}

		[Address(RVA = "0x75B9E0", Offset = "0x75A1E0", Length = "0x25")]
		[Token(Token = "0x6006018")]
		internal EventTrigger Clear()
		{
			return null;
		}

		[Token(Token = "0x6006019")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public EventTrigger()
		{
		}
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400234E")]
	public readonly Dictionary<string, object> events;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400234F")]
	private readonly Dictionary<string, EventTrigger> m_EventTriggers;

	[Token(Token = "0x6003C84")]
	[Address(RVA = "0x75B6E0", Offset = "0x759EE0", Length = "0xE6")]
	public EventTrigger RegEvent(string uid, object receiver = null)
	{
		return null;
	}

	[Token(Token = "0x6003C85")]
	[Address(RVA = "0x75B7D0", Offset = "0x759FD0", Length = "0xA9")]
	public EventTrigger UnregEvent(string uid)
	{
		return null;
	}

	[Address(RVA = "0x75B5C0", Offset = "0x759DC0", Length = "0x117")]
	[Token(Token = "0x6003C86")]
	public void Invoke(string uid, params object[] args)
	{
	}

	[Address(RVA = "0x75B500", Offset = "0x759D00", Length = "0xBA")]
	[Token(Token = "0x6003C87")]
	public void InvokeReceiver(string uid, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x6003C88")]
	[Address(RVA = "0x75B880", Offset = "0x75A080", Length = "0xAD")]
	public EventManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
