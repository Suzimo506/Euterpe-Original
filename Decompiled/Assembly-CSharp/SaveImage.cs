using Assets.Scripts.Common.ImageSaver;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000011")]
public class SaveImage : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_SampleImg;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000034")]
	private GameObject m_43Img;

	[SerializeField]
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_VerySpecialImg;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000036")]
	[SerializeField]
	private GameObject m_SquareImg;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	private ImageSaver m_ImageSaver;

	[Address(RVA = "0x6241C0", Offset = "0x6229C0", Length = "0x94")]
	[Token(Token = "0x6000032")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6244E0", Offset = "0x622CE0", Length = "0x64")]
	[Token(Token = "0x6000033")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x624260", Offset = "0x622A60", Length = "0x48")]
	[Token(Token = "0x6000034")]
	private void OnCilck(Image images)
	{
	}

	[Address(RVA = "0x6242B0", Offset = "0x622AB0", Length = "0x221")]
	[Token(Token = "0x6000035")]
	private void OnClickDownload()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000036")]
	public SaveImage()
	{
	}
}
