namespace Steamworks;

public class MMKVPMarshaller
{
	private IntPtr m_pNativeArray; //Field offset: 0x10
	private IntPtr m_pArrayEntries; //Field offset: 0x18

	public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters) { }

	protected virtual void Finalize() { }

	public static IntPtr op_Implicit(MMKVPMarshaller that) { }

}

