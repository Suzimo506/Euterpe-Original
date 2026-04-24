namespace Assets.Scripts.Database;

public class CharacterFestivalVoiceInfo : BaseDataObject
{
	public int index; //Field offset: 0x20
	public float weight; //Field offset: 0x24
	public List<FestivalExpression> expressions; //Field offset: 0x28
	public List<FestivalExpression> reviewExpressions; //Field offset: 0x30

	public CharacterFestivalVoiceInfo() { }

	public List<FestivalExpression> GetExpression(bool isCat = false) { }

	private void SetExpression(List<FestivalExpression> expr, List<List`1<String>> localExpressions) { }

}

