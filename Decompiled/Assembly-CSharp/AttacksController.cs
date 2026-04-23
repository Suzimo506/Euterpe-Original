using Assets.Scripts.Database;
using Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000037")]
public class AttacksController : MonoBehaviour
{
	[Token(Token = "0x20009A3")]
	public enum KeyAudioType
	{
		[Token(Token = "0x4003498")]
		Hit,
		[Token(Token = "0x4003499")]
		Touch,
		[Token(Token = "0x400349A")]
		Others,
		[Token(Token = "0x400349B")]
		Bass,
		[Token(Token = "0x400349C")]
		KeyAudioTypeCount
	}

	[Token(Token = "0x4000159")]
	public const int FAIL_PLAY_IDX1 = -1;

	[Token(Token = "0x400015A")]
	public const int FAIL_PLAY_IDX2 = -2;

	[Token(Token = "0x400015B")]
	private static AttacksController instance;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public AttackEffectManager attackAttackEffectManager;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015D")]
	private DBOther m_DbOther;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400015E")]
	public AudioSource curHitAs;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400015F")]
	public AudioSource curTouchAs;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource curLAs;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000161")]
	public AudioSource curBassAs;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000162")]
	public bool showAttackAnim;

	[Token(Token = "0x17000022")]
	public static AttacksController Instance
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5F29E0", Offset = "0x5F11E0", Length = "0x56")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x5F2830", Offset = "0x5F1030", Length = "0x19F")]
	private void Start()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x5F1280", Offset = "0x5EFA80", Length = "0x9E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x5F1B20", Offset = "0x5F0320", Length = "0x1C2")]
	public void PlayOneShot(string keyAudio, KeyAudioType audioType)
	{
	}

	[Address(RVA = "0x5F2070", Offset = "0x5F0870", Length = "0x1B4")]
	[Token(Token = "0x6000146")]
	public void ShowAttack(int id, uint resultCode, uint actionType, bool isContinue = false)
	{
	}

	[Address(RVA = "0x5F1320", Offset = "0x5EFB20", Length = "0x24E")]
	[Token(Token = "0x6000147")]
	public void OnShowAttack(int idx, uint result)
	{
	}

	[Address(RVA = "0x5F1CF0", Offset = "0x5F04F0", Length = "0x37A")]
	[Token(Token = "0x6000148")]
	private void ShowAttackEffect(int id, uint resultCode, bool isContinue)
	{
	}

	[Address(RVA = "0x5F2240", Offset = "0x5F0A40", Length = "0x5EE")]
	[Token(Token = "0x6000149")]
	private void ShowWisadelAtkEffect(int id)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x5F1570", Offset = "0x5EFD70", Length = "0x2DE")]
	private void PlayAttackAnim(int id, bool isContinue, uint result)
	{
	}

	[Address(RVA = "0x5F1850", Offset = "0x5F0050", Length = "0x2C3")]
	[Token(Token = "0x600014B")]
	public void PlayJumpAnim()
	{
	}

	[Address(RVA = "0x5F29D0", Offset = "0x5F11D0", Length = "0xB")]
	[Token(Token = "0x600014C")]
	public AttacksController()
	{
	}
}
