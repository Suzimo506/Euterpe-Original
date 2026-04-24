namespace MEC;

public struct CoroutineHandle : IEquatable<CoroutineHandle>
{
	private const byte ReservedSpace = 15; //Field offset: 0x0
	private static readonly Int32[] NextIndex; //Field offset: 0x0
	private readonly int _id; //Field offset: 0x0

	public bool IsAliveAndPaused
	{
		 get { } //Length: 358
		 set { } //Length: 141
	}

	public bool IsRunning
	{
		 get { } //Length: 82
		 set { } //Length: 99
	}

	public bool IsValid
	{
		 get { } //Length: 7
	}

	public byte Key
	{
		 get { } //Length: 6
	}

	public Nullable<Int32> Layer
	{
		 get { } //Length: 82
		 set { } //Length: 426
	}

	public Segment Segment
	{
		 get { } //Length: 295
		 set { } //Length: 96
	}

	public string Tag
	{
		 get { } //Length: 82
		 set { } //Length: 101
	}

	private static CoroutineHandle() { }

	public CoroutineHandle(byte ind) { }

	public CoroutineHandle(CoroutineHandle other) { }

	public override bool Equals(CoroutineHandle other) { }

	public virtual bool Equals(object other) { }

	public bool get_IsAliveAndPaused() { }

	public bool get_IsRunning() { }

	public bool get_IsValid() { }

	public byte get_Key() { }

	public Nullable<Int32> get_Layer() { }

	public Segment get_Segment() { }

	public string get_Tag() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(CoroutineHandle a, CoroutineHandle b) { }

	public static bool op_Inequality(CoroutineHandle a, CoroutineHandle b) { }

	public void set_IsAliveAndPaused(bool value) { }

	public void set_IsRunning(bool value) { }

	public void set_Layer(Nullable<Int32> value) { }

	public void set_Segment(Segment value) { }

	public void set_Tag(string value) { }

	public virtual string ToString() { }

}

