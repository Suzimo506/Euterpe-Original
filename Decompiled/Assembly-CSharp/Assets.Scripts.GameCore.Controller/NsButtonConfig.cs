using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using nn.hid;

namespace Assets.Scripts.GameCore.Controller;

[CreateAssetMenu]
[Token(Token = "0x2000777")]
public class NsButtonConfig : ControllerConfig
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002778")]
	public string CurrentProposal;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002779")]
	[SerializeField]
	private Dictionary<string, Dictionary<string, List<NpadButton>>> m_AssignedProposal;

	[Token(Token = "0x17000690")]
	public Dictionary<string, Dictionary<string, List<NpadButton>>> assignedProposal
	{
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60045FF")]
	[Address(RVA = "0x4A20D0", Offset = "0x4A08D0", Length = "0x66")]
	public NsButtonConfig()
	{
	}
}
