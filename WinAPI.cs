using System;
using System.Runtime.InteropServices;

namespace CPUThrottler
{
    internal static class WinAPI
    {
        [DllImport("PowrProf.dll")]
        public static extern uint PowerEnumerate(
          IntPtr RootPowerKey,
          IntPtr SchemeGuid,
          IntPtr SubGroupOfPowerSettingGuid,
          uint AcessFlags,
          uint Index,
          ref Guid Buffer,
          ref uint BufferSize);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerReadFriendlyName(
          IntPtr RootPowerKey,
          ref Guid SchemeGuid,
          IntPtr SubGroupOfPowerSettingGuid,
          IntPtr PowerSettingGuid,
          IntPtr Buffer,
          ref uint BufferSize);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerGetActiveScheme(
          IntPtr UserRootPowerKey,
          ref IntPtr ActivePolicyGuid);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerSetActiveScheme(IntPtr UserRootPowerKey, ref Guid SchemeGuid);

        [DllImport("PowrProf.dll")]
        public static extern uint PowerWriteACValueIndex(
          IntPtr RootPowerKey,
          ref Guid SchemeGuid,
          ref Guid SubGroupOfPowerSettingGuid,
          ref Guid PowerSettingGuid,
          uint AcValueIndex);

        public enum AccessFlags : uint
        {
            ACCESS_SCHEME = 16, // 0x00000010
            ACCESS_SUBGROUP = 17, // 0x00000011
            ACCESS_INDIVIDUAL_SETTING = 18, // 0x00000012
        }
    }
}
