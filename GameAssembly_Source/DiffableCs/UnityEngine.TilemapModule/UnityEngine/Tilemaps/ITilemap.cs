namespace UnityEngine.Tilemaps;

[RequiredByNativeCode]
public class ITilemap
{
	internal static ITilemap s_Instance; //Field offset: 0x0
	internal Tilemap m_Tilemap; //Field offset: 0x10

	internal ITilemap() { }

	[RequiredByNativeCode]
	private static ITilemap CreateInstance() { }

	public void RefreshTile(Vector3Int position) { }

}

