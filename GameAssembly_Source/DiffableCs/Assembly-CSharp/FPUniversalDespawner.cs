//Type is in global namespace

public class FPUniversalDespawner : MonoBehaviour, IFastPoolItem
{
	[CompilerGenerated]
	private sealed class <CheckAlive>d__26 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FPUniversalDespawner <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <CheckAlive>d__26(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <Despawn>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float despawn_delay; //Field offset: 0x20
		public FPUniversalDespawner <>4__this; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Despawn>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private int targetPoolID; //Field offset: 0x18
	[SerializeField]
	private bool despawnDelayed; //Field offset: 0x1C
	[SerializeField]
	private float delay; //Field offset: 0x20
	[SerializeField]
	private bool despawnOnParticlesDead; //Field offset: 0x24
	[SerializeField]
	private bool resetParticleSystem; //Field offset: 0x25
	[SerializeField]
	private bool despawnOnAudioSourceStop; //Field offset: 0x26
	private bool needCheck; //Field offset: 0x27
	private AudioSource aSource; //Field offset: 0x28
	private ParticleSystem pSystem; //Field offset: 0x30

	public float Delay
	{
		 get { } //Length: 6
	}

	public bool DespawnDelayed
	{
		 get { } //Length: 5
	}

	public bool DespawnOnAudioSourceStop
	{
		 get { } //Length: 5
	}

	public bool DespawnOnParticlesDead
	{
		 get { } //Length: 5
	}

	public bool ResetParticleSystem
	{
		 get { } //Length: 5
	}

	public int TargetPoolID
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public FPUniversalDespawner() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator CheckAlive() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator Despawn(float despawn_delay) { }

	public float get_Delay() { }

	public bool get_DespawnDelayed() { }

	public bool get_DespawnOnAudioSourceStop() { }

	public bool get_DespawnOnParticlesDead() { }

	public bool get_ResetParticleSystem() { }

	public int get_TargetPoolID() { }

	public override void OnFastDestroy() { }

	public override void OnFastInstantiate() { }

	public void set_TargetPoolID(int value) { }

	private void Start() { }

}

