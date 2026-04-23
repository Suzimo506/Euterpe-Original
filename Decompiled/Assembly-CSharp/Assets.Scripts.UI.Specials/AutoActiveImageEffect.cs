using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000869")]
public class AutoActiveImageEffect : MonoBehaviour
{
	[Address(RVA = "0x6093C0", Offset = "0x607BC0", Length = "0x50")]
	[Token(Token = "0x6004CEA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004CEB")]
	[Address(RVA = "0x609360", Offset = "0x607B60", Length = "0x50")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004CEC")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AutoActiveImageEffect()
	{
	}
}
