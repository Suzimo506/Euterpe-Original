using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F6")]
public class ScreenShotTextHandle : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002FF8")]
	public Text txtReplace;

	[Token(Token = "0x4002FF9")]
	[FieldOffset(Offset = "0x20")]
	public Text txtOrigin;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002FFA")]
	public Transform txtScrollRoot;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002FFB")]
	private bool doOutHanlde;

	[Token(Token = "0x6005165")]
	[Address(RVA = "0x4D0660", Offset = "0x4CEE60", Length = "0x19E")]
	public void StartShotHandle()
	{
	}

	[Token(Token = "0x6005166")]
	[Address(RVA = "0x4D0600", Offset = "0x4CEE00", Length = "0x5D")]
	public void EndShotHandle()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005167")]
	public ScreenShotTextHandle()
	{
	}
}
