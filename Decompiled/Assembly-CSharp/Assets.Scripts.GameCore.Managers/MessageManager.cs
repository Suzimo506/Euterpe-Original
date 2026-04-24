using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000745")]
public class MessageManager : SingletonMonoBehaviour<MessageManager>
{
	[Token(Token = "0x400266F")]
	[FieldOffset(Offset = "0x18")]
	private List<IData> m_Messages;

	[Token(Token = "0x4002670")]
	[FieldOffset(Offset = "0x20")]
	public GameObject pnlMessage;

	[Token(Token = "0x4002671")]
	public const string task = "task";

	[Token(Token = "0x4002672")]
	public const string achievement = "achievement";

	[Token(Token = "0x4002673")]
	public const string level = "level";

	[Token(Token = "0x4002674")]
	public const string exp = "exp";

	[Token(Token = "0x4002675")]
	public const string item = "item";

	[Token(Token = "0x4002676")]
	public const string unlockStage = "unlockStage";

	[Token(Token = "0x4002677")]
	public const string stageAchievement = "stage_achievement";

	[Token(Token = "0x4002678")]
	public const string unlockLevel = "unlockLevel";

	[Token(Token = "0x4002679")]
	public const string unlockRole = "unlockRole";

	[Token(Token = "0x400267A")]
	public const string unlockElfin = "unlockElfin";

	[Token(Token = "0x400267B")]
	public const string unlockLoading = "unlockLoading";

	[Token(Token = "0x400267C")]
	public const string unlockWelcome = "unlockWelcome";

	[Token(Token = "0x400267D")]
	public const string unlockHead = "unlockHead";

	[Token(Token = "0x400267E")]
	public const string rank = "rank";

	[Token(Token = "0x400267F")]
	[HideInInspector]
	public static int maxExp;

	[Token(Token = "0x17000664")]
	public List<IData> messages
	{
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000665")]
	public bool available
	{
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x6D9BA0", Offset = "0x6D83A0", Length = "0x105")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004414")]
	[Address(RVA = "0x6D9230", Offset = "0x6D7A30", Length = "0x5D")]
	public void ResetData()
	{
	}

	[Token(Token = "0x6004415")]
	[Address(RVA = "0x6D8630", Offset = "0x6D6E30", Length = "0x191")]
	private void Init()
	{
	}

	[Address(RVA = "0x6D87D0", Offset = "0x6D6FD0", Length = "0xA2")]
	[Token(Token = "0x6004416")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004417")]
	[Address(RVA = "0x6D8880", Offset = "0x6D7080", Length = "0x129")]
	private void OnReward(object sender, object rev, params object[] pars)
	{
	}

	[Token(Token = "0x6004418")]
	[Address(RVA = "0x6D8590", Offset = "0x6D6D90", Length = "0x94")]
	private void CheckMessagesRef()
	{
	}

	[Address(RVA = "0x6D9290", Offset = "0x6D7A90", Length = "0x889")]
	[Token(Token = "0x6004419")]
	public void Send(string type, params object[] msg)
	{
	}

	[Token(Token = "0x600441A")]
	[Address(RVA = "0x6D89B0", Offset = "0x6D71B0", Length = "0x877")]
	public void Receive(string type, params object[] msg)
	{
	}

	[Address(RVA = "0x6D9B60", Offset = "0x6D8360", Length = "0x38")]
	[Token(Token = "0x600441B")]
	public MessageManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
