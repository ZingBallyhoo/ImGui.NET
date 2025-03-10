using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImTextureID
    {
        public ulong _TexUserID;
        public ImTextureData* _TexData;
    }
    public unsafe partial struct ImTextureIDPtr
    {
        public ImTextureID* NativePtr { get; }
        public ImTextureIDPtr(ImTextureID* nativePtr) => NativePtr = nativePtr;
        public ImTextureIDPtr(IntPtr nativePtr) => NativePtr = (ImTextureID*)nativePtr;
        public static implicit operator ImTextureIDPtr(ImTextureID* nativePtr) => new ImTextureIDPtr(nativePtr);
        public static implicit operator ImTextureID* (ImTextureIDPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImTextureIDPtr(IntPtr nativePtr) => new ImTextureIDPtr(nativePtr);
        public ref ulong _TexUserID => ref Unsafe.AsRef<ulong>(&NativePtr->_TexUserID);
        public ImTextureDataPtr _TexData => new ImTextureDataPtr(NativePtr->_TexData);
        public void Destroy()
        {
            ImGuiNative.ImTextureID_destroy((ImTextureID*)(NativePtr));
        }
    }
}
