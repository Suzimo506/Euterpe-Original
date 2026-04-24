namespace Assets.Scripts.PeroTools.GeneralLocalization;

[ExecuteInEditMode]
public class Localization : SerializedMonoBehaviour
{
	[HideInInspector]
	public OptionEntry lastActiveOptionEntry; //Field offset: 0x58
	private LocalizationSettings m_Manager; //Field offset: 0x60
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

