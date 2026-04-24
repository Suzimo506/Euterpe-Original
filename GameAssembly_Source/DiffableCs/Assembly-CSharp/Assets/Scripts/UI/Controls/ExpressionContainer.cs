namespace Assets.Scripts.UI.Controls;

public class ExpressionContainer
{
	private const int base_random = 1000; //Field offset: 0x0
	private const byte base_exp = 0; //Field offset: 0x0
	private const byte festival_exp = 1; //Field offset: 0x0
	private Byte[] m_MasterRandom; //Field offset: 0x10
	private Byte[] m_ExpressionRandom; //Field offset: 0x18
	private List<Expression> m_Expressions; //Field offset: 0x20
	private List<FestivalExpression> m_FestivalExpressions; //Field offset: 0x28

	public ExpressionContainer() { }

	public Expression GetExpression(int index) { }

	public Expression RandomExpression() { }

	private void RefreshRandom(List<Single> typeWeightBuffer) { }

	public void SetExpression(CharacterInfo characterInfo, CharacterFestivalVoiceInfo festivalVoiceInfo, bool isCat) { }

	private void SetRandom(Byte[] random, List<Single> weightBuffer) { }

}

