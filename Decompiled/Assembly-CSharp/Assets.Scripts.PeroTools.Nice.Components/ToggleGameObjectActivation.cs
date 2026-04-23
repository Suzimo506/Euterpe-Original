using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x200060C")]
public class ToggleGameObjectActivation : SerializedMonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002231")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_Object;

	[Token(Token = "0x4002232")]
	[FieldOffset(Offset = "0x60")]
	[HideInInspector]
	[SerializeField]
	private Toggle m_Toggle;

	[Address(RVA = "0x985AE0", Offset = "0x9842E0", Length = "0xE2")]
	[Token(Token = "0x6003B2B")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B2C")]
	[Address(RVA = "0x985C00", Offset = "0x984400", Length = "0x1E")]
	private void OnValueChanged(bool isOn)
	{
	}

	[Token(Token = "0x6003B2D")]
	[Address(RVA = "0x985BD0", Offset = "0x9843D0", Length = "0x20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003B2E")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public ToggleGameObjectActivation()
	{
	}
}
