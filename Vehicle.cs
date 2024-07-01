﻿public interface IVehicle
{
    string Make { get; set; }
    string Model { get; set; }
    int Year { get; set; }

    void Start();
    void Stop();
}
