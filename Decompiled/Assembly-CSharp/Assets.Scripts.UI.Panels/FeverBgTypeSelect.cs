using Cpp2ILInjected;
using PeroPeroGames.GlobalDefines;
using UnityEngine;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D4")]
public class FeverBgTypeSelect : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002E23")]
	[SerializeField]
	private FeverBgType m_FeverType;

	[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
	[Token(Token = "0x6004F95")]
	public int GetFeverBgTypeForInt()
	{
		return default(int);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004F96")]
	public FeverBgTypeSelect()
	{
	}
}
