using UnityEngine;

namespace PlatformerMVC
{
    public static class Utils
    {

        public static Vector3 Change (this Vector3 org, object x = null, object y = null, object z = null)
        {
            return new Vector3(x == null ? org.x : (float)x, y == null ? org.y : (float)y, z == null ? org.z : (float)z);
        }

    }//End Class
}//End namespace
