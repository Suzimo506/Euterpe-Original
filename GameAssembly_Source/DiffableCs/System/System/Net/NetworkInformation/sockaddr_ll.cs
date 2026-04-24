namespace System.Net.NetworkInformation;

internal struct sockaddr_ll
{
	public ushort sll_family; //Field offset: 0x0
	public ushort sll_protocol; //Field offset: 0x2
	public int sll_ifindex; //Field offset: 0x4
	public ushort sll_hatype; //Field offset: 0x8
	public byte sll_pkttype; //Field offset: 0xA
	public byte sll_halen; //Field offset: 0xB
	public Byte[] sll_addr; //Field offset: 0x10

}

