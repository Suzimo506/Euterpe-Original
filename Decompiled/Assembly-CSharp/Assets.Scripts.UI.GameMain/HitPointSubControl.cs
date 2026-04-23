using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x2000896")]
public class HitPointSubControl : MonoBehaviour, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002CAF")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x17000878")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6004DDF")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x5B0980", Offset = "0x5AF180", Length = "0xB4")]
	[Token(Token = "0x6004DDC")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5B0A40", Offset = "0x5AF240", Length = "0x20")]
	[Token(Token = "0x6004DDD")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x5B0A70", Offset = "0x5AF270", Length = "0x20")]
	[Token(Token = "0x6004DDE")]
	public void Resume()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004DE0")]
	public HitPointSubControl()
	{
	}
}
