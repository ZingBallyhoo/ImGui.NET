using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImFontConfig
    {
        public void* FontData;
        public int FontDataSize;
        public byte FontDataOwnedByAtlas;
        public byte MergeMode;
        public byte PixelSnapH;
        public byte PixelSnapV;
        public int FontNo;
        public int OversampleH;
        public int OversampleV;
        public float SizePixels;
        public Vector2 GlyphOffset;
        public ushort* GlyphRanges;
        public ushort* GlyphExcludeRanges;
        public float GlyphMinAdvanceX;
        public float GlyphMaxAdvanceX;
        public float GlyphExtraAdvanceX;
        public uint FontBuilderFlags;
        public float RasterizerMultiply;
        public float RasterizerDensity;
        public ushort EllipsisChar;
        public fixed byte Name[40];
        public ImFontFlags Flags;
        public ImFont* DstFont;
        public IntPtr* FontLoader;
        public void* FontLoaderData;
    }
    public unsafe partial struct ImFontConfigPtr
    {
        public ImFontConfig* NativePtr { get; }
        public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
        public ImFontConfigPtr(IntPtr nativePtr) => NativePtr = (ImFontConfig*)nativePtr;
        public static implicit operator ImFontConfigPtr(ImFontConfig* nativePtr) => new ImFontConfigPtr(nativePtr);
        public static implicit operator ImFontConfig* (ImFontConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImFontConfigPtr(IntPtr nativePtr) => new ImFontConfigPtr(nativePtr);
        public IntPtr FontData { get => (IntPtr)NativePtr->FontData; set => NativePtr->FontData = (void*)value; }
        public ref int FontDataSize => ref Unsafe.AsRef<int>(&NativePtr->FontDataSize);
        public ref bool FontDataOwnedByAtlas => ref Unsafe.AsRef<bool>(&NativePtr->FontDataOwnedByAtlas);
        public ref bool MergeMode => ref Unsafe.AsRef<bool>(&NativePtr->MergeMode);
        public ref bool PixelSnapH => ref Unsafe.AsRef<bool>(&NativePtr->PixelSnapH);
        public ref bool PixelSnapV => ref Unsafe.AsRef<bool>(&NativePtr->PixelSnapV);
        public ref int FontNo => ref Unsafe.AsRef<int>(&NativePtr->FontNo);
        public ref int OversampleH => ref Unsafe.AsRef<int>(&NativePtr->OversampleH);
        public ref int OversampleV => ref Unsafe.AsRef<int>(&NativePtr->OversampleV);
        public ref float SizePixels => ref Unsafe.AsRef<float>(&NativePtr->SizePixels);
        public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);
        public IntPtr GlyphRanges { get => (IntPtr)NativePtr->GlyphRanges; set => NativePtr->GlyphRanges = (ushort*)value; }
        public IntPtr GlyphExcludeRanges { get => (IntPtr)NativePtr->GlyphExcludeRanges; set => NativePtr->GlyphExcludeRanges = (ushort*)value; }
        public ref float GlyphMinAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMinAdvanceX);
        public ref float GlyphMaxAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMaxAdvanceX);
        public ref float GlyphExtraAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphExtraAdvanceX);
        public ref uint FontBuilderFlags => ref Unsafe.AsRef<uint>(&NativePtr->FontBuilderFlags);
        public ref float RasterizerMultiply => ref Unsafe.AsRef<float>(&NativePtr->RasterizerMultiply);
        public ref float RasterizerDensity => ref Unsafe.AsRef<float>(&NativePtr->RasterizerDensity);
        public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
        public RangeAccessor<byte> Name => new RangeAccessor<byte>(NativePtr->Name, 40);
        public ref ImFontFlags Flags => ref Unsafe.AsRef<ImFontFlags>(&NativePtr->Flags);
        public ImFontPtr DstFont => new ImFontPtr(NativePtr->DstFont);
        public IntPtr FontLoader { get => (IntPtr)NativePtr->FontLoader; set => NativePtr->FontLoader = (IntPtr*)value; }
        public IntPtr FontLoaderData { get => (IntPtr)NativePtr->FontLoaderData; set => NativePtr->FontLoaderData = (void*)value; }
        public void Destroy()
        {
            ImGuiNative.ImFontConfig_destroy((ImFontConfig*)(NativePtr));
        }
    }
}
