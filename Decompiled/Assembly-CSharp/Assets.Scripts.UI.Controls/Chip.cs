using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A9")]
public class Chip : MonoBehaviour
{
	[Token(Token = "0x4002D44")]
	[FieldOffset(Offset = "0x18")]
	public Text chipTxt;

	[Token(Token = "0x4002D45")]
	[FieldOffset(Offset = "0x20")]
	public Text chipCountText;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002D46")]
	public Transform character;

	[Token(Token = "0x4002D47")]
	[FieldOffset(Offset = "0x30")]
	public Transform elfin;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002D48")]
	public Transform trove;

	[Token(Token = "0x4002D49")]
	[FieldOffset(Offset = "0x40")]
	public Transform parent;

	[Token(Token = "0x4002D4A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject image;

	[Token(Token = "0x4002D4B")]
	[FieldOffset(Offset = "0x50")]
	public particleHoming particleHoming;

	[Token(Token = "0x4002D4C")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem.Particle m_Particle;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4002D4D")]
	private GameObject m_GameObject;

	[Token(Token = "0x4002D4E")]
	private static int m_DoneCount;

	[Token(Token = "0x4002D4F")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_InvokeEvent;

	[Token(Token = "0x6004E7D")]
	[Address(RVA = "0x5AB9B0", Offset = "0x5AA1B0", Length = "0x22D")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004E7E")]
	[Address(RVA = "0x5ABBE0", Offset = "0x5AA3E0", Length = "0x37")]
	public void SetEnable(bool enable)
	{
	}

	[Address(RVA = "0x5AB4F0", Offset = "0x5A9CF0", Length = "0x4B3")]
	[Token(Token = "0x6004E7F")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004E80")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public Chip()
	{
	}
}
