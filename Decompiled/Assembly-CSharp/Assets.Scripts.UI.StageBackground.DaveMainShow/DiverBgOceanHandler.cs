using Assets.Scripts.UI.StageBackground.DaveFishSwim;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x2000839")]
public class DiverBgOceanHandler : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002ADA")]
	private GameObject m_MarijiaPrefab;

	[SerializeField]
	[Token(Token = "0x4002ADB")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_RinPrefab;

	[SerializeField]
	[Token(Token = "0x4002ADC")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_CoralPrefab;

	[Token(Token = "0x4002ADD")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_MarijiaObj;

	[Token(Token = "0x4002ADE")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_RinObj;

	[Token(Token = "0x4002ADF")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_CoralObj;

	[Token(Token = "0x4002AE0")]
	[FieldOffset(Offset = "0x48")]
	private DaveBgFishGroupManage m_FishSwimHandler;

	[Token(Token = "0x6004BB4")]
	[Address(RVA = "0x60E950", Offset = "0x60D150", Length = "0x153")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004BB5")]
	[Address(RVA = "0x60EB00", Offset = "0x60D300", Length = "0x4D")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004BB6")]
	[Address(RVA = "0x60EAB0", Offset = "0x60D2B0", Length = "0x4D")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004BB7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DiverBgOceanHandler()
	{
	}
}
