using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI;

[Token(Token = "0x200082B")]
public class ShowTips : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002A90")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x16C20", Offset = "0x16020")]
	private GameObject[] m_NavTips;

	[Token(Token = "0x6004B3F")]
	[Address(RVA = "0x61BB50", Offset = "0x61A350", Length = "0x75")]
	private void Start()
	{
	}

	[Address(RVA = "0x61BB50", Offset = "0x61A350", Length = "0x75")]
	[Token(Token = "0x6004B40")]
	private void InitNavTips()
	{
	}

	[Token(Token = "0x6004B41")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ShowTips()
	{
	}
}
