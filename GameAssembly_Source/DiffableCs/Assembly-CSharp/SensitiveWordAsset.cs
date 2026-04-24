//Type is in global namespace

[CreateAssetMenu]
public class SensitiveWordAsset : ScriptableObject
{
	public List<String> cn; //Field offset: 0x18
	public List<String> num; //Field offset: 0x20
	public List<String> eng; //Field offset: 0x28
	public List<String> all; //Field offset: 0x30
	public List<String> specialChar; //Field offset: 0x38
	private List<String> m_BlockingWord; //Field offset: 0x40

	public SensitiveWordAsset() { }

	public string Block(string input) { }

	private void BlockTest(string input) { }

}

