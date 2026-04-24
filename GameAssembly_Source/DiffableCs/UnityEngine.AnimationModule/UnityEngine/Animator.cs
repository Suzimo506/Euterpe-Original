namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class Animator : Behaviour
{

	internal bool allowConstantClipSamplingOptimization
	{
		internal get { } //Length: 51
		internal set { } //Length: 66
	}

	public Vector3 angularVelocity
	{
		 get { } //Length: 77
	}

	[Obsolete]
	public bool animatePhysics
	{
		 get { } //Length: 57
		 set { } //Length: 75
	}

	public bool applyRootMotion
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Avatar avatar
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	internal Transform avatarRoot
	{
		internal get { } //Length: 51
	}

	public Vector3 bodyPosition
	{
		 get { } //Length: 117
		 set { } //Length: 92
	}

	internal Vector3 bodyPositionInternal
	{
		[NativeMethod]
		internal get { } //Length: 77
		[NativeMethod]
		internal set { } //Length: 66
	}

	public Quaternion bodyRotation
	{
		 get { } //Length: 103
		 set { } //Length: 83
	}

	internal Quaternion bodyRotationInternal
	{
		[NativeMethod]
		internal get { } //Length: 75
		[NativeMethod]
		internal set { } //Length: 66
	}

	public AnimatorCullingMode cullingMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector3 deltaPosition
	{
		 get { } //Length: 77
	}

	public Quaternion deltaRotation
	{
		 get { } //Length: 75
	}

	public float feetPivotActive
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool fireEvents
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float gravityWeight
	{
		 get { } //Length: 51
	}

	public bool hasBoundPlayables
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool hasRootMotion
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool hasTransformHierarchy
	{
		 get { } //Length: 51
	}

	public float humanScale
	{
		 get { } //Length: 51
	}

	public bool isHuman
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isInitialized
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isMatchingTarget
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool isOptimizable
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	internal bool isRootPositionOrRotationControlledByCurves
	{
		[NativeMethod]
		internal get { } //Length: 51
	}

	public bool keepAnimatorControllerStateOnDisable
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int layerCount
	{
		 get { } //Length: 51
	}

	public bool layersAffectMassCenter
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float leftFeetBottomHeight
	{
		 get { } //Length: 51
	}

	[Obsolete]
	public bool linearVelocityBlending
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool logWarnings
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int parameterCount
	{
		 get { } //Length: 51
	}

	public AnimatorControllerParameter[] parameters
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Vector3 pivotPosition
	{
		 get { } //Length: 77
	}

	public float pivotWeight
	{
		 get { } //Length: 51
	}

	public PlayableGraph playableGraph
	{
		 get { } //Length: 90
	}

	public float playbackTime
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public AnimatorRecorderMode recorderMode
	{
		 get { } //Length: 51
	}

	public float recorderStartTime
	{
		 get { } //Length: 51
		 set { } //Length: 3
	}

	public float recorderStopTime
	{
		 get { } //Length: 51
		 set { } //Length: 3
	}

	public float rightFeetBottomHeight
	{
		 get { } //Length: 51
	}

	public Vector3 rootPosition
	{
		[NativeMethod]
		 get { } //Length: 77
		[NativeMethod]
		 set { } //Length: 66
	}

	public Quaternion rootRotation
	{
		[NativeMethod]
		 get { } //Length: 75
		[NativeMethod]
		 set { } //Length: 66
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float speed
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool stabilizeFeet
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal bool supportsOnAnimatorMove
	{
		[NativeMethod]
		internal get { } //Length: 51
	}

	public Vector3 targetPosition
	{
		 get { } //Length: 77
	}

	public Quaternion targetRotation
	{
		 get { } //Length: 75
	}

	public AnimatorUpdateMode updateMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
	}

	public Animator() { }

	public void ApplyBuiltinRootMotion() { }

	private void CheckIfInIKPass() { }

	internal void ClearInternalControllerPlayable() { }

	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	[FreeFunction]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	[FreeFunction]
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void EvaluateController() { }

	private void EvaluateController(float deltaTime) { }

	[Obsolete]
	public void ForceStateNormalizedTime(float normalizedTime) { }

	internal bool get_allowConstantClipSamplingOptimization() { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public bool get_animatePhysics() { }

	public bool get_applyRootMotion() { }

	public Avatar get_avatar() { }

	internal Transform get_avatarRoot() { }

	public Vector3 get_bodyPosition() { }

	[NativeMethod]
	internal Vector3 get_bodyPositionInternal() { }

	private void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	public Quaternion get_bodyRotation() { }

	[NativeMethod]
	internal Quaternion get_bodyRotationInternal() { }

	private void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	public AnimatorCullingMode get_cullingMode() { }

	public Vector3 get_deltaPosition() { }

	private void get_deltaPosition_Injected(out Vector3 ret) { }

	public Quaternion get_deltaRotation() { }

	private void get_deltaRotation_Injected(out Quaternion ret) { }

	public float get_feetPivotActive() { }

	public bool get_fireEvents() { }

	public float get_gravityWeight() { }

	[NativeMethod]
	public bool get_hasBoundPlayables() { }

	[NativeMethod]
	public bool get_hasRootMotion() { }

	public bool get_hasTransformHierarchy() { }

	public float get_humanScale() { }

	[NativeMethod]
	public bool get_isHuman() { }

	[NativeMethod]
	public bool get_isInitialized() { }

	[NativeMethod]
	public bool get_isMatchingTarget() { }

	[NativeMethod]
	public bool get_isOptimizable() { }

	[NativeMethod]
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	public bool get_keepAnimatorControllerStateOnDisable() { }

	public int get_layerCount() { }

	public bool get_layersAffectMassCenter() { }

	public float get_leftFeetBottomHeight() { }

	public bool get_linearVelocityBlending() { }

	public bool get_logWarnings() { }

	public int get_parameterCount() { }

	[FreeFunction]
	public AnimatorControllerParameter[] get_parameters() { }

	public Vector3 get_pivotPosition() { }

	private void get_pivotPosition_Injected(out Vector3 ret) { }

	public float get_pivotWeight() { }

	public PlayableGraph get_playableGraph() { }

	public float get_playbackTime() { }

	public AnimatorRecorderMode get_recorderMode() { }

	public float get_recorderStartTime() { }

	public float get_recorderStopTime() { }

	public float get_rightFeetBottomHeight() { }

	[NativeMethod]
	public Vector3 get_rootPosition() { }

	private void get_rootPosition_Injected(out Vector3 ret) { }

	[NativeMethod]
	public Quaternion get_rootRotation() { }

	private void get_rootRotation_Injected(out Quaternion ret) { }

	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	public float get_speed() { }

	public bool get_stabilizeFeet() { }

	[NativeMethod]
	internal bool get_supportsOnAnimatorMove() { }

	public Vector3 get_targetPosition() { }

	private void get_targetPosition_Injected(out Vector3 ret) { }

	public Quaternion get_targetRotation() { }

	private void get_targetRotation_Injected(out Quaternion ret) { }

	public AnimatorUpdateMode get_updateMode() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	[FreeFunction]
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	private ScriptableObject GetBehaviour(Type type) { }

	public T GetBehaviour() { }

	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	public T[] GetBehaviours() { }

	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	[NativeMethod]
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	public bool GetBool(int id) { }

	public bool GetBool(string name) { }

	[FreeFunction]
	private bool GetBoolID(int id) { }

	[FreeFunction]
	private bool GetBoolString(string name) { }

	public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction]
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	[FreeFunction]
	private void GetCurrentGraph(ref PlayableGraph graph) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal string GetCurrentStateName(int layerIndex) { }

	public float GetFloat(string name) { }

	public float GetFloat(int id) { }

	[FreeFunction]
	private float GetFloatID(int id) { }

	[FreeFunction]
	private float GetFloatString(string name) { }

	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	private void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	private void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	private void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	private float GetHintWeightPosition(AvatarIKHint hint) { }

	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	public int GetInteger(string name) { }

	public int GetInteger(int id) { }

	[FreeFunction]
	private int GetIntegerID(int id) { }

	[FreeFunction]
	private int GetIntegerString(string name) { }

	public int GetLayerIndex(string layerName) { }

	public string GetLayerName(int layerIndex) { }

	public float GetLayerWeight(int layerIndex) { }

	public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) { }

	[FreeFunction]
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal string GetNextStateName(int layerIndex) { }

	public AnimatorControllerParameter GetParameter(int index) { }

	[Obsolete]
	public Quaternion GetQuaternion(int id) { }

	[Obsolete]
	public Quaternion GetQuaternion(string name) { }

	private float GetRecorderStartTime() { }

	private float GetRecorderStopTime() { }

	internal string GetStats() { }

	[Obsolete]
	public Vector3 GetVector(string name) { }

	[Obsolete]
	public Vector3 GetVector(int id) { }

	public bool HasState(int layerIndex, int stateID) { }

	[FreeFunction]
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	[FreeFunction]
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	public void InterruptMatchTarget() { }

	public void InterruptMatchTarget(bool completeMatch) { }

	internal bool IsBoneTransform(Transform transform) { }

	[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Obsolete]
	public bool IsControlled(Transform transform) { }

	private bool IsInIKPass() { }

	public bool IsInTransition(int layerIndex) { }

	public bool IsParameterControlledByCurve(int id) { }

	public bool IsParameterControlledByCurve(string name) { }

	[FreeFunction]
	private bool IsParameterControlledByCurveID(int id) { }

	[FreeFunction]
	private bool IsParameterControlledByCurveString(string name) { }

	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	private void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void OnCullingModeChanged() { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void OnUpdateModeChanged() { }

	public void Play(string stateName, int layer, float normalizedTime) { }

	[FreeFunction]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	public void Play(int stateNameHash, int layer) { }

	public void Play(int stateNameHash) { }

	public void Play(string stateName, int layer) { }

	public void Play(string stateName) { }

	public void PlayInFixedTime(string stateName, int layer) { }

	public void PlayInFixedTime(string stateName) { }

	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	[FreeFunction]
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	public void PlayInFixedTime(int stateNameHash, int layer) { }

	public void PlayInFixedTime(int stateNameHash) { }

	private void Rebind(bool writeDefaultValues) { }

	public void Rebind() { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int id) { }

	[FreeFunction]
	private void ResetTriggerID(int id) { }

	[FreeFunction]
	private void ResetTriggerString(string name) { }

	internal string ResolveHash(int hash) { }

	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	public void set_animatePhysics(bool value) { }

	public void set_applyRootMotion(bool value) { }

	public void set_avatar(Avatar value) { }

	public void set_bodyPosition(Vector3 value) { }

	[NativeMethod]
	internal void set_bodyPositionInternal(Vector3 value) { }

	private void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	public void set_bodyRotation(Quaternion value) { }

	[NativeMethod]
	internal void set_bodyRotationInternal(Quaternion value) { }

	private void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	public void set_cullingMode(AnimatorCullingMode value) { }

	public void set_feetPivotActive(float value) { }

	public void set_fireEvents(bool value) { }

	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	public void set_layersAffectMassCenter(bool value) { }

	public void set_linearVelocityBlending(bool value) { }

	public void set_logWarnings(bool value) { }

	public void set_playbackTime(float value) { }

	public void set_recorderStartTime(float value) { }

	public void set_recorderStopTime(float value) { }

	[NativeMethod]
	public void set_rootPosition(Vector3 value) { }

	private void set_rootPosition_Injected(ref Vector3 value) { }

	[NativeMethod]
	public void set_rootRotation(Quaternion value) { }

	private void set_rootRotation_Injected(ref Quaternion value) { }

	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	public void set_speed(float value) { }

	public void set_stabilizeFeet(bool value) { }

	public void set_updateMode(AnimatorUpdateMode value) { }

	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	[NativeMethod]
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	public void SetBool(int id, bool value) { }

	public void SetBool(string name, bool value) { }

	[FreeFunction]
	private void SetBoolID(int id, bool value) { }

	[FreeFunction]
	private void SetBoolString(string name, bool value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int id, float value) { }

	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction]
	private void SetFloatID(int id, float value) { }

	[FreeFunction]
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	[FreeFunction]
	private void SetFloatString(string name, float value) { }

	[FreeFunction]
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	private void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	private void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	private void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int id, int value) { }

	[FreeFunction]
	private void SetIntegerID(int id, int value) { }

	[FreeFunction]
	private void SetIntegerString(string name, int value) { }

	public void SetLayerWeight(int layerIndex, float weight) { }

	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	[NativeMethod]
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	private void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	public void SetLookAtWeight(float weight, float bodyWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	public void SetLookAtWeight(float weight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	[NativeMethod]
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	[Obsolete]
	public void SetQuaternion(string name, Quaternion value) { }

	[Obsolete]
	public void SetQuaternion(int id, Quaternion value) { }

	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	public void SetTrigger(int id) { }

	public void SetTrigger(string name) { }

	[FreeFunction]
	private void SetTriggerID(int id) { }

	[FreeFunction]
	private void SetTriggerString(string name) { }

	[Obsolete]
	public void SetVector(string name, Vector3 value) { }

	[Obsolete]
	public void SetVector(int id, Vector3 value) { }

	public void StartPlayback() { }

	public void StartRecording(int frameCount) { }

	public void StopPlayback() { }

	public void StopRecording() { }

	[NativeMethod]
	public static int StringToHash(string name) { }

	[NativeMethod]
	public void Update(float deltaTime) { }

	[NativeConditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void WriteDefaultPose() { }

	[FreeFunction]
	public void WriteDefaultValues() { }

}

