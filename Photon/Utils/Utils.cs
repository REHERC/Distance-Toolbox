using System.IO;
using Photon.Globals;

namespace Photon
{
    public static class Utils
    {
        public static bool IsSpectrumInstalled()
        {
            if (!IsDistanceDirValid())
                return false;

            string BaseDir = $@"{Settings.General.Data.GameDir}\Distance_Data";

            if (!File.Exists($@"{BaseDir}\Managed\Spectrum.Bootstrap.dll"))
                return false;
            if (!Directory.Exists($@"{BaseDir}\Spectrum"))
                return false;
            if (!File.Exists($@"{BaseDir}\Spectrum\Spectrum.API.dll"))
                return false;
            if (!File.Exists($@"{BaseDir}\Spectrum\Spectrum.Interop.dll"))
                return false;
            if (!File.Exists($@"{BaseDir}\Spectrum\Spectrum.Manager.dll"))
                return false;
            return true;
        }

        public static bool IsDistanceDirValid()
        {
            string BaseDir = Settings.General.Data.GameDir;

            if (!Directory.Exists(BaseDir))
                return false;
            if (!Directory.Exists($@"{BaseDir}\Distance_Data"))
                return false;
            if (!File.Exists($@"{BaseDir}\Distance.exe"))
                return false;
            if (!Directory.Exists($@"{BaseDir}\Distance_Data\Managed"))
                return false;
            return true;
        }
    }
}
