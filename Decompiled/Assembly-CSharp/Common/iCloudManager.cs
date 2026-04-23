using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Common;

[Token(Token = "0x20004E4")]
public class iCloudManager : SingletonMonoBehaviour<iCloudManager>
{
	[Address(RVA = "0x4756A0", Offset = "0x473EA0", Length = "0x45D")]
	[Token(Token = "0x6003635")]
	private void OnSaveSelectCallback(bool isLocal)
	{
	}

	[Address(RVA = "0x475B00", Offset = "0x474300", Length = "0x38")]
	[Token(Token = "0x6003636")]
	public iCloudManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
