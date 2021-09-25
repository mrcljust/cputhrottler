using System;
using System.Runtime.InteropServices;

namespace CPUThrottler
{
    internal static class WinApi
    {
        public enum AccessFlags : uint
        {
            AccessScheme = 16, // 0x00000010
            AccessSubgroup = 17, // 0x00000011
            AccessIndividualSetting = 18 // 0x00000012
        }

        [DllImport("PowrProf.dll")]
        public static extern uint PowerEnumerate(
            IntPtr rootPowerKey,
            IntPtr schemeGuid,
            IntPtr subGroupOfPowerSettingGuid,
            uint acessFlags,
            uint index,
            ref Guid buffer,
            ref uint bufferSize);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerReadFriendlyName(
            IntPtr rootPowerKey,
            ref Guid schemeGuid,
            IntPtr subGroupOfPowerSettingGuid,
            IntPtr powerSettingGuid,
            IntPtr buffer,
            ref uint bufferSize);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerGetActiveScheme(
            IntPtr userRootPowerKey,
            ref IntPtr activePolicyGuid);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerSetActiveScheme(IntPtr userRootPowerKey, ref Guid schemeGuid);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerWriteACValueIndex(
            IntPtr rootPowerKey,
            ref Guid schemeGuid,
            ref Guid subGroupOfPowerSettingGuid,
            ref Guid powerSettingGuid,
            uint acValueIndex);
    }
}