﻿namespace CSharpBicycleProject;
internal interface IBicycle
{
    IWheelInterface Wheel { get; }
    BikeColor FrameColor { get; set; }
    decimal Price { get; }
    string model { get; }
    int StartNumber { get; }

    void Paint(BikeColor color);
} // end interface

