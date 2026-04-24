using System.Collections.Generic;
using Cpp2ILInjected;
using MDAC;
using UnityEngine;

namespace Assets.Scripts.GameCore.Controller.Configs;

[CreateAssetMenu]
[Token(Token = "0x200077A")]
public class StandloneCtrlConfig : ControllerConfig
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002791")]
	public string CurrentProposal;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002792")]
	public int keyCustomCount;

	[Token(Token = "0x4002793")]
	[FieldOffset(Offset = "0x64")]
	public int keyFeverCustomCount;

	[SerializeField]
	[Token(Token = "0x4002794")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<string, Dictionary<string, List<KeyCode>>> m_ButtonKeyEnties;

	[SerializeField]
	[Token(Token = "0x4002795")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<string, Dictionary<string, List<ButtonKeyCode>>> m_ButtonArcadeKeyEnties;

	[Token(Token = "0x17000692")]
	public Dictionary<string, Dictionary<string, List<KeyCode>>> buttonKeyEnties
	{
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000693")]
	public Dictionary<string, Dictionary<string, List<ButtonKeyCode>>> buttonArcadeKeyEnties
	{
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004626")]
	[Address(RVA = "0x4A9F70", Offset = "0x4A8770", Length = "0x74")]
	public StandloneCtrlConfig()
	{
	}
}
