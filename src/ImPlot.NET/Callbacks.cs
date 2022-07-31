namespace ImPlotNET
{
    public unsafe delegate int ImPlotFormatter(double value, char* buff, int size, void* user_data);
    public unsafe delegate ImPlotPoint ImPlotGetter(int idx, void* user_data);
    public unsafe delegate double ImPlotTransform(double value, void* user_data);
}