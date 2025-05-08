
using UnityEngine;

namespace SxxMyFirstUPM {
    public static class SxxDebug {
        public static void Log(string message) {
            Debug.Log($"[MyPackage] {message}");
        }
    }
}