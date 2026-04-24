namespace Assets.Scripts.Structs;

public struct GameDialogArgs
{
	private static StringBuilder s_builder; //Field offset: 0x0
	public const int DIALOG_UP = 0; //Field offset: 0x0
	public const int DIALOG_DOWN = 1; //Field offset: 0x0
	public const int DIALOG_TYPE_ROLE = 0; //Field offset: 0x0
	public const int DIALOG_TYPE_BOSS = 1; //Field offset: 0x0
	public const int DIALOG_TYPE_UI = 2; //Field offset: 0x0
	public int index; //Field offset: 0x0
	public decimal time; //Field offset: 0x4
	public int dialogType; //Field offset: 0x14
	public int dialogIndex; //Field offset: 0x18
	public string text; //Field offset: 0x20
	public Color textColor; //Field offset: 0x28
	public Color bgColor; //Field offset: 0x38
	public float speed; //Field offset: 0x48
	public int fontSize; //Field offset: 0x4C
	public Vector2Int dialogSize; //Field offset: 0x50
	public DialogState dialogState; //Field offset: 0x58
	public Alignment alignment; //Field offset: 0x5C

	private static GameDialogArgs() { }

	public static void FixDialogDelay(Dictionary<String, List`1<GameDialogArgs>> argsDic, decimal delay) { }

	private static void Format(Dictionary<String, List`1<GameDialogArgs>> argsDic) { }

	private void Format() { }

	public static Dictionary<String, List`1<GameDialogArgs>> Load(string str) { }

}

