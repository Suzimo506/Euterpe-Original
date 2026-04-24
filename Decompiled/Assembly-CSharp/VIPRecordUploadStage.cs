using Assets.Scripts.Purchase;
using Cpp2ILInjected;

[Token(Token = "0x2000068")]
public class VIPRecordUploadStage : IIAPPipelineStage
{
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40002F1")]
	private string url;

	[Address(RVA = "0x4EBC10", Offset = "0x4EA410", Length = "0x49")]
	[Token(Token = "0x600031B")]
	public VIPRecordUploadStage()
	{
	}

	[Address(RVA = "0x4EBAF0", Offset = "0x4EA2F0", Length = "0xD")]
	[Token(Token = "0x600031C")]
	protected override void InvokeImpl()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void UploadToServer()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x4EBB00", Offset = "0x4EA300", Length = "0x10F")]
	private void SaveToDataManager()
	{
	}
}
