using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200093E")]
public class PnlDlcGradientControl : SerializedMonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40031F8")]
	[FieldOffset(Offset = "0x58")]
	private IGradientItem[] m_GradientItems;

	[Address(RVA = "0x8255A0", Offset = "0x823DA0", Length = "0x9D")]
	[Token(Token = "0x60053F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60053F1")]
	[Address(RVA = "0x8256A0", Offset = "0x823EA0", Length = "0x9D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60053F2")]
	[Address(RVA = "0x825740", Offset = "0x823F40", Length = "0xAB")]
	public void OnItemIndexChange(int jsonIndex)
	{
	}

	[Token(Token = "0x60053F3")]
	[Address(RVA = "0x8257F0", Offset = "0x823FF0", Length = "0x106")]
	private void RecoverArknightShowItem()
	{
	}

	[Address(RVA = "0x825640", Offset = "0x823E40", Length = "0x5D")]
	[Token(Token = "0x60053F4")]
	private void CollectGradientItem()
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x60053F5")]
	public PnlDlcGradientControl()
	{
	}
}
