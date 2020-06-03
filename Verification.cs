using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;

namespace BaseProject
{
    class Verification
    {
        public static StrongName ThisAppStrongName { get; set; }

        public static bool isSignedPlugin(Assembly plugin)
        {
            StrongName assemblyStrongName = GetStrongName(plugin);

            if (assemblyStrongName == null)
            {
                return false;
            }

            if (assemblyStrongName.PublicKey.Equals(ThisAppStrongName.PublicKey))
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }

        public static StrongName GetStrongName(Assembly assembly)
        {
            AssemblyName assemblyName = assembly.GetName();

            byte[] publicKey = assemblyName.GetPublicKey();
            if (publicKey == null || publicKey.Length == 0)
            {
                return null;
            }

            StrongNamePublicKeyBlob keyBlob = new StrongNamePublicKeyBlob(publicKey);
            return new StrongName(keyBlob, assemblyName.Name, assemblyName.Version);
        }
    }
}
