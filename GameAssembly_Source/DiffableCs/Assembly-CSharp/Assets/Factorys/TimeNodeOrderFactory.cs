namespace Assets.Factorys;

public class TimeNodeOrderFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public MusicData pressMd; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <FindPressHeader>b__0(MusicData m) { }

	}

	[DecimalConstant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static readonly decimal precision; //Field offset: 0x0
	private const int pressing_range = 50; //Field offset: 0x0
	private TimeNodeOrder tempNodeOrder; //Field offset: 0x10
	private TimeNodeOrder prevTimeNodeOrder; //Field offset: 0x18
	private decimal lastTnoTime; //Field offset: 0x20
	private int lastTnoIndex; //Field offset: 0x30
	private Dictionary<Int32, List`1<TimeNodeOrder>> timeOrderBuffer; //Field offset: 0x38
	private List<MusicData> m_MusicDatas; //Field offset: 0x40

	private static TimeNodeOrderFactory() { }

	private TimeNodeOrderFactory() { }

	private void AddLongPressingTno(int tick) { }

	private void AddTimeNodeOrder(int tick) { }

	private void AddTno(int tick, TimeNodeOrder tno) { }

	private TimeNodeOrder CheckTnoEqual() { }

	private void CreateMulingTicks(int leftRange, int rightRange, MusicData md) { }

	private void CreateNoteTicks(int leftRange, int rightRange, MusicData md) { }

	private void CreatePressingTimeNodeOrder(MusicData md) { }

	private void CreateTimeNodeOrder(List<MusicData> musicDatas) { }

	private MusicData FindPressHeader(MusicData pressMd) { }

	public static TimeNodeOrderResult GetTimeNodeOrder(List<MusicData> musicDatas) { }

	private void LongNoteSort(List<TimeNodeOrder> tnos) { }

	private void NoteSort() { }

	private void RangeFixed(ref MusicData md) { }

	private void RefreshMulLastTime(decimal lastTick, int index) { }

}

