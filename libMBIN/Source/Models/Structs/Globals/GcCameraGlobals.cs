namespace libMBIN.Models.Structs
{
    public class GcCameraGlobals : NMSTemplate
    {
        /* 0x0000 */ public float TogglePerspectiveBlendTime;
        /* 0x0004 */ public float ThirdPersonAfterIntroCamBlendTime;
        /* 0x0008 */ public float ThirdPersonSkipIntroCamBlendTime;
        /* 0x000C */ public float ShipThirdPersonBlendTime;
        /* 0x0010 */ public float ShipThirdPersonBlendOffset;
        /* 0x0014 */ public float ShipFirstPersonBlendTime;
        /* 0x0018 */ public float ShipFirstPersonBlendOffset;
        /* 0x001C */ public float FlybyMinRange;
        /* 0x0020 */ public float FlybyRange;
        /* 0x0024 */ public float FlybyMinRelativeSpeed;
        /* 0x0028 */ public float FlybyRelativeSpeedRange;
        /* 0x002C */ public float FlybyInVehicleDamper;
        /* 0x0030 */ public float BinocularFlashTime;
        /* 0x0034 */ public float BinocularFlashStrength;
        /* 0x0038 */ public float MinFirstPersonCameraPitch;
        /* 0x003C */ public float MaxFirstPersonCameraPitch;
        /* 0x0040 */ public GcCameraFollowSettings CharacterUnarmedCam;
        /* 0x0120 */ public GcCameraFollowSettings CharacterRunCam;
        /* 0x0200 */ public GcCameraFollowSettings CharacterCombatCam;
        /* 0x02E0 */ public GcCameraFollowSettings CharacterIndoorCam;
        /* 0x03C0 */ public GcCameraFollowSettings CharacterAirborneCam;
        /* 0x04A0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        /* 0x0580 */ public GcCameraFollowSettings CharacterFallingCam;
        /* 0x0660 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        /* 0x0740 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        /* 0x0820 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        /* 0x0900 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0904 */ public byte[] Padding904;
        /* 0x0908 */ public GcCameraFollowSettings BuggyFollowCam;
        /* 0x09E8 */ public GcCameraFollowSettings BikeFollowCam;
        /* 0x0AC8 */ public GcCameraFollowSettings TruckFollowCam;
        /* 0x0BA8 */ public GcCameraFollowSettings SpaceshipFollowCam;
        /* 0x0C88 */ public GcCameraFollowSettings DropshipFollowCam;
        /* 0x0D68 */ public GcCameraFollowSettings ShuttleFollowCam;
        /* 0x0E48 */ public GcCameraFollowSettings RoyalShipFollowCam;
        /* 0x0F28 */ public GcCameraFollowSettings ScienceShipFollowCam;
        /* 0x1008 */ public float FrontendModelCameraSpringTime;
        /* 0x100C */ public float ModelViewFlashTime;
        /* 0x1010 */ public Vector4f ModelViewOffset;
        /* 0x1020 */ public Vector2f ModelViewFocusOffset;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1028 */ public byte[] Padding1028;
        /* 0x1030 */ public Vector4f InteractionOffset;
        /* 0x1040 */ public Vector4f InteractionShipFocusOffset;
        /* 0x1050 */ public float DistanceForFleetInteraction;
        /* 0x1054 */ public float DistanceForFrigateInteraction;
        /* 0x1058 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x105C */ public byte[] Padding105C;
        /* 0x1060 */ public Vector4f OffsetForFleetInteraction;
        /* 0x1070 */ public Vector4f OffsetForFrigateInteraction;
        /* 0x1080 */ public float FleetUIOrbitRate;
        /* 0x1084 */ public float FleetUIVerticalMotionDuration;
        /* 0x1088 */ public float FleetUIVerticalMotionAmplitude;
        /* 0x108C */ public Vector2f PitchForFrigateInteraction;
        /* 0x1094 */ public Vector2f RotationForFrigateInteraction;
        /* 0x109C */ public float InteractionModeBlendTime;
        /* 0x10A0 */ public float InteractionModeFocusCamBlend;
        /* 0x10A4 */ public float InteractionModeFoV;
        /* 0x10A8 */ public float MinInteractFocusAngle;
        /* 0x10AC */ public float ModelViewInterpTime;
        /* 0x10B0 */ public float ThirdPersonBlendInTime;
        /* 0x10B4 */ public float ThirdPersonBlendOutTime;
        /* 0x10B8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        /* 0x10BC */ public float ThirdPersonOffsetSpringTime;
        /* 0x10C0 */ public bool MaxBob;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x10C1 */ public byte[] Padding10C1;
        /* 0x10C4 */ public float PhotoModeMoveSpeed;
        /* 0x10C8 */ public float PhotoModeTurnSpeed;
        /* 0x10CC */ public float PhotoModeMaxDistance;
        /* 0x10D0 */ public float PhotoModeMaxDistanceSpace;
        /* 0x10D4 */ public float PhotoModeMaxDistanceClampForce;
        /* 0x10D8 */ public float PhotoModeMaxDistanceClampBuffer;
        /* 0x10DC */ public float PhotoModeCollisionRadius;
        /* 0x10E0 */ public float PhotoModeRollSpeed;
        /* 0x10E4 */ public float PhotoModeFlashDuration;
        /* 0x10E8 */ public float PhotoModeFlashIntensity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x10EC */ public byte[] Padding10EC;
        /* 0x10F0 */ public Vector4f PhotoModeShipOffset;
        /* 0x1100 */ public float RunningFoVAdjust;
        /* 0x1104 */ public float MeleeBoostedFoV;
        /* 0x1108 */ public float MeleeFoV;
        /* 0x110C */ public float AerialViewDownDistance;
        /* 0x1110 */ public float AerialViewPause;
        /* 0x1114 */ public float AerialViewStartTime;
        /* 0x1118 */ public float AerialViewBackTime;
        /* 0x111C */ public float AerialViewBlendTime;
        /* 0x1120 */ public TkCurveType AerialViewCurve;
        /* 0x1124 */ public GcCameraAerialViewData BeaconTransition;
        /* 0x1154 */ public GcCameraAerialViewData SignalTransition;
        /* 0x1184 */ public GcCameraAerialViewData WaypointTransition;
        /* 0x11B4 */ public GcCameraAerialViewData RadioTowerTransition;
        /* 0x11E4 */ public float ScreenshotHorizonHeight;
        /* 0x11E8 */ public float ScreenshotHorizonFaceFactor;
        /* 0x11EC */ public float ScreenshotBendDownAmount;
        /* 0x11F0 */ public float ScreenshotRightDistance;
        /* 0x11F4 */ public float ScreenshotBackDistance;
        /* 0x11F8 */ public float ScreenshotInTime;
        /* 0x11FC */ public float ScreenshotOutTime;
        /* 0x1200 */ public float ShipCamSpringStrengthMin;
        /* 0x1204 */ public float ShipCamSpringStrengthMax;
        /* 0x1208 */ public float ShipCamTurn;
        /* 0x120C */ public float ShipCamPitch;
        /* 0x1210 */ public float ShipCamPitchMod;
        /* 0x1214 */ public float ShipCamLookInterp;
        /* 0x1218 */ public float ShipCamMinReturnTime;
        /* 0x121C */ public float ShipCamReturnTime;
        /* 0x1220 */ public float ShipCamMotionTurn;
        /* 0x1224 */ public float ShipCamMotionPitch;
        /* 0x1228 */ public float ShipCamMotionPitchMod;
        /* 0x122C */ public float ShipCamMotionMaxLagTurnAngle;
        /* 0x1230 */ public float ShipCamMotionMaxLagPitchAngle;
        /* 0x1234 */ public float ShipCamMotionInterp;
        /* 0x1238 */ public float ShipCamRollAmountMin;
        /* 0x123C */ public float ShipCamRollAmountMax;
        /* 0x1240 */ public float ShipCamRollSpeedScaler;
        /* 0x1244 */ public float ShipCamAimFOV;
        /* 0x1248 */ public float MouseSensitivity;
        /* 0x124C */ public float ModelViewRotateSpeed;
        /* 0x1250 */ public float ModelViewMouseRotateSpeed;
        /* 0x1254 */ public float ModelViewMouseRotateSnapStrength;
        /* 0x1258 */ public float ModelViewMouseMoveSpeed;
        /* 0x125C */ public float ModelViewDistSpeed;
        /* 0x1260 */ public float ModelViewMinDist;
        /* 0x1264 */ public float ModelViewMaxDist;
        /* 0x1268 */ public float ModelViewDefaultPitch;
        /* 0x126C */ public float ModelViewDefaultYaw;
        /* 0x1270 */ public bool DebugMoveCam;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1271 */ public byte[] Padding1271;
        /* 0x1274 */ public float DebugMoveCamSpeed;
        /* 0x1278 */ public float DebugMoveCamHeight;
        /* 0x127C */ public bool DebugAICam;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x127D */ public byte[] Padding127D;
        /* 0x1280 */ public float DebugAICamUp;
        /* 0x1284 */ public float DebugAICamAt;
        /* 0x1288 */ public float PainShakeTime;
        /* 0x128C */ public float ShipShakeDamper;
        /* 0x1290 */ public float IndoorCamShakeDamper;
        /* 0x1294 */ public float FirstPersonSlerpAway;
        /* 0x1298 */ public float FirstPersonSlerpTowards;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x129C */ public byte[] Padding129C;
        [NMS(Size = 0x1E)]
        /* 0x12A0 */ public GcCameraShakeData[] CameraShakeTable;
        /* 0x2920 */ public float BobAmount;
        /* 0x2924 */ public float BobFactor;
        /* 0x2928 */ public float BobFocus;
        /* 0x292C */ public float BobRollFactor;
        /* 0x2930 */ public float BobRollAmount;
        /* 0x2934 */ public float BobRollOffset;
        /* 0x2938 */ public float BobFwdAmount;
        /* 0x293C */ public float CamSeed1;
        /* 0x2940 */ public float CamSeed2;
        /* 0x2944 */ public float CamWander1Phase;
        /* 0x2948 */ public float CamWander2Phase;
        /* 0x294C */ public float CamWander1Amplitude;
        /* 0x2950 */ public float CamWander2Amplitude;
        /* 0x2954 */ public float DebugSpaceStationTeleportOffset;
        /* 0x2958 */ public float DebugCameraSlowFactor;
        /* 0x295C */ public float DebugCameraFastFactor;
        /* 0x2960 */ public float DebugCameraSpaceFastFactor;
        /* 0x2964 */ public float OffsetCamFOV;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2968 */ public byte[] Padding2968;
        /* 0x2970 */ public Vector4f OffsetCamOffset;
        /* 0x2980 */ public Vector4f OffsetCamRotation;
        /* 0x2990 */ public float ObjectFocusTime;
        /* 0x2994 */ public float CharCamFocusHeight;
        /* 0x2998 */ public float CharCamMaxDistance;
        /* 0x299C */ public float CharCamMinDistance;
        /* 0x29A0 */ public float CharCamHeight;
        /* 0x29A4 */ public float CharCamOffsetTime;
        /* 0x29A8 */ public float CharCamAutoDirStartTime;
        /* 0x29AC */ public float CharCamLookOffset;
        /* 0x29B0 */ public float CharCamLookOffsetFactor;
        /* 0x29B4 */ public float CharCamDeflectSpeed;
        /* 0x29B8 */ public float CharCamMinSpeed;
        /* 0x29BC */ public float CharCamRightStickX;
        /* 0x29C0 */ public float CharCamRightStickY;
        /* 0x29C4 */ public float FirstPersonCamHeight;
        /* 0x29C8 */ public float FirstPersonFoV;
        /* 0x29CC */ public float ThirdPersonFoV;
        /* 0x29D0 */ public float FirstPersonZoom1FoV;
        /* 0x29D4 */ public float FirstPersonZoom2FoV;
        /* 0x29D8 */ public float ShipFoVMin;
        /* 0x29DC */ public float ShipFoVMin2;
        /* 0x29E0 */ public float ShipFoVMax;
        /* 0x29E4 */ public float ShipWarpFoV;
        /* 0x29E8 */ public float ShipFoVMin3rdPerson;
        /* 0x29EC */ public float ShipFoVMax3rdPerson;
        /* 0x29F0 */ public float ShipFoVBoost;
        /* 0x29F4 */ public float ShipFoVMiniJump;
        /* 0x29F8 */ public float ShipFoVSpring;
        /* 0x29FC */ public float ShipMiniJumpFoVSpring;
        /* 0x2A00 */ public float FoVSpring;
        /* 0x2A04 */ public float FoVAdjust;
        /* 0x2A08 */ public bool FollowDrawCamProbes;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2A09 */ public byte[] Padding2A09;
        /* 0x2A0C */ public GcCameraAnimationData CameraAnimations;
        /* 0x2A90 */ public GcCameraAnimationData AmbientDroneAnimations;
        [NMS(Size = 0x80)]
        /* 0x2B14 */ public string CameraAmbientAnimationsData;
        /* 0x2B94 */ public float CameraAmbientAutoSwitchMinTime;
        /* 0x2B98 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2B9C */ public byte[] Padding2B9C;
        /* 0x2BA0 */ public TkModelRendererData CameraNPCShipInteraction;
        /* 0x2C50 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Size = 0x4)]
        /* 0x2D00 */ public Vector4f[] SavedCameraPositions;
        [NMS(Size = 0x40, Ignore = true)]
        /* 0x2D40 */ public byte[] Padding2D40;
        [NMS(Size = 0x4)]
        /* 0x2D80 */ public Vector4f[] SavedCameraFacing;
        /* 0x2DC0 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2E14 */ public byte[] EndPadding;
    }
}
