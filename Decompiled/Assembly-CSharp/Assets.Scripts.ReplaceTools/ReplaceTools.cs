using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A6")]
public class ReplaceTools : SerializedMonoBehaviour
{
	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x58")]
	public bool AwakeInit;

	[SerializeField]
	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x60")]
	private AbstractReplace[] m_Replaces;

	[Token(Token = "0x4002105")]
	public const int bad_apple = 0;

	[Token(Token = "0x60038EC")]
	[Address(RVA = "0x659D50", Offset = "0x658550", Length = "0x111")]
	private void Awake()
	{
	}

	[Token(Token = "0x60038ED")]
	[Address(RVA = "0x659E70", Offset = "0x658670", Length = "0x75")]
	public void Replace(int index)
	{
	}

	[Token(Token = "0x60038EE")]
	[Address(RVA = "0x659EF0", Offset = "0x6586F0", Length = "0x50")]
	public ReplaceTools()
	{
	}
}
