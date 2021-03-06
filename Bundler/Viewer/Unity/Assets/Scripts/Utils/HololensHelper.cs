﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

public static class HololensHelper
{ 
    public static bool IsDeviceHololens()
    {
        return SystemInfo.deviceModel.Contains("HoloLens");
    }
}
