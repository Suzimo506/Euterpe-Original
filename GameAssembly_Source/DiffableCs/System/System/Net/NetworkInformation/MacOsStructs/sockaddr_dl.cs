namespace System.Net.NetworkInformation.MacOsStructs;

internal struct sockaddr_dl
{
	public byte sdl_len; //Field offset: 0x0
	public byte sdl_family; //Field offset: 0x1
	public ushort sdl_index; //Field offset: 0x2
	public byte sdl_type; //Field offset: 0x4
	public byte sdl_nlen; //Field offset: 0x5
	public byte sdl_alen; //Field offset: 0x6
	public byte sdl_slen; //Field offset: 0x7
	public Byte[] sdl_data; //Field offset: 0x8

	internal void Read(IntPtr ptr) { }

}

