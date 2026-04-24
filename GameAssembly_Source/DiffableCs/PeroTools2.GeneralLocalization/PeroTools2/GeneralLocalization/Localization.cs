namespace PeroTools2.GeneralLocalization;

[ExecuteInEditMode]
public class Localization : SerializedMonoBehaviour
{
	[SerializeField]
	private LocalizationSettings m_Settings; //Field offset: 0x58
	[HideInInspector]
	public OptionEntry lastActiveOptionEntry; //Field offset: 0x60
	public List<OptionPair> optionPairs; //Field offset: 0x68
	public SchemeEntry selectedSchemeEntry; //Field offset: 0x70
	public Source source; //Field offset: 0x78
	public Type sourceType; //Field offset: 0x80

	public Localization() { }

	public void ApplySchemeOption(SchemeEntry schemeEntry, OptionEntry optionEntry) { }

	public OptionEntry FindEntry(Option option) { }

	public Option GetOption(OptionEntry entry) { }

	private void OnDisable() { }

	private void OnEnable() { }

}

