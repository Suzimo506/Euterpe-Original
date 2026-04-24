using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B6")]
public class UITutorial : SingletonMonoBehaviour<UITutorial>
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4002D7F")]
	private Button[] m_Restart;

	[Token(Token = "0x4002D80")]
	[FieldOffset(Offset = "0x20")]
	public GameObject autoObj;

	[Token(Token = "0x4002D81")]
	[FieldOffset(Offset = "0x28")]
	private Animator m_Animator;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D82")]
	private Sequence m_AddLifeSeq;

	[Token(Token = "0x17000884")]
	public Animator animator
	{
		[Address(RVA = "0x5BCA60", Offset = "0x5BB260", Length = "0x69")]
		[Token(Token = "0x6004EC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004EC5")]
	[Address(RVA = "0x5BC0C0", Offset = "0x5BA8C0", Length = "0x203")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004EC6")]
	[Address(RVA = "0x5BC810", Offset = "0x5BB010", Length = "0xC9")]
	private void Start()
	{
	}

	[Token(Token = "0x6004EC7")]
	[Address(RVA = "0x5BC2D0", Offset = "0x5BAAD0", Length = "0x164")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004EC8")]
	[Address(RVA = "0x5BC8E0", Offset = "0x5BB0E0", Length = "0x137")]
	private void Update()
	{
	}

	[Token(Token = "0x6004EC9")]
	[Address(RVA = "0x5BC790", Offset = "0x5BAF90", Length = "0x7B")]
	private void OnResume()
	{
	}

	[Address(RVA = "0x5BC5E0", Offset = "0x5BADE0", Length = "0x7B")]
	[Token(Token = "0x6004ECA")]
	private void OnPause()
	{
	}

	[Address(RVA = "0x5BC490", Offset = "0x5BAC90", Length = "0x14A")]
	[Token(Token = "0x6004ECB")]
	private void OnHpReduct(object sender, object reciever, params object[] args)
	{
	}

	[Address(RVA = "0x5BC660", Offset = "0x5BAE60", Length = "0x129")]
	[Token(Token = "0x6004ECC")]
	private void OnRestartClicked()
	{
	}

	[Address(RVA = "0x5BC440", Offset = "0x5BAC40", Length = "0x4F")]
	[Token(Token = "0x6004ECD")]
	private void OnExitClicked()
	{
	}

	[Address(RVA = "0x5BCA20", Offset = "0x5BB220", Length = "0x38")]
	[Token(Token = "0x6004ECE")]
	public UITutorial()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
