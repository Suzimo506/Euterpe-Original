using Cpp2ILInjected;
using PeroTools2.Commons;
using UnityEngine;

namespace ArcadeController.UI.Panel;

[Token(Token = "0x200053E")]
public class PnlArcadeDirectionNavigate : SingletonMonoBehaviour<PnlArcadeDirectionNavigate>
{
	[SerializeField]
	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0x58")]
	private Animator m_ImgLAnimator;

	[SerializeField]
	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0x60")]
	private Animator m_ImgRAnimator;

	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Animator m_ImgZLAnimator;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001F78")]
	private Animator m_ImgZRAnimator;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001F79")]
	[SerializeField]
	private Transform m_ArcadeDirectionPoint;

	[Address(RVA = "0x599D10", Offset = "0x598510", Length = "0x38")]
	[Token(Token = "0x6003764")]
	public PnlArcadeDirectionNavigate()
	{
		((SingletonMonoBehaviour<T>)(object)this)._002Ector();
	}
}
