using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000837")]
public class StageParticleMeshLoader : SerializedMonoBehaviour
{
	[Token(Token = "0x4002AD5")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem[] m_ParticleSystem;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002AD6")]
	private List<ParticleSystemRenderer> m_PsRenderer;

	[Address(RVA = "0x6034D0", Offset = "0x601CD0", Length = "0x113")]
	[Token(Token = "0x6004BAC")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6036E0", Offset = "0x601EE0", Length = "0x142")]
	[Token(Token = "0x6004BAD")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x6035F0", Offset = "0x601DF0", Length = "0xE8")]
	[Token(Token = "0x6004BAE")]
	private void LoadStageParticleMesh(int index, string bgStageMeshAssetName)
	{
	}

	[Token(Token = "0x6004BAF")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public StageParticleMeshLoader()
	{
	}
}
