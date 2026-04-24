using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x200084F")]
public abstract class RedotBaseComponent : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002B4E")]
	[SerializeField]
	private uint m_EventType;

	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4002B4F")]
	private bool m_ExcuteUpdateOnEnable;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002B50")]
	[SerializeField]
	protected Image m_ImgRedot;

	[Token(Token = "0x6004C48")]
	[Address(RVA = "0x6191F0", Offset = "0x6179F0", Length = "0xB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004C49")]
	[Address(RVA = "0x6192B0", Offset = "0x617AB0", Length = "0x2F")]
	protected virtual void OnRedotUpdate()
	{
	}

	[Address(RVA = "0x619150", Offset = "0x617950", Length = "0x9E")]
	[Token(Token = "0x6004C4A")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004C4B")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected RedotBaseComponent()
	{
	}
}
