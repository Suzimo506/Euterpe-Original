using Cpp2ILInjected;
using Sirenix.OdinInspector;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008AD")]
public class OverrideSortingLayer : SerializedMonoBehaviour
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002D5D")]
	public string layerName;

	[Token(Token = "0x4002D5E")]
	[FieldOffset(Offset = "0x60")]
	public int sortingOrder;

	[Address(RVA = "0x5B1380", Offset = "0x5AFB80", Length = "0x94")]
	[Token(Token = "0x6004E95")]
	private void Start()
	{
	}

	[Token(Token = "0x6004E96")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public OverrideSortingLayer()
	{
	}
}
