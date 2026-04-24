using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000182")]
public class ImgIllus : MonoBehaviour
{
	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x18")]
	private Image m_IllusImg;

	[Token(Token = "0x4000981")]
	[HideInInspector]
	[FieldOffset(Offset = "0x20")]
	public string imageName;

	[Address(RVA = "0x5C6E30", Offset = "0x5C5630", Length = "0x47")]
	[Token(Token = "0x6000B05")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x5C6F00", Offset = "0x5C5700", Length = "0x8B")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x5C6E80", Offset = "0x5C5680", Length = "0x76")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x5C6F90", Offset = "0x5C5790", Length = "0x46")]
	public ImgIllus()
	{
	}
}
